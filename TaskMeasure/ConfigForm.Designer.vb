<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UrlTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ApiKeyTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ImmediateMesureCheckBox = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Redmine URL"
        '
        'UrlTextBox
        '
        Me.UrlTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.UrlTextBox.Location = New System.Drawing.Point(94, 10)
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(353, 19)
        Me.UrlTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "API Key"
        '
        'ApiKeyTextBox
        '
        Me.ApiKeyTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ApiKeyTextBox.Location = New System.Drawing.Point(94, 36)
        Me.ApiKeyTextBox.Name = "ApiKeyTextBox"
        Me.ApiKeyTextBox.Size = New System.Drawing.Size(353, 19)
        Me.ApiKeyTextBox.TabIndex = 3
        '
        'SubmitBtn
        '
        Me.SubmitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubmitBtn.Location = New System.Drawing.Point(398, 91)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(75, 23)
        Me.SubmitBtn.TabIndex = 4
        Me.SubmitBtn.Text = "Submit"
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 117)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(486, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ImmediateMesureCheckBox
        '
        Me.ImmediateMesureCheckBox.AutoSize = True
        Me.ImmediateMesureCheckBox.Location = New System.Drawing.Point(12, 63)
        Me.ImmediateMesureCheckBox.Margin = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.ImmediateMesureCheckBox.Name = "ImmediateMesureCheckBox"
        Me.ImmediateMesureCheckBox.Size = New System.Drawing.Size(252, 16)
        Me.ImmediateMesureCheckBox.TabIndex = 6
        Me.ImmediateMesureCheckBox.Text = "計測コメント入力のEnter押下で計測を開始する"
        Me.ImmediateMesureCheckBox.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 139)
        Me.Controls.Add(Me.ImmediateMesureCheckBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SubmitBtn)
        Me.Controls.Add(Me.ApiKeyTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UrlTextBox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "ConfigForm"
        Me.Text = "Config"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UrlTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ApiKeyTextBox As TextBox
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ImmediateMesureCheckBox As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
