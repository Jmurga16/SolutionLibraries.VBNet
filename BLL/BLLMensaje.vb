Public Class BLLMensaje
    Dim MiDALMensaje As New DAL.DALMensaje

    Public Function BGetResponseBool(Mensaje As String, BtnPrincipal As String, BtnSecundario As String) As Boolean
        Return MiDALMensaje.GetResponseBool(Mensaje, BtnPrincipal, BtnSecundario)
    End Function

    Public Function BGetMensajeFromBD(Id As Integer) As LayerEntity.ClsMensaje
        Return MiDALMensaje.GetMensajeFromBD(Id)
    End Function

End Class
