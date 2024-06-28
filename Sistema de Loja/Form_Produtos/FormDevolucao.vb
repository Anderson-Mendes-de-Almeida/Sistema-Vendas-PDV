Imports System.ComponentModel
Imports System.Data.OleDb

Public Class FormDevolucao
    'variavel pega item da ListView
    Public CodigoVenda As Integer

    'variavel para calculo para campo totalcompr da TBVendaProduto
    Public ResulVAlor As Decimal
    Public DecTotalCompr As Decimal
    Public decVlr_Uni As Decimal


    Dim douValorTotal As Double = 0

    'variaveis para LTtelavenda2
    Dim IntCodigo As Integer
    Dim douCodBrras As Double
    Dim intQtdProdu As Integer
    Dim decValorUnid As Decimal
    Dim strMotivoDevol As String


    Private Sub FormDevolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNuNota.Select()


    End Sub

    Private Sub txtNuNota_KeyUp(sender As Object, e As KeyEventArgs)





    End Sub



    Private Sub txtNuNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNuNota.KeyPress

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If
        If Asc(e.KeyChar) = 13 Then

            Try



                Dim Con As New OleDbConnection

                Con.ConnectionString = My.Settings.CN1
                Con.Open()

                Dim SQL As String = " SELECT * FROM TBVendaProduto WHERE codigovenda=" & txtNuNota.Text


                Dim comando As New OleDbCommand(SQL, Con)
                Dim Leitor As OleDbDataReader

                Leitor = comando.ExecuteReader

                Leitor.Read()

                Dim codNota As Integer = Leitor("codigovenda")
                Dim datacompra As String = Leitor("datacompra")
                Dim formapag As String = Leitor("formapag")
                Dim totalCompr As String = Leitor("totalCompr")
                Dim strMotivoDevol As String = Leitor("MotivoDevol") & ""

                Dim lvi As New ListViewItem
                lvi.Text = (codNota)
                lvi.SubItems.Add(datacompra)
                lvi.SubItems.Add(formapag)               '                'Aqui formato as colunas para moeda "Reais"
                lvi.SubItems.Add(FormatCurrency(totalCompr, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim)
                LtTelaVenda.Items.Add(lvi)
                lvi = Nothing

                txtMotivoDevol.Text = strMotivoDevol


            Catch ex As Exception

                MessageBox.Show("Produto não Existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txtNuNota.Clear()
                Return

                Dim itens As List(Of String) = New List(Of String)

                For Each item As ListViewItem In LtTelaVenda.Items
                    itens.Add(item.SubItems(0).Text)
                    itens.Add(item.SubItems(1).Text)
                    itens.Add(item.SubItems(2).Text)
                    itens.Add(item.SubItems(3).Text)

                    LtTelaVenda.Items.RemoveAt(item.Index)
                Next




            End Try

            'Limpando, colocando focu e desabilitando textbox
            txtNuNota.Text = ""
            txtNuNota.Focus()
            txtNuNota.Enabled = False
            BtLimpa.Enabled = False

            lblTotalProdu.Text = ""

            lblDevolvidos.Text = ""

        End If


    End Sub

    Private Sub BtLimpa_Click(sender As Object, e As EventArgs) Handles BtLimpa.Click



        Try

            'Limpando ListBox
            LtTelaVenda.Items.RemoveAt(0)

            LtTelaVenda.Enabled = True

            txtNuNota.Enabled = True
            BtLimpa.Enabled = False

            'Aqqui limpamos o ListView2,,, LTTelaVenda2

            Dim contador As Integer = Me.LtTelaVenda2.Items.Count

            For index = 1 To contador
                LtTelaVenda2.Items.RemoveAt(0)

            Next

            txtNuNota.Focus()
            txtMotivoDevol.Text = ""

            lblTotalProdu.Text = ""
        Catch ex As Exception
            Return
            txtNuNota.Focus()

        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LtTelaVenda_Click(sender As Object, e As EventArgs) Handles LtTelaVenda.Click
        DecTotalCompr = Me.LtTelaVenda.SelectedItems(0).SubItems(3).Text


        CodigoVenda = Me.LtTelaVenda.SelectedItems(0).Text

        'Desabilitando ListView
        LtTelaVenda.Enabled = False

        BtLimpa.Enabled = True
        BtLimpa.Focus()

        Try

            Dim Con As New OleDbConnection

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT * FROM TBProduVenda WHERE codigovenda=" & CodigoVenda     'txtNuNota.Text


            Dim comando As New OleDbCommand(SQL, Con)
            Dim Leitor As OleDbDataReader
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            '=======================================Aqui uso o DataReader para carrega a listView com a Coleção=========
            da.Fill(dt)
            da.Fill(ds, "TBProduVenda")
            Dim isql2 As String = "SELECT count(*) as qtd FROM TBProduVenda WHERE (CodigoVenda) =" & CodigoVenda

            Leitor = comando.ExecuteReader

            '  Dim n As Integer = Leitor.FieldCount
            Dim count As Integer = dt.Rows.Count

            Dim n As Integer = count

            'carregando lebol com numero produtos
            lblTotalProdu.Text = count

            'desabilitando textbox
            txtNuNota.Enabled = False

            For index = 1 To n
                Leitor.Read()

                Dim item As New ListViewItem(Leitor("Produto").ToString)
                item.SubItems.Add(Leitor("Codigo")).ToString()
                item.SubItems.Add(Leitor("codBarraProd").ToString())
                item.SubItems.Add(Leitor("quantidade").ToString())
                item.SubItems.Add(FormatCurrency(Leitor("valorunitario")))
                LtTelaVenda2.Items.Add(item)
            Next

            'liberando espaço
            Leitor.Dispose()
            Leitor.Close()
            comando.Dispose()

        Catch ex As Exception

            ' MessageBox.Show("Produto não Existente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(ex.Message)

        Finally



        End Try


        Try

            Dim Con As New OleDbConnection

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            'Dim comando As New OleDbCommand
            Dim Sql5 As String = " SELECT count(*) as c  FROM TBDevolucao WHERE codigovenda =" & CodigoVenda
            Dim comando5 As New OleDbCommand(Sql5, Con)

            Dim Leitor5 As OleDbDataReader
            Leitor5 = comando5.ExecuteReader
            Leitor5.Read()


            lblDevolvidos.Text = Leitor5("c").ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LtTelaVenda2_Click(sender As Object, e As EventArgs) Handles LtTelaVenda2.Click
        ' Dim CodBarras As String = LtTelaVenda2.SelectedItems.Item(1).Index
        'MessageBox.Show("Código do produto escolhido: " + LtTelaVenda2.SelectedItems(0).SubItems(0).Text)

        Try
            IntCodigo = LtTelaVenda2.SelectedItems(0).SubItems(1).Text
            douCodBrras = LtTelaVenda2.SelectedItems(0).SubItems(2).Text
            intQtdProdu = LtTelaVenda2.SelectedItems(0).SubItems(3).Text
            decValorUnid = LtTelaVenda2.SelectedItems(0).SubItems(4).Text


            'abilita btFinalizar
            btnFinalizar.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnCancelarVend_Click(sender As Object, e As EventArgs) Handles btnCancelarVend.Click
        Me.Close()

    End Sub


    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        'Fechando form1 para depois chamar no final da rotina, isso ira atualizar rotina nos forms
        Form1.Close()


        Dim IntEm_estoque As Integer
        Dim IntQtd_saida As Integer
        Dim douJaVendido As Decimal
        Dim Vlr_TotalSaida As Decimal
        Dim intCustoUni As Integer
        Dim intLucro As Integer

        ' variaveis TBDevolução
        Dim douCodBarras As Double
        Dim strProduto As String
        Dim intQtd As Integer
        Dim decVlrUni As Decimal
        Dim dataCancel As Date
        Dim strMotivo As String



        Dim Con As New OleDbConnection
        Dim Leitor As OleDbDataReader

        Con.ConnectionString = My.Settings.CN1
        Con.Open()


        Try

            Dim sql As String = "SELECT codBarras, DescProduto, Vlr_Unidade, Vlr_Venda, Em_estoque, Qtd_saida, Vlr_TotalSaida, Vendido, Lucro FROM TBProduto WHERE codbarras=" & douCodBrras
            Dim Comando As New OleDbCommand(sql, Con)

            Leitor = Comando.ExecuteReader

            Leitor.Read()

            '===============================Populando Tabela TBDevolução com registros "Produtos de devolvidos por clientes==============
            'Essas variaveis irei popular TBDevolução
            douCodBarras = Leitor("codBarras")
            strProduto = Leitor("DescProduto")
            intCustoUni = Leitor("Vlr_Unidade")
            decVlrUni = Leitor("Vlr_Venda")
            intLucro = Leitor("Lucro")
            'strMotivo = Leitor("Motvo")

            Dim Comando5 As New OleDbCommand
            Comando5.CommandText = "INSERT INTO TBDevolucao (codigovenda, CodBarras, Produto, Qtd, VlrUni, DataCancel, Motivo)" & " VALUES (?, ?, ?, ?, ?, ?, ?)"

            Comando5.Parameters.Clear()
            Comando5.Parameters.Add("@codigovenda", System.Data.OleDb.OleDbType.Integer, 13).Value = CodigoVenda
            Comando5.Parameters.Add("@CodBarras", System.Data.OleDb.OleDbType.Double, 13).Value = douCodBarras
            Comando5.Parameters.Add("@Produto", System.Data.OleDb.OleDbType.VarChar, 80).Value = strProduto
            Comando5.Parameters.Add("@Qtd", System.Data.OleDb.OleDbType.Integer, 1).Value = intQtdProdu
            Comando5.Parameters.Add("@VlrUni", System.Data.OleDb.OleDbType.Decimal, 13).Value = decVlrUni
            Comando5.Parameters.Add("@DataCancel", System.Data.OleDb.OleDbType.Date).Value = Now
            Comando5.Parameters.Add("@Motivo", System.Data.OleDb.OleDbType.VarChar, 4000).Value = txtMotivoDevol.Text

            Comando5.CommandType = CommandType.Text

            Comando5.Connection = Con

            Comando5.ExecuteNonQuery()

            '============================================================Aqui atualizo TBProduto, devolvendo proddutos e valores a Tabela==========

            'Vriaeveis para atualizar registro devolcidos a TBProduto
            IntEm_estoque = Leitor("Em_estoque")
            IntQtd_saida = Leitor("Qtd_saida")

            douJaVendido = Leitor("vendido")
            Vlr_TotalSaida = Leitor("Vlr_TotalSaida")

            'Calculando\Diminuindo o Lucro
            Dim intDevolLucro As Integer = decValorUnid - intCustoUni
            Dim Param_Lucro As Integer = intLucro - intDevolLucro

            'variavel resultado - Parametro
            Dim ParamQTD_Saida As Integer
            Dim ParamdouEm_Estoque As Integer
            Dim ParamDec_Vendido As Decimal
            Dim ParamVlr_TotalSaida As Decimal

            'Leitor.Close()
            Comando.Dispose()
            '=====================Calculando devolução=

            ParamQTD_Saida = IntQtd_saida - 1
            ParamdouEm_Estoque = IntEm_estoque + 1
            ParamDec_Vendido = douJaVendido - decValorUnid
            'ParamVlr_TotalSaida = Vlr_TotalSaida - decValorUnid

            Dim sql2 As String = "UPDATE TBProduto SET Em_Estoque=?, Qtd_saida=?, Vendido=?, Lucro=? WHERE codBarras=" & douCodBrras.ToString
            Dim Comando2 As New OleDbCommand(sql2, Con)

            Comando2.Parameters.Clear()
            Comando2.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", ParamdouEm_Estoque))
            Comando2.Parameters.Add(New OleDb.OleDbParameter("@Qtd_saida", ParamQTD_Saida))
            Comando2.Parameters.Add(New OleDb.OleDbParameter("@Vendido", ParamDec_Vendido))
            Comando2.Parameters.Add(New OleDb.OleDbParameter("@Lucro", Param_Lucro))


            Comando2.ExecuteNonQuery()

            Comando2.Dispose()

            '========================================Deletar registros de TBProdutos============================================

            Dim leitor2 As OleDbDataReader
            Dim comando3 As New OleDbCommand

            comando3.CommandText = " DELETE FROM TBProduVenda WHERE codigo=" & IntCodigo
            comando3.Connection = Con


            leitor2 = comando3.ExecuteReader


            leitor2.Read()
            comando3.Dispose()
            '======================================Aqui nesse trecho insiro texto sobre motivo=============================

            Dim sql4 As String = "UPDATE TBVendaProduto SET MotivoDevol=?, totalCompr=? WHERE CodigoVenda=" & CodigoVenda
            Dim Comando4 As New OleDbCommand(sql4, Con)

            'Calculando campo total comprar
            ResulVAlor = DecTotalCompr - decVlr_Uni

            Comando4.Parameters.Clear()
            Comando4.Parameters.Add(New OleDb.OleDbParameter("@MotivoDevol", txtMotivoDevol.Text))
            Comando4.Parameters.Add(New OleDb.OleDbParameter("@totalCompr", ResulVAlor.ToString))

            Comando4.ExecuteNonQuery()

            Comando4.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MessageBox.Show("Devolução efetuada com sucesso!", "SkyNetSystem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnFinalizar.Enabled = True

            Me.Close()

        End Try

        'Fechando conexões, 
        Con.Dispose()
        Con.Close()

        Form1.Show()

    End Sub

    Private Sub txtNuNota_TextChanged(sender As Object, e As EventArgs) Handles txtNuNota.TextChanged
        BtLimpa.Enabled = True

    End Sub

    Private Sub LtTelaVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtTelaVenda.SelectedIndexChanged

    End Sub

    Private Sub LtTelaVenda2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LtTelaVenda2.SelectedIndexChanged
        Try


        Catch ex As Exception
            Return

        End Try



    End Sub

    Private Sub LtTelaVenda2_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles LtTelaVenda2.ChangeUICues

    End Sub
    '// exibe detalhes
    'listView1.View = View.Details;
    '// permite ao usuário editar o texto
    'listView1.LabelEdit = true;
    ' // permite ao usuário rearranjar as colunas
    'listView1.AllowColumnReorder = true;
    ' // Selecione o item e subitem quando um seleção for feita
    'listView1.FullRowSelect = true;
    '// Exibe as linhas no ListView
    'listView1.GridLines = true;

    '// Anexa Subitems no ListView
    'listView1.Columns.Add("ProductName", 200, HorizontalAlignment.Left);
    'listView1.Columns.Add("ProductID", 70, HorizontalAlignment.Left);
    'listView1.Columns.Add("UnitPrice", 100, HorizontalAlignment.Left);

End Class
