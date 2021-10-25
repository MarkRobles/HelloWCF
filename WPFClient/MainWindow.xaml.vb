Imports System.ServiceModel
Imports System.Threading
Imports Contracts
Imports Proxies

Class MainWindow
    Private Sub chkVisibilidadPrecio_Checked(sender As Object, e As RoutedEventArgs)

    End Sub

    Public Sub New()
        InitializeComponent()

        Me.Title = "UI Running on Thread " & Thread.CurrentThread.ManagedThreadId & " | Process " & Process.GetCurrentProcess().Id.ToString()
    End Sub

    Sub LimpiarCampos()
        txtDescripcionCorta.Text = ""
        txtDescripcionLarga.Text = ""
        txtSlogan.Text = ""
        txtMargen.Text = ""
        chkVisibilidadPrecio.IsChecked = False
    End Sub



    Function ValidarCampos() As String
        Dim strScript As String = String.Empty
        If txtDescripcionCorta.Text = "" Then
            strScript = String.Concat(strScript, Environment.NewLine, "*Descripcion corta")

        End If
        If txtDescripcionLarga.Text = "" Then
            strScript = String.Concat(strScript, Environment.NewLine, "*Descripcion larga")

        End If
        If txtSlogan.Text = "" Then
            strScript = String.Concat(strScript, Environment.NewLine, "*Slogan")

        End If
        If txtMargen.Text = "" Then
            strScript = String.Concat(strScript, Environment.NewLine, "*Margen")

        End If

        Return strScript
    End Function

    Sub ObtenerMarcas()
        Dim address As EndpointAddress = New EndpointAddress("net.tcp://localhost:2113/AliveIdea")
        Dim binding As New NetTcpBinding()
        Dim proxy As AliveIdeaClient = New AliveIdeaClient(binding, address)
        Dim data As IEnumerable(Of Marca) = proxy.ObtenerMarcas()
        If data IsNot Nothing Then grdMarcas.ItemsSource = data
        proxy.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As RoutedEventArgs) Handles btnAgregar.Click
        Dim strScript As String = String.Empty
        Dim address As EndpointAddress = New EndpointAddress("net.tcp://localhost:2113/AliveIdea")
        Dim binding As New NetTcpBinding()
        Dim proxy As AliveIdeaClient = New AliveIdeaClient(binding, address)



        Try
            strScript = ValidarCampos()
            If strScript <> "" Then
                strScript = String.Concat("Validar los siguientes campos:", strScript)
                MsgBox(strScript)
                Exit Try
            End If
            Dim marca As New Marca
            marca.DescripcionCorta = txtDescripcionCorta.Text.Trim
            marca.DescripcionLarga = txtDescripcionLarga.Text.Trim
            marca.Margen = txtMargen.Text
            marca.Slogan = txtSlogan.Text
            marca.VisibilidadPrecio = chkVisibilidadPrecio.IsChecked
            Dim resultado = proxy.CrearMarca(marca)
            If resultado >= 1 Then
                MsgBox("Marca creada correctamente")
            End If


        Catch ex As Exception

        Finally
            proxy.Close()
            ObtenerMarcas()
            LimpiarCampos()
        End Try

    End Sub

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        ObtenerMarcas()
    End Sub
End Class
