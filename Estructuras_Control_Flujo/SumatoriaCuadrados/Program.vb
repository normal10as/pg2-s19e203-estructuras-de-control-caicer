Imports System

Module Program
    Sub Main(args As String())
        Dim Numero As UInt16
        Dim sumatoria As Decimal
        Do
            Console.WriteLine("ingrese un numero")
            Numero = Console.ReadLine()
        Loop Until Numero > 0
        For i As UInt16 = 1 To Numero Step 1
            sumatoria = suma(sumatoria, i)
        Next
    End Sub

    Private Function suma(ByRef sumatoria As Decimal, i As UShort) As Decimal
        sumatoria += i ^ 2
        Console.WriteLine("la sumatoria en rango " & i & " es: " & sumatoria)
        Return sumatoria
    End Function
End Module
