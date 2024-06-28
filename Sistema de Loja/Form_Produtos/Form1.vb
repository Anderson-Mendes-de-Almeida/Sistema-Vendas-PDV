Imports System.Data.OleDb
Imports Sistema_de_Loja.WsCotaDolar


Public Class Form1
    Dim intTotalReg As Integer
    Dim dtmesComp As String

    Private Sub VerificaimpressoLigada()

        Try
            System.IO.File.Copy("", "LPT1", True)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Verifique se a Impressora esta Desligada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub
    Private Sub CotacaoDolar()
        Try
            'Chama o WebService para retornar o valor
            Dim ws = New FachadaWSSGSClient

            'Através do código da moeda, atribui a variável valorCotacao o resultado da busca
            Dim valorcotacao = ws.getUltimosValoresSerieVO(1, 1).valores(0).svalor

            'Mostrar no txtValor o resultado
            lblcotacao.Text = "R$ " + valorcotacao

        Catch ex As Exception
            'Caso aconteça alguma excessão, mostra valor zerado
            lblcotacao.Text = "R$ 0.00"

        End Try



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rotina para cotação dolar
        CotacaoDolar()


        'botão para deletar todas as tabelas, kkkkkk
        Button9.Location = New Point(871, 210)

        ' VerificaimpressoLigada()

        Try


            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            '------------------------------Tabela Produtos-----------------------------------------

            'Dim comando As New OleDbCommand
            Dim Sql As String = " SELECT count(*) as c , sum(qtd_saida) as qtd_S FROM TBProduto "
            Dim comando As New OleDbCommand(Sql, Con)

            Dim Leitor As OleDbDataReader
            Leitor = comando.ExecuteReader
            Leitor.Read()


            lblProdutosVendidos.Text = Leitor("qtd_S").ToString
            'If Leitor("qtd_S") = Nothing Then

            '    MessageBox.Show("OK")
            'End If


            Leitor.Close()

            '---------------------------------------TBCliente---------------------------------------------

            comando.CommandText = " SELECT count(*) as a FROM TBCliente "

            Leitor = comando.ExecuteReader
            Leitor.Read()

            lblCountCli.Text = Leitor("a")

            Leitor.Close()


            '--------------------------------------TBFornecedores---------------------------------------------

            comando.CommandText = " SELECT count(*) as f FROM TBFornecedores "

            Leitor = comando.ExecuteReader
            Leitor.Read()

            lblCountForne.Text = Leitor("f")



            Leitor.Close()

            '--------------------------------------TBFuncionários----------------------------------------------

            comando.CommandText = " SELECT count(*) as f FROM TBFuncionario "

            Leitor = comando.ExecuteReader
            Leitor.Read()

            lblFuncionarios.Text = Leitor("f")

            Leitor.Close()


            '--------------------------------------TBProdutos---Contando Produtos em entrada---------------------------------------------------

            comando.CommandText = " SELECT count(*) as ent FROM TBProduto "

            Leitor = comando.ExecuteReader
            Leitor.Read()

            lblProdEntrada.Text = Leitor("ent")

            'intTotalReg = Leitor("ent")


            Leitor.Close()

            '---------------------------------------TBProdutos---Contando Produto em Estoque----------------------


            comando.CommandText = " SELECT sum(Em_Estoque) as EmEst FROM TBProduto "

            Leitor = comando.ExecuteReader
            Leitor.Read()

            lblProdEmEstoque.Text = Leitor("EmEst")

            Leitor.Close()

            '-----------------------------------------TBVendas---Contando total de vedas------------------------------

            comando.CommandText = " SELECT count(*) as ven FROM TBVendasHistorico "

            Leitor = comando.ExecuteReader

            Leitor.Read()

            intTotalReg = Leitor("ven")

            Leitor.Close()


            '----------------------------------------TBVendas retornando vendas data atual--------------------------------------------

            Dim mes As Integer = Now.Month

            comando.CommandText = " SELECT count(*) as c FROM TBProduVenda WHERE Month(datacompra) = " & mes

            Leitor = comando.ExecuteReader


            Leitor.Read()

            lblQtdMes.Text = Leitor("c")


            Leitor.Close()
            '-------------------------------------TBVendas-----Pegando o Total me R$ no Mês---------------------

            Dim mes2 As Integer = Now.Month

            'comando.CommandText = " SELECT sum(valorTotal) as vt FROM TBVendasHistorico WHERE Month(datacompra) = " & mes2

            'Leitor = comando.ExecuteReader

            'Leitor.Read()

            'lblTotalMesGrana.Text = FormatCurrency(Leitor("vt"), 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim


            Con.Close()
            Con.Dispose()
            comando.Dispose()
            Leitor.Close()



        Catch ex As Exception
            '      MessageBox.Show("Ainda Não Existe Nenhum Produto Cadastrado ou Vendido!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btRelaProdutEstoq_Click(sender As Object, e As EventArgs) Handles btRelaProdutEstoq.Click
        FormRelaProdutEstoq.Show()


    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        FormLogin.Close()
        FormLogin.Dispose()

    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles btCadastroFuncionarios.Click
        FormFuncionarios.Show()




    End Sub

    Private Sub btCadastroClientes_Click(sender As Object, e As EventArgs) Handles btCadastroClientes.Click
        FormCadasClinte.Show()




    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btTeleVendas.Click
        FormTelaVenda.Show()


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        btDataHora.Text = Now




    End Sub

    Private Sub btCadastroFornecedores_Click(sender As Object, e As EventArgs) Handles btCadastroFornecedores.Click
        FormCadasFornece.Show()

    End Sub

    Private Sub btCountCli_Click(sender As Object, e As EventArgs) Handles btCountCli.Click

    End Sub

    Private Sub btFornecedores_Click(sender As Object, e As EventArgs) Handles btFornecedores.Click

    End Sub

    Private Sub btVendasRealizadas_Click(sender As Object, e As EventArgs) Handles btVendasRealizadas.Click
        FormVendasRealisadas.Show()

    End Sub

    Private Sub lblQtdMes_Click(sender As Object, e As EventArgs) Handles lblQtdMes.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click

        FormBackup.ShowDialog()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        FormEditarProd.Show()

    End Sub

    Private Sub btContrVendMarcadas_Click(sender As Object, e As EventArgs) Handles btContrVendMarcadas.Click

        FormLogin.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormDevolucao.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btPedidos.Click

    End Sub

    Private Sub btControlesGastos_Click(sender As Object, e As EventArgs) Handles btControlesGastos.Click
        FormProduDevolvido.Show()



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        Me.Update()


    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        Me.Show()

    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(sender, e)

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        'Me.Controls.Clear()
        'InitializeComponent()
        'Form1_Load(sender, e)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim comando1 As New OleDbCommand
            Dim Con As New OleDbConnection
            Dim leitor1 As OleDbDataReader

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            comando1.CommandText = " DELETE FROM TBProduto"
            comando1.Connection = Con

            leitor1 = comando1.ExecuteReader

            leitor1.Read()

            Con.Dispose()
            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        '=========================================================================================
        Try
            Dim comando1 As New OleDbCommand
            Dim Con As New OleDbConnection
            Dim leitor1 As OleDbDataReader

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            comando1.CommandText = " DELETE FROM TBProduVenda"
            comando1.Connection = Con

            leitor1 = comando1.ExecuteReader

            leitor1.Read()

            Con.Dispose()
            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        '================================================================================================
        Try
            Dim comando1 As New OleDbCommand
            Dim Con As New OleDbConnection
            Dim leitor1 As OleDbDataReader

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            comando1.CommandText = " DELETE FROM TBVendaProduto" ' and TBProduVenda"
            comando1.CommandText = " DELETE FROM TBEntrada"
            comando1.CommandText = " DELETE FROM TBProduVenda"
            comando1.CommandText = " DELETE FROM TBVendasHistorico"
            comando1.Connection = Con

            leitor1 = comando1.ExecuteReader

            leitor1.Read()

            Con.Dispose()
            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        MessageBox.Show("Todas as Tabelas foram apagadas cm sucesso!!!!!!!")


        Try

            Dim comando1 As New OleDbCommand
            Dim Con As New OleDbConnection
            Dim leitor1 As OleDbDataReader

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            comando1.CommandText = " DELETE FROM TBDevolucao"
            comando1.Connection = Con

            leitor1 = comando1.ExecuteReader

            leitor1.Read()

            Con.Dispose()
            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

    End Sub

    Private Sub lblCotacao_Click(sender As Object, e As EventArgs)
        'Procedure para pegar cotação Moeda
        'CotacaoDolar()

        'cmbMoeda.SelectedIndex = 0

        'Dim codigomoeda = ""

        ''Pega posição do caracter ( -) que separa o código da descrição da moeda
        'Dim posTraco = cmbMoeda.Text.IndexOf(" -")
        'Dim valorcotacao As String

        '' Caso a posição for maior que -1, atribui o valor a variável codigoMoeda
        'If (posTraco > -1) Then
        '    codigomoeda = cmbMoeda.Text.Substring(0, posTraco)

        '    Try
        '        ' Chama WebService para retornar o valor
        '        Dim ws As New FachadaWSSGSClient()

        '        ' Através do código da moeda, atribui a variável valorCotacao o resultado da busca
        '        valorcotacao = ws.getUltimosValoresSerieVO(Convert.ToInt32(codigomoeda), 1).valores(0).svalor

        '        lblCotacao.Text = "R$ " + valorcotacao

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try


        'End If
    End Sub

    Private Sub btQuemSom_Click(sender As Object, e As EventArgs) Handles btQuemSom.Click
        Formquemsomos.Show()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
