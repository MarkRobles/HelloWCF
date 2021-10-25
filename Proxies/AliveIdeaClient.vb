Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports Contracts

''' <summary>
''' Cuando esta clase es instanciada por una app cliente busca informacion del endpoint
''' </summary>
Public Class AliveIdeaClient
    Inherits ClientBase(Of IAliveIdeaService) 'This give us access to channel property os our service
    Implements IAliveIdeaService


    Public Sub New(ByVal endpointName As String)
        MyBase.New(endpointName)
    End Sub


    Public Sub New(ByVal binding As Binding, ByVal address As EndpointAddress)
        MyBase.New(binding, address)
    End Sub

    Public Function ObtenerMarcas() As List(Of Marca) Implements IAliveIdeaService.ObtenerMarcas
        Return Channel.ObtenerMarcas
    End Function

    Public Function CrearMarca(marca As Marca) As Integer Implements IAliveIdeaService.CrearMarca
        Return Channel.CrearMarca(marca)
    End Function


End Class
