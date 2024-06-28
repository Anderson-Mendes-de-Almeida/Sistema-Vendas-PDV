<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVendasRealisadas
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslFechar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgProdutos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMotivoDevol = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDevolucao = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrecoUni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPesqCodBarras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.btConsulta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dgVendasRealiz = New System.Windows.Forms.DataGridView()
        Me.txtPesquisaProdu = New System.Windows.Forms.TextBox()
        Me.cbPesquisa = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgVendasRealiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.TsslFechar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 35)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = Global.Sistema_de_Loja.My.Resources.Resources.Grafico
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(244, 30)
        Me.ToolStripStatusLabel1.Text = "Consultar Vendas  Agrupadas"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Image = Global.Sistema_de_Loja.My.Resources.Resources.Pizza
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(254, 30)
        Me.ToolStripStatusLabel2.Text = "Vendas Agrupadas por Periodo"
        '
        'TsslFechar
        '
        Me.TsslFechar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TsslFechar.ForeColor = System.Drawing.Color.White
        Me.TsslFechar.Image = Global.Sistema_de_Loja.My.Resources.Resources.fechar
        Me.TsslFechar.Name = "TsslFechar"
        Me.TsslFechar.Size = New System.Drawing.Size(86, 30)
        Me.TsslFechar.Text = "Fechar"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(10, 51)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 394)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgProdutos)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtValorTotal)
        Me.TabPage1.Controls.Add(Me.btConsulta)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dtpDataFinal)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dtpDataInicial)
        Me.TabPage1.Controls.Add(Me.dgVendasRealiz)
        Me.TabPage1.Controls.Add(Me.txtPesquisaProdu)
        Me.TabPage1.Controls.Add(Me.cbPesquisa)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(996, 368)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vendas Realizadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgProdutos
        '
        Me.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProdutos.Location = New System.Drawing.Point(882, 8)
        Me.dgProdutos.Name = "dgProdutos"
        Me.dgProdutos.Size = New System.Drawing.Size(208, 32)
        Me.dgProdutos.TabIndex = 14
        Me.dgProdutos.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMotivoDevol)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnDevolucao)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtProduto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPrecoUni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtQtd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPesqCodBarras)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(9, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 125)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devolução de Produtos"
        Me.GroupBox1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(419, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 15)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Motivo da Devolução"
        '
        'txtMotivoDevol
        '
        Me.txtMotivoDevol.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivoDevol.Location = New System.Drawing.Point(422, 42)
        Me.txtMotivoDevol.Multiline = True
        Me.txtMotivoDevol.Name = "txtMotivoDevol"
        Me.txtMotivoDevol.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoDevol.Size = New System.Drawing.Size(265, 75)
        Me.txtMotivoDevol.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(690, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 17)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "lução de produtos em destaque"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(690, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(211, 17)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "ira concluir o processo de devo-"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(690, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 17)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Ao clicar no botão abaixo você"
        '
        'btnDevolucao
        '
        Me.btnDevolucao.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDevolucao.Image = Global.Sistema_de_Loja.My.Resources.Resources.shopping_cart_down1
        Me.btnDevolucao.Location = New System.Drawing.Point(693, 73)
        Me.btnDevolucao.Name = "btnDevolucao"
        Me.btnDevolucao.Size = New System.Drawing.Size(198, 44)
        Me.btnDevolucao.TabIndex = 50
        Me.btnDevolucao.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(190, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Descrição do Produto"
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(193, 42)
        Me.txtProduto.MaxLength = 320
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(215, 23)
        Me.txtProduto.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(176, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(178, 94)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(89, 23)
        Me.txtTotal.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Preço Unidade"
        '
        'txtPrecoUni
        '
        Me.txtPrecoUni.Location = New System.Drawing.Point(6, 94)
        Me.txtPrecoUni.Name = "txtPrecoUni"
        Me.txtPrecoUni.Size = New System.Drawing.Size(89, 23)
        Me.txtPrecoUni.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(101, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Quantidade"
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(101, 94)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(71, 23)
        Me.txtQtd.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Código de Barras"
        '
        'txtPesqCodBarras
        '
        Me.txtPesqCodBarras.Location = New System.Drawing.Point(6, 42)
        Me.txtPesqCodBarras.MaxLength = 13
        Me.txtPesqCodBarras.Name = "txtPesqCodBarras"
        Me.txtPesqCodBarras.Size = New System.Drawing.Size(177, 23)
        Me.txtPesqCodBarras.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(818, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.ForeColor = System.Drawing.Color.Red
        Me.txtValorTotal.Location = New System.Drawing.Point(822, 331)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(168, 33)
        Me.txtValorTotal.TabIndex = 11
        '
        'btConsulta
        '
        Me.btConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConsulta.Location = New System.Drawing.Point(638, 28)
        Me.btConsulta.Name = "btConsulta"
        Me.btConsulta.Size = New System.Drawing.Size(105, 27)
        Me.btConsulta.TabIndex = 10
        Me.btConsulta.Text = "Consulta"
        Me.btConsulta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data Final"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(316, 29)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(101, 26)
        Me.dtpDataFinal.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Inicial"
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(209, 29)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(101, 26)
        Me.dtpDataInicial.TabIndex = 6
        '
        'dgVendasRealiz
        '
        Me.dgVendasRealiz.AllowUserToAddRows = False
        Me.dgVendasRealiz.AllowUserToDeleteRows = False
        Me.dgVendasRealiz.AllowUserToResizeRows = False
        Me.dgVendasRealiz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVendasRealiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVendasRealiz.Location = New System.Drawing.Point(8, 61)
        Me.dgVendasRealiz.MultiSelect = False
        Me.dgVendasRealiz.Name = "dgVendasRealiz"
        Me.dgVendasRealiz.ReadOnly = True
        Me.dgVendasRealiz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVendasRealiz.Size = New System.Drawing.Size(872, 170)
        Me.dgVendasRealiz.TabIndex = 5
        '
        'txtPesquisaProdu
        '
        Me.txtPesquisaProdu.Enabled = False
        Me.txtPesquisaProdu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisaProdu.Location = New System.Drawing.Point(423, 28)
        Me.txtPesquisaProdu.Name = "txtPesquisaProdu"
        Me.txtPesquisaProdu.Size = New System.Drawing.Size(209, 26)
        Me.txtPesquisaProdu.TabIndex = 4
        '
        'cbPesquisa
        '
        Me.cbPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPesquisa.FormattingEnabled = True
        Me.cbPesquisa.Items.AddRange(New Object() {"Por Data", "Por Produto", "-------------------------------------------", "Casrregar Todas Vendas"})
        Me.cbPesquisa.Location = New System.Drawing.Point(9, 29)
        Me.cbPesquisa.Name = "cbPesquisa"
        Me.cbPesquisa.Size = New System.Drawing.Size(194, 26)
        Me.cbPesquisa.TabIndex = 3
        Me.cbPesquisa.Text = "Por Datas"
        '
        'FormVendasRealisadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1024, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormVendasRealisadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                                           Vendas Realisadas"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgVendasRealiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgVendasRealiz As DataGridView
    Friend WithEvents txtPesquisaProdu As TextBox
    Friend WithEvents cbPesquisa As ComboBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btConsulta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TsslFechar As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents dgProdutos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMotivoDevol As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnDevolucao As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrecoUni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQtd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPesqCodBarras As TextBox
End Class
