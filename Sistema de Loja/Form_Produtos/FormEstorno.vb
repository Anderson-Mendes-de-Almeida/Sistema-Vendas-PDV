Imports System.Data.OleDb

Public Class FormEstorno
    Dim codVend As Integer

    Dim doucodigo As Double

    'Aqui estão as variaveis de rotina estorno
    Dim douvlrSaldo As Double
    Dim intQtd_Saida As Double
    Dim douVlr_UnidMedia As Double
    Dim douVlrSaldEstor As Double
    Dim douResulVlrEstorMultpli As Double ' essa variavel é o valor do txtValorProduto x quantidade de produtos devolvidos
    Dim douVendido As Integer
    Dim douLucro As Double
    Dim douResulLucro As Double
    Dim douVlrVenda As Double
    Dim douVlr_TotalSaida As Double
    Dim intQtdSaidaSom As Double
    Dim douVendidoSoma As Double
    Dim douVlrUnidade As Double

    Dim IntQtdEntradaTBEntr As Integer
    Dim douTotalEntradaTBEntr As Double
    Dim intEm_Estoque As Integer

    Dim IntResultadQtdEntr As Integer

    'variaveis que fazem parte da rotina estorno lucro
    Dim douResulVlrVenda_1 As Double
    Dim douResulVlrVenda_2 As Double
    Dim douLucroFim As Double

    Dim intSomaEm_Estoque As Integer

    'variaveis da Prodedure InsertTBProduto
    Dim intcodigo As Integer
    Dim doucodBarras As Double
    Dim strProduto As String
    Dim douVlrProduto As Double
    Dim intQtdEntradainsert As Integer
    Dim douVlrTotalEntrinsert As Double
    Dim strData As String


    Private Sub carregaGridView()

        Try


            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim Sql As String = "SELECT * FROM TBEntrada WHERE codBarras =" & douCodBarrasEsto

            Dim Comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(Comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBEntrada")


            dgEstorno1.DataSource = dt

            ds.Dispose()
            da.Dispose()
            Con.Dispose()
            Con.Close()
            FormatGrid()



        Catch ex As Exception
            MessageBox.Show("Erro ao conectar com Base de Dados : " & ex.Message)

        End Try

        '---------------Mudando a cor de Cabeçalho DatagridView------------------
        dgEstorno1.EnableHeadersVisualStyles = False
        'muda cor Headers
        dgEstorno1.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver
        'mudar co lateral esquerda
        'dgSaidaProduto.RowHeadersDefaultCellStyle.BackColor = Color.Black


    End Sub

    Private Sub SubtraiTBproduto()
        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            ''Dim sql2 As String = "SELECT vlr_unidade, vlr_totalSaida, Qtd_saida, Saldo, vlr_venda, vendido, Lucro, Em_Estoque FROM TBProduto"
            Dim sql2 As String = "SELECT vlr_unidade,  Qtd_saida, vlr_totalSaida,  Em_Estoque, Saldo, vlr_venda, vendido, Lucro FROM TBProduto"
            Dim Comando2 As New OleDbCommand(sql2, Con)

            Dim Leitor As OleDbDataReader
            Leitor = Comando2.ExecuteReader

            Leitor.Read()

            douVlrUnidade = Leitor("vlr_unidade")
            douVlr_TotalSaida = Leitor("vlr_totalSaida")
            intQtd_Saida = Leitor("Qtd_saida")
            douvlrSaldo = Leitor("saldo")
            douVendido = Leitor("vendido")
            douLucro = Leitor("Lucro")
            douVlrVenda = Leitor("vlr_Venda")
            intEm_Estoque = Leitor("Em_Estoque")

            Leitor.Close()

            douResulVlrVenda_1 = TxtQtdProdutos.Text * douVlrVenda
            douResulVlrVenda_2 = TxtQtdProdutos.Text * douVlrUnidade
            douResulLucro = douResulVlrVenda_1 - douResulVlrVenda_2
            douLucroFim = douResulLucro - douLucro

            'Aki multiplico o qtd de itens estornado pelo valor que cliente pago e devolvo ao banco
            douResulVlrEstorMultpli = (douVlrProdEston * TxtQtdProdutos.Text)
            'Aqui estou diminuindo/Valor estorno - o que foi Campo Produtos Vendido
            douVendidoSoma = douVendido - douResulVlrEstorMultpli
            'Essa variavel "douVlrProdEston" vem do txtValorProduto.text Aqui diminuo o Saldo
            douVlrSaldEstor = (douvlrSaldo - douResulVlrEstorMultpli)
            'aumentando estoque com produtos estornados
            douVlr_TotalSaida = douVlr_TotalSaida + douResulVlrEstorMultpli
            'Qtd estornado 
            intSomaEm_Estoque = intEm_Estoque + TxtQtdProdutos.Text
            intQtdSaidaSom = intQtd_Saida - TxtQtdProdutos.Text
            '----------------------------------------------------------------------------------------------------

            Dim sql3 As String = "UPDATE TBProduto SET vlr_totalSaida=?, Qtd_saida=?, Saldo=?, vendido=?, lucro=?, Em_Estoque=? WHERE codBarras=" & doucodigo
            Dim Comando As New OleDbCommand(sql3, Con)

            Comando.Parameters.Clear()      '' Erro Valor Venda Produtos

            Comando.Parameters.Add(New OleDb.OleDbParameter("@vlr_totalSaida", douVlr_TotalSaida))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@Qtd_saida", intQtdSaidaSom))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@saldo", douVlrSaldEstor))
            ''Comando.Parameters.Add(New OleDb.OleDbParameter("@vlr_venda", douVlrSaldEstor)) ''Erro aqui
            Comando.Parameters.Add(New OleDb.OleDbParameter("@vendido", douVendidoSoma))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@lucro", douLucroFim)) ''ver
            Comando.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", intSomaEm_Estoque))

            Comando.ExecuteNonQuery()


            Con.Dispose()
            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub SelecionCodProd()
        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()


            Dim Sql As String = " SELECT codProdLancando FROM TBEntrada "
            Dim comando As New OleDbCommand(Sql, Con)

            Dim Leitor As OleDbDataReader
            Leitor = comando.ExecuteReader
            Leitor.Read()


            codVend = Leitor("codProdLancando").ToString


            Leitor.Close()
            Con.Close()
            Con.Dispose()


        Catch ex As Exception

        End Try

    End Sub
    Private Sub FormatGrid()

        With dgEstorno1

            '''''''escondendo colunas------
            .Columns(0).Visible = False
            '.Columns(8).Visible = False


            '''''''Regulando tamanho colunas-----
            .Columns(1).Width = 130
            .Columns(2).Width = 200
            ' .Columns(6).Width = 50

            'Editando Cabeçalho
            '  .Columns(0).HeaderText = "Código "
            ' .Columns(0).HeaderText = "Codigo de Barras"
            .Columns(1).HeaderText = "Código Barras"
            .Columns(2).HeaderText = "Produto"
            .Columns(3).HeaderText = "Valor Unitario"
            .Columns(4).HeaderText = "Quantidade Entrada"
            .Columns(5).HeaderText = "Valor Total Entrada"


            ''''''''''Aqui formato as colunas para moeda "Reais"


            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(3).DefaultCellStyle.Format = "c2"
            '.Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"


            'dgvPedidos.Columns("valor_total").DefaultCellStyle.Format = "C2"


        End With

    End Sub
    Private Sub InsertTbEstorno()

        intcodigo = dgEstorno1.CurrentRow.Cells(0).Value.ToString()
        doucodBarras = dgEstorno1.CurrentRow.Cells(1).Value.ToString()
        strProduto = dgEstorno1.CurrentRow.Cells(2).Value.ToString()
        douVlrProduto = TxtValorProduto.Text
        'douVlrProduto = dgEstorno1.CurrentRow.Cells(3).Value.ToString()
        intQtdEntradainsert = dgEstorno1.CurrentRow.Cells(4).Value.ToString()
        ''douVlrTotalEntrinsert = dgEstorno1.CurrentRow.Cells(5).Value.ToString()
        strData = dgEstorno1.CurrentRow.Cells(6).Value.ToString()


        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim sql As String = " INSERT INTO TBEstorno (codestorno, codbarras, Produto, vlrproduto, qtdEntrada, VlrTotalEntrada, data)" & " VALUES (?, ?, ?, ?, ?, ?, ?)"

            Dim comando As New OleDbCommand(sql, Con)

            comando.Parameters.Clear()
            comando.Parameters.Add("@codestorno", System.Data.OleDb.OleDbType.VarChar, 13).Value = intcodigo
            comando.Parameters.Add("@codbarras", System.Data.OleDb.OleDbType.VarChar, 13).Value = doucodBarras
            comando.Parameters.Add("@Produto", System.Data.OleDb.OleDbType.VarChar, 40).Value = strProduto
            comando.Parameters.Add("@vlrproduto", System.Data.OleDb.OleDbType.VarChar, 13).Value = douVlrProduto
            comando.Parameters.Add("@qtdEntrada", System.Data.OleDb.OleDbType.VarChar, 13).Value = intQtdEntradainsert
            comando.Parameters.Add("@VlrTotalEntrada", System.Data.OleDb.OleDbType.VarChar, 13).Value = douVlrTotalEntrinsert
            comando.Parameters.Add("@data", System.Data.OleDb.OleDbType.Date, 13).Value = strData


            comando.CommandType = CommandType.Text


            comando.Connection = Con

            comando.ExecuteNonQuery()


            Con.Close()
            comando.Dispose()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub FormEstorno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' SelecionCodProd()

        carregaGridView()

    End Sub

    Private Sub dgEstorno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub cbPesquisaEntr_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' doucodigo = dgEstorno1.CurrentRow.Cells(1).Value

        'Essa sub tudo ok, somente inseri dados na TBEstorno
        InsertTbEstorno()

        SubtraiTBproduto()

        carregaGridView()


        'Fechando/abrindo FormRelaProduEstoque para atualizar
        FormRelaProdutEstoq.Close()
        FormRelaProdutEstoq.Show()
        FormRelaProdutEstoq.Refresh()

        Me.Dispose()
        Me.Close()


    End Sub

    Private Sub dgEstorno1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEstorno1.CellClick
        'Codigo barras de produtos
        doucodigo = dgEstorno1.CurrentRow.Cells(1).Value

        'Pegando codigo produto
        codVend = dgEstorno1.CurrentRow.Cells(0).Value

        TxtQtdProdutos.Enabled = True
        TxtQtdProdutos.Focus()



    End Sub

    Private Sub dgEstorno1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEstorno1.CellContentClick

    End Sub

    Private Sub TxtValorPagProduto_TextChanged(sender As Object, e As EventArgs) Handles TxtValorProduto.TextChanged
        Button1.Enabled = True

        douVlrProdEston = TxtValorProduto.Text


    End Sub

    Private Sub TxtValorPagProduto_LostFocus(sender As Object, e As EventArgs) Handles TxtValorProduto.LostFocus
        TxtValorProduto.Text = FormatCurrency(TxtValorProduto.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim



    End Sub

    Private Sub TxtQtdProdutos_TextChanged(sender As Object, e As EventArgs) Handles TxtQtdProdutos.TextChanged
        'Abilitando o Button1 Confiramr Estorno Produtos
        TxtValorProduto.Enabled = True




    End Sub

    Private Sub dgEstorno1_LostFocus(sender As Object, e As EventArgs) Handles dgEstorno1.LostFocus

    End Sub

    Private Sub TxtQtdProdutos_LostFocus(sender As Object, e As EventArgs) Handles TxtQtdProdutos.LostFocus

    End Sub
End Class