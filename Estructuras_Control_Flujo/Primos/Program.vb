Imports System

Module Program
    Sub Main(args As String())
        Dim cont As UInt16
        For i As Integer = 1 To 1000 Step 1
            For j As UInt16 = 1 To i - 1 Step 1

                If (i Mod j = 0) Then
                    cont += 1

                End If
            Next
            If cont <= 2 Then
                Console.WriteLine(i & " es primo")
            End If
            cont = 0
        Next
    End Sub
End Module
