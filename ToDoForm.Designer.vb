<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToDo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToDo))
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.DataGrid_ToDo = New System.Windows.Forms.DataGridView()
        Me.ToDoListBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGrid_ToDo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Calendar
        '
        resources.ApplyResources(Me.Calendar, "Calendar")
        Me.Calendar.MaxSelectionCount = 1
        Me.Calendar.Name = "Calendar"
        '
        'DataGrid_ToDo
        '
        Me.DataGrid_ToDo.AllowUserToAddRows = False
        Me.DataGrid_ToDo.AllowUserToDeleteRows = False
        Me.DataGrid_ToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_ToDo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.DataGrid_ToDo, "DataGrid_ToDo")
        Me.DataGrid_ToDo.Name = "DataGrid_ToDo"
        Me.DataGrid_ToDo.ReadOnly = True
        Me.DataGrid_ToDo.RowTemplate.Height = 21
        '
        'ToDoListBox
        '
        resources.ApplyResources(Me.ToDoListBox, "ToDoListBox")
        Me.ToDoListBox.Name = "ToDoListBox"
        Me.ToDoListBox.ReadOnly = True
        Me.ToDoListBox.ShortcutsEnabled = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ToDo
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToDoListBox)
        Me.Controls.Add(Me.DataGrid_ToDo)
        Me.Controls.Add(Me.Calendar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ToDo"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.DataGrid_ToDo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calendar As MonthCalendar
    Friend WithEvents DataGrid_ToDo As DataGridView
    Friend WithEvents ToDoListBox As TextBox
    Friend WithEvents Label1 As Label
End Class
