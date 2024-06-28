<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEstorno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstorno))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgEstorno1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtQtdProdutos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtValorProduto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgEstorno1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Lista de Produtos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Quantidade de produtos"
        '
        'dgEstorno1
        '
        Me.dgEstorno1.AllowUserToAddRows = False
        Me.dgEstorno1.AllowUserToDeleteRows = False
        Me.dgEstorno1.AllowUserToResizeRows = False
        Me.dgEstorno1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstorno1.Location = New System.Drawing.Point(12, 81)
        Me.dgEstorno1.MultiSelect = False
        Me.dgEstorno1.Name = "dgEstorno1"
        Me.dgEstorno1.ReadOnly = True
        Me.dgEstorno1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstorno1.Size = New System.Drawing.Size(532, 169)
        Me.dgEstorno1.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(449, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 53)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Confirmar Estorno de Produtos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtQtdProdutos
        '
        Me.TxtQtdProdutos.Enabled = False
        Me.TxtQtdProdutos.Location = New System.Drawing.Point(13, 26)
        Me.TxtQtdProdutos.Name = "TxtQtdProdutos"
        Me.TxtQtdProdutos.Size = New System.Drawing.Size(100, 21)
        Me.TxtQtdProdutos.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(193, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Valor Produto"
        '
        'TxtValorProduto
        '
        Me.TxtValorProduto.Enabled = False
        Me.TxtValorProduto.Location = New System.Drawing.Point(196, 26)
        Me.TxtValorProduto.Name = "TxtValorProduto"
        Me.TxtValorProduto.Size = New System.Drawing.Size(100, 21)
        Me.TxtValorProduto.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 23)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Clique no produto para abilitar o processo"
        '
        'FormEstorno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(560, 291)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtValorProduto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtQtdProdutos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgEstorno1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEstorno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                     Estorno de P" &
    "roduto"
        Me.TopMost = True
        CType(Me.dgEstorno1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgEstorno1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtQtdProdutos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtValorProduto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
End Class
