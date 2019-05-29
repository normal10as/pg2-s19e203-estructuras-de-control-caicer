Imports System

Module Program
    Sub Main(args As String())
        Dim NumUno, NumDos, NumTres, menor As Int16
        Console.WriteLine("ingrese un numero")
        NumUno = Console.ReadLine()
        Console.WriteLine("ingrese otro valor")
        NumDos = Console.ReadLine()
        Console.WriteLine("ingrese otro numero")
        NumTres = Console.ReadLine()
        If NumDos < NumUno Then
            menor = NumDos
        Else
            menor = NumUno
        End If
        If NumTres < menor Then
            menor = NumTres
        End If
        Console.WriteLine("el menor es: " & menor)
    End Sub
End Module
