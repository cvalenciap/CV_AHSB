Imports System.Web.Security
Imports System.IO
Imports System.Text

Public Class w_consolidado1


   Inherits System.Web.UI.Page
   Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
   Const sCOM_CHAR_IZQUIERDO As String = "["
   Const sCOM_CHAR_DERECHO As String = "]"
   Const sCOM_CHAR_DERECHOGUION As String = "]-"
   Const sCOM_CHAR_SEPARADOR As String = "/"
   Dim sNombreClase = "w_consolidado1"
#Region " Web Form Designer Generated Code "

   'This call is required by the Web Form Designer.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
   Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
   Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton
   Protected WithEvents lblPeriodo As System.Web.UI.WebControls.Label
   Protected WithEvents lblFuncionario As System.Web.UI.WebControls.Label
   Protected WithEvents lblCodBCR As System.Web.UI.WebControls.Label
   Protected WithEvents lblNormativa As System.Web.UI.WebControls.Label
   Protected WithEvents cmbMes As System.Web.UI.WebControls.DropDownList
   Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblaCodBCR As System.Web.UI.WebControls.Label
   Protected WithEvents lblaNormativa As System.Web.UI.WebControls.Label
   Protected WithEvents MsgBox1 As MsgBox.MsgBox
   Protected WithEvents pnlGrilla As System.Web.UI.WebControls.Panel
   Protected WithEvents cmdAceptaP As System.Web.UI.WebControls.Button
   Protected WithEvents lblaFuncionario As System.Web.UI.WebControls.Label
   Protected WithEvents cmdAceptar As System.Web.UI.WebControls.Button
   Protected WithEvents pnlDetalle As System.Web.UI.WebControls.Panel
   Protected WithEvents dtgRegistro As System.Web.UI.WebControls.DataGrid
   Protected WithEvents dtgDetalle As System.Web.UI.WebControls.DataGrid
   Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
   Protected WithEvents lblOficina As System.Web.UI.WebControls.Label
   Protected WithEvents txtTClientes As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTClientes As System.Web.UI.WebControls.Label
   Protected WithEvents txtTLCredito As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTLCredito As System.Web.UI.WebControls.Label
   Protected WithEvents lblTCAutomaticos As System.Web.UI.WebControls.Label
   Protected WithEvents txtTCAutomaticos As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTCCorresponsal As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTCCorresponsal As System.Web.UI.WebControls.Label
   Protected WithEvents lblTPuntosCaja As System.Web.UI.WebControls.Label
   Protected WithEvents txtTPuntosCaja As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTTarjetas As System.Web.UI.WebControls.Label
   Protected WithEvents txtTTarjetas As System.Web.UI.WebControls.TextBox
   'NOTE: The following placeholder declaration is required by the Web Form Designer.
   'Do not delete or move it.
   Private designerPlaceholderDeclaration As System.Object

   Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
      'CODEGEN: This method call is required by the Web Form Designer
      'Do not modify it using the code editor.
      InitializeComponent()
      Cargar_Controles()
   End Sub

#End Region
   Private ErrMsg As String




#Region "   * * * Variables Generales * * *   "

   
   Private ReadOnly Property CodUsuario() As String
      Get
         Return Session("xCodTrabajador")
      End Get
   End Property
   Private ReadOnly Property Coficina() As String
      Get
         Return Session("xCodDependencia")
      End Get
   End Property
   Private ReadOnly Property Dependencia() As String
      Get
         Return Session("xDepTrabajador")
      End Get
   End Property
   Public Property DSInfoRegistro() As DataSet
      Get
         Return Session("xInfoRegistro")
      End Get
      Set(ByVal Value As DataSet)
         Session("xInfoRegistro") = Value
      End Set
   End Property

   Public Property oLoad() As Boolean
      Get
         Return Session("xLoad")
      End Get
      Set(ByVal Value As Boolean)
         Session("xLoad") = Value
      End Set
   End Property

   Public Property Periodo() As Integer
      Get
         Return Session("xPeriodo")
      End Get
      Set(ByVal Value As Integer)
         Session("xPeriodo") = Value
      End Set
   End Property
   Public Property DSInfoOficina() As DataSet
      Get
         Return Session("xInfoOficina")
      End Get
      Set(ByVal Value As DataSet)
         Session("xInfoOficina") = Value
      End Set
   End Property
   Public Property TCajeroAutoma() As Integer
      Get
         Return Session("xTCajeroAutoma")
      End Get
      Set(ByVal Value As Integer)
         Session("xTCajeroAutoma") = Value
      End Set
   End Property
   Public Property TCajeroCorresp() As Integer
      Get
         Return Session("xTCajeroCorresp")
      End Get
      Set(ByVal Value As Integer)
         Session("xTCajeroCorresp") = Value
      End Set
   End Property
   Public Property TPuntoCaja() As Integer
      Get
         Return Session("xTPuntoCaja")
      End Get
      Set(ByVal Value As Integer)
         Session("xTPuntoCaja") = Value
      End Set
   End Property
   Public Property TTarjetas() As Integer
      Get
         Return Session("xTTarjetas")
      End Get
      Set(ByVal Value As Integer)
         Session("xTTarjetas") = Value
      End Set
   End Property
   Public Property TLCredito() As Integer
      Get
         Return Session("xTLCredito")
      End Get
      Set(ByVal Value As Integer)
         Session("xTLCredito") = Value
      End Set
   End Property
   Public Property TClientes() As Integer
      Get
         Return Session("xTClientes")
      End Get
      Set(ByVal Value As Integer)
         Session("xTClientes") = Value
      End Set
   End Property
