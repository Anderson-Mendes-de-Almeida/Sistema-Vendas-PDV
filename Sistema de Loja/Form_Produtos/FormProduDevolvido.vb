Imports System.Data.OleDb

Public Class FormProduDevolvido
    Dim intNuNota As Integer


    Private Sub BtLimpa_Click(sender As Object, e As EventArgs) Handles BtLimpa.Click


        Try

            txtNuNota.Focus()

            'Limpando ListBox
            LtTelaVenda.Items.RemoveAt(0)

            LtTelaVenda.Enabled = True

            txtNuNota.Enabled = True
            BtLimpa.Enabled = False

            'Aqqui limpamos o ListView2,,, LTTelaVenda2

            Dim contador As Integer = Me.LtTelaVenda.Items.Count

            For index = 1 To contador
                LtTelaVenda.Items.RemoveAt(0)

            Next


            txtNuNota.Focus()
            txtMotivoDevol.Text = ""

            lblTotalProd.Text = ""
        Catch ex As Exception

            Return
            txtNuNota.Focus()

        End Try
    End Sub

    Private Sub FormProduDevolvido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNuNota.Select()




    End Sub

    Private Sub txtNuNota_TextChanged(sender As Object, e As EventArgs) Handles txtNuNota.TextChanged
        ' Me.txtNuNota.TabIndex = 0

    End Sub

    Private Sub txtNuNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuNota.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True




        End If
        If Asc(e.KeyChar) = 13 Then

            BtLimpa.Enabled = True

            Try

                intNuNota = txtNuNota.Text


            Catch ex As Exception
                Return

            End Try

            Try


                Dim con As New OleDbConnection
                Dim Leitor As OleDbDataReader

                con.ConnectionString = My.Settings.CN1
                con.Open()

                Dim SQL As String = "Select * FROM TBDevolucao WHERE codigovenda= " & intNuNota

                Dim comando As New OleDbCommand(SQL, con)
                Dim da As New OleDbDataAdapter(comando)
                Dim dt As New DataTable
                Dim ds As New DataSet

                da.Fill(dt)
                da.Fill(ds, "TBDevolucao")

                Leitor = comando.ExecuteReader

                Dim count As Integer = dt.Rows.Count

                'Nesse bloco de codigo testo para ver se o numero da nota existe
                If count <= 0 Then
                    MessageBox.Show("Produto não Existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtNuNota.Text = ""
                    txtNuNota.Focus()

                    Return

                End If

                For index = 1 To count
                    Leitor.Read()

                    Dim item As New ListViewItem(Leitor("Produto").ToString)

                    item.SubItems.Add(Leitor("codigovenda")).ToString()
                    item.SubItems.Add(Leitor("codbarras")).ToString()
                    item.SubItems.Add(Leitor("qtd")).ToString()
                    item.SubItems.Add(FormatCurrency(Leitor("vlruni")).ToString())
                    item.SubItems.Add(Leitor("datacancel")).ToString()
                    txtMotivoDevol.Text = (Leitor("motivo")).ToString()
                    LtTelaVenda.Items.Add(item)

                    'Dim item As New ListViewItem(Leitor("Produto").ToString)
                    'item.SubItems.Add(Leitor("codigovenda")).ToString()
                    'item.SubItems.Add(Leitor("codbarras")).ToString()
                    'item.SubItems.Add(Leitor("qtd")).ToString()
                    'item.SubItems.Add(FormatCurrency(Leitor("vlruni")).ToString())
                    'item.SubItems.Add(Leitor("datacancel")).ToString()
                    'txtMotivoDevol.Text = (Leitor("motivo")).ToString()
                    'LtTelaVenda.Items.Add(item)
                Next

                lblTotalProd.Text = count

                'liberando espaço
                Leitor.Dispose()
                Leitor.Close()
                comando.Dispose()


            Catch ex As Exception
                MessageBox.Show("Produto não Existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtNuNota.Clear()
                Return


            End Try

            txtNuNota.Text = ""
            txtNuNota.Focus()
            txtNuNota.Enabled = False



        End If



    End Sub

    Private Sub btnCancelarVend_Click(sender As Object, e As EventArgs) Handles btnCancelarVend.Click
        Me.Close()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Try

            Dim con As New OleDbConnection
            con.ConnectionString = My.Settings.CN1
            con.Open()

            Dim sql As String = "UPDATE TBDevolucao SET Motivo=? WHERE codigovenda=" & intNuNota
            Dim Comando As New OleDbCommand(sql, con)

            Comando.Parameters.Clear()
            Comando.Parameters.Add(New OleDb.OleDbParameter("@Motivo", txtMotivoDevol.Text))

            Comando.ExecuteNonQuery()

            MessageBox.Show("Produto Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'txtPesquisaProdEntr.Clear()
            'txtEditeDescric.Clear()

            'txtPesquisaProdEntr.Focus()
            'btnAtualizar.Enabled = False

            'txtPreco.Clear()
            'txtPrecoVenda.Clear()

            con.Close()
            Comando.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txtMotivoDevol.Clear()
        LtTelaVenda.Clear()
        Me.Close()



    End Sub
End Class