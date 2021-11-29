Imports System

Module Program
    Sub Main()
        Dim UCString As String
        Dim CString As String
        Dim count As Integer
        Dim charCount As Integer
        Dim cuChar As Char
        Dim pChar As Char
        Dim checklen As Boolean = False
        Console.WriteLine("input a string")
        UCString = "AAARRRRGGGHH" 'Console.ReadLine
        If Len(UCString) = 1 Then
            checklen = True
            Console.WriteLine("The string is a single character, and as such cannot be compressed further.")
        End If
        If checklen = False Then
            Do
                count = count + 1
                cuChar = UCString(count)
                pChar = UCString(count - 1)
                If cuChar <> pChar Then

                    Console.WriteLine(pChar & charCount + 1)
                    CString = CString & " " & pChar & charCount + 1 & " "
                    charCount = 0
                Else
                    charCount = charCount + 1
                End If
            Loop Until count = Len(UCString)
        End If
        Console.ReadLine(CString)
        Console.ReadKey()

    End Sub
End Module
