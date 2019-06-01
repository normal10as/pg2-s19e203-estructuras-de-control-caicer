Imports System

Module Program

    Sub Main()
        Dim Medida As Byte
        Dim pulgadas, metros, pies, yardas As Single
        Dim centrimetros As UInt32

        Console.WriteLine("ingrese la unidad en la que se encuentra ")
        Console.WriteLine("1-metros 2-centimetros 3-pies 4-yardas 5-pulgadas")
        Medida = Console.ReadLine()

        Select Case Medida
            Case 1
                Console.WriteLine("ingresar la medida ")
                metros = Console.ReadLine()
                Console.WriteLine("en Centimetros es: " & metros * 100)
                Console.WriteLine("en Pies es: " & metros * 100 / 2.54 / 12)
                Console.WriteLine("en Yardas es: " & metros * 100 / 2.54 / 12 / 3)
                Console.WriteLine("en Pulgadas es: " & metros * 100 / 2.54)
            Case 2
                Console.WriteLine("ingresar la medida ")
                metros = Console.ReadLine()
                Console.WriteLine("en Metros es: " & metros / 100)
                Console.WriteLine("en Pies es: " & metros / 2.54 / 12)
                Console.WriteLine("en Yardas es: " & metros / 2.54 / 12 / 3)
                Console.WriteLine("en Pulgadas es: " & metros / 2.54)
            Case 3
                Console.WriteLine("ingresar la medida ")
                metros = Console.ReadLine()
                Console.WriteLine("en Centimetros es: " & metros * 12 * 2.54)
                Console.WriteLine("en metros es: " & metros / 100 * 2.54 * 12)
                Console.WriteLine("en Yardas es: " & metros / 3)
                Console.WriteLine("en Pulgadas es: " & metros * 12)
            Case 4
                Console.WriteLine("ingresar la medida ")
                metros = Console.ReadLine()
                Console.WriteLine("en Centimetros es: " & metros * 2.54 * 12 * 3)
                Console.WriteLine("en metros es: " & metros / 100 * 2.54 * 12 * 3)
                Console.WriteLine("en Pies es: " & metros * 3)
                Console.WriteLine("en Pulgadas es: " & metros * 12 * 3)
            Case 5
                Console.WriteLine("ingresar la medida ")
                metros = Console.ReadLine()
                Console.WriteLine("en Centimetros es: " & metros * 2.54)
                Console.WriteLine("en metros es: " & metros / 100 * 2.54)
                Console.WriteLine("en Pies es: " & metros / 12)
                Console.WriteLine("en Yadas es: " & metros / 12 / 3)
        End Select
    End Sub
End Module
