Imports System.ServiceModel
Imports System.Threading
Imports Contracts
Imports Proxies

Class MainWindow
    Private Sub chkVisibilidadPrecio_Checked(sender As Object, e As RoutedEventArgs)

    End Sub

    Public Sub New()
        InitializeComponent()
        ObtenerMarcas()
        Me.Title = "UI Running on Thread " & Thread.CurrentThread.ManagedThreadId & " | Process " & Process.GetCurrentProcess().Id.ToString()
    End Sub


    Sub ObtenerMarcas()
        Dim address As EndpointAddress = New EndpointAddress("net.tcp://localhost:2113/AliveIdea")
        Dim binding As New NetTcpBinding()
        Dim proxy As AliveIdeaClient = New AliveIdeaClient(binding, address)
        Dim data As IEnumerable(Of Marca) = proxy.ObtenerMarcas()
        If data IsNot Nothing Then grdMarcas.ItemsSource = data
        proxy.Close()
    End Sub


End Class
