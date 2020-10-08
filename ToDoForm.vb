Imports System.Data.SqlClient

Public Class ToDo
    'データベースへの接続
    Dim cn As New SqlConnection("Data Source=MASAMICHI-PC\SQLEXPRESS;" _
                                        + "Initial Catalog=ToDo_DataBase;" _
                                        + "Integrated Security=True;" _
                                        + "Pooling=False")

    '全件取得
    Dim adapter As New SqlDataAdapter("SELECT * FROM Table_ToDo", cn)
    Dim table As New DataTable()

    'ToDo設定用項目
    Public todoDay As String
    Public todoTime As String
    Public todoTask As String
    Public todoMemo As String

    Private Sub ToDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '起動時にテーブルを表示
        adapter.Fill(table)
        DataGrid_ToDo.DataSource = table

        For i As Integer = 0 To table.Rows.Count - 1
            If CType(Calendar.TodayDate, Date) = CType(table.Rows.Item(i).Item(0), Date) Then
                '本日の予定を表示
                ToDoListBox.Text = ToDoListBox.Text + table.Rows.Item(i).Item(0) + " " +
                                    table.Rows.Item(i).Item(1) + " " +
                                    table.Rows.Item(i).Item(2) + " " +
                                    table.Rows.Item(i).Item(3) + vbCrLf
            End If
        Next
    End Sub

    Private Sub Calendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateSelected
        'カレンダーから日を選択された場合の処理

        '設定項目の初期化
        todoDay = IIf(e.Start.Year < 10, "0" + e.Start.Year.ToString, e.Start.Year.ToString) +
                  "/" + IIf(e.Start.Month < 10, "0" + e.Start.Month.ToString, e.Start.Month.ToString) +
                  "/" + IIf(e.Start.Day < 10, "0" + e.Start.Day.ToString, e.Start.Day.ToString)
        todoTime = IIf(e.Start.Hour < 10, "0" + e.Start.Hour.ToString, e.Start.Hour.ToString) +
                   ":" + IIf(e.Start.Minute < 10, "0" + e.Start.Minute.ToString, e.Start.Minute.ToString)
        todoTask = ""
        todoMemo = ""

        'ToDoの各項目設定用ダイアログを呼び出す
        Dim setToDo As New InputDialog
        setToDo.ShowDialog()

        If Not String.IsNullOrEmpty(todoTask) Then
            '各項目が設定された後、データベースの更新を行う
            cn.Open()
            adapter.InsertCommand = New SqlCommand("INSERT INTO Table_ToDo VALUES('" +
                                                   todoDay + "','" + todoTime + "','" +
                                                   todoTask + "','" + todoMemo + "')", cn)
            adapter.InsertCommand.ExecuteNonQuery()
            adapter.SelectCommand = New SqlCommand("SELECT * FROM Table_ToDo", cn)
            cn.Close()

            'グリッドビューの更新
            table = New DataTable()
            adapter.Fill(table)
            DataGrid_ToDo.DataSource = table

            If ToDoListBox.TextLength > 0 Then
                '本日の予定をクリア
                ToDoListBox.Clear()
            End If

            For i As Integer = 0 To table.Rows.Count - 1
                If CType(Calendar.TodayDate, Date) = CType(table.Rows.Item(i).Item(0), Date) Then
                    '本日の予定を更新
                    ToDoListBox.Text = ToDoListBox.Text + table.Rows.Item(i).Item(0) + " " +
                                    table.Rows.Item(i).Item(1) + " " +
                                    table.Rows.Item(i).Item(2) + " " +
                                    table.Rows.Item(i).Item(3) + vbCrLf
                End If
            Next
        End If

    End Sub
End Class
