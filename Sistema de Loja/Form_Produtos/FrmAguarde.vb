Public Class FrmAguarde
    Private Sub FrmAguarde_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True

    End Sub

    Private Sub FrmAguarde_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tmTimer.Start()
    End Sub

    Private Sub tmTimer_Tick(sender As Object, e As EventArgs) Handles tmTimer.Tick
        picProcesso.Width = picProcesso.Width + 5
        If picProcesso.Width = 475 Then
            picProcesso.Visible = False
            picProcesso.Width = 15
            tmTimer.Stop()
            Dispose()
            Close()

        End If


    End Sub


End Class