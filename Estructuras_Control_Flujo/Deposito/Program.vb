Imports System

Module Program
    Const Interes As Byte = 47
    Sub Main()
        Dim monto, capital, totalcap As Decimal
        Dim totalInteres As Decimal = 0, totalanualinteres As Decimal = 0
        Console.WriteLine("Ingrese el munto a capitaliza")
        monto = Console.ReadLine()
        For i As Byte = 1 To 12 Step 1
            totalInteres = (monto * (Interes / 100) / 12)
            totalanualinteres += totalInteres
            capital = monto + totalInteres

            Console.WriteLine("En el mes " & i & " el capital " & monto & " genero " & totalInteres & " de interes " & " dejo " & capital)
            monto = capital
        Next
        Console.WriteLine("El interes acumulado fue de: " & totalanualinteres)
    End Sub
End Module
