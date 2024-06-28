Imports System.Data.OleDb

Public Class FormVendaManual
    Dim douValorTotal As Double = 0

    Dim intTotal As Decimal = 0
    Dim intCodBarras As Int64
    Dim IntEm_estoque As Integer
    Dim IntQtd_saida As Integer = 0
    Dim douJaVendido As Double = 0
    Dim douVendido As Double = 0

    'varivel tipo de pagamento Radio Button
    Dim strrbTipoPag As String = "Dinheiro"

    Dim douCodBarras As Double
    Dim strItem As String
    Dim strPreco As String
    Dim intQtd As Integer
    Dim douTroco As Double
    Dim cont As Integer = 0
    'contando Items ListView
    Dim contador As Integer = 0

    Private Sub Em_estoque()

        Try

            Dim Con As New OleDbConnection

            Con.ConnectionString = My.Settings.CN1
            Con.Open()


            Dim sql As String = "SELECT Em_estoque, Qtd_saida, Vendido FROM TBProduto WHERE codbarras=" & intCodBarras
            Dim Comando As New OleDbCommand(sql, Con)

            Dim Leitor As OleDbDataReader
            Leitor = Comando.ExecuteReader

            Leitor.Read()

            IntEm_estoque = Leitor("Em_estoque")
            IntQtd_saida = Leitor("Qtd_saida")
            douJaVendido = Leitor("Vendido")


            Leitor.Close()
            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub txtPesqCodBarras_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPesqCodBarras.KeyUp



        Try
            Dim douCodBarras As Double


            If (e.KeyCode = Keys.Enter) Then



                Dim Con As New OleDbConnection

                Con.ConnectionString = My.Settings.CN1
                Con.Open()

                Dim SQL As String = " SELECT codbarras, descproduto, vlr_venda
                                      FROM TBProduto Where codbarras=" & txtPesqCodBarras.Text


                Dim comando As New OleDbCommand(SQL, Con)
                Dim Leitor As OleDbDataReader
                Leitor = comando.ExecuteReader
                Leitor.Read()

                douCodBarras = Leitor("codbarras")
                Dim strDescProuto As String = Leitor("descproduto")
                Dim doubVlr_Venda As Double = Leitor("vlr_venda")



                If LtTelaVenda.Items.Count = 0 Then
                    '  LtTelaVenda.View = View.Details
                    Dim lvi As New ListViewItem
                    lvi.Text = (douCodBarras)
                    lvi.SubItems.Add(strDescProuto)
                    lvi.SubItems.Add(FormatCurrency(doubVlr_Venda, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim)
                    LtTelaVenda.Items.Add(lvi)
                    lvi = Nothing
                Else
                    Dim lvi As New ListViewItem
                    lvi.Text = (douCodBarras)
                    lvi.SubItems.Add(strDescProuto)
                    lvi.SubItems.Add(FormatCurrency(doubVlr_Venda, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim)
                    LtTelaVenda.Items.Add(lvi)
                    lvi = Nothing


                End If

                '-----------------------passando valor ListView para 

                txtDescricao.Text = strDescProuto    'LtTelaVenda.CurrentRow.Cells(1).Value.ToString()

                'somando todos os produtos
                douValorTotal = douValorTotal + doubVlr_Venda                 ' dgTelaVenda.CurrentRow.Cells(2).Value.ToString()

                'exibindo no textbox
                txtTotalPagar.Text = douValorTotal


                Con.Close()
                Con.Dispose()

                txtPesqCodBarras.Clear()

            End If


        Catch ex As Exception
            MessageBox.Show("Produto não Existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        Finally

        End Try


        'txtPesqCodBarras.Clear()
        'txtPesqCodBarras.Focus()

    End Sub

    Private Sub txtPesqCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtPesqCodBarras.TextChanged

    End Sub

    Private Sub txtTotalPagar_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPagar.TextChanged

        txtTotalPagar.Text = FormatCurrency(txtTotalPagar.Text, 2, TriState.True,
                          TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub

    Private Sub txtDinheiro_TextChanged(sender As Object, e As EventArgs) Handles txtDinheiro.TextChanged

    End Sub

    Private Sub txtTroco_TextChanged(sender As Object, e As EventArgs) Handles txtTroco.TextChanged

        txtTroco.Text = FormatCurrency(txtTroco.Text, 2, TriState.True,
                          TriState.True, TriState.True).Replace("R$", "R$").Trim
    End Sub

    Private Sub txtDinheiro_LostFocus(sender As Object, e As EventArgs) Handles txtDinheiro.LostFocus

        Try

            txtDinheiro.Text = FormatCurrency(txtDinheiro.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim



            'calculando valor de troco
            Dim doubTroco As String
            doubTroco = txtDinheiro.Text - (douValorTotal)

            txtTroco.Text = doubTroco

        Catch ex As Exception
            txtPesqCodBarras.Focus()
        End Try

    End Sub

    Private Sub txtPesqCodBarras_LostFocus(sender As Object, e As EventArgs) Handles txtPesqCodBarras.LostFocus

        txtDinheiro.Focus()

    End Sub

    Private Sub txtTroco_LostFocus(sender As Object, e As EventArgs) Handles txtTroco.LostFocus

        txtObservacao.Focus()

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If LtTelaVenda.Items.Count < 1 Then
            MessageBox.Show("Não à produtos cadastrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        End If

        'procedure Carrega valor Em_estoque e Vedido
        Em_estoque()

        Dim Param_Em_Est As Integer
        Dim Param_Qtd_saida As Integer
        Dim Param_Vendido As Double

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()



            '===========================================Aqui do baixa nos produtos vendidos ====================================
            Dim itens As List(Of String) = New List(Of String)

            For Each item As ListViewItem In LtTelaVenda.Items
                contador = LtTelaVenda.Items.Count
                itens.Add(item.SubItems(0).Text)

                Dim sql2 As String = "SELECT Em_estoque, Qtd_saida, Vendido FROM TBProduto WHERE codbarras=" & item.Text
                Dim Comando2 As New OleDbCommand(sql2, Con)

                Dim Leitor As OleDbDataReader
                Leitor = Comando2.ExecuteReader

                Leitor.Read()

                IntEm_estoque = Leitor("Em_estoque")
                IntQtd_saida = Leitor("Qtd_saida")
                douJaVendido = Leitor("vendido")
                ' Pegando valor coluna Preço 
                'itens.Add(item.SubItems(2).Text)
                'douVendido = item.Text
                douVendido = (item.SubItems(2).Text)

                Param_Em_Est = (IntEm_estoque) - (1)
                Param_Qtd_saida = (IntQtd_saida) + (1)
                Param_Vendido = douJaVendido + douVendido

                '===============================Dando baixa em Banco de dados , Em_Estoque e vendido=================================
                Dim sql As String = "UPDATE TBProduto SET Em_Estoque=?, Qtd_saida=?, Vendido=? WHERE codBarras=" & item.Text
                Dim Comando As New OleDbCommand(sql, Con)

                Comando.Parameters.Clear()
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", Param_Em_Est))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Qtd_saida", Param_Qtd_saida))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Vendido", Param_Vendido))


                Comando.ExecuteNonQuery()

                Comando2.Dispose()
                Comando.Dispose()

                Leitor.Close()

            Next

            ' ============================Inserindo dados na Tabela Vendas================================================================
            Try

                ''Aqui deleta ou cria pasta
                'If Not IO.Directory.Exists(Diretorio) Then
                '    IO.Directory.CreateDirectory(Diretorio)

                'End If

                ''Esse codigo apaga o arquivo de ticket.txt se ele existir
                'If IO.File.Exists(Ticket) Then
                '    IO.File.Delete(Ticket)
                '    Dim Criar = IO.File.CreateText(Ticket)
                '    Criar.Close()
                'End If

                Dim itens2 As List(Of String) = New List(Of String)

                For Each itemSeg As ListViewItem In LtTelaVenda.Items   'Aqui tive duficuldade, muita atenção parametro deve usar variavel " ItemSeg "
                    itens2.Add(itemSeg.SubItems(0).Text)
                    itens2.Add(itemSeg.SubItems(1).Text)
                    itens2.Add(itemSeg.SubItems(2).Text)
                    itens2.Add(itemSeg.SubItems(3).Text)
                    'variaveis p/ Ticket
                    douCodBarras = itemSeg.SubItems(0).Text
                    strItem = itemSeg.SubItems(1).Text
                    strPreco = FormatCurrency(itemSeg.SubItems(2).Text, 2, TriState.True, TriState.True).Replace("R$", "R$").Trim
                    intQtd = itemSeg.SubItems(3).Text
                    douValorTotal = txtTotalPagar.Text
                    douTroco = txtTroco.Text

                    Dim Comando3 As New OleDbCommand
                    Comando3.CommandText = "INSERT INTO TBVendas (CodBarras, Produto, datacompra, valorTotal, Dinheiro, Troco, tipopagamento)" & "VALUES (?, ?, ?, ?, ?, ?, ?)"

                    Comando3.Parameters.Clear()
                    Comando3.Parameters.Add("@CodBarras", System.Data.OleDb.OleDbType.VarChar, 13).Value = itemSeg.SubItems(0).Text
                    Comando3.Parameters.Add("@Produto", System.Data.OleDb.OleDbType.VarChar, 30).Value = itemSeg.SubItems(1).Text
                    Comando3.Parameters.Add("@dataCompra", System.Data.OleDb.OleDbType.Date, 13).Value = Now
                    Comando3.Parameters.Add("@ValorTotal", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtTotalPagar.Text
                    Comando3.Parameters.Add("@Dinheiro", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtDinheiro.Text
                    Comando3.Parameters.Add("@Troco", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtTroco.Text
                    Comando3.Parameters.Add("@tipopagamento", System.Data.OleDb.OleDbType.VarChar, 12).Value = strrbTipoPag

                    '========================================Aqui crio o Ticket=============================================================================
                    ' CriarTicket()

                    Comando3.CommandType = CommandType.Text


                    Comando3.Connection = Con

                    Comando3.ExecuteNonQuery()

                    Comando3.Dispose()

                Next
                '    '===================================Inserindo Dados TBVendaProduto==============================================================
                Dim leitor As OleDbDataReader
                Dim comando5 As New OleDbCommand
                Dim mes As Integer = Now.Month

                Dim intRegistro As Integer

                comando5.CommandText = " SELECT count(*) as c FROM TBVendaProduto "
                comando5.Connection = Con


                leitor = comando5.ExecuteReader
                leitor.Read()

                'pegando numero de registro TBVendaProduto
                intRegistro = leitor("c")


                leitor.Close()


                '=====================================Inserindo registro tabela TBVendaProduto=================================================
                'Aqui adiciono sempre + 1 no mero de registros do campo
                intRegistro = intRegistro + 1

                Dim Comando4 As New OleDbCommand
                Comando4.CommandText = "INSERT INTO TBVendaProduto (codigovenda, datacompra, formaPag, totalcompr)" & "VALUES (?, ?, ?, ?)"

                Comando4.Parameters.Clear()

                Comando4.Parameters.Add("@codigovenda", System.Data.OleDb.OleDbType.Integer, 30).Value = intRegistro
                Comando4.Parameters.Add("@dataCompra", System.Data.OleDb.OleDbType.Date, 30).Value = Now
                Comando4.Parameters.Add("@formaPag", System.Data.OleDb.OleDbType.VarChar, 30).Value = strrbTipoPag
                Comando4.Parameters.Add("@totalcompr", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtTotalPagar.Text


                Comando4.CommandType = CommandType.Text

                Comando4.Connection = Con

                Comando4.ExecuteNonQuery()

                Comando4.Dispose()


                '================================================================================================================

                Dim itens4 As List(Of String) = New List(Of String)
                Dim codBarra As String


                For Each itemQuar As ListViewItem In LtTelaVenda.Items
                    itens4.Add(itemQuar.SubItems(0).Text)
                    itens4.Add(itemQuar.SubItems(2).Text)

                    codBarra = itemQuar.SubItems(0).Text

                    Dim contitens As Integer = 0

                    For Each item In LtTelaVenda.Items

                        If codBarra = item.SubItems.Item(0).Text Then
                            contitens += 1

                        End If

                    Next


                    Comando4.CommandText = "INSERT INTO TBProduVenda (codigovenda, CodBarraProd, produto, quantidade, valorUnitario)" & "VALUES (?, ?, ?, ?, ?)"

                    Comando4.Parameters.Clear()

                    Comando4.Parameters.Add("@codigovenda", System.Data.OleDb.OleDbType.Integer, 30).Value = intRegistro
                    Comando4.Parameters.Add("@CodBarraProd", System.Data.OleDb.OleDbType.VarChar, 20).Value = itemQuar.SubItems(0).Text
                    Comando4.Parameters.Add("@produto", System.Data.OleDb.OleDbType.VarChar, 20).Value = itemQuar.SubItems(1).Text
                    Comando4.Parameters.Add("@quantidade", System.Data.OleDb.OleDbType.VarChar, 30).Value = "1"
                    Comando4.Parameters.Add("@valorUnitario", System.Data.OleDb.OleDbType.VarChar, 30).Value = itemQuar.SubItems(2).Text


                    Comando4.CommandType = CommandType.Text

                    Comando4.Connection = Con

                    Comando4.ExecuteNonQuery()

                    Comando4.Dispose()


                Next


                Con.Close()



            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try


            MessageBox.Show("Venda Finalizada com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtDescricao.Clear()
            txtDinheiro.Text = 0
            txtTotalPagar.Text = 0
            txtTroco.Text = 0



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            LtTelaVenda.Clear()


        End Try


        Dispose()
        Close()

    End Sub

    Private Sub LtTelaVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtTelaVenda.SelectedIndexChanged

    End Sub

    Private Sub txtObservacao_TextChanged(sender As Object, e As EventArgs) Handles txtObservacao.TextChanged

    End Sub

    Private Sub txtObservacao_LostFocus(sender As Object, e As EventArgs) Handles txtObservacao.LostFocus
        rbDinheiro.Focus()

    End Sub

    Private Sub rbDinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rbDinheiro.CheckedChanged

    End Sub

    Private Sub rbDinheiro_LostFocus(sender As Object, e As EventArgs) Handles rbDinheiro.LostFocus
        rbCartao.Checked = True


    End Sub

    Private Sub rbCartao_CheckedChanged(sender As Object, e As EventArgs) Handles rbCartao.CheckedChanged

    End Sub

    Private Sub rbCartao_LostFocus(sender As Object, e As EventArgs) Handles rbCartao.LostFocus
        rbCheque.Checked = True

    End Sub

    Private Sub rbCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rbCheque.CheckedChanged

    End Sub

    Private Sub rbCheque_LostFocus(sender As Object, e As EventArgs) Handles rbCheque.LostFocus
        btnFinalizar.Focus()
    End Sub

    Private Sub btnFinalizar_LostFocus(sender As Object, e As EventArgs) Handles btnFinalizar.LostFocus
        btnCancelarVend.Focus()

    End Sub

    Private Sub btnCancelarVend_Click(sender As Object, e As EventArgs) Handles btnCancelarVend.Click
        Dispose()

    End Sub

    Private Sub FormVendaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class