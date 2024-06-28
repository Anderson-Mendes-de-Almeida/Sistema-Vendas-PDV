Imports System.Data.OleDb

Public Class FormLogin

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Veja http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Dim IntSenha As Integer

        Try
            Dim con As New OleDbConnection
            con.ConnectionString = My.Settings.CN1
            con.Open()

            Dim sql As String = "SELECT * FROM TBLogin WHERE senha=" & txtsenha.Text
            Dim da As New OleDbDataAdapter
            Dim Leitor As OleDbDataReader
            Dim comando As New OleDbCommand(sql, con)

            da.SelectCommand = comando
            Leitor = comando.ExecuteReader


            If Leitor.HasRows = 0 Then
                MessageBox.Show("Senha Inválida!" & vbCrLf & "Tente Novamente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtsenha.Clear()
                txtsenha.Focus()

            Else
                Form1.Show()
                Visible = False

            End If

            comando.Dispose()
            da.Dispose()
            Leitor.Close()
            con.Dispose()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Por Favor! Digite senha de Segurança!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        txtsenha.Clear()




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        If txtsenha.Text = "" Then
            MessageBox.Show("Finalizando Sistema!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()


        End If

    End Sub

    Private Sub txtsenha_TextChanged(sender As Object, e As EventArgs) Handles txtsenha.TextChanged

    End Sub

    Private Sub txtsenha_GotFocus(sender As Object, e As EventArgs) Handles txtsenha.GotFocus


    End Sub

    Private Sub txtsenha_Click(sender As Object, e As EventArgs) Handles txtsenha.Click


    End Sub

    Private Sub txtsenha_LostFocus(sender As Object, e As EventArgs) Handles txtsenha.LostFocus
        OK.Enabled = True
    End Sub

    Private Sub TimerHoras_Tick(sender As Object, e As EventArgs) Handles TimerHoras.Tick
        Dim horas As DateTime = DateTime.Now
        lblHoras.Text = Now.ToString("HH:mm")
        lblData.Text = horas.ToLongDateString

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        LogoPictureBox.Location = New Point(228, 120)



    End Sub
End Class
