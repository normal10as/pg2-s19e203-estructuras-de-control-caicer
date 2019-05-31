Imports System

Module Program
    Enum posi
        Primero = 1
        Segundo
        Tercero
        Cuarto
        Quinto
    End Enum
    Sub Main(args As String())
        Dim numuno, numdos, numtres, numcuatro, numcinco, mayor, posicion As Int16
        Console.WriteLine("ingrese un numero")
        numuno = Console.ReadLine()
        Console.WriteLine("ingrese un numero")
        numdos = Console.ReadLine()
        If numuno > numdos Then
            mayor = numuno
            posicion = 1
        Else
            mayor = numdos
            posicion = 2
        End If
        Console.WriteLine("ingrese un numero")
        numtres = Console.ReadLine()
        If numtres > mayor Then
            mayor = numtres
            posicion = 3
        End If
        Console.WriteLine("ingrese un numero")
        numcuatro = Console.ReadLine()
        If numcuatro > mayor Then
            mayor = numcuatro
            posicion = 4
        End If
        Console.WriteLine("ingrese un numero")
        numcinco = Console.ReadLine()
        If numcinco > mayor Then
            mayor = numcinco
            posicion = 5
        End If
        Console.WriteLine("el mayor de los cinco numero es {0} y estaba en la posicion {1}", mayor, posicion)
    End Sub
End Module
