Imports DataProtector.DataProtector
Imports System.Data.SqlClient
Imports System.Data
Imports System.Text


Public Class DBConexion

   Protected dbConnection As Data.SqlClient.SqlConnection
   Protected dbCommand As Data.SqlClient.SqlCommand
   Protected dbDataReader As Data.SqlClient.SqlDataReader

    Protected dbDataAdapter As Data.SqlClient.SqlDataAdapter
    Protected dbDataSet As Data.DataSet
    Protected dbParametro As New SqlParameter

   Private gBNSQLConString_AHSB As String
   Private gBNConString_AHSB As String
   Private gBNConCUBString_AHSB As String
   Private SQLConn As New SqlConnection
   Private SQLDa As New SqlDataAdapter
   Private bLog As Boolean = False
   Private sFilePath As String = ""
    Private CadenaConexion As String
    Private mClase As String
    Private strError As String
   '**************************************************************************
   'Nombre:    	New()
   'Propósito: 	Constructor
   '**************************************************************************
  
    Property PropiedadClase() As String
        Get
            Return (mClase)
        End Get
        Set(ByVal value As String)
            mClase = value
        End Set
    End Property

    Protected Sub AbrirConexion(ByRef ErrMsg As String)

        Try
            'Dim dp As New DataProtector.DataProtector(Store.USE_MACHINE_STORE)
            'Dim dataToDecrypt As Byte() = Convert.FromBase64String(CadenaEncriptada)
            'Dim CadenaConexion As String = Encoding.ASCII.GetString(dp.Decrypt(dataToDecrypt, Nothing))
            If GetParametrosCOM(SQLConString, SqlConHOST, strError) Then
                CadenaConexion = SQLConString
                'CadenaConexion = BNFunciones.GetEncrypDesencryp(GetEncryptedConnectionString("SQL"), False)
                dbConnection = New Data.SqlClient.SqlConnection(CadenaConexion)
                dbConnection.Open()
            Else
                mClase = strError
            End If
            

        Catch ex As Exception
            ErrMsg = ex.Message
        End Try

    End Sub

    Protected Sub AbrirConexion_Libre(ByVal SrvSQL As String, ByVal UsrSQL As String, ByVal PwdSQL As String, ByVal BdDSQL As String, ByRef ErrMsg As String)
        Dim CadenaConexion As String

        Try
            'CadenaConexion = "Server=" & SrvSQL & ";" & _
            '                 "Uid=" & UsrSQL & ";" & _
            '                 "Password=" & PwdSQL & ";" & _
            '                 "Database=" & BdDSQL

            If GetParametrosCOM(SQLConString, SqlConHOST, strError) Then
                CadenaConexion = SQLConString
                'CadenaConexion = BNFunciones.GetEncrypDesencryp(GetEncryptedConnectionString("SQL"), False)
                dbConnection = New Data.SqlClient.SqlConnection(CadenaConexion)
                dbConnection.Open()
            Else
                mClase = strError
            End If


        Catch ex As Exception
            ErrMsg = ex.Message
        End Try

    End Sub

    Protected Sub CerrarConexion(ByRef ErrMsg As String)

        Try
            dbConnection.Close()

        Catch ex As Exception
            ErrMsg = ex.Message
        End Try

    End Sub


End Class
