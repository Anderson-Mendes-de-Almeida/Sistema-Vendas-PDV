Imports System.Data.OleDb


Public Class FormFuncionarios
    Dim intcodigo As String

    Private Sub Limpacampos()

        txtNomeFuncio.Text = Nothing
        txtrg.Text = Nothing
        txtEndereco.Text = Nothing
        txtBairro.Text = Nothing
        mktcep.Text = Nothing
        txtCidade.Text = Nothing
        cbUf.Text = Nothing
        mktTelefone.Text = Nothing
        mktCelular.Text = Nothing
        cbSexo.Text = Nothing
        dtpNascimento.Text = Nothing
        txtEmail.Text = Nothing
        dtpCadastro.Text = Nothing
        txtComentario.Text = Nothing

    End Sub
    Private Sub FormatGridViewCadFuncio()

        With dgFuncion

            '''''''escondendo colunas------
            .Columns(0).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False


            '''''''Regulando tamanho colunas-----
            .Columns(0).Width = 50  'codigo
            .Columns(3).Width = 100
            '.Columns(8).Width = 50

            '---------------------Editando Cabeçalho--------------------------
            '  .Columns(0).HeaderText = "Código "
            ' .Columns(1).HeaderText = "Codigo de Barras"
            .Columns(1).HeaderText = "Funcionário"
            .Columns(2).HeaderText = "Identidade"
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
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(4).DefaultCellStyle.Format = "c2"
            '.Columns(5).DefaultCellStyle.Format = "c2"
            '.Columns(7).DefaultCellStyle.Format = "c2"


            'dgvPedidos.Columns("valor_total").DefaultCellStyle.Format = "C2"

            'Colorin primeira linha DataGrid
            ' dgEntradProduto.Rows(0).DefaultCellStyle.BackColor = Color.Chocolate

        End With



    End Sub


    Private Sub CarregaFunciona()

        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select * FROM TBFuncionario"
            Dim comando As New OleDbCommand(Sql, Con)


            '-----------------------------------
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_Funcionario")


            dgFuncion.DataSource = dt

            'pegando codigo cliente para UPDATE
            If intcodigo = Me.dgFuncion.CurrentRow.Cells(0).Value.ToString() = Nothing Then

            End If

            ' If Me.lblProdutosVendidos.Text = Leitor("qtd_S").ToString = (Nothing) Then

            ds.Dispose()

            'FormatGridView()

            'cbPesquisaEntr.Focus()

            Con.Close()

        Catch ex As Exception
            MessageBox.Show("Não Existem Funcionários Cadastrados : ", " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally


        End Try

        FormatGridViewCadFuncio()


    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        txtNomeFuncio.Focus()

        Try

            If txtNomeFuncio.Text = "" Then
                MessageBox.Show("Digite o Nome do Funcionário!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1

            Con.Open()


            Dim Comando As New OleDbCommand
            Comando.CommandText = "INSERT INTO TBFuncionario (funcionario, rg, endereco, bairro, cep, cidade, uf, telefone, celular, sexo, nascimento, email, datacadastro, comentario)" & " 
                                   VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?,?,?)"

            Comando.Parameters.Clear()
            Comando.Parameters.Add("@funcionario", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtNomeFuncio.Text
            Comando.Parameters.Add("@rg", System.Data.OleDb.OleDbType.VarChar, 12).Value = txtrg.Text
            Comando.Parameters.Add("@endereco", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtEndereco.Text
            Comando.Parameters.Add("@bairro", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtBairro.Text
            Comando.Parameters.Add("@cep", System.Data.OleDb.OleDbType.VarChar, 13).Value = mktcep.Text
            Comando.Parameters.Add("@cidade", System.Data.OleDb.OleDbType.VarChar, 30).Value = txtCidade.Text
            Comando.Parameters.Add("@uf", System.Data.OleDb.OleDbType.VarChar, 2).Value = cbUf.Text
            Comando.Parameters.Add("@telefone", System.Data.OleDb.OleDbType.VarChar, 20).Value = mktTelefone.Text
            Comando.Parameters.Add("@celular", System.Data.OleDb.OleDbType.VarChar, 20).Value = mktCelular.Text
            Comando.Parameters.Add("@sexo", System.Data.OleDb.OleDbType.VarChar, 13).Value = cbSexo.Text
            Comando.Parameters.Add("@nascimento", System.Data.OleDb.OleDbType.Date, 13).Value = dtpNascimento.Text
            Comando.Parameters.Add("@email", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtEmail.Text
            Comando.Parameters.Add("@datacadastro", System.Data.OleDb.OleDbType.Date, 13).Value = dtpCadastro.Text
            Comando.Parameters.Add("@anotacao", System.Data.OleDb.OleDbType.VarChar, 1000).Value = txtComentario.Text


            Comando.CommandType = CommandType.Text


            Comando.Connection = Con

            Comando.ExecuteNonQuery()


            Con.Close()

            MessageBox.Show("Funcionário Cadastrado com Sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            'Me.Close()
        End Try

        'Aqui carregamos o GridView
        CarregaFunciona()

        'desabilitando btnCadastrar
        ToolStripStatusLabel2.Enabled = False

        Limpacampos()

    End Sub

    Private Sub FormFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaFunciona()

    End Sub

    Private Sub dgFuncion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFuncion.CellContentClick

    End Sub

    Private Sub dgFuncion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFuncion.CellClick

        ' dgClientes.CurrentRow.Cells(0).Value.ToString()
        txtNomeFuncio.Text = dgFuncion.CurrentRow.Cells(1).Value.ToString
        txtrg.Text = dgFuncion.CurrentRow.Cells(2).Value.ToString
        txtEndereco.Text = dgFuncion.CurrentRow.Cells(3).Value.ToString
        txtBairro.Text = dgFuncion.CurrentRow.Cells(4).Value.ToString
        mktcep.Text = dgFuncion.CurrentRow.Cells(5).Value.ToString
        txtCidade.Text = dgFuncion.CurrentRow.Cells(6).Value.ToString
        cbUf.Text = dgFuncion.CurrentRow.Cells(7).Value.ToString
        mktTelefone.Text = dgFuncion.CurrentRow.Cells(8).Value.ToString
        mktCelular.Text = dgFuncion.CurrentRow.Cells(9).Value.ToString
        cbSexo.Text = dgFuncion.CurrentRow.Cells(10).Value.ToString
        dtpNascimento.Text = dgFuncion.CurrentRow.Cells(11).Value.ToString
        txtEmail.Text = dgFuncion.CurrentRow.Cells(12).Value.ToString
        dtpCadastro.Text = dgFuncion.CurrentRow.Cells(13).Value.ToString
        txtComentario.Text = dgFuncion.CurrentRow.Cells(14).Value.ToString

        'desabilitando 
        ToolStripStatusLabel2.Enabled = False

        'abilitar botão Alterar
        ToolStripStatusLabel4.Enabled = True


    End Sub

    Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel4.Click
        Try


            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            intcodigo = dgFuncion.CurrentRow.Cells(0).Value.ToString

            Dim sql As String = "UPDATE TBFuncionario SET funcionario=?, rg=?, endereco=?, bairro=?, cep=?, cidade=?,
                                uf=?, telefone=?, celular=?, sexo=?, nascimento=?, email=?, datacadastro=?, comentario=? WHERE codigo=" & intcodigo
            Dim Comando As New OleDbCommand(sql, Con)

            '--------------------somando valor do grid---------------------------------

            'acrecentando entrada em Em_Estque
            'intEm_Estoque = Val(txtEm_Estoque.Text) + Val(txtEntradaProduto.Text)
            ''acrescentando o valor em Qtd_Entrada
            'intQtd_Entrada2 = Val(txtEntradaProduto.Text) + Val(intQtd_Entrada)

            '---------------------------------------------------------------------------
            Comando.Parameters.Clear()
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cliente", txtNomeFuncio.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@rg", txtrg.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@endereco", txtEndereco.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@bairro", txtBairro.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cep", mktcep.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cidade", txtCidade.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@uf", cbUf.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@telefone", mktTelefone.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@celular", mktCelular.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@sexo", cbSexo.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@nascimento", dtpNascimento.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@ email", txtEmail.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@datacadastro", dtpCadastro.Text))
            Comando.Parameters.Add(New OleDb.OleDbParameter("@comentario", txtComentario.Text))



            Comando.ExecuteNonQuery()


            Con.Close()

            MessageBox.Show("Cadastro Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dgFuncion.Refresh()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        CarregaFunciona()


    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Close()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Limpacampos()

        txtNomeFuncio.Focus()

        'abilitando ToolStripStatusLabel2
        ToolStripStatusLabel2.Enabled = True

        'desabilinta botão Alterar
        ToolStripStatusLabel4.Enabled = False

    End Sub
End Class