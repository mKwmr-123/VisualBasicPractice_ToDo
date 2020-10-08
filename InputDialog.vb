Public Class InputDialog
    Private Sub InputDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '日付を表示
        DayLabel.Text = ToDo.todoDay
        DayLabel.ForeColor = Color.White

        '時・分のみ表示
        DateTimeToDo.Format = DateTimePickerFormat.Custom
        DateTimeToDo.CustomFormat = "HH:mm"
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        'キャンセル処理
        Dim res As DialogResult = MessageBox.Show("キャンセルしますか？", "確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If res = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        '登録処理
        If "タスク".Equals(TaskBox.Text) Then
            'タスクが設定されてない場合
            MessageBox.Show("タスクを選択して下さい")
            Exit Sub
        End If

        If memo.TextLength > 50 Then
            '文字数オーバーの場合（1バイト文字も同じ文字数で判定しています）
            MessageBox.Show("メモの文字数がオーバーしています。50文字以下にしてください。")
            Exit Sub
        End If

        Dim res As DialogResult = MessageBox.Show("登録しますか？", "確認",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If res = DialogResult.Yes Then
            '設定された時間、タスク、メモを保持
            ToDo.todoTime = IIf(DateTimeToDo.Value.Hour < 10,
                                "0" + DateTimeToDo.Value.Hour.ToString, DateTimeToDo.Value.Hour.ToString) + ":" +
                            IIf(DateTimeToDo.Value.Minute < 10,
                                "0" + DateTimeToDo.Value.Minute.ToString, DateTimeToDo.Value.Minute.ToString)
            ToDo.todoTask = TaskBox.Text
            ToDo.todoMemo = memo.Text
            Me.Close()
        End If

    End Sub
End Class