Imports System.Data.OleDb

Public Class FormCadasClinte
    Dim intcodigo As String


    Private Sub FormatGridViewCadCli()
        With dgClientes

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
            .Columns(1).HeaderText = "Cliente"
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
    Private Sub Limpacampos()

        txtNomeCli.Text = Nothing
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
    Private Sub Carregaliente()
        Try

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select * FROM TBCliente"
            Dim comando As New OleDbCommand(Sql, Con)


            '-----------------------------------
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "tab_Cliente")


            dgClientes.DataSource = dt

            'pegando codigo cliente para UPDATE
            If intcodigo = Me.dgClientes.CurrentRow.Cells(0).Value.ToString() = Nothing Then

            End If

            ' If Me.lblProdutosVendidos.Text = Leitor("qtd_S").ToString = (Nothing) Then

            ds.Dispose()

            'FormatGridView()

            'cbPesquisaEntr.Focus()

            Con.Close()

        Catch ex As Exception
            MessageBox.Show("Não Existem Cliente Cadastrados : ", " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally


        End Try

        FormatGridViewCadCli()

    End Sub
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Limpacampos()

        txtNomeCli.Focus()

        'abilitando ToolStripStatusLabel2
        ToolStripStatusLabel2.Enabled = True

        'desabilinta botão Alterar
        ToolStripStatusLabel4.Enabled = False

    End Sub

    Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel3.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSexo.SelectedIndexChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtCidade.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUf.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txtComentario.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtBairro.TextChanged

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Form1.Close()


        txtNomeCli.Focus()

        Try

            If txtNomeCli.Text = "" Then
                MessageBox.Show("Digite o nome do Cliente!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1

            Con.Open()


            Dim Comando As New OleDbCommand
            Comando.CommandText = "INSERT INTO TBCliente (cliente, rg, endereco, bairro, cep, cidade, uf, telefone, celular, sexo, nascimento, email, datacadastro, comentario)" & " 
                                   VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?,?,?)"

            Comando.Parameters.Clear()
            Comando.Parameters.Add("@cliente", System.Data.OleDb.OleDbType.VarChar, 50).Value = txtNomeCli.Text
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

            MessageBox.Show("Cliente Cadastrado com Sucesso!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            'Me.Close()
        End Try

        'Aqui carregamos o GridView
        Carregaliente()

        'desabilitando btnCadastrar
        ToolStripStatusLabel2.Enabled = False

        Limpacampos()

        Form1.Show()

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles dtpCadastro.ValueChanged

    End Sub

    Private Sub FormCadasClinte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregaliente()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub rtbRg_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellContentClick





    End Sub

    Private Sub dgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellClick

        ' dgClientes.CurrentRow.Cells(0).Value.ToString()
        txtNomeCli.Text = dgClientes.CurrentRow.Cells(1).Value.ToString
        txtrg.Text = dgClientes.CurrentRow.Cells(2).Value.ToString
        txtEndereco.Text = dgClientes.CurrentRow.Cells(3).Value.ToString
        txtBairro.Text = dgClientes.CurrentRow.Cells(4).Value.ToString
        mktcep.Text = dgClientes.CurrentRow.Cells(5).Value.ToString
        txtCidade.Text = dgClientes.CurrentRow.Cells(6).Value.ToString
        cbUf.Text = dgClientes.CurrentRow.Cells(7).Value.ToString
        mktTelefone.Text = dgClientes.CurrentRow.Cells(8).Value.ToString
        mktCelular.Text = dgClientes.CurrentRow.Cells(9).Value.ToString
        cbSexo.Text = dgClientes.CurrentRow.Cells(10).Value.ToString
        dtpNascimento.Text = dgClientes.CurrentRow.Cells(11).Value.ToString
        txtEmail.Text = dgClientes.CurrentRow.Cells(12).Value.ToString
        dtpCadastro.Text = dgClientes.CurrentRow.Cells(13).Value.ToString
        txtComentario.Text = dgClientes.CurrentRow.Cells(14).Value.ToString

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

            intcodigo = dgClientes.CurrentRow.Cells(0).Value.ToString

            Dim sql As String = "UPDATE TBCliente SET cliente=?, rg=?, endereco=?, bairro=?, cep=?, cidade=?,
                                uf=?, telefone=?, celular=?, sexo=?, nascimento=?, email=?, datacadastro=?, comentario=? WHERE codigo=" & intcodigo
            Dim Comando As New OleDbCommand(sql, Con)

            '--------------------somando valor do grid---------------------------------

            'acrecentando entrada em Em_Estque
            'intEm_Estoque = Val(txtEm_Estoque.Text) + Val(txtEntradaProduto.Text)
            ''acrescentando o valor em Qtd_Entrada
            'intQtd_Entrada2 = Val(txtEntradaProduto.Text) + Val(intQtd_Entrada)

            '---------------------------------------------------------------------------
            Comando.Parameters.Clear()
            Comando.Parameters.Add(New OleDb.OleDbParameter("@cliente", txtNomeCli.Text))
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

            MessageBox.Show("Produto Atualizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dgClientes.Refresh()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Carregaliente()


    End Sub
End Class