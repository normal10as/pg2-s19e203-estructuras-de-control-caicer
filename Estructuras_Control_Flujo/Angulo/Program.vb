Imports System

Module Program
    Sub Main(args As String())
        Dim Angulo As Int16
        Console.WriteLine("ingrese el angulo")
        Angulo = Console.ReadLine()
        Select Case Angulo
            Case 1 To 90
                Console.WriteLine("Es Agudo")
            Case 90
                Console.WriteLine("Es Recto")
            Case 91 To 179
                Console.WriteLine("Es Obtuso")
            Case 180
                Console.WriteLine("Es Llano")
            Case 181 To 359
                Console.WriteLine("Es concavo")
            Case Else
                Console.WriteLine("Error")
        End Select
    End Sub
End Module
