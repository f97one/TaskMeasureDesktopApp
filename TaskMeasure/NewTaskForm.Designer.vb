<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewTaskForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTaskForm))
        Me.MeasureNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TaskNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EstimatedTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.TaskCountUpTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ElaspedTimeLabel = New System.Windows.Forms.Label()
        Me.PauseBtn = New System.Windows.Forms.Button()
        Me.DoneBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MeasureNotifyIcon
        '
        Me.MeasureNotifyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MeasureNotifyIcon.Icon = CType(resources.GetObject("MeasureNotifyIcon.Icon"), System.Drawing.Icon)
        Me.MeasureNotifyIcon.Text = "TaskMeasure"
        Me.MeasureNotifyIcon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 8, 3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Task Name"
        '
        'TaskNameTextBox
        '
        Me.TaskNameTextBox.Location = New System.Drawing.Point(148, 14)
        Me.TaskNameTextBox.MaxLength = 32
        Me.TaskNameTextBox.Name = "TaskNameTextBox"
        Me.TaskNameTextBox.Size = New System.Drawing.Size(188, 19)
        Me.TaskNameTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 8, 3, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estimated end time"
        '
        'EstimatedTimePicker1
        '
        Me.EstimatedTimePicker1.CustomFormat = "HH:mm"
        Me.EstimatedTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EstimatedTimePicker1.Location = New System.Drawing.Point(148, 40)
        Me.EstimatedTimePicker1.Name = "EstimatedTimePicker1"
        Me.EstimatedTimePicker1.ShowUpDown = True
        Me.EstimatedTimePicker1.Size = New System.Drawing.Size(87, 19)
        Me.EstimatedTimePicker1.TabIndex = 4
        '
        'StartBtn
        '
        Me.StartBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartBtn.Location = New System.Drawing.Point(305, 99)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 5
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'TaskCountUpTimer1
        '
        Me.TaskCountUpTimer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 8, 3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Elasped :"
        '
        'ElaspedTimeLabel
        '
        Me.ElaspedTimeLabel.AutoSize = True
        Me.ElaspedTimeLabel.Location = New System.Drawing.Point(146, 73)
        Me.ElaspedTimeLabel.Margin = New System.Windows.Forms.Padding(8, 8, 3, 8)
        Me.ElaspedTimeLabel.Name = "ElaspedTimeLabel"
        Me.ElaspedTimeLabel.Size = New System.Drawing.Size(31, 12)
        Me.ElaspedTimeLabel.TabIndex = 2
        Me.ElaspedTimeLabel.Text = "00:00"
        '
        'PauseBtn
        '
        Me.PauseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PauseBtn.Location = New System.Drawing.Point(19, 99)
        Me.PauseBtn.Name = "PauseBtn"
        Me.PauseBtn.Size = New System.Drawing.Size(49, 23)
        Me.PauseBtn.TabIndex = 5
        Me.PauseBtn.Text = "Pause"
        Me.PauseBtn.UseVisualStyleBackColor = True
        '
        'DoneBtn
        '
        Me.DoneBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DoneBtn.Location = New System.Drawing.Point(224, 99)
        Me.DoneBtn.Name = "DoneBtn"
        Me.DoneBtn.Size = New System.Drawing.Size(75, 23)
        Me.DoneBtn.TabIndex = 5
        Me.DoneBtn.Text = "Done"
        Me.DoneBtn.UseVisualStyleBackColor = True
        '
        'NewTaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 134)
        Me.Controls.Add(Me.PauseBtn)
        Me.Controls.Add(Me.DoneBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.EstimatedTimePicker1)
        Me.Controls.Add(Me.TaskNameTextBox)
        Me.Controls.Add(Me.ElaspedTimeLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "NewTaskForm"
        Me.ShowInTaskbar = False
        Me.Text = "Measure Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MeasureNotifyIcon As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents TaskNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EstimatedTimePicker1 As DateTimePicker
    Friend WithEvents StartBtn As Button
    Friend WithEvents TaskCountUpTimer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ElaspedTimeLabel As Label
    Friend WithEvents PauseBtn As Button
    Friend WithEvents DoneBtn As Button
End Class
