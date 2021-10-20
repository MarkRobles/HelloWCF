Imports Entities

Public Interface IMarcasRepositorio
    Function ObtenerMarcas() As List(Of Marca)
    Function CrearMarca(marca As Marca) As Integer

End Interface
