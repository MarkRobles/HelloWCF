Imports System.ServiceModel

<ServiceContract()>
Public Interface IAliveIdeaService

    <OperationContract()>
    Function ObtenerMarcas() As List(Of Marca)

    <OperationContract()>
    Function CrearMarca(ByVal marca As Marca) As Integer
End Interface
