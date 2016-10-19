<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCadastroProdut
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtunidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVlrVenda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEm_Estoque = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtdMinEsto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btCalcGanho = New System.Windows.Forms.Button()
        Me.txtValorTotalEntrad = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(451, 35)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = Global.Sistema_de_Loja.My.Resources.Resources.visto
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(110, 30)
        Me.ToolStripStatusLabel1.Text = "Concluído"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Image = Global.Sistema_de_Loja.My.Resources.Resources.fechar
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 30)
        Me.ToolStripStatusLabel2.Text = "Fechar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código de Barras do Produto (Ex: 9852541200010)"
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Location = New System.Drawing.Point(15, 64)
        Me.txtCodBarras.MaxLength = 13
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(284, 21)
        Me.txtCodBarras.TabIndex = 2
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(15, 109)
        Me.txtDescricao.MaxLength = 500
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(431, 21)
        Me.txtDescricao.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrição do Produto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Custo Unitario"
        '
        'txtunidade
        '
        Me.txtunidade.Location = New System.Drawing.Point(15, 157)
        Me.txtunidade.Name = "txtunidade"
        Me.txtunidade.Size = New System.Drawing.Size(132, 21)
        Me.txtunidade.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(162, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Valor Venda Produto"
        '
        'txtVlrVenda
        '
        Me.txtVlrVenda.Location = New System.Drawing.Point(165, 157)
        Me.txtVlrVenda.Name = "txtVlrVenda"
        Me.txtVlrVenda.Size = New System.Drawing.Size(134, 21)
        Me.txtVlrVenda.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(309, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Qtda. Comprada"
        '
        'txtEm_Estoque
        '
        Me.txtEm_Estoque.Location = New System.Drawing.Point(312, 157)
        Me.txtEm_Estoque.Name = "txtEm_Estoque"
        Me.txtEm_Estoque.Size = New System.Drawing.Size(134, 21)
        Me.txtEm_Estoque.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(299, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fique atento(a) todos aprodutos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(299, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "devem conter código barras."
        '
        'txtQtdMinEsto
        '
        Me.txtQtdMinEsto.Location = New System.Drawing.Point(165, 203)
        Me.txtQtdMinEsto.Name = "txtQtdMinEsto"
        Me.txtQtdMinEsto.Size = New System.Drawing.Size(132, 21)
        Me.txtQtdMinEsto.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(162, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Qtda. Estoque Minimo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(12, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Custo Total"
        '
        'btCalcGanho
        '
        Me.btCalcGanho.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btCalcGanho.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCalcGanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalcGanho.Location = New System.Drawing.Point(312, 203)
        Me.btCalcGanho.Name = "btCalcGanho"
        Me.btCalcGanho.Size = New System.Drawing.Size(134, 23)
        Me.btCalcGanho.TabIndex = 17
        Me.btCalcGanho.Text = "Calcular % de Ganho"
        Me.btCalcGanho.UseVisualStyleBackColor = False
        '
        'txtValorTotalEntrad
        '
        Me.txtValorTotalEntrad.Location = New System.Drawing.Point(15, 205)
        Me.txtValorTotalEntrad.Name = "txtValorTotalEntrad"
        Me.txtValorTotalEntrad.Size = New System.Drawing.Size(132, 21)
        Me.txtValorTotalEntrad.TabIndex = 18
        '
        'FormCadastroProdut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(451, 236)
        Me.Controls.Add(Me.txtValorTotalEntrad)
        Me.Controls.Add(Me.btCalcGanho)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtQtdMinEsto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEm_Estoque)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVlrVenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtunidade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCadastroProdut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        Me.TopMost = True
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtunidade As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVlrVenda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEm_Estoque As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQtdMinEsto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btCalcGanho As Button
    Friend WithEvents txtValorTotalEntrad As TextBox
End Class
