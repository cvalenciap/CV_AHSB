Imports System.Web.Security
Imports System.Web.UI.WebControls

Public Class w_formulario2


    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents cmdAgrega As System.Web.UI.WebControls.Button
    Protected WithEvents cmdElimina As System.Web.UI.WebControls.Button
    Protected WithEvents cmdCancelar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdEliminar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdAceptar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdModificar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdNuevo As System.Web.UI.WebControls.Button
    Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton
    Protected WithEvents pnlDetalle As System.Web.UI.WebControls.Panel
    Protected WithEvents lblPeriodo As System.Web.UI.WebControls.Label
    Protected WithEvents txtPeriodo As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblFuncionario As System.Web.UI.WebControls.Label
    Protected WithEvents txtFuncionario As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCodBCR As System.Web.UI.WebControls.Label
    Protected WithEvents lblNormativa As System.Web.UI.WebControls.Label
    Protected WithEvents txtCodBCR As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNormativa As System.Web.UI.WebControls.TextBox
    Protected WithEvents Dropdownlist1 As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblInstPago As System.Web.UI.WebControls.Label
    Protected WithEvents lblCanal As System.Web.UI.WebControls.Label
    Protected WithEvents lblNroOperaMN As System.Web.UI.WebControls.Label
    Protected WithEvents txtNroOperaMN As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblNroOperaME As System.Web.UI.WebControls.Label
    Protected WithEvents txtNroOperaME As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblValorOperaMN As System.Web.UI.WebControls.Label
    Protected WithEvents lblValorOperaME As System.Web.UI.WebControls.Label
    Protected WithEvents lblTransaccion As System.Web.UI.WebControls.Label
    Protected WithEvents lblObservaciones As System.Web.UI.WebControls.Label
    Protected WithEvents cmbInstPago As System.Web.UI.WebControls.DropDownList
    Protected WithEvents cmbTransaccion As System.Web.UI.WebControls.DropDownList
    Protected WithEvents cmbCanal As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtObservaciones As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtValorOperaMN As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtValorOperaME As System.Web.UI.WebControls.TextBox
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
    Private xTVehiculo As DataTable
    Private xModelo As DataTable
    Private xColorFondo As DataTable
    Private xColorLetra As DataTable

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

    Public Property CodTrabajador() As String
        Get
            Return Session("xCodTrabajador")
        End Get
        Set(ByVal Value As String)
            Session("xCodTrabajador") = Value
        End Set

    End Property

    Public Property ID_Registro() As Integer
        Get
            Return Session("xIDRegistro")
        End Get
        Set(ByVal Value As Integer)
            Session("xIDRegistro") = Value
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

    Public Property DTVehiculo() As DataTable
        Get
            Return xTVehiculo
        End Get
        Set(ByVal Value As DataTable)
            xTVehiculo = Value
        End Set
    End Property

    Public Property DTModelo() As DataTable
        Get
            Return xModelo
        End Get
        Set(ByVal Value As DataTable)
            xModelo = Value
        End Set
    End Property

    Public Property DTColorFondo() As DataTable
        Get
            Return xColorFondo
        End Get
        Set(ByVal Value As DataTable)
            xColorFondo = Value
        End Set
    End Property

    Public Property DTColorLetra() As DataTable
        Get
            Return xColorLetra
        End Get
        Set(ByVal Value As DataTable)
            xColorLetra = Value
        End Set
    End Property


    Private Sub Cargar_Controles()
        'Dim oDBSQL As New BNOperacion
        'Dim dsControl As DataSet = oDBSQL.Get_FormRegistro(ErrMsg)

        'DTVehiculo = dsControl.Tables("TVehiculo")
        'DTModelo = dsControl.Tables("Modelo")
        'DTColorFondo = dsControl.Tables("ColorFondo")
        'DTColorLetra = dsControl.Tables("ColorLetra")

        'Me.cmbTVehiculo.DataSource = DTVehiculo
        'Me.cmbTVehiculo.DataValueField = DTVehiculo.Columns(0).ColumnName
        'Me.cmbTVehiculo.DataTextField = DTVehiculo.Columns(1).ColumnName
        'Me.cmbTVehiculo.DataBind()

        'Me.cmbModeloVehiculo.DataSource = DTModelo
        'Me.cmbModeloVehiculo.DataValueField = DTModelo.Columns(0).ColumnName
        'Me.cmbModeloVehiculo.DataTextField = DTModelo.Columns(1).ColumnName
        'Me.cmbModeloVehiculo.DataBind()

        'Me.cmbColorFondo.DataSource = DTColorFondo
        'Me.cmbColorFondo.DataValueField = DTColorFondo.Columns(0).ColumnName
        'Me.cmbColorFondo.DataTextField = DTColorFondo.Columns(1).ColumnName
        'Me.cmbColorFondo.DataBind()

        'Me.cmbColorLetra.DataSource = DTColorLetra
        'Me.cmbColorLetra.DataValueField = DTColorFondo.Columns(0).ColumnName
        'Me.cmbColorLetra.DataTextField = DTColorFondo.Columns(1).ColumnName
        'Me.cmbColorLetra.DataBind()

    End Sub

#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Session("xLogOnPerfil") Is Nothing Then
            FormsAuthentication.SignOut()
            Response.Redirect("PaginaSesionCaducada.htm")
        End If
        'If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.REGISTRO_PLACAS, 1) = "N" Then
        '    Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
        'End If

        If Not Page.IsPostBack Then
            oLoad = True
            Me.pnlDetalle.Enabled = False
            'Me.pnlGrilla.Enabled = False
            ID_Registro = Request.QueryString("ID_Nodo")
            'ID_Registro = 0

            'If ID_Registro = 0 Then
            '    Accion = 1

            '    cmdNuevo.Visible = False
            '    cmdModificar.Visible = False
            '    cmdEliminar.Visible = False
            '    cmdAceptar.Visible = True
            '    cmdAceptar.Text = "Grabar"
            '    cmdCancelar.Visible = True
            '    cmdCancelar.Text = "Cancelar"

            'Else
            '    cmdModificar.Visible = True
            '    cmdEliminar.Visible = True
            '    cmdAceptar.Visible = False
            '    cmdCancelar.Visible = False
            '    Me.rbDuplicadas.Enabled = False
            '    Me.rbOriginales.Enabled = False
            'End If


            'Obtener_Informacion_Registro()
            'Mostrar_Informacion_Registro()
            'cmbTVehiculo_SelectedIndexChanged(sender, e)

            'Me.cmbColorLetra.SelectedValue = 7  ' letras negras
            'Me.cmbColorFondo.SelectedValue = 4  'Mayores amarillo

        End If


        'Me.txtFIngreso.Text = CDate(Now.Date.ToShortDateString)
        'Formato_Grilla_Registro()
    End Sub
#Region "*** Formato Grilla Registro ****"

    Private Sub Formato_Grilla_Registro()

        'dtgRegistro.Columns.Clear()
        'dtgRegistro.DataSource = DSInfoRegistro.Tables("InfoRegistro_Detalle")
        'dtgRegistro.AutoGenerateColumns = False
        'dtgRegistro.AllowPaging = False

        'Dim dgBoundColumn As BoundColumn
        'Dim dgButtonColumn As ButtonColumn
        ''============================================================
        '' Primera Columna: Selector de Fila
        ''============================================================
        'dgButtonColumn = New ButtonColumn
        'dgButtonColumn.ButtonType = ButtonColumnType.LinkButton
        'dgButtonColumn.HeaderText = "Selección"
        'dgButtonColumn.Text = "==>"
        'dgButtonColumn.CommandName = "Select"
        'dtgRegistro.Columns.Add(dgButtonColumn)
        ''============================================================
        '' IDDetalle
        ''============================================================
        ''dgBoundColumn = New BoundColumn
        ''dgBoundColumn.HeaderText = "ID"
        ''dgBoundColumn.DataField = "ID_Detalle"
        ''dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        ''dtgRegistro.Columns.Add(dgBoundColumn)
        ''dgBoundColumn.Visible = False
        ''============================================================
        '' Segunda Columna: Modelo
        ''============================================================
        'dgBoundColumn = New BoundColumn
        'dgBoundColumn.HeaderText = "Modelo"
        'dgBoundColumn.DataField = "Modelo"
        'dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        'dtgRegistro.Columns.Add(dgBoundColumn)
        ''============================================================
        '' Tercera Columna: Serie
        ''============================================================
        'dgBoundColumn = New BoundColumn
        'dgBoundColumn.HeaderText = "Serie"
        'dgBoundColumn.DataField = "Serie"
        'dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        'dtgRegistro.Columns.Add(dgBoundColumn)
        ''============================================================
        '' Cuarta Columna: Nro. Inicial
        ''============================================================
        'dgBoundColumn = New BoundColumn
        'dgBoundColumn.HeaderText = "Rango Inicial"
        'dgBoundColumn.DataField = "RangoInicial"
        'dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        'dtgRegistro.Columns.Add(dgBoundColumn)

        ''============================================================
        '' Quinta Columna: Nro. Final
        ''============================================================
        'dgBoundColumn = New BoundColumn
        'dgBoundColumn.HeaderText = "Rango Final"
        'dgBoundColumn.DataField = "RangoFinal"
        'dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        'dtgRegistro.Columns.Add(dgBoundColumn)
        ''============================================================
        '' Sexta Columna: Color Fondo
        ''============================================================
        'dgBoundColumn = New BoundColumn
        'dgBoundColumn.HeaderText = "Color Fondo"
        'dgBoundColumn.DataField = "ColorFondo"
        'dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
        'dtgRegistro.Columns.Add(dgBoundColumn)
        ''============================================================
        '' Septima Columna: Color Letra
        ''============================================================
        'dgBoundColumn = New BoundColumn
        'dgBoundColumn.HeaderText = "Color Letra"
        'dgBoundColumn.DataField = "ColorLetra"
        'dgBoundColumn.ItemStyle.Width = New Unit(50, UnitType.Cm)
        'dtgRegistro.Columns.Add(dgBoundColumn)


        'dtgRegistro.DataBind()
        'dtgRegistro.Visible = True
    End Sub
#End Region



#Region "   * * * Interacción con los Botones de Control * * *   "

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click


        '===========================================================================
        ' Campos Requeridos
        '===========================================================================
        'If rbOriginales.Checked = False And rbDuplicadas.Checked = False Then
        '    MsgBox1.ShowMessage("Debe seleccionar el Tipo de Placa!")
        '    Exit Sub

        'End If
        'If Accion < 3 Then
        '    If Me.txtNroActa.Text = "" Then
        '        MsgBox1.ShowMessage("No ha ingresado el Nro. de Acta!")
        '        Exit Sub
        '    End If

        'End If

        'If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
        '    MsgBox1.ShowMessage("No ha registrado ningun rango de placas")
        '    Exit Sub
        'End If
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

        'MsgBox1.ShowConfirmation(msgAccionEvento, _
        '                             "GRABAR", True, True)


    End Sub



    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Accion > 1 Then
            cmdModificar.Visible = True
            cmdEliminar.Visible = True
            cmdAceptar.Visible = False
            cmdCancelar.Visible = False

        End If
        pnlDetalle.Enabled = False


        'rbOriginales.Checked = False
        'rbOriginales.Enabled = True
        'rbDuplicadas.Checked = False
        'rbDuplicadas.Enabled = True
        'txtNroActa.Text = ""
        Limpiar_Controles_Detalle()
        'If cmbTVehiculo.SelectedValue = 1 Then
        '    Me.cmbColorFondo.SelectedValue = 4  'Mayores amarillo

        'Else

        '    Me.cmbColorFondo.SelectedValue = 6  'Menores celeste
        '    Me.txtSerie.MaxLength = 2
        '    Me.txtRangoFinal.MaxLength = 5
        '    Me.txtRangoInicial.MaxLength = 5
        'End If
        'Me.DSInfoRegistro.Clear()
        'dtgRegistro.DataSource = Nothing
        'dtgRegistro.DataBind()
        'Cargar_Controles()


    End Sub


    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Accion = 3
        cmdNuevo.Visible = False
        cmdModificar.Visible = False
        cmdEliminar.Visible = False
        cmdAceptar.Visible = True
        cmdAceptar.Text = "SI"
        cmdCancelar.Visible = True
        cmdCancelar.Text = "NO"
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
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
        Dim IdTMovimiento As String = "I"
        Dim IdTDocumento As Integer = 2
        Dim NTicket As Integer
        '----
        Dim sender As System.Object
        Dim e As System.EventArgs

        Dim NroActa As String
        Dim FechaRegistro As String
        Dim TipoPlaca As Integer
        'Dim CodUsuario As String
        'Dim Coficina As String
        '----

        'CodUsuario = "0293784"
        'Coficina = "0002"

        '----
        Try
            '===========================================================================
            'Carga de Variables/Parametros en Memoria para enviar a la BD
            '===========================================================================
            ' 1ro) Panel de Información General
            '===========================================================================
            'If Me.rbOriginales.Checked Then
            '    TipoPlaca = 1
            'End If
            'If Me.rbDuplicadas.Checked Then
            '    TipoPlaca = 2
            'End If
            'NroActa = Me.txtNroActa.Text.Trim.ToUpper
            'FechaRegistro = Me.txtFIngreso.Text.Trim

            ' 4to) Otras Variables...
            '===========================================================================
            'Dim oDBSQL As New BNOperacion
            Dim MensajeTermino As String
            '===========================================================================

            'Select Case Accion
            '    Case Is = 1
            '        If Not Validar_Acta(NroActa, oDBSQL) Then
            '            MsgBox1.ShowMessage("Acta ya ha sido registrada")
            '            Exit Sub
            '        End If
            '        If Not Validar_PlacasRegistradas(IdTMovimiento, oDBSQL) Then
            '            MsgBox1.ShowMessage("Existen placas originales registradas para el rango ingresado")
            '            Exit Sub
            '        End If
            '        ID_Registro = oDBSQL.Grabar_NuevoFormRegistro(IdTMovimiento, FechaRegistro, TipoPlaca, IdTDocumento, NroActa, _
            '                                            CodUsuario, Coficina, NTicket, )

            '        MensajeTermino = " Grabo "
            '    Case Is = 2
            '        oDBSQL.Modificar_FormRegistro(ID_Registro, FechaRegistro, IdTDocumento, _
            '                                 NroActa, CodUsuario)
            '        MensajeTermino = " Modifico "
            '    Case Is = 3
            '        oDBSQL.Eliminar_FormRegistro(ID_Registro, CodUsuario)
            '        MensajeTermino = " Elimino "


            'End Select

            'Grabar_DetallexRegistro(oDBSQL)

            'MsgBox1.ShowMessage("El Registro se" + MensajeTermino + "Correctamente!")

            If Accion = 3 Then
                SalirPagina()
            End If
            cmdCancelar_Click(sender, e)
        Catch ex As Exception
            'MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub

    'Private Sub Grabar_DetallexRegistro(ByVal oDBSQL As BNOperacion)
    '    Dim IdTMovimiento As String = "I"

    '    Dim IdModelo As Integer
    '    Dim IdColorFondo As Integer
    '    Dim IdColorLetra As Integer
    '    Dim Serie As String
    '    Dim RangoInicial As String
    '    Dim RangoFinal As String

    '    '    Dim CodUsuario As String
    '    '   Dim Coficina As String
    '    '----
    '    '    CodUsuario = "0293784"
    '    '   Coficina = "0002"

    '    Dim dr As DataRow
    '    Dim Indice As Integer
    '    Dim NroPlaca As String
    '    Try
    '        If Accion > 1 Then
    '            oDBSQL.Eliminar_DetallexRegistro(ID_Registro, ErrMsg)
    '        End If
    '        If Accion = 3 Then
    '            Exit Sub
    '        End If
    '        For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
    '            Try
    '                IdModelo = dr.Item("ID_Modelo")
    '                IdColorFondo = dr.Item("ID_ColorFondo")
    '                IdColorLetra = dr.Item("ID_ColorLetra")
    '                Serie = dr.Item("Serie")
    '                RangoInicial = dr.Item("RangoInicial")
    '                RangoFinal = dr.Item("RangoFinal")

    '                Dim Lcompleta As New String("0", Len(RangoInicial))
    '                For Indice = Val(RangoInicial) To Val(RangoFinal)

    '                    NroPlaca = Right(Lcompleta + RTrim(CStr(Indice)), Len(Lcompleta))
    '                    oDBSQL.Insertar_DetallexRegistro(ID_Registro, IdModelo, IdColorFondo, IdColorLetra, _
    '                                                     Serie, RangoInicial, RangoFinal, CodUsuario, Coficina, NroPlaca, IdTMovimiento)
    '                Next


    '            Catch ex As Exception
    '                Dim Err$ = ex.Message
    '            End Try
    '        Next
    '    Catch ex As Exception
    '        MsgBox1.ShowMessage(ex.Message)
    '    End Try

    'End Sub
    Private Sub Obtener_Informacion_Registro()
        'Dim oBDSQL As New BNOperacion

        'Try
        '    DSInfoRegistro = oBDSQL.Get_InfoRegistro(ID_Registro, ErrMsg)

        'Catch ex As Exception
        '    MsgBox1.ShowMessage(ErrMsg)
        'End Try

    End Sub
    Private Sub Mostrar_Informacion_Registro()
        If ID_Registro = 0 Then Exit Sub

        Try
            Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_General").Rows(0)

            '===========================================================================
            ' 1ro) Panel de Información General
            '===========================================================================
            'If dr.Item("Id_TPlaca") = 1 Then
            '    Me.rbOriginales.Checked = True
            'Else
            '    Me.rbDuplicadas.Checked = True
            'End If
            'Me.txtFIngreso.Text = dr.Item("FechaRegistro")
            'Me.txtNroActa.Text = dr.Item("NDocumento")

        Catch ex As Exception
            'MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub
