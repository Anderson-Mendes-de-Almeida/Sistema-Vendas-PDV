<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTelaVenda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTelaVenda))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttroco = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.LtTelaVenda = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.rbCartao = New System.Windows.Forms.RadioButton()
        Me.rbDinheiro = New System.Windows.Forms.RadioButton()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.txtDinheiro = New System.Windows.Forms.TextBox()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 108)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAIXA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1005, 730)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttroco)
        Me.GroupBox3.Controls.Add(Me.txtDescricao)
        Me.GroupBox3.Controls.Add(Me.LtTelaVenda)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.txtDinheiro)
        Me.GroupBox3.Controls.Add(Me.txtTotalPagar)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCodBarras)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(993, 581)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'txttroco
        '
        Me.txttroco.Enabled = False
        Me.txttroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttroco.Location = New System.Drawing.Point(628, 367)
        Me.txttroco.Name = "txttroco"
        Me.txttroco.Size = New System.Drawing.Size(345, 35)
        Me.txttroco.TabIndex = 79
        Me.txttroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(628, 147)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(345, 35)
        Me.txtDescricao.TabIndex = 78
        '
        'LtTelaVenda
        '
        Me.LtTelaVenda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LtTelaVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtTelaVenda.FullRowSelect = True
        Me.LtTelaVenda.GridLines = True
        Me.LtTelaVenda.Location = New System.Drawing.Point(8, 93)
        Me.LtTelaVenda.Name = "LtTelaVenda"
        Me.LtTelaVenda.Size = New System.Drawing.Size(608, 466)
        Me.LtTelaVenda.TabIndex = 23
        Me.LtTelaVenda.UseCompatibleStateImageBehavior = False
        Me.LtTelaVenda.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CÓDIGO BARRAS"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PRODUTO"
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PREÇO"
        Me.ColumnHeader3.Width = 110
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnCancelar)
        Me.GroupBox5.Controls.Add(Me.btnFinalizar)
        Me.GroupBox5.Controls.Add(Me.rbCartao)
        Me.GroupBox5.Controls.Add(Me.rbDinheiro)
        Me.GroupBox5.Controls.Add(Me.rbCheque)
        Me.GroupBox5.Location = New System.Drawing.Point(628, 425)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(345, 132)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(178, 73)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(161, 53)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar Venda Ativa"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Enabled = False
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(6, 73)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(161, 53)
        Me.btnFinalizar.TabIndex = 10
        Me.btnFinalizar.Text = "Finalizar Venda Ativa"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'rbCartao
        '
        Me.rbCartao.AutoSize = True
        Me.rbCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCartao.Location = New System.Drawing.Point(131, 25)
        Me.rbCartao.Name = "rbCartao"
        Me.rbCartao.Size = New System.Drawing.Size(94, 29)
        Me.rbCartao.TabIndex = 8
        Me.rbCartao.Text = "Cartão"
        Me.rbCartao.UseVisualStyleBackColor = True
        '
        'rbDinheiro
        '
        Me.rbDinheiro.AutoSize = True
        Me.rbDinheiro.Checked = True
        Me.rbDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDinheiro.Location = New System.Drawing.Point(10, 25)
        Me.rbDinheiro.Name = "rbDinheiro"
        Me.rbDinheiro.Size = New System.Drawing.Size(110, 29)
        Me.rbDinheiro.TabIndex = 7
        Me.rbDinheiro.TabStop = True
        Me.rbDinheiro.Text = "Dinheiro"
        Me.rbDinheiro.UseVisualStyleBackColor = True
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheque.Location = New System.Drawing.Point(237, 25)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(105, 29)
        Me.rbCheque.TabIndex = 9
        Me.rbCheque.Text = "Cheque"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'txtDinheiro
        '
        Me.txtDinheiro.Enabled = False
        Me.txtDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDinheiro.ForeColor = System.Drawing.Color.Red
        Me.txtDinheiro.Location = New System.Drawing.Point(626, 287)
        Me.txtDinheiro.Name = "txtDinheiro"
        Me.txtDinheiro.Size = New System.Drawing.Size(347, 35)
        Me.txtDinheiro.TabIndex = 6
        Me.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Enabled = False
        Me.txtTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPagar.ForeColor = System.Drawing.Color.Red
        Me.txtTotalPagar.Location = New System.Drawing.Point(626, 213)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(347, 35)
        Me.txtTotalPagar.TabIndex = 9
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(622, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "TOTAL A PAGAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(622, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 24)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "DESCRIÇÃO DO PRODUTO"
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(626, 88)
        Me.txtCodBarras.MaxLength = 13
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(347, 35)
        Me.txtCodBarras.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(987, 48)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(190, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(621, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AGUARDANDO LEITURA DOS PRODUTOS..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LISTA DE PRODUTOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(622, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(351, 24)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "CÓDIGO DE BARRAS DOS PRODUTOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(622, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "DINHEIRO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(622, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "TROCO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(993, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_de_Loja.My.Resources.Resources.shopping_cart1
        Me.PictureBox1.Location = New System.Drawing.Point(762, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FormTelaVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTelaVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDinheiro As TextBox
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbDinheiro As RadioButton
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LtTelaVenda As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txttroco As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbCartao As RadioButton
    Friend WithEvents rbCheque As RadioButton
End Class
