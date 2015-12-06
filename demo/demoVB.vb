Module Module1

    Sub Main()
        Console.Write("Enter the number of multiplication table: ")
        Dim number As Integer = Integer.Parse(Console.ReadLine())

        If number < 1 And number > 12 Then
            Console.Write("The number must be between 1 - 12")
        Else
            For i = 1 To number
                Dim result As Integer = number * i
                Console.WriteLine("{0} x {1} = {2}", number, i, result)
            Next
        End If

        Console.ReadLine()
    End Sub

End Module
