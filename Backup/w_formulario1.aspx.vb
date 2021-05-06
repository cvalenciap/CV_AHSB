Imports System.Web.Security
Imports System.Web.UI

Public Class w_formulario1


    Inherits System.Web.UI.Page


   Const sCOM_DESC_EXCEPCION As String = ":BN-Event:"
   Const sCOM_CHAR_IZQUIERDO As String = "["
   Const sCOM_CHAR_DERECHO As String = "]"
   Const sCOM_CHAR_DERECHOGUION As String = "]-"
   Const sCOM_CHAR_SEPARADOR As String = "/"
    Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton

   Dim sNombreClase = "w_formulario1"

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
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
   Protected WithEvents lblTCAutomaticos As System.Web.UI.WebControls.Label
   Protected WithEvents lblTCCorresponsal As System.Web.UI.WebControls.Label
   Protected WithEvents lblTPuntosCaja As System.Web.UI.WebControls.Label
   Protected WithEvents lblTTarjetas As System.Web.UI.WebControls.Label
   Protected WithEvents txtTCAutomaticos As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTCCorresponsal As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtTPuntosCaja As System.Web.UI.WebControls.TextBox
   Protected WithEvents pnlDetalle As System.Web.UI.WebControls.Panel
   Protected WithEvents lblOperacion As System.Web.UI.WebControls.Label
   Protected WithEvents cmbOperacion As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblTOperacion As System.Web.UI.WebControls.Label
   Protected WithEvents cmbTOperacion As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblEstado As System.Web.UI.WebControls.Label
   Protected WithEvents cmbEstado As System.Web.UI.WebControls.DropDownList
   Protected WithEvents lblNroOpera As System.Web.UI.WebControls.Label
   Protected WithEvents txtNroOpera As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblObservaciones As System.Web.UI.WebControls.Label
   Protected WithEvents txtObservaciones As System.Web.UI.WebControls.TextBox
   Protected WithEvents cmdAgrega As System.Web.UI.WebControls.Button
   Protected WithEvents cmdElimina As System.Web.UI.WebControls.Button
   Protected WithEvents dtgRegistro As System.Web.UI.WebControls.DataGrid
   Protected WithEvents txtTTarjetas As System.Web.UI.WebControls.TextBox
   Protected WithEvents Panel1 As System.Web.UI.WebControls.Panel
   Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
   Protected WithEvents CompareValidator1 As System.Web.UI.WebControls.CompareValidator
   Protected WithEvents lblTLCredito As System.Web.UI.WebControls.Label
   Protected WithEvents txtTLCredito As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblTClientes As System.Web.UI.WebControls.Label
   Protected WithEvents txtTClientes As System.Web.UI.WebControls.TextBox
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
   Private xOperacion As DataTable
   Private xTOperacion As DataTable
   Private xEstado As DataTable
   Private IdOPeracion As Integer
    Private NroOPeraciones As Integer
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
   Public Property qTCAutomatico() As Integer
      Get
         Return Session("xqTCAutomatico")
      End Get
      Set(ByVal Value As Integer)
         Session("xqTCAutomatico") = Value
      End Set
   End Property

   Public Property qTCCorresponsal() As Integer
      Get
         Return Session("xqTCCorresponsal")
      End Get
      Set(ByVal Value As Integer)
         Session("xqTCCorresponsal") = Value
      End Set
   End Property
   Public Property qTPuntos() As Integer
      Get
         Return Session("xqTPuntos")
      End Get
      Set(ByVal Value As Integer)
         Session("xqTPuntos") = Value
      End Set
   End Property
   Public Property qTTarjetas() As Integer
      Get
         Return Session("xqTTarjetas")
      End Get
      Set(ByVal Value As Integer)
         Session("xqTTarjetas") = Value
      End Set
   End Property
   Public Property qTLCredito() As Integer
      Get
         Return Session("xqTLCredito")
      End Get
      Set(ByVal Value As Integer)
         Session("xqTLCredito") = Value
      End Set
   End Property
   Public Property qTClientes() As Integer
      Get
         Return Session("xqTClientes")
      End Get
      Set(ByVal Value As Integer)
         Session("xqTClientes") = Value
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
            'Response.Redirect("PaginaSesionCaducada.htm")
            Response.Redirect("w_PaginaSesionCaducada.aspx")
        End If
        If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.REGISTRO_FORMULARIOS, 1) = "N" Then
            Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
        End If

        Me.lnkSalir.Attributes.Add("onClick", "setGoodLink();")
        cmdAceptaP.Enabled = True

        Leer_Parametros()
        If Not Page.IsPostBack Then
            Me.txtAnno.Text = CStr(Year(Now()))
            oLoad = True
            Dim oBDSQL As New BNOperacion

            Try
                Existe = 0
                Existe = oBDSQL.Verificar_RegistroControl(1, Session("xCodTrabajador"))


                If Existe = 1 Then
                    Dim mensaje = "EL FORMATO 1 SE ENCUENTRA EN USO, INTENTE MAS TARDE"
                    Response.Redirect("w_central.aspx?ErrMsg=" & mensaje)
                    Return
                Else
                    Obtener_Informacion_Formato1()
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
      dgBoundColumn = New BoundColumn
      dgBoundColumn.HeaderText = "Observaciones"
      dgBoundColumn.DataField = "Observaciones"
      dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
      dtgRegistro.Columns.Add(dgBoundColumn)
      ''============================================================
      '' Septima Columna: Dependencia
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
         ' cmdModificar.Visible = True
         ' cmdEliminar.Visible = True
         cmdAceptar.Visible = False
         cmdCancelar.Visible = False

      End If
      Panel1.Enabled = False
      ' Me.pnlDetalle.Enabled = False

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
      Dim nReporte As Integer = 1


      Dim dr As DataRow
      Dim oDBSQL As New BNOperacion
      Dim MensajeTermino As String
      Dim sender As System.Object
      Dim e As System.EventArgs

      Dim CodBCR As String
      Dim Normativa As String
      Dim Funcionario As String
      Dim Periodo As String
      'Dim qTCAutomatico As Integer
      'Dim qTCCorresponsal As Integer
      'Dim qTPuntos As Integer
      'Dim qTTarjetas As Integer
      'Dim qTLCredito As Integer
      'Dim qTClientes As Integer


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
         'qTCAutomatico = CInt(Me.txtTCAutomaticos.Text)
         'qTCCorresponsal = CInt(Me.txtTCCorresponsal.Text)
         'qTPuntos = CInt(Me.txtTPuntosCaja.Text)
         'qTTarjetas = CInt(Me.txtTTarjetas.Text)
         'qTLCredito = CInt(Me.txtTLCredito.Text)
         'qTClientes = CInt(Me.txtTClientes.Text)


         ' 4to) Otras Variables...
         '===========================================================================
        
        
         Select Case Accion
            Case Is = 1
                    Grabar_DetallexRegistro(oDBSQL, Periodo)
                    oDBSQL.Grabar_NuevoForm1Cabecera(Periodo, CodBCR, Normativa, nReporte, _
                                                Funcionario, qTCAutomatico, qTCCorresponsal, qTPuntos, qTTarjetas, _
                                                 qTLCredito, qTClientes)

               MensajeTermino = " Grabo "
            Case Is = 2
               Grabar_DetallexRegistro(oDBSQL, Periodo)
               oDBSQL.Modificar_Form1Cabecera(Periodo, nReporte, _
                                                 qTCAutomatico, qTCCorresponsal, qTPuntos, qTTarjetas, _
                                                 qTLCredito, qTClientes)
               MensajeTermino = " Modifico "
            Case Is = 3
               'oDBSQL.Eliminar_FormRegistro(ID_Registro, CodUsuario)
               MensajeTermino = " Elimino "


         End Select

         ' Grabar_DetallexRegistro(oDBSQL, Periodo)

         MsgBox1.ShowMessage("El Registro se" + MensajeTermino + "Correctamente!")

            ' If Accion = 3 Then
            SalirPagina()
            'End If
            cmdCancelar_Click(sender, e)
            Response.Redirect("w_central.aspx")
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try

   End Sub

   Private Sub Grabar_DetallexRegistro(ByVal oDBSQL As BNOperacion, ByVal Periodo As String)

      Dim IdOperacion As Integer
      Dim IdTOperacion As Integer
      Dim IdEstado As Integer
      Dim NroOperaciones As Integer
      Dim Observaciones As String
      Dim CodOficina As String
      Dim UsuCrea As String
      Dim FechaCrea As Date

      Dim Bnlog As New BNOperacion
      Dim sNombreMetodo = "Grabar Formulario"

      qTCAutomatico = 0
      qTPuntos = 0
      qTTarjetas = 0
      qTLCredito = 0
      qTClientes = 0

      '    '    Dim CodUsuario As String
      '    '   Dim Coficina As String
      '    '----
      '    '    CodUsuario = "0293784"
      '    '   Coficina = "0002"

      Dim dr As DataRow
      Dim Indice As Integer
        Try

            ' oDBSQL.Actualizar_RegistroControl(1, Periodo, Session("xCodTrabajador"))

            If Accion > 1 Then
                oDBSQL.Eliminar_Form1Registro(Periodo, Accion, CodUsuario, ErrMsg)
            End If
            If Accion = 3 Then
                Exit Sub
            End If
            For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
                Try
                    IdOperacion = dr.Item("IdOperacion")
                    IdTOperacion = dr.Item("IdTOPeracion")
                    IdEstado = dr.Item("IdEstado")
                    NroOperaciones = dr.Item("NroOperaciones")
                    Observaciones = dr.Item("Observaciones")
                    CodOficina = dr.Item("cOficina")
                    UsuCrea = dr.Item("UsuCrea")
                    FechaCrea = dr.Item("FechaCrea")
                    oDBSQL.Insertar_DetalleForm1(Periodo, IdOperacion, IdTOperacion, IdEstado, _
                                                         NroOperaciones, Observaciones, UsuCrea, CodOficina, FechaCrea)


                    Select Case Mid(CStr(IdOperacion), 1, 1)
                        Case "1"
                            If Mid(CStr(IdOperacion), 2, 1) = "4" Then
                                qTCCorresponsal += NroOperaciones
                            Else
                                qTCAutomatico += NroOperaciones
                            End If
                        Case "2"
                            qTPuntos += NroOperaciones
                        Case "3"
                            If Mid(CStr(IdOperacion), 2, 1) = "4" Then
                                qTLCredito += NroOperaciones
                            Else
                                qTTarjetas += NroOperaciones
                            End If
                        Case "4"
                            qTClientes += NroOperaciones
                    End Select

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
   Private Sub Obtener_Informacion_Formato1()
        Dim oBDSQL As New BNOperacion

      Dim Periodo As String
        Dim Mes As String
        ' Dim Existe As Integer
        Mes = Right("00" + RTrim(Me.cmbMes.SelectedIndex.ToString + 1), 2)
        Periodo = Mes + Me.txtAnno.Text

        Try
           
            Existe = oBDSQL.Grabar_RegistroControl(1, Periodo, Session("xCodTrabajador"))

            If Existe = 1 Then

                Return
            Else

                DSInfoRegistro = oBDSQL.Get_InfoFormato1(Periodo, ErrMsg)
            End If
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
        Catch ex As Exception
            MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub

    Private Sub Leer_Parametros()
        Dim oDBSQL As New BNOperacion
        Dim oBDSQL As New BNOperacion
        Dim dtParametro As DataTable

        dtParametro = oDBSQL.Leer_Parametros(ErrMsg)

        Me.lblaCodBCR.Text = dtParametro.Rows(0).Item("CodBCR").ToString
        Me.lblaNormativa.Text = dtParametro.Rows(0).Item("Normativa").ToString
        Me.lblaFuncionario.Text = dtParametro.Rows(0).Item("Funcionario").ToString



    End Sub