#End Region
#Region "   * * * Carga de Controles - Combos * * *   "


   Private Sub Cargar_Controles()
      Dim mintIndice As Integer

      For mintIndice = 0 To 11
         cmbMes.Items.Add(NombreMes(mintIndice))
      Next

   End Sub



#End Region
   Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      If Session("xLogOnPerfil") Is Nothing Then
         FormsAuthentication.SignOut()
            Response.Redirect("w_PaginaSesionCaducada.aspx")
      End If
      If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.CONSULTAS, 1) = "N" Then
         Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
      End If


      Leer_Parametros()
      If Not Page.IsPostBack Then
         Me.txtAnno.Text = CStr(Year(Now()))
         oLoad = True
         Obtener_Informacion_Formato1()
         Me.pnlDetalle.Enabled = True
         Me.pnlGrilla.Visible = False
         Me.Panel1.Visible = False
         cmdAceptar.Visible = False
      End If

      Formato_Grilla_Registro()
   End Sub

#Region "*** Formato Grilla Registro ****"

   Private Sub Formato_Grilla_Registro()
      '    Me.pnlGrilla.Enabled = True

      dtgRegistro.Columns.Clear()
      dtgRegistro.DataSource = DSInfoRegistro.Tables("InfoRegistro_Detalle")
      dtgRegistro.AutoGenerateColumns = False
      dtgRegistro.AllowPaging = False

      Dim dgBoundColumn As BoundColumn
      Dim dgButtonColumn As ButtonColumn
      ''============================================================
      '' Primera Columna: Selector de Fila
      ''============================================================
      dgButtonColumn = New ButtonColumn
      dgButtonColumn.ButtonType = ButtonColumnType.LinkButton
      dgButtonColumn.HeaderText = "Selección"
      dgButtonColumn.Text = "==>"
      dgButtonColumn.CommandName = "Select"
      dtgRegistro.Columns.Add(dgButtonColumn)
      ''============================================================
      '' Primera Columna: Periodo
      ''============================================================
      ''dgBoundColumn = New BoundColumn
      ''dgBoundColumn.HeaderText = "Periodo"
      ''dgBoundColumn.DataField = "Periodo"
      ''dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      ''dtgRegistro.Columns.Add(dgBoundColumn)
      ''dgBoundColumn.Visible = False
      ''============================================================
      '' Segunda Columna: Operación
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Operacion"
      dgBoundColumn.DataField = "Operacion"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Tercera Columna: Tipo Operacion
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Tipo"
      dgBoundColumn.DataField = "TOperacion"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Estado
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Estado"
      dgBoundColumn.DataField = "Estado"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Quinta Columna: Nro. Operaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Nro. Operaciones"
      dgBoundColumn.DataField = "NroOperaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N0}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Sexta Columna: Observaciones
      ''============================================================
      'dgBoundColumn = New BoundColumn
      'dgBoundColumn.HeaderText = "Observaciones"
      'dgBoundColumn.DataField = "Observaciones"
      'dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      'dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Septima Columna: Dependencia
      ''============================================================
      'dgBoundColumn = New BoundColumn
      'dgBoundColumn.HeaderText = "Dependencia"
      'dgBoundColumn.DataField = "Dependencia"
      'dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      'dtgRegistro.Columns.Add(dgBoundColumn)


      dtgRegistro.DataBind()
      dtgRegistro.Visible = True
   End Sub




   Private Sub Formato_Grilla_Detalle()
      '    Me.pnlGrilla.Enabled = True

      dtgDetalle.Columns.Clear()
      dtgDetalle.DataSource = DSInfoOficina.Tables("InfoOficina")
      dtgDetalle.AutoGenerateColumns = False
      dtgDetalle.AllowPaging = False

      Dim dgBoundColumn As BoundColumn
      Dim dgButtonColumn As ButtonColumn
      ''============================================================
      '' Primera Columna: Selector de Fila
      ''============================================================
      dgButtonColumn = New ButtonColumn
      dgButtonColumn.ButtonType = ButtonColumnType.LinkButton
      dgButtonColumn.HeaderText = "Selección"
      dgButtonColumn.Text = "==>"
      dgButtonColumn.CommandName = "Select"
      dtgDetalle.Columns.Add(dgButtonColumn)
      '============================================================
      ' Segunda Columna: Dependencia
      '============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Dependencia"
      dgBoundColumn.DataField = "Dependencia"
      dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Tercera Columna: Nro. Operaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Nro. Operaciones"
      dgBoundColumn.DataField = "NroOperaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N0}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgDetalle.Columns.Add(dgBoundColumn)
      '============================================================
      ' Cuarta Columna: Observaciones
      '============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Observaciones"
      dgBoundColumn.DataField = "Observaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)


      dtgDetalle.DataBind()
      dtgDetalle.Visible = True
   End Sub
