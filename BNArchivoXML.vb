Public Class BNArchivoXML
    Inherits System.Web.UI.Page

    Public Function LeerFileXML(ByVal Archivo As String) As DataTable
        Try
            Dim dsArchivo As New DataSet
            Dim Ruta As String
            Ruta = Server.MapPath(Archivo)

            '==============================================
            ' Archivos XML
            '==============================================
            ' 1) Archivo de Menu : MenuXML.xml
            ' 2) Archivo de Ciudades : CodigoCiudadXML.xml
            ' 3) Archivo de Nemonicos : CodigoNemonicoXML.xml
            ' 4) Archivo de Sub Tasas : SubTasasXML.xml
            ' 5) Archivo de Tasas FFAA : FFAATasasXML.xml

            dsArchivo.ReadXml(Ruta)
            Return dsArchivo.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
