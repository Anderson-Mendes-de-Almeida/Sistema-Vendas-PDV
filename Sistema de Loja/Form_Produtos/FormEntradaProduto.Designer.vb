<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEntradaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEntradaProduto))
        Me.txtPesquisaProdEntr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgEntradProduto = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEntradaProduto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalvarEntradaProd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbPesquisaEntr = New System.Windows.Forms.ComboBox()
        Me.txtEm_Estoque = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustoUnitario = New System.Windows.Forms.TextBox()
        Me.txtCustoTotalEntr = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgEntradProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPesquisaProdEntr
        '
        Me.txtPesquisaProdEntr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPesquisaProdEntr.Enabled = False
        Me.txtPesquisaProdEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisaProdEntr.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPesquisaProdEntr.Location = New System.Drawing.Point(251, 44)
        Me.txtPesquisaProdEntr.MaxLength = 13
        Me.txtPesquisaProdEntr.Name = "txtPesquisaProdEntr"
        Me.txtPesquisaProdEntr.Size = New System.Drawing.Size(464, 24)
        Me.txtPesquisaProdEntr.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cosultar Produtos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lista de Produtos"
        '
        'dgEntradProduto
        '
        Me.dgEntradProduto.AllowUserToAddRows = False
        Me.dgEntradProduto.AllowUserToDeleteRows = False
        Me.dgEntradProduto.AllowUserToResizeRows = False
        Me.dgEntradProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgEntradProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEntradProduto.Location = New System.Drawing.Point(17, 107)
        Me.dgEntradProduto.MultiSelect = False
        Me.dgEntradProduto.Name = "dgEntradProduto"
        Me.dgEntradProduto.ReadOnly = True
        Me.dgEntradProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgEntradProduto.Size = New System.Drawing.Size(698, 325)
        Me.dgEntradProduto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(719, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Em Estoque"
        '
        'txtEntradaProduto
        '
        Me.txtEntradaProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEntradaProduto.Enabled = False
        Me.txtEntradaProduto.Location = New System.Drawing.Point(722, 107)
        Me.txtEntradaProduto.Name = "txtEntradaProduto"
        Me.txtEntradaProduto.Size = New System.Drawing.Size(137, 21)
        Me.txtEntradaProduto.TabIndex = 6
        Me.txtEntradaProduto.Text = " "
        Me.txtEntradaProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(719, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Qtda. Comprada"
        '
        'btnSalvarEntradaProd
        '
        Me.btnSalvarEntradaProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalvarEntradaProd.Enabled = False
        Me.btnSalvarEntradaProd.Location = New System.Drawing.Point(722, 249)
        Me.btnSalvarEntradaProd.Name = "btnSalvarEntradaProd"
        Me.btnSalvarEntradaProd.Size = New System.Drawing.Size(138, 27)
        Me.btnSalvarEntradaProd.TabIndex = 8
        Me.btnSalvarEntradaProd.Text = "Salvar Entrada"
        Me.btnSalvarEntradaProd.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(722, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbPesquisaEntr
        '
        Me.cbPesquisaEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPesquisaEntr.FormattingEnabled = True
        Me.cbPesquisaEntr.Items.AddRange(New Object() {"Produto", "Código de Barras"})
        Me.cbPesquisaEntr.Location = New System.Drawing.Point(17, 44)
        Me.cbPesquisaEntr.Name = "cbPesquisaEntr"
        Me.cbPesquisaEntr.Size = New System.Drawing.Size(226, 26)
        Me.cbPesquisaEntr.TabIndex = 10
        '
        'txtEm_Estoque
        '
        Me.txtEm_Estoque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEm_Estoque.ForeColor = System.Drawing.Color.Red
        Me.txtEm_Estoque.Location = New System.Drawing.Point(722, 43)
        Me.txtEm_Estoque.Name = "txtEm_Estoque"
        Me.txtEm_Estoque.ReadOnly = True
        Me.txtEm_Estoque.Size = New System.Drawing.Size(137, 21)
        Me.txtEm_Estoque.TabIndex = 11
        Me.txtEm_Estoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(725, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Aqui você ira poder alterar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(725, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "quantidade de produtos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(723, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "quando houver necessidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(719, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Custo Unitario"
        '
        'txtCustoUnitario
        '
        Me.txtCustoUnitario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCustoUnitario.Enabled = False
        Me.txtCustoUnitario.Location = New System.Drawing.Point(722, 158)
        Me.txtCustoUnitario.Name = "txtCustoUnitario"
        Me.txtCustoUnitario.Size = New System.Drawing.Size(137, 21)
        Me.txtCustoUnitario.TabIndex = 7
        Me.txtCustoUnitario.Text = " "
        Me.txtCustoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCustoTotalEntr
        '
        Me.txtCustoTotalEntr.Enabled = False
        Me.txtCustoTotalEntr.Location = New System.Drawing.Point(722, 208)
        Me.txtCustoTotalEntr.Name = "txtCustoTotalEntr"
        Me.txtCustoTotalEntr.Size = New System.Drawing.Size(138, 21)
        Me.txtCustoTotalEntr.TabIndex = 100
        Me.txtCustoTotalEntr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(719, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Custo Total"
        '
        'FormEntradaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(884, 447)
        Me.Controls.Add(Me.txtCustoTotalEntr)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCustoUnitario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEm_Estoque)
        Me.Controls.Add(Me.cbPesquisaEntr)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalvarEntradaProd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEntradaProduto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgEntradProduto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPesquisaProdEntr)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEntradaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                                 Entrada Produto"
        Me.TopMost = True
        CType(Me.dgEntradProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPesquisaProdEntr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgEntradProduto As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEntradaProduto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalvarEntradaProd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbPesquisaEntr As ComboBox
    Friend WithEvents txtEm_Estoque As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustoUnitario As TextBox
    Friend WithEvents txtCustoTotalEntr As TextBox
    Friend WithEvents Label9 As Label
End Class
