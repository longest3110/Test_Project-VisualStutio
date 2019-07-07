Imports System.Data

Class MainWindow

	Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
		Dim dt As New DataTable
		Dim row As DataRow

		dt.Columns.Add("id")
		dt.Columns.Add("Text")
		dt.Columns.Add("ImagePath")

		row = dt.NewRow
		row("id") = "あ"
		row("Text") = "さいとう"
		row("ImagePath") = getImagePath(ImageType.ハサミ)
		dt.Rows.Add(row)


		listBox.DataContext = dt
		listBox.SelectedValuePath = "id"
		datagrid.DataContext = dt
	End Sub

	Private Sub listBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles listBox.SelectionChanged
		MsgBox(listBox.SelectedValue)
	End Sub

	Private Function getImagePath(ByVal type As ImageType) As String
		Select Case type
			Case ImageType.ハサミ
				Return ".\Images\ハサミのフリーアイコン.png"
			Case ImageType.バット
				Return ".\Images\バットのアイコン素材.png"
			Case ImageType.温泉宿
				Return ".\Images\温泉宿の暖簾アイコン.png"
			Case ImageType.夜空
				Return ".\Images\夜空のフリーアイコン.png"
		End Select

		Return ""
	End Function

End Class

Public Enum ImageType
	ハサミ = 0
	バット = 1
	温泉宿 = 2
	夜空 = 3
	None = 4
End Enum
