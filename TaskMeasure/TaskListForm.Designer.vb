<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskListForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RedmineProjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectsEntityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TicketsGrid = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RedmineIssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssuesEntityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectsComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.RedmineProjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectsEntityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedmineIssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.IssuesEntityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "プロジェクト"
        '
        'RedmineProjectBindingSource
        '
        Me.RedmineProjectBindingSource.DataSource = GetType(TaskMeasure.Entities.RedmineProject)
        '
        'ProjectsBindingSource
        '
        Me.ProjectsBindingSource.DataMember = "Projects"
        Me.ProjectsBindingSource.DataSource = Me.ProjectsEntityBindingSource
        '
        'ProjectsEntityBindingSource
        '
        Me.ProjectsEntityBindingSource.DataSource = GetType(TaskMeasure.Entities.ProjectsEntity)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "チケット"
        '
        'TicketsGrid
        '
        Me.TicketsGrid.AllowUserToAddRows = False
        Me.TicketsGrid.AllowUserToDeleteRows = False
        Me.TicketsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TicketsGrid.AutoGenerateColumns = False
        Me.TicketsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn})
        Me.TicketsGrid.DataSource = Me.RedmineIssueBindingSource
        Me.TicketsGrid.Location = New System.Drawing.Point(17, 75)
        Me.TicketsGrid.Name = "TicketsGrid"
        Me.TicketsGrid.ReadOnly = True
        Me.TicketsGrid.RowTemplate.Height = 21
        Me.TicketsGrid.Size = New System.Drawing.Size(502, 222)
        Me.TicketsGrid.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.IdDataGridViewTextBoxColumn.HeaderText = "チケットID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdDataGridViewTextBoxColumn.Width = 74
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SubjectDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "題名"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubjectDataGridViewTextBoxColumn.Width = 5
        '
        'RedmineIssueBindingSource
        '
        Me.RedmineIssueBindingSource.DataSource = GetType(TaskMeasure.Entities.RedmineIssue)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem, Me.ToolStripMenuItem1, Me.CloseAppToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SettingToolStripMenuItem.Text = "設定(&S)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 6)
        '
        'CloseAppToolStripMenuItem
        '
        Me.CloseAppToolStripMenuItem.Name = "CloseAppToolStripMenuItem"
        Me.CloseAppToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CloseAppToolStripMenuItem.Text = "終了(&X)"
        '
        'IssuesEntityBindingSource
        '
        Me.IssuesEntityBindingSource.DataSource = GetType(TaskMeasure.Entities.IssuesEntity)
        '
        'ProjectsComboBox
        '
        Me.ProjectsComboBox.DataSource = Me.RedmineProjectBindingSource
        Me.ProjectsComboBox.DisplayMember = "Name"
        Me.ProjectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProjectsComboBox.FormattingEnabled = True
        Me.ProjectsComboBox.Location = New System.Drawing.Point(74, 27)
        Me.ProjectsComboBox.Name = "ProjectsComboBox"
        Me.ProjectsComboBox.Size = New System.Drawing.Size(445, 20)
        Me.ProjectsComboBox.TabIndex = 5
        Me.ProjectsComboBox.ValueMember = "Id"
        '
        'TaskListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 309)
        Me.Controls.Add(Me.ProjectsComboBox)
        Me.Controls.Add(Me.TicketsGrid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TaskListForm"
        Me.Text = "TaskListForm"
        CType(Me.RedmineProjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectsEntityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedmineIssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.IssuesEntityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TicketsGrid As DataGridView
    Friend WithEvents RedmineIssueBindingSource As BindingSource
    Friend WithEvents IssuesEntityBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CloseAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectsBindingSource As BindingSource
    Friend WithEvents ProjectsEntityBindingSource As BindingSource
    Friend WithEvents RedmineProjectBindingSource As BindingSource
    Friend WithEvents ProjectsComboBox As ComboBox
End Class
