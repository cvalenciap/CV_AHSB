Imports System.Web.Security


Public Class w_formulario2


   Inherits System.Web.UI.Page
   Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
   Const sCOM_CHAR_IZQUIERDO As String = "["
   Const sCOM_CHAR_DERECHO As String = "]"
   Const sCOM_CHAR_DERECHOGUION As String = "]-"
   Const sCOM_CHAR_SEPARADOR As String = "/"

   Dim sNombreClase = "w_formulario2"
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
   Protected WithEvents lblTOperacion As System.Web.UI.WebControls.Label
   Protected WithEvents lblObservaciones As System.Web.UI.WebControls.Label
   Protected WithEvents txtObservaciones As System.Web.UI.WebControls.TextBox
   Protected WithEvents cmdAgrega As System.Web.UI.WebControls.Button
   Protected WithEvents cmdElimina As System.Web.UI.WebControls.Button
   Protected WithEvents dtgRegistro As System.Web.UI.WebControls.DataGrid
   Protected WithEvents lblNInstPagoMN As System.Web.UI.WebControls.Label
   Protected WithEvents txtNInstPagoMN As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblNInstPagoME As System.Web.UI.WebControls.Label
   Protected WithEvents txtNInstPagoME As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblVInstPagoMN As System.Web.UI.WebControls.Label
   Protected WithEvents txtVInstPagoMN As System.Web.UI.WebControls.TextBox
   Protected WithEvents lbVInstPagoME As System.Web.UI.WebControls.Label
   Protected WithEvents txtVInstPagoME As System.Web.UI.WebControls.TextBox
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
   Protected WithEvents lblInstPago As System.Web.UI.WebControls.Label
   Protected WithEvents cmbInstPago As System.Web.UI.WebControls.DropDownList
   Protected WithEvents cmbTipoTxn As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblCanal As System.Web.UI.WebControls.Label
   Protected WithEvents cmbCanal As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblNroOperaMN As System.Web.UI.WebControls.Label
   Protected WithEvents txtNroOperaMN As System.Web.UI.WebControls.TextBox
   Protected WithEvents VOperacionesMN As System.Web.UI.WebControls.Label
   Protected WithEvents lblNroOperaME As System.Web.UI.WebControls.Label
   Protected WithEvents txtNroOperaME As System.Web.UI.WebControls.TextBox
   Protected WithEvents VOperacionesME As System.Web.UI.WebControls.Label
   Protected WithEvents txtVOperaMN As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtVOperaME As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblME As System.Web.UI.WebControls.Label
   Protected WithEvents lblMN As System.Web.UI.WebControls.Label
   Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
   Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator2 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents CompareValidator4 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
   Protected WithEvents CompareValidator3 As System.Web.UI.WebControls.CompareValidator
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
   Private xInstPago As DataTable
   Private xTipoTxn As DataTable
    Private xCanal As DataTable
    Private Existe As Integer
 


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
   Public Property NroOperaMN() As Integer
      Get
         Return Session("xNroOperaMN")
      End Get
      Set(ByVal Value As Integer)
         Session("xNroOperaMN") = Value
      End Set
   End Property
   Public Property NroOperaME() As Integer
      Get
         Return Session("xNroOperaME")
      End Get
      Set(ByVal Value As Integer)
         Session("xNroOperaME") = Value
      End Set
   End Property
   Public Property ValOperaMN() As Double
      Get
         Return Session("xValOperaMN")
      End Get
      Set(ByVal Value As Double)
         Session("xValOperaMN") = Value
      End Set
   End Property
   Public Property ValOperaME() As Double
      Get
         Return Session("xValOperaME")
      End Get
      Set(ByVal Value As Double)
         Session("xValOperaME") = Value
      End Set
   End Property
   Public Property qInstPagoMN() As Integer
      Get
         Return Session("xqInstPagoMN")
      End Get
      Set(ByVal Value As Integer)
         Session("xqInstPagoMN") = Value
      End Set
   End Property
   Public Property qInstPagoME() As Integer
      Get
         Return Session("xqInstPagoME")
      End Get
      Set(ByVal Value As Integer)
         Session("xqInstPagoME") = Value
      End Set
   End Property
   Public Property sInstPagoMN() As Double
      Get
         Return Session("sInstPagoMN")
      End Get
      Set(ByVal Value As Double)
         Session("sInstPagoMN") = Value
      End Set
   End Property
   Public Property sInstPagoME() As Double
      Get
         Return Session("sInstPagoME")
      End Get
      Set(ByVal Value As Double)
         Session("sInstPagoME") = Value
      End Set
   End Property



#End Region
#Region "   * * * Carga de Controles - Combos * * *   "

   Public Property DTInstPago() As DataTable
      Get
         Return xInstPago
      End Get
      Set(ByVal Value As DataTable)
         xInstPago = Value
      End Set
   End Property

   Public Property DTTipoTxn() As DataTable
      Get
         Return xTipoTxn
      End Get
      Set(ByVal Value As DataTable)
         xTipoTxn = Value
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




   Private Sub Cargar_Controles()
      Dim oDBSQL As New BNOperacion
      Dim dsControl As DataSet = oDBSQL.Get_FormFormato2(ErrMsg)
      Dim mintIndice As Integer

      DTInstPago = dsControl.Tables("InstPago")
      DTTipoTxn = dsControl.Tables("TipoTxn")
      DTCanal = dsControl.Tables("Canal")

      Me.cmbInstPago.DataSource = DTInstPago
      Me.cmbInstPago.DataValueField = DTInstPago.Columns(0).ColumnName
      Me.cmbInstPago.DataTextField = DTInstPago.Columns(1).ColumnName
      Me.cmbInstPago.DataBind()

      Me.cmbTipoTxn.DataSource = DTTipoTxn
      Me.cmbTipoTxn.DataValueField = DTTipoTxn.Columns(0).ColumnName
      Me.cmbTipoTxn.DataTextField = DTTipoTxn.Columns(1).ColumnName
      Me.cmbTipoTxn.DataBind()

      Me.cmbCanal.DataSource = DTCanal
      Me.cmbCanal.DataValueField = DTCanal.Columns(0).ColumnName
      Me.cmbCanal.DataTextField = DTCanal.Columns(1).ColumnName
      Me.cmbCanal.DataBind()

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
        Me.cmdAceptaP.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdAceptar.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdAgrega.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdCancelar.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdElimina.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdEliminar.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdModificar.Attributes.Add("onClick", "setGoodLink();")
        Me.dtgRegistro.Attributes.Add("onClick", "setGoodLink();")
        Me.cmdNuevo.Attributes.Add("onClick", "setGoodLink();")

        Me.cmdAceptaP.Enabled = True

        Leer_Parametros()
        If Not Page.IsPostBack Then
            Me.txtAnno.Text = CStr(Year(Now()))
            oLoad = True
            Dim oBDSQL As New BNOperacion
            
            Try
                Existe = 0
                Existe = oBDSQL.Verificar_RegistroControl(2, Session("xCodTrabajador"))

                If Existe = 1 Then
                    Dim mensaje = "EL FORMATO 2 SE ENCUENTRA EN USO, INTENTE MAS TARDE"
                    Response.Redirect("w_central.aspx?ErrMsg=" & mensaje)
                    Return
                Else
                    Obtener_Informacion_Formato2()
                    Me.Panel1.Enabled = False
                    Me.pnlGrilla.Visible = False
                    cmdAceptar.Visible = False
                End If
            Catch ex As Exception
                MsgBox1.ShowMessage(ErrMsg)
            End Try

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
      '' Segunda Columna: Instrumento de Pago
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "InstPago"
      dgBoundColumn.DataField = "InstPago"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Tercera Columna: Tipo Transaccion
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "TipoTxn"
      dgBoundColumn.DataField = "TipoTxn"
      dgBoundColumn.ItemStyle.Width = New Unit(20, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Cuarta Columna: Canal
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Canal"
      dgBoundColumn.DataField = "Canal"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Quinta Columna: Nro. OperacionesMN
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Nro.Oper.MN - S/."
      dgBoundColumn.DataField = "NroOperaMN"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N0}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Sexta Columna: Valor OperacionesMN
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Val.Oper.MN"
      dgBoundColumn.DataField = "ValOperaMN"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Septima Columna: Nro. OperacionesME
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Nro.Oper.ME - $"
      dgBoundColumn.DataField = "NroOperaME"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N0}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Octava Columna: Valor OperacionesME
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Val.Oper.ME"
      dgBoundColumn.DataField = "ValOperaME"
      dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
      dgBoundColumn.DataFormatString = "{0:N}"
      dgBoundColumn.ItemStyle.HorizontalAlign = HorizontalAlign.Right
      dtgRegistro.Columns.Add(dgBoundColumn)

      ''============================================================
      '' Novena Columna: Observaciones
      ''============================================================
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Observaciones"
      dgBoundColumn.DataField = "Observaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Décima Columna: Dependencia
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
         '   cmdModificar.Visible = True
         '  cmdEliminar.Visible = True
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
      Dim nReporte As Integer = 2


      Dim dr As DataRow
      Dim oDBSQL As New BNOperacion
      Dim MensajeTermino As String
      Dim sender As System.Object
      Dim e As System.EventArgs

      Dim CodBCR As String
      Dim Normativa As String
      Dim Funcionario As String
      Dim Periodo As String
      'Dim qInstPagoMN As Integer
      'Dim qInstPagoME As Integer
      'Dim sInstPagoMN As Double
      'Dim sInstPagoME As Double


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
         ' qInstPagoMN = CInt(Me.txtNInstPagoMN.Text)
         ' qInstPagoME = CInt(Me.txtNInstPagoME.Text)
         ' sInstPagoMN = CDbl(Me.txtVInstPagoMN.Text)
         ' sInstPagoME = CDbl(Me.txtVInstPagoME.Text)




         'For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
         '   Try
         '      qInstPagoMN += dr.Item("NroOperaMN")
         '      qInstPagoME += dr.Item("NroOperaME")
         '      sInstPagoMN += dr.Item("ValOperaMN")
         '      sInstPagoME += dr.Item("ValOperaME")


         '   Catch ex As Exception
         '      Dim Err$ = ex.Message
         '   End Try
         'Next
         ' 4to) Otras Variables...
         '===========================================================================


         Select Case Accion
            Case Is = 1
               Grabar_DetallexRegistro(oDBSQL, Periodo)
               oDBSQL.Grabar_NuevoForm2Cabecera(Periodo, CodBCR, Normativa, nReporte, _
                                                Funcionario, qInstPagoMN, qInstPagoME, sInstPagoMN, sInstPagoME)

               MensajeTermino = " Grabo "
            Case Is = 2
               Grabar_DetallexRegistro(oDBSQL, Periodo)
               oDBSQL.Modificar_Form2Cabecera(Periodo, nReporte, _
                                               qInstPagoMN, qInstPagoME, sInstPagoMN, sInstPagoME)
               MensajeTermino = " Modifico "
            Case Is = 3
               'oDBSQL.Eliminar_FormRegistro(ID_Registro, CodUsuario)
               MensajeTermino = " Elimino "


         End Select

         'Grabar_DetallexRegistro(oDBSQL, Periodo)

         MsgBox1.ShowMessage("El Registro se" + MensajeTermino + "Correctamente!")

            'If Accion = 3 Then
            SalirPagina()
            'End If
            cmdCancelar_Click(sender, e)
            Response.Redirect("w_central.aspx")
        Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub

   Private Sub Grabar_DetallexRegistro(ByVal oDBSQL As BNOperacion, ByVal Periodo As String)

      Dim IdInstPago As Integer
      Dim IdTTxn As Integer
      Dim IdCanal As Integer
      Dim NroOperaMN As Integer
      Dim NroOperaME As Integer
      Dim ValOperaMN As Double
      Dim ValOperaME As Double
      Dim Observaciones As String
      Dim CodOficina As String
      Dim UsuCrea As String
      Dim FechaCrea As DateTime

      Dim Bnlog As New BNOperacion
      Dim sNombreMetodo = "Grabar Formulario"

      qInstPagoMN = 0
      qInstPagoME = 0
      sInstPagoMN = 0
      sInstPagoME = 0

      '    '    Dim CodUsuario As String
      '    '   Dim Coficina As String
      '    '----
      '    '    CodUsuario = "0293784"
      '    '   Coficina = "0002"

      Dim dr As DataRow
      Dim Indice As Integer
     
        Try
            '   oDBSQL.Actualizar_RegistroControl(2, Periodo, Session("xCodTrabajador"))


            If Accion > 1 Then
                oDBSQL.Eliminar_Form2Registro(Periodo, Accion, CodUsuario, ErrMsg)
            End If
            If Accion = 3 Then
                Exit Sub
            End If
            For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
                Try
                    IdInstPago = dr.Item("IdInstPago")
                    IdTTxn = dr.Item("IdTTxn")
                    IdCanal = dr.Item("IdCanal")
                    NroOperaMN = dr.Item("NroOperaMN")
                    NroOperaME = dr.Item("NroOperaME")
                    ValOperaMN = dr.Item("ValOperaMN")
                    ValOperaME = dr.Item("ValOperaME")
                    Observaciones = dr.Item("Observaciones")
                    CodOficina = dr.Item("cOficina")
                    UsuCrea = dr.Item("UsuCrea")
                    FechaCrea = dr.Item("FechaCrea")
                    oDBSQL.Insertar_DetalleForm2(Periodo, IdInstPago, IdTTxn, IdCanal, _
                                                         NroOperaMN, NroOperaME, ValOperaMN, ValOperaME, _
                                                         Observaciones, UsuCrea, CodOficina, FechaCrea)

                    qInstPagoMN += dr.Item("NroOperaMN")
                    qInstPagoME += dr.Item("NroOperaME")
                    sInstPagoMN += dr.Item("ValOperaMN")
                    sInstPagoME += dr.Item("ValOperaME")
                Catch ex As Exception
                    Dim Err$ = ex.Message
                End Try
            Next
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
   Private Sub Obtener_Informacion_Formato2()
      Dim oBDSQL As New BNOperacion
      Dim Periodo As String
      Dim Mes As String
      Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
      Periodo = Mes + Me.txtAnno.Text

        Try


            Existe = oBDSQL.Grabar_RegistroControl(2, Periodo, Session("xCodTrabajador"))

            'If Existe = 1 Then

            'Return
            'Else
                DSInfoRegistro = oBDSQL.Get_InfoFormato2(Periodo, ErrMsg)
            'End If

        Catch ex As Exception
            MsgBox1.ShowMessage(ErrMsg)
        End Try

   End Sub
   Private Sub Mostrar_Informacion_Formato2()

      'If ID_Registro = 0 Then Exit Sub

      Try

         'Dim dr As DataRow = DSInfoRegistro.Tables("InfoFormato1_Detalle").Rows(0)
         Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_General").Rows(0)
         '===========================================================================
         ' 1ro) Panel de Información General
         '===========================================================================

         Me.txtNInstPagoMN.Text = Format(dr.Item("NInstPagoMN"), "##,###,##0")
         Me.txtNInstPagoME.Text = Format(dr.Item("NInstPagoME"), "##,###,##0")
         Me.txtVInstPagoMN.Text = Format(dr.Item("VInstPagoMN"), "##,##0.00")
         Me.txtVInstPagoME.Text = Format(dr.Item("VInstPagoME"), "##,##0.00")

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

      Dim IdInstPago As Integer
      Dim IdTTxn As Integer
      Dim IdCanal As Integer
      Dim NroOperaMN As Integer
      Dim NroOperaME As Integer
      Dim ValOperaMN As Double
      Dim ValOperaME As Double
      Dim Observaciones As String
      Dim Valida As Integer
      Dim nCaracteres As Integer

      Try
         If (Me.txtNroOperaMN.Text = "" And Me.txtVInstPagoMN.Text = "") Or (Me.txtNroOperaME.Text = "" _
            And Me.txtVInstPagoME.Text = "") Then
            MsgBox1.ShowMessage("No ha ingresado ningún valor!")
            Exit Sub
         Else

            'If Not IsNumeric(Me.txtNroOperaMN.Text) Or Not IsNumeric(Me.txtNroOperaME.Text) _
            '   Or Not IsNumeric(Me.txtVInstPagoMN.Text) Or Not IsNumeric(Me.txtVInstPagoME.Text) Then

            '   MsgBox1.ShowMessage("Los valores deben ser numéricos!")

            '   Exit Sub
            'End If
         End If

         IdInstPago = CInt(Me.cmbInstPago.SelectedValue)
         IdTTxn = CInt(Me.cmbTipoTxn.SelectedValue)
         IdCanal = CInt(Me.cmbCanal.SelectedValue)

         NroOperaMN = CInt(Me.txtNroOperaMN.Text)
         NroOperaME = CInt(Me.txtNroOperaME.Text)
         ValOperaMN = CDbl(Me.txtVOperaMN.Text)
         ValOperaME = CDbl(Me.txtVOperaME.Text)
         Observaciones = Me.txtObservaciones.Text.ToUpper

         '----
         If Validar_Operacion(IdInstPago, IdTTxn, IdCanal, Coficina) Then
            Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").NewRow
            dr.Item("IdInstPago") = IdInstPago
            dr.Item("InstPago") = cmbInstPago.SelectedItem.Text
            dr.Item("IdTTxn") = IdTTxn
            dr.Item("TipoTxn") = cmbTipoTxn.SelectedItem.Text
            dr.Item("IdCanal") = IdCanal
            dr.Item("Canal") = cmbCanal.SelectedItem.Text
            dr.Item("NroOperaMN") = NroOperaMN
            dr.Item("NroOperaME") = NroOperaME
            dr.Item("ValOperaMN") = ValOperaMN
            dr.Item("ValOperaME") = ValOperaME
            dr.Item("Observaciones") = Observaciones
            dr.Item("cOficina") = Coficina
            dr.Item("Dependencia") = Dependencia
            dr.Item("UsuCrea") = CodUsuario
            dr.Item("FechaCrea") = Now

            DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Add(dr)
            dtgRegistro.DataBind()

            Acumular_Totales(NroOperaMN, NroOperaME, ValOperaMN, ValOperaME)
            Limpiar_Controles_Detalle()
         Else
            MsgBox1.ShowMessage("Operación ya ingresada")
         End If
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub

   Private Sub cmdElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElimina.Click

      Dim NroOperaMN As Integer
      Dim NroOperaME As Integer
      Dim ValOperaMN As Double
      Dim ValOperaME As Double
      Dim IdOficina As String
      Dim iFila As Integer


      iFila = dtgRegistro.SelectedIndex
      If iFila < 0 Then
         MsgBox1.ShowMessage("Debe Seleccionar una detalle Previamente!")
         Exit Sub
      End If
      Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila)
      NroOperaMN = dr.Item("NroOperaMN")
      NroOperaME = dr.Item("NroOperaME")
      ValOperaMN = dr.Item("ValOperaMN")
      ValOperaMN = dr.Item("ValOperaME")
      IdOficina = dr.Item("cOficina")


      If IdOficina <> Coficina Then
         MsgBox1.ShowMessage("No puede eliminar un registro de otra área")
         Exit Sub
      End If
      Actualizar_Totales(NroOperaMN, NroOperaME, ValOperaMN, ValOperaME)
      DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Delete()
      dtgRegistro.SelectedIndex = -1
      dtgRegistro.DataBind()

   End Sub
