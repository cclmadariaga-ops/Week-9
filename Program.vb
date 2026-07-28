Option Strict On
'Pathway A Code Explanation' 

'' For Pathway A, I created a console menu program called Midnight Mixx. I changed the original choices from the starter code And made them match my own music theme.
'' The array In my program Is called storyChoices(). It stores all Of the menu choices that the user can pick from. Using an array makes it easier To keep multiple choices together instead of making a separate variable For Each one.
'' The For...Next loop Is used to show the choices from the array. It goes through each item And displays the menu options with a number next to them.
'' The Do While loop keeps the program running. The menu will continue to appear until the user chooses 0 to exit the program.
'' The For Each loop Is used when showing the user's history at the end. It goes through each choice the user selected and displays it.
'' This project helped Me understand how arrays And loops work together In Visual Basic. I learned how loops can repeat actions And how arrays can store information that the program can use.


Module Week9LoopsAndArrays

    Sub Main()
        Dim storyChoices() As String = {
            "Create a Dreamscape Playlist",
            "Add songs to Chill Mode",
            "Explore the Energy music world",
            "Customize your album artwork"
        }

        Dim keepPlaying As Boolean = True
        Dim chosenHistory As New List(Of String)

        Do While keepPlaying
            Console.Clear()
            Console.WriteLine("Midnight Mixx Menu")
            Console.WriteLine("----------------")

            ' For...Next is useful when you need the array index.
            For index As Integer = 0 To storyChoices.Length - 1
                Console.WriteLine($"{index + 1}. {storyChoices(index)}")
            Next

            Console.WriteLine("0. Exit")
            Console.WriteLine()
            Console.Write("Choose an option: ")

            Dim userInput As String = Console.ReadLine()
            Dim choiceNumber As Integer

            If Integer.TryParse(userInput, choiceNumber) Then
                If choiceNumber = 0 Then
                    keepPlaying = False
                ElseIf choiceNumber >= 1 AndAlso choiceNumber <= storyChoices.Length Then
                    Dim selectedChoice As String = storyChoices(choiceNumber - 1)
                    chosenHistory.Add(selectedChoice)

                    Console.WriteLine()
                    Console.WriteLine($"You chose: {selectedChoice}")
                    Console.WriteLine("Press ENTER to return to the menu.")
                    Console.ReadLine()
                Else
                    ShowInputError()
                End If
            Else
                ShowInputError()
            End If
        Loop

        ShowHistory(chosenHistory)
    End Sub

    Sub ShowInputError()
        Console.WriteLine()
        Console.WriteLine("That choice is not valid. Press ENTER and try again.")
        Console.ReadLine()
    End Sub

    Sub ShowHistory(history As List(Of String))
        Console.Clear()
        Console.WriteLine("Session Recap")
        Console.WriteLine("-------------")

        If history.Count = 0 Then
            Console.WriteLine("No choices were selected.")
        Else
            ' For Each is useful when you need each item and do not need the index.
            For Each item As String In history
                Console.WriteLine($"- {item}")
            Next
        End If

        Console.WriteLine()
        Console.WriteLine("Press ENTER to close.")
        Console.ReadLine()
    End Sub

End Module
