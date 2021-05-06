Imports System.Web.Security


Public Class w_formulario3


   Inherits System.Web.UI.Page

   Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
   Const sCOM_CHAR_IZQUIERDO As String = "["
   Const sCOM_CHAR_DERECHO As String = "]"
   Const sCOM_CHAR_DERECHOGUION As String = "]-"
   Const sCOM_CHAR_SEPARADOR As String = "/"

   Dim sNombreClase = "w_formulario3"
#Region " Web Form Designer Generated Code "

   'This call is required by the Web Form Designer.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
   Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
   Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton
   Protected WithEvents MsgBox1 As MsgBox.MsgBox
   Protected WithEvents pnlGrilla As System.Web.UI.WebControls.Panel
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
   Protected WithEvents lblCCobro As System.Web.UI.WebControls.Label
   Protected WithEvents lblCanal As System.Web.UI.WebControls.Label
   Protected WithEvents lblComision As System.Web.UI.WebControls.Label
   Protected WithEvents lblCliente As System.Web.UI.WebControls.Label
   Protected WithEvents cmbCanal As System.Web.UI.WebControls.DropDownList
   Protected WithEvents txtTarifaMN As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTarifaMN As System.Web.UI.WebControls.Label
   Protected WithEvents lblTarifaME As System.Web.UI.WebControls.Label
   Protected WithEvents txtTarifaME As System.Web.UI.WebControls.TextBox
   Protected WithEvents cmbCliente As System.Web.UI.WebControls.DropDownList
   Protected WithEvents cmbConcepto As System.Web.UI.WebControls.DropDownList
   Protected WithEvents cmbComision As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblCodBCR As System.Web.UI.WebControls.Label
   Protected WithEvents lblaCodBCR As System.Web.UI.WebControls.Label
   Protected WithEvents lblNormativa As System.Web.UI.WebControls.Label
   Protected WithEvents lblaNormativa As System.Web.UI.WebControls.Label
   Protected WithEvents lblFuncionario As System.Web.UI.WebControls.Label
   Protected WithEvents lblaFuncionario As System.Web.UI.WebControls.Label
   Protected WithEvents lblPeriodo As System.Web.UI.WebControls.Label
   Protected WithEvents cmbMes As System.Web.UI.WebControls.DropDownList
   Protected WithEvents txtAnno As System.Web.UI.WebControls.TextBox
   Protected WithEvents cmdAceptaP As System.Web.UI.WebControls.Button
   Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
   Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator2 As System.Web.UI.WebControls.CompareValidator
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
   Private xConcepto As DataTable
   Private xCanal As DataTable
   Private xComision As DataTable
   Private xCliente As DataTable


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

   Public Property DTConcepto() As DataTable
      Get
         Return xConcepto
      End Get
      Set(ByVal Value As DataTable)
         xConcepto = Value
      End Set
   End Property

   Public Property DTCanal() As DataTable
      Get
         Return xCanal
      End Get
      Set(ByVal Value As DataTable)
         xCanal = Value
      End Set
   End Property

   Public Property DTComision() As DataTable
      Get
         Return xComision
      End Get
      Set(ByVal Value As DataTable)
         xComision = Value
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
      Dim dsControl As DataSet = oDBSQL.Get_FormFormato3(ErrMsg)
      Dim mintIndice As Integer

      DTConcepto = dsControl.Tables("Concepto")
      DTCanal = dsControl.Tables("Canal")
      DTComision = dsControl.Tables("Comision")
      DTCliente = dsControl.Tables("Cliente")

      Me.cmbConcepto.DataSource = DTConcepto
      Me.cmbConcepto.DataValueField = DTConcepto.Columns(0).ColumnName
      Me.cmbConcepto.DataTextField = DTConcepto.Columns(1).ColumnName
      Me.cmbConcepto.DataBind()

      Me.cmbCanal.DataSource = DTCanal
      Me.cmbCanal.DataValueField = DTCanal.Columns(0).ColumnName
      Me.cmbCanal.DataTextField = DTCanal.Columns(1).ColumnName
      Me.cmbCanal.DataBind()

      Me.cmbComision.DataSource = DTComision
      Me.cmbComision.DataValueField = DTComision.Columns(0).ColumnName
      Me.cmbComision.DataTextField = DTComision.Columns(1).ColumnName
      Me.cmbComision.DataBind()

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
         Obtener_Informacion_Formato3()
         Me.Panel1.Enabled = False
         'Me.pnlDetalle.Enabled = False
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
      '' Primera Columna: Periodo
      ''============================================================
      ''dgBoundColumn = New BoundColumn
      ''dgBoundColumn.HeaderText = "Periodo"
      ''dgBoundColumn.DataField = "Periodo"
      ''dgBoundColumn.ItemStyle.Width = New Unit(6, UnitType.Cm)
      ''dtgRegistro.Columns.Add(dgBoundColumn)
      ''dgBoundColumn.Visible = False
      ''============================================================
      '' Segunda Columna: Concepto
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Concepto"
      dgBoundColumn.DataField = "Concepto"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Tercera Columna: Canal
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Canal"
      dgBoundColumn.DataField = "Canal"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Comision
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Comision"
      dgBoundColumn.DataField = "Comision"
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
      '' Sexta Columna: TarifaMN
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Tarifa MN"
      dgBoundColumn.DataField = "TarifaMN"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Septima Columna: TarifaME
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Tarifa ME"
      dgBoundColumn.DataField = "TarifaME"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Octava Columna: Observaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Observaciones"
      dgBoundColumn.DataField = "Observaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Novena Columna: Dependencia
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Dependencia"
      dgBoundColumn.DataField = "Dependencia"
      dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
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
         'cmdModificar.Visible = True
         'cmdEliminar.Visible = True
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
      Dim nReporte As Integer = 3


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

               oDBSQL.Grabar_NuevoForm3Cabecera(Periodo, CodBCR, Normativa, nReporte, _
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

      Dim IdConcepto As Integer
      Dim IdCanal As Integer
      Dim IdComision As Integer
      Dim IdCliente As Integer
      Dim sTarifaMN As Double
      Dim sTarifaME As Double
      Dim Observaciones As String
      Dim CodOficina As String
      Dim UsuCrea As String
      Dim FechaCrea As Date

      '    '    Dim CodUsuario As String
      '    '   Dim Coficina As String
      '    '----
      '    '    CodUsuario = "0293784"
      '    '   Coficina = "0002"
      Dim Bnlog As New BNOperacion
      Dim sNombreMetodo = "Grabar Formulario"

      Dim dr As DataRow
      Dim Indice As Integer
      Try
         If Accion > 1 Then
            oDBSQL.Eliminar_Form3Registro(Periodo, Accion, CodUsuario, ErrMsg)
         End If
         If Accion = 3 Then
            Exit Sub
         End If
         For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
            Try
               IdConcepto = dr.Item("IdConcepto")
               IdCanal = dr.Item("IdCanal")
               IdComision = dr.Item("IdComision")
               IdCliente = dr.Item("IdCliente")
               sTarifaMN = dr.Item("TarifaMN")
               sTarifaME = dr.Item("TarifaME")
               CodOficina = dr.Item("cOficina")
               Observaciones = dr.Item("Observaciones")
               UsuCrea = dr.Item("UsuCrea")
               FechaCrea = dr.Item("FechaCrea")
               oDBSQL.Insertar_DetalleForm3(Periodo, IdConcepto, IdCanal, IdComision, IdCliente, _
                                                    sTarifaMN, sTarifaME, Observaciones, UsuCrea, CodOficina, FechaCrea)


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
   Private Sub Obtener_Informacion_Formato3()
      Dim oBDSQL As New BNOperacion
      Dim Periodo As String
      Dim Mes As String
      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Mes + Me.txtAnno.Text

      Try
         DSInfoRegistro = oBDSQL.Get_InfoFormato3(Periodo, ErrMsg)

      Catch ex As Exception
         MsgBox1.ShowMessage(ErrMsg)
      End Try

   End Sub
   Private Sub Mostrar_Informacion_Formato3()

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

      Dim IdConcepto As Integer
      Dim IdCanal As Integer
      Dim IdComision As Integer
      Dim IdCliente As Integer
      Dim sTarifaMN As Double
      Dim sTarifaME As Double
      Dim Observaciones As String
      Dim SearchChar As String
      Dim SearchString As String
      Dim Valida As Integer
      Dim nCaracteres As Integer

      Try
         If Me.txtTarifaMN.Text = "" Or Me.txtTarifaME.Text = "" Then
            MsgBox1.ShowMessage("No ha ingresado ninguna tarifa!")
            Exit Sub
         Else
            'If Not IsNumeric(Me.txtTarifaMN.Text) Or Not IsNumeric(Me.txtTarifaME.Text) Then
            '   MsgBox1.ShowMessage("Tarifas deben ser numéricas!")
            '   txtTarifaMN.Text = 0
            '   txtTarifaME.Text = 0
            '   Exit Sub
            'End If
         End If

         IdConcepto = CInt(Me.cmbConcepto.SelectedValue)
         IdCanal = CInt(Me.cmbCanal.SelectedValue)
         IdComision = CInt(Me.cmbComision.SelectedValue)
         IdCliente = CInt(Me.cmbCliente.SelectedValue)

         sTarifaMN = CDbl(Me.txtTarifaMN.Text)
         sTarifaME = CDbl(Me.txtTarifaME.Text)

         Observaciones = Me.txtObservaciones.Text.ToUpper

         '----
         If Validar_Operacion(IdConcepto, IdCanal, IdComision, IdCliente, Coficina) Then
            Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").NewRow
            dr.Item("IdConcepto") = IdConcepto
            dr.Item("Concepto") = cmbConcepto.SelectedItem.Text
            dr.Item("IdCanal") = IdCanal
            dr.Item("Canal") = cmbCanal.SelectedItem.Text
            dr.Item("IdComision") = IdComision
            dr.Item("Comision") = cmbComision.SelectedItem.Text
            dr.Item("IdCliente") = IdCliente
            dr.Item("Cliente") = cmbCliente.SelectedItem.Text
            dr.Item("TarifaMN") = sTarifaMN
            dr.Item("TarifaME") = sTarifaME
            dr.Item("Observaciones") = Observaciones
            dr.Item("cOficina") = Coficina
            dr.Item("Dependencia") = Dependencia
            dr.Item("UsuCrea") = CodUsuario
            dr.Item("FechaCrea") = Now
            DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Add(dr)
            dtgRegistro.DataBind()
            Limpiar_Controles_Detalle()
            'Acumular_Totales(IdOperacion, NroOperaciones)
         Else
            MsgBox1.ShowMessage("Operación ya ingresada")
         End If
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
         Me.txtTarifaMN.Text = 0
         Me.txtTarifaME.Text = 0
         Me.txtObservaciones.Text = ""

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Function Validar_Operacion(ByVal IdConcepto As Integer, ByVal IdCanal As Integer, _
                                    ByVal IdComision As Integer, ByVal idcliente As Integer, _
                                    ByVal cOficina As String) As Boolean

      Dim xIdConcepto As Integer
      Dim xIdCanal As Integer
      Dim xIdComision As Integer
      Dim xIdCliente As Integer
      Dim xcOficina As String
      Dim dr As DataRow


      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
         Return True
      End If
      For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
         Try

            xIdConcepto = dr.Item("IdConcepto")
            xIdCanal = dr.Item("IdCanal")
            xIdComision = dr.Item("IdComision")
            xIdCliente = dr.Item("IdCliente")
            xcOficina = dr.Item("cOficina")

            If IdConcepto = xIdConcepto And _
               IdCanal = xIdCanal And _
               IdComision = xIdComision And _
               idcliente = xIdCliente And _
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
      Obtener_Informacion_Formato3()
      Formato_Grilla_Registro()
      Me.pnlGrilla.Visible = True

      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then
         'Registro Existe
         Accion = 2
         '    cmdNuevo.Visible = False
         '    cmdModificar.Visible = False
         '    cmdEliminar.Visible = False
         Mostrar_Informacion_Formato3()
      Else
         Accion = 1

      End If
      cmdAceptar.Visible = True
      cmdAceptar.Text = "Grabar"
      cmdCancelar.Visible = True
      cmdCancelar.Text = "Cancelar"
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
