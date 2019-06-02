Imports System

Module Program
    Sub Main(args As String())
        Dim TotalPares As UInt16 = 0, TotalImpares As UInt16 = 0, Numero As UInt16 = 1
        Do Until (Numero = 0)
            Console.WriteLine("Ingrese un numero. Para salir press 0")
            Numero = Console.ReadLine()
            If Numero = 0 Then
                Exit Do
            ElseIf ((-1) ^ Numero) = 1 Then
                Console.WriteLine("El numero ingresado es Par")
                TotalPares += 1
            Else
                Console.WriteLine("El numero ingresado es Impar")
                TotalImpares += 1
            End If
        Loop
        Console.WriteLine("El total de impares es: " & TotalImpares & " y el total de pares es: " & TotalPares)
    End Sub
End Module
