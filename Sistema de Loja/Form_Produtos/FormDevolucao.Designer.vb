<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDevolucao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDevolucao))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarVend = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.txtMotivoDevol = New System.Windows.Forms.TextBox()
        Me.txtNuNota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LtTelaVenda = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LtTelaVenda2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtLimpa = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalProdu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblDevolvidos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtMotivoDevol)
        Me.GroupBox1.Location = New System.Drawing.Point(605, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 370)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelarVend)
        Me.GroupBox2.Controls.Add(Me.btnFinalizar)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 98)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'btnCancelarVend
        '
        Me.btnCancelarVend.Location = New System.Drawing.Point(127, 21)
        Me.btnCancelarVend.Name = "btnCancelarVend"
        Me.btnCancelarVend.Size = New System.Drawing.Size(106, 50)
        Me.btnCancelarVend.TabIndex = 38
        Me.btnCancelarVend.Text = "Cancelar Venda"
        Me.btnCancelarVend.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Enabled = False
        Me.btnFinalizar.Location = New System.Drawing.Point(14, 21)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(106, 50)
        Me.btnFinalizar.TabIndex = 37
        Me.btnFinalizar.Text = "Confirmar Devolução"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'txtMotivoDevol
        '
        Me.txtMotivoDevol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoDevol.ForeColor = System.Drawing.Color.Red
        Me.txtMotivoDevol.Location = New System.Drawing.Point(9, 20)
        Me.txtMotivoDevol.Multiline = True
        Me.txtMotivoDevol.Name = "txtMotivoDevol"
        Me.txtMotivoDevol.Size = New System.Drawing.Size(243, 229)
        Me.txtMotivoDevol.TabIndex = 45
        '
        'txtNuNota
        '
        Me.txtNuNota.Location = New System.Drawing.Point(57, 33)
        Me.txtNuNota.Name = "txtNuNota"
        Me.txtNuNota.Size = New System.Drawing.Size(99, 21)
        Me.txtNuNota.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Lista de Produtos"
        '
        'LtTelaVenda
        '
        Me.LtTelaVenda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LtTelaVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtTelaVenda.FullRowSelect = True
        Me.LtTelaVenda.GridLines = True
        Me.LtTelaVenda.Location = New System.Drawing.Point(9, 97)
        Me.LtTelaVenda.Name = "LtTelaVenda"
        Me.LtTelaVenda.Size = New System.Drawing.Size(537, 63)
        Me.LtTelaVenda.TabIndex = 33
        Me.LtTelaVenda.UseCompatibleStateImageBehavior = False
        Me.LtTelaVenda.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NÚMERO NOTA"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DATA COMPRA"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PAGAMENTO"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TOTAL"
        Me.ColumnHeader4.Width = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 24)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Número Nota"
        '
        'LtTelaVenda2
        '
        Me.LtTelaVenda2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader9, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LtTelaVenda2.FullRowSelect = True
        Me.LtTelaVenda2.GridLines = True
        Me.LtTelaVenda2.Location = New System.Drawing.Point(9, 166)
        Me.LtTelaVenda2.Name = "LtTelaVenda2"
        Me.LtTelaVenda2.Size = New System.Drawing.Size(590, 226)
        Me.LtTelaVenda2.TabIndex = 42
        Me.LtTelaVenda2.UseCompatibleStateImageBehavior = False
        Me.LtTelaVenda2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 2
        Me.ColumnHeader5.Text = "Produto"
        Me.ColumnHeader5.Width = 300
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.DisplayIndex = 0
        Me.ColumnHeader9.Text = "Codigo"
        Me.ColumnHeader9.Width = 7
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 1
        Me.ColumnHeader6.Text = "Cod. Barra"
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Quantidade"
        Me.ColumnHeader7.Width = 85
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Valor. Uni"
        Me.ColumnHeader8.Width = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(636, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 16)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Motivo da Devolução Produto"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.txtNuNota)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtLimpa)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(534, 63)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_de_Loja.My.Resources.Resources.Find6
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'BtLimpa
        '
        Me.BtLimpa.Enabled = False
        Me.BtLimpa.Image = Global.Sistema_de_Loja.My.Resources.Resources.icons8_vassoura_48
        Me.BtLimpa.Location = New System.Drawing.Point(215, 12)
        Me.BtLimpa.Name = "BtLimpa"
        Me.BtLimpa.Size = New System.Drawing.Size(84, 47)
        Me.BtLimpa.TabIndex = 43
        Me.BtLimpa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtLimpa.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalProdu)
        Me.GroupBox4.Location = New System.Drawing.Point(552, 116)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(47, 44)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        '
        'lblTotalProdu
        '
        Me.lblTotalProdu.AutoSize = True
        Me.lblTotalProdu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProdu.ForeColor = System.Drawing.Color.Red
        Me.lblTotalProdu.Location = New System.Drawing.Point(10, 15)
        Me.lblTotalProdu.Name = "lblTotalProdu"
        Me.lblTotalProdu.Size = New System.Drawing.Size(18, 25)
        Me.lblTotalProdu.TabIndex = 48
        Me.lblTotalProdu.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(551, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "nº Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(548, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Devolvidos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblDevolvidos)
        Me.GroupBox5.Location = New System.Drawing.Point(549, 23)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(47, 44)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        '
        'lblDevolvidos
        '
        Me.lblDevolvidos.AutoSize = True
        Me.lblDevolvidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevolvidos.ForeColor = System.Drawing.Color.Red
        Me.lblDevolvidos.Location = New System.Drawing.Point(10, 15)
        Me.lblDevolvidos.Name = "lblDevolvidos"
        Me.lblDevolvidos.Size = New System.Drawing.Size(18, 25)
        Me.lblDevolvidos.TabIndex = 48
        Me.lblDevolvidos.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(228, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 15)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Obs: Clicar na data da compra para visualizar todos Itens"
        '
        'FormDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(873, 402)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LtTelaVenda2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LtTelaVenda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDevolucao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                            Devolução de Produtos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancelarVend As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents txtNuNota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LtTelaVenda As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents LtTelaVenda2 As ListView
    Friend WithEvents BtLimpa As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents txtMotivoDevol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTotalProdu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblDevolvidos As Label
    Friend WithEvents Label5 As Label
End Class