#End Region



#Region "   * * * Interacción con los Botones de Control * * *   "

   Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
      'Dim ruta As String = "C:\ARCHIVO"
      Dim ruta As String
      Dim wruta As String = ""

      ruta = Page.MapPath("FileTmp")

      Dim bExisteArchivo As Boolean
      Dim bExisteBackup As Boolean
      Dim strtrama As String
      Dim NReporte As String = "01"
      Dim dr As DataRow



      Dim Periodo As String
      Dim Mes As String
      Dim Funcionario As String
      Dim Completa As Integer = 50

      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Me.txtAnno.Text + Mes
      Funcionario = Trim(Me.lblaFuncionario.Text)
      Completa = Completa - Len(Funcionario)
      Funcionario = Funcionario & StrDup(Completa, " ")

      Dim Bnlog As New BNOperacion
      Dim sNombreMetodo = "Genera Consolidado"
      Try

         Dim archivo_fin = "\" & Me.lblaCodBCR.Text & Me.lblaNormativa.Text & NReporte & Periodo & ".txt"
      '  Dim archivo As String = ruta & "\" & Me.lblaCodBCR.Text & Me.lblaNormativa.Text & NReporte & Periodo & ".txt"
         Dim archivo As String = ruta & archivo_fin

         Dim I As Integer = 0
      For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows

         Dim fsBackup As FileStream
         Dim swBackup As StreamWriter

         I += 1

         '---- Escribe Cabecera ----'
         If I = 1 Then
            fsBackup = New FileStream(archivo, FileMode.Create)
                    'swBackup = New StreamWriter(fsBackup)
                    swBackup = New StreamWriter(fsBackup, System.Text.Encoding.Default)

            strtrama = Me.lblaCodBCR.Text & Me.lblaNormativa.Text & NReporte & Periodo & CompletaCeros(TCajeroAutoma, 10) _
                        & CompletaCeros(TCajeroCorresp, 10) & CompletaCeros(TPuntoCaja, 10) & CompletaCeros(TTarjetas, 18) _
                        & CompletaCeros(TLCredito, 10) & CompletaCeros(TClientes, 18) & Funcionario



            swBackup.WriteLine(strtrama)
            swBackup.Close()
            fsBackup.Close()
            fsBackup = Nothing
            swBackup = Nothing

         End If
         '---- Escribe Detalle ----'
         'bExisteBackup = IIf(System.IO.File.Exists(ruta), True, False)
         bExisteBackup = IIf(System.IO.File.Exists(archivo), True, False)
         If bExisteBackup Then ' VISA1 COMO VISA8
            fsBackup = New FileStream(archivo, FileMode.Append)
            ' fsBackup = New FileStream(ruta & "\RPT006_POSVENTASINTERNACIONAL.txt", FileMode.Append)
         Else
            fsBackup = New FileStream(archivo, FileMode.Create)
            ' fsBackup = New FileStream(ruta & "\RPT006_POSVENTASINTERNACIONAL.txt", FileMode.Create)
         End If
                'swBackup = New StreamWriter(fsBackup)
                '03/01 txt formato ANSI
                swBackup = New StreamWriter(fsBackup, System.Text.Encoding.Default)

         strtrama = dr.Item("IdOperacion") & dr.Item("IdEstado") & dr.Item("IdTOperacion") _
                    & CompletaCeros(dr.Item("NroOperaciones").ToString, 10) & StrDup(200, " ")

         swBackup.WriteLine(strtrama)
         swBackup.Close()
         fsBackup.Close()
         fsBackup = Nothing
         swBackup = Nothing

      Next
         MsgBox1.ShowMessage("Archivo Generado")

         Response.ContentType = "text/plain"
         Response.AppendHeader("Content-Disposition", "attachment; filename=" & archivo_fin)
         Response.TransmitFile(Server.MapPath("FileTmp" & archivo_fin))
         Response.End()

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
         Bnlog.CrearLogTXT(sCOM_CHAR_IZQUIERDO & _
                      Format(Now, "yyyy/MM/dd HH:mm:ss") & _
                      sCOM_DESC_EXCEPCION & _
                      sNombreClase & sCOM_CHAR_SEPARADOR & _
                      sNombreMetodo & sCOM_CHAR_DERECHOGUION & _
                      sCOM_CHAR_IZQUIERDO & "ERROR-" & sCOM_CHAR_SEPARADOR & " " & ex.Message & sCOM_CHAR_DERECHO)
      End Try
   End Sub


