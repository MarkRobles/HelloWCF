

Public Module clsComunicacionConFrontEnd




    Private strNombreBotonEliminar As String
    Public Property NombreBotonEliminar() As String
        Get
            Return strNombreBotonEliminar
        End Get
        Set(ByVal value As String)
            strNombreBotonEliminar = value
        End Set
    End Property


    Private strMensaje As String
    Public Property Mensaje() As String
        Get
            Return strMensaje
        End Get
        Set(ByVal value As String)
            strMensaje = value
        End Set
    End Property


    Private intSegundosDuracionAlerta As Integer
    Public Property SegundosDuracionAlerta() As Integer
        Get
            Return intSegundosDuracionAlerta
        End Get
        Set(ByVal value As Integer)
            intSegundosDuracionAlerta = value
        End Set
    End Property

    Private strConfirmacionEliminacionSweetAlert As String
    Public ReadOnly Property ConfirmacionEliminacionSweetAlert() As String
        Get
            Return "<script language='javascript'> Swal.fire({
                                          title: '¿Estas seguro?',
                                          text: """ + strMensaje + """,
                                          icon: 'warning',
                                          showCancelButton: true,
                                          confirmButtonText: 'OK'
                                        }).then((result) => {
                                          if (result.isConfirmed) {
                                            " + NombreBotonEliminar + ".DoClick();
                                          }
                                        }) </script>"
        End Get
    End Property


    Public ReadOnly Property ScriptAlertaAutoCerrable() As String
        Get
            Return "<script language='javascript'>
                let timerInterval
                Swal.fire({
                  title: '¡Atención!',
                  html: '""" + strMensaje + """ <b></b> .',
                  timer: """ + SegundosDuracionAlerta.ToString() + """,
                  timerProgressBar: true,
                
                  willClose: () => {
                    clearInterval(timerInterval)
                  }
                }).then((result) => {
                  /* Read more about handling dismissals below */
                  if (result.dismiss === Swal.DismissReason.timer) {
                   // console.log('I was closed by the timer')
                  }
                })
</script>"
        End Get
    End Property

    Sub MostrarSweetAlert(ByVal page As Page, ByVal strScript As String, Optional ShowInfoIcon As Boolean = False)
        If strScript.Contains("location.href") Then
            Exit Sub
        End If
        If ShowInfoIcon Then
            'Quitar caracteres que impiden la visualizacion del mensaje en la alerta
            strScript = strScript.Replace("'", "").Replace(vbCrLf, "\n").Replace(vbCr, "\n").Replace("""", "").Replace(Chr(10), "\n").Replace(Chr(13), "\n") & "\n"
            strScript = "<script language='javascript'> 
                                Swal.fire({
                                  title: 'Notificación',
                                  text: '" & strScript & "',
                                  icon: 'info'
                                });
                                </script>"
            System.Web.UI.ScriptManager.RegisterStartupScript(page, GetType(String), "ErrorAlert", strScript, False)
            Exit Sub
        End If


        Select Case True
            Case strScript.ToUpper().Contains("CORRECTA"),
                 strScript.ToUpper().Contains("EXITOSA")

                strScript = strScript.Replace("'", "").Replace(vbCrLf, "\n").Replace(vbCr, "\n").Replace("""", "").Replace(Chr(10), "\n").Replace(Chr(13), "\n") & "\n"
                strScript = "<script language='javascript'> 
                                Swal.fire({
                                  title: 'Exito!',
                                  text: '" & strScript & "',
                                  icon: 'success'
                                });
                                </script>"
                System.Web.UI.ScriptManager.RegisterStartupScript(page, GetType(String), "OkAlert", strScript, False)
                Exit Sub
            Case String.IsNullOrWhiteSpace(strScript)

            Case Else
                'Quitar caracteres que impiden la visualizacion del mensaje en la alerta
                strScript = strScript.Replace(Chr(10), "<br/>").Replace(Chr(13), "<br/>").Replace("'", "")
                strScript = "<script language='javascript'> 
                            Swal.fire({
                              title: 'Error!',
                              html: '" & strScript & "',
                              icon: 'error'
                            });
                            </script>"
                System.Web.UI.ScriptManager.RegisterStartupScript(page, GetType(String), "ErrorAlert", strScript, False)
                Exit Sub
        End Select
    End Sub


    Sub MostrarAlertaAutoCerrable(ByVal page As Page, ByVal strMensaje As String, ByVal intSegundosDuracionAlerta As Integer)
        Mensaje = strMensaje
        SegundosDuracionAlerta = intSegundosDuracionAlerta * 1000
        System.Web.UI.ScriptManager.RegisterStartupScript(page, GetType(String), "AutoCerrable", ScriptAlertaAutoCerrable, False)
    End Sub

    Sub MostrarAlertaConfirmacion(ByVal page As Page, ByVal strNombreBotonQueElimina As String)
        Mensaje = strMensaje
        NombreBotonEliminar = strNombreBotonQueElimina
        System.Web.UI.ScriptManager.RegisterStartupScript(page, GetType(String), "ConfirmarEliminacion", ConfirmacionEliminacionSweetAlert, False)
    End Sub
End Module
