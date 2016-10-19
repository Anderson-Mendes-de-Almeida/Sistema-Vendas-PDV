Imports System.Data.OleDb

Public Class FormVendasRealisadas

    Private Sub FormatGridView()

        With dgVendasRealiz

            'escondendo colunas------
            .Columns(0).Visible = False
            '.Columns(4).Visible = False


            'Regulando tamanho colunas-----
            .Columns(1).Width = 150
            .Columns(2).Width = 150

            'Editando Cabeçalho
            '.Columns(0).HeaderText = "Tesntando"
            .Columns(1).HeaderText = "Codigo de Barras"
            .Columns(2).HeaderText = "Produto"
            .Columns(3).HeaderText = "Data Compra"
            .Columns(4).HeaderText = "Total Pagar"
            .Columns(5).HeaderText = "Dinheiro"
            .Columns(6).HeaderText = "Troco"
            .Columns(7).HeaderText = "Tipo Pagamento"

            'Aqui formato as colunas para moeda "Reais"
            .Columns(4).DefaultCellStyle.Format = "c2"
            .Columns(5).DefaultCellStyle.Format = "c2"
            .Columns(6).DefaultCellStyle.Format = "c2"
            '.Columns(9).DefaultCellStyle.Format = "c2"


        End With


    End Sub
    Private Sub FormVendasRealisadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()
            'Dim comando As New OleDbCommand
            Dim Sql As String = " Select * FROM TBvendas"
            Dim comando As New OleDbCommand(Sql, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBvendas")


            dgVendasRealiz.DataSource = dt

            dgVendasRealiz.DataSource = ds.Tables("TBvendas")

            Con.Close()
            Con.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        FormatGridView()

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub txtPesquisaProdu_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisaProdu.TextChanged

    End Sub

    Private Sub TsslFechar_Click(sender As Object, e As EventArgs) Handles TsslFechar.Click
        Me.Dispose()

    End Sub

    Private Sub cbPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPesquisa.SelectedIndexChanged

        'Dim dtInicial As String = Format(dtpDataInicial.Value, "dd/MM/yyyy").ToString
        'Dim dtFinal As String = Format(dtpDataFinal.Value, "dd/MM/yyyy").ToString

        Dim dtInicial As String = dtpDataInicial.Value.ToString
        Dim dtFinal As String = dtpDataFinal.Value.ToString

        If cbPesquisa.SelectedIndex = 0 Then

            Try
                Dim dt As New DataTable
                Dim ds As New DataSet
                Dim Con As New OleDbConnection
                Dim comando As New OleDbCommand

                Con.ConnectionString = My.Settings.CN1
                Con.Open()


                Dim sql As String = " Select * FROM TBvendas WHERE datacompra BETWEEN @dtInicio AND @dtFim "

                comando.Parameters.Clear()
                comando.Parameters.AddWithValue("@dtInicio", dtInicial)
                comando.Parameters.AddWithValue("@dtFim", dtFinal)


                comando.CommandType = CommandType.Text
                comando.CommandText = sql

                Dim da As New OleDbDataAdapter(comando)
                da.SelectCommand.Connection = Con

                da.Fill(dt)
                da.Fill(ds, "TBvendas")

                dgVendasRealiz.DataSource = dt

                'Distruindo todos objetos
                da.Dispose()
                comando.Dispose()
                Con.Close()
                Con.Dispose()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally

            End Try


        ElseIf cbPesquisa.SelectedIndex = 1 Then
            MessageBox.Show("1")
        ElseIf cbPesquisa.SelectedIndex = 2 Then

            Return
            'MessageBox.Show("")
        ElseIf cbPesquisa.SelectedIndex = 3 Then
            MessageBox.Show("2")

        End If
    End Sub
End Class