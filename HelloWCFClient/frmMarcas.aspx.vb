Public Class frmMarcas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim proxy As New AliveIdeaService.AliveIdeaServiceClient("NetTcpBinding_IAliveIdeaService")
        'proxy.ClientCredentials.Windows.ClientCredential.UserName = "DOMAIN\\User"
        'proxy.ClientCredentials.Windows.ClientCredential.Password = "Password"

        Try


            Dim marcas = proxy.ObtenerMarcas()
            grdMarcas.DataSource = marcas
            grdMarcas.DataBind()

        Catch ex As Exception
            MostrarSweetAlert(Me, ex.Message)
        Finally
            proxy.Close() 'Liberar los recursos utilizados por el proxy aunque ocurra un error
        End Try

    End Sub

End Class