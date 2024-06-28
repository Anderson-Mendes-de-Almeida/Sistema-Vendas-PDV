Imports System.Data.OleDb

Public Class FormCadasFornece


    Private Sub Limpacampos()

        txtNomeForne.Text = Nothing
        mktCnpj.Text = Nothing
        txtEndereco.Text = Nothing
        txtBairro.Text = Nothing
        mktcep.Text = Nothing
        txtCidade.Text = Nothing
        cbUf.Text = Nothing
        mktTelefone.Text = Nothing
        mktCelular.Text = Nothing
        txtEmail.Text = Nothing
        dtpCadastro.Text = Nothing
        txtComentario.Text = Nothing

    End Sub
    Private Sub FormatGridViewForn()

        With dglistProd

            '''''''escondendo colunas------
            .Columns(0).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            '   .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False


            '''''''Regulando tamanho colunas-----
            .Columns(1).Width = 150 'codigo
            .Columns(3).Width = 100
            '.Columns(8).Width = 50

            '---------------------Editando Cabeçalho--------------------------
            '  .Columns(0).HeaderText = "Código "
            ' .Columns(1).HeaderText = "Codigo de Barras"
            .Columns(1).HeaderText = "Fonecedor"
            .Columns(8).HeaderText = "Telefone"
            '.Columns(4).HeaderText = "Valor Venda"
            '.Columns(5).HeaderText = "Em Estoque"
            '.Columns(6).HeaderText = "Qtd_Entrada"
            '.Columns(7).HeaderText = "Qtd Minima Estoque"
            '.Columns(8).HeaderText = "Situação"
            '.Columns(8).HeaderText = "Qtd Saida"
            '.Columns(9).HeaderText = "Produtos em Estoque"
            '.Columns(10).HeaderText = "Saldo Total Estoque"
            '.Columns(11).HeaderText = "Produtos Vendidos"
            '.Columns(12).HeaderText = "Qtd Minima Estoque"
            '.Columns(13).HeaderText = "Data da Compra"
            '.Columns(14).HeaderText = "Situação"




            ''''''''''Aqui formato as colunas para moeda "Reais"
            '.Columns(3).DefaultCellStyle.Format = "c2"
            '.Columns(4).DefaultCellStyle.Format = "c2"
            '.Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"


            'dgvPedidos.Columns("valor_total").DefaultCellStyle.Format = "C2"

            'Colorin primeira linha DataGrid
            ' dgEntradProduto.Rows(0).DefaultCellStyle.BackColor = Color.Chocolate

        End With


    End Sub
    Private Sub carregaGridForne()

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select * FROM TBFornecedores"
            Dim comando As New OleDbCommand(Sql, Con)


            '-----------------------------------
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_Cliente")


            dglistProd.DataSource = dt

            'pegando codigo cliente para UPDATE
            'intcodigo = dglistProd.CurrentRow.Cells(0).Value.ToString()



            ds.Dispose()

            'FormatGridView()

            'cbPesquisaEntr.Focus()

            Con.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar com Base de Dados : " & ex.Message)

        Finally


        End Try

        FormatGridViewForn()


    End Sub
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Form1.Close()

        Try

            If txtNomeForne.Text = "" Then
                MessageBox.Show("Digite o Nome do Fornecedor!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1

            Con.Open()


            Dim Comando As New OleDbCommand
            Comando.CommandText = "INSERT INTO TBFornecedores (nomeempre, cnpj, endereco, bairro, cidade, uf, cep, telefone, celular, email, datacadastro, comentario)" & " 
                                   VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?)"

            Comando.Parameters.Clear()
            Comando.Parameters.Add("@nomeempre", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtNomeForne.Text
            Comando.Parameters.Add("@cnpj", System.Data.OleDb.OleDbType.VarChar, 18).Value = mktCnpj.Text
            Comando.Parameters.Add("@endereco", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtEndereco.Text
            Comando.Parameters.Add("@bairro", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtBairro.Text
            Comando.Parameters.Add("@cidade", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtCidade.Text
            Comando.Parameters.Add("@uf", System.Data.OleDb.OleDbType.VarChar, 2).Value = cbUf.Text
            Comando.Parameters.Add("@cep", System.Data.OleDb.OleDbType.VarChar, 13).Value = mktcep.Text
            Comando.Parameters.Add("@telefone", System.Data.OleDb.OleDbType.VarChar, 20).Value = mktTelefone.Text
            Comando.Parameters.Add("@celular", System.Data.OleDb.OleDbType.VarChar, 20).Value = mktCelular.Text
            '  Comando.Parameters.Add("@nascimento", System.Data.OleDb.OleDbType.Date, 13).Value = dtpNascimento.Text
            Comando.Parameters.Add("@email", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtEmail.Text
            Comando.Parameters.Add("@datacadastro", System.Data.OleDb.OleDbType.Date, 13).Value = dtpCadastro.Text
            Comando.Parameters.Add("@anotacao", System.Data.OleDb.OleDbType.VarChar, 32767).Value = txtComentario.Text
            ''=====problema no tamanho dos campos

            Comando.CommandType = CommandType.Text


            Comando.Connection = Con

            Comando.ExecuteNonQuery()


            Con.Close()

            MessageBox.Show("Fornecedor Cadastrado com Sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally


        End Try


        'desabilitando btnCadastrar
        ToolStripStatusLabel1.Enabled = False

        carregaGridForne()

        Limpacampos()

        Form1.Show()

    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        Me.Close()

    End Sub

    Private Sub FormCadasFornece_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregaGridForne()

    End Sub

    Private Sub txtcnpj_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dglistProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dglistProd.CellContentClick

    End Sub

    Private Sub dglistProd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dglistProd.CellClick
        ' dglistProd.CurrentRow.Cells(0).Value.ToString()
        txtNomeForne.Text = dglistProd.CurrentRow.Cells(1).Value.ToString
        mktCnpj.Text = dglistProd.CurrentRow.Cells(2).Value.ToString
        txtEndereco.Text = dglistProd.CurrentRow.Cells(3).Value.ToString
        txtBairro.Text = dglistProd.CurrentRow.Cells(4).Value.ToString
        txtCidade.Text = dglistProd.CurrentRow.Cells(5).Value.ToString
        cbUf.Text = dglistProd.CurrentRow.Cells(6).Value.ToString
        mktcep.Text = dglistProd.CurrentRow.Cells(7).Value.ToString
        mktTelefone.Text = dglistProd.CurrentRow.Cells(8).Value.ToString
        mktCelular.Text = dglistProd.CurrentRow.Cells(9).Value.ToString
        txtEmail.Text = dglistProd.CurrentRow.Cells(10).Value.ToString
        dtpCadastro.Text = dglistProd.CurrentRow.Cells(11).Value.ToString
        txtComentario.Text = dglistProd.CurrentRow.Cells(12).Value.ToString


        'desabilitando btnCadastrar
        ToolStripStatusLabel1.Enabled = False

        'abilitando botão Alterar
        ToolStripStatusLabel2.Enabled = True



    End Sub

    Private Sub tsslNovo_Click(sender As Object, e As EventArgs) Handles tsslNovo.Click
        Limpacampos()

        txtNomeForne.Focus()

        'abilitando ToolStripStatusLabel1
        ToolStripStatusLabel1.Enabled = True

        carregaGridForne()

        'desabilitando botão Alterar
        ToolStripStatusLabel2.Enabled = False


    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Try


            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim intcodigo As Integer = dglistProd.CurrentRow.Cells(0).Value.ToString

            Dim sql As String = "UPDATE TBFornecedores SET nomeEmpre=?, cnpj=?, endereco=?, bairro=?, cidade=?,
                                uf=?, cep=?, telefone=?, celular=?, email=?, datacadastro=?, comentario=? WHERE codForne=" & intcodigo
            Dim Comando As New OleDbCommand(sql, Con)

            '--------------------somando valor do grid---------------------------------

            'acrecentando entrada em Em_Estque
            'intEm_Estoque = Val(txtEm_Estoque.Text) + Val(txtEntradaProduto.Text)
            ''acrescentando o valor em Qtd_Entrada
            'intQtd_Entrada2 = Val(txtEntradaProduto.Text) + Val(intQtd_Entrada)

            '---------------------------------------------------------------------------
            Comando.Parameters.Clear()
            Comando.Parameters.Add(New OleDb.OleDbParameter("@nomeEmpre", txtNomeForne.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cnpj", mktCnpj.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@endereco", txtEndereco.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@bairro", txtBairro.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cidade", txtCidade.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@uf", cbUf.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cep", mktcep.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@telefone", mktTelefone.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@celular", mktCelular.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@email", txtEmail.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@datacadastro", dtpCadastro.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@comentario", txtComentario.Text))



            Comando.ExecuteNonQuery()


            Con.Close()

            MessageBox.Show("Cadastro Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dglistProd.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        carregaGridForne()

    End Sub
End Class