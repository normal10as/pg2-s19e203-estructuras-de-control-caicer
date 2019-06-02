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
        Dim caso As Byte
        Console.WriteLine("ingresar un numero")
        valor1 = Console.ReadLine()
        Console.WriteLine("ingresar un numero")
        valor2 = Console.ReadLine()
        Console.WriteLine("la operacion")
        caso = Console.ReadLine()
        Console.WriteLine(Opera(caso, valor1, valor2))
        Console.WriteLine("ingresar un numero")
        valor3 = Console.ReadLine()
        Console.WriteLine("la operacion")
        caso = Console.ReadLine()
        Console.WriteLine(Opera(caso, valor1, valor2, valor3))
        Console.WriteLine("ingresar un numero")
        valor4 = Console.ReadLine()
        Console.WriteLine("la operacion")
        caso = Console.ReadLine()
        Console.WriteLine(Opera(caso, valor1, valor2, valor3, valor4))
    End Sub

    Function Opera(caso As Byte, valor1 As Decimal, valor2 As Integer) As Decimal
        Select Case caso
            Case 1
                valor1 = valor1 + valor2
            Case 2
                valor1 = valor1 - valor2
            Case 3
                valor1 = valor1 * valor2
            Case 4
                valor1 = valor1 / valor2

        End Select
        Return valor1
    End Function
    Function Opera(caso As Byte, valor1 As Decimal, valor2 As Integer, valor3 As Integer) As Decimal
        Select Case caso
            Case 1
                valor1 = valor1 + valor2 + valor3
            Case 2
                valor1 = valor1 - valor2 - valor3
            Case 3
                valor1 = valor1 * valor2 * valor3
            Case 4
                valor1 = valor1 / valor2 / valor3

        End Select
        Return valor1
    End Function
    Function Opera(caso As Byte, valor1 As Decimal, valor2 As Integer, valor3 As Integer, valor4 As Integer) As Decimal
        Select Case caso
            Case 1
                valor1 = valor1 + valor2 + valor3 + valor4
            Case 2
                valor1 = valor1 - valor2 - valor3 - valor4
            Case 3
                valor1 = valor1 * valor2 * valor3 * valor4
            Case 4
                valor1 = valor1 / valor2 / valor3 / valor4

        End Select
        Return valor1
    End Function
End Module
