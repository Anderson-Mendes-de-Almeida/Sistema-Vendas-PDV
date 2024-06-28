Imports System.Data
Imports System.Data.OleDb


Public Class FormCadastroProdut

    Private Sub InsertTBEntrada()

        Try

            'hora atual sistema para Banco de Dados
            Dim HoraCadastro As Date = Now

            If txtCodBarras.Text = "" Then
                MessageBox.Show("Digite o Código Barras do produto!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1

            Con.Open()


            Dim Comando As New OleDbCommand
            Comando.CommandText = "INSERT INTO TBEntrada (CodBarras, DescrProduto, ValorUnitario, Qtd_Entrada, ValorTotEntrada, DataEntrada )" & " VALUES (?, ?, ?, ?, ?,?)"

            Comando.Parameters.Clear()
            Comando.Parameters.Add("@descProduto", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtCodBarras.Text
            Comando.Parameters.Add("@descProduto", System.Data.OleDb.OleDbType.VarChar, 80).Value = txtDescricao.Text
            Comando.Parameters.Add("@ValorUnitario", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtunidade.Text
            Comando.Parameters.Add("@Qtd_Entrada", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtEm_Estoque.Text
            Comando.Parameters.Add("@ValorTotEntrada", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtValorTotalEntrad.Text
            Comando.Parameters.Add("@DataEntrada", System.Data.OleDb.OleDbType.Date, 13).Value = HoraCadastro

            Comando.CommandType = CommandType.Text


            Comando.Connection = Con

            Comando.ExecuteNonQuery()


            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub



    Private Sub CodBarrasExist()

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim sql2 As String = "SELECT CodBarras FROM TBProduto WHERE CodBarras=" & txtCodBarras.Text

            Dim Comando2 As New OleDbCommand(sql2, Con)

            Dim Leitor As OleDbDataReader
            Leitor = Comando2.ExecuteReader

            Leitor.Read()

            Dim douCodBarras As Double

            douCodBarras = Leitor("CodBarras")

            If douCodBarras = txtCodBarras.Text Then

                MessageBox.Show("Produto Ja Cadastrado!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtCodBarras.Focus()
                txtCodBarras.Clear()

                Return


            End If

        Catch ex As Exception
            txtDescricao.Focus()

        End Try

    End Sub
    Private Sub LimpaCampos()

        txtCodBarras.Clear()
        txtDescricao.Clear()
        txtunidade.Clear()
        txtVlrVenda.Clear()
        txtEm_Estoque.Clear()
        txtValorTotalEntrad.Clear()
        txtEm_Estoque.Clear()
        txtQtdMinEsto.Clear()

        txtCodBarras.Focus()

    End Sub


    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Me.Close()

    End Sub

    Private Sub FormCadastroProdut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

        Try
            'hora atual sistema para Banco de Dados
            Dim HoraCadastro As Date = Now

            If txtCodBarras.Text = "" Then
                MessageBox.Show("Digite o Código Barras do produto!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1

            Con.Open()


            Dim Comando As New OleDbCommand
            Comando.CommandText = "INSERT INTO TBProduto (codbarras, descProduto, vlr_Unidade, Vlr_Venda, qtd_Entrada, Vlr_TotalEntrada, Em_Estoque, Estoque_minimo, data_compra)" & " VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

            Comando.Parameters.Clear()
            Comando.Parameters.Add("@codbarras", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtCodBarras.Text
            Comando.Parameters.Add("@descProduto", System.Data.OleDb.OleDbType.VarChar, 200).Value = txtDescricao.Text
            Comando.Parameters.Add("@vlr_Unidade", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtunidade.Text
            Comando.Parameters.Add("@vlr_Venda", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtVlrVenda.Text
            Comando.Parameters.Add("@qtd_Entrada", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtEm_Estoque.Text
            Comando.Parameters.Add("@Vlr_TotalEntrada", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtValorTotalEntrad.Text
            Comando.Parameters.Add("@Em_estoque", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtEm_Estoque.Text
            Comando.Parameters.Add("@Estoque_minimo", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtQtdMinEsto.Text
            Comando.Parameters.Add("@data_compra", System.Data.OleDb.OleDbType.Date, 13).Value = HoraCadastro


            Comando.CommandType = CommandType.Text


            Comando.Connection = Con

            Comando.ExecuteNonQuery()


            Con.Close()
            Comando.Dispose()

            'Procedure para Insert TBEntrada
            InsertTBEntrada()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        MessageBox.Show("Produto Cadastrado com Sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim result As Integer = 0
        result = MessageBox.Show("Deseja Incluir Mais Produtos?", "AVISO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then

            LimpaCampos()

            Return
        Else


            Me.Close()

            'Aqui crio objeto e referencio, chamo o FormRelaProdutEsroque que esta invisivel
            'Dim Form As FormRelaProdutEstoq = FormRelaProdutEstoq
            'Form.ShowDialog()

            FormRelaProdutEstoq.Show()

        End If

        Form1.Close()


    End Sub

    Private Sub btCalcGanho_Click(sender As Object, e As EventArgs) Handles btCalcGanho.Click


    End Sub


    Private Sub txtunidade_Leave(sender As Object, e As EventArgs) Handles txtunidade.Leave
        If txtunidade.Text = String.Empty Then
            txtunidade.Text = 0

        End If
        txtunidade.Text = FormatCurrency(txtunidade.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub


    Private Sub txtValorTotalEntrad_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotalEntrad.TextChanged
        If txtValorTotalEntrad.Text = String.Empty Then
            txtValorTotalEntrad.Text = 0

        End If
        txtValorTotalEntrad.Text = FormatCurrency(txtValorTotalEntrad.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub


    Private Sub txtVlrVenda_LostFocus(sender As Object, e As EventArgs) Handles txtVlrVenda.LostFocus
        If txtVlrVenda.Text = String.Empty Then
            txtVlrVenda.Text = 0

        End If
        txtVlrVenda.Text = FormatCurrency(txtVlrVenda.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub txtQtdMinEsto_LostFocus(sender As Object, e As EventArgs) Handles txtQtdMinEsto.LostFocus
        ' ToolStripStatusLabel1.PerformClick()

    End Sub

    Private Sub txtCodBarras_Leave(sender As Object, e As EventArgs) Handles txtCodBarras.Leave
        'If txtCodBarras.Text = "" Then
        '    MessageBox.Show("Digite o Código de Barras", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtCodBarras.Focus()


        '    Return

        'End If
    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged



    End Sub

    Private Sub txtEm_Estoque_Leave(sender As Object, e As EventArgs) Handles txtEm_Estoque.Leave
        Try
            Dim VrTotalEntrad As Double

            VrTotalEntrad = txtunidade.Text * txtEm_Estoque.Text

            txtValorTotalEntrad.Text = VrTotalEntrad

        Catch ex As Exception
            MessageBox.Show("Digite a Quantidade de Produtos em Estoque", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtEm_Estoque.Focus()





        End Try
    End Sub

    Private Sub txtCodBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBarras.KeyPress

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            'Verificando se CodBarras ja existe
            CodBarrasExist()


            'aqui tiro o som
            e.Handled = True

        End If
    End Sub

    Private Sub txtQtdMinEsto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdMinEsto.KeyPress


    End Sub

    Private Sub txtQtdMinEsto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQtdMinEsto.KeyUp
        Try

            If (e.KeyCode = Keys.Enter) Then
                ToolStripStatusLabel1.PerformClick()

            ElseIf (e.KeyCode = Keys.Tab) Then
                txtQtdMinEsto.Focus()

            End If

        Catch ex As Exception

            Return


        End Try

    End Sub

    Private Sub txtCodBarras_MouseEnter(sender As Object, e As EventArgs) Handles txtCodBarras.MouseEnter

    End Sub

    Private Sub txtQtdMinEsto_TextChanged(sender As Object, e As EventArgs) Handles txtQtdMinEsto.TextChanged

    End Sub

    Private Sub txtunidade_TextChanged(sender As Object, e As EventArgs) Handles txtunidade.TextChanged

    End Sub
End Class