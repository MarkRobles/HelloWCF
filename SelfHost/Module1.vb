Imports System.ServiceModel
Imports HelloWCF

Module Module1

    Sub Main()

        Try
            Dim host As New ServiceHost(GetType(AliveIdeaService))
            host.Open()

            Console.WriteLine("Presiona cualquier tecla pra salir")
            Console.ReadKey()

            host.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub

End Module
