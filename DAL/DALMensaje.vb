Imports System.Data.SqlClient

Public Class DALMensaje

    Public Function GetResponseBool(Mensaje As String, BtnPrincipal As String, BtnSecundario As String) As Boolean
        Return True
    End Function

    Public Function GetMensajeFromBD(Id As Integer) As LayerEntity.ClsMensaje
        Dim cnn As New SqlConnection(Conexion.ConnectionString)
        Dim command As New SqlCommand("SP_SELECT_MENSAJE", cnn)
        Dim entity As LayerEntity.ClsMensaje = New LayerEntity.ClsMensaje

        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("Id", SqlDbType.Int).Value = Id

        Try
            cnn.Open()
            Dim dr As SqlDataReader
            dr = command.ExecuteReader

            While dr.Read()
                entity.Mensaje = dr("Mensaje").ToString()
                entity.BtnPrincipal = dr("BtnPrincipal").ToString()
                entity.BtnSecundario = dr("BtnSecundario").ToString()
            End While

            command.ExecuteNonQuery()
            dr.Close()

        Catch ex As Exception

        End Try
        cnn.Close()

        Return entity

    End Function

End Class
