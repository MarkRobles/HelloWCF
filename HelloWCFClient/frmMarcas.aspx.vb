Public Class frmMarcas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim proxy As New AliveIdeaService.AliveIdeaServiceClient()

        Dim marcas = proxy.ObtenerMarcas()
    End Sub

End Class