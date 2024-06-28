Imports System.Data.OleDb

Public Class FormVendasAgrupadas
    Private Sub FormVendasAgrupadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim ContGrid As Integer

            Dim Con As New OleDbConnection
            Con.ConnectionString = My.Settings.CN1
            Con.Open()

            Dim Sql As String = " SELECT count(*) as c FROM TBProduVenda "
            Dim comando As New OleDbCommand(Sql, Con)

            Dim Leitor As OleDbDataReader

            Leitor = comando.ExecuteReader
            Leitor.Read()


            ContGrid = Leitor("c").ToString

            txtValorTotal.Text = ContGrid

            Leitor.Close()
            '====================================X=======================================


            For index = 0 To ContGrid - 1

            Next


            'Dim comando As New OleDbCommand
            Dim Sql2 As String = " Select * FROM TBProduVenda"
            Dim comando2 As New OleDbCommand(Sql2, Con)

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(comando2)
            Dim dt As New DataTable
            Dim ds As New DataSet

            da.Fill(dt)
            da.Fill(ds, "TBProdutosvendas")


            dgVendasAgrupadas.DataSource = dt

            dgVendasAgrupadas.DataSource = ds.Tables("TBProdutosvendas")

            Con.Close()
            Con.Dispose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        '---------------Mudando a cor de Cabeçalho DatagridView------------------
        dgVendasAgrupadas.EnableHeadersVisualStyles = False
        'muda cor Headers
        dgVendasAgrupadas.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver
        'mudar co lateral esquerda
        'dgSaidaProduto.RowHeadersDefaultCellStyle.BackColor = Color.Black

        'Procedure calcula vendas
        '   VendasRealizadas()

        'FormatGridView()

    End Sub

    Private Sub btConsulta_Click(sender As Object, e As EventArgs) Handles btConsulta.Click

    End Sub
End Class