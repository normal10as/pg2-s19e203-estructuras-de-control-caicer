Imports System

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
        Dim Mes As Byte
        Console.WriteLine("Ingrese el Numero del mes")
        Mes = Console.ReadLine()
        Select Case Mes
            Case 1
                Console.WriteLine("El mes es {0}", meses.Enero)
            Case 2
                Console.WriteLine("El mes es {0}", meses.Febrero)
            Case 3
                Console.WriteLine("El mes es {0}", meses.Marzo)
            Case 4
                Console.WriteLine("El mes es {0}", meses.Abril)
            Case 5
                Console.WriteLine("El mes es {0}", meses.Mayo)
            Case 6
                Console.WriteLine("El mes es {0}", meses.Junio)
            Case 7
                Console.WriteLine("El mes es {0}", meses.Julio)
            Case 8
                Console.WriteLine("El mes es {0}", meses.Agosto)
            Case 9
                Console.WriteLine("El mes es {0}", meses.Septiembre)
            Case 10
                Console.WriteLine("El mes es {0}", meses.Noviembre)
            Case 11
                Console.WriteLine("El mes es {0}", meses.Octubre)
            Case 12
                Console.WriteLine("El mes es {0}", meses.Diciembre)
            Case Else
                Console.WriteLine("No es ningun mes")
        End Select

    End Sub
End Module
