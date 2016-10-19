Imports System.Data
Imports System.Data.OleDb


Public Class FormCadastroProdut
    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Me.Close()

    End Sub

    Private Sub FormCadastroProdut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Try
            'hora sistema para Banco de Dados
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
                Comando.Parameters.Add("@descProduto", System.Data.OleDb.OleDbType.VarChar, 40).Value = txtDescricao.Text
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


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        MessageBox.Show("Produto Cadastrado com Sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()

        'Aqui crio objeto e referencio, chamo o FormRelaProdutEsroque que esta invisivel
        Dim Form As FormRelaProdutEstoq = FormRelaProdutEstoq
        Form.ShowDialog()




    End Sub

    Private Sub btCalcGanho_Click(sender As Object, e As EventArgs) Handles btCalcGanho.Click
        'Dim valor1 As Decimal
        'Dim valor2 As Decimal

        'valor1 = txtunidade.Text
        'valor2 = txtPorcentagem.Text

        'valorT = valor2 / 100
        'valorD = valorT * 100 / valor1

        'txtVlrVenda.Text = valorD





    End Sub

    Private Sub txtunidade_TextChanged(sender As Object, e As EventArgs) Handles txtunidade.TextChanged

    End Sub

    Private Sub txtVlrVenda_TextChanged(sender As Object, e As EventArgs) Handles txtVlrVenda.TextChanged

    End Sub

    Private Sub txtunidade_Leave(sender As Object, e As EventArgs) Handles txtunidade.Leave
        If txtunidade.Text = String.Empty Then
            txtunidade.Text = 0

        End If
        txtunidade.Text = FormatCurrency(txtunidade.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub FormCadastroProdut_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub txtEm_Estoque_TextChanged(sender As Object, e As EventArgs) Handles txtEm_Estoque.TextChanged

    End Sub

    Private Sub txtEm_Estoque_LostFocus(sender As Object, e As EventArgs) Handles txtEm_Estoque.LostFocus




    End Sub

    Private Sub txtValorTotalEntrad_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotalEntrad.TextChanged
        If txtValorTotalEntrad.Text = String.Empty Then
            txtValorTotalEntrad.Text = 0

        End If
        txtValorTotalEntrad.Text = FormatCurrency(txtValorTotalEntrad.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub txtValorTotalEntrad_LostFocus(sender As Object, e As EventArgs) Handles txtValorTotalEntrad.LostFocus

    End Sub

    Private Sub txtPorcentagem_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtValorTotalEntrad_Leave(sender As Object, e As EventArgs) Handles txtValorTotalEntrad.Leave

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtVlrVenda_Layout(sender As Object, e As LayoutEventArgs) Handles txtVlrVenda.Layout

    End Sub

    Private Sub txtunidade_Click(sender As Object, e As EventArgs) Handles txtunidade.Click

    End Sub

    Private Sub txtVlrVenda_Leave(sender As Object, e As EventArgs) Handles txtVlrVenda.Leave

    End Sub

    Private Sub txtVlrVenda_LostFocus(sender As Object, e As EventArgs) Handles txtVlrVenda.LostFocus
        If txtVlrVenda.Text = String.Empty Then
            txtVlrVenda.Text = 0

        End If
        txtVlrVenda.Text = FormatCurrency(txtVlrVenda.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub



    Private Sub txtCodBarras_LostFocus(sender As Object, e As EventArgs) Handles txtCodBarras.LostFocus


    End Sub

    Private Sub txtQtdMinEsto_TextChanged(sender As Object, e As EventArgs) Handles txtQtdMinEsto.TextChanged

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
            '  btnSalvarEntradaProd.PerformClick()
            txtDescricao.Focus()

            'aqui tiro o som
            e.Handled = True

        End If
    End Sub
End Class