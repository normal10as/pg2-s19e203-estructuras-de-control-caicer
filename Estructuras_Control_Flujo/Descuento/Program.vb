Imports System

Module Program
    Sub Main(args As String())
        Dim cantidad As Int16
        Dim monto, descuento, total As Decimal
        Dim totalDescuento As Decimal = 0, totalDinero As Decimal = 0
        Do
            Console.WriteLine("ingresar el precio de los articulos: ")
            monto = Console.ReadLine()
            Console.WriteLine("ingresar la cantidad de articulos: ")
            cantidad = Console.ReadLine()
            If cantidad > 9 And cantidad <= 50 Then
                descuento = cantidad * monto * 0.05
                totalDescuento += descuento
            ElseIf cantidad >= 51 And cantidad <= 250 Then
                descuento = cantidad * monto * 0.1
                totalDescuento += descuento
            ElseIf cantidad >= 251 Then
                descuento = cantidad * monto * 0.2
                totalDescuento += descuento
            ElseIf cantidad = 0 Then
                Exit Do
            End If
            total = cantidad * monto - descuento
            totalDinero += total
            Console.WriteLine("el sub total es: " & cantidad * monto)
            Console.WriteLine("el descuento es: " & descuento)
            Console.WriteLine("el total es: " & total)
        Loop Until (Cantidad = 0 And monto = 0)
        Console.WriteLine("La suma de todos los descuentos da: " & totalDescuento)
        Console.WriteLine("La suma de todo el dinero recaudado da: " & totalDinero)
    End Sub
End Module
