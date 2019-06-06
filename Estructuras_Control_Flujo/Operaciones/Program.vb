Imports System

Module Program
    Enum OPERACION
        suma = 1
        resta
        multipli
        division
    End Enum
    Sub Main(args As String())
        Dim valor1, valor2, valor3, valor4 As Integer
        Dim caso As OPERACION
        Console.WriteLine("ingresar un numero")
        valor1 = Console.ReadLine()
        Console.WriteLine("ingresar un numero")
        valor2 = Console.ReadLine()
        Console.WriteLine("la operacion 1-SUMA 2-RESTA 3-MULTIPLICACION 4-DIVISION")
        caso = Console.ReadLine()
        Console.WriteLine(Opera(caso, valor1, valor2))
        Console.WriteLine("ingresar un numero")
        valor3 = Console.ReadLine()
        Console.WriteLine("la operacion 1-SUMA 2-RESTA 3-MULTIPLICACION 4-DIVISION")
        caso = Console.ReadLine()
        Console.WriteLine(Opera(caso, valor1, valor2, valor3))
        Console.WriteLine("ingresar un numero")
        valor4 = Console.ReadLine()
        Console.WriteLine("la operacion 1-SUMA 2-RESTA 3-MULTIPLICACION 4-DIVISION")
        caso = Console.ReadLine()
        Console.WriteLine(Opera(caso, valor1, valor2, valor3, valor4))
    End Sub

    Function Opera(caso As OPERACION, valor1 As Decimal, valor2 As Integer) As Decimal
        Select Case caso
            Case OPERACION.suma
                Return valor1 + valor2
            Case OPERACION.resta
                Return valor1 - valor2
            Case OPERACION.multipli
                Return valor1 * valor2
            Case OPERACION.division
                Return valor1 / valor2
        End Select
    End Function
    Function Opera(caso As OPERACION, valor1 As Decimal, valor2 As Integer, valor3 As Integer) As Decimal
        Return Opera(caso, valor1, Opera(caso, valor2, valor3))
    End Function
    Function Opera(caso As OPERACION, valor1 As Decimal, valor2 As Integer, valor3 As Integer, valor4 As Integer) As Decimal
        Return Opera(caso, Opera(caso, valor1, valor2), Opera(caso, valor3, valor4))
    End Function
End Module
