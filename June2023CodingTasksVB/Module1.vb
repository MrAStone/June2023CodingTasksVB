Module Module1
    'https://filestore.aqa.org.uk/sample-papers-and-mark-schemes/2023/june/AQA-85251C-QP-JUN23.PDF
    Sub Main()

    End Sub
    'q4
    Function calculate(width As Integer, lenght As Integer, height As Integer) As Integer
        If height = -1 Then
            Return width * lenght
        Else
            Return width * lenght * height
        End If
    End Function
    Sub q4()
        Dim numOne, numTwo, numThree, answer As Integer
        Console.Write("Enter width: ")
        numOne = Console.ReadLine()
        Console.Write("Enter lenght: ")
        numTwo = Console.ReadLine()
        Console.Write("Enter height, -1 to ignore: ")
        numThree = Console.ReadLine()

        answer = calculate(numOne, numTwo, numThree)
        If numThree = -1 Then
            Console.WriteLine($"Area {answer}")
        Else
            Console.WriteLine($"Volume {answer}")
        End If
    End Sub
    'q4.2 - ammend to make it more robust

    Sub q7()

    End Sub

    Sub q12P2()
        Dim fruits() As String = {"banana", "apple", "orange", "pear", "grape", "pineapple"}


    End Sub
    Sub q13()
        Dim check As Boolean = False
        While check = False
            Dim square As String = ""
            While square.Length <> 2
                Console.Write("Enter grid reference (eg C2): ")
                square = Console.ReadLine()
                square = square.ToUpper()
            End While

            'answer code here

        End While
    End Sub
    Sub q15()

    End Sub
    Sub q16()
        Dim r As Random = New Random()
    End Sub

End Module
