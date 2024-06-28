Imports System.Data.OleDb


Public Class FormRelaProdutEstoq
    Dim ds As New DataSet
    Dim douCodBarras As New List(Of Decimal)
    Dim intContDgProduto As Integer

    Private Sub CarregaRelaProdutEstoq()

        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select * FROM TBProduto"
            Dim comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBproduto")


            dgProduto.DataSource = dt

            dgProduto.DataSource = ds.Tables("TBProduto")

            Con.Close()
            Con.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try

        '  pintado row datagrid
        ConferiEstMin()

    End Sub

    Private Sub SomaVlrTotSaida()

        'contando linha DataGridView 
        intContDgProduto = dgProduto.Rows.Count

        'Varrendo Grid e adicionando os Codigos Barras a Lista
        For index = 0 To intContDgProduto - 1

            douCodBarras.Add(dgProduto.Rows(index).Cells(1).Value.ToString())


            Try

                Dim Con As New OleDbConnection
                Con.ConnectionString = My.Settings.CN1
                Con.Open()

                Dim douVlrUnid As Double
                Dim intQtdSaida As Integer
                Dim douvrl_TotaEntrada As Double = 0
                Dim douEm_Estoque As Double = 0

                Dim Para_douVlrTotalSai As Double = 0
                Dim Para_Saldo As Double = 0
                Dim Para_CutMedio As Double = 0

                Dim Sql As String = " SELECT vlr_unidade, Vlr_TotalEntrada, qtd_Saida, Em_Estoque FROM TBProduto WHERE codbarras= " & douCodBarras.Item(index)
                Dim comando As New OleDbCommand(Sql, Con)

                Dim Leitor As OleDbDataReader
                Leitor = comando.ExecuteReader
                Leitor.Read()

                douVlrUnid = Leitor("vlr_unidade")
                intQtdSaida = Leitor("qtd_Saida")                ' quantidade que ja vendeu
                douvrl_TotaEntrada = Leitor("Vlr_TotalEntrada") ' valor em reais de todos produtos comprado
                douEm_Estoque = Leitor("Em_Estoque")            'quantida em estoque

                '-----calculo Valor total Saida--------------------QtdSaida*CustoMédioUnidade------
                Para_douVlrTotalSai = douVlrUnid * intQtdSaida                                          'Ponto em estudo---------------------------------->

                '------calculo de subtração saldo----------------Valor Total Entrada - Valor Total Saida--
                Para_Saldo = douvrl_TotaEntrada - Para_douVlrTotalSai      ' Saldo é grana em Estouque

                '------calculo de Divisão Custo médio Unidade------Saldo/Em_Estoque-----
                Para_CutMedio = Para_Saldo / douEm_Estoque '

                Leitor.Close()
                'If FormSaidaProduto.Visible = True Then
                '    MessageBox.Show("Form Visivel")



                'End If

                Dim sql2 As String = "UPDATE TBProduto SET Vlr_TotalSaida=?, Saldo=?, vlr_Unidade=? WHERE CodBarras= " & douCodBarras.Item(index)
                Dim Comando2 As New OleDbCommand(sql2, Con)

                Comando2.Parameters.Clear()
                Comando2.Parameters.Add(New OleDb.OleDbParameter("@vlr_totalsaida", Para_douVlrTotalSai))
                Comando2.Parameters.Add(New OleDb.OleDbParameter("@Saldo", Para_Saldo))
                Comando2.Parameters.Add(New OleDb.OleDbParameter("@vlr_totalEntrada", Para_CutMedio))

                Comando2.ExecuteNonQuery()


                Con.Close()
                Con.Dispose()



            Catch ex As Exception
                MessageBox.Show(ex.Message)


            End Try

        Next

    End Sub


    Private Sub ConferiEstMin()

        Dim intEstqMin As Integer
        Dim intEm_Estq As Integer

        For i As Integer = 0 To dgProduto.Rows.Count() - 1

            'pegando o valor Em_estoque/varendo as linha de cima para baixo
            intEm_Estq = dgProduto.Rows(i).Cells(8).Value.ToString

            'pegando valor EstqMinimo/varendo as linha de cima para baixo
            intEstqMin = dgProduto.Rows(i).Cells(13).Value


            ''============================================================================Colorindo Colunas DataGridView==========
            ''Aqui coloco a coluna Valor venda produto em destaque
            dgProduto.Rows(i).Cells("Vlr_Venda").Style.BackColor = Color.Blue

            ''Aqui coloco a coluna em destaque
            dgProduto.Rows(i).Cells("Em_Estoque").Style.BackColor = Color.Yellow

            ''=====================================================================================================================
            If intEm_Estq < intEstqMin Then
                dgProduto.Rows(i).DefaultCellStyle.ForeColor = Color.Red


            End If

        Next


    End Sub
    Private Sub FormatGridView()

        With dgProduto


            'escondendo colunas------
            .Columns(0).Visible = False
            ' .Columns(12).Visible = False


            'Regulando tamanho colunas-----
            .Columns(1).Width = 100
            .Columns(2).Width = 400

            'Editando Cabeçalho
            '.Columns(0).HeaderText = "Tesntando"
            .Columns(1).HeaderText = "Codigo de Barras"
            .Columns(2).HeaderText = "Produto"


            .Columns(3).HeaderText = "Total Entrada"
            .Columns(4).HeaderText = "Custo Médio Unitario"
            .Columns(5).HeaderText = "Valor Total Entrada"

            .Columns(6).HeaderText = "Qtd.Saida"
            .Columns(7).HeaderText = "Valor Total Saida"


            .Columns(8).HeaderText = "Em Estoque"
            .Columns(9).HeaderText = "Saldo"
            .Columns(10).HeaderText = "Valor Venda Produto"
            .Columns(11).HeaderText = "Produtos Vendidos"
            .Columns(12).HeaderText = "Lucro"
            .Columns(13).HeaderText = "Qtd Minima Estoque"
            .Columns(14).HeaderText = "Data da Compra"


            'Aqui formato as colunas para moeda "Reais"
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(4).DefaultCellStyle.Format = "c2"
            .Columns(5).DefaultCellStyle.Format = "c2"
            .Columns(7).DefaultCellStyle.Format = "c2"
            .Columns(9).DefaultCellStyle.Format = "c2"
            .Columns(10).DefaultCellStyle.Format = "c2"
            .Columns(11).DefaultCellStyle.Format = "c2"
            .Columns(12).DefaultCellStyle.Format = "c2"

            ''  .ColumnHeadersDefaultCellStyle.Font = New Font("verdana", 10, FontStyle.Bold)

            ''dgProduto.Rows(10).DefaultCellStyle.BackColor = Color.Purple
            ''.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow
        End With


    End Sub
    Private Sub PesquisaProduto()
        Try
            ' If cbPesquisa.SelectedIndex = 0 Then

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT * FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdu.Text & "%' "
            Dim comando As New OleDbCommand(SQL, Con)

            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable

            'atualizamos a datatable com as tabelas
            da.Fill(dt)

            dgProduto.DataSource = dt


            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

        End Try
    End Sub

    Private Sub Pesquisacodbarra()
        Try

            Dim Con As New OleDbConnection
                Con.ConnectionString = My.Settings.CN1
                Con.Open()

            Dim SQL As String = " SELECT * FROM TBProduto Where codBarras LIKE '%" & Convert.ToInt64(txtPesquisaProdu.Text) & "%' "

            Dim comando As New OleDbCommand(SQL, Con)

                Dim da As New OleDbDataAdapter(comando)
                Dim dt As New DataTable

                'atualizamos a datatable com as tabelas
                da.Fill(dt)

                dgProduto.DataSource = dt

                Con.Close()




        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'Return

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select * FROM TBProduto"
            Dim comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_produto")


            dgProduto.DataSource = dt

            dgProduto.DataSource = ds.Tables("tab_Produto")

        Finally

        End Try


    End Sub


    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

        FormCadastroProdut.Show()

        Me.Visible = False
        Me.Dispose()



    End Sub

    Private Sub FormRelaProdutEstoq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
        dgProduto.Refresh()

        CarregaRelaProdutEstoq()

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim Sql As String = " Select * FROM TBProduto"
            Dim comando As New OleDbCommand(Sql, Con)

            ' Dim comando As New OleDbCommand
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBproduto")


            dgProduto.DataSource = dt

            dgProduto.DataSource = ds.Tables("TBProduto")


            'Procedure para calcular Vlr_totalSaida
            SomaVlrTotSaida()


            '-----------------------------------------------------------------
            '-----------------Aqui começa o codigo Count, Sum-----------------
            '-----------------------------------------------------------------
            Dim Leitor As OleDbDataReader

            comando.CommandText = "SELECT count(*) as Qtd, sum (vlr_totalentrada) as vlr, sum(qtd_entrada) as qtde,
                                    sum(qtd_saida) as qtdS , sum(Em_estoque) as emstq, sum(vendido) as vd FROM TBProduto "


            Leitor = comando.ExecuteReader
            Leitor.Read()

            btTotalProdutos.Text = Leitor("qtd")
            txtvalorEntrada.Text = Leitor("vlr")  'If Me.lblProdutosVendidos.Text = Leitor("qtd_S").ToString = (Nothing) Then
            btTotalEntrada.Text = Leitor("qtdE") & ""
            Me.btTotalSaida.Text = Leitor("qtds").ToString
            txtSaldoEstoque.Text = Leitor("emstq").ToString
            txtTotalReaisVendas.Text = Leitor("vd").ToString

            Leitor.Close()

            Con.Close()

        Catch ex As Exception

            MessageBox.Show("Não existe ainda produtos cadastrados!", "SkyNetSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

        'Essa Procedure é usado para formatar as colunas do Grid
        FormatGridView()

        'pintado row datagrid
        ConferiEstMin()

        '---------------Mudando a cor de Cabeçalho DatagridView------------------
        dgProduto.EnableHeadersVisualStyles = False
        'muda cor Headers
        dgProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver
        'mudar co lateral esquerda
        'dgSaidaProduto.RowHeadersDefaultCellStyle.BackColor = Color.Black
        '------------------------------------------------------------------


        CarregaRelaProdutEstoq()

        '------------------------------------------------------------------------------------
        'Dim douVlrSaiTotal As Double
        'Dim douVlr_Venda As Double
        'Dim douLucro As Double

        ''Calculando Valor de Vendas
        'Dim cont As Integer

        'Try
        '    cont = dgProduto.Rows.Count - 1

        '    For T = 0 To cont

        '        douVlrSaiTotal = dgProduto.Rows(T).Cells(7).Value ' valor de compra do produto
        '        douVlr_Venda = dgProduto.Rows(T).Cells(11).Value   ' valor de venda do produto
        '        '===============================================================
        '        If PerguntaLucro = True Then
        '            'aqui tenho 
        '            douLucro = douVlr_Venda - douVlrSaiTotal

        '            dgProduto.Rows(T).Cells(12).Value = douLucro



        '        End If

        '    Next
        '    '=======================================================================
        '    PerguntaLucro = False

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try





    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click

        dgProduto.Dispose()

        ''atualizando form1
        ''  Form1.Close()
        Form1.Show()
        'Form1.Refresh()



        Me.Close()
        Me.Dispose()



    End Sub

    Private Sub cbPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisa.SelectedIndexChanged
        Try
            txtPesquisaProdu.Enabled = True

        Catch ex As Exception



            Return


        End Try

        txtPesquisaProdu.Focus()


    End Sub

    Private Sub txtPesquisaProdu_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdu.TextChanged


        If cbPesquisa.SelectedIndex = 0 Then

            PesquisaProduto()
        Else


            Pesquisacodbarra()

        End If

        'verificando se estoque esta baix0
        ConferiEstMin()

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        FormEntradaProduto.Show()

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txtvalorEntrada_TextChanged(sender As Object, e As EventArgs) Handles txtvalorEntrada.TextChanged
        txtvalorEntrada.Text = FormatCurrency(txtvalorEntrada.Text, 2,
        TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub txtTotalReaisVendas_TextChanged(sender As Object, e As EventArgs) Handles txtTotalReaisVendas.TextChanged
        txtTotalReaisVendas.Text = FormatCurrency(txtTotalReaisVendas.Text, 2,
        TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        FormSaidaProduto.Show()

    End Sub
End Class