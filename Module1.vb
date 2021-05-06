Imports System.Reflection.Assembly
Imports System.Xml
Imports System.IO
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.HttpRequest
Imports System.Web.HttpResponse
Imports System.Configuration
Imports System.Text.RegularExpressions

Module Module1

    Public vAMBIENTE As String = ConfigurationSettings.AppSettings("vRUTA_AMBIENTE")
    Public vSISTEMA As String = ConfigurationSettings.AppSettings("vSISTEMA")
    Public vCUENTA As String = ConfigurationSettings.AppSettings("vCUENTA")
    Public vSEMILLA As String = ConfigurationSettings.AppSettings("vSEMILLA")
    Public vRUTA_KEY_ARCHIVO As String = ConfigurationSettings.AppSettings("vRUTA_KEY_ARCHIVO") 'Físicamente existe en la pc
    Public vIDUSUARIO As String = ConfigurationSettings.AppSettings("vIDUSUARIO")
    Public vALIASGRUPO1 As String = ConfigurationSettings.AppSettings("vALIASGRUPO1")
    Public vALIASGRUPO2 As String = ConfigurationSettings.AppSettings("vALIASGRUPO2")
    Public vALIASGRUPO3 As String = ConfigurationSettings.AppSettings("vALIASGRUPO3")

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
        Dim fichero As String = vAMBIENTE
        Dim srAmbiente As New System.IO.StreamReader(fichero)
        Dim objStreamAmbiente As StreamReader

        Try
            StrError = ""
            '=================
            ' INSTANCIA DE COMPONENTES
            '=================
            'D:\ProyectosNET\HBPRDIntraPRAH\Web References\WSParametrosCOM_CERT\
            objStreamAmbiente = File.OpenText(fichero)
            Dim readAmbiente As String = objStreamAmbiente.ReadToEnd
            objStreamAmbiente.Close()
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
                    obj_InterfazKey = New WSParametrosCOM_PROD.ParametroInterfazKeyService
                    obj_SistemaPrm = New WSParametrosCOM_PROD.SistemaParametro

            End Select


            Dim srclave As New System.IO.StreamReader(vRUTA_KEY_ARCHIVO)
            Dim objStreamReader As StreamReader
            'open the file
            objStreamReader = File.OpenText(vRUTA_KEY_ARCHIVO)
            Dim readfile As String = objStreamReader.ReadToEnd
            Dim key_Archivo() As Byte = WSGetArray.GetArrayBytes(vRUTA_KEY_ARCHIVO)

            ' Dim key_Archivo() As Byte = File.ReadAllBytes("C:\opt\software\key\prah\clavesegurades.key")
            obj_SistemaPrm = obj_InterfazKey.datoParametroService( _
             vSISTEMA, _
             vCUENTA, _
             vSEMILLA, _
             key_Archivo, _
            vIDUSUARIO)
            objStreamReader.Close()

            Dim vValorsqlPW1, vValorsqlIP1, vValorsqlBD1, vValorsqlUser1 As String
            Dim vValorsqlPW2, vValorsqlIP2, vValorsqlBD2, vValorsqlUser2 As String
            Dim vValorClavesHost As String

            Select Case obj_SistemaPrm.proceso.codigo
                Case "00000" ' Caso Exito
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
                    cad_valor = obj_SistemaPrm.proceso.descripcion 'Ejem.:"SISTEMA NO REGISTRADO"
                    StrError = cad_valor
                    bEstado = False
                    ' LblAcceso.Text = "-0010 - Sistema No Registrado"
                    Exit Function
                Case "-0024" 'Caso clave inválido
                    cad_valor = obj_SistemaPrm.proceso.descripcion 'Ejem.:"LA CLAVE ES INCORRECTA, VERIFICAR MAYUSCULAS Y MINUSCULAS"
                    StrError = cad_valor
                    ' LblAcceso.Text = "-0024 - La clave es incorrecta,verificar mayúsculas y minúsculas"
                    bEstado = False
                    Exit Function

                Case Else
                    cad_valor = "{---no especificado---}"
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

        Catch ex As Exception
            StrError = cad_valor & "|" & ex.Message()
        End Try

        Return bEstado

    End Function

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
End Module