#End Region
#Region "*** Interaccion BD ***"
   Private Sub EjecutarProceso()

   End Sub


   Private Sub Obtener_Informacion_Formato1()
      Dim oBDSQL As New BNOperacion
      Dim Periodo As String
      Dim Mes As String
      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Mes + Me.txtAnno.Text

      Try
         DSInfoRegistro = oBDSQL.Get_InfoConsolidadoF1(Periodo, ErrMsg)

      Catch ex As Exception
         MsgBox1.ShowMessage(ErrMsg)
      End Try

   End Sub
   Private Sub Mostrar_Informacion_Formato1()

      'If ID_Registro = 0 Then Exit Sub

      Try

         'Dim dr As DataRow = DSInfoRegistro.Tables("InfoFormato1_Detalle").Rows(0)

         Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_General").Rows(0)
         '===========================================================================
         ' 1ro) Panel de Información General
         '===========================================================================

         Me.txtTCAutomaticos.Text = Format(dr.Item("TCajeroAutoma"), "##,###,##0")
         Me.txtTCCorresponsal.Text = Format(dr.Item("TCajeroCorresp"), "##,###,##0")
         Me.txtTPuntosCaja.Text = Format(dr.Item("TPuntoCaja"), "##,###,##0")
         Me.txtTTarjetas.Text = Format(dr.Item("TTarjetas"), "##,###,##0")
         Me.txtTLCredito.Text = Format(dr.Item("TLCredito"), "##,###,##0")
         Me.txtTClientes.Text = Format(dr.Item("TClientes"), "##,###,##0")
         TCajeroAutoma = dr.Item("TCajeroAutoma")
         TCajeroCorresp = dr.Item("TCajeroCorresp")
         TPuntoCaja = dr.Item("TPuntoCaja")
         TTarjetas = dr.Item("TTarjetas")
         TLCredito = dr.Item("TLCredito")
         TClientes = dr.Item("TClientes")

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub

   Private Sub Leer_Parametros()
      Dim oDBSQL As New BNOperacion
      Dim dtParametro As DataTable

      dtParametro = oDBSQL.Leer_Parametros(ErrMsg)

      Me.lblaCodBCR.Text = dtParametro.Rows(0).Item("CodBCR").ToString
      Me.lblaNormativa.Text = dtParametro.Rows(0).Item("Normativa").ToString
      Me.lblaFuncionario.Text = dtParametro.Rows(0).Item("Funcionario").ToString

   End Sub
#End Region



