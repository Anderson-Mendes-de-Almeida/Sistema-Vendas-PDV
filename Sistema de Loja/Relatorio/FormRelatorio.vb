Imports System.Data.OleDb

Public Class FormRelatorio
    Private Sub FormRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim Con As New OleDbConnection

            Con.ConnectionString = My.Settings.CN1
            Con.Open()


            Dim SQL As String = " SELECT * FROM  TBVendas "

            Dim da As New OleDbDataAdapter(SQL, Con)

            Dim ds As New dsRelatorio

            da.Fill(ds.Tables("DataTable2"))

            Dim cry As New CrystalReport1


            cry.SetDataSource(ds.Tables("DataTable2"))
            CrystalReportViewer1.ReportSource = cry
            CrystalReportViewer1.Refresh()





        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class