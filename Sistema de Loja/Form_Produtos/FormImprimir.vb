Public Class FormImprimir
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dispose()
        Timer1.Dispose()

        Close()

        FormTelaVenda.Show()

    End Sub

    Private Sub FormImprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class