#End Region

#Region "   * * * Interacción con la Grilla de Detalle * * *   "

    Private Sub cmdAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrega.Click

        Dim IDModelo As Integer
        Dim Serie As String
        Dim IDColorFondo As Integer
        Dim IDColorLetra As Integer
        Dim RangoInicial As String
        Dim RangoFinal As String
        Dim SearchChar As String
        Dim SearchString As String
        Dim Valida As Integer
        Dim nCaracteres As Integer

        Try
            'IDColorFondo = CInt(cmbColorFondo.SelectedValue)
            'IDColorLetra = CInt(cmbColorLetra.SelectedValue)
            'IDModelo = CInt(cmbModeloVehiculo.SelectedValue)
            'If txtSerie.Text = "" Then
            '    MsgBox1.ShowMessage("No ha ingresado la Serie!")
            '    Exit Sub
            'End If
            'Serie = UCase(Trim(Me.txtSerie.Text))
            'If Me.rbOriginales.Checked And cmbTVehiculo.SelectedValue = 1 Then
            ' 07/02  Las series originales de remolques, volquetes y  otros siguen en 2 caracteres
            'If Len(Serie) < 3 Then
            '    MsgBox1.ShowMessage("La Serie no puede tener menos de 3 caracteres!")
            '    Exit Sub
            'End If
            'Else
            'If Len(Serie) < 2 Then
            '    MsgBox1.ShowMessage("La Serie no puede tener menos de 2 caracteres!")
            '    Exit Sub

            'End If
            'End If
            'If Me.rbOriginales.Checked Then
            'nCaracteres = IIf(cmbTVehiculo.SelectedValue = 1, 3, 5)
            'Else
            '    nCaracteres = IIf(cmbTVehiculo.SelectedValue = 1, IIf(Len(Serie) = 3, 3, 4), IIf(Len(Serie) = 3, 3, 5))
            'If Me.rbDuplicadas.Checked Then
            '    txtRangoFinal.Text = Me.txtRangoInicial.Text
            'End If

            Dim LCompleta As New String("0", nCaracteres)

            '---Verifica Rangos ingresados
            'If Me.txtRangoInicial.Text = "" Or Me.txtRangoFinal.Text = "" Then
            '    MsgBox1.ShowMessage("No ha ingresado uno de los rangos!")
            '    Exit Sub
            'End If


            'SearchChar = Mid(txtSerie.Text.Trim.ToUpper, 1, 1)
            'SearchString = Trim(txtSerieInicio.Text)
            'Valida = InStr(SearchString, SearchChar)
            'If Valida = 0 Then
            '    MsgBox1.ShowMessage("La Serie para " + cmbModeloVehiculo.SelectedItem.Text + " debe empezar con una de estas letras " + SearchString)
            '    Exit Sub
            'End If

            'If rbOriginales.Checked And (Val(txtRangoFinal.Text) < Val(txtRangoInicial.Text)) Then
            '    MsgBox1.ShowMessage("El Rango Final no puede ser menor que el inicial!")
            '    Exit Sub
            'End If
            'RangoInicial = IIf(IsNumeric(txtRangoInicial.Text), Right(LCompleta + RTrim(txtRangoInicial.Text), Len(LCompleta)), LCompleta)
            'RangoFinal = IIf(IsNumeric(txtRangoFinal.Text), Right(LCompleta + RTrim(txtRangoFinal.Text), Len(LCompleta)), LCompleta)

            'txtRangoInicial.Text = RangoInicial
            'txtRangoFinal.Text = RangoFinal

            '----
            'If Validar_Placas(Serie, RangoInicial, RangoFinal) Then
            '    Dim dr As DataRow = DSInfoRegistro.Tables("InfoRegistro_Detalle").NewRow
            '    dr.Item("Id_Modelo") = IDModelo
            '    dr.Item("Modelo") = cmbModeloVehiculo.SelectedItem.Text
            '    dr.Item("Serie") = Serie
            '    dr.Item("ID_ColorFondo") = IDColorFondo
            '    dr.Item("ColorFondo") = cmbColorFondo.SelectedItem.Text
            '    dr.Item("ID_ColorLetra") = IDColorLetra
            '    dr.Item("ColorLetra") = cmbColorLetra.SelectedItem.Text
            '    dr.Item("RangoInicial") = RangoInicial
            '    dr.Item("RangoFinal") = IIf(Me.rbOriginales.Checked, RangoFinal, RangoInicial)
            '    DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Add(dr)
            '    dtgRegistro.DataBind()
            '    Limpiar_Controles_Detalle()
            'Else
            '    MsgBox1.ShowMessage("La serie y rangos ya han sido registrados")
            'End If
        Catch ex As Exception
            'MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub

    Private Sub cmdElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElimina.Click
        'Dim iFila As Integer
        'iFila = dtgRegistro.SelectedIndex
        'If iFila < 0 Then
        '    MsgBox1.ShowMessage("Debe Seleccionar una detalle Previamente!")
        '    Exit Sub
        'End If
        'DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows(iFila).Delete()
        'dtgRegistro.SelectedIndex = -1
        'dtgRegistro.DataBind()

    End Sub
