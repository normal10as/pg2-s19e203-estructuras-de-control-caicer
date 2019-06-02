Imports System

Module Program
    Sub Main(args As String())
        Dim Valor1 As UInt16 = 0, Valor2 As UInt16 = 1, Valor3 As UInt16
        Console.WriteLine(" Comienza: " & Valor1)
        For i As Byte = 0 To 20 Step 1
            Valor3 = Valor1 + Valor2
            Console.WriteLine("siguiente: " & (Valor3))
            Valor1 = Valor2
            Valor2 = Valor3
        Next
    End Sub
End Module
