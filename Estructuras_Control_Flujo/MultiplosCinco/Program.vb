Imports System

Module Program
    Sub Main(args As String())
        Dim contador As Int16 = 0
        Dim inicio, final As Int16
        Console.WriteLine("Ingresar el numero menor")
        inicio = Console.ReadLine()
        Console.WriteLine("Ingrese el numero mayor")
        final = Console.ReadLine()
        Console.WriteLine("CON FOR")
        For i As Int16 = inicio To final Step 1
            If i Mod 5 = 0 Then
                Console.WriteLine("es multiplo de 5: " & i)
            End If
        Next
        Console.WriteLine("CON DO UNTIL")
        contador = inicio
        Do Until contador > final
            If contador Mod 5 = 0 Then
                Console.WriteLine("es multiplo de 5: " & contador)
            End If
            contador += 1
        Loop
        Console.WriteLine("CON LOOP UNTIL")
        contador = inicio
        Do
            If contador Mod 5 = 0 Then
                Console.WriteLine("es multiplo de 5: " & contador)
            End If
            contador += 1
        Loop Until contador > final
        Console.WriteLine("CON LOOP WHILE")
        contador = inicio
        Do
            If contador Mod 5 = 0 Then
                Console.WriteLine("es multiplo de 5: " & contador)
            End If
            contador += 1
        Loop While contador < final
        Console.WriteLine("CON DO WHILE")
        contador = inicio
        Do While contador < final
            If contador Mod 5 = 0 Then
                Console.WriteLine("es multiplo de 5: " & contador)
            End If
            contador += 1
        Loop
    End Sub

End Module
