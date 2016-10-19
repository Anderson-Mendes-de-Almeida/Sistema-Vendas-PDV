<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadasFornece
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCadasFornece))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslNovo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mktCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.mktCelular = New System.Windows.Forms.MaskedTextBox()
        Me.mktTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mktcep = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dglistProd = New System.Windows.Forms.DataGridView()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Comentario = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbUf = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeForne = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dglistProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslNovo, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(670, 35)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslNovo
        '
        Me.tsslNovo.ForeColor = System.Drawing.Color.White
        Me.tsslNovo.Image = Global.Sistema_de_Loja.My.Resources.Resources.user_add
        Me.tsslNovo.Name = "tsslNovo"
        Me.tsslNovo.Size = New System.Drawing.Size(71, 30)
        Me.tsslNovo.Text = "NOVO"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = Global.Sistema_de_Loja.My.Resources.Resources.window_edit
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(82, 30)
        Me.ToolStripStatusLabel1.Text = "GRAVAR"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Image = Global.Sistema_de_Loja.My.Resources.Resources.page_edit
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 30)
        Me.ToolStripStatusLabel2.Text = "ALTERAR"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Gray
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(32, 30)
        Me.ToolStripStatusLabel3.Text = "-----"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Image = Global.Sistema_de_Loja.My.Resources.Resources.fechar
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(61, 30)
        Me.ToolStripStatusLabel4.Text = "SAIR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mktCnpj)
        Me.GroupBox1.Controls.Add(Me.mktCelular)
        Me.GroupBox1.Controls.Add(Me.mktTelefone)
        Me.GroupBox1.Controls.Add(Me.mktcep)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtComentario)
        Me.GroupBox1.Controls.Add(Me.Comentario)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpCadastro)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbUf)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNomeForne)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 347)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'mktCnpj
        '
        Me.mktCnpj.Location = New System.Drawing.Point(262, 32)
        Me.mktCnpj.Mask = "00.000.000/0000-00"
        Me.mktCnpj.Name = "mktCnpj"
        Me.mktCnpj.Size = New System.Drawing.Size(112, 20)
        Me.mktCnpj.TabIndex = 4
        '
        'mktCelular
        '
        Me.mktCelular.Location = New System.Drawing.Point(129, 186)
        Me.mktCelular.Mask = "(000) 0-0000-0000"
        Me.mktCelular.Name = "mktCelular"
        Me.mktCelular.Size = New System.Drawing.Size(100, 20)
        Me.mktCelular.TabIndex = 11
        '
        'mktTelefone
        '
        Me.mktTelefone.Location = New System.Drawing.Point(16, 186)
        Me.mktTelefone.Mask = "(000) 0000-0000"
        Me.mktTelefone.Name = "mktTelefone"
        Me.mktTelefone.Size = New System.Drawing.Size(100, 20)
        Me.mktTelefone.TabIndex = 10
        '
        'mktcep
        '
        Me.mktcep.Location = New System.Drawing.Point(17, 146)
        Me.mktcep.Mask = "00000-000"
        Me.mktcep.Name = "mktcep"
        Me.mktcep.Size = New System.Drawing.Size(100, 20)
        Me.mktcep.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dglistProd)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 316)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE PRODUTOS"
        '
        'dglistProd
        '
        Me.dglistProd.AllowUserToAddRows = False
        Me.dglistProd.AllowUserToDeleteRows = False
        Me.dglistProd.AllowUserToResizeRows = False
        Me.dglistProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglistProd.Location = New System.Drawing.Point(6, 19)
        Me.dglistProd.MultiSelect = False
        Me.dglistProd.Name = "dglistProd"
        Me.dglistProd.ReadOnly = True
        Me.dglistProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dglistProd.Size = New System.Drawing.Size(263, 291)
        Me.dglistProd.TabIndex = 15
        '
        'txtComentario
        '
        Me.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComentario.Location = New System.Drawing.Point(17, 264)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(357, 71)
        Me.txtComentario.TabIndex = 14
        '
        'Comentario
        '
        Me.Comentario.AutoSize = True
        Me.Comentario.Location = New System.Drawing.Point(14, 248)
        Me.Comentario.Name = "Comentario"
        Me.Comentario.Size = New System.Drawing.Size(79, 13)
        Me.Comentario.TabIndex = 28
        Me.Comentario.Text = "COMENTÁRIO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(241, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "CADASTRO"
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCadastro.Location = New System.Drawing.Point(244, 186)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(130, 20)
        Me.dtpCadastro.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(16, 227)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(214, 20)
        Me.txtEmail.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "E-MAIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(313, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "UF"
        '
        'cbUf
        '
        Me.cbUf.FormattingEnabled = True
        Me.cbUf.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbUf.Location = New System.Drawing.Point(313, 107)
        Me.cbUf.Name = "cbUf"
        Me.cbUf.Size = New System.Drawing.Size(61, 21)
        Me.cbUf.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(126, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "CELULAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "TELEFONE"
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(16, 107)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(291, 20)
        Me.txtCidade.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CIDADE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "CEP"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(225, 71)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(149, 20)
        Me.txtBairro.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "BAIRRO"
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(16, 71)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(203, 20)
        Me.txtEndereco.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ENDEREÇO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CNPJ"
        '
        'txtNomeForne
        '
        Me.txtNomeForne.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeForne.Location = New System.Drawing.Point(16, 33)
        Me.txtNomeForne.Name = "txtNomeForne"
        Me.txtNomeForne.Size = New System.Drawing.Size(240, 20)
        Me.txtNomeForne.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOME DA EMPRESA"
        '
        'FormCadasFornece
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(670, 390)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCadasFornece"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                              CAD" &
    "ASTRO FORNECEDORES"
        Me.TopMost = True
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dglistProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mktCelular As MaskedTextBox
    Friend WithEvents mktTelefone As MaskedTextBox
    Friend WithEvents mktcep As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dglistProd As DataGridView
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Comentario As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpCadastro As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbUf As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeForne As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tsslNovo As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents mktCnpj As MaskedTextBox
End Class
