Imports System.Data.OleDb

Public Class FormVendasRealisadas
    Dim codProdDevol As Integer
    Dim CodBarrasDevo As Int64

    Dim intCodBarras As Int64
    Dim intQtd_Saida As Integer
    Dim intEm_Estoque As Integer
    Dim VlrVendido As Decimal

    Private Sub CarreFormPrincipal()

        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select CodBarras, Produto, datacompra, ValorUni, QTD, CalcQtd, valorTotal, Dinheiro, Troco, tipopagamento FROM TBvendasHistorico"

            Dim comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBvendasHistorico")


            dgVendasRealiz.DataSource = dt

            dgVendasRealiz.DataSource = ds.Tables("TBvendasHistorico")

            Con.Close()
            Con.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        ''---------------Mudando a cor de Cabeçalho DatagridView------------------
        'dgVendasRealiz.EnableHeadersVisualStyles = False
        ''muda cor Headers
        'dgVendasRealiz.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver
        'mudar co lateral esquerda
        'dgSaidaProduto.RowHeadersDefaultCellStyle.BackColor = Color.Black

        'Procedure calcula vendas
        '   VendasRealizadas()

        FormatGridView()

    End Sub
    Private Sub CarregaDgProduto()

        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim Sql As String = " Select CodBarras, Produto, datacompra, ValorUni, QTD, CalcQtd, tipopagamento FROM TBvendasHistorico "
            Dim comando As New OleDbCommand(Sql, Con)

            ' Dim comando As New OleDbCommand
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBproduto")


            dgProdutos.DataSource = dt

            dgProdutos.DataSource = ds.Tables("TBProduto")

            Con.Dispose()
            Con.Close()

        Catch ex As Exception

        End Try



    End Sub
    Private Sub VendasRealizadas()

        Dim dtInicial As String = Format(dtpDataInicial.Value, "dd/MM/yyyy").ToString
        Dim dtFinal As String = Format(dtpDataFinal.Value.AddDays(1), "dd/MM/yyyy").ToString


        Try

            dtpDataInicial.Enabled = True
            dtpDataFinal.Enabled = True

            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim Con As New OleDbConnection
            Dim comando As New OleDbCommand

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            ''aki tenho que consertar o Select ' ==> Select CodBarras, Produto, datacompra, ValorUni, QTD, CalcQtd, tipopagamento FROM TBProduvenda WHERE datacompra BETWEEN @dtInicio AND @dtFim "
            Dim sql As String = " Select * FROM TBVendaProduto WHERE datacompra BETWEEN @dtInicio AND @dtFim "

            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@dtInicio", dtInicial)
            comando.Parameters.AddWithValue("@dtFim", dtFinal)


            comando.CommandType = CommandType.Text
            comando.CommandText = sql

            Dim da As New OleDbDataAdapter(comando)
            da.SelectCommand.Connection = Con

            da.Fill(dt)
            da.Fill(ds, "TBProduVenda")

            dgVendasRealiz.DataSource = dt

            'Distruindo todos objetos
            da.Dispose()
            comando.Dispose()
            Con.Close()
            Con.Dispose()

            Dim valor As Decimal

            'Calculando Valor de Vendas
            For Each col As DataGridViewRow In dgVendasRealiz.Rows

                valor = valor + col.Cells(3).Value

            Next

            txtValorTotal.Text = valor


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

        End Try

        FormatGridView()



    End Sub

    Private Sub FormatGridView()

        With dgVendasRealiz

            '---------------Mudando a cor de Cabeçalho DatagridView------------------
            dgVendasRealiz.EnableHeadersVisualStyles = False
            'muda cor Headers
            dgVendasRealiz.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver

            'escondendo colunas------
            '  .Columns(0).Visible = False
            ' .Columns(4).Visible = False


            'Regulando tamanho colunas-----
            .Columns(0).Width = 100
            .Columns(1).Width = 150
            .Columns(3).Width = 200
            .Columns(4).Width = 200

            'Editando Cabeçalho                      CodBarras, Produto, datacompra, ValorUni, QTD, tipopagamento
            '.Columns(0).HeaderText = "Tesntando"
            ' .Columns(0).HeaderText = "Codigo de Barras"
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Data da Compra"
            .Columns(2).HeaderText = "SITUAÇÃO "
            .Columns(3).HeaderText = "Valor Total da Compra "
            .Columns(4).HeaderText = "Cliente Devedor "
            '.Columns(5).HeaderText = "Calculando QTD"
            '.Columns(6).HeaderText = "Total Pagar"

            '' .Columns(7).HeaderText = "Dinheiro"
            ' .Columns(8).HeaderText = "Troco"
            ''''''''''''''''''''''''''''''''''''''   .Columns(6).HeaderText = "Tipo Pagamento"

            'Aqui formato as colunas para moeda "Reais"
            .Columns(3).DefaultCellStyle.Format = "c2"
            '.Columns(6).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"
            '.Columns(8).DefaultCellStyle.Format = "c2"
            '.Columns(9).DefaultCellStyle.Format = "c2"

            '.Columns(2).HeaderCell = Color.Violet=True

        End With


    End Sub
    Private Sub FormVendasRealisadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  CarreFormPrincipal()

        'Carregando Variaveis, esse Grid esta invisivel
        ' CarregaDgProduto()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        ' FormVendasAgrupadas.Show()

    End Sub

    Private Sub txtPesquisaProdu_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdu.TextChanged

    End Sub

    Private Sub TsslFechar_Click(sender As Object, e As EventArgs) Handles TsslFechar.Click
        Me.Dispose()

    End Sub

    Private Sub cbPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisa.SelectedIndexChanged

        txtPesquisaProdu.Enabled = True

        txtPesquisaProdu.Select()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btConsulta.Click
        VendasRealizadas()



    End Sub

    Private Sub dtpDataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataInicial.ValueChanged


    End Sub

    Private Sub cbPesquisa_LostFocus(sender As Object, e As EventArgs) Handles cbPesquisa.LostFocus

    End Sub

    Private Sub txtValorTotal_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotal.TextChanged
        txtValorTotal.Text = FormatCurrency(txtValorTotal.Text, 2, TriState.True,
                            TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub dgVendasRealiz_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVendasRealiz.CellContentClick

    End Sub

    'Private Sub dgVendasRealiz_DoubleClick(sender As Object, e As EventArgs) Handles dgVendasRealiz.DoubleClick

    '    GroupBox1.Enabled = True

    '    'pegando codigo produto vendido
    '    codProdDevol = dgVendasRealiz.CurrentRow.Cells(0).Value.ToString
    '    'pegando codBarras Produto
    '    CodBarrasDevo = dgVendasRealiz.CurrentRow.Cells(1).Value.ToString()

    '    txtPesqCodBarras.Text = dgVendasRealiz.CurrentRow.Cells(1).Value.ToString
    '    txtPrecoUni.Text = dgVendasRealiz.CurrentRow.Cells(4).Value.ToString
    '    txtQtd.Text = dgVendasRealiz.CurrentRow.Cells(5).Value.ToString
    '    txtTotal.Text = dgVendasRealiz.CurrentRow.Cells(6).Value.ToString
    '    txtProduto.Text = dgVendasRealiz.CurrentRow.Cells(2).Value.ToString



    'End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged


        txtTotal.Text = FormatCurrency(txtTotal.Text, 2, TriState.True,
                            TriState.True, TriState.True).Replace("R$", "R$").Trim
    End Sub

    Private Sub btnDevolucao_Click(sender As Object, e As EventArgs) Handles btnDevolucao.Click


        Try
            Dim Con1 As New OleDbConnection
            Con1.ConnectionString = My.Settings.CN1
            Con1.Open()

            Dim Sql2 As String = "DELETE FROM TBvendas WHERE codigo=" & codProdDevol
            Dim Comando2 As New OleDbCommand(Sql2, Con1)

            Comando2.ExecuteNonQuery()

            'Desabilitando campos
            GroupBox1.Enabled = False

            '------------------Inserindo Dados TbDevolucao-------------------------------------------

            'pegando codigo produto vendido
            codProdDevol = dgVendasRealiz.CurrentRow.Cells(0).Value.ToString

            txtPesqCodBarras.Text = dgVendasRealiz.CurrentRow.Cells(1).Value.ToString
            txtPrecoUni.Text = dgVendasRealiz.CurrentRow.Cells(4).Value.ToString
            txtQtd.Text = dgVendasRealiz.CurrentRow.Cells(5).Value.ToString
            txtTotal.Text = dgVendasRealiz.CurrentRow.Cells(6).Value.ToString
            txtProduto.Text = dgVendasRealiz.CurrentRow.Cells(2).Value.ToString

            Try
                Dim sql As String = " INSERT INTO TBDevolucao (codbarras, Produto, Qtd, vlrUni, VlrTotal, dataCancel, Motivo)" & " VALUES (?, ?, ?, ?, ?, ?, ?)"

                Dim comando As New OleDbCommand(sql, Con1)

                comando.Parameters.Clear()
                comando.Parameters.Add("@codbarras", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtPesqCodBarras.Text
                comando.Parameters.Add("@Produto", System.Data.OleDb.OleDbType.VarChar, 320).Value = txtProduto.Text
                comando.Parameters.Add("@Qtd", System.Data.OleDb.OleDbType.VarChar, 40).Value = txtQtd.Text
                comando.Parameters.Add("vlrUni", System.Data.OleDb.OleDbType.VarChar, 40).Value = txtPrecoUni.Text
                comando.Parameters.Add("@VlrTotal", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtTotal.Text
                comando.Parameters.Add("@dataCancel", System.Data.OleDb.OleDbType.Date).Value = Now
                comando.Parameters.Add("@Motivo", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtMotivoDevol.Text



                comando.CommandType = CommandType.Text


                comando.Connection = Con1

                comando.ExecuteNonQuery()
                '-----------------------------------------UPDATE TBProduto-------------------------------------------------------------------

                Try
                    Dim codBarr As Int64

                    Dim cont As Integer = dgProdutos.Rows.Count - 1

                    For index = 0 To cont - 1
                        codBarr = dgProdutos.Rows(index).Cells(1).Value.ToString

                        If CodBarrasDevo = codBarr Then
                            intQtd_Saida = dgProdutos.Rows(index).Cells(6).Value.ToString
                            intEm_Estoque = dgProdutos.Rows(index).Cells(8).Value.ToString
                            VlrVendido = dgProdutos.Rows(index).Cells(11).Value.ToString()

                        End If

                    Next

                    '  intCodBarras = dgProdutos.CurrentRow.Cells(1).Value.ToString()



                    Dim intParmEmEst As Integer
                    Dim intParamQtd_Saida As Integer



                    Dim sql3 As String = "UPDATE TBProduto SET Qtd_saida=?, Em_Estoque=?, vendido=? WHERE codBarras=" & CodBarrasDevo
                    Dim Comando3 As New OleDbCommand(sql3, Con1)

                    'calculando saida e estoque
                    intParmEmEst = intEm_Estoque + txtQtd.Text
                    intParamQtd_Saida = intQtd_Saida - txtQtd.Text

                    VlrVendido = 0

                    Comando3.Parameters.Clear()
                    Comando3.Parameters.Add(New OleDb.OleDbParameter("@Qtd_saida", intParamQtd_Saida))
                    Comando3.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", intParmEmEst))
                    Comando3.Parameters.Add(New OleDb.OleDbParameter("@vendido", VlrVendido))

                    Comando3.ExecuteNonQuery()

                    Con1.Close()

                    MessageBox.Show("Baixa em Produto com Sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    dgVendasRealiz.Refresh()

                    'End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally



                End Try




            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Con1.Close()
            Con1.Dispose()
        Catch ex As Exception

        End Try

        CarreFormPrincipal()

    End Sub

    Private Sub btnDevolucao_DoubleClick(sender As Object, e As EventArgs) Handles btnDevolucao.DoubleClick

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgProdutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProdutos.CellContentClick

    End Sub

    Private Sub dgVendasRealiz_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVendasRealiz.CellDoubleClick
        FormQuitaDivi.Show()


        Dim StrPago As String = "Pago"


        CodVendDg = dgVendasRealiz.CurrentRow.Cells(0).Value
        StrformaPag = dgVendasRealiz.CurrentRow.Cells(2).Value.ToString



        'If StrformaPag = "Fiado" Then

        '    Dim Con1 As New OleDbConnection
        '    Con1.ConnectionString = My.Settings.CN1
        '    Con1.Open()

        '    Dim sql10 As String = "UPDATE TBVendaProduto SET formaPag=? WHERE codigoVenda=" & CodVendDg

        '    Dim Comando30 As New OleDbCommand(sql10, Con1)

        '    Comando30.Parameters.Clear()
        '    Comando30.Parameters.Add(New OleDb.OleDbParameter("@formaPag", StrPago))

        '    Comando30.ExecuteNonQuery()

        '    Con1.Close()
        '    Con1.Dispose()

        '    dgVendasRealiz.Refresh()

        'End If






    End Sub
End Class