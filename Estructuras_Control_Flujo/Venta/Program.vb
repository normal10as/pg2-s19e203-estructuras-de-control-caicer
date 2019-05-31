Imports System

Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim monto, descuento, total As Decimal

        Console.WriteLine("ingresar el precio de los articulos: ")
        monto = Console.ReadLine()
        Console.WriteLine("ingresar la cantidad de articulos: ")
        cantidad = Console.ReadLine()
        If cantidad > 9 And cantidad <= 50 Then
            descuento = cantidad * monto * 0.05
        ElseIf cantidad >= 51 And cantidad <= 250 Then
            descuento = cantidad * monto * 0.1
        ElseIf cantidad >= 251 Then
            descuento = cantidad * monto * 0.2
        End If
        total = cantidad * monto - descuento
        Console.WriteLine("el sub total es: " & cantidad * monto)
        Console.WriteLine("el descuento es: " & descuento)
        Console.WriteLine("el total es: " & total)
    End Sub
End Module
