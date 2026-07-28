Class MainWindow


    Private Sub btnLoop_Click(sender As Object, e As RoutedEventArgs) Handles btnLoop.Click

        '' For loop
        'For intCount = 1 To 5
        '    txtData.Text += intCount.ToString() + vbCrLf
        'For intCount2 = 0 To 20
        '    lstData.Items.Add("This is an Item " & intCount2.ToString() & " Finally!")
        'List folders in root dir
        'For Each strFolder As String In
        '        System.IO.Directory.GetDirectories("C:\")
        '    'Add these items to the list
        '    lstData.Items.Add(strFolder)
        '    txtData.Text += strFolder + vbCrLf
        'Next

        txtData.Text = ""
        lstData.Items.Clear()

        Dim index As Integer = 1

        While index <= 10

            txtData.Text += "Table" & index.ToString() & vbCrLf

            index += 1

        End While


    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click

        lstData.Items.Clear()
        txtData.Text = ""

    End Sub


End Class