<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputDialog
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
        Me.DateTimeToDo = New System.Windows.Forms.DateTimePicker()
        Me.memo = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.TaskBox = New System.Windows.Forms.ComboBox()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimeToDo
        '
        Me.DateTimeToDo.CalendarFont = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DateTimeToDo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimeToDo.Location = New System.Drawing.Point(141, 13)
        Me.DateTimeToDo.Name = "DateTimeToDo"
        Me.DateTimeToDo.ShowUpDown = True
        Me.DateTimeToDo.Size = New System.Drawing.Size(87, 19)
        Me.DateTimeToDo.TabIndex = 0
        Me.DateTimeToDo.Value = New Date(2020, 10, 7, 9, 0, 0, 0)
        '
        'memo
        '
        Me.memo.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.memo.Location = New System.Drawing.Point(16, 46)
        Me.memo.Multiline = True
        Me.memo.Name = "memo"
        Me.memo.Size = New System.Drawing.Size(384, 108)
        Me.memo.TabIndex = 2
        Me.memo.Text = "メモ"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(211, 160)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(84, 27)
        Me.addButton.TabIndex = 3
        Me.addButton.Text = "登録"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(325, 160)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(76, 26)
        Me.cancelButton.TabIndex = 4
        Me.cancelButton.Text = "キャンセル"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'TaskBox
        '
        Me.TaskBox.FormattingEnabled = True
        Me.TaskBox.Items.AddRange(New Object() {"重要", "社用", "雑務", "プライベート", "その他"})
        Me.TaskBox.Location = New System.Drawing.Point(234, 12)
        Me.TaskBox.Name = "TaskBox"
        Me.TaskBox.Size = New System.Drawing.Size(166, 20)
        Me.TaskBox.TabIndex = 1
        Me.TaskBox.Text = "タスク"
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DayLabel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.DayLabel.Location = New System.Drawing.Point(13, 13)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(23, 12)
        Me.DayLabel.TabIndex = 5
        Me.DayLabel.Text = "day"
        '
        'InputDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(413, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.DayLabel)
        Me.Controls.Add(Me.TaskBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.memo)
        Me.Controls.Add(Me.DateTimeToDo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimeToDo As DateTimePicker
    Friend WithEvents memo As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents TaskBox As ComboBox
    Friend WithEvents DayLabel As Label
End Class
