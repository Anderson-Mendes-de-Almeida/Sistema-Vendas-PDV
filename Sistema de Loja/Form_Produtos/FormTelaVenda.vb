Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class FormTelaVenda
    Dim intTotal As Decimal = 0
    Dim intCodBarras As Int64
    Dim IntEm_estoque As Integer
    Dim IntQtd_saida As Integer = 0
    Dim douJaVendido As Double = 0
    Dim douVendido As Double = 0

    'varivel tipo de pagamento Radio Button
    Dim strrbTipoPag As String = ""

    'variaveis Tickets
    Dim Ticket As String = "c:\Pasta Ticket\Ticket.txt"
    Dim Diretorio As String = "c:\Pasta Ticket\"
    Private codutf As System.Text.Encoding
    Dim douCodBarras As Double
    Dim strItem As String
    Dim strPreco As String
    Dim intQtd As Integer
    Dim douValorTotal As Double
    Dim douTroco As Double
    Dim cont As Integer = 0
    'contando Items ListView
    Dim contador As Integer = 0

    Dim CodigoNota As Integer '' Variavel serve para numerar nota

    'variaveis para calcular Lucro
    Public douvlr_TotalSaida As Double
    Public douVlrVendido As Double
    'Essas duas vriaveis são usadas para calculo Lucro
    Public Param_douLucroSoma As Double
    Public Param_douLucro As Double


    'variaveis calculo Vlr_TotalSaida
    Dim decVLR_Unidade As Decimal


    Dim WithEvents PrintDoc As New System.Drawing.Printing.PrintDocument


    Private Sub PrintDocument()

        Try
            Dim ds = New dsRelatorio
            Dim Relatorio = New CrystalReport1
            ''Relatorio.SetDataSource(ds)   ''


            Dim Con As New OleDbConnection

            Con.ConnectionString = My.Settings.CN1
            Con.Open()


            Dim SQL As String = " SELECT * FROM  TBVendas "

            Dim da As New OleDbDataAdapter(SQL, Con)

            ''Dim ds As New dsRelatorio

            da.Fill(ds.Tables("DataTable2"))

            Relatorio.SetDataSource(ds)

            Dim dialogo = New PrintDialog

            '  PrintDoc.PrinterSettings.PrinterName = "EPSON LX-350"
            PrintDoc.PrinterSettings.PrinterName = "EPSONA39A7D (L355 Series)"

            Dim PkSize As New System.Drawing.Printing.PaperSize

            For intPaperSize As Integer = 0 To PrintDoc.PrinterSettings.PaperSizes.Count - 1

                If PrintDoc.PrinterSettings.PaperSizes.Item(intPaperSize).PaperName = "formularioContinuo" Then

                    PkSize = PrintDoc.PrinterSettings.PaperSizes.Item(intPaperSize)

                    Exit For

                End If

            Next

            Relatorio.PrintToPrinter(dialogo.PrinterSettings, dialogo.PrinterSettings.DefaultPageSettings, False)
        Catch ex As Exception

            MessageBox.Show("Erro ao Imprimir", ex.Message)

        End Try
    End Sub


    Private Sub FormTelaVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeletaTBVendas()

        txtCodBarras.Focus()


    End Sub

    Private Sub CarregaTBVendasHistorico()  ' Em manutenção--------------------
        Dim ResultQtd As Decimal
        Dim VlrUni As Decimal
        Dim decQtd As Decimal

        Dim con As New OleDbConnection
        con.ConnectionString = My.Settings.CN1
        con.Open()
        'Dim status As Boolean = con.State

        '===========================================Aqui Alimento a TBVendasHistorico============================================================
        Dim ComandoHisto As New OleDbCommand
        Try
            Dim itens2 As List(Of String) = New List(Of String)

            For Each itemSeg As ListViewItem In LtTelaVenda.Items   'Aqui tive duficuldade, muita atenção parametro deve usar variavel " ItemSeg "
                itens2.Add(itemSeg.SubItems(0).Text)
                itens2.Add(itemSeg.SubItems(1).Text)
                itens2.Add(itemSeg.SubItems(2).Text)
                itens2.Add(itemSeg.SubItems(3).Text)

                ' "INSERT INTO TBVendasHistorico (Codigonota, CodBarras, NomeCli, RUC_RG, Endereco, EmpresaCli, Pais, Produto, datacompra, ValorUni, QTD, CalcQtd, valorTotal, Dinheiro, Troco, tipopagamento)" & "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                ComandoHisto.CommandText = "INSERT INTO TBVendasHistorico (Codigonota, CodBarras,
                                            Produto, datacompra, ValorUni, QTD, CalcQtd, valorTotal,
                                            Dinheiro, Troco, tipopagamento)" & "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

                ComandoHisto.Parameters.Clear()

                ComandoHisto.Parameters.Add("@Codigonota", System.Data.OleDb.OleDbType.VarChar, 30).Value = CodigoNota

                ComandoHisto.Parameters.Add("@CodBarras", System.Data.OleDb.OleDbType.VarChar, 13).Value = itemSeg.SubItems(0).Text
                'ComandoHisto.Parameters.Add("@NomeCli", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtNomeCli.Text.ToString '' Aqui estou 
                'ComandoHisto.Parameters.Add("@RUC_RG", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtDoc.Text.ToString
                'ComandoHisto.Parameters.Add("@Endereco", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtEndereco.Text.ToString
                'ComandoHisto.Parameters.Add("@EmpresaCli", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtEmpresaCli.Text.ToString
                'ComandoHisto.Parameters.Add("@Pais", System.Data.OleDb.OleDbType.VarChar, 50).Value = cbPaises.Text.ToString

                ComandoHisto.Parameters.Add("@Produto", System.Data.OleDb.OleDbType.VarChar, 30).Value = itemSeg.SubItems(1).Text
                ComandoHisto.Parameters.Add("@dataCompra", System.Data.OleDb.OleDbType.Date, 13).Value = Now
                ComandoHisto.Parameters.Add("@ValorUni", System.Data.OleDb.OleDbType.VarChar, 12).Value = itemSeg.SubItems(2).Text
                ComandoHisto.Parameters.Add("@QTD", System.Data.OleDb.OleDbType.VarChar, 12).Value = itemSeg.SubItems(3).Text

                VlrUni = itemSeg.SubItems(2).Text
                decQtd = itemSeg.SubItems(3).Text

                ResultQtd = VlrUni * decQtd

                ComandoHisto.Parameters.Add("@CalcQtd", System.Data.OleDb.OleDbType.VarChar, 12).Value = FormatCurrency(ResultQtd).ToString ''aqui formato com moeda, simbolo do sistema
                ComandoHisto.Parameters.Add("@ValorTotal", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtTotalPagar.Text
                ComandoHisto.Parameters.Add("@Dinheiro", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtDinheiro.Text
                ComandoHisto.Parameters.Add("@Troco", System.Data.OleDb.OleDbType.VarChar, 30).Value = txttroco.Text
                ComandoHisto.Parameters.Add("@tipopagamento", System.Data.OleDb.OleDbType.VarChar, 12).Value = strrbTipoPag



                ComandoHisto.CommandType = CommandType.Text


                ComandoHisto.Connection = con


            Next

            ComandoHisto.ExecuteNonQuery()

            ComandoHisto.Dispose()




        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try







    End Sub
    Private Sub DeletaTBVendas()

        Dim Con As New OleDbConnection

        Con.ConnectionString = My.Settings.CN1
        Con.Open()

        Dim leitor As OleDbDataReader
        Dim comando5 As New OleDbCommand

        comando5.CommandText = " DELETE FROM TBVendas"
        comando5.Connection = Con


        leitor = comando5.ExecuteReader




        leitor.Read()

        Con.Dispose()
        Con.Close()


    End Sub
    Private Sub PegaNumeroNota()

        Dim Con As New OleDbConnection

        Con.ConnectionString = My.Settings.CN1
        Con.Open()

        Dim leitor As OleDbDataReader
        Dim comando5 As New OleDbCommand

        comando5.CommandText = " SELECT count(*) as c FROM TBVendaProduto "
        comando5.Connection = Con


        leitor = comando5.ExecuteReader
        leitor.Read()

        'pegando numero de registro TBVendaProduto
        CodigoNota = leitor("c")
        CodigoNota = CodigoNota + 1

        leitor.Close()

        Con.Dispose()
        Con.Close()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPagar.TextChanged
        Try
            txtTotalPagar.Text = FormatCurrency(txtTotalPagar.Text, 2, TriState.True,
                            TriState.True, TriState.True).Replace("R$", "R$").Trim

        Catch ex As Exception

        End Try

    End Sub


    Private Sub CriarTicket()


        Try
            codutf = System.Text.Encoding.GetEncoding("ISO-8859-1")
            Dim fluxotexto As IO.StreamWriter
            fluxotexto = New IO.StreamWriter(Ticket, True, codutf)

            Dim dateHorario As Date
            Dim Cabecalho As String
            Dim Endereco As String
            Dim Mascara As String
            Dim texto As String
            Dim Espaco As String
            Dim Tel As String

            cont = cont + 1

            If cont = 1 Then
                dateHorario = Now
                Tel = "Tel: (011) 9 8038-2194"
                Cabecalho = "Depósito e Casa de Ferragens Oliveira"
                Endereco = "Rua Guaicuri, nº 30 A Vila Missionária SP" & vbCrLf
                Mascara = "Cod.Barra     Produto     Preço      QTD"
                fluxotexto.WriteLine(dateHorario)
                fluxotexto.WriteLine(Tel)
                fluxotexto.WriteLine(Cabecalho)
                fluxotexto.WriteLine(Endereco)
                fluxotexto.WriteLine(Mascara)
            End If


            texto = douCodBarras & " " & strItem & " " & strPreco & " " & intQtd
            Espaco = "--------------------------------------------------------------------------------                                                                                                                                                                                                                                                                                                                                                                                                   "

            fluxotexto.WriteLine(texto)


            If cont = contador Then
                fluxotexto.WriteLine("                                   ")
                fluxotexto.WriteLine("Total                           " & txtTotalPagar.Text)
                fluxotexto.WriteLine("Dinheiro                        " & txtDinheiro.Text)
                fluxotexto.WriteLine("Troco                           " & txttroco.Text)

                fluxotexto.WriteLine(Espaco)
            End If
            fluxotexto.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        System.IO.File.Copy("c:\Pasta Ticket\Ticket.txt", "LPT1", True)


    End Sub
    Private Sub Em_estoque()

        Try

            Dim Con As New OleDbConnection

            Con.ConnectionString = My.Settings.CN1
            Con.Open()


            Dim sql As String = "SELECT Em_estoque, Qtd_saida, Vlr_Venda FROM TBProduto WHERE codbarras=" & intCodBarras
            Dim Comando As New OleDbCommand(sql, Con)

            Dim Leitor As OleDbDataReader
            Leitor = Comando.ExecuteReader

            Leitor.Read()

            IntEm_estoque = Leitor("Em_estoque")
            IntQtd_saida = Leitor("Qtd_saida")
            douJaVendido = Leitor("Vlr_Venda")
            ' douJaVendido = Leitor("Vendido")


            Leitor.Close()
            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub txtCodBarras_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyUp
        'Buscando Produto pelo codigo para venda
        Try
            If (e.KeyCode = Keys.Enter) Then



                Dim Con As New OleDbConnection

                Con.ConnectionString = My.Settings.CN1
                Con.Open()

                Dim SQL As String = " SELECT codbarras, descproduto, vlr_venda
                                      FROM TBProduto Where codbarras=" & txtCodBarras.Text


                Dim comando As New OleDbCommand(SQL, Con)
                Dim Leitor As OleDbDataReader
                Leitor = comando.ExecuteReader
                Leitor.Read()

                intCodBarras = Leitor("codbarras")
                Dim strDescProuto As String = Leitor("descproduto")
                Dim doubVlr_Venda As Decimal = Leitor("vlr_venda")



                If LtTelaVenda.Items.Count = 0 Then
                    '  LtTelaVenda.View = View.Details
                    Dim lvi As New ListViewItem
                    lvi.Text = (intCodBarras)
                    lvi.SubItems.Add(strDescProuto)
                    lvi.SubItems.Add(FormatCurrency(doubVlr_Venda, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim)
                    lvi.SubItems.Add(txtqtd.Text)
                    LtTelaVenda.Items.Add(lvi)
                    lvi = Nothing
                Else
                    Dim lvi As New ListViewItem
                    lvi.Text = (intCodBarras)
                    lvi.SubItems.Add(strDescProuto)
                    lvi.SubItems.Add(FormatCurrency(doubVlr_Venda, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim)
                    lvi.SubItems.Add(txtqtd.Text)
                    LtTelaVenda.Items.Add(lvi)
                    lvi = Nothing


                End If

                '-----------------------passando valor 


                txtDescricao.Text = strDescProuto    'LtTelaVenda.CurrentRow.Cells(1).Value.ToString()


                Dim intQtd As Integer = txtqtd.Text
                Dim decResul As Decimal

                decResul = intQtd * doubVlr_Venda

                'somando todos os produtos
                intTotal = intTotal + decResul                ' dgTelaVenda.CurrentRow.Cells(2).Value.ToString()

                'Dim intQtd As Integer = txtqtd.Text
                'intTotal = intQtd * intTotal

                'exibindo no textbox
                txtTotalPagar.Text = intTotal


                Con.Close()

                txtCodBarras.Text = ""
                txtqtd.Clear()
                txtqtd.Text = 1

            End If


        Catch ex As Exception
            MessageBox.Show("Produto não Existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCodBarras.Clear()
            txtCodBarras.Focus()

            Return 

        Finally
            ' txtTotalPagar.Enabled = True
            txtDinheiro.Enabled = True


        End Try



    End Sub

    Private Sub txtTroco_TextChanged(sender As Object, e As EventArgs)
        txttroco.Text = FormatCurrency(txttroco.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim




    End Sub



    Private Sub txtDinheiro_LostFocus(sender As Object, e As EventArgs) Handles txtDinheiro.LostFocus
        btnFinalizar.Enabled = True

        Try

            txtDinheiro.Text = FormatCurrency(txtDinheiro.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim



            'calculando valor de troco
            Dim doubTroco As String
            doubTroco = txtDinheiro.Text - (intTotal)

            txttroco.Text = doubTroco

        Catch ex As Exception
            txtCodBarras.Focus()
        End Try

    End Sub


    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        'Form1.Close()

        If LtTelaVenda.Items.Count < 1 Then
            MessageBox.Show("Não à produtos cadastrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        End If

        'procedure Carrega valor Em_estoque e Vedido
        Em_estoque()

        Dim Param_Em_Est As Integer
        Dim Param_Qtd_saida As Integer
        Dim Param_Vendido As Double
        Dim Paramvlr_TotalSaida As Double
        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()



            '===========================================Aqui do baixa nos produtos vendidos ====================================
            Dim itens As List(Of String) = New List(Of String)

            For Each item As ListViewItem In LtTelaVenda.Items
                contador = LtTelaVenda.Items.Count
                itens.Add(item.SubItems(0).Text)
                intQtd = (item.SubItems(3).Text)

                Dim sql2 As String = "SELECT Vlr_Unidade, Qtd_Saida, Vlr_TotalSaida, Em_estoque, Vendido FROM TBProduto WHERE codbarras=" & item.Text
                Dim Comando2 As New OleDbCommand(sql2, Con)

                Dim Leitor As OleDbDataReader
                Leitor = Comando2.ExecuteReader

                Leitor.Read()

                decVLR_Unidade = Leitor("Vlr_Unidade")
                douvlr_TotalSaida = Leitor("Vlr_TotalSaida")
                IntEm_estoque = Leitor("Em_estoque")
                IntQtd_saida = Leitor("Qtd_saida")
                douJaVendido = Leitor("vendido")

                douVendido = (item.SubItems(2).Text) * intQtd

                Param_Em_Est = (IntEm_estoque) - intQtd
                Param_Qtd_saida = (IntQtd_saida) + intQtd
                Param_Vendido = douJaVendido + douVendido
                'Aqui calculamos VLR_TotalSaida
                Paramvlr_TotalSaida = Param_Qtd_saida * decVLR_Unidade
                'Aqui variaveis para Lucro, efetuando calculo de Lucro
                Param_douLucro = Param_Vendido - Paramvlr_TotalSaida


                '===============================Dando baixa em Banco de dados , Em_Estoque e vendido=================================
                Dim sql As String = "UPDATE TBProduto SET Vlr_TotalSaida=?, Em_Estoque=?, Qtd_saida=?, Vendido=?, Lucro=? WHERE codBarras=" & item.Text
                Dim Comando As New OleDbCommand(sql, Con)

                Comando.Parameters.Clear()
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Vlr_TotalSaida", Paramvlr_TotalSaida))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", Param_Em_Est))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Qtd_saida", Param_Qtd_saida))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Vendido", Param_Vendido))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Lucro=?", Param_douLucro))


                Comando.ExecuteNonQuery()

                Comando2.Dispose()
                Comando.Dispose()

                Leitor.Close()

            Next
            Con.Dispose()
            Con.Close()


            ' ============================Inserindo dados na Tabela Vendas================================================================
            Try
                Dim Con2 As New OleDbConnection
                Con2.ConnectionString = My.Settings.CN1
                Con2.Open()

                'Aqui deleta ou cria pasta
                If Not IO.Directory.Exists(Diretorio) Then
                    IO.Directory.CreateDirectory(Diretorio)

                End If

                'Esse codigo apaga o arquivo de ticket.txt se ele existir
                If IO.File.Exists(Ticket) Then
                    IO.File.Delete(Ticket)
                    Dim Criar = IO.File.CreateText(Ticket)
                    Criar.Close()
                End If

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
                    douTroco = txttroco.Text

                    PegaNumeroNota()

                    Dim Comando3 As New OleDbCommand
                    Comando3.CommandText = "INSERT INTO TBVendas (Codigonota, CodBarras, NomeCli, RUC_RG, Endereco,  Pais, EmpresaCli, Produto, datacompra, ValorUni, QTD, CalcQtd, valorTotal, Dinheiro, Troco, tipopagamento)" & "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

                    Comando3.Parameters.Clear()

                    Comando3.Parameters.Add("@Codigonota", System.Data.OleDb.OleDbType.VarChar, 30).Value = CodigoNota

                    Comando3.Parameters.Add("@CodBarras", System.Data.OleDb.OleDbType.VarChar, 13).Value = itemSeg.SubItems(0).Text
                    'Comando3.Parameters.Add("@NomeCli", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtNomeCli.Text.ToString '' Aqui estou 
                    'Comando3.Parameters.Add("@RUC_RG", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtDoc.Text.ToString
                    'Comando3.Parameters.Add("@Endereco", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtEndereco.Text.ToString
                    'Comando3.Parameters.Add("@Pais", System.Data.OleDb.OleDbType.VarChar, 50).Value = cbPaises.Text.ToString
                    'Comando3.Parameters.Add("@EmpresaCli", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtEmpresaCli.Text.ToString

                    Comando3.Parameters.Add("@Produto", System.Data.OleDb.OleDbType.VarChar, 80).Value = itemSeg.SubItems(1).Text
                    Comando3.Parameters.Add("@dataCompra", System.Data.OleDb.OleDbType.Date, 13).Value = Now
                    Comando3.Parameters.Add("@ValorUni", System.Data.OleDb.OleDbType.VarChar, 12).Value = itemSeg.SubItems(2).Text
                    Comando3.Parameters.Add("@QTD", System.Data.OleDb.OleDbType.VarChar, 12).Value = itemSeg.SubItems(3).Text

                    Dim VlrUni As Decimal = itemSeg.SubItems(2).Text
                    Dim decQtd As Decimal = itemSeg.SubItems(3).Text
                    Dim resulQtd As Decimal

                    resulQtd = VlrUni * decQtd

                    Comando3.Parameters.Add("@CalcQtd", System.Data.OleDb.OleDbType.VarChar, 12).Value = FormatCurrency(resulQtd).ToString ''aqui formato com moeda, simbolo do sistema
                    Comando3.Parameters.Add("@ValorTotal", System.Data.OleDb.OleDbType.VarChar, 13).Value = txtTotalPagar.Text
                    Comando3.Parameters.Add("@Dinheiro", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtDinheiro.Text
                    Comando3.Parameters.Add("@Troco", System.Data.OleDb.OleDbType.VarChar, 30).Value = txttroco.Text
                    Comando3.Parameters.Add("@tipopagamento", System.Data.OleDb.OleDbType.VarChar, 12).Value = strrbTipoPag



                    'Essa função é usada para inserir dados na TBHitorico
                    ' CarregaTBVendasHistorico()

                    '========================================Aqui crio o Ticket=============================================================================
                    'CriarTicket()
                    '=======================================================================================================================================


                    'Comando finais TBVendas----------Esses dados são apagados sempre, para obter numero NOTA

                    Comando3.CommandType = CommandType.Text


                    Comando3.Connection = Con2

                    'Comando3.ExecuteNonQuery()

                    Comando3.Dispose()

                    'CarregaTBVendasHistorico()

                Next
                '  CarregaTBVendasHistorico()
                '    '===================================Inserindo Dados TBVendaProduto==============================================================
                Dim leitor As OleDbDataReader
                Dim comando5 As New OleDbCommand
                Dim mes As Integer = Now.Month

                Dim intRegistro As Integer

                comando5.CommandText = " SELECT count(*) as c FROM TBVendaProduto "
                comando5.Connection = Con2


                leitor = comando5.ExecuteReader
                leitor.Read()

                'pegando numero de registro TBVendaProduto
                intRegistro = leitor("c")


                leitor.Close()


                '=====================================Inserindo registro tabela TBVendaProduto=================================================
                'Aqui adiciono sempre + 1 no mero de registros do campo
                intRegistro = intRegistro + 1

                Dim Comando4 As New OleDbCommand
                Comando4.CommandText = "INSERT INTO TBVendaProduto (codigovenda, datacompra, formaPag, totalcompr, nomeclideve)" & "VALUES (?, ?, ?, ?, ?)"

                Comando4.Parameters.Clear()

                Comando4.Parameters.Add("@codigovenda", System.Data.OleDb.OleDbType.Integer, 30).Value = intRegistro
                Comando4.Parameters.Add("@dataCompra", System.Data.OleDb.OleDbType.Date, 30).Value = Now
                Comando4.Parameters.Add("@formaPag", System.Data.OleDb.OleDbType.VarChar, 30).Value = strrbTipoPag
                Comando4.Parameters.Add("@totalcompr", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtTotalPagar.Text

                If StrNomeCliDeve = Nothing Then

                    Comando4.Parameters.Add("@nomeclideve", System.Data.OleDb.OleDbType.VarChar, 30).Value = "Pago"

                Else
                    Comando4.Parameters.Add("@nomeclideve", System.Data.OleDb.OleDbType.VarChar, 30).Value = StrNomeCliDeve

                End If


                Comando4.CommandType = CommandType.Text

                Comando4.Connection = Con2

                Comando4.ExecuteNonQuery()

                Comando4.Dispose()


                '================================================================================================================

                Dim itens4 As List(Of String) = New List(Of String)
                Dim codBarra As String


                For Each itemQuar As ListViewItem In LtTelaVenda.Items
                    itens4.Add(itemQuar.SubItems(0).Text)
                    itens4.Add(itemQuar.SubItems(2).Text)
                    itens4.Add(itemQuar.SubItems(3).Text)

                    codBarra = itemQuar.SubItems(0).Text

                    Dim contitens As Integer = 0

                    For Each item In LtTelaVenda.Items

                        If codBarra = item.SubItems.Item(0).Text Then
                            contitens += 1

                        End If

                    Next


                    Comando4.CommandText = "INSERT INTO TBProduVenda (codigovenda, CodBarraProd, produto, quantidade, valorUnitario, datacompra)" & "VALUES (?, ?, ?, ?, ?, ?)"

                    Comando4.Parameters.Clear()

                    Comando4.Parameters.Add("@codigovenda", System.Data.OleDb.OleDbType.Integer, 30).Value = intRegistro
                    Comando4.Parameters.Add("@CodBarraProd", System.Data.OleDb.OleDbType.VarChar, 20).Value = itemQuar.SubItems(0).Text
                    Comando4.Parameters.Add("@produto", System.Data.OleDb.OleDbType.VarChar, 80).Value = itemQuar.SubItems(1).Text
                    Comando4.Parameters.Add("@quantidade", System.Data.OleDb.OleDbType.VarChar, 30).Value = itemQuar.SubItems(3).Text
                    Comando4.Parameters.Add("@valorUnitario", System.Data.OleDb.OleDbType.VarChar, 30).Value = itemQuar.SubItems(2).Text
                    Comando4.Parameters.Add("@datacompra", System.Data.OleDb.OleDbType.Date).Value = Now


                    Comando4.CommandType = CommandType.Text

                    Comando4.Connection = Con2


                    Comando4.ExecuteNonQuery()

                    Comando4.Dispose()


                Next
                Con2.Dispose()
                Con2.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try


            MessageBox.Show("Venda Finalizada com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtDescricao.Clear()
            txtDinheiro.Text = 0
            txtTotalPagar.Text = 0
            txttroco.Text = 0




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            LtTelaVenda.Clear()


        End Try


        Dispose()
        Close()

        'Me.Dispose()

        FormImprimir.Show()

        PrintDocument()

        'abrindo formulario para atualizar
        ' Form1.TopMost = False

        '  Form1.Show()



    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Form1.Show()

        Me.Close()

    End Sub



    Private Sub txttroco_TextChanged_1(sender As Object, e As EventArgs) Handles txttroco.TextChanged

        txttroco.Text = FormatCurrency(txttroco.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

    End Sub



    Private Sub btnFinalizar_KeyDown(sender As Object, e As KeyEventArgs) Handles btnFinalizar.KeyDown
        txtCodBarras.Focus()

    End Sub

    Private Sub rbDinheiro_LostFocus(sender As Object, e As EventArgs) Handles rbDinheiro.LostFocus
        ' rbCartao.Focus()
        '  rbDinheiro.BackColor = Color.Gray
        ' rbCartao.Checked = True
        rbDinheiro.ForeColor = Color.White

    End Sub



    Private Sub rbCartao_LostFocus(sender As Object, e As EventArgs) Handles rbCartao.LostFocus
        rbCartao.ForeColor = Color.White


    End Sub



    Private Sub rbDinheiro_Click(sender As Object, e As EventArgs) Handles rbDinheiro.Click
        strrbTipoPag = "Dinheiro"
        '  rbDinheiro.BackColor = Color.Yellow


        rbDinheiro.ForeColor = Color.Yellow
    End Sub

    Private Sub rbCheque_Click(sender As Object, e As EventArgs) Handles rbFiado.Click
        strrbTipoPag = "Fiado"
        rbFiado.ForeColor = Color.Yellow

    End Sub

    Private Sub rbCartao_Click(sender As Object, e As EventArgs) Handles rbCartao.Click
        strrbTipoPag = "Cartão"
        '  rbCartao.BackColor = Color.Yellow
        rbCartao.ForeColor=Color.Yellow

    End Sub

    Private Sub LtTelaVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtTelaVenda.SelectedIndexChanged

    End Sub

    Private Sub txtDinheiro_Click(sender As Object, e As EventArgs) Handles txtDinheiro.Click

        txtDinheiro.BackColor = Color.Yellow

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtDinheiro_TextChanged(sender As Object, e As EventArgs) Handles txtDinheiro.TextChanged
        '  txtDinheiro.BackColor = Color.Yellow

    End Sub

    Private Sub txtDinheiro_GotFocus(sender As Object, e As EventArgs) Handles txtDinheiro.GotFocus
        txtDinheiro.BackColor = Color.Yellow
    End Sub

    Private Sub txtDinheiro_Leave(sender As Object, e As EventArgs) Handles txtDinheiro.Leave
        txtDinheiro.BackColor = Color.White

    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDesconto.Click
        Dim douDesconto As Double

        douDesconto = 3 * txtTotalPagar.Text / 100
        douDesconto = FormatCurrency(douDesconto, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim()

        MessageBox.Show("Desconto efetuado de R$ " & douDesconto)

        ' txtTotalPagar.Text = ""
        intTotal = CDbl(txtTotalPagar.Text) - douDesconto
        txtTotalPagar.Text = intTotal

        txtDinheiro.Focus()


    End Sub

    Private Sub btnDesconto_LostFocus(sender As Object, e As EventArgs) Handles btnDesconto.LostFocus

        rbDinheiro.Checked = True

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        FormRelatorio.Show()




    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim ds = New dsRelatorio
        Dim Relatorio = New CrystalReport1
        ''Relatorio.SetDataSource(ds)   ''


        Dim Con As New OleDbConnection

        Con.ConnectionString = My.Settings.CN1
        Con.Open()


        Dim SQL As String = " SELECT * FROM  TBVendas "

        Dim da As New OleDbDataAdapter(SQL, Con)

        ''Dim ds As New dsRelatorio

        da.Fill(ds.Tables("DataTable2"))

        Relatorio.SetDataSource(ds)

        Dim dialogo = New PrintDialog

        PrintDoc.PrinterSettings.PrinterName = "EPSON LX-350"

        Dim PkSize As New System.Drawing.Printing.PaperSize

        For intPaperSize As Integer = 0 To PrintDoc.PrinterSettings.PaperSizes.Count - 1

            If PrintDoc.PrinterSettings.PaperSizes.Item(intPaperSize).PaperName = "formularioContinuo" Then

                PkSize = PrintDoc.PrinterSettings.PaperSizes.Item(intPaperSize)

                Exit For

            End If

        Next

        Relatorio.PrintToPrinter(dialogo.PrinterSettings, dialogo.PrinterSettings.DefaultPageSettings, False)


    End Sub
    Private Sub PrintDoc_QueryPageSettings(ByVal sender As Object, ByRef e As Printing.QueryPageSettingsEventArgs)
        e.PageSettings.Landscape = True


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormPesquisa.Show()

    End Sub

    Private Sub rbDinheiro_GotFocus(sender As Object, e As EventArgs) Handles rbDinheiro.GotFocus
        'rbDinheiro.BackColor = Color.Yellow

    End Sub

    Private Sub rbCartao_GotFocus(sender As Object, e As EventArgs) Handles rbCartao.GotFocus
        'rbCartao.BackColor = Color.Yellow

    End Sub


    Private Sub rbCheque_GotFocus(sender As Object, e As EventArgs) Handles rbFiado.GotFocus
        'rbCheque.BackColor = Color.Yellow
        ' rbCheque.Checked = True

    End Sub

    Private Sub rbCheque_LostFocus(sender As Object, e As EventArgs) Handles rbFiado.LostFocus
        rbFiado.ForeColor = Color.White


    End Sub


    Private Sub cbPaises_LostFocus(sender As Object, e As EventArgs)
        btnFinalizar.Focus()




    End Sub

    Private Sub rbCartao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rbCartao.KeyPress

    End Sub

    Private Sub rbCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rbFiado.CheckedChanged
        FormFiados.Show()

    End Sub

    Private Sub rbCartao_CheckedChanged(sender As Object, e As EventArgs) Handles rbCartao.CheckedChanged

    End Sub

    Private Sub rbDinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rbDinheiro.CheckedChanged

    End Sub
End Class