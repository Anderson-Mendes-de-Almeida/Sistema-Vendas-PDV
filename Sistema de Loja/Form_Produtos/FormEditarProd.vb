Imports System.Data.OleDb




Public Class FormEditarProd
    Dim codigo As Integer = 0

    Private Sub Pesquisacodbarra2()
        btnAtualizar.Enabled = True

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codigo, descproduto, vlr_unidade, vlr_Venda FROM TBProduto Where codBarras LIKE '%" & Convert.ToInt64(txtPesquisaProdEntr.Text) & "%' "

            Dim comando As New OleDbCommand(SQL, Con)
            Dim Leitor As OleDbDataReader

            Leitor = comando.ExecuteReader
            Leitor.Read()

            codigo = Leitor("codigo")
            txtEditeDescric.Text = Leitor("descproduto").ToString
            txtPreco.Text = Leitor("vlr_unidade").ToString
            txtPrecoVenda.Text = Leitor("vlr_venda").ToString


            Leitor.Close()
            Con.Close()
            Con.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtPesquisaProdEntr_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdEntr.TextChanged

    End Sub

    Private Sub cbPesquisaEntr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisaEntr.SelectedIndexChanged
        Try
            txtPesquisaProdEntr.Enabled = True

        Catch ex As Exception

            Return

        End Try

        txtPesquisaProdEntr.Focus()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click, btnProcurar.Click
        Pesquisacodbarra2()
    End Sub

    Private Sub txtPesquisaProdEntr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesquisaProdEntr.KeyPress


    End Sub

    Private Sub txtPesquisaProdEntr_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPesquisaProdEntr.KeyUp

        If (e.KeyCode = Keys.Enter) Then

            btnProcurar.PerformClick()




        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim sql As String = "UPDATE TBProduto SET DescProduto=?, vlr_unidade=?, vlr_venda=? WHERE codigo=" & codigo
            Dim Comando As New OleDbCommand(sql, Con)

            Comando.Parameters.Clear()
            Comando.Parameters.Add(New OleDb.OleDbParameter("@DescProduto", txtEditeDescric.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@vlr_unidade", txtPreco.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@vlr_venda", txtPrecoVenda.Text))

            Comando.ExecuteNonQuery()

            MessageBox.Show("Produto Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtPesquisaProdEntr.Clear()
            txtEditeDescric.Clear()

            txtPesquisaProdEntr.Focus()
            btnAtualizar.Enabled = False

            txtPreco.Clear()
            txtPrecoVenda.Clear()


            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPreco_TextChanged(sender As Object, e As EventArgs) Handles txtPreco.TextChanged
        'Try
        '    txtPreco.Text = FormatCurrency(txtPreco.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub txtPrecoVenda_TextChanged(sender As Object, e As EventArgs) Handles txtPrecoVenda.TextChanged
        'Try
        '    txtPrecoVenda.Text = FormatCurrency(txtPrecoVenda.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub txtPrecoVenda_GotFocus(sender As Object, e As EventArgs) Handles txtPrecoVenda.GotFocus
        txtPrecoVenda.Text = FormatCurrency(txtPrecoVenda.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim



    End Sub

    Private Sub txtPrecoVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecoVenda.KeyPress

    End Sub

    Private Sub txtPreco_GotFocus(sender As Object, e As EventArgs) Handles txtPreco.GotFocus

        txtPreco.Text = FormatCurrency(txtPreco.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub txtPreco_LostFocus(sender As Object, e As EventArgs) Handles txtPreco.LostFocus

        txtPreco.Text = FormatCurrency(txtPreco.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub txtPrecoVenda_LostFocus(sender As Object, e As EventArgs) Handles txtPrecoVenda.LostFocus
        txtPrecoVenda.Text = FormatCurrency(txtPrecoVenda.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub
End Class