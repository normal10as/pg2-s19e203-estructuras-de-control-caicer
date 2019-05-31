Imports System

Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim monto, descuento, total As Decimal

        Console.WriteLine("ingresar el precio de los articulos: ")
        monto = Console.ReadLine()
        Console.WriteLine("ingresar la cantidad de articulos: ")
        cantidad = Console.ReadLine()
        Select Case cantidad
            Case 9 To 50
                descuento = cantidad * monto * 0.05
            Case 51 To 250
                descuento = cantidad * monto * 0.1
            Case Is >= 251
                descuento = cantidad * monto * 0.2
        End Select
        total = cantidad * monto - descuento
        Console.WriteLine("el sub total es: " & cantidad * monto)
        Console.WriteLine("el descuento es: " & descuento)
        Console.WriteLine("el total es: " & total)
    End Sub
End Module
