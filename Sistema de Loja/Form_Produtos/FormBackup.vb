Imports System.IO
Imports System.Windows.Forms

Public Class FormBackup
    Inherits System.Windows.Forms.Form


    Dim strCaminhoBancoDeDados As String
    Dim PastaBackup As String
    Private Sub PCriarPastaParaBackupBancoDedados()
        Dim DataHoje As String = DateTime.Now
        DataHoje = Replace(DataHoje, "/", "-")
        DataHoje = Replace(DataHoje, ":", "-")
        DataHoje = Replace(DataHoje, " ", "-")

        'PastaBackup = Application.StartupPath & "\Backups\" & DataHoje & "\"
        PastaBackup = My.Settings.strLocalBackupBancoDeDados & "Backups\" & DataHoje & "\"

        If Not Directory.Exists(PastaBackup) Then
            Directory.CreateDirectory(PastaBackup)
        End If
    End Sub
    Private Sub PCarregaDados()
        txtLocalFisicoBancoDeDados.Text = My.Settings.strCaminhoBancoDeDados
        txtDestinoBancoDeDados.Text = My.Settings.strLocalBackupBancoDeDados
    End Sub
    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
        PCarregaDados()
    End Sub
    Public Sub PRealizarBackupBancoDeDadosInicial()
        Try
            Me.Cursor = Cursors.WaitCursor
            PCriarPastaParaBackupBancoDedados()
            Dim strCaminho As String = PastaBackup & "BDSistemaLoja.accdb"
            System.IO.File.Copy(My.Settings.strCaminhoBancoDeDados, strCaminho)
            FrmAguarde.ShowDialog()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Ocorreu um erro na tentativa de realizar o backup do Banco de Dados. " & ex.Message, MsgBoxStyle.Information, "CS .Net Tecnologia")
            Exit Sub
        End Try
    End Sub
    Public Sub PRealizarBackupBancoDeDados()
        Try
            If txtLocalFisicoBancoDeDados.Text = "" Then
                MsgBox("Por favor selecione a pasta para o Backup do Banco de Dados.", MsgBoxStyle.Exclamation, "CS .Net Tecnologia")
                Exit Sub
            End If

            intPergunta = MsgBox("Tem certeza que deseja realizar o Backup do Banco de Dados?",
                               MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CS .Net Tecnologia")
            If intPergunta <> vbYes Then Exit Sub

            Me.Cursor = Cursors.WaitCursor
            PCriarPastaParaBackupBancoDedados()
            System.IO.File.Copy(txtLocalFisicoBancoDeDados.Text, PastaBackup & "BDSistemaLoja.accdb")

            FrmAguarde.ShowDialog()
            MsgBox("Backup do Banco de Dados foi criado com sucesso.", MsgBoxStyle.Information, "CS .Net Tecnologia")
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Ocorreu um erro na tentativa de realizar o backup do Banco de Dados. " & ex.Message, MsgBoxStyle.Information, "CS .Net Tecnologia")
            Exit Sub
        End Try

    End Sub
    Private Sub PPerguntaBackup()
        If txtDestinoBancoDeDados.Text = "" Then
            MsgBox("Por favor selecione o local o Backup do Banco de Dados.", MsgBoxStyle.Exclamation, "CS .Net Tecnologia")
            Exit Sub
        End If
        MsgBox("Por precaução o sistema irá realizar backup do Banco de Dados.",
                             MsgBoxStyle.Information, "CS .Net Tecnologia")

        PRealizarBackupBancoDeDados()
        PRealizaRestauracaoBancoDeDados()
    End Sub
    Private Sub PRealizaRestauracaoBancoDeDados()
        Try
            Dim OpenDialog As New OpenFileDialog
            OpenDialog.Title = "Selecione o local para acessar o backup"
            OpenDialog.Filter = "Arquivo Backup|*.accdb"
            OpenDialog.InitialDirectory = My.Settings.strLocalBackupBancoDeDados & "Backups\"

            If Not Directory.Exists(OpenDialog.InitialDirectory) Then
                MsgBox("Não existe o diretório definido para restaurar o banco de dados. Ou seja, você ainda não realizou nenhum Backup Banco de Dados.",
                       MsgBoxStyle.Information, "CS .Net Tecnologia")
                Exit Sub
            End If

            If OpenDialog.ShowDialog = Windows.Form.DialogResult.Cancel Then
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                System.IO.File.Copy(OpenDialog.FileName, txtLocalFisicoBancoDeDados.Text)

                FrmAguarde.ShowDialog()
                MsgBox("Backup Restaurado. Novas alterações terão efeito depois de reiniciar o aplicativo. O programa será encerrado agora.", MsgBoxStyle.Exclamation, "BackUp Acessado. Reinicar Aplicativo")
                Application.Restart()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Ocorreu um erro na tentativa de restaurar o Banco de Dados. " & ex.Message, MsgBoxStyle.Information, "CS .Net Tecnologia")
            Exit Sub
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLocalizarCaminFisico_Click(sender As Object, e As EventArgs) Handles btnLocalizarCaminFisico.Click
        If FolderBrowserDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            If Not System.IO.File.Exists(FolderBrowserDialog1.SelectedPath & "\BDSistemaLoja.accdb") Then
                MsgBox("Banco de Dados não foi encontrado. Verifique se selecionou o local corretamente.",
                       MsgBoxStyle.Information, "CS .Net Tecnologia")
                Exit Sub
            End If
            If FolderBrowserDialog1.SelectedPath = "C:\" Then
                My.Settings.strCaminhoBancoDeDados = FolderBrowserDialog1.SelectedPath & "BDSistemaLoja.accdb"
                My.Settings.Save()
                txtLocalFisicoBancoDeDados.Text = My.Settings.strCaminhoBancoDeDados
            Else
                My.Settings.strCaminhoBancoDeDados = FolderBrowserDialog1.SelectedPath & "\BDSistemaLoja.accdb"
                My.Settings.Save()
                txtLocalFisicoBancoDeDados.Text = My.Settings.strCaminhoBancoDeDados
            End If
        End If


    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        PPerguntaBackup()

    End Sub

    Private Sub btnRealizarBachup_Click(sender As Object, e As EventArgs) Handles btnRealizarBachup.Click
        PRealizarBackupBancoDeDados()


    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        If FolderBrowserDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Settings.strLocalBackupBancoDeDados = FolderBrowserDialog1.SelectedPath & "\"
            My.Settings.Save()
            txtDestinoBancoDeDados.Text = My.Settings.strLocalBackupBancoDeDados

        End If
        Me.Show()

    End Sub
End Class