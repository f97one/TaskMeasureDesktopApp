<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskMeasureForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskMeasureForm))
        Me.PauseBtn = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StartStopButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimeEntryComboBox = New System.Windows.Forms.ComboBox()
        Me.TimeEntryActivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstimatedHoursLabel = New System.Windows.Forms.Label()
        Me.ElapsedHoursLabel = New System.Windows.Forms.Label()
        Me.TicketNameLabel = New System.Windows.Forms.Label()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.ElapsedTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CommentsToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TimeEntryActivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PauseBtn
        '
        Me.PauseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PauseBtn.Appearance = System.Windows.Forms.Appearance.Button
        Me.PauseBtn.AutoCheck = False
        Me.PauseBtn.AutoSize = True
        Me.PauseBtn.Location = New System.Drawing.Point(13, 217)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(46, 22)
        Me.PauseBtn.TabIndex = 0
        Me.PauseBtn.TabStop = True
        Me.PauseBtn.Text = "Pause"
        Me.PauseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "チケット名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "活動分類"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "経過時間"
        '
        'StartStopButton
        '
        Me.StartStopButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartStopButton.Location = New System.Drawing.Point(208, 216)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(75, 23)
        Me.StartStopButton.TabIndex = 4
        Me.StartStopButton.Text = "Start"
        Me.StartStopButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "コメント"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "見積時間"
        '
        'TimeEntryComboBox
        '
        Me.TimeEntryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TimeEntryActivityBindingSource, "IsDefault", True))
        Me.TimeEntryComboBox.DataSource = Me.TimeEntryActivityBindingSource
        Me.TimeEntryComboBox.DisplayMember = "Name"
        Me.TimeEntryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimeEntryComboBox.FormattingEnabled = True
        Me.TimeEntryComboBox.Location = New System.Drawing.Point(73, 29)
        Me.TimeEntryComboBox.Name = "TimeEntryComboBox"
        Me.TimeEntryComboBox.Size = New System.Drawing.Size(121, 20)
        Me.TimeEntryComboBox.TabIndex = 5
        Me.TimeEntryComboBox.ValueMember = "Id"
        '
        'TimeEntryActivityBindingSource
        '
        Me.TimeEntryActivityBindingSource.DataSource = GetType(TaskMeasure.Entities.TimeEntryActivity)
        '
        'EstimatedHoursLabel
        '
        Me.EstimatedHoursLabel.AutoSize = True
        Me.EstimatedHoursLabel.Location = New System.Drawing.Point(71, 56)
        Me.EstimatedHoursLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.EstimatedHoursLabel.Name = "EstimatedHoursLabel"
        Me.EstimatedHoursLabel.Size = New System.Drawing.Size(133, 12)
        Me.EstimatedHoursLabel.TabIndex = 2
        Me.EstimatedHoursLabel.Text = "9999.5 H (9999時間30分)"
        '
        'ElapsedHoursLabel
        '
        Me.ElapsedHoursLabel.AutoSize = True
        Me.ElapsedHoursLabel.Location = New System.Drawing.Point(71, 72)
        Me.ElapsedHoursLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.ElapsedHoursLabel.Name = "ElapsedHoursLabel"
        Me.ElapsedHoursLabel.Size = New System.Drawing.Size(133, 12)
        Me.ElapsedHoursLabel.TabIndex = 2
        Me.ElapsedHoursLabel.Text = "9999.5 H (9999時間30分)"
        '
        'TicketNameLabel
        '
        Me.TicketNameLabel.AutoSize = True
        Me.TicketNameLabel.Location = New System.Drawing.Point(72, 13)
        Me.TicketNameLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.TicketNameLabel.Name = "TicketNameLabel"
        Me.TicketNameLabel.Size = New System.Drawing.Size(91, 12)
        Me.TicketNameLabel.TabIndex = 2
        Me.TicketNameLabel.Text = "hoge を fuga する"
        '
        'CommentTextBox
        '
        Me.CommentTextBox.CausesValidation = False
        Me.CommentTextBox.Location = New System.Drawing.Point(74, 88)
        Me.CommentTextBox.MaxLength = 255
        Me.CommentTextBox.Multiline = True
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CommentTextBox.Size = New System.Drawing.Size(209, 120)
        Me.CommentTextBox.TabIndex = 6
        '
        'ElapsedTimer1
        '
        '
        'TaskMeasureForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 251)
        Me.Controls.Add(Me.CommentTextBox)
        Me.Controls.Add(Me.TimeEntryComboBox)
        Me.Controls.Add(Me.StartStopButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ElapsedHoursLabel)
        Me.Controls.Add(Me.TicketNameLabel)
        Me.Controls.Add(Me.EstimatedHoursLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PauseBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TaskMeasureForm"
        Me.Text = "Measure Task"
        CType(Me.TimeEntryActivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PauseBtn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents StartStopButton As Button
    Private WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeEntryComboBox As ComboBox
    Friend WithEvents TimeEntryActivityBindingSource As BindingSource
    Friend WithEvents EstimatedHoursLabel As Label
    Friend WithEvents ElapsedHoursLabel As Label
    Friend WithEvents TicketNameLabel As Label
    Friend WithEvents CommentTextBox As TextBox
    Friend WithEvents ElapsedTimer1 As Timer
    Friend WithEvents CommentsToolTip1 As ToolTip
End Class
