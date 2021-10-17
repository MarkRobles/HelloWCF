Imports Data
Imports Data.Data
Imports Entities

<ServiceBehavior(InstanceContextMode:=InstanceContextMode.PerCall)>
Public Class AliveIdeaService : Implements IAliveIdeaService, IDisposable

    ReadOnly _context As New AliveIdeaDbContext

    ''' <summary>
    ''' WCF call this method for us. If this service implements IDisposable, each time it creates an instance of that service and ends
    ''' with it. it will check if it implements IDisposable and dispose
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        _context.Dispose()
    End Sub

    Public Function ObtenerMarcas() As List(Of Marca) Implements IAliveIdeaService.ObtenerMarcas
        Dim marcas = _context.Marcas.ToList()
        Return marcas
    End Function

    '<OperationBehavior(TransactionScopeRequired:=true)>Esto aplica cuando haces varios inserts para que se hagan en una sola exhibicion
    Public Function CrearMarca(marca As Marca) As Integer Implements IAliveIdeaService.CrearMarca
        _context.Marcas.Add(marca)
        Return _context.SaveChanges()


    End Function
End Class
