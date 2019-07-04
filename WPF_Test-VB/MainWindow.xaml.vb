Class MainWindow
	Private Structure ListBoxThumbnail
		Public Property ImagePath As String
		Public Property Text As String
	End Structure

	Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
		Dim temp As ListBoxThumbnail
		Dim datas As New List(Of ListBoxThumbnail)

		temp = New ListBoxThumbnail()
		temp.ImagePath = "C:\Users\longe\Develop\Test_Project-VisualStutio\WPF_Test-VB\Images\ハサミのフリーアイコン.png"
		temp.Text = "ハサミ"
		datas.Add(temp)


		listBox.ItemsSource = datas
	End Sub


End Class
