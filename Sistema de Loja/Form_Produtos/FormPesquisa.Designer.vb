<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPesquisa
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
        Me.cbPesquisaEntr = New System.Windows.Forms.ComboBox()
        Me.dgEntradProduto = New System.Windows.Forms.DataGridView()
        Me.txtPesquisaProdEntr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgEntradProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPesquisaEntr
        '
        Me.cbPesquisaEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPesquisaEntr.FormattingEnabled = True
        Me.cbPesquisaEntr.Items.AddRange(New Object() {"Produto", "Código de Barras"})
        Me.cbPesquisaEntr.Location = New System.Drawing.Point(8, 39)
        Me.cbPesquisaEntr.Name = "cbPesquisaEntr"
        Me.cbPesquisaEntr.Size = New System.Drawing.Size(188, 26)
        Me.cbPesquisaEntr.TabIndex = 109
        '
        'dgEntradProduto
        '
        Me.dgEntradProduto.AllowUserToAddRows = False
        Me.dgEntradProduto.AllowUserToDeleteRows = False
        Me.dgEntradProduto.AllowUserToResizeRows = False
        Me.dgEntradProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgEntradProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEntradProduto.Location = New System.Drawing.Point(8, 80)
        Me.dgEntradProduto.MultiSelect = False
        Me.dgEntradProduto.Name = "dgEntradProduto"
        Me.dgEntradProduto.ReadOnly = True
        Me.dgEntradProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgEntradProduto.Size = New System.Drawing.Size(587, 111)
        Me.dgEntradProduto.TabIndex = 102
        '
        'txtPesquisaProdEntr
        '
        Me.txtPesquisaProdEntr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPesquisaProdEntr.Enabled = False
        Me.txtPesquisaProdEntr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesquisaProdEntr.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPesquisaProdEntr.Location = New System.Drawing.Point(202, 39)
        Me.txtPesquisaProdEntr.MaxLength = 13
        Me.txtPesquisaProdEntr.Name = "txtPesquisaProdEntr"
        Me.txtPesquisaProdEntr.Size = New System.Drawing.Size(390, 24)
        Me.txtPesquisaProdEntr.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Pesquisa Produtos"
        '
        'FormPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(604, 203)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbPesquisaEntr)
        Me.Controls.Add(Me.dgEntradProduto)
        Me.Controls.Add(Me.txtPesquisaProdEntr)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                             Pesq" &
    "uisa"
        Me.TopMost = True
        CType(Me.dgEntradProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPesquisaEntr As ComboBox
    Friend WithEvents dgEntradProduto As DataGridView
    Friend WithEvents txtPesquisaProdEntr As TextBox
    Friend WithEvents Label1 As Label
End Class
