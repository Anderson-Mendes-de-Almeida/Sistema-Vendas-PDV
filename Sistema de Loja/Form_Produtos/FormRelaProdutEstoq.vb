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


            ''Procedure para calcular Vlr_totalSaida
            'SomaVlrTotSaida()

            Con.Close()
            Con.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try



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
                intQtdSaida = Leitor("qtd_Saida")
                douvrl_TotaEntrada = Leitor("Vlr_TotalEntrada")
                douEm_Estoque = Leitor("Em_Estoque")

                '-----calculo Valor total Saida--------------------QtdSaida*CustoMédioUnidade------
                Para_douVlrTotalSai = douVlrUnid * intQtdSaida

                '------calculo de subtração saldo----------------Valor Total Entrada - Valor Total Saida--
                Para_Saldo = douvrl_TotaEntrada - Para_douVlrTotalSai

                '------calculo de Divisão Custo médio Unidade------Saldo/Em_Estoque-----
                Para_CutMedio = Para_Saldo / douEm_Estoque






                Leitor.Close()


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
            intEstqMin = dgProduto.Rows(i).Cells(12).Value

            If intEm_Estq < intEstqMin Then
                dgProduto.Rows(i).DefaultCellStyle.ForeColor = Color.Red

                dgProduto.Columns(12).Name = "Repor estoque"


            End If

        Next


    End Sub
    Private Sub FormatGridView()
        With dgProduto

            'escondendo colunas------
            .Columns(0).Visible = False
            '.Columns(4).Visible = False


            'Regulando tamanho colunas-----
            .Columns(1).Width = 150
            .Columns(2).Width = 150

            'Editando Cabeçalho
            '.Columns(0).HeaderText = "Tesntando"
            .Columns(1).HeaderText = "Codigo de Barras"
            .Columns(2).HeaderText = "Produto"
            .Columns(3).HeaderText = "Total Entrada"
            .Columns(4).HeaderText = "Custo Unitario"
            .Columns(5).HeaderText = "Valor Total Entrada"

            .Columns(6).HeaderText = "Qtd.Saida"
            .Columns(7).HeaderText = "Valor Total Saida"


            .Columns(8).HeaderText = "Em Estoque"
            .Columns(9).HeaderText = "Saldo"
            .Columns(10).HeaderText = "Valor Venda Produto"
            .Columns(11).HeaderText = "Produtos Vendidos"
            .Columns(12).HeaderText = "Qtd Minima Estoque"
            .Columns(13).HeaderText = "Data da Compra"


            'Aqui formato as colunas para moeda "Reais"
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(4).DefaultCellStyle.Format = "c2"
            .Columns(5).DefaultCellStyle.Format = "c2"
            .Columns(7).DefaultCellStyle.Format = "c2"
            .Columns(9).DefaultCellStyle.Format = "c2"
            .Columns(10).DefaultCellStyle.Format = "c2"
            .Columns(11).DefaultCellStyle.Format = "c2"


            'dgvPedidos.Columns("valor_total").DefaultCellStyle.Format = "C2"

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

            Dim SQL As String = " SELECT * FROM TBProduto Where codBarras LIKE '%" & Convert.ToInt32(txtPesquisaProdu.Text) & "%' "

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



    End Sub

    Private Sub FormRelaProdutEstoq_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
            txtvalorEntrada.Text = Leitor("vlr") 'If Me.lblProdutosVendidos.Text = Leitor("qtd_S").ToString = (Nothing) Then
            btTotalEntrada.Text = Leitor("qtdE")
            Me.btTotalSaida.Text = Leitor("qtds").ToString
            txtSaldoEstoque.Text = Leitor("emstq").ToString
            txtTotalReaisVendas.Text = Leitor("vd").ToString

            Leitor.Close()

            Con.Close()

        Catch ex As Exception
            '  MessageBox.Show("Erro ao conectar com Base de Dados : " & ex.Message)
            '   MessageBox.Show("Não a Produtos Cadastrados!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)

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


    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click

        dgProduto.Dispose()

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