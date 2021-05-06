Imports System.Web.Security


Public Class w_formulario4


   Inherits System.Web.UI.Page

   Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
   Const sCOM_CHAR_IZQUIERDO As String = "["
   Const sCOM_CHAR_DERECHO As String = "]"
   Const sCOM_CHAR_DERECHOGUION As String = "]-"
   Const sCOM_CHAR_SEPARADOR As String = "/"

   Dim sNombreClase = "w_formulario4"
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
   Protected WithEvents cmdNuevo As System.Web.UI.WebControls.Button
   Protected WithEvents cmdModificar As System.Web.UI.WebControls.Button
   Protected WithEvents cmdAceptar As System.Web.UI.WebControls.Button
   Protected WithEvents cmdEliminar As System.Web.UI.WebControls.Button
   Protected WithEvents cmdCancelar As System.Web.UI.WebControls.Button
   Protected WithEvents pnlDetalle As System.Web.UI.WebControls.Panel
   Protected WithEvents lblObservaciones As System.Web.UI.WebControls.Label
   Protected WithEvents txtObservaciones As System.Web.UI.WebControls.TextBox
   Protected WithEvents cmdAgrega As System.Web.UI.WebControls.Button
   Protected WithEvents cmdElimina As System.Web.UI.WebControls.Button
   Protected WithEvents dtgRegistro As System.Web.UI.WebControls.DataGrid
   Protected WithEvents lblCliente As System.Web.UI.WebControls.Label
   Protected WithEvents lblTCliente As System.Web.UI.WebControls.Label
   Protected WithEvents cmbTCliente As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblMontoMin As System.Web.UI.WebControls.Label
   Protected WithEvents lblMontoMax As System.Web.UI.WebControls.Label
   Protected WithEvents lblMoneda As System.Web.UI.WebControls.Label
   Protected WithEvents cmbMoneda As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblTasa As System.Web.UI.WebControls.Label
   Protected WithEvents Textbox1 As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblPlaza As System.Web.UI.WebControls.Label
   Protected WithEvents cmbPlaza As System.Web.UI.WebControls.DropDownList
   Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
   Protected WithEvents lblComisV As System.Web.UI.WebControls.Label
   Protected WithEvents txtComisV As System.Web.UI.WebControls.TextBox
   Protected WithEvents CompareValidator4 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents Label1 As System.Web.UI.WebControls.Label
   Protected WithEvents Label2 As System.Web.UI.WebControls.Label
   Protected WithEvents Label3 As System.Web.UI.WebControls.Label
   Protected WithEvents Label4 As System.Web.UI.WebControls.Label
   Protected WithEvents Label5 As System.Web.UI.WebControls.Label
   Protected WithEvents Label6 As System.Web.UI.WebControls.Label
   Protected WithEvents Label7 As System.Web.UI.WebControls.Label
   Protected WithEvents Label8 As System.Web.UI.WebControls.Label
   Protected WithEvents Label9 As System.Web.UI.WebControls.Label
   Protected WithEvents Label10 As System.Web.UI.WebControls.Label
   Protected WithEvents Label11 As System.Web.UI.WebControls.Label
   Protected WithEvents Label13 As System.Web.UI.WebControls.Label
   Protected WithEvents Label14 As System.Web.UI.WebControls.Label
   Protected WithEvents Label15 As System.Web.UI.WebControls.Label
   Protected WithEvents Label16 As System.Web.UI.WebControls.Label
   Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator2 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator3 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator5 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator9 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator10 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator11 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator12 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator13 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator14 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator15 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator16 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents Label12 As System.Web.UI.WebControls.Label
   Protected WithEvents txtMontoMinV As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMaxV As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMinCA As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMaxCA As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMinI As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMaxI As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMinO As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtMontoMaxO As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTasaV As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTasaCA As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtComisCA As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTasaI As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtComisI As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTasaO As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtComisO As System.Web.UI.WebControls.TextBox
   Protected WithEvents CompareValidator6 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator7 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator8 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents lblIndx As System.Web.UI.WebControls.Label
   Protected WithEvents lblOperacion As System.Web.UI.WebControls.Label
   Protected WithEvents cmbOperacion As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblCCobro As System.Web.UI.WebControls.Label
   Protected WithEvents cmbConcepto As System.Web.UI.WebControls.DropDownList
   Protected WithEvents cmbCliente As System.Web.UI.WebControls.DropDownList
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
   Private xTCliente As DataTable
   Private xMoneda As DataTable
   Private xCliente As DataTable
   Private xPlaza As DataTable
   Private xConcepto As DataTable
   Private xOperacion As DataTable


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

   Public Property DTTCliente() As DataTable
      Get
         Return xTCliente
      End Get
      Set(ByVal Value As DataTable)
         xTCliente = Value
      End Set
   End Property
   Public Property DTMoneda() As DataTable
      Get
         Return xMoneda
      End Get
      Set(ByVal Value As DataTable)
         xMoneda = Value
      End Set
   End Property

   Public Property DTConcepto() As DataTable
      Get
         Return xConcepto
      End Get
      Set(ByVal Value As DataTable)
         xConcepto = Value
      End Set
   End Property
   Public Property DTPlaza() As DataTable
      Get
         Return xPlaza
      End Get
      Set(ByVal Value As DataTable)
         xPlaza = Value
      End Set
   End Property
   Public Property DTOperacion() As DataTable
      Get
         Return xOperacion
      End Get
      Set(ByVal Value As DataTable)
         xOperacion = Value
      End Set
   End Property

   Public Property DTCliente() As DataTable
      Get
         Return xCliente
      End Get
      Set(ByVal Value As DataTable)
         xCliente = Value
      End Set
   End Property
   Private Sub Cargar_Controles()
      Dim oDBSQL As New BNOperacion
      Dim dsControl As DataSet = oDBSQL.Get_FormFormato4(ErrMsg)
      Dim mintIndice As Integer

      DTTCliente = dsControl.Tables("TCliente")
      DTMoneda = dsControl.Tables("Moneda")
      DTPlaza = dsControl.Tables("Plaza")
      DTConcepto = dsControl.Tables("Concepto")
      DTOperacion = dsControl.Tables("Operacion")
      DTCliente = dsControl.Tables("Cliente")

      Me.cmbTCliente.DataSource = DTTCliente
      Me.cmbTCliente.DataValueField = DTTCliente.Columns(0).ColumnName
      Me.cmbTCliente.DataTextField = DTTCliente.Columns(1).ColumnName
      Me.cmbTCliente.DataBind()

      Me.cmbMoneda.DataSource = DTMoneda
      Me.cmbMoneda.DataValueField = DTMoneda.Columns(0).ColumnName
      Me.cmbMoneda.DataTextField = DTMoneda.Columns(1).ColumnName
      Me.cmbMoneda.DataBind()

      Me.cmbConcepto.DataSource = DTConcepto
      Me.cmbConcepto.DataValueField = DTConcepto.Columns(0).ColumnName
      Me.cmbConcepto.DataTextField = DTConcepto.Columns(1).ColumnName
      Me.cmbConcepto.DataBind()

      Me.cmbPlaza.DataSource = DTPlaza
      Me.cmbPlaza.DataValueField = DTPlaza.Columns(0).ColumnName
      Me.cmbPlaza.DataTextField = DTPlaza.Columns(1).ColumnName
      Me.cmbPlaza.DataBind()

      Me.cmbOperacion.DataSource = DTOperacion
      Me.cmbOperacion.DataValueField = DTOperacion.Columns(0).ColumnName
      Me.cmbOperacion.DataTextField = DTOperacion.Columns(1).ColumnName
      Me.cmbOperacion.DataBind()

      Me.cmbCliente.DataSource = DTCliente
      Me.cmbCliente.DataValueField = DTCliente.Columns(0).ColumnName
      Me.cmbCliente.DataTextField = DTCliente.Columns(1).ColumnName
      Me.cmbCliente.DataBind()
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
      If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.REGISTRO_FORMULARIOS, 1) = "N" Then
         Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
      End If

        Me.lnkSalir.Attributes.Add("onClick", "setGoodLink();")

      Leer_Parametros()
      If Not Page.IsPostBack Then
         Me.txtAnno.Text = CStr(Year(Now()))
         oLoad = True
         Obtener_Informacion_Formato4()
         Me.Panel1.Enabled = False
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
      dgButtonColumn.HeaderText = "Sel"
      dgButtonColumn.Text = "==>"
      dgButtonColumn.CommandName = "Select"
      dtgRegistro.Columns.Add(dgButtonColumn)
     
      ''============================================================
      '' Segunda Columna: Tipo Cliente
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TCliente"
      dgBoundColumn.DataField = "TCliente"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Quinta Columna: Operacion
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Operacion"
      dgBoundColumn.DataField = "Operacion"
      dgBoundColumn.ItemStyle.Width = New Unit(15, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Quinta Columna: Concepto Cobro
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Concepto"
      dgBoundColumn.DataField = "Concepto"
      dgBoundColumn.ItemStyle.Width = New Unit(15, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Moneda
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Moneda"
      dgBoundColumn.DataField = "Moneda"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Septima Columna: Plaza
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Plaza"
      dgBoundColumn.DataField = "Plaza"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Quinta Columna:Cliente
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Cliente"
      dgBoundColumn.DataField = "Cliente"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Octava Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaV"
      dgBoundColumn.DataField = "sTasaV"
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinV"
      dgBoundColumn.DataField = "sMMinimoV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxV"
      dgBoundColumn.DataField = "sMMaximoV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaV"
      dgBoundColumn.DataField = "sComFijaV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Octava Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaCA"
      dgBoundColumn.DataField = "sTasaCA"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinCA"
      dgBoundColumn.DataField = "sMMinimoCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxCA"
      dgBoundColumn.DataField = "sMMaximoCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaCA"
      dgBoundColumn.DataField = "sComFijaCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Octava Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaI"
      dgBoundColumn.DataField = "sTasaI"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinI"
      dgBoundColumn.DataField = "sMMinimoI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxI"
      dgBoundColumn.DataField = "sMMaximoI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaI"
      dgBoundColumn.DataField = "sComFijaI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Octava Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaO"
      dgBoundColumn.DataField = "sTasaO"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinO"
      dgBoundColumn.DataField = "sMMinimoO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxO"
      dgBoundColumn.DataField = "sMMaximoO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaO"
      dgBoundColumn.DataField = "sComFijaO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Onceava Columna: Observaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Observaciones"
      dgBoundColumn.DataField = "Observaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(30, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Doceava Columna: Dependencia
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Dependencia"
      dgBoundColumn.DataField = "Dependencia"
      dgBoundColumn.ItemStyle.Width = New Unit(15, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Septima Columna: Dependencia
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Usuario"
      dgBoundColumn.DataField = "Usuario"
      dgBoundColumn.ItemStyle.Width = New Unit(30, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)



      dtgRegistro.DataBind()
      dtgRegistro.Visible = True
   End Sub
#End Region



#Region "   * * * Interacción con los Botones de Control * * *   "

   Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

      '===========================================================================
      ' Campos Requeridos
      '===========================================================================

      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
         MsgBox1.ShowMessage("No ha registrado ninguna operación")
         Exit Sub
      End If
      '--------------------------------------------------------------------
      Dim msgAccionEvento As String
      Select Case Accion
         Case 1
            msgAccionEvento = "Esta seguro de Grabar el Nuevo Ingreso?"
         Case 2
            msgAccionEvento = "Esta seguro de Modificar el Registro?"
         Case 3
            msgAccionEvento = "Esta seguro de Eliminar el Registro?"

      End Select

      MsgBox1.ShowConfirmation(msgAccionEvento, _
                                   "GRABAR", True, True)


   End Sub



   Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
      If Accion > 1 Then
         ' cmdModificar.Visible = True
         ' cmdEliminar.Visible = True
         cmdAceptar.Visible = False
         cmdCancelar.Visible = False

      End If
      Panel1.Enabled = False


      Limpiar_Controles_Detalle()

      Me.DSInfoRegistro.Clear()
      dtgRegistro.DataSource = Nothing
      dtgRegistro.DataBind()
      'Cargar_Controles()


   End Sub


   Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Accion = 3
      cmdNuevo.Visible = False
      cmdModificar.Visible = False
      cmdEliminar.Visible = False
      cmdAceptar.Visible = True
      cmdAceptar.Text = "SI"
      cmdCancelar.Visible = True
      cmdCancelar.Text = "NO"
   End Sub

   Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Accion = 2
      cmdNuevo.Visible = False
      cmdModificar.Visible = False
      cmdEliminar.Visible = False
      cmdAceptar.Visible = True
      cmdAceptar.Text = "Grabar"
      cmdCancelar.Visible = True
      cmdCancelar.Text = "Cancelar"
      pnlDetalle.Enabled = True

   End Sub

#End Region
#Region "*** Interaccion BD ***"
   Private Sub EjecutarProceso()
      '-- Valores Fijos para Ingreso ---
      'Dim IdTMovimiento As String = "I"
      Dim nReporte As Integer = 4


      Dim dr As DataRow
      Dim oDBSQL As New BNOperacion
      Dim MensajeTermino As String
      Dim sender As System.Object
      Dim e As System.EventArgs

      Dim CodBCR As String
      Dim Normativa As String
      Dim Funcionario As String
      Dim Periodo As String

      'Dim Coficina As String
      '----

      'CodUsuario = "0293784"
      'Coficina = "0002"

      '----
      Try
         '===========================================================================
         'Carga de Variables/Parametros en Memoria para enviar a la BD
         '===========================================================================


         '===========================================================================
         '===========================================================================
         ' 1ro) Panel de Información General
         '===========================================================================

         Normativa = Me.lblaNormativa.Text.Trim
         CodBCR = Me.lblaCodBCR.Text.Trim
         Funcionario = Me.lblaFuncionario.Text.Trim
         Periodo = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2) + Me.txtAnno.Text


         ' 4to) Otras Variables...
         '===========================================================================


         Select Case Accion
            Case Is = 1

               oDBSQL.Grabar_NuevoForm4Cabecera(Periodo, CodBCR, Normativa, nReporte, _
                                                Funcionario)

               MensajeTermino = " Grabo "
            Case Is = 2
               'oDBSQL.Modificar_FormRegistro(ID_Registro, FechaRegistro, IdTDocumento, _
               '                       NroActa, CodUsuario)
               MensajeTermino = " Modifico "
            Case Is = 3
               'oDBSQL.Eliminar_FormRegistro(ID_Registro, CodUsuario)
               MensajeTermino = " Elimino "


         End Select

         Grabar_DetallexRegistro(oDBSQL, Periodo)

         MsgBox1.ShowMessage("El Registro se" + MensajeTermino + "Correctamente!")

         If Accion = 3 Then
            SalirPagina()
         End If
         cmdCancelar_Click(sender, e)
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub

   Private Sub Grabar_DetallexRegistro(ByVal oDBSQL As BNOperacion, ByVal Periodo As String)

      Dim IdTCliente As Integer
      Dim IdMoneda As Integer
      Dim IdCliente As Integer
      Dim IdPlaza As Integer
      Dim IdConcepto As Integer
      Dim IdOperacion As Integer

      Dim sTasaV As Double
      Dim sMMinimoV As Double
      Dim sMMaximoV As Double
      Dim sComFijaV As Double
      Dim sTasaCA As Double
      Dim sMMinimoCA As Double
      Dim sMMaximoCA As Double
      Dim sComFijaCA As Double
      Dim sTasaI As Double
      Dim sMMinimoI As Double
      Dim sMMaximoI As Double
      Dim sComFijaI As Double
      Dim sTasaO As Double
      Dim sMMinimoO As Double
      Dim sMMaximoO As Double
      Dim sComFijaO As Double
      Dim UsuCrea As String
      Dim FechaCrea As DateTime

      Dim Observaciones As String
      Dim CodOficina As String

      Dim Bnlog As New BNOperacion
      Dim sNombreMetodo = "Grabar Formulario"

      Dim dr As DataRow
      Dim Indice As Integer
      Try
         If Accion > 1 Then
            oDBSQL.Eliminar_Form4Registro(Periodo, Accion, CodUsuario, ErrMsg)
         End If
         If Accion = 3 Then
            Exit Sub
         End If
         For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
            Try

               IdTCliente = dr.Item("IdTCliente")
               IdMoneda = dr.Item("IdMoneda")
               IdCliente = dr.Item("IdCliente")
               IdPlaza = dr.Item("IdPlaza")
               IdOperacion = dr.Item("IdOperacion")
               IdConcepto = dr.Item("IdConcepto")
               sTasaV = IIf(dr.Item("sTasaV") > 0, dr.Item("sTasaV"), 0)
               sMMinimoV = IIf(dr.Item("sMMinimoV") > 0, dr.Item("sMMinimoV"), 0)
               sMMaximoV = IIf(dr.Item("sMMaximoV") > 0, dr.Item("sMMaximoV"), 0)
               sComFijaV = IIf(dr.Item("sComFijaV") > 0, dr.Item("sComFijaV"), 0)
               sTasaCA = IIf(dr.Item("sTasaCA") > 0, dr.Item("sTasaCA"), 0)
               sMMinimoCA = IIf(dr.Item("sMMinimoCA") > 0, dr.Item("sMMinimoCA"), 0)
               sMMaximoCA = IIf(dr.Item("sMMaximoCA") > 0, dr.Item("sMMaximoCA"), 0)
               sComFijaCA = IIf(dr.Item("sComFijaCA") > 0, dr.Item("sComFijaCA"), 0)
               sTasaI = IIf(dr.Item("sTasaI") > 0, dr.Item("sTasaI"), 0)
               sMMinimoI = IIf(dr.Item("sMMinimoI") > 0, dr.Item("sMMinimoI"), 0)
               sMMaximoI = IIf(dr.Item("sMMaximoI") > 0, dr.Item("sMMaximoI"), 0)
               sComFijaI = IIf(dr.Item("sComFijaI") > 0, dr.Item("sComFijaI"), 0)
               sTasaO = IIf(dr.Item("sTasaO") > 0, dr.Item("sTasaO"), 0)
               sMMinimoO = IIf(dr.Item("sMMinimoO") > 0, dr.Item("sMMinimoO"), 0)
               sMMaximoO = IIf(dr.Item("sMMaximoO") > 0, dr.Item("sMMaximoO"), 0)
               sComFijaO = IIf(dr.Item("sComFijaO") > 0, dr.Item("sComFijaO"), 0)
               CodOficina = dr.Item("cOficina")
               Observaciones = dr.Item("Observaciones")
               UsuCrea = dr.Item("UsuCrea")
               FechaCrea = dr.Item("FechaCrea")

               oDBSQL.Insertar_DetalleForm4(Periodo, IdTCliente, IdMoneda, IdCliente, IdPlaza, _
                                            IdOperacion, IdConcepto, _
                                            sTasaV, sMMinimoV, sMMaximoV, sComFijaV, _
                                            sTasaCA, sMMinimoCA, sMMaximoCA, sComFijaCA, _
                                            sTasaI, sMMinimoI, sMMaximoI, sComFijaI, _
                                            sTasaO, sMMinimoO, sMMaximoO, sComFijaO, _
                                            Observaciones, UsuCrea, CodOficina, FechaCrea)


            Catch ex As Exception
               Dim Err$ = ex.Message

               Bnlog.CrearLogTXT(sCOM_CHAR_IZQUIERDO & _
                        Format(Now, "yyyy/MM/dd HH:mm:ss") & _
                        sCOM_DESC_EXCEPCION & _
                        sNombreClase & sCOM_CHAR_SEPARADOR & _
                        sNombreMetodo & sCOM_CHAR_DERECHOGUION & _
                        sCOM_CHAR_IZQUIERDO & "ERROR-" & sCOM_CHAR_SEPARADOR & " " & ex.Message & sCOM_CHAR_DERECHO)
            End Try
         Next
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub
   Private Sub Obtener_Informacion_Formato4()
      Dim oBDSQL As New BNOperacion
      Dim Periodo As String
      Dim Mes As String
      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Mes + Me.txtAnno.Text

      Try
         DSInfoRegistro = oBDSQL.Get_InfoFormato4(Periodo, ErrMsg)

      Catch ex As Exception
         MsgBox1.ShowMessage(ErrMsg)
      End Try

   End Sub
   Private Sub Mostrar_Informacion_Formato4()

      'If ID_Registro = 0 Then Exit Sub

      Try

         'Dim dr As DataRow = DSInfoRegistro.Tables("InfoFormato1_Detalle").Rows(0)
         Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_General").Rows(0)
         '===========================================================================
         ' 1ro) Panel de Información General
         '===========================================================================

         'Me.txtTCAutomaticos.Text = dr.Item("TCajeroAutoma")


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

#Region "   * * * Interacción con la Grilla de Detalle * * *   "

   Private Sub cmdAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrega.Click

      Dim IdTCliente As Integer
      Dim IdMoneda As Integer
      Dim IdCliente As Integer
      Dim IdPlaza As Integer
      Dim IdOperacion As Integer
      Dim IdConcepto As Integer
      Dim sTasaV As Double
      Dim sMMinimoV As Double
      Dim sMMaximoV As Double
      Dim sComFijaV As Double
      Dim sTasaCA As Double
      Dim sMMinimoCA As Double
      Dim sMMaximoCA As Double
      Dim sComFijaCA As Double
      Dim sTasaI As Double
      Dim sMMinimoI As Double
      Dim sMMaximoI As Double
      Dim sComFijaI As Double
      Dim sTasaO As Double
      Dim sMMinimoO As Double
      Dim sMMaximoO As Double
      Dim sComFijaO As Double
      Dim Observaciones As String
      Dim Valida As Integer
      Dim dr As DataRow


      Try
         'If Me.txtTasa.Text = "" Or Me.txtMontoMin.Text = "" Or Me.txtMontoMax.Text = "" Then
         '   'MsgBox1.ShowMessage("No ha ingresado ninguna tarifa!")
         '   'Exit Sub
         'Else
         '   'If Not IsNumeric(Me.txtTasa.Text) Or Not IsNumeric(Me.txtMontoMin.Text) Or Not IsNumeric(Me.txtMontoMax.Text) Then
         '   '   MsgBox1.ShowMessage("Tarifas deben ser numéricas!")
         '   '   txtTasa.Text = 0
         '   '   txtMontoMin.Text = 0
         '   '   txtMontoMax.Text = 0
         '   '   Exit Sub
         '   'End If
         'End If

         IdTCliente = CInt(Me.cmbTCliente.SelectedValue)
         IdMoneda = CInt(Me.cmbMoneda.SelectedValue)
         IdCliente = CInt(Me.cmbCliente.SelectedValue)
         IdPlaza = CInt(Me.cmbPlaza.SelectedValue)
         IdOperacion = CInt(Me.cmbOperacion.SelectedValue)
         IdConcepto = CInt(Me.cmbConcepto.SelectedValue)
         sTasaV = CDbl(IIf(IsNumeric(Me.txtTasaV.Text), Me.txtTasaV.Text, 0))
         sMMinimoV = CDbl(IIf(IsNumeric(Me.txtMontoMinV.Text), Me.txtMontoMinV.Text, 0))
         sMMaximoV = CDbl(IIf(IsNumeric(Me.txtMontoMaxV.Text), Me.txtMontoMaxV.Text, 0))
         sComFijaV = CDbl(IIf(IsNumeric(Me.txtComisV.Text), Me.txtComisV.Text, 0))
         sTasaCA = CDbl(IIf(IsNumeric(Me.txtTasaCA.Text), Me.txtTasaCA.Text, 0))
         sMMinimoCA = CDbl(IIf(IsNumeric(Me.txtMontoMinCA.Text), Me.txtMontoMinCA.Text, 0))
         sMMaximoCA = CDbl(IIf(IsNumeric(Me.txtMontoMaxCA.Text), Me.txtMontoMaxCA.Text, 0))
         sComFijaCA = CDbl(IIf(IsNumeric(Me.txtComisCA.Text), Me.txtComisCA.Text, 0))
         sTasaI = CDbl(IIf(IsNumeric(Me.txtTasaI.Text), Me.txtTasaI.Text, 0))
         sMMinimoI = CDbl(IIf(IsNumeric(Me.txtMontoMinI.Text), Me.txtMontoMinI.Text, 0))
         sMMaximoI = CDbl(IIf(IsNumeric(Me.txtMontoMaxI.Text), Me.txtMontoMaxI.Text, 0))
         sComFijaI = CDbl(IIf(IsNumeric(Me.txtComisI.Text), Me.txtComisI.Text, 0))
         sTasaO = CDbl(IIf(IsNumeric(Me.txtTasaO.Text), Me.txtTasaO.Text, 0))
         sMMinimoO = CDbl(IIf(IsNumeric(Me.txtMontoMinO.Text), Me.txtMontoMinO.Text, 0))
         sMMaximoO = CDbl(IIf(IsNumeric(Me.txtMontoMaxO.Text), Me.txtMontoMaxO.Text, 0))
         sComFijaO = CDbl(IIf(IsNumeric(Me.txtComisO.Text), Me.txtComisO.Text, 0))
         Observaciones = Me.txtObservaciones.Text.ToUpper

         Me.cmbCliente.Enabled = True
         Me.cmbMoneda.Enabled = True
         Me.cmbPlaza.Enabled = True
         Me.cmbTCliente.Enabled = True
         Me.cmbConcepto.Enabled = True
         Me.cmbOperacion.Enabled = True
         '----
         If Me.lblIndx.Text = "" Then


            If Validar_Operacion(IdTCliente, IdMoneda, IdCliente, IdPlaza, IdOperacion, IdConcepto, Coficina) Then
               dr = DSInfoRegistro.Tables("InfoRegistro_Detalle").NewRow
               dr.Item("IdTCliente") = IdTCliente
               dr.Item("TCliente") = cmbTCliente.SelectedItem.Text
               dr.Item("IdCliente") = IdCliente
               dr.Item("Cliente") = cmbCliente.SelectedItem.Text
               dr.Item("IdMoneda") = IdMoneda
               dr.Item("Moneda") = cmbMoneda.SelectedItem.Text
               dr.Item("IdPlaza") = IdPlaza
               dr.Item("Plaza") = cmbPlaza.SelectedItem.Text
               dr.Item("IdOperacion") = IdOperacion
               dr.Item("Operacion") = cmbOperacion.SelectedItem.Text
               dr.Item("IdConcepto") = IdConcepto
               dr.Item("Concepto") = cmbConcepto.SelectedItem.Text
               dr.Item("sTasaV") = sTasaV
               dr.Item("sMMinimoV") = sMMinimoV
               dr.Item("sMMaximoV") = sMMaximoV
               dr.Item("sComFijaV") = sComFijaV
               dr.Item("sTasaCA") = sTasaCA
               dr.Item("sMMinimoCA") = sMMinimoCA
               dr.Item("sMMaximoCA") = sMMaximoCA
               dr.Item("sComFijaCA") = sComFijaCA
               dr.Item("sTasaI") = sTasaI
               dr.Item("sMMinimoI") = sMMinimoI
               dr.Item("sMMaximoI") = sMMaximoI
               dr.Item("sComFijaI") = sComFijaI
               dr.Item("sTasaO") = sTasaO
               dr.Item("sMMinimoO") = sMMinimoO
               dr.Item("sMMaximoO") = sMMaximoO
               dr.Item("sComFijaO") = sComFijaO
               dr.Item("Observaciones") = Observaciones
               dr.Item("cOficina") = Coficina
               dr.Item("Dependencia") = Dependencia
               dr.Item("UsuCrea") = CodUsuario
               dr.Item("FechaCrea") = Now
               DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Add(dr)
               'Acumular_Totales(IdOperacion, NroOperaciones)
            Else
               MsgBox1.ShowMessage("Operación ya ingresada")
            End If
         Else
            dr = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(Me.lblIndx.Text)
            dr.Item("sTasaV") = sTasaV
            dr.Item("sMMinimoV") = sMMinimoV
            dr.Item("sMMaximoV") = sMMaximoV
            dr.Item("sComFijaV") = sComFijaV
            dr.Item("sTasaCA") = sTasaCA
            dr.Item("sMMinimoCA") = sMMinimoCA
            dr.Item("sMMaximoCA") = sMMaximoCA
            dr.Item("sComFijaCA") = sComFijaCA
            dr.Item("sTasaI") = sTasaI
            dr.Item("sMMinimoI") = sMMinimoI
            dr.Item("sMMaximoI") = sMMaximoI
            dr.Item("sComFijaI") = sComFijaI
            dr.Item("sTasaO") = sTasaO
            dr.Item("sMMinimoO") = sMMinimoO
            dr.Item("sMMaximoO") = sMMaximoO
            dr.Item("sComFijaO") = sComFijaO
            dr.Item("Observaciones") = Observaciones
         End If


         dtgRegistro.DataBind()
         Limpiar_Controles_Detalle()

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub

   Private Sub cmdElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElimina.Click
      'Dim IdOperacion As Integer
      'Dim NroOperaciones As Integer
      Dim iFila As Integer
      Dim IdOficina As String

      iFila = dtgRegistro.SelectedIndex
      If iFila < 0 Then
         MsgBox1.ShowMessage("Debe Seleccionar una detalle Previamente!")
         Exit Sub
      End If
      Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila)
      'IdOperacion = dr.Item("IdOperacion")
      'NroOperaciones = dr.Item("NroOperaciones")
      'Actualizar_Totales(IdOperacion, NroOperaciones)
      IdOficina = dr.Item("cOficina")

      If IdOficina <> Coficina Then
         MsgBox1.ShowMessage("No puede eliminar un registro de otra área")
         Exit Sub
      End If
      DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Delete()
      dtgRegistro.SelectedIndex = -1
      dtgRegistro.DataBind()

   End Sub
#End Region
#Region "********* Rutinas Diversas ********"

   Private Sub Limpiar_Controles_Detalle()
      Try
         Me.txtTasaV.Text = 0.0
         Me.txtMontoMinV.Text = 0.0
         Me.txtMontoMaxV.Text = 0.0
         Me.txtComisV.Text = 0.0
         Me.txtTasaCA.Text = 0.0
         Me.txtMontoMinCA.Text = 0.0
         Me.txtMontoMaxCA.Text = 0.0
         Me.txtComisCA.Text = 0.0
         Me.txtTasaI.Text = 0.0
         Me.txtMontoMinI.Text = 0.0
         Me.txtMontoMaxI.Text = 0.0
         Me.txtComisI.Text = 0.0
         Me.txtTasaO.Text = 0.0
         Me.txtMontoMinO.Text = 0.0
         Me.txtMontoMaxO.Text = 0.0
         Me.txtComisO.Text = 0.0
     
         Me.txtObservaciones.Text = ""
         Me.lblIndx.Text = ""
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Function Validar_Operacion(ByVal IdTCliente As Integer, ByVal IdMoneda As Integer, _
                                      ByVal IdCliente As Integer, ByVal IdPlaza As Integer, _
   ByVal IdOperacion As Integer, ByVal IdConcepto As Integer, _
                                      ByVal cOficina As String) As Boolean


      Dim xIdTCliente As Integer
      Dim xIdMoneda As Integer
      Dim xIdCliente As Integer
      Dim xIdPlaza As Integer
      Dim xIdOperacion As Integer
      Dim xIdConcepto As Integer
      Dim xcOficina As String

      Dim dr As DataRow


      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
         Return True
      End If
      For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
         Try

            xIdTCliente = dr.Item("IdTCliente")
            xIdMoneda = dr.Item("IdMoneda")
            xIdCliente = dr.Item("IdCliente")
            xIdPlaza = dr.Item("IdPlaza")
            xIdOperacion = dr.Item("IdOperacion")
            xIdConcepto = dr.Item("IdConcepto")
            xcOficina = dr.Item("cOficina")

            If IdTCliente = xIdTCliente And _
               IdMoneda = xIdMoneda And _
               IdCliente = xIdCliente And _
               IdPlaza = xIdPlaza And _
               IdOperacion = xIdOperacion And _
               IdConcepto = xIdConcepto And _
               cOficina = xcOficina Then
               Return False
            End If



         Catch ex As Exception
            Dim Err$ = ex.Message
         End Try
      Next

      Return True
   End Function



   Private Sub MsgBox1_YesChoosed(ByVal sender As Object, ByVal Key As String) Handles MsgBox1.YesChoosed
      Select Case Key
         Case "GRABAR"
            'Se confirmó que se desea grabar 
            EjecutarProceso()
         Case "ELIMINAR"
            'No se utiliza esta opcion.

      End Select
      'cmdCancelar_Click(sender, e)
   End Sub
   Private Sub MsgBox1_NoChoosed(ByVal sender As Object, ByVal Key As String) Handles MsgBox1.NoChoosed
      Select Case Key
         Case "GRABAR"
            MsgBox1.ShowMessage("Accion Cancelada")
         Case "ELIMINAR"
            'No se utiliza esta opcion.

      End Select
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
        SalirPagina()
        Response.Redirect("w_central.aspx")
   End Sub
#End Region


   Private Sub cmdAceptaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptaP.Click
      If Me.txtAnno.Text = "" Then
         MsgBox1.ShowMessage("Debe ingresar el año del periodo a registrar")
         Return
      End If
      Me.Panel1.Enabled = True
      Obtener_Informacion_Formato4()
      Formato_Grilla_Registro()
      Me.pnlGrilla.Visible = True

      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then
         'Registro Existe
         Accion = 2
         '    cmdNuevo.Visible = False
         '    cmdModificar.Visible = False
         '    cmdEliminar.Visible = False
         Mostrar_Informacion_Formato4()
      Else
         Accion = 1

      End If
      cmdAceptar.Visible = True
      cmdAceptar.Text = "Grabar"
      cmdCancelar.Visible = True
      cmdCancelar.Text = "Cancelar"
   End Sub


   Private Sub dtgRegistro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgRegistro.SelectedIndexChanged

      Dim iFila As Integer
      Dim IdOficina As String


      iFila = dtgRegistro.SelectedIndex
      If iFila < 0 Then
         MsgBox1.ShowMessage("Debe Seleccionar una detalle Previamente!")
         Exit Sub
      End If

      Me.lblIndx.Text = iFila
      Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila)

      IdOficina = dr.Item("cOficina")

      If IdOficina <> Coficina Then
         MsgBox1.ShowMessage("No puede modificar un registro de otra área")
         Exit Sub
      End If

      Me.cmbCliente.SelectedValue = dr.Item("IdCliente")
      Me.cmbMoneda.SelectedValue = dr.Item("IdMoneda")
      Me.cmbPlaza.SelectedValue = dr.Item("IdPlaza")
      Me.cmbTCliente.SelectedValue = dr.Item("IdTCliente")
      Me.cmbOperacion.SelectedValue = dr.Item("IdOperacion")
      Me.cmbConcepto.SelectedValue = dr.Item("IdConcepto")
      Me.txtComisV.Text = IIf(dr.Item("sComFijaV") > 0, dr.Item("sComFijaV"), 0)
      Me.txtMontoMaxV.Text = IIf(dr.Item("sMMaximoV") > 0, dr.Item("sMMaximoV"), 0)
      Me.txtMontoMinV.Text = IIf(dr.Item("sMMinimoV") > 0, dr.Item("sMMinimoV"), 0)
      Me.txtTasaV.Text = IIf(dr.Item("sTasaV") > 0, dr.Item("sTasaV"), 0)
      Me.txtComisCA.Text = IIf(dr.Item("sComFijaCA") > 0, dr.Item("sComFijaCA"), 0)
      Me.txtMontoMaxCA.Text = IIf(dr.Item("sMMaximoCA") > 0, dr.Item("sMMaximoCA"), 0)
      Me.txtMontoMinCA.Text = IIf(dr.Item("sMMinimoCA") > 0, dr.Item("sMMinimoCA"), 0)
      Me.txtTasaCA.Text = IIf(dr.Item("sTasaCA") > 0, dr.Item("sTasaCA"), 0)
      Me.txtComisI.Text = IIf(dr.Item("sComFijaI") > 0, dr.Item("sComFijaI"), 0)
      Me.txtMontoMaxI.Text = IIf(dr.Item("sMMaximoI") > 0, dr.Item("sMMaximoI"), 0)
      Me.txtMontoMinI.Text = IIf(dr.Item("sMMinimoI") > 0, dr.Item("sMMinimoI"), 0)
      Me.txtTasaI.Text = IIf(dr.Item("sTasaI") > 0, dr.Item("sTasaI"), 0)
      Me.txtComisO.Text = IIf(dr.Item("sComFijaO") > 0, dr.Item("sComFijaO"), 0)
      Me.txtMontoMaxO.Text = IIf(dr.Item("sMMaximoO") > 0, dr.Item("sMMaximoO"), 0)
      Me.txtMontoMinO.Text = IIf(dr.Item("sMMinimoO") > 0, dr.Item("sMMinimoO"), 0)
      Me.txtTasaO.Text = IIf(dr.Item("sTasaO") > 0, dr.Item("sTasaO"), 0)
      Me.txtObservaciones.Text = dr.Item("Observaciones")

      Me.cmbCliente.Enabled = False
      Me.cmbMoneda.Enabled = False
      Me.cmbPlaza.Enabled = False
      Me.cmbTCliente.Enabled = False
      Me.cmbOperacion.Enabled = False
      Me.cmbConcepto.Enabled = False
   End Sub

    Private Sub SalirPagina()
        '   Response.Redirect("w_central.aspx")
        Dim oBDSQL As New BNOperacion
        Dim Periodo As String
        Dim Mes As String
        ' Dim Existe As Integer
        Dim CodTrabajador As String
        CodTrabajador = Session("xCodTrabajador")
        Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
        Periodo = Mes + Me.txtAnno.Text
        Try
            oBDSQL.Actualizar_RegistroControl(1, Periodo, CodTrabajador)

        Catch ex As Exception
            MsgBox1.ShowMessage(ErrMsg)
        End Try

    End Sub
End Class
