Imports System.ServiceModel
Imports System.ServiceModel.Activation

Public Class CustomHostFactory
    Inherits ServiceHostFactory


    Protected Overrides Function CreateServiceHost(serviceType As Type, baseAddresses() As Uri) As ServiceHost

        'Si necesitas establecer la configuracion dinamicamente , aqui es posible hacerlo
        Dim host As New ServiceHost(serviceType, baseAddresses)
        Return host
    End Function


End Class
