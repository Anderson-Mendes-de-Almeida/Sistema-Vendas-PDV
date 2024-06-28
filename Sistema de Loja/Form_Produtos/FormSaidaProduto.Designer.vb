<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaidaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSaidaProduto))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEm_Estoque = New System.Windows.Forms.TextBox()
        Me.cbPesquisaEntr = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalvarEntradaProd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgSaidaProduto = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPesquisaProdSai = New System.Windows.Forms.TextBox()
        Me.txtSaidaProduto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustoUnitario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustoTotalSaid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgSaidaProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtEm_Estoque
        '
        resources.ApplyResources(Me.txtEm_Estoque, "txtEm_Estoque")
        Me.txtEm_Estoque.ForeColor = System.Drawing.Color.Red
        Me.txtEm_Estoque.Name = "txtEm_Estoque"
        Me.txtEm_Estoque.ReadOnly = True
        '
        'cbPesquisaEntr
        '
        resources.ApplyResources(Me.cbPesquisaEntr, "cbPesquisaEntr")
        Me.cbPesquisaEntr.FormattingEnabled = True
        Me.cbPesquisaEntr.Items.AddRange(New Object() {resources.GetString("cbPesquisaEntr.Items"), resources.GetString("cbPesquisaEntr.Items1")})
        Me.cbPesquisaEntr.Name = "cbPesquisaEntr"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSalvarEntradaProd
        '
        resources.ApplyResources(Me.btnSalvarEntradaProd, "btnSalvarEntradaProd")
        Me.btnSalvarEntradaProd.Name = "btnSalvarEntradaProd"
        Me.btnSalvarEntradaProd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'dgSaidaProduto
        '
        Me.dgSaidaProduto.AllowUserToAddRows = False
        Me.dgSaidaProduto.AllowUserToDeleteRows = False
        Me.dgSaidaProduto.AllowUserToResizeRows = False
        resources.ApplyResources(Me.dgSaidaProduto, "dgSaidaProduto")
        Me.dgSaidaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSaidaProduto.MultiSelect = False
        Me.dgSaidaProduto.Name = "dgSaidaProduto"
        Me.dgSaidaProduto.ReadOnly = True
        Me.dgSaidaProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtPesquisaProdSai
        '
        resources.ApplyResources(Me.txtPesquisaProdSai, "txtPesquisaProdSai")
        Me.txtPesquisaProdSai.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPesquisaProdSai.Name = "txtPesquisaProdSai"
        '
        'txtSaidaProduto
        '
        resources.ApplyResources(Me.txtSaidaProduto, "txtSaidaProduto")
        Me.txtSaidaProduto.ForeColor = System.Drawing.Color.Red
        Me.txtSaidaProduto.Name = "txtSaidaProduto"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtCustoUnitario
        '
        resources.ApplyResources(Me.txtCustoUnitario, "txtCustoUnitario")
        Me.txtCustoUnitario.Name = "txtCustoUnitario"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Name = "Label8"
        '
        'txtCustoTotalSaid
        '
        resources.ApplyResources(Me.txtCustoTotalSaid, "txtCustoTotalSaid")
        Me.txtCustoTotalSaid.Name = "txtCustoTotalSaid"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Name = "Label9"
        '
        'FormSaidaProduto
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtCustoTotalSaid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCustoUnitario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaidaProduto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEm_Estoque)
        Me.Controls.Add(Me.cbPesquisaEntr)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalvarEntradaProd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgSaidaProduto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPesquisaProdSai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSaidaProduto"
        Me.TopMost = True
        CType(Me.dgSaidaProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEm_Estoque As TextBox
    Friend WithEvents cbPesquisaEntr As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSalvarEntradaProd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dgSaidaProduto As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPesquisaProdSai As TextBox
    Friend WithEvents txtSaidaProduto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustoUnitario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustoTotalSaid As TextBox
    Friend WithEvents Label9 As Label
End Class
