Imports System.Web.Security


Public Class w_consform1


   Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

   'This call is required by the Web Form Designer.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

   End Sub
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
   Protected WithEvents lblTCAutomaticos As System.Web.UI.WebControls.Label
   Protected WithEvents lblTCCorresponsal As System.Web.UI.WebControls.Label
   Protected WithEvents lblTPuntosCaja As System.Web.UI.WebControls.Label
   Protected WithEvents lblTTarjetas As System.Web.UI.WebControls.Label
   Protected WithEvents txtTCAutomaticos As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTCCorresponsal As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTPuntosCaja As System.Web.UI.WebControls.TextBox
   Protected WithEvents dtgRegistro As System.Web.UI.WebControls.DataGrid
   Protected WithEvents txtTTarjetas As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
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

   Public Property Accion() As Integer
      Get
         Return Session("xAccion")
      End Get
      Set(ByVal Value As Integer)
         Session("xAccion") = Value
      End Set
   End Property
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
   Public Property AccionDetalle() As Integer
      Get
         Return Session("xAccionDetalle")
      End Get
      Set(ByVal Value As Integer)
         Session("xAccionDetalle") = Value
      End Set
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
   Public Property Contador() As Integer
      Get
         Return Session("xContador")
      End Get
      Set(ByVal Value As Integer)
         Session("xContador") = Value
      End Set
   End Property

#End Region
#Region "   * * * Carga de Controles - Combos * * *   "

   Public Property DTOperacion() As DataTable
      Get
         Return xOperacion
      End Get
      Set(ByVal Value As DataTable)
         xOperacion = Value
      End Set
   End Property

   Public Property DTTOperacion() As DataTable
      Get
         Return xTOperacion
      End Get
      Set(ByVal Value As DataTable)
         xTOperacion = Value
      End Set
   End Property

   Public Property DTEstado() As DataTable
      Get
         Return xEstado
      End Get
      Set(ByVal Value As DataTable)
         xEstado = Value
      End Set
   End Property




   Private Sub Cargar_Controles()
      Dim oDBSQL As New BNOperacion
      Dim dsControl As DataSet = oDBSQL.Get_FormFormato1(ErrMsg)
      Dim mintIndice As Integer

      DTOperacion = dsControl.Tables("Operacion")
      DTTOperacion = dsControl.Tables("TOperacion")
      DTEstado = dsControl.Tables("Estado")

      Me.cmbOperacion.DataSource = DTOperacion
      Me.cmbOperacion.DataValueField = DTOperacion.Columns(0).ColumnName
      Me.cmbOperacion.DataTextField = DTOperacion.Columns(1).ColumnName
      Me.cmbOperacion.DataBind()

      Me.cmbTOperacion.DataSource = DTTOperacion
      Me.cmbTOperacion.DataValueField = DTTOperacion.Columns(0).ColumnName
      Me.cmbTOperacion.DataTextField = DTTOperacion.Columns(1).ColumnName
      Me.cmbTOperacion.DataBind()

      Me.cmbEstado.DataSource = DTEstado
      Me.cmbEstado.DataValueField = DTEstado.Columns(0).ColumnName
      Me.cmbEstado.DataTextField = DTEstado.Columns(1).ColumnName
      Me.cmbEstado.DataBind()

      For mintIndice = 0 To 11
         cmbMes.Items.Add(NombreMes(mintIndice))
      Next

   End Sub



#End Region
   Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      If Session("xLogOnPerfil") Is Nothing Then
         FormsAuthentication.SignOut()
         Response.Redirect("PaginaSesionCaducada.htm")
      End If
      If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.REGISTRO_FORMULARIOS, 1) = "N" Then
         Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
      End If

      Me.txtAnno.Text = CStr(Year(Now()))

      Leer_Parametros()
      If Not Page.IsPostBack Then
         oLoad = True
         Obtener_Informacion_Formato1()

         Me.pnlGrilla.Visible = False
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
      '' Segunda Columna: Operación
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Operacion"
      dgBoundColumn.DataField = "Operacion"
      dgBoundColumn.ItemStyle.Width = New Unit(40, UnitType.Cm)
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
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Quinta Columna: Nro. Operaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Nro. Operaciones"
      dgBoundColumn.DataField = "NroOperaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)

      dtgRegistro.DataBind()
      dtgRegistro.Visible = True
   End Sub
#End Region



#Region "*** Interaccion BD ***"
  

  
   Private Sub Obtener_Informacion_Formato1()
      Dim oBDSQL As New BNOperacion
      Dim Periodo As String
      Dim Mes As String
      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Mes + Me.txtAnno.Text

      Try
         DSInfoRegistro = oBDSQL.Get_ConsFormato1(Periodo, ErrMsg)

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

         Me.txtTCAutomaticos.Text = dr.Item("TCajeroAutoma")
         Me.txtTCCorresponsal.Text = dr.Item("TCajeroCorresp")
         Me.txtTPuntosCaja.Text = dr.Item("TPuntoCaja")
         Me.txtTTarjetas.Text = dr.Item("TTarjetas")


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

  
   Private Sub SalirPagina()
      '   Response.Redirect("w_central.aspx")
   End Sub


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
#End Region


#Region "*** Controles ***"



   Private Sub lnkSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkSalir.Click
      Response.Redirect("w_central.aspx")
   End Sub
#End Region


   Private Sub cmdAceptaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptaP.Click
      If Me.txtAnno.Text = "" Then
         MsgBox1.ShowMessage("Debe ingresar el año a consultar")
         Return
      End If
      Obtener_Informacion_Formato1()
      Formato_Grilla_Registro()
      Me.pnlGrilla.Visible = True

      'If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then

      '   Mostrar_Informacion_Formato1()
      'Else
         MsgBox1.ShowMessage("No existen datos para el periodo seleccionado")

      cmdAceptar.Visible = True
      cmdAceptar.Text = "Grabar"
   
   End Sub


End Class