#End Region
#Region "********* Rutinas Diversas ********"
    Private Sub cmbTVehiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If oLoad Then
        '    Try
        '        Dim dvModelo As New DataView
        '        dvModelo = DTModelo.DefaultView
        '        dvModelo.RowFilter = "ID_TVehiculo= " & CType(cmbTVehiculo.SelectedValue, String)
        '        If dvModelo.Count > 0 Then
        '            cmbModeloVehiculo.DataSource = dvModelo
        '            cmbModeloVehiculo.DataValueField = dvModelo.Table.Columns(0).Caption
        '            cmbModeloVehiculo.DataTextField = dvModelo.Table.Columns(1).Caption
        '            cmbModeloVehiculo.Enabled = True
        '            cmbModeloVehiculo.DataBind()
        '        Else
        '            cmbModeloVehiculo.Enabled = False
        '        End If
        '    Catch ex As Exception
        '        MsgBox1.ShowMessage(ex.Message)
        '    End Try

        '    If cmbTVehiculo.SelectedValue = 1 Then
        '        Me.cmbColorFondo.SelectedValue = 4  'Mayores amarillo
        '        If rbOriginales.Checked Then
        '            Me.txtSerie.MaxLength = 3
        '            Me.txtRangoFinal.MaxLength = 3
        '            Me.txtRangoInicial.MaxLength = 3
        '        Else
        '            '  Me.txtSerie.MaxLength = 2
        '            Me.txtRangoFinal.MaxLength = 4
        '            Me.txtRangoInicial.MaxLength = 4
        '        End If

        '    Else

        '        Me.cmbColorFondo.SelectedValue = 6  'Menores celeste
        '        If rbOriginales.Checked Then
        '            Me.txtSerie.MaxLength = 2
        '        Else
        '            Me.txtSerie.MaxLength = 3
        '        End If
        '        Me.txtRangoFinal.MaxLength = 5
        '        Me.txtRangoInicial.MaxLength = 5
        '    End If
        '    cmbModeloVehiculo_SelectedIndexChanged(sender, e)
        'End If

    End Sub
    Private Sub Limpiar_Controles_Detalle()
        'Try
        '    Me.txtSerie.Text = ""
        '    Me.txtRangoFinal.Text = 0
        '    Me.txtRangoInicial.Text = 0
        'Catch ex As Exception
        '    MsgBox1.ShowMessage(ex.Message)
        'End Try
    End Sub
    Private Function Validar_Placas(ByVal Serie As String, ByVal RangoInicial As String, ByVal RangoFinal As String) As Boolean

        Dim xSerie As String
        Dim xRangoInicial As String
        Dim xRangoFinal As String
        Dim dr As DataRow

        If DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows.Count = 0 Then
            Return True
        End If
        For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
            Try
                xSerie = dr.Item("Serie")
                xRangoInicial = dr.Item("RangoInicial")
                xRangoFinal = dr.Item("RangoFinal")

                If Serie = xSerie Then
                    If RangoInicial >= xRangoInicial And RangoInicial <= xRangoFinal Then
                        Return False
                    End If
                    If RangoFinal >= xRangoInicial And RangoFinal <= xRangoFinal Then
                        Return False
                    End If

                End If
            Catch ex As Exception
                Dim Err$ = ex.Message
            End Try
        Next
        Return True
    End Function
    Private Sub SalirPagina()
        '   Response.Redirect("w_central.aspx")
    End Sub


    'Private Sub MsgBox1_YesChoosed(ByVal sender As Object, ByVal Key As String) Handles MsgBox1.YesChoosed
    '    Select Case Key
    '        Case "GRABAR"
    '            'Se confirmó que se desea grabar 
    '            EjecutarProceso()
    '        Case "ELIMINAR"
    '            'No se utiliza esta opcion.

    '    End Select
    '    ' cmdCancelar_Click(sender, e)
    'End Sub
    'Private Sub MsgBox1_NoChoosed(ByVal sender As Object, ByVal Key As String) Handles MsgBox1.NoChoosed
    '    Select Case Key
    '        Case "GRABAR"
    '            MsgBox1.ShowMessage("Accion Cancelada")
    '        Case "ELIMINAR"
    '            'No se utiliza esta opcion.
    '            '. 
    '    End Select
    'End Sub

    'Public Function Validar_Acta(ByVal NroActa As String, ByVal oDBSQL As BNOperacion) As Boolean


    '    Contador = oDBSQL.Verifica_Acta(NroActa)
    '    Try
    '        If Contador > 0 Then
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Dim Err$ = ex.Message
    '    End Try
    '    Return True
    'End Function
    'Public Function Validar_PlacasRegistradas(ByVal IdTMovimiento As String, ByVal oDBSQL As BNOperacion) As Boolean



    '    Dim Serie As String
    '    Dim RangoInicial As String
    '    Dim RangoFinal As String
    '    Dim dr As DataRow
    '    For Each dr In DSInfoRegistro.Tables("InfoRegistro_Detalle").Rows
    '        Try
    '            Serie = dr.Item("Serie")
    '            RangoInicial = dr.Item("RangoInicial")
    '            RangoFinal = dr.Item("RangoFinal")
    '            Contador = oDBSQL.Verifica_PlacasRegistradas(IdTMovimiento, Serie, RangoInicial, RangoFinal)

    '            If Contador > 0 Then
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Dim Err$ = ex.Message
    '        End Try
    '    Next
    '    Return True
    'End Function
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
        Response.Redirect("w_central.aspx")
    End Sub
#End Region





End Class
