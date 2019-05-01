<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueMeasureForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TicketNameLabel = New System.Windows.Forms.Label()
        Me.EstimatedHoursLabel = New System.Windows.Forms.Label()
        Me.ElapsedHoursLabel = New System.Windows.Forms.Label()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.ElapsedTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "チケット名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 4, 8, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "予定工数"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 4, 8, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "経過時間"
        '
        'TicketNameLabel
        '
        Me.TicketNameLabel.AutoSize = True
        Me.TicketNameLabel.Location = New System.Drawing.Point(76, 9)
        Me.TicketNameLabel.Margin = New System.Windows.Forms.Padding(3, 0, 8, 4)
        Me.TicketNameLabel.Name = "TicketNameLabel"
        Me.TicketNameLabel.Size = New System.Drawing.Size(79, 12)
        Me.TicketNameLabel.TabIndex = 0
        Me.TicketNameLabel.Text = "hogeをfugaする"
        '
        'EstimatedHoursLabel
        '
        Me.EstimatedHoursLabel.AutoSize = True
        Me.EstimatedHoursLabel.Location = New System.Drawing.Point(76, 29)
        Me.EstimatedHoursLabel.Margin = New System.Windows.Forms.Padding(3, 4, 8, 4)
        Me.EstimatedHoursLabel.Name = "EstimatedHoursLabel"
        Me.EstimatedHoursLabel.Size = New System.Drawing.Size(133, 12)
        Me.EstimatedHoursLabel.TabIndex = 1
        Me.EstimatedHoursLabel.Text = "9999.5 H (9999時間30分)"
        '
        'ElapsedHoursLabel
        '
        Me.ElapsedHoursLabel.AutoSize = True
        Me.ElapsedHoursLabel.Location = New System.Drawing.Point(76, 49)
        Me.ElapsedHoursLabel.Margin = New System.Windows.Forms.Padding(3, 4, 8, 4)
        Me.ElapsedHoursLabel.Name = "ElapsedHoursLabel"
        Me.ElapsedHoursLabel.Size = New System.Drawing.Size(133, 12)
        Me.ElapsedHoursLabel.TabIndex = 1
        Me.ElapsedHoursLabel.Text = "9999.5 H (9999時間30分)"
        '
        'PauseButton
        '
        Me.PauseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PauseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PauseButton.Enabled = False
        Me.PauseButton.Location = New System.Drawing.Point(12, 82)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(75, 23)
        Me.PauseButton.TabIndex = 2
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'StartStopButton
        '
        Me.StartStopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartStopButton.Location = New System.Drawing.Point(171, 82)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(75, 23)
        Me.StartStopButton.TabIndex = 3
        Me.StartStopButton.Text = "Start"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'ElapsedTimer1
        '
        '
        'IssueMeasureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.PauseButton
        Me.ClientSize = New System.Drawing.Size(258, 117)
        Me.Controls.Add(Me.StartStopButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.ElapsedHoursLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EstimatedHoursLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TicketNameLabel)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "IssueMeasureForm"
        Me.Text = "Measuring Issue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TicketNameLabel As Label
    Friend WithEvents EstimatedHoursLabel As Label
    Friend WithEvents ElapsedHoursLabel As Label
    Friend WithEvents PauseButton As Button
    Friend WithEvents StartStopButton As Button
    Friend WithEvents ElapsedTimer1 As Timer
End Class
