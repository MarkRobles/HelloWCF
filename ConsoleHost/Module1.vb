Imports System.ServiceModel
Imports HelloWCF

Module Module1

    Sub Main()
        Dim hostHelloWCF As New ServiceHost(GetType(AliveIdeaService))
        hostHelloWCF.Open()
        Console.WriteLine("Servicio iniciado. Presiona [Enter] para salir.")
        Console.ReadLine()

        hostHelloWCF.Close()
    End Sub

End Module
