Public Class frmMarcas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim proxy As New AliveIdeaService.AliveIdeaServiceClient("BasicHttpBinding_IAliveIdeaService")

        Dim marcas = proxy.ObtenerMarcas()
        proxy.Close()
    End Sub

End Class