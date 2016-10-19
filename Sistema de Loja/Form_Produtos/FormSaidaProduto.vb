Imports System.Data.OleDb

Public Class FormSaidaProduto
    Dim intQtd_Saida As Integer

    Private Sub ConferiEstMin3()

        Dim intEstqMin As Integer
        Dim intEm_Estq As Integer

        For i As Integer = 0 To dgSaidaProduto.Rows.Count() - 1

            'pegando o valor Em_estoque/varendo as linha de cima para baixo
            intEm_Estq = dgSaidaProduto.Rows(i).Cells(3).Value.ToString

            'pegando valor EstqMinimo/varendo as linha de cima para baixo
            intEstqMin = dgSaidaProduto.Rows(i).Cells(5).Value

            If intEm_Estq < intEstqMin Then
                dgSaidaProduto.Rows(i).DefaultCellStyle.ForeColor = Color.Red


            End If

        Next


    End Sub
    Private Sub AtualizaRegistros()
        Try
            Dim Con As New OleDbConnection             ' Dim SQL As String = " SELECT * FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codbarras, descproduto, vlr_venda, Em_Estoque,  Qtd_Saida,
                                  estoque_minimo  FROM TBProduto"
            Dim comando As New OleDbCommand(SQL, Con)

            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable

            'atualizamos a datatable com as tabelas
            da.Fill(dt)

            dgSaidaProduto.DataSource = Nothing
            dgSaidaProduto.DataSource = dt


            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub PesquisaProduto3()
        Try
            ' If cbPesquisa.SelectedIndex = 0 Then

            Dim Con As New OleDbConnection             ' Dim SQL As String = " SELECT * FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdEntr.Text & "%' "

            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codbarras, descproduto, vlr_venda, Em_Estoque,  Qtd_Saida,
                                  estoque_minimo  FROM TBProduto Where DescProduto LIKE '%" & txtPesquisaProdSai.Text & "%' "
            Dim comando As New OleDbCommand(SQL, Con)

            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable

            'atualizamos a datatable com as tabelas
            da.Fill(dt)

            dgSaidaProduto.DataSource = Nothing
            dgSaidaProduto.DataSource = dt


            Con.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

        End Try
    End Sub
    Private Sub PesquisacodBarras3()
        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim SQL As String = " SELECT codbarras, descproduto, vlr_venda, Em_Estoque, Qtd_Saida,
                                  estoque_minimo FROM TBProduto Where codBarras LIKE '%" & Convert.ToInt32(txtPesquisaProdSai.Text) & "%' "

            Dim comando As New OleDbCommand(SQL, Con)

            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable

            'atualizamos a datatable com as tabelas
            da.Fill(dt)

            dgSaidaProduto.DataSource = Nothing
            dgSaidaProduto.DataSource = dt

            Con.Close()




        Catch ex As Exception
            'Ao ser apagado o codigo de barras em cbPesquisaEntrProduto o sistema
            'cai aqui e faz o carregamento do GridView

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select codbarras, descproduto, vlr_venda, Em_Estoque, Qtd_Saida,
                                  estoque_minimo FROM TBProduto"
            Dim comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_produto")


            dgSaidaProduto.DataSource = dt

            dgSaidaProduto.DataSource = ds.Tables("tab_Produto")

        Finally

        End Try

    End Sub

    Private Sub formatgridview2()
        With dgSaidaProduto

            '''''''escondendo colunas------
            '.Columns(7).Visible = False
            '.Columns(8).Visible = False
            '.Columns(9).Visible = False
            '.Columns(10).Visible = False
            '.Columns(11).Visible = False
            '.Columns(12).Visible = False
            '.Columns(13).Visible = False
            '.Columns(14).Visible = False


            '''''''Regulando tamanho colunas-----
            .Columns(2).Width = 150
            .Columns(3).Width = 100
            ' .Columns(6).Width = 50

            'Editando Cabeçalho
            '  .Columns(0).HeaderText = "Código "
            .Columns(0).HeaderText = "Codigo de Barras"
            .Columns(1).HeaderText = "Produto"
            .Columns(2).HeaderText = "Valor Venda"
            .Columns(3).HeaderText = "Em Estoque"
            .Columns(4).HeaderText = "Qtd_Saida"
            .Columns(5).HeaderText = "Qtd Minima Estoque"
            '.Columns(6).HeaderText = "Situação"
            '.Columns(8).HeaderText = "Qtd Saida"


            ''''''''''Aqui formato as colunas para moeda "Reais"
            .Columns(2).DefaultCellStyle.Format = "c2"
            '.Columns(3).DefaultCellStyle.Format = "c2"
            '.Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"


            'dgvPedidos.Columns("valor_total").DefaultCellStyle.Format = "C2"


        End With

    End Sub
    Private Sub FormSaidaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'limpando textbox
        txtSaidaProduto.Clear()

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select codBarras, descproduto,vlr_venda, Em_Estoque, 
                                  Qtd_saida, estoque_minimo FROM TBProduto"
            Dim comando As New OleDbCommand(Sql, Con)


            '-----------------------------------
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_produto")


            dgSaidaProduto.DataSource = dt

            ds.Dispose()

            'Aqui formatamos o DataGridView
            formatgridview2()

            cbPesquisaEntr.Focus()

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar com Base de Dados : " & ex.Message)

        End Try

        '---------------Mudando a cor de Cabeçalho DatagridView------------------
        dgSaidaProduto.EnableHeadersVisualStyles = False
        'muda cor Headers
        dgSaidaProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver
        'mudar co lateral esquerda
        'dgSaidaProduto.RowHeadersDefaultCellStyle.BackColor = Color.Black

        '------------------------------------------------------------------


        'conferir quantidade estoque e colorir linha
        ConferiEstMin3()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub cbPesquisaEntr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisaEntr.SelectedIndexChanged
        Try
            txtPesquisaProdSai.Enabled = True

        Catch ex As Exception



            Return


        End Try

        txtPesquisaProdSai.Focus()
    End Sub

    Private Sub txtPesquisaProdSai_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdSai.TextChanged
        If cbPesquisaEntr.SelectedIndex = 0 Then
            ' dgEntradProduto.ClearSelection()
            '  Me.dgEntradProduto.Columns.Clear()

            Me.dgSaidaProduto.Columns.Clear()
            PesquisaProduto3()

        Else

            Me.dgSaidaProduto.Columns.Clear()
            PesquisacodBarras3()

        End If

        formatgridview2()

        'conferir estoque minimo
        ConferiEstMin3()

    End Sub

    Private Sub btnSalvarEntradaProd_Click(sender As Object, e As EventArgs) Handles btnSalvarEntradaProd.Click
        'Pegando Código barras DataGridView
        Dim intcodBarras As Double

        'variavel quantidade em Estoque
        Dim intEm_Estoque As Integer


        Try
            If txtSaidaProduto.Text = Nothing Then
                MessageBox.Show("Digite a Quantidade de Produtos para Atualizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            Else

                Dim Con As New OleDbConnection
                Con.ConnectionString = My.Settings.CN1
                Con.Open()

                intcodBarras = dgSaidaProduto.CurrentRow.Cells(0).Value.ToString

                ' qtd_saida=?
                Dim sql As String = "UPDATE TBProduto SET Em_Estoque=?, Qtd_saida=? WHERE codBarras=" & intcodBarras
                Dim Comando As New OleDbCommand(sql, Con)

                '-----------------------------tirando produtos de Em_Estque e Qtd_saida-----

                intEm_Estoque = Val(txtEm_Estoque.Text) - Val(txtSaidaProduto.Text)
                '----------------------------acrescentando o valor em Qtd_Entrada
                Dim intQtd_SaidaParam As Integer = Val(txtSaidaProduto.Text) + Val(intQtd_Saida)

                ''---------------------------------------------------------------------------
                Comando.Parameters.Clear()
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Em_Estoque", intEm_Estoque))
                Comando.Parameters.Add(New OleDb.OleDbParameter("@Qtd_Entrada", intQtd_SaidaParam))

                Comando.ExecuteNonQuery()


                Con.Close()

                MessageBox.Show("Produto Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgSaidaProduto.Refresh()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            'Limpando campos txt
            txtSaidaProduto.Clear()
            txtEm_Estoque.Clear()

        End Try

        'Essa procedure serve para atualizar os registros apos exclusão, inclusão
        AtualizaRegistros()

        'novamente tenho que formatar o grid
        formatgridview2()

        'conferindo estoque minimo e colorindo
        ConferiEstMin3()
    End Sub

    Private Sub dgSaidaProduto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSaidaProduto.CellContentClick

    End Sub

    Private Sub dgSaidaProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSaidaProduto.CellClick
        txtSaidaProduto.Focus()



        'If ((Me.dgSaidaProduto.CurrentRow.Cells(4).Value.ToString) = (Nothing)) Then 'caso seja Nothing dara a mensagem / se nao for botado o Add("") darra erro
        '    MessageBox.Show("não a valores em estoque!")
        '    Return
        'Else
        ' ------------------------------------------------------------

        '  ''''''Pegando a quantidade em estoque
        Dim IntEmEstoq As String = dgSaidaProduto.CurrentRow.Cells(3).Value.ToString

        '''''''pegando o valor qta_saida do grid
        If ((Me.dgSaidaProduto.CurrentRow.Cells(4).Value.ToString) = (Nothing)) Then

        Else
            intQtd_Saida = dgSaidaProduto.CurrentRow.Cells(4).Value.ToString


        End If

        txtEm_Estoque.Text = IntEmEstoq





    End Sub

    Private Sub txtSaidaProduto_TextChanged(sender As Object, e As EventArgs) Handles txtSaidaProduto.TextChanged

    End Sub

    Private Sub txtSaidaProduto_Click(sender As Object, e As EventArgs) Handles txtSaidaProduto.Click


    End Sub

    Private Sub txtSaidaProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaidaProduto.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then
            btnSalvarEntradaProd.PerformClick()

            'aqui tiro o som
            e.Handled = True

        End If
    End Sub

    Private Sub txtSaidaProduto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSaidaProduto.KeyUp

    End Sub
End Class