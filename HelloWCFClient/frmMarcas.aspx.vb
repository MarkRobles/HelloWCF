

Imports Contracts

Public Class frmMarcas
    Inherits System.Web.UI.Page


    Function LimpiarCampos()
        txtDescripcionCorta.Text = String.Empty
        txtDescripcionLarga.Text = String.Empty
        chkVisibilidad.Checked = False
        txtMargen.Text = String.Empty
        txtSlogan.Text = String.Empty
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ObtenerMarcas()
    End Sub


    Sub ObtenerMarcas()
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

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs)
        popDatos.Visible = True
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim proxy As New AliveIdeaService.AliveIdeaServiceClient("NetTcpBinding_IAliveIdeaService")
        Try
            Dim marca As New Marca
            marca.DescripcionCorta = txtDescripcionCorta.Text.Trim
            marca.DescripcionLarga = txtDescripcionLarga.Text.Trim
            marca.VisibilidadPrecio = chkVisibilidad.Checked
            marca.Margen = txtMargen.Text.Trim
            marca.Slogan = txtSlogan.Text.Trim

            Dim resultado = proxy.CrearMarca(marca)

            If resultado >= 1 Then
                clsComunicacionConFrontEnd.MostrarSweetAlert(Me, "Marca registrada correctamente")
            End If


        Catch ex As Exception
            MostrarSweetAlert(Me, ex.Message)
        Finally
            proxy.Close() 'Liberar los recursos utilizados por el proxy aunque ocurra un error
            ObtenerMarcas()
            LimpiarCampos()
        End Try
    End Sub
End Class