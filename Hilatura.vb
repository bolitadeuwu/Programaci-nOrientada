Imports System

Module Program
    Sub Main(args As String())

        Dim Toneladas As Single

        Console.WriteLine("�Cu�ntas toneladas de hilo  se producen en el turno diurno?")
        Toneladas = Console.ReadLine()
        If Toneladas >= 15 Then
            Console.WriteLine("Oh, muy bien, la produccion es buena")
        Else
            Console.WriteLine("Mejoremos la producci�n")
        End If
        Console.WriteLine("�Cu�ntas toneladas de hilo se producen por el turno vespertino?")
        Toneladas = Console.ReadLine()
        If Toneladas >= 13 Then
            Console.WriteLine("La producci�n es muy buena")
        Else
            Console.WriteLine("Mejoremos la producci�n")
        End If
        Console.WriteLine("�Cu�ntas toneladas de hilo se producen por el turno nocturno ")
        Toneladas = Console.ReadLine()
        If Toneladas >= 13 Then
            Console.WriteLine("La producci�n es muy buena")
        Else
            Console.WriteLine("Mejoremos la producci�n")
        End If
    End Sub
End Module