#Region "********* Rutinas Diversas ********"




   '*--------------------------------------------------
   '* Función : NombreMes  (Devuelve el Nombre del Mes)
   '*--------------------------------------------------
   Public Function NombreMes(ByVal NumMes As Integer) As String
      Dim Mes(12)
      Dim diafin As String

      Mes(0) = "Enero"
      Mes(1) = "Febrero"
      Mes(2) = "Marzo"
      Mes(3) = "Abril"
      Mes(4) = "Mayo"
      Mes(5) = "Junio"
      Mes(6) = "Julio"
      Mes(7) = "Agosto"
      Mes(8) = "Setiembre"
      Mes(9) = "Octubre"
      Mes(10) = "Noviembre"
      Mes(11) = "Diciembre"
      Select Case NumMes
         Case 0
            NombreMes = Mes(0)
         Case 1
            NombreMes = Mes(1)
         Case 2
            NombreMes = Mes(2)
         Case 3
            NombreMes = Mes(3)
         Case 4
            NombreMes = Mes(4)
         Case 5
            NombreMes = Mes(5)
         Case 6
            NombreMes = Mes(6)
         Case 7
            NombreMes = Mes(7)
         Case 8
            NombreMes = Mes(8)
         Case 9
            NombreMes = Mes(9)
         Case 10
            NombreMes = Mes(10)
         Case 11
            NombreMes = Mes(11)
      End Select
   End Function


   Public Function FormatImp(ByVal importe As String) As String

      Dim cadenaImporte As String = ""

      If Contiene(importe) Then

         Dim arrayImporte As String() = importe.Split(".")
         If arrayImporte(1).Length = 0 Then
            arrayImporte(1) = "00"
         End If

         If arrayImporte(1).Length = 1 Then
            arrayImporte(1) = arrayImporte(1) & "0"
         End If

         cadenaImporte = arrayImporte(0) & "." & arrayImporte(1)

      Else
         If importe = "" Then
            cadenaImporte = "0.00"
         Else
            cadenaImporte = importe & ".00"
         End If

      End If


      cadenaImporte = cadenaImporte.Replace(".", "")
      cadenaImporte = CompletaCeros(cadenaImporte, 18)
      Return cadenaImporte
   End Function



   Public Function Contiene(ByVal cadena As String) As Boolean

      Dim arreglo As String() = cadena.Split(".")
      Dim flag As Boolean = False

      If arreglo.Length > 1 Then
         flag = True
      End If
      Return flag
   End Function


   'Public Function CompletaCeros(ByVal Importe As String) As String

   '   Dim x As Integer = 0
   '   Dim longuitud As Integer = 15
   '   Dim cantCeros As Integer = 15 - Importe.Length
   '   Dim ceros As String
   '   Dim cadena As String
   '   For x = 1 To cantCeros
   '      ceros = ceros & "0"
   '   Next
   '   cadena = ceros & Importe
   '   Return cadena
   'End Function
   Public Function CompletaCeros(ByVal Importe As String, ByVal Longitud As Integer) As String

      Dim x As Integer = 0
      'Dim longuitud As Integer = 15
      Dim cantCeros As Integer = Longitud - Importe.Length
      Dim ceros As String
      Dim cadena As String
      For x = 1 To cantCeros
         ceros = ceros & "0"
      Next
      cadena = ceros & Importe
      Return cadena
   End Function

#End Region


#Region "*** Controles ***"

   Private Sub lnkSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkSalir.Click
      Response.Redirect("w_central.aspx")
   End Sub
#End Region


   Private Sub cmdAceptaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptaP.Click
      cmdAceptar.Visible = False
      If Me.txtAnno.Text = "" Then
         MsgBox1.ShowMessage("Debe ingresar el año del periodo a consultar")
         Return
      End If

      Me.pnlDetalle.Enabled = True
      Obtener_Informacion_Formato1()
      Formato_Grilla_Registro()
      Me.pnlGrilla.Visible = True

      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then
         'Registro Existe
         Mostrar_Informacion_Formato1()
         cmdAceptar.Visible = True
      Else
         MsgBox1.ShowMessage("No existen datos para el periodo ingresado")

      End If



   End Sub


   Private Sub dtgRegistro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgRegistro.SelectedIndexChanged
      Dim iFila As Integer
      Dim ID_Dato As Integer
      Dim Id_Periodo As String
      Dim Id_Operacion As Integer
      Dim Id_TOperacion As Integer
      Dim Id_Estado As Integer
      Dim oBDSQL As New BNOperacion

      Dim oitem As DataGridItem
      Dim URL As String

      oitem = Me.dtgRegistro.SelectedItem

      iFila = Me.dtgRegistro.SelectedIndex
      Id_Periodo = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2) + Me.txtAnno.Text
      Id_Operacion = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdOperacion")
      Id_TOperacion = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdTOperacion")
      Id_Estado = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdEstado")


      DSInfoOficina = oBDSQL.Get_InfoOficinaF1(Id_Periodo, Id_Operacion, Id_TOperacion, Id_Estado, ErrMsg)
      If DSInfoOficina.Tables("InfoOficina").Rows.Count > 0 Then
         Me.Panel1.Visible = True
         Me.lblOficina.Visible = False
         Formato_Grilla_Detalle()
         Me.dtgDetalle.Visible = True

      End If



   End Sub

   Private Sub dtgDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgDetalle.SelectedIndexChanged
      Me.Panel1.Visible = False
      Me.dtgDetalle.Visible = False
      Me.lblOficina.Visible = False

   End Sub
End Class
