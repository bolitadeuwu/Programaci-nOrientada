Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer
        Dim yes As String
        Dim respuesta As String
        x = 0
        Do While x <= 1000
            Console.Write(x)
            Console.Write(" - ")
            x = x + 20
        Loop
        Console.ReadKey()

        Console.WriteLine("¿Desea repetir el conteo?, escriba yes")

        respuesta = Console.ReadLine()

        If respuesta = yes Then
            x = 0
            Do While x <= 1000
                Console.Write(x)
                Console.Write(" - ")
                x = x + 20
            Loop
        Else
            Console.WriteLine("El programa no se repite")
        End If

    End Sub
End Module
