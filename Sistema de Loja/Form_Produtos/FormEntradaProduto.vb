Imports System.Data.OleDb

Public Class FormEntradaProduto
    'Pegando o codigo Protudo em DataGrid
    Dim intcodigo As Integer

    'Pegando a quantidade de entrada
    Dim intQtd_Entrada As Integer
    'pegando valor celula totalEntraProduto em dgEntradaProduto
    Dim douVlrTotalEntr As Double

    Private Sub ConferiEstMin2()

        Dim intEstqMin As Integer
        Dim intEm_Estq As Integer

        For i As Integer = 0 To dgEntradProduto.Rows.Count() - 1

            'pegando o valor Em_estoque/varendo as linha de cima para baixo
            intEm_Estq = dgEntradProduto.Rows(i).Cells(5).Value.ToString

            'pegando valor EstqMinimo/varendo as linha de cima para baixo
            intEstqMin = dgEntradProduto.Rows(i).Cells(7).Value

            If intEm_Estq < intEstqMin Then
                dgEntradProduto.Rows(i).DefaultCellStyle.ForeColor = Color.Red

                '  dgEntradProduto.Columns(12).Name = "Repor estoque"





            End If

        Next


    End Sub
    Private Sub AtualizaRegistro2()

        Try

            Dim Con As New OleDbConnection             ' Dim SQL As String = " SELECT * FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codigo, codbarras, descproduto, Qtd_Entrada, vlr_unidade, vlr_totalEntrada,  Em_Estoque, vlr_venda, estoque_minimo  FROM TBProduto "

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

        End Try
    End Sub


    Private Sub FormatGridView()
        With dgEntradProduto

            '''''''escondendo colunas------
            .Columns(5).Visible = False
            '.Columns(8).Visible = False
            '.Columns(9).Visible = False
            '.Columns(10).Visible = False
            '.Columns(11).Visible = False
            '.Columns(12).Visible = False
            '.Columns(13).Visible = False
            '.Columns(14).Visible = False


            '''''''Regulando tamanho colunas-----
            .Columns(0).Width = 50  'codigo
            .Columns(3).Width = 100
            .Columns(2).Width = 150

            'Editando Cabeçalho
            .Columns(0).HeaderText = "Código "
            .Columns(1).HeaderText = "Codigo de Barras"
            .Columns(2).HeaderText = "Produto"
            .Columns(3).HeaderText = "Total Entrada"
            .Columns(4).HeaderText = "Custo Unitario"
            '   .Columns(5).HeaderText = "Valor Total Entrada"


            .Columns(6).HeaderText = "Em Estoque"
            .Columns(7).HeaderText = "Valor Venda Produto"
            .Columns(8).HeaderText = "Qtd Minima Estoque"



            ''''''''''Aqui formato as colunas para moeda "Reais"
            .Columns(4).DefaultCellStyle.Format = "c2"
            .Columns(7).DefaultCellStyle.Format = "c2"
            ' .Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"


        End With



    End Sub

    Private Sub PesquisaProduto2()
        Try
            ' If cbPesquisa.SelectedIndex = 0 Then

            Dim Con As New OleDbConnection             ' Dim SQL As String = " SELECT * FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codigo, codbarras, descproduto, vlr_unidade, vlr_venda, Em_Estoque,  Qtd_Entrada, estoque_minimo  FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "

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

    Private Sub Pesquisacodbarra2()
        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codigo, codbarras, descproduto, vlr_unidade, vlr_venda, Em_Estoque, Qtd_Entrada, estoque_minimo FROM TBProduto Where codBarras LIKE '%" & Convert.ToInt32(txtPesquisaProdEntr.Text) & "%' "

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
            Dim Sql As String = " Select codigo, codbarras, descproduto, vlr_unidade, vlr_venda, Em_Estoque,Qtd_Entrada,
                                  estoque_minimo FROM TBProduto"
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
    Private Sub FormEntradaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Use esse código para limpar a caixa de texto
        'Pois percebi que a mesma iniciava com valores
        txtEntradaProduto.Text = Nothing

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select Codigo, codBarras, descproduto, Qtd_Entrada, vlr_unidade, vlr_TotalEntrada, Em_Estoque, vlr_venda,  estoque_minimo FROM TBProduto"
            Dim comando As New OleDbCommand(Sql, Con)


            '-----------------------------------
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_produto")


            dgEntradProduto.DataSource = dt

            ds.Dispose()

            FormatGridView()

            cbPesquisaEntr.Focus()

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar com Base de Dados : " & ex.Message)

        End Try

        'verificando estoque baixo e colorindo
        ConferiEstMin2()

        '---------------Mudando a cor de Cabeçalho DatagridView------------------
        dgEntradProduto.EnableHeadersVisualStyles = False
        'muda cor Headers
        dgEntradProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver
        'mudar co lateral esquerda
        'dgSaidaProduto.RowHeadersDefaultCellStyle.BackColor = Color.Black

    End Sub

    Private Sub FormEntradaProduto_Click(sender As Object, e As EventArgs) Handles MyBase.Click


    End Sub

    Private Sub dgEntradProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEntradProduto.CellClick

        txtEntradaProduto.Focus()

        'pegando a quantia em Qtd_Entrada
        intQtd_Entrada = dgEntradProduto.CurrentRow.Cells(3).Value.ToString
        'Pegando a quantidade em estoque
        Dim QTDEmEstoq As String = dgEntradProduto.CurrentRow.Cells(6).Value.ToString
        'pegando o codigo do produto
        intcodigo = dgEntradProduto.CurrentRow.Cells(0).Value.ToString
        'pegando Valor Total Entrada
        douVlrTotalEntr = dgEntradProduto.CurrentRow.Cells(5).Value.ToString
        'MessageBox.Show(douVlrTotalEntr)

        txtEm_Estoque.Text = QTDEmEstoq



    End Sub

    Private Sub cbPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisaEntr.SelectedIndexChanged
        Try
            txtPesquisaProdEntr.Enabled = True

        Catch ex As Exception



            Return


        End Try

        txtPesquisaProdEntr.Focus()
    End Sub

    Private Sub txtPesquisaProdEntr_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdEntr.TextChanged
        If cbPesquisaEntr.SelectedIndex = 0 Then
            ' dgEntradProduto.ClearSelection()
            '  Me.dgEntradProduto.Columns.Clear()

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

    Private Sub dgEntradProduto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEntradProduto.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub



    Private Sub txtEntradaProduto_TextChanged(sender As Object, e As EventArgs) Handles txtEntradaProduto.TextChanged

    End Sub

    Private Sub txtEntradaProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEntradaProduto.KeyPress




    End Sub

    Private Sub btnSalvarEntradaProd_Click(sender As Object, e As EventArgs) Handles btnSalvarEntradaProd.Click
        'variavel quantidade em Estoque
        Dim intEm_Estoque As Integer
        'variavel quantidade QtdEm_trada
        Dim intQtd_Entrada2 As Integer
        'varivel passando valor paametro
        Dim param_VlrTotalEntr As Double


        Try
            If txtEntradaProduto.Text = Nothing Then
                MessageBox.Show("Digite a Quantidade de Produtos para Atualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else

                Dim Con As New OleDbConnection
                Con.ConnectionString = My.Settings.CN1
                Con.Open()

                intcodigo = dgEntradProduto.CurrentRow.Cells(0).Value.ToString

                Dim sql As String = "UPDATE TBProduto SET Em_Estoque=?, qtd_Entrada=?, vlr_totalEntrada=? WHERE codigo=" & intcodigo
                Dim Comando As New OleDbCommand(sql, Con)

                '--------------------somando valor do grid---------------------------------

                'acrecentando entrada em Em_Estque
                intEm_Estoque = Val(txtEm_Estoque.Text) + Val(txtEntradaProduto.Text)
                'acrescentando o valor em Qtd_Entrada
                intQtd_Entrada2 = Val(txtEntradaProduto.Text) + Val(intQtd_Entrada)
                'somando valor Entrada no campo valor total Entrada
                Dim douCustoTotalEntr As Double = txtCustoTotalEntr.Text
                param_VlrTotalEntr = (douCustoTotalEntr) + (douVlrTotalEntr)

                '---------------------------------------------------------------------------
                Comando.Parameters.Clear()
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", intEm_Estoque))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Qtd_Entrada", intQtd_Entrada2))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@vlr_totalEntrada", param_VlrTotalEntr))

                Comando.ExecuteNonQuery()


                Con.Close()

                MessageBox.Show("Produto Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgEntradProduto.Refresh()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            'Limpando campos txt
            txtEntradaProduto.Clear()
            txtEm_Estoque.Clear()
            txtCustoUnitario.Clear()
            txtCustoTotalEntr.Clear()

        End Try

        'aqui atualizo o registro apos entrada
        AtualizaRegistro2()

        'formatando novamente Grid
        FormatGridView()

        'verificando estoque baixo e colorindo
        ConferiEstMin2()

    End Sub


    Private Sub txtEntradaProduto_LostFocus(sender As Object, e As EventArgs) Handles txtEntradaProduto.LostFocus


    End Sub

    Private Sub txtCustoUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtCustoUnitario.TextChanged

    End Sub

    Private Sub txtCustoUnitario_LostFocus(sender As Object, e As EventArgs) Handles txtCustoUnitario.LostFocus

        Try
            Dim douCusTotal As Double

            douCusTotal = txtEntradaProduto.Text * txtCustoUnitario.Text

            txtCustoTotalEntr.Text = douCusTotal

        Catch ex As Exception
            Return

        End Try



    End Sub

    Private Sub txtCustoTotalEntr_TextChanged(sender As Object, e As EventArgs) Handles txtCustoTotalEntr.TextChanged

        Try
            txtCustoTotalEntr.Text = FormatCurrency(txtCustoTotalEntr.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

        Catch ex As Exception
            Return

        End Try


    End Sub

    Private Sub txtCustoUnitario_Leave(sender As Object, e As EventArgs) Handles txtCustoUnitario.Leave
        Try
            txtCustoUnitario.Text = FormatCurrency(txtCustoUnitario.Text, 2, TriState.True, TriState.True, TriState.True).Replace("R$", "R$").Trim

        Catch ex As Exception
            Return

        End Try
    End Sub

    Private Sub txtCustoTotalEntr_Leave(sender As Object, e As EventArgs) Handles txtCustoTotalEntr.Leave



    End Sub

    Private Sub txtCustoTotalEntr_GotFocus(sender As Object, e As EventArgs) Handles txtCustoTotalEntr.GotFocus


    End Sub

    Private Sub txtCustoTotalEntr_LostFocus(sender As Object, e As EventArgs) Handles txtCustoTotalEntr.LostFocus

    End Sub

    Private Sub txtCustoTotalEntr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustoTotalEntr.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then
            btnSalvarEntradaProd.PerformClick()

            'aqui tiro o som
            e.Handled = True

        End If
    End Sub
End Class