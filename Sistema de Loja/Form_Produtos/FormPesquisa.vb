Imports System.Data.OleDb

Public Class FormPesquisa

    Private Sub ConferiEstMin2()

        Dim intEstqMin As Integer
        Dim intEm_Estq As Integer

        ''DataGridView.Rows[rowIndex].Cells["Em Estoque"].Style.BackColor = Color.Yellow;
        ''  dgEntradProduto.Rows(1).Cells("Em Estoque").Style.BackColor = Color.Yellow

        'For i As Integer = 0 To dgEntradProduto.Rows.Count() - 1

        '    'pegando o valor Em_estoque/varendo as linha de cima para baixo
        '    intEm_Estq = dgEntradProduto.Rows(i).Cells(6).Value.ToString

        '    'pegando valor EstqMinimo/varendo as linha de cima para baixo
        '    intEstqMin = dgEntradProduto.Rows(i).Cells(8).Value

        '    If intEm_Estq < intEstqMin Then
        '        dgEntradProduto.Rows(i).DefaultCellStyle.ForeColor = Color.Red

        '        '  dgEntradProduto.Columns(12).Name = "Repor estoque"
        '        dgEntradProduto.Columns(6).DefaultCellStyle.BackColor = Color.Blue




        '    End If

        '    ''Aqui coloco a coluna Valor venda produto em destaque
        '    dgEntradProduto.Rows(i).Cells("Vlr_Venda").Style.BackColor = Color.Red
        '    ''Aqui coloco a coluna Em Estoque em destaque
        '    dgEntradProduto.Rows(i).Cells("Em_Estoque").Style.BackColor = Color.Yellow
        'Next


    End Sub

    Private Sub FormatGridView()



        With dgEntradProduto

            '''''''escondendo colunas------
            ''.Columns(5).Visible = False
            '.Columns(8).Visible = False



            '''''''Regulando tamanho colunas-----
            .Columns(0).Width = 100  'codigo
            .Columns(1).Width = 300
            .Columns(2).Width = 100

            'Editando Cabeçalho
            '  .Columns(0).HeaderText = "Código "
            .Columns(0).HeaderText = "Codigo de Barras"
            .Columns(1).HeaderText = "Produto"
            '.Columns(3).HeaderText = "Total Entrada"
            '.Columns(4).HeaderText = "Custo Unitario"
            .Columns(2).HeaderText = "Valor Total Entrada"


            '.Columns(6).HeaderText = "Em Estoque"
            '.Columns(7).HeaderText = "Valor Venda Produto"
            '.Columns(8).HeaderText = "Qtd Minima Estoque"


            ''''''''''Aqui formato as colunas para moeda "Reais"
            .Columns(2).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"
            ' .Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"

            '' dgEntradProduto.Rows(1).Cells("codBarras").Style.BackColor = Color.Yellow
        End With


    End Sub

    Private Sub Pesquisacodbarra2()
        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " Select codBarras, descproduto, vlr_venda FROM TBProduto
                        Where codBarras LIKE '%" & Convert.ToInt64(txtPesquisaProdEntr.Text) & "%' "

            Dim comando As New OleDbCommand(SQL, Con)

            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable

            'atualizamos a datatable com as tabelas
            da.Fill(dt)

            dgEntradProduto.DataSource = Nothing
            dgEntradProduto.DataSource = dt

            Con.Close()




        Catch ex As Exception
            'Ao ser apagado o codigo de barras em cbPesquisaEntrProduto o sistema
            'cai aqui e faz o carregamento do GridView

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select codBarras, descproduto,  vlr_venda FROM TBProduto"

            Dim comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_produto")


            dgEntradProduto.DataSource = dt

            dgEntradProduto.DataSource = ds.Tables("tab_Produto")

        Finally

        End Try


    End Sub

    Private Sub PesquisaProduto2()
        Try
            ' If cbPesquisa.SelectedIndex = 0 Then

            Dim Con As New OleDbConnection             ' Dim SQL As String = " SELECT * FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " Select codBarras, descproduto, vlr_venda FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "


            Dim comando As New OleDbCommand(SQL, Con)

            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable

            'atualizamos a datatable com as tabelas
            da.Fill(dt)

            dgEntradProduto.DataSource = Nothing
            dgEntradProduto.DataSource = dt


            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

        End Try
    End Sub

    Private Sub FormPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPesquisaEntr.Select()





    End Sub

    Private Sub cbPesquisaEntr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisaEntr.SelectedIndexChanged

        Try
            txtPesquisaProdEntr.Enabled = True

        Catch ex As Exception

            Return

        End Try

        txtPesquisaProdEntr.Focus()


    End Sub

    Private Sub txtPesquisaProdEntr_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdEntr.TextChanged
        If cbPesquisaEntr.SelectedIndex = 0 Then

            Me.dgEntradProduto.Columns.Clear()

            PesquisaProduto2()

        Else

            Me.dgEntradProduto.Columns.Clear()
            Pesquisacodbarra2()



        End If

        FormatGridView()


        'verificando estoque baixo e colorindo
        ConferiEstMin2()





    End Sub
End Class