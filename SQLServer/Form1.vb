Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'TESTDataSet.person' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.PersonTableAdapter.Fill(Me.TESTDataSet.person)

    End Sub
End Class
