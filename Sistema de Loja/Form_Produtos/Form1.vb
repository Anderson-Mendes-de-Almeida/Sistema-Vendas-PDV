Imports System.Data.OleDb


Public Class Form1
    Dim intTotalReg As Integer
    Dim dtmesComp As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

            intTotalReg = Leitor("ent")

            Leitor.Close()

            '---------------------------------------TBProdutos---Contando Produto em Estoque----------------------


            comando.CommandText = " SELECT sum(Em_Estoque) as EmEst FROM TBProduto "

            Leitor = comando.ExecuteReader
            Leitor.Read()

            lblProdEmEstoque.Text = Leitor("EmEst")

            Leitor.Close()

            '-----------------------------------------TBVendas---Contando total de vedas------------------------------

            comando.CommandText = " SELECT count(*) as ven FROM TBVendas "

            Leitor = comando.ExecuteReader

            Leitor.Read()

            intTotalReg = Leitor("ven")

            Leitor.Close()


            '----------------------------------------TBVendas retornando vendas data atual--------------------------------------------

            Dim mes As Integer = Now.Month

            comando.CommandText = " SELECT count(*) as c FROM TBVendas WHERE Month(datacompra) = " & mes

            Leitor = comando.ExecuteReader


            Leitor.Read()

            lblQtdMes.Text = Leitor("c")


            Leitor.Close()
            '-------------------------------------TBVendas-----Pegando o Total me R$ no Mês---------------------

            Dim mes2 As Integer = Now.Month

            comando.CommandText = " SELECT sum(valorTotal) as vt FROM TBVendas WHERE Month(datacompra) = " & mes2


            Leitor = comando.ExecuteReader


            Leitor.Read()

            lblTotalMesGrana.Text = FormatCurrency(Leitor("vt"), 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim


            Con.Close()



        Catch ex As Exception
            MessageBox.Show("Ainda Não Existe Nenhum Produto Cadastrado! : " & ex.Message)
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
End Class
