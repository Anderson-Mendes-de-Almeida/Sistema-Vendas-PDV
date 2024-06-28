<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRelaProdutEstoq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelaProdutEstoq))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgProduto = New System.Windows.Forms.DataGridView()
        Me.txtPesquisaProdu = New System.Windows.Forms.TextBox()
        Me.cbPesquisa = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalReaisVendas = New System.Windows.Forms.TextBox()
        Me.txtSaldoEstoque = New System.Windows.Forms.TextBox()
        Me.txtvalorEntrada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btTotalSaida = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btTotalEntrada = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btTotalProdutos = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1068, 35)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = Global.Sistema_de_Loja.My.Resources.Resources.visto
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(174, 30)
        Me.ToolStripStatusLabel1.Text = "Cadastrar Produtos"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Image = Global.Sistema_de_Loja.My.Resources.Resources.page_add
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(181, 30)
        Me.ToolStripStatusLabel2.Text = "Entrada de Produtos"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Image = Global.Sistema_de_Loja.My.Resources.Resources.excluir
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(222, 30)
        Me.ToolStripStatusLabel3.Text = "Saida Manual de Produtos"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Image = Global.Sistema_de_Loja.My.Resources.Resources.fechar
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(86, 30)
        Me.ToolStripStatusLabel4.Text = "Fechar"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 51)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1052, 450)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgProduto)
        Me.TabPage1.Controls.Add(Me.txtPesquisaProdu)
        Me.TabPage1.Controls.Add(Me.cbPesquisa)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1044, 422)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalhes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgProduto
        '
        Me.dgProduto.AllowUserToAddRows = False
        Me.dgProduto.AllowUserToDeleteRows = False
        Me.dgProduto.AllowUserToResizeRows = False
        Me.dgProduto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProduto.Location = New System.Drawing.Point(8, 50)
        Me.dgProduto.MultiSelect = False
        Me.dgProduto.Name = "dgProduto"
        Me.dgProduto.ReadOnly = True
        Me.dgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgProduto.Size = New System.Drawing.Size(932, 246)
        Me.dgProduto.TabIndex = 5
        '
        'txtPesquisaProdu
        '
        Me.txtPesquisaProdu.Enabled = False
        Me.txtPesquisaProdu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisaProdu.Location = New System.Drawing.Point(220, 10)
        Me.txtPesquisaProdu.MaxLength = 13
        Me.txtPesquisaProdu.Name = "txtPesquisaProdu"
        Me.txtPesquisaProdu.Size = New System.Drawing.Size(537, 24)
        Me.txtPesquisaProdu.TabIndex = 4
        '
        'cbPesquisa
        '
        Me.cbPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPesquisa.FormattingEnabled = True
        Me.cbPesquisa.Items.AddRange(New Object() {"Produto", "Código de Barras"})
        Me.cbPesquisa.Location = New System.Drawing.Point(9, 8)
        Me.cbPesquisa.Name = "cbPesquisa"
        Me.cbPesquisa.Size = New System.Drawing.Size(194, 26)
        Me.cbPesquisa.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtTotalReaisVendas)
        Me.TabPage2.Controls.Add(Me.txtSaldoEstoque)
        Me.TabPage2.Controls.Add(Me.txtvalorEntrada)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btTotalSaida)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btTotalEntrada)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btTotalProdutos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1044, 422)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estatistícas de Produtos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(797, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total de Unidades Vendidas"
        '
        'txtTotalReaisVendas
        '
        Me.txtTotalReaisVendas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTotalReaisVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalReaisVendas.Location = New System.Drawing.Point(767, 281)
        Me.txtTotalReaisVendas.Multiline = True
        Me.txtTotalReaisVendas.Name = "txtTotalReaisVendas"
        Me.txtTotalReaisVendas.Size = New System.Drawing.Size(215, 37)
        Me.txtTotalReaisVendas.TabIndex = 12
        Me.txtTotalReaisVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoEstoque
        '
        Me.txtSaldoEstoque.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSaldoEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoEstoque.Location = New System.Drawing.Point(286, 283)
        Me.txtSaldoEstoque.Multiline = True
        Me.txtSaldoEstoque.Name = "txtSaldoEstoque"
        Me.txtSaldoEstoque.Size = New System.Drawing.Size(215, 37)
        Me.txtSaldoEstoque.TabIndex = 11
        Me.txtSaldoEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtvalorEntrada
        '
        Me.txtvalorEntrada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtvalorEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalorEntrada.ForeColor = System.Drawing.Color.Red
        Me.txtvalorEntrada.Location = New System.Drawing.Point(526, 284)
        Me.txtvalorEntrada.Multiline = True
        Me.txtvalorEntrada.Name = "txtvalorEntrada"
        Me.txtvalorEntrada.Size = New System.Drawing.Size(215, 37)
        Me.txtvalorEntrada.TabIndex = 10
        Me.txtvalorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(820, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Valor Total Vendas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(568, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Valor Total das Entradas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(332, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Saldo em Estoque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(820, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total de Saida"
        Me.Label3.Visible = False
        '
        'btTotalSaida
        '
        Me.btTotalSaida.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btTotalSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTotalSaida.Location = New System.Drawing.Point(767, 216)
        Me.btTotalSaida.Name = "btTotalSaida"
        Me.btTotalSaida.Size = New System.Drawing.Size(215, 38)
        Me.btTotalSaida.TabIndex = 4
        Me.btTotalSaida.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(568, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total de Entrada"
        '
        'btTotalEntrada
        '
        Me.btTotalEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btTotalEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTotalEntrada.ForeColor = System.Drawing.Color.Black
        Me.btTotalEntrada.Location = New System.Drawing.Point(527, 216)
        Me.btTotalEntrada.Name = "btTotalEntrada"
        Me.btTotalEntrada.Size = New System.Drawing.Size(215, 38)
        Me.btTotalEntrada.TabIndex = 2
        Me.btTotalEntrada.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(332, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Produtos Cadastrados"
        '
        'btTotalProdutos
        '
        Me.btTotalProdutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btTotalProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTotalProdutos.Location = New System.Drawing.Point(286, 216)
        Me.btTotalProdutos.Name = "btTotalProdutos"
        Me.btTotalProdutos.Size = New System.Drawing.Size(215, 38)
        Me.btTotalProdutos.TabIndex = 0
        Me.btTotalProdutos.UseVisualStyleBackColor = False
        '
        'FormRelaProdutEstoq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1068, 502)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRelaProdutEstoq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                              Relação de Produtos em Estoque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgProduto As DataGridView
    Friend WithEvents txtPesquisaProdu As TextBox
    Friend WithEvents cbPesquisa As ComboBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btTotalSaida As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btTotalEntrada As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btTotalProdutos As Button
    Friend WithEvents txtvalorEntrada As TextBox
    Friend WithEvents txtSaldoEstoque As TextBox
    Friend WithEvents txtTotalReaisVendas As TextBox
    Friend WithEvents Label7 As Label
End Class
