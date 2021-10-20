Imports System.Security
Imports System.Security.Claims
Imports System.Security.Permissions
Imports System.Threading
Imports Data
Imports Data.Data
Imports Entities

<ServiceBehavior(InstanceContextMode:=InstanceContextMode.PerCall)>
Public Class AliveIdeaService : Implements IAliveIdeaService


    Public Sub New()
    End Sub

    'Public Sub New(ByVal zipCodeRepository As IMarcasRepositorio)
    '    Me.New(zipCodeRepository)
    'End Sub


    Public Sub New(ByVal zipCodeRepository As IMarcasRepositorio)
        _MarcaRepositorio = zipCodeRepository
    End Sub


    Private _MarcaRepositorio As IMarcasRepositorio = Nothing


    '  <PrincipalPermission(SecurityAction.Demand, Role:="BUILTIN\\Administrators")>'opcion 2
    Public Function ObtenerMarcas() As List(Of Marca) Implements IAliveIdeaService.ObtenerMarcas
        'Opcion 1
        'Dim principal = Thread.CurrentPrincipal
        'If Not principal.IsInRole("BUILTIN\\Administrators") Then
        '    Throw New SecurityException("Accesso denegado")
        'End If

        'Opcion3 
        '  ClaimsPrincipal.Current.HasClaim()
        Dim marcaRepo As IMarcasRepositorio = IIf(_MarcaRepositorio Is Nothing, New MarcaRepositorio, _MarcaRepositorio) 'Make class testable
        Dim marcas = marcaRepo.ObtenerMarcas()
        Return marcas

    End Function

    '<OperationBehavior(TransactionScopeRequired:=true)>Esto aplica cuando haces varios inserts para que se hagan en una sola exhibicion
    Public Function CrearMarca(marca As Marca) As Integer Implements IAliveIdeaService.CrearMarca

        Dim marcaRepo As IMarcasRepositorio = IIf(_MarcaRepositorio Is Nothing, New MarcaRepositorio, _MarcaRepositorio)
        Dim resultado = marcaRepo.CrearMarca(marca)
        Return resultado


    End Function
End Class
