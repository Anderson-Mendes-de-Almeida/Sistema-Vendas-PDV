<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarProd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEditeDescric = New System.Windows.Forms.TextBox()
        Me.cbPesquisaEntr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPesquisaProdEntr = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrecoVenda)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPreco)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnProcurar)
        Me.GroupBox1.Controls.Add(Me.btnAtualizar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEditeDescric)
        Me.GroupBox1.Controls.Add(Me.cbPesquisaEntr)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPesquisaProdEntr)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editando Descrição Produtos"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Location = New System.Drawing.Point(155, 137)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(128, 20)
        Me.txtPrecoVenda.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Edite Preço Venda"
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(5, 137)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(128, 20)
        Me.txtPreco.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Edite Preço Compra"
        '
        'btnProcurar
        '
        Me.btnProcurar.Location = New System.Drawing.Point(190, 162)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(184, 23)
        Me.btnProcurar.TabIndex = 17
        Me.btnProcurar.Text = "PRODURAR"
        Me.btnProcurar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Enabled = False
        Me.btnAtualizar.Location = New System.Drawing.Point(5, 162)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(184, 23)
        Me.btnAtualizar.TabIndex = 16
        Me.btnAtualizar.Text = "ATUALIZAR"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Edite a Descrição do Produto"
        '
        'txtEditeDescric
        '
        Me.txtEditeDescric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEditeDescric.Location = New System.Drawing.Point(5, 95)
        Me.txtEditeDescric.Name = "txtEditeDescric"
        Me.txtEditeDescric.Size = New System.Drawing.Size(371, 23)
        Me.txtEditeDescric.TabIndex = 14
        '
        'cbPesquisaEntr
        '
        Me.cbPesquisaEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPesquisaEntr.FormattingEnabled = True
        Me.cbPesquisaEntr.Items.AddRange(New Object() {"Código de Barras"})
        Me.cbPesquisaEntr.Location = New System.Drawing.Point(5, 44)
        Me.cbPesquisaEntr.Name = "cbPesquisaEntr"
        Me.cbPesquisaEntr.Size = New System.Drawing.Size(128, 24)
        Me.cbPesquisaEntr.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cosultar Produtos"
        '
        'txtPesquisaProdEntr
        '
        Me.txtPesquisaProdEntr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPesquisaProdEntr.Enabled = False
        Me.txtPesquisaProdEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisaProdEntr.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPesquisaProdEntr.Location = New System.Drawing.Point(155, 44)
        Me.txtPesquisaProdEntr.MaxLength = 13
        Me.txtPesquisaProdEntr.Name = "txtPesquisaProdEntr"
        Me.txtPesquisaProdEntr.Size = New System.Drawing.Size(221, 23)
        Me.txtPesquisaProdEntr.TabIndex = 11
        '
        'FormEditarProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(393, 214)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditarProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                 Editar Descrição de Produtos"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbPesquisaEntr As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPesquisaProdEntr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEditeDescric As TextBox
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnProcurar As Button
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents Label4 As Label
End Class
