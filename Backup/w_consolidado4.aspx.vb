Imports System.Web.Security
Imports System.IO
Imports System.Text

Public Class w_consolidado4


   Inherits System.Web.UI.Page
   Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
   Const sCOM_CHAR_IZQUIERDO As String = "["
   Const sCOM_CHAR_DERECHO As String = "]"
   Const sCOM_CHAR_DERECHOGUION As String = "]-"
   Const sCOM_CHAR_SEPARADOR As String = "/"
   Dim sNombreClase = "w_consolidado4"
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
   Public Property DSInfoOficina() As DataSet
      Get
         Return Session("xInfoOficina")
      End Get
      Set(ByVal Value As DataSet)
         Session("xInfoOficina") = Value
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
         Obtener_Informacion_Formato4()
         Me.pnlDetalle.Enabled = True
         Me.pnlGrilla.Visible = False
         Me.Panel1.Visible = False
         Me.cmdAceptar.Visible = False
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
      '' Segunda Columna: Tipo Cliente
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TCliente"
      dgBoundColumn.DataField = "TCliente"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Operacion
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Operacion"
      dgBoundColumn.DataField = "Operacion"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Concepto
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Concepto"
      dgBoundColumn.DataField = "Concepto"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Moneda
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Moneda"
      dgBoundColumn.DataField = "Moneda"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Quinta Columna: Cliente
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Cliente"
      dgBoundColumn.DataField = "Cliente"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
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
      '' Novena Columna: Tasa
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
      '' Decima Columna: Comision Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaV"
      dgBoundColumn.DataField = "sComFijaV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Tasa
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
      '' Decima Columna: Comision Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaCA"
      dgBoundColumn.DataField = "sComFijaCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Tasa
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
      '' Decima Columna: Comision Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaI"
      dgBoundColumn.DataField = "sComFijaI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Tasa
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
      '' Decima Columna: Comision Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaO"
      dgBoundColumn.DataField = "sComFijaO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N3}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      
      ''============================================================
      '' Decima Columna: Observaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Observaciones"
      dgBoundColumn.DataField = "Observaciones"
      dtgRegistro.Columns.Add(dgBoundColumn)

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
      dgButtonColumn.HeaderText = "Sel"
      dgButtonColumn.Text = "==>"
      dgButtonColumn.CommandName = "Select"
      dtgDetalle.Columns.Add(dgButtonColumn)
      ''============================================================
      '' Novena Columna: Dependencia
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Dependencia"
      dgBoundColumn.DataField = "Dependencia"
      dgBoundColumn.ItemStyle.Width = New Unit(30, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
   
      ''============================================================
      '' Novena Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaV"
      dgBoundColumn.DataField = "sTasaV"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinV"
      dgBoundColumn.DataField = "sMMinimoV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxV"
      dgBoundColumn.DataField = "sMMaximoV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Comisión Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaV"
      dgBoundColumn.DataField = "sComFijaV"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaCA"
      dgBoundColumn.DataField = "sTasaCA"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinCA"
      dgBoundColumn.DataField = "sMMinimoCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxCA"
      dgBoundColumn.DataField = "sMMaximoCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Comisión Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaCA"
      dgBoundColumn.DataField = "sComFijaCA"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaI"
      dgBoundColumn.DataField = "sTasaI"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinI"
      dgBoundColumn.DataField = "sMMinimoI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxI"
      dgBoundColumn.DataField = "sMMaximoI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Comisión Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaI"
      dgBoundColumn.DataField = "sComFijaI"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Tasa
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TasaO"
      dgBoundColumn.DataField = "sTasaO"
      dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Monto Min
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMinO"
      dgBoundColumn.DataField = "sMMinimoO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "MMáxO"
      dgBoundColumn.DataField = "sMMaximoO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Decima Columna: Comisión Fija
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "CFijaO"
      dgBoundColumn.DataField = "sComFijaO"
      dgBoundColumn.ItemStyle.Width = New Unit(8, UnitType.Cm)
      dtgDetalle.Columns.Add(dgBoundColumn)
            ''============================================================
      '' Decima Columna: Monto Max
      ''============================================================
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
      Dim ruta As String = Page.MapPath("FileTmp")
      Dim bExisteArchivo As Boolean
      Dim bExisteBackup As Boolean
      Dim strtrama As String
      Dim dr As DataRow
      Dim NReporte As String = "04"

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

               strtrama = Me.lblaCodBCR.Text & Me.lblaNormativa.Text & NReporte & Periodo & Funcionario

               swBackup.WriteLine(strtrama)
               swBackup.Close()
               fsBackup.Close()
               fsBackup = Nothing
               swBackup = Nothing

            End If
            '---- Escribe Detalle ----'
            Completa = 200 - Len(Trim(dr.Item("Observaciones")))
            Completa = IIf(Completa < 0, 0, Completa)

            bExisteBackup = IIf(System.IO.File.Exists(archivo), True, False)
            If bExisteBackup Then 'NUNCA ES NUEVO
               fsBackup = New FileStream(archivo, FileMode.Append)
            Else
               fsBackup = New FileStream(archivo, FileMode.Create)
            End If
                'swBackup = New StreamWriter(fsBackup) 
                '03/01 Archivo txt formato ansi
                swBackup = New StreamWriter(fsBackup, System.Text.Encoding.Default)

            strtrama = dr.Item("IdTCliente") & dr.Item("IdConcepto") & dr.Item("IdOperacion") _
                      & dr.Item("IdMoneda") & dr.Item("IdPlaza") & dr.Item("IdCliente") _
                      & FormatImp(dr.Item("sComFijaV").ToString, 8) & FormatImp(dr.Item("sTasaV").ToString, 6) _
                      & FormatImp(dr.Item("sMMinimoV").ToString, 8) & FormatImp(dr.Item("sMMaximoV").ToString, 8) _
                      & FormatImp(dr.Item("sComFijaCA").ToString, 8) & FormatImp(dr.Item("sTasaCA").ToString, 6) _
                      & FormatImp(dr.Item("sMMinimoCA").ToString, 8) & FormatImp(dr.Item("sMMaximoCA").ToString, 8) _
                      & FormatImp(dr.Item("sComFijaI").ToString, 8) & FormatImp(dr.Item("sTasaI").ToString, 6) _
                      & FormatImp(dr.Item("sMMinimoI").ToString, 8) & FormatImp(dr.Item("sMMaximoI").ToString, 8) _
                      & FormatImp(dr.Item("sComFijaO").ToString, 8) & FormatImp(dr.Item("sTasaO").ToString, 6) _
                      & FormatImp(dr.Item("sMMinimoO").ToString, 8) & FormatImp(dr.Item("sMMaximoO").ToString, 8) _
                      & Trim(dr.Item("Observaciones")) & StrDup(Completa, " ")

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


   Private Sub Obtener_Informacion_Formato4()
      Dim oBDSQL As New BNOperacion
      Dim Periodo As String
      Dim Mes As String
      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Mes + Me.txtAnno.Text

      Try
         DSInfoRegistro = oBDSQL.Get_InfoConsolidadoF4(Periodo, ErrMsg)

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
   Public Function FormatImp(ByVal importe As String, ByVal Longitud As Integer) As String

      Dim cadenaImporte As String = ""

      If Contiene(importe) Then

         Dim arrayImporte As String() = importe.Split(".")
         If arrayImporte(1).Length = 0 Then
                ' arrayImporte(1) = "00"
                arrayImporte(1) = "000"
            Else
                If arrayImporte(1).Length = 1 Then
                    arrayImporte(1) = arrayImporte(1) & "00"
                Else
                    If arrayImporte(1).Length = 2 Then
                        arrayImporte(1) = arrayImporte(1) & "0"
                    End If
                End If
            End If

            cadenaImporte = arrayImporte(0) & "." & arrayImporte(1)

        Else
                If importe = "" Then
                    cadenaImporte = "0.000"
                Else
                    cadenaImporte = importe & ".000"
                End If

            End If


            cadenaImporte = cadenaImporte.Replace(".", "")
            cadenaImporte = CompletaCeros(cadenaImporte, Longitud)
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
      Obtener_Informacion_Formato4()
      Formato_Grilla_Registro()
      Me.pnlGrilla.Visible = True

      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then
         'Registro Existe
         Mostrar_Informacion_Formato4()
         Me.cmdAceptar.Visible = True
      Else
         MsgBox1.ShowMessage("No existen datos para el periodo ingresado")

      End If



   End Sub


   Private Sub dtgRegistro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgRegistro.SelectedIndexChanged
      Dim iFila As Integer
      Dim IdPeriodo As String
      Dim IdTCliente As Integer
      Dim IdMoneda As Integer
      Dim IdCliente As Integer
      Dim IdPlaza As Integer
      Dim IdOperacion As Integer
      Dim IdConcepto As Integer
      Dim oBDSQL As New BNOperacion


      Dim oitem As DataGridItem
      Dim URL As String

      oitem = Me.dtgRegistro.SelectedItem

      iFila = Me.dtgRegistro.SelectedIndex
      IdPeriodo = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2) + Me.txtAnno.Text

      IdTCliente = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdTCliente")
      IdMoneda = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdMoneda")
      IdCliente = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdCliente")
      IdPlaza = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdPlaza")
      IdOperacion = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdOperacion")
      IdConcepto = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Item("IdConcepto")
      DSInfoOficina = oBDSQL.Get_InfoOficinaF4(IdPeriodo, IdTCliente, IdMoneda, IdCliente, _
                                            IdPlaza, IdOperacion, IdConcepto, ErrMsg)
      If DSInfoOficina.Tables("InfoOficina").Rows.Count > 0 Then
         Me.Panel1.Visible = True
         Formato_Grilla_Detalle()
         Me.dtgDetalle.Visible = True

      End If



   End Sub

   Private Sub dtgDetalle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgDetalle.SelectedIndexChanged
      Me.Panel1.Visible = False
      Me.dtgDetalle.Visible = False

   End Sub
End Class
