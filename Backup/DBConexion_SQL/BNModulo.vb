Imports System.Reflection.Assembly
Imports System.Xml
Imports System.IO
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.HttpRequest
Imports System.Web.HttpResponse
Imports System.Configuration
Imports System.Text.RegularExpressions


Public Module BNModulo

    Public Const KEY As String = "+*+$"
    'Public OracleConnectionString As String = "Data Source=orades;user id=BN_VISA;password=visa"
    Public strErrores As String
    Public SQLCUBEncrypted As String = GetEncryptedConnectionString("SQL")
    Public SqlConCUBString As String = Encryptor.DecryptTripleDES(SQLCUBEncrypted)

    Public vAMBIENTE As String = ConfigurationSettings.AppSettings("vRUTA_AMBIENTE")
    Public vSISTEMA As String = ConfigurationSettings.AppSettings("vSISTEMA")
    Public vCUENTA As String = ConfigurationSettings.AppSettings("vCUENTA")
    Public vSEMILLA As String = ConfigurationSettings.AppSettings("vSEMILLA")
    Public vRUTA_KEY_ARCHIVO As String = ConfigurationSettings.AppSettings("vRUTA_KEY_ARCHIVO") 'Físicamente existe en la pc
    Public vIDUSUARIO As String = ConfigurationSettings.AppSettings("vIDUSUARIO")
    Public vALIASGRUPO1 As String = ConfigurationSettings.AppSettings("vALIASGRUPO1")
    Public vALIASGRUPO2 As String = ConfigurationSettings.AppSettings("vALIASGRUPO2")
    Public vALIASGRUPO3 As String = ConfigurationSettings.AppSettings("vALIASGRUPO3")

    '== Constantes ============================================================
    Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
    Const sCOM_CHAR_IZQUIERDO As String = "["
    Const sCOM_CHAR_DERECHO As String = "]"
    Const sCOM_CHAR_DERECHOGUION As String = "]-"
    Const sCOM_CHAR_SEPARADOR As String = "/"

    Public SQLConString As String
    Public SqlConHOST As String

    Function GetParametrosCOM(ByRef StrSQL1 As String, ByRef StrHOST As String, ByRef StrError As String) As Boolean
        Dim bEstado As Boolean = False
        '============================================================
        ' Cargar Parametros COM 
        '============================================================
        Dim obj_InterfazKey, vValor_texto, obj_SistemaPrm
        Dim cad_valor As String
        Dim WSGetArray As New WSGetArray.Service1
        Dim sMensajeUsuario As String

        Try
            StrError = ""
            '=================
            ' INSTANCIA DE COMPONENTES
            '=================
            'D:\ProyectosNET\HBPRDIntraPRAH\Web References\WSParametrosCOM_CERT\
            Dim fichero As String = vAMBIENTE
            sMensajeUsuario = "PASO_1"
            Dim srAmbiente As New System.IO.StreamReader(fichero)
            Dim objStreamAmbiente As StreamReader
            sMensajeUsuario = "PASO_2"
            objStreamAmbiente = File.OpenText(fichero)
            Dim readAmbiente As String = objStreamAmbiente.ReadToEnd
            sMensajeUsuario = "PASO_3"
            objStreamAmbiente.Close()
            srAmbiente.Close()
            sMensajeUsuario = "PASO_4"
            Select Case readAmbiente
                Case Is = "DESA"   'ASIGNAR URL COM AMBIENTE  DESARROLLO
                    Dim vURLCOM As String = ConfigurationSettings.AppSettings("vURLGETArrayDESA")
                    WSGetArray.Url = vURLCOM
                    obj_InterfazKey = New WSParametrosCOM_DESA.ParametroInterfazKeyService
                    obj_SistemaPrm = New WSParametrosCOM_DESA.SistemaParametro

                Case Is = "CERT"   'ASIGNAR URL COM AMBIENTE CERTIFICACION
                    Dim vURLCOM As String = ConfigurationSettings.AppSettings("vURLGETArrayCERT")
                    WSGetArray.Url = vURLCOM
                    obj_InterfazKey = New WSParametrosCOM_CERT.ParametroInterfazKeyService
                    obj_SistemaPrm = New WSParametrosCOM_CERT.SistemaParametro

                Case Is = "PROD"   'ASIGNAR URL COM AMBIENTE PRODUCCION 
                    Dim vURLCOM As String = ConfigurationSettings.AppSettings("vURLGETArrayPROD")
                    WSGetArray.Url = vURLCOM
                    obj_InterfazKey = New WsParametrosCOM_PROD.ParametroInterfazKeyService
                    obj_SistemaPrm = New WsParametrosCOM_PROD.SistemaParametro

            End Select
            sMensajeUsuario = "PASO_5"
            Dim srclave As New System.IO.StreamReader(vRUTA_KEY_ARCHIVO)
            Dim objStreamReader As StreamReader
            sMensajeUsuario = "PASO_6"
            'open the file
            objStreamReader = File.OpenText(vRUTA_KEY_ARCHIVO)
            Dim readfile As String = objStreamReader.ReadToEnd
            sMensajeUsuario = "PASO_7"
            Dim key_Archivo() As Byte = WSGetArray.GetArrayBytes(vRUTA_KEY_ARCHIVO)
            sMensajeUsuario = "PASO_8"
            ' Dim key_Archivo() As Byte = File.ReadAllBytes("C:\opt\software\key\prah\clavesegurades.key")
            obj_SistemaPrm = obj_InterfazKey.datoParametroService( _
             vSISTEMA, _
             vCUENTA, _
             vSEMILLA, _
             key_Archivo, _
            vIDUSUARIO)
            sMensajeUsuario = "PASO_9"
            objStreamReader.Close()
            srclave.Close()

            Dim vValorsqlPW1, vValorsqlIP1, vValorsqlBD1, vValorsqlUser1 As String
            Dim vValorsqlPW2, vValorsqlIP2, vValorsqlBD2, vValorsqlUser2 As String
            Dim vValorClavesHost As String
            sMensajeUsuario = "PASO_10"
            Select Case obj_SistemaPrm.proceso.codigo
                Case "00000" ' Caso Exito
                    sMensajeUsuario = "PASO_11"
                    bEstado = True
                    Dim n As Integer 'Contador
                    For n = 0 To (obj_SistemaPrm.grupoParametro.Length - 1) 'Leer Parámetros
                        '========
                        Dim vParametroGrupo1(obj_SistemaPrm.grupoParametro(n).parametro.Length - 1) As String 'Definimos Arreglo
                        Dim vParametroGrupo2(obj_SistemaPrm.grupoParametro(n).parametro.Length - 1) As String
                        Dim vParametroGrupo3(obj_SistemaPrm.grupoParametro(n).parametro.Length - 1) As String

                        Dim p As Integer 'p=Parámetros
                        For p = 0 To (obj_SistemaPrm.grupoParametro(n).parametro.Length - 1) ' Inicio Mostrar Parámetros
                            vParametroGrupo1(p) = obj_SistemaPrm.grupoParametro(n).parametro(p).valorParam  'Ejem="SqlNombredb"
                            vParametroGrupo2(p) = obj_SistemaPrm.grupoParametro(n).parametro(p).valorParam
                            vParametroGrupo3(p) = obj_SistemaPrm.grupoParametro(n).parametro(p).valorParam

                            Select Case obj_SistemaPrm.grupoParametro(n).aliasGrupo 'Nombre de Grupo[Personalizado]
                                Case vALIASGRUPO1 'sql
                                    vValorClavesHost = vParametroGrupo1(0)

                                Case vALIASGRUPO2  'sql
                                    vValorsqlPW1 = vParametroGrupo2(0)
                                    vValorsqlIP1 = vParametroGrupo2(1)
                                    vValorsqlBD1 = vParametroGrupo2(2)
                                    vValorsqlUser1 = vParametroGrupo2(3)

                                Case vALIASGRUPO3  'sql
                                    vValorsqlPW2 = vParametroGrupo3(0)
                                    vValorsqlIP2 = vParametroGrupo3(1)
                                    vValorsqlBD2 = vParametroGrupo3(2)
                                    vValorsqlUser2 = vParametroGrupo3(3)

                                Case Else
                                    StrError = obj_SistemaPrm.descripcion
                                    'MsgBox("error" & obj_SistemaPrm.descripcion)
                            End Select

                        Next p 'Fin Mostrar parámetros
                    Next n 'Fin de leer parametros        

                Case "-0010" 'Caso sistema o usuario inválido
                    sMensajeUsuario = "PASO_12"
                    cad_valor = obj_SistemaPrm.proceso.descripcion 'Ejem.:"SISTEMA NO REGISTRADO"
                    StrError = cad_valor
                    bEstado = False
                    ' LblAcceso.Text = "-0010 - Sistema No Registrado"
                    Exit Function
                Case "-0024" 'Caso clave inválido
                    sMensajeUsuario = "PASO_13"
                    cad_valor = obj_SistemaPrm.proceso.descripcion 'Ejem.:"LA CLAVE ES INCORRECTA, VERIFICAR MAYUSCULAS Y MINUSCULAS"
                    StrError = cad_valor
                    ' LblAcceso.Text = "-0024 - La clave es incorrecta,verificar mayúsculas y minúsculas"
                    bEstado = False
                    Exit Function

                Case Else
                    cad_valor = "{---no especificado---}"
                    sMensajeUsuario = "PASO_14"
                    StrError = cad_valor
                    'Dim mmm As String = cad_valor(1)
                    ' LblAcceso.Text = "{---no especificado---}"
                    bEstado = False
                    Exit Function
            End Select
            If vValorsqlPW1 <> "" And vValorsqlIP1 <> "" And vValorsqlBD1 <> "" And vValorsqlUser1 <> "" Then
                StrSQL1 = "Data Source= " & vValorsqlIP1 & ";uid= " & vValorsqlUser1 & ";pwd= " & vValorsqlPW1 & ";database=" & vValorsqlBD1 & ""
                SQLConString = StrSQL1
            Else
                StrSQL1 = ""
                SQLConString = StrSQL1
            End If


            If vValorClavesHost <> "" Then
                StrHOST = vValorClavesHost
            Else
                StrHOST = ""
            End If

            CrearLogTXT(sCOM_CHAR_IZQUIERDO & _
                       Format(Now, "yyyy/MM/dd HH:mm:ss") & _
                       sCOM_DESC_EXCEPCION & _
                       "BNMODULO-" & sCOM_CHAR_SEPARADOR & _
                       "GetParametrosCOM-AHSB-" & sCOM_CHAR_DERECHOGUION & _
                       sCOM_CHAR_IZQUIERDO & "EVENTO-" & sMensajeUsuario & sCOM_CHAR_DERECHO)

        Catch ex As Exception
            CrearLogTXT(sCOM_CHAR_IZQUIERDO & _
                       Format(Now, "yyyy/MM/dd HH:mm:ss") & _
                       sCOM_DESC_EXCEPCION & _
                       "BNMODULO-" & sCOM_CHAR_SEPARADOR & _
                       "GetParametrosCOM-AHSB-" & sCOM_CHAR_DERECHOGUION & _
                       sCOM_CHAR_IZQUIERDO & "ERROR-" & sMensajeUsuario & sCOM_CHAR_SEPARADOR & " " & ex.Message & sCOM_CHAR_DERECHO)

            StrError = cad_valor & "|" & ex.Message()
            'INICIO SRAMOSQ
            StrSQL1 = "Data Source= 10.240.140.118;uid=sa;pwd=123456a.;database=BN_AHSB" '& vValorsqlIP1 & ";uid= " & vValorsqlUser1 & ";pwd= " & vValorsqlPW1 & ";database=" & vValorsqlBD1 & ""
            bEstado = True
            'FIN SRAMOSQ
        End Try

        Return bEstado

    End Function

    Public Sub CrearLogTXT(ByVal Datos As String)
        Dim stbRegistro As New System.Text.StringBuilder
        Try
            stbRegistro.Append(Datos)
            Dim fstRegistro As New System.IO.FileStream("C:\LOG\logParaCOM.txt", FileMode.Append)    'ConfigurationSettings.AppSettings("RutaLog")
            Dim stwConstancia As New System.IO.StreamWriter(fstRegistro)
            stwConstancia.WriteLine(stbRegistro)
            stwConstancia.Close()
            fstRegistro.Close()

        Catch ex As Exception
            'Throw ex
        End Try
    End Sub

    Function DevolverIP(ByVal URL As String) As String
        Dim bCadena As String = ""
        Dim arr() As String
        Dim i As Integer
        arr = Split(URL, "/")
        For i = 0 To arr.Length - 1
            If arr(i) <> "" Then
                If arr(i).Substring(0, 1) = "1" Then
                    bCadena = arr(i)
                End If
            Else
                bCadena = ""
            End If
        Next
        Return bCadena
    End Function


    Function BuscarArchivoDirectorio(ByVal sDir As String, ByVal tipoArch As String) As ArrayList
        Dim dir As String
        Dim files As String
        Dim contenido As String
        Dim arrfiles As New ArrayList
        Dim cont As Integer = 0

        Try
            'For Each dir In Directory.GetDirectories(sDir)
            For Each files In Directory.GetFiles(sDir, tipoArch)
                contenido = files
                arrfiles.Add(New BNItem(files.Substring(InStr(files, ".")), files))
                cont += 1
            Next
            'DirSearch(dir, tipoArch)
            'Next

        Catch ex As System.Exception
            Throw ex
        End Try
        Return arrfiles
    End Function

    Function ReemplazarCadenaWSClaves(ByVal ListaArch As ArrayList, ByVal IPReplace As String, ByRef strError As String) As Boolean
        Dim bEstado As Boolean = False
        Dim i As Integer

        Try
            For i = 0 To ListaArch.Count - 1
                ''CType(arrfiles(cont), BNItem).ID()
                ''CType(arrfiles(cont), BNItem).Item()
                ''arrfiles(cont).Item()
                Select Case ListaArch(i).ID
                    Case Is = "wsdl"
                        Dim srArhivo As StreamReader
                        srArhivo = File.OpenText(ListaArch(i).Item())
                        Dim Contenido As String = srArhivo.ReadToEnd
                        srArhivo.Close()
                        'contenido = Regex.Replace(contenido, "http://10.7.12.64:9080/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                        If Regex.IsMatch(Contenido, "http://10.7.12.64:9080/") Then    'IP DESA
                            contenido = Regex.Replace(contenido, "http://10.7.12.64:9080/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                        Else
                            If Regex.IsMatch(Contenido, "http://10.7.106.247/") Then  'IP CERTI
                                contenido = Regex.Replace(contenido, "http://10.7.106.247/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                            Else
                                If Regex.IsMatch(Contenido, "http://10.7.10.53/") Then  'IP PROD
                                    contenido = Regex.Replace(contenido, "http://10.7.10.53/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                                End If
                            End If
                        End If
                        Dim srArchwriter As StreamWriter
                        srArchwriter = File.CreateText(ListaArch(i).Item())
                        srarchwriter.Write(contenido)
                        srArchwriter.Close()


                    Case Is = "map"
                        Dim srArhivo As StreamReader
                        srArhivo = File.OpenText(ListaArch(i).Item())
                        Dim contenido As String = srArhivo.ReadToEnd
                        srArhivo.Close()
                        If Regex.IsMatch(Contenido, "http://10.7.12.64:9080/") Then   'IP DESA
                            contenido = Regex.Replace(contenido, "http://10.7.12.64:9080/wsclavehost/services/autenticareg/wsdl/autenticareg.wsdl", "http://" & IPReplace & "/wsclavehost/services/autenticareg/wsdl/autenticareg.wsdl")
                        Else
                            If Regex.IsMatch(Contenido, "http://10.7.106.247/") Then  'IP CERTI
                                contenido = Regex.Replace(contenido, "http://10.7.106.247/wsclavehost/services/autenticareg/wsdl/autenticareg.wsdl", "http://" & IPReplace & "/wsclavehost/services/autenticareg/wsdl/autenticareg.wsdl")
                            Else
                                If Regex.IsMatch(Contenido, "http://10.7.10.53/") Then  'IP PROD
                                    contenido = Regex.Replace(contenido, "http://10.7.10.53/wsclavehost/services/autenticareg/wsdl/autenticareg.wsdl", "http://" & IPReplace & "/wsclavehost/services/autenticareg/wsdl/autenticareg.wsdl")
                                End If
                            End If
                        End If
                        Dim srArchwriter As StreamWriter
                        srArchwriter = File.CreateText(ListaArch(i).Item())
                        srarchwriter.Write(contenido)
                        srArchwriter.Close()

                    Case Is = "vb"
                        Dim srArhivo As StreamReader
                        srArhivo = File.OpenText(ListaArch(i).Item())
                        Dim contenido As String = srArhivo.ReadToEnd
                        srArhivo.Close()
                        If Regex.IsMatch(Contenido, "http://10.7.12.64:9080/") Then   'IP DESA
                            contenido = Regex.Replace(contenido, "http://10.7.12.64:9080/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                        Else
                            If Regex.IsMatch(Contenido, "http://10.7.106.247/") Then  'IP CERTI
                                contenido = Regex.Replace(contenido, "http://10.7.106.247/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                            Else
                                If Regex.IsMatch(Contenido, "http://10.7.10.53/") Then  'IP PROD
                                    contenido = Regex.Replace(contenido, "http://10.7.10.53/WSClaveHost/services/AutenticaReg", "http://" & IPReplace & "/WSClaveHost/services/AutenticaReg")
                                End If
                            End If
                        End If
                        Dim srArchwriter As StreamWriter
                        srArchwriter = File.CreateText(ListaArch(i).Item())
                        srarchwriter.Write(contenido)
                        srArchwriter.Close()
                End Select

            Next
            bEstado = True

        Catch ex As Exception
            strError = ex.Message
            bEstado = False

        End Try
        Return bEstado

    End Function

    Public Structure BNItem
        Public ID As String
        Public Item As String
        Sub New(ByVal sID As String, ByVal sItem As String)
            ID = sID
            Item = sItem
        End Sub
    End Structure


    Function GetEncryptedConnectionString(ByVal DataSource As String) As String
        Dim ConnectionString As String
        Dim DataXML As New DataTable
        Dim dvDataXML As DataView

        Try
            dvDataXML = New DataView(LeerFileXML("Configuration.XML"), "", "key", DataViewRowState.CurrentRows)
            Dim rowIndex As Integer = dvDataXML.Find("" & DataSource & "")
            ConnectionString = dvDataXML(rowIndex)("DATA").ToString()
        Catch ex As Exception
            ConnectionString = ""
        End Try

        Return ConnectionString
    End Function


    Function GetValoresControles(ByVal DataSource As String) As String
        Dim ConnectionString As String
        Dim DataXML As New DataTable
        Dim dvDataXML As DataView

        Try
            dvDataXML = New DataView(LeerFileXML("Configuration.XML"), "", "key", DataViewRowState.CurrentRows)
            Dim rowIndex As Integer = dvDataXML.Find("" & DataSource & "")
            ConnectionString = dvDataXML(rowIndex)("DATA").ToString()
        Catch ex As Exception
            ConnectionString = ""
        End Try

        Return ConnectionString
    End Function

    Public Function LeerFileXML(ByVal Archivo As String) As DataTable
        Try
            Dim dsArchivo As New DataSet
            Dim Ruta As String
            Ruta = AppPath(True) & Archivo
            '==============================================
            ' Archivos XML
            '==============================================
            ' 1) Archivo de Configuaracion : Configuration.xml

            dsArchivo.ReadXml(Ruta)
            Return dsArchivo.Tables(0)

        Catch ex As Exception
            Throw ex
        End Try

    End Function

#Region "[BN-Mostrar Ruta]"
    Public Function AppPath( _
            Optional ByVal backSlash As Boolean = False _
            ) As String
        Dim s As String = IO.Path.GetDirectoryName( _
                Reflection.Assembly.GetCallingAssembly.GetName.CodeBase.ToString)
        ' si hay que añadirle el backslash
        If backSlash Then
            s &= "\"
        End If
        Return s
    End Function

    Public Function DLLPath( _
            Optional ByVal backSlash As Boolean = False _
            ) As String
        Dim s As String = IO.Path.GetDirectoryName( _
                GetExecutingAssembly.GetName.CodeBase.ToString)
        ' si hay que añadirle el backslash
        If backSlash Then
            s &= "\"
        End If
        Return s
    End Function

#End Region
End Module
