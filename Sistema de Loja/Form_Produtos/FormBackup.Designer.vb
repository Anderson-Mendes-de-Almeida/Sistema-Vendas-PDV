<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBackup
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBackup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnRealizarBachup = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDestinoBancoDeDados = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLocalFisicoBancoDeDados = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnLocalizarCaminFisico = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestaurar)
        Me.GroupBox1.Controls.Add(Me.btnRealizarBachup)
        Me.GroupBox1.Controls.Add(Me.btnLocalizar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDestinoBancoDeDados)
        Me.GroupBox1.Controls.Add(Me.btnLocalizarCaminFisico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLocalFisicoBancoDeDados)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalhes para Bachup"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.Location = New System.Drawing.Point(436, 146)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(139, 64)
        Me.btnRestaurar.TabIndex = 7
        Me.btnRestaurar.Text = "Restaurar do Banco de Dados?"
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnRealizarBachup
        '
        Me.btnRealizarBachup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarBachup.Location = New System.Drawing.Point(436, 51)
        Me.btnRealizarBachup.Name = "btnRealizarBachup"
        Me.btnRealizarBachup.Size = New System.Drawing.Size(139, 64)
        Me.btnRealizarBachup.TabIndex = 6
        Me.btnRealizarBachup.Text = "Realizar Backup..."
        Me.btnRealizarBachup.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnLocalizar.Location = New System.Drawing.Point(249, 185)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(156, 23)
        Me.btnLocalizar.TabIndex = 3
        Me.btnLocalizar.Text = "Localizar..."
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Local do Backup do Banco de Dados"
        '
        'txtDestinoBancoDeDados
        '
        Me.txtDestinoBancoDeDados.Location = New System.Drawing.Point(20, 146)
        Me.txtDestinoBancoDeDados.Multiline = True
        Me.txtDestinoBancoDeDados.Name = "txtDestinoBancoDeDados"
        Me.txtDestinoBancoDeDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDestinoBancoDeDados.Size = New System.Drawing.Size(385, 33)
        Me.txtDestinoBancoDeDados.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Local Físico do Banco de Dados"
        '
        'txtLocalFisicoBancoDeDados
        '
        Me.txtLocalFisicoBancoDeDados.Location = New System.Drawing.Point(20, 53)
        Me.txtLocalFisicoBancoDeDados.Multiline = True
        Me.txtLocalFisicoBancoDeDados.Name = "txtLocalFisicoBancoDeDados"
        Me.txtLocalFisicoBancoDeDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLocalFisicoBancoDeDados.Size = New System.Drawing.Size(385, 33)
        Me.txtLocalFisicoBancoDeDados.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnLocalizarCaminFisico
        '
        Me.btnLocalizarCaminFisico.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnLocalizarCaminFisico.Location = New System.Drawing.Point(249, 92)
        Me.btnLocalizarCaminFisico.Name = "btnLocalizarCaminFisico"
        Me.btnLocalizarCaminFisico.Size = New System.Drawing.Size(156, 23)
        Me.btnLocalizarCaminFisico.TabIndex = 1
        Me.btnLocalizarCaminFisico.Text = "Localizar..."
        Me.btnLocalizarCaminFisico.UseVisualStyleBackColor = True
        '
        'FormBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(626, 247)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                               Faça Backup de seus Registros"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLocalFisicoBancoDeDados As TextBox
    Friend WithEvents btnLocalizar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDestinoBancoDeDados As TextBox
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnRealizarBachup As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnLocalizarCaminFisico As Button
End Class
