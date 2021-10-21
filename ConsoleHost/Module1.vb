Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports HelloWCF

Module Module1

    Sub Main()
        Dim hostHelloWCF As New ServiceHost(GetType(AliveIdeaService))
        'Para agregar endpoints de forma dinamica se debe hacer antes de abrir el host
        Dim address As String = "net.tcp://localhost:8009/AliveIdeaService"
        'Cada binding tiene una clase propia
        Dim binding As Binding = New NetTcpBinding
        Dim contract As Type = GetType(IAliveIdeaService)

        hostHelloWCF.AddServiceEndpoint(contract, binding, address)

        hostHelloWCF.Open()
        Console.WriteLine("Servicio iniciado. Presiona [Enter] para salir.")
        Console.ReadLine()

        hostHelloWCF.Close()
    End Sub

End Module
