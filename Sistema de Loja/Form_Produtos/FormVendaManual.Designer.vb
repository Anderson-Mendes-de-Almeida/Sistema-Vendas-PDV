<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVendaManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVendaManual))
        Me.LtTelaVenda = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPesqCodBarras = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelarVend = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.rbCartao = New System.Windows.Forms.RadioButton()
        Me.rbDinheiro = New System.Windows.Forms.RadioButton()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.txtTroco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDinheiro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LtTelaVenda
        '
        Me.LtTelaVenda.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LtTelaVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LtTelaVenda.FullRowSelect = True
        Me.LtTelaVenda.GridLines = True
        Me.LtTelaVenda.Location = New System.Drawing.Point(12, 84)
        Me.LtTelaVenda.Name = "LtTelaVenda"
        Me.LtTelaVenda.Size = New System.Drawing.Size(472, 251)
        Me.LtTelaVenda.TabIndex = 24
        Me.LtTelaVenda.UseCompatibleStateImageBehavior = False
        Me.LtTelaVenda.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CÓDIGO BARRAS"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PRODUTO"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PREÇO"
        Me.ColumnHeader3.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Lista de Produtos"
        '
        'txtPesqCodBarras
        '
        Me.txtPesqCodBarras.Location = New System.Drawing.Point(15, 33)
        Me.txtPesqCodBarras.MaxLength = 13
        Me.txtPesqCodBarras.Name = "txtPesqCodBarras"
        Me.txtPesqCodBarras.Size = New System.Drawing.Size(368, 21)
        Me.txtPesqCodBarras.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Pesquisa por Código de Barras"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(12, 368)
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(472, 45)
        Me.txtObservacao.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Observação:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtTroco)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDinheiro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTotalPagar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(490, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 398)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelarVend)
        Me.GroupBox2.Controls.Add(Me.btnFinalizar)
        Me.GroupBox2.Controls.Add(Me.rbCartao)
        Me.GroupBox2.Controls.Add(Me.rbDinheiro)
        Me.GroupBox2.Controls.Add(Me.rbCheque)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 99)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'btnCancelarVend
        '
        Me.btnCancelarVend.Location = New System.Drawing.Point(109, 56)
        Me.btnCancelarVend.Name = "btnCancelarVend"
        Me.btnCancelarVend.Size = New System.Drawing.Size(91, 43)
        Me.btnCancelarVend.TabIndex = 38
        Me.btnCancelarVend.Text = "Cancelar Venda"
        Me.btnCancelarVend.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(12, 56)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(91, 43)
        Me.btnFinalizar.TabIndex = 37
        Me.btnFinalizar.Text = "Finalizar Venda"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'rbCartao
        '
        Me.rbCartao.AutoSize = True
        Me.rbCartao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCartao.Location = New System.Drawing.Point(76, 20)
        Me.rbCartao.Name = "rbCartao"
        Me.rbCartao.Size = New System.Drawing.Size(61, 19)
        Me.rbCartao.TabIndex = 35
        Me.rbCartao.Text = "Cartão"
        Me.rbCartao.UseVisualStyleBackColor = True
        '
        'rbDinheiro
        '
        Me.rbDinheiro.AutoSize = True
        Me.rbDinheiro.Checked = True
        Me.rbDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDinheiro.Location = New System.Drawing.Point(6, 20)
        Me.rbDinheiro.Name = "rbDinheiro"
        Me.rbDinheiro.Size = New System.Drawing.Size(72, 19)
        Me.rbDinheiro.TabIndex = 34
        Me.rbDinheiro.TabStop = True
        Me.rbDinheiro.Text = "Dinheiro"
        Me.rbDinheiro.UseVisualStyleBackColor = True
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheque.Location = New System.Drawing.Point(137, 20)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(68, 19)
        Me.rbCheque.TabIndex = 36
        Me.rbCheque.Text = "Cheque"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'txtTroco
        '
        Me.txtTroco.Location = New System.Drawing.Point(6, 228)
        Me.txtTroco.Name = "txtTroco"
        Me.txtTroco.Size = New System.Drawing.Size(210, 21)
        Me.txtTroco.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Troco"
        '
        'txtDinheiro
        '
        Me.txtDinheiro.Location = New System.Drawing.Point(6, 181)
        Me.txtDinheiro.Name = "txtDinheiro"
        Me.txtDinheiro.Size = New System.Drawing.Size(210, 21)
        Me.txtDinheiro.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Dinheiro"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(6, 132)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(210, 21)
        Me.txtTotalPagar.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total a Pagar"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(6, 86)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(210, 21)
        Me.txtDescricao.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Descrição Produtos"
        '
        'FormVendaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(719, 423)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPesqCodBarras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LtTelaVenda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormVendaManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "       Venda Manual"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LtTelaVenda As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPesqCodBarras As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDinheiro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTroco As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancelarVend As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents rbCartao As RadioButton
    Friend WithEvents rbDinheiro As RadioButton
    Friend WithEvents rbCheque As RadioButton
End Class