#End Region

#Region "   * * * Interacción con la Grilla de Detalle * * *   "

   Private Sub cmdAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrega.Click

      Dim IdOperacion As Integer
      Dim IdTOperacion As Integer
      Dim IdEstado As Integer
      Dim NroOperaciones As Integer
      Dim Observaciones As String
      Dim SearchChar As String
      Dim SearchString As String
      Dim Valida As Integer
      Dim nCaracteres As Integer

      Try
         If Me.txtNroOpera.Text = 0 Then
            MsgBox1.ShowMessage("No ha ingresado la Cantidad de Operaciones!")
            Exit Sub
            '   'Else
            '   '   If Not IsNumeric(Me.txtNroOpera.Text) Then
            '   '      MsgBox1.ShowMessage("Cantidad de Operaciones debe ser numérico!")
            '   '      txtNroOpera.Text = ""
            '   '      Exit Sub
            '   '   End If
         End If

         IdOperacion = CInt(Me.cmbOperacion.SelectedValue)
         IdTOperacion = CInt(Me.cmbTOperacion.SelectedValue)
         IdEstado = CInt(Me.cmbEstado.SelectedValue)

         NroOperaciones = CInt(Me.txtNroOpera.Text)
         Observaciones = Me.txtObservaciones.Text.ToUpper

         '----
         If Validar_Operacion(IdOperacion, IdTOperacion, IdEstado, Coficina) Then
            Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").NewRow
            dr.Item("IdOperacion") = IdOperacion
            dr.Item("Operacion") = cmbOperacion.SelectedItem.Text
            dr.Item("IdTOperacion") = IdTOperacion
            dr.Item("TOperacion") = cmbTOperacion.SelectedItem.Text
            dr.Item("IdEstado") = IdEstado
            dr.Item("Estado") = cmbEstado.SelectedItem.Text
            dr.Item("NroOperaciones") = NroOperaciones
            dr.Item("Observaciones") = Observaciones
            dr.Item("cOficina") = Coficina
            dr.Item("Dependencia") = Dependencia
            dr.Item("UsuCrea") = CodUsuario
            dr.Item("FechaCrea") = Now

            DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Add(dr)
            dtgRegistro.DataBind()
            Limpiar_Controles_Detalle()
            Acumular_Totales(IdOperacion, NroOperaciones)

         Else

            MsgBox1.ShowMessage("Operación ya ingresada")
         End If



      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)


      End Try

   End Sub

   Private Sub cmdElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElimina.Click
      Dim IdOperacion As Integer
      Dim NroOperaciones As Integer
      Dim IdOficina As String
      Dim iFila As Integer

      
      iFila = dtgRegistro.SelectedIndex
      If iFila < 0 Then
         MsgBox1.ShowMessage("Debe Seleccionar una detalle Previamente!")
         Exit Sub
      End If

      Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila)
      IdOperacion = dr.Item("IdOperacion")
      NroOperaciones = dr.Item("NroOperaciones")
      IdOficina = dr.Item("cOficina")

      If IdOficina <> Coficina Then
         MsgBox1.ShowMessage("No puede eliminar un registro de otra área")
         Exit Sub
      End If

      Actualizar_Totales(IdOperacion, NroOperaciones)

      DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Delete()
      dtgRegistro.SelectedIndex = -1
      dtgRegistro.DataBind()

   End Sub
#End Region
#Region "********* Rutinas Diversas ********"
   
   Private Sub Limpiar_Controles_Detalle()
      Try
         Me.txtNroOpera.Text = 0
         Me.txtObservaciones.Text = ""
         ' Me.lblIndx.Text = ""

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Sub Acumular_Totales(ByVal IdOperacion As Integer, ByVal NroOperaciones As Integer)
      Dim tCorresponsal As Integer
      Dim tCAutomatico As Integer
      Dim tPuntos As Integer
      Dim tTarjetas As Integer
      Dim tLCredito As Integer
      Dim tClientes As Integer

      Try

         Select Case Mid(CStr(IdOperacion), 1, 1)
            Case "1"
               If Mid(CStr(IdOperacion), 2, 1) = "4" Then
                  tCorresponsal = CInt(Me.txtTCCorresponsal.Text) + NroOperaciones
                  Me.txtTCCorresponsal.Text = Format(tCorresponsal, "##,###,##0")
               Else
                  tCAutomatico = Me.txtTCAutomaticos.Text
                  tCAutomatico += NroOperaciones
                  Me.txtTCAutomaticos.Text = Format(tCAutomatico, "##,###,##0")
               End If
            Case "2"
               tPuntos = CInt(Me.txtTPuntosCaja.Text) + NroOperaciones
               Me.txtTPuntosCaja.Text = Format(tPuntos, "##,###,##0")
            Case "3"
               If Mid(CStr(IdOperacion), 1, 1) = "3" Then
                  If Mid(CStr(IdOperacion), 2, 1) = "4" Then
                     tLCredito = CInt(Me.txtTLCredito.Text) + NroOperaciones
                     Me.txtTLCredito.Text = Format(tLCredito, "##,###,##0")
                  Else
                     tTarjetas = CInt(Me.txtTTarjetas.Text) + NroOperaciones
                     Me.txtTTarjetas.Text = Format(tTarjetas, "##,###,##0")
                  End If
               End If
            Case "4"
               tClientes = CInt(Me.txtTClientes.Text) + NroOperaciones
               Me.txtTClientes.Text = Format(tClientes, "##,###,##0")
         End Select

      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Sub Actualizar_Totales(ByVal IdOperacion As Integer, ByVal NroOperaciones As Integer)
      Dim tCorresponsal As Integer
      Dim tCAutomatico As Integer
      Dim tPuntos As Integer
      Dim tTarjetas As Integer
      Dim tLCredito As Integer
      Dim tClientes As Integer
      Try
         Select Case Mid(CStr(IdOperacion), 1, 1)
            Case "1"
               If Mid(CStr(IdOperacion), 2, 1) = "4" Then
                  tCorresponsal = CInt(Me.txtTCCorresponsal.Text) - NroOperaciones
                  Me.txtTCCorresponsal.Text = Format(tCorresponsal, "##,###,##0")
               Else
                  tCAutomatico = Me.txtTCAutomaticos.Text
                  tCAutomatico += NroOperaciones
                  Me.txtTCAutomaticos.Text = Format(tCAutomatico, "##,###,##0")
               End If
            Case "2"
               tPuntos = CInt(Me.txtTPuntosCaja.Text) - NroOperaciones
               Me.txtTPuntosCaja.Text = Format(tPuntos, "##,###,##0")
            Case "3"
               If Mid(CStr(IdOperacion), 1, 1) = "3" Then
                  If Mid(CStr(IdOperacion), 2, 1) = "4" Then
                     tLCredito = CInt(Me.txtTLCredito.Text) - NroOperaciones
                     Me.txtTLCredito.Text = Format(tLCredito, "##,###,##0")
                  Else
                     tTarjetas = CInt(Me.txtTTarjetas.Text) - NroOperaciones
                     Me.txtTTarjetas.Text = Format(tTarjetas, "##,###,##0")
                  End If
               End If
            Case "4"
               tClientes = CInt(Me.txtTClientes.Text) - NroOperaciones
               Me.txtTClientes.Text = Format(tClientes, "##,###,##0")
         End Select
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub
   Private Function Validar_Operacion(ByVal IdOperacion As Integer, ByVal IdTOperacion As Integer, ByVal IdEstado As Integer, ByVal COficina As String) As Boolean

      Dim xIdOperacion As Integer
      Dim xIdTOperacion As Integer
      Dim xIdEstado As Integer
      Dim xCoficina As String
      Dim dr As DataRow
      Dim Bnlog As New BNOperacion
      Dim sNombreMetodo = Validar_Operacion

      If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
         Return True
      End If
      For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
         Try

            xIdOperacion = dr.Item("IdOperacion")
            xIdTOperacion = dr.Item("IdTOperacion")
            xIdEstado = dr.Item("IdEstado")
            xCoficina = dr.Item("Coficina")


            If IdOperacion = xIdOperacion And _
               IdTOperacion = xIdTOperacion And _
               IdEstado = xIdEstado And _
               COficina = xCoficina Then
               Return False
            End If



         Catch ex As Exception
            Dim Err$ = ex.Message
       

         End Try
      Next

      Return True
   End Function
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



   'Private Sub cmbModeloVehiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '    Dim dvModelo As New DataView
   '    dvModelo = DTModelo.DefaultView
   '    dvModelo.RowFilter = "ID_Modelo = " & CType(cmbModeloVehiculo.SelectedValue, String)
   '    Dim dr2 As DataRowView

   '    For Each dr2 In dvModelo
   '        txtSerieInicio.Text = dr2.Item("SerieIni")
   '    Next

   'End Sub
   'Private Sub rbOriginales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '    If rbOriginales.Checked Then
   '        Me.rbDuplicadas.Checked = False
   '        Me.rbDuplicadas.Enabled = False
   '        Me.lblRangoInicial.Text = "Nro. Inicial"
   '        Me.lblRangoFinal.Visible = True
   '        Me.txtRangoFinal.Visible = True
   '        pnlDetalle.Enabled = True
   '        pnlGrilla.Enabled = True

   '        Me.txtSerie.MaxLength = 3
   '        '   Me.txtRangoFinal.MaxLength = 3
   '        '   Me.txtRangoInicial.MaxLength = 3

   '    End If
   'End Sub

   'Private Sub rbDuplicadas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '    If rbDuplicadas.Checked Then
   '        rbOriginales.Checked = False
   '        Me.lblRangoInicial.Text = "Nro. de Placa"
   '        Me.lblRangoFinal.Visible = False
   '        Me.txtRangoFinal.Visible = False
   '        pnlDetalle.Enabled = True
   '        pnlGrilla.Enabled = True
   '    End If
   'End Sub
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
        Obtener_Informacion_Formato1()
        Formato_Grilla_Registro()
        Me.pnlGrilla.Visible = True

        If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count > 0 Then
            'Registro Existe
            Accion = 2
            '    cmdNuevo.Visible = False
            '    cmdModificar.Visible = False
            '    cmdEliminar.Visible = False
            Mostrar_Informacion_Formato1()
        Else
            Accion = 1
            Me.txtTCAutomaticos.Text = 0
            Me.txtTCCorresponsal.Text = 0
            Me.txtTPuntosCaja.Text = 0
            Me.txtTTarjetas.Text = 0
            Me.txtTLCredito.Text = 0
            Me.txtTClientes.Text = 0
        End If
        cmdAceptar.Visible = True
        cmdAceptar.Text = "Grabar"
        cmdCancelar.Visible = True
        cmdCancelar.Text = "Cancelar"
   End Sub

 
  
   
  
    
End Class
