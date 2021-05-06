'Imports DBConexion_SQL

'Option Explicit On 
Imports System.Configuration
Imports DBConexion_SQL
Imports System.IO

Public Class BNSeguridad
    Public CadPermiso As String
    Public CodTrabajador As String
    Public NomTrabajador As String
    Public DepTrabajador As String
    Public CodDependencia As String
    Public LogOnPerfil As String
    Public SQLConString As String
    Public SqlConHOST As String

    Private gBNConCUBString_AHSB As String
    Private gBNConString_AHSB As String
    Private StrError As String
    Private mClase As String

    Property PropiedadClase() As String
        Get
            Return (mClase)
        End Get
        Set(ByVal value As String)
            mClase = value
        End Set
    End Property

    Public Function IniciarSesion(ByVal Usuario As String, ByVal Password As String, ByRef Mensaje As String) As Boolean
        Dim CadenaPermiso As String

        ValidarUsuario(Usuario, Password, Mensaje)

        If Mensaje = "" Then
            'INICIO SRAMOSQ
            'LogOnPerfil = ADM 'Get_Perfil_Usuario()
            LogOnPerfil = Get_Perfil_Usuario()
            'FIN SRAMOSQ
            Return True
        End If
        Return False
    End Function

    Private Sub ValidarUsuario(ByVal Usuario As String, ByVal Password As String, ByRef MensajeClaves As String)
        Dim Sw As String = ConfigurationSettings.AppSettings("WsAmbiente")
        Dim sAplicacion As String = ConfigurationSettings.AppSettings("App")
        Dim sOpcion As String = ConfigurationSettings.AppSettings("Opc")
        Dim StrError As String
        'Dim sAplicacion As String = System.Configuration.ConfigurationSettings.AppSettings.Item("Aplicacion")

        Dim sUsuario As String = Usuario.Trim.ToUpper
        Dim sPassword As String = Password.Trim.ToUpper & Space(8 - Password.Trim.Length)  'corrección para 8 caracetres
        'Dim sOpcion As String = "00"                                                      'opc interna de host

        Dim sParametros As String = sUsuario & sPassword & sAplicacion & sOpcion    'logica de trama a enviar
        Dim sCadena As String
        Dim strIP As String
        Dim ArrArchivos As New ArrayList

        '==========================================================
        ' Codigo Original -->> Descomentar para Release
        '==========================================================



        'If Sw = "0" Then 'Produccion
        '    Dim oClaves As New srv1pgwhs1.PServicioClavesHOST
        '    sCadena = oClaves.SerClavesHOST(sParametros)
        'Else
        '    If Sw = "1" Then 'Desarrollo
        '        Dim oClaves As New desa_his.PServicioClavesHOST
        '        sCadena = oClaves.SerClavesHOST(sParametros)
        '    Else
        '        If Sw = "2" Then 'Certificacion
        '            Dim oClaves As New WebReference.PServicioClavesHOST
        '            sCadena = oClaves.SerClavesHOST(sParametros)

        '        End If
        '    End If

        'End If
        'INICIO SRAMOSQ
        Try
            'FIN SRAMOSQ

            If GetParametrosCOM(SQLConString, SqlConHOST, StrError) Then
                Dim fichero As String = ConfigurationSettings.AppSettings("vRUTA_AMBIENTE")
                Dim srAmbiente As New System.IO.StreamReader(fichero)
                Dim objStreamAmbiente As StreamReader

                objStreamAmbiente = File.OpenText(fichero)
                Dim readAmbiente As String = objStreamAmbiente.ReadToEnd
                objStreamAmbiente.Close()
                srAmbiente.Close()
                'INICIO SRAMOS
                Select readAmbiente
                    Case Is = "DESA"
                        'desarrollo
                        'Dim ServicioClaves As New WSClaves_DESA.AutenticaRegService
                        'sCadena = ServicioClaves.claveHost(sParametros)
                        sCadena = "00|0741|1|0294489|01S02S03S04S05N06N07N08N09N10N11N12N13N14N15N16N17N18N19N20N21N22N23N24N25N26N27N28N29N30N|SAAVEDRA/MEJIA/MIGUEL              |TRUJILLO                           |Su acceso ha sido exitoso                         |1|08881233       |Secc. Arquitectura de Software|                         |"
                    Case Is = "CERT"
                        'certificacion
                        Dim ServicioClaves As New WSClaves_CERT.AutenticaRegService
                        sCadena = ServicioClaves.claveHost(sParametros)
                    Case Is = "PROD"
                        'produccion
                        Dim ServicioClaves As New WSClaves_PROD.AutenticaRegService
                        sCadena = ServicioClaves.claveHost(sParametros)
                End Select
                'FIN SRAMOS
            Else
                mClase = "Error en Lectura Parametros COM " & StrError
                MensajeClaves = mClase
                Exit Sub
            End If
            'INICIO SRAMOSQ
        Catch ex As Exception

        End Try
        'FIN SRAMOSQ
        'Dim oClaves As New desa_his1.PServicioClavesHOST

        '==========================================================
        Try
            If sCadena.Substring(0, 2) = "00" Then
                CadPermiso = sCadena.Substring(18, 90).Trim

                CodTrabajador = sCadena.Substring(10, 7).Trim
                NomTrabajador = sCadena.Substring(109, 35).Trim
                DepTrabajador = sCadena.Substring(145, 35).Trim
                CodDependencia = sCadena.Substring(3, 4).Trim

                MensajeClaves = ""

            ElseIf sCadena.Substring(0, 2) = "01" Then
                '=================================================
                ' USUARIO NO EXISTE en la Aplicacion de Claves
                '=================================================
                CadPermiso = ""
                MensajeClaves = "El Usuario Ingresado no Existe"

            ElseIf sCadena.Substring(0, 2) = "02" Then
                '=================================================
                ' CLAVE ERRADA para el Usuario
                '=================================================
                CadPermiso = ""
                MensajeClaves = "La Clave Ingresada es Incorrecta."

            ElseIf sCadena.Substring(0, 2) = "04" Then
                '=================================================
                ' SISTEMA SE ENCUENTRA TEMPORALMENTE INACTIVO
                '=================================================
                CadPermiso = ""
                MensajeClaves = "Error desconocido, comuniquese con Sistemas"

            ElseIf sCadena.Substring(0, 2) = "06" Then
                '======================================================
                ' 30/01/2007 Adición en Sistema de Claves codigo 06 
                '            para verificar user/clave no sean iguales
                '======================================================
                CadPermiso = ""
                MensajeClaves = "Modificar Clave, debe ser diferente a código de usuario"
            ElseIf sCadena.Substring(0, 2) = "07" Then
                '=================================================
                ' 30/01/2007 Adición en Sistema de Claves codigo 07 
                '            por caducidad de clave (60 dias)
                '=================================================
                CadPermiso = ""
                MensajeClaves = "Clave vencida o no modificada"

            End If
            'INICIO SRAMOSQ
            'MensajeClaves = ""
            'FIN SRAMOSQ
        Catch ex As Exception
            CadPermiso = " "
            MensajeClaves = "EL SISTEMA SE ENCUENTRA TEMPORALMENTE INACTIVO. POR FAVOR, INTENTE MAS TARDE"
            'INICIO SRAMOSQ
            ' MensajeClaves = ""
            'CodTrabajador = "0569"  'sCadena.Substring(10, 7).Trim
            'NomTrabajador = "PRUEBA" 'sCadena.Substring(109, 35).Trim
            'DepTrabajador = "0563"  'sCadena.Substring(145, 35).Trim
            'CodDependencia = "1234" 'sCadena.Substring(3, 4).Trim
            'FIN SRAMOSQ
        End Try
    End Sub

    Private Function Get_Perfil_Usuario() As String

        If CadPermiso = TramaADM Then
            '=========================================
            ' Retornando el Perfil ADMINISTRADOR
            '=========================================
            Return ADM

        ElseIf CadPermiso = TramaREG Then
            '    '=========================================
            '    ' Retornando el Perfil Supervisor
            '    '=========================================
            Return REG

            'ElseIf CadPermiso = TramaALM Then
            '    '=========================================
            '    ' Retornando el Perfil Almacenero
            '    '=========================================
            '    Return ALM

            'ElseIf CadPermiso = TramaOPE Then
            '    '=========================================
            '    ' Retornando el Perfil Operador
            '    '=========================================
            '    Return OPE

        End If

    End Function

End Class



