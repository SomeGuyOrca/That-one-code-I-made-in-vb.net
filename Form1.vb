Imports System.Linq.Expressions

Public Class Form1
    Private Sub _Click(sender As Object, e As EventArgs) Handles startGame.Click
        Dim guessing_Number As Int64


        Dim number_input As Int64
guessing_Game:
        number_input = InputBox("Enter a number to see if it's correct: ")
        If number_input = guessing_Number Then
            MessageBox.Show("The number you entered is correct!")
        ElseIf number_input <> guessing_Number Then
            MessageBox.Show("The number you entered is wrong!")
            GoTo guessing_Game
        Else
            MessageBox.Show("The value you entered is not compatible")
        End If

    End Sub
End Class