#End Region
#Region "********* Rutinas Diversas ********"

   Private Sub Limpiar_Controles_Detalle()
      Try
         Me.txtNroOperaMN.Text = 0
         Me.txtNroOperaME.Text = 0
         Me.txtVOperaMN.Text = 0
         Me.txtVOperaME.Text = 0
         Me.txtObservaciones.Text = ""

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Sub Acumular_Totales(ByVal NroOperaMN As Integer, ByVal NroOperaME As Integer, ByVal ValOperaMN As Double, ByVal ValOperaME As Double)
      Dim NInstPagoMN As Integer
      Dim NInstPagoME As Integer
      Dim VInstPagoMN As Double
      Dim VInstPagoME As Double
      Try

         NInstPagoMN = CInt(Me.txtNInstPagoMN.Text) + NroOperaMN
         Me.txtNInstPagoMN.Text = Format(NInstPagoMN, "##,###,##0")
         '---
         NInstPagoME = CInt(Me.txtNInstPagoME.Text) + NroOperaME
         Me.txtNInstPagoME.Text = Format(NInstPagoME, "##,###,##0")
         '--
         VInstPagoMN = CDbl(Me.txtVInstPagoMN.Text) + ValOperaMN
         Me.txtVInstPagoMN.Text = Format(VInstPagoMN, "##,###,##0.00")
         '---
         VInstPagoME = CDbl(Me.txtVInstPagoME.Text) + ValOperaME
         Me.txtVInstPagoME.Text = Format(VInstPagoME, "##,###,##0.00")

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Sub Actualizar_Totales(ByVal NroOperaMN As Integer, ByVal NroOperaME As Integer, ByVal ValOperaMN As Double, ByVal ValOperaME As Double)
      Dim NInstPagoMN As Integer
      Dim NInstPagoME As Integer
      Dim VInstPagoMN As Decimal
      Dim VInstPagoME As Decimal
      Try


         NInstPagoMN = CInt(Me.txtNInstPagoMN.Text) - NroOperaMN
         Me.txtNInstPagoMN.Text = Format(NInstPagoMN, "##,###,##0")
         '---
         NInstPagoME = CInt(Me.txtNInstPagoME.Text) - NroOperaME
         Me.txtNInstPagoME.Text = Format(NInstPagoME, "##,###,##0")
         '--
         VInstPagoMN = CDbl(Me.txtVInstPagoMN.Text) - ValOperaMN
         Me.txtVInstPagoMN.Text = Format(VInstPagoMN, "##,###,##0.00")
         '---
         VInstPagoME = CDbl(Me.txtVInstPagoME.Text) - ValOperaME
         Me.txtVInstPagoME.Text = Format(VInstPagoME, "##,###,##0.00")


      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Function Validar_Operacion(ByVal IdInstPago As Integer, ByVal IdTTxn As Integer, ByVal IdCanal As Integer, ByVal cOficina As String) As Boolean

      Dim xIdInstPAgo As Integer
      Dim xIdTTxn As Integer
      Dim xIdCanal As Integer
      Dim xcOficina As String
      Dim dr As DataRow



      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
         Return True
      End If
      For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
         Try

            xIdInstPAgo = dr.Item("IdInstPago")
            xIdTTxn = dr.Item("IdTTxn")
            xIdCanal = dr.Item("IdCanal")
            xcOficina = dr.Item("cOficina")


            If IdInstPago = xIdInstPAgo And _
               IdTTxn = xIdTTxn And _
               IdCanal = xIdCanal And _
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
        cmdAceptaP.Enabled = False
        If Me.txtAnno.Text = "" Then
            MsgBox1.ShowMessage("Debe ingresar el año del periodo a registrar")
            Return
        End If
        Me.Panel1.Enabled = True
        Obtener_Informacion_Formato2()
        Formato_Grilla_Registro()
        Me.pnlGrilla.Visible = True

        If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then
            'Registro Existe
            Accion = 2
            '    cmdNuevo.Visible = False
            '    cmdModificar.Visible = False
            '    cmdEliminar.Visible = False
            Mostrar_Informacion_Formato2()
        Else
            Accion = 1
            Me.txtNInstPagoMN.Text = 0
            Me.txtNInstPagoME.Text = 0
            Me.txtVInstPagoMN.Text = 0
            Me.txtVInstPagoME.Text = 0
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
            oBDSQL.Actualizar_RegistroControl(2, Periodo, CodTrabajador)

        Catch ex As Exception

            MsgBox1.ShowMessage(ErrMsg)
        End Try

    End Sub

End Class
