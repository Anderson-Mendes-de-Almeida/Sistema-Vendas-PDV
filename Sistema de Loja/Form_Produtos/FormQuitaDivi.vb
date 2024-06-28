
Imports System.Data.OleDb

Public Class FormQuitaDivi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim StrPago As String = "Pago"


        'CodVendDg = dgVendasRealiz.CurrentRow.Cells(0).Value
        'StrformaPag = dgVendasRealiz.CurrentRow.Cells(2).Value.ToString

        Try


            If StrformaPag = "Fiado" Then

                Dim Con1 As New OleDbConnection
                Con1.ConnectionString = My.Settings.CN1
                Con1.Open()

                Dim sql10 As String = "UPDATE TBVendaProduto SET formaPag=? WHERE codigoVenda=" & CodVendDg

                Dim Comando30 As New OleDbCommand(sql10, Con1)

                Comando30.Parameters.Clear()
                Comando30.Parameters.Add(New OleDb.OleDbParameter("@formaPag", StrPago))

                Comando30.ExecuteNonQuery()

                Con1.Close()
                Con1.Dispose()

                '    dgVendasRealiz.Refresh()

                ' MsgBox("Dívida quitada!", "Formulário para quitar Dívidas!", vbOKOnly)
                MsgBox("Dívida quitada!", MsgBoxStyle.Information, "SkyNetSystem do Brasil!")

                Me.Close()

                FormVendasRealisadas.Close()
                FormVendasRealisadas.Show()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub
End Class