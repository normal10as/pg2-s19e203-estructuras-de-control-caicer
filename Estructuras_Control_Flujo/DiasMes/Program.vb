Imports System.DateTime

Module Program
    Enum meses
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum
    Sub Main(args As String())
        Dim NumMes As Byte
        Console.WriteLine("Ingrese el numero del mes")
        NumMes = Console.ReadLine()
        Select Case NumMes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("El mes tiene 31 dias")
            Case 4, 6, 9, 11
                Console.WriteLine("El mes tiene 30 dias")
            Case 2
                If Now.Year Mod 4 = 0 And Now.Year Mod 100.0! = 0 Or Now.Year Mod 400 = 0 Then
                    Console.WriteLine("El mes tiene 29 dias")
                Else
                    Console.WriteLine("El mes tiene 28 dias")
                End If
        End Select
    End Sub
End Module
