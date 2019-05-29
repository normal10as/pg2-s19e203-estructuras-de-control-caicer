Imports System

Module Program
    Sub Main(args As String())
        Dim numuno, numdos As Int16
        Console.WriteLine("ingresar un numero")
        numuno = Console.ReadLine()
        Console.WriteLine("ingresar un numero")
        numdos = Console.ReadLine()
        If numuno > numdos Then
            Console.WriteLine("el numero {0} es mayor que {1}", numuno, numdos)
        ElseIf numuno = numdos Then
            Console.WriteLine("el numero {0} es igual que {1}", numuno, numdos)
        Else
            Console.WriteLine("el numero {0} es menor que {1}", numuno, numdos)
        End If
    End Sub
End Module
