Imports System.Web.Security
Public Class w_atencion_cliente
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents MsgBox1 As MsgBox.MsgBox
    Protected WithEvents dtgAtencion As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lblDocumento As System.Web.UI.WebControls.Label
    Protected WithEvents lblTipo As System.Web.UI.WebControls.Label
    Protected WithEvents cmbTDocumento As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblNumero As System.Web.UI.WebControls.Label
    Protected WithEvents txtNDocumento As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblDatosPlaca As System.Web.UI.WebControls.Label
    Protected WithEvents lblTVehiculo As System.Web.UI.WebControls.Label
    Protected WithEvents cmbTVehiculo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblPlaca As System.Web.UI.WebControls.Label
    Protected WithEvents txtSerie As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblGuion As System.Web.UI.WebControls.Label
    Protected WithEvents txtNumero As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdVerificaStock As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblRefrendo As System.Web.UI.WebControls.Label
    Protected WithEvents lblFRegistro As System.Web.UI.WebControls.Label
    Protected WithEvents txtFRefrendo As System.Web.UI.WebControls.TextBox
    Protected WithEvents PopCalendar1 As RJS.Web.WebControl.PopCalendar
    Protected WithEvents lblSecuencia As System.Web.UI.WebControls.Label
    Protected WithEvents txtNSecuencia As System.Web.UI.WebControls.TextBox
    Protected WithEvents cmdVerificaRefrendo As System.Web.UI.WebControls.ImageButton
    Protected WithEvents cmdAgregar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdElimina As System.Web.UI.WebControls.Button
    Protected WithEvents lblNTicket As System.Web.UI.WebControls.Label
    Protected WithEvents lblTicket As System.Web.UI.WebControls.Label
    Protected WithEvents cmdNuevo As System.Web.UI.WebControls.Button
    Protected WithEvents cmdAceptar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdCancelar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdImprimir As System.Web.UI.WebControls.ImageButton
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton
    Protected WithEvents cmdEliminar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdModificar As System.Web.UI.WebControls.Button

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
    Private xTDocumento As DataTable
    Private xtvehiculo As DataTable

    Private Fecha As String
#Region "   * * * Variables Generales * * *   "

    Public Property Accion() As Integer
        Get
            Return Session("xAccion")
        End Get
        Set(ByVal Value As Integer)
            Session("xAccion") = Value
        End Set
    End Property
    Public Property DSInfoAtencion() As DataSet
        Get
            Return Session("xInfoAtencion")
        End Get
        Set(ByVal Value As DataSet)
            Session("xInfoAtencion") = Value
        End Set
    End Property
    Public Property DSInfoPlaca() As DataSet
        Get
            Return Session("xInfoPlaca")
        End Get
        Set(ByVal Value As DataSet)
            Session("xInfoPlaca") = Value
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
    Public Property Contador() As Integer
        Get
            Return Session("xContador")
        End Get
        Set(ByVal Value As Integer)
            Session("xContador") = Value
        End Set
    End Property
    Public Property Ticket() As Integer
        Get
            Return Session("xTicket")
            'Return xTicket

        End Get
        Set(ByVal Value As Integer)
            Session("xTicket") = Value
            'xTicket = Value

        End Set


    End Property
    Public Property Secuencia() As Integer
        Get
            Return Session("xSecuencia")
            'Return xTicket

        End Get
        Set(ByVal Value As Integer)
            Session("xSecuencia") = Value
            'xTicket = Value

        End Set


    End Property
    Public Property FRegistro() As String
        Get
            Return Session("xFRegistro")
            'Return xTicket

        End Get
        Set(ByVal Value As String)
            Session("xFRegistro") = Value
            'xTicket = Value

        End Set
    End Property
#End Region
#Region "   * * * Carga de Controles - Combos * * *   "

    Public Property DTDocumento() As DataTable
        Get
            Return xTDocumento
        End Get
        Set(ByVal Value As DataTable)
            xTDocumento = Value
        End Set
    End Property
    Public Property DTVehiculo() As DataTable
        Get
            Return xtvehiculo
        End Get
        Set(ByVal Value As DataTable)
            xtvehiculo = Value
        End Set
    End Property



    Private Sub Cargar_Controles()
        Dim oDBSQL As New BNOperacion
        Dim dsControl As DataSet = oDBSQL.Get_FormAtencion(Coficina, ErrMsg)
        DTDocumento = dsControl.Tables("TDocumento")
        DTVehiculo = dsControl.Tables("TVehiculo")

        Me.cmbTDocumento.DataSource = DTDocumento
        Me.cmbTDocumento.DataValueField = DTDocumento.Columns(0).ColumnName
        Me.cmbTDocumento.DataTextField = DTDocumento.Columns(1).ColumnName
        Me.cmbTDocumento.DataBind()

        Me.cmbTVehiculo.DataSource = DTVehiculo
        Me.cmbTVehiculo.DataValueField = DTVehiculo.Columns(0).ColumnName
        Me.cmbTVehiculo.DataTextField = DTVehiculo.Columns(1).ColumnName
        Me.cmbTVehiculo.DataBind()

       
    End Sub

#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim FRegistro As String
        If Session("xLogOnPerfil") Is Nothing Then
            FormsAuthentication.SignOut()
            Response.Redirect("PaginaSesionCaducada.htm")
        End If
        If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.ATENCION_CLIENTES, 1) = "N" Then
            Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
        End If


        If Not Page.IsPostBack Then
            oLoad = True
            Accion = 0
            Ticket = Request.QueryString("ID_Nodo")
            FRegistro = Request.QueryString("Fecha")
            Me.cmdAgregar.Enabled = False
            Me.cmdElimina.Enabled = False
            Me.cmdAceptar.Enabled = False
            Me.cmdImprimir.Visible = False


            If Ticket = 0 Then
                ' conseguir nro ticket

                Obtener_Numero_Ticket(Coficina)
             

                Accion = 1

                cmdNuevo.Visible = False
                cmdModificar.Visible = False
                cmdEliminar.Visible = False
                '  cmdAceptar.Visible = True
                '  cmdAceptar.Text = "Grabar"
                cmdCancelar.Visible = True
                cmdCancelar.Text = "Cancelar"


                FRegistro = Now.ToString

            Else
                cmdModificar.Visible = True
                cmdEliminar.Visible = True
                cmdAceptar.Visible = False
                cmdCancelar.Visible = False


            End If
            Obtener_Informacion_Atencion(Ticket, FRegistro)
            Me.cmbTDocumento.SelectedValue = 1
            Mostrar_Informacion_Registro()
            If Accion = 1 Then
                Ticket = Secuencia + 1
                '    lblTicket.Text = CStr(Now.Year) & Right("00" + Trim(CStr(Now.Month)), 2) & Right("00" + Trim(CStr(Now.Day)), 2) & " - " & Right("0000" + Trim(CStr(Ticket)), 4)

            End If
        End If
        Me.txtFRefrendo.Text = Now.ToShortDateString
        lblTicket.Text = CStr(CDate(FRegistro).Year) & Right("00" + Trim(CStr(CDate(FRegistro).Month)), 2) & Right("00" + Trim(CStr(CDate(FRegistro).Day)), 2) & " - " & Right("0000" + Trim(CStr(Ticket)), 4)

        Formato_Grilla_Atencion()
    End Sub

#Region "*** Formato Grilla Atencion ****"

    Private Sub Formato_Grilla_Atencion()


        dtgAtencion.Columns.Clear()
        dtgAtencion.DataSource = DSInfoAtencion.Tables("InfoAtencion_Detalle")


        dtgAtencion.AutoGenerateColumns = False
        dtgAtencion.AllowPaging = False

        Dim dgBoundColumn As BoundColumn
        Dim dgButtonColumn As ButtonColumn
        '============================================================
        ' Primera Columna: Selector de Fila
        '============================================================
        dgButtonColumn = New ButtonColumn
        dgButtonColumn.ButtonType = ButtonColumnType.LinkButton
        dgButtonColumn.HeaderText = "Selección"
        dgButtonColumn.Text = "==>"
        dgButtonColumn.CommandName = "Select"
        dtgAtencion.Columns.Add(dgButtonColumn)
        '============================================================
        ' Ticket
        '============================================================
        dgBoundColumn = New BoundColumn
        dgBoundColumn.HeaderText = "Nro. Ticket"
        dgBoundColumn.DataField = "Ticket"
        dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        dtgAtencion.Columns.Add(dgBoundColumn)
        dgBoundColumn.Visible = False
        '============================================================
        ' Segunda Columna: Modelo
        '============================================================
        dgBoundColumn = New BoundColumn
        dgBoundColumn.HeaderText = "Modelo"
        dgBoundColumn.DataField = "Modelo"
        dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        dtgAtencion.Columns.Add(dgBoundColumn)
        '============================================================
        ' Tercera Columna: Serie
        '============================================================
        dgBoundColumn = New BoundColumn
        dgBoundColumn.HeaderText = "Serie"
        dgBoundColumn.DataField = "Serie"
        dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        dtgAtencion.Columns.Add(dgBoundColumn)
        '============================================================
        ' Cuarta Columna: Número
        '============================================================
        dgBoundColumn = New BoundColumn
        dgBoundColumn.HeaderText = "Numero"
        dgBoundColumn.DataField = "Numero"
        dgBoundColumn.ItemStyle.Width = New Unit(10, UnitType.Cm)
        dtgAtencion.Columns.Add(dgBoundColumn)

        dtgAtencion.DataBind()
        dtgAtencion.Visible = True

    End Sub
#End Region

    Private Sub EjecutarProceso()

        '===========================================================================
        Dim sender As System.Object
        Dim e As System.EventArgs
        Dim dr As DataRow
        Dim oDBSQL As New BNOperacion
        Dim MensajeTermino As String
        '===========================================================================

        Dim Serie As String
        Dim Numero As String
        Dim FRefrendo As String
        Dim Secuencia As Integer
        Dim TDocumento As Integer
        Dim NDocumento As String



        If Accion > 1 Then
            oDBSQL.Eliminar_Atencion(Ticket, FRegistro, Coficina)
            If Accion = 2 Then
                MensajeTermino = " Modificó "
            ElseIf Accion = 3 Then
                MensajeTermino = " Eliminó "

            End If

        End If

        If Accion < 3 Then
            Try
                For Each dr In DSInfoAtencion.Tables("InfoAtencion_Detalle").Rows
                    Try
                        Serie = dr.Item("Serie")
                        Numero = dr.Item("Numero")
                        FRefrendo = dr.Item("FRefrendo")
                        Secuencia = dr.Item("Secuencia")
                        'TDocumento = dr.Item("Id_TDocumento")
                        'NDocumento = dr.Item("NDocumento")
                        TDocumento = Me.cmbTDocumento.SelectedValue
                        NDocumento = Me.txtNDocumento.Text
                        oDBSQL.Graba_NuevoDespacho(Ticket, Serie, Numero, FRefrendo, Secuencia, _
                                                   TDocumento, NDocumento, Coficina, FRegistro)
                        '-- Incrementa Secuencia Ticket ---'

                        Try
                            '01/06/2007  Ticket se incrementa en inicio
                            'If Accion = 1 Then
                            '    oDBSQL.Grabar_NuevaSecuencia(Coficina)
                            'End If

                        Catch ex As Exception
                            MsgBox1.ShowMessage(ex.Message)
                            Exit Sub
                        End Try

                        MensajeTermino = " Grabo "
                    Catch ex As Exception
                        Dim Err$ = ex.Message
                    End Try
                Next

            Catch ex As Exception
                MsgBox1.ShowMessage(ex.Message)
            End Try
        End If

        MsgBox1.ShowMessage("El Registro se" + MensajeTermino + "Correctamente!")
        If Accion = 3 Then
            Me.cmdCancelar_Click(sender, e)
        Else
            Me.Limpiar_Controles_Detalle()
        End If
    End Sub

#Region "*********Rutinas diversas *******"


    Private Sub cmdVerificaStock_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdVerificaStock.Click
        '===========================================================================
        Dim oDBSQL As New BNOperacion
        '===========================================================================
        Dim Serie As String
        Dim Numero As String
        Dim Contador As String

        Dim nCaracteres As Integer
        '-------
        'Dim COficina As String = "0002"
        '------
        Serie = Me.txtSerie.Text
        Numero = Me.txtNumero.Text
        If Not IsNumeric(Numero) Then
            MsgBox1.ShowMessage("El número de la placa debe ser numérico")
            Exit Sub
        End If
        If Len(Serie) < 2 Then
            MsgBox1.ShowMessage("Verifique la Serie ingresada")
            Exit Sub
        End If
        nCaracteres = IIf(cmbTVehiculo.SelectedValue = 1, IIf(Len(Serie) = 3, 3, 4), IIf(Len(Serie) = 3, 3, 5))
        Dim LCompleta As New String("0", nCaracteres)
        Numero = Right(LCompleta + Trim(Numero), Len(LCompleta))
        Me.txtNumero.Text = Numero

        Contador = oDBSQL.Verifica_StockPlaca(Serie, Numero, COficina)
        If Contador = "" Then

            Me.cmdVerificaStock.ImageUrl = "imagenes\nok2.jpg"
            MsgBox1.ShowMessage("Placa no se encuentra registrada")
            Exit Sub
        Else
            If Val(Contador) = 0 Then
                Me.cmdVerificaStock.ImageUrl = "imagenes\nok2.jpg"
                MsgBox1.ShowMessage("Placa ya ha sido entregada")
                Exit Sub
            End If
            If Val(Contador) = 9000 Then
                Me.cmdVerificaStock.ImageUrl = "imagenes\nok2.jpg"
                MsgBox1.ShowMessage("Placa se encuentra en tramite")
                Exit Sub
            End If
            Me.cmdVerificaStock.ImageUrl = "imagenes\VistoBueno.jpg"
        End If
    End Sub

    Private Sub cmdVerificaRefrendo_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdVerificaRefrendo.Click
        '===========================================================================
        Dim oDBSQL As New BNOperacion
        '===========================================================================
        '-------
        Dim FRefrendo As String
        Dim Secuencia As Integer
        Dim Contador As String
        If txtFRefrendo.Text = "" Then
            MsgBox1.ShowMessage("Ingrese la Fecha de Refrendo!")
            Exit Sub
        End If
        If txtNSecuencia.Text = "" Then
            MsgBox1.ShowMessage("Ingrese el Número de Secuencia del Refrendo!")
            Exit Sub
        End If
        If Not IsNumeric(txtNSecuencia.Text) Then
            MsgBox1.ShowMessage("La Secuencia del Refrendo no es numérica!")
            Exit Sub
        End If
        FRefrendo = Me.txtFRefrendo.Text
        Secuencia = Me.txtNSecuencia.Text
        If IsDate(FRefrendo) Then
            If CDate(FRefrendo) > Now.ToShortDateString Then
                MsgBox1.ShowMessage("La fecha del refrendo no puede ser mayor a la actual")
                Exit Sub
            End If
        Else



        End If
        Contador = oDBSQL.Verifica_Refrendo(FRefrendo, Secuencia)
        If Contador = "" Then
            Me.cmdVerificaRefrendo.ImageUrl = "imagenes\VistoBueno.jpg"
            Me.cmdAgregar.Enabled = True
            Me.cmdElimina.Enabled = True
        Else
            MsgBox1.ShowMessage("Refrendo ya ha sido utilizado con el ticket: " & Contador)
            Me.cmdVerificaRefrendo.ImageUrl = "imagenes\nok2.jpg"

        End If
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Dim Serie As String
        Dim Numero As String
        Dim FRefrendo As String
        Dim Id_TDocumento As Integer
        Dim NDocumento As String
        Dim Secuencia As Integer

        Try
            If txtSerie.Text = "" Then
                MsgBox1.ShowMessage("No ha ingresado la Serie!")
                Exit Sub
            End If
            If txtNumero.Text = "" Then
                MsgBox1.ShowMessage("No ha ingresado el Numero de la Placa!")
                Exit Sub
            End If
            If Me.txtNDocumento.Text = "" Then
                MsgBox1.ShowMessage("No ha ingresado el número de documento!")
                Exit Sub
            End If

            Serie = UCase(Trim(Me.txtSerie.Text))
            If Len(Serie) < 2 Then
                MsgBox1.ShowMessage("La Serie no puede tener menos de 2 caracteres!")
                Exit Sub
            End If
            Numero = Me.txtNumero.Text
            FRefrendo = Me.txtFRefrendo.Text
            Secuencia = Me.txtNSecuencia.Text
            Id_TDocumento = Me.cmbTDocumento.SelectedValue
            NDocumento = Me.txtNDocumento.Text
            '----
            If Validar_Placas_Despacho() Then
                Dim oBDSQL As New BNOperacion
                Try
                    DSInfoPlaca = oBDSQL.Get_InfoPlaca(Serie, Numero)
                Catch ex As Exception
                    MsgBox1.ShowMessage(ErrMsg)
                End Try
                Dim dr2 As DataRow = DSInfoPlaca.Tables("InfoPlaca").Rows(0)

                Dim dr As DataRow = DSInfoAtencion.Tables("InfoAtencion_Detalle").NewRow
                dr.Item("Ticket") = Ticket
                dr.Item("Modelo") = dr2.Item("Modelo")
                dr.Item("Serie") = Serie
                dr.Item("Numero") = Numero
                dr.Item("FRefrendo") = FRefrendo
                dr.Item("Secuencia") = Secuencia
                dr.Item("Id_TDocumento") = Id_TDocumento
                dr.Item("NDocumento") = NDocumento

                DSInfoAtencion.Tables("InfoAtencion_Detalle").Rows.Add(dr)
                dtgAtencion.DataBind()
                Limpiar_Controles_Detalle()
                cmdAceptar.Visible = True
                cmdAceptar.Enabled = True
            Else
                MsgBox1.ShowMessage("La placa ya ha sido registrada para su despacho")
            End If
        Catch ex As Exception
            MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub
    Private Sub Obtener_Numero_Ticket(ByVal coficina As String)

        Dim oBDSQL As New BNOperacion
        Try
            DSInfoAtencion = oBDSQL.Get_NroTicket(coficina, ErrMsg)

        Catch ex As Exception
            MsgBox1.ShowMessage(ErrMsg)
        End Try
        If DSInfoAtencion.Tables("SecuenciaTicket").Rows.Count = 0 Then
        Else
            Secuencia = DSInfoAtencion.Tables("SecuenciaTicket").Rows(0).Item("Secuencia")
        End If

    End Sub
    Private Sub Obtener_Informacion_Atencion(ByVal Ticket As Integer, ByVal Fecha As String)

        Dim oBDSQL As New BNOperacion
        Try
            DSInfoAtencion = oBDSQL.Get_InfoAtencion(Ticket, Fecha, ErrMsg)

        Catch ex As Exception
            MsgBox1.ShowMessage(ErrMsg)
        End Try


    End Sub
    Private Function Validar_Placas_Despacho() As Boolean
        Dim Serie As String
        Dim Numero As String

        If DSInfoAtencion.Tables("InfoAtencion_Detalle").Rows.Count = 0 Then
            Return True
        End If

        Serie = Me.txtSerie.Text
        Numero = Me.txtNumero.Text


        Dim dvAuxiliar As New DataView(DSInfoAtencion.Tables("InfoAtencion_Detalle"))
        dvAuxiliar.RowFilter = "Serie = '" & Serie & " ' " & " And Numero = '" & Numero & " ' "

        If dvAuxiliar.Count > 0 Then Return False
        Return True

    End Function
    Private Sub Limpiar_Controles_Detalle()
        Try
            Me.txtSerie.Text = ""
            Me.txtNumero.Text = 0
            Me.txtFRefrendo.Text = ""
            Me.txtNSecuencia.Text = 0

            Me.cmdVerificaRefrendo.ImageUrl = "imagenes\verifica.jpg"
            Me.cmdVerificaStock.ImageUrl = "imagenes\verifica.jpg"

        Catch ex As Exception
            MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.cmdAgregar.Enabled = False
        Me.cmdElimina.Enabled = False
        Me.cmdImprimir.Visible = False

        Limpiar_Controles_Detalle()
        Me.DSInfoAtencion.Clear()
        dtgAtencion.DataSource = Nothing
        dtgAtencion.DataBind()
        Cargar_Controles()
    End Sub
#End Region

    Private Sub cmdElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdElimina.Click
        Dim iFila As Integer
        iFila = dtgAtencion.SelectedIndex
        If iFila < 0 Then
            MsgBox1.ShowMessage("Debe Seleccionar un detalle Previamente!")
            Exit Sub
        End If
        DSInfoAtencion.Tables("InfoAtencion_Detalle").Rows(iFila).Delete()
        dtgAtencion.SelectedIndex = -1
        dtgAtencion.DataBind()
    End Sub



    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If DSInfoAtencion.Tables("InfoAtencion_Detalle").Rows.Count = 0 Then
            MsgBox1.ShowMessage("No ha registrado ninguna placa")
            Exit Sub
        End If


        EjecutarProceso()

        cmdImprimir.Visible = True
        cmdNuevo.Visible = True
        cmdAceptar.Visible = False

    End Sub

    Private Sub lnkSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkSalir.Click
        Response.Redirect("w_central.aspx")
    End Sub




    Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click

        Me.cmdCancelar_Click(sender, e)
        Me.cmdNuevo.Visible = False
        Obtener_Numero_Ticket(Coficina)

        Ticket = Secuencia + 1
        lblTicket.Text = CStr(CDate(FRegistro).Year) & Right("00" + Trim(CStr(CDate(FRegistro).Month)), 2) & Right("00" + Trim(CStr(CDate(FRegistro).Day)), 2) & " - " & Right("0000" + Trim(CStr(Ticket)), 4)

    End Sub

    Private Sub cmbTVehiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTVehiculo.SelectedIndexChanged
        If cmbTVehiculo.SelectedValue = 1 Then
            Me.txtSerie.MaxLength = 3
            Me.txtNumero.MaxLength = 4
        Else
            Me.txtSerie.MaxLength = 2
            Me.txtNumero.MaxLength = 5
        End If
    End Sub



    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdImprimir.Click
        Dim Dt_Ticket As DataTable
        Dim myExportOptions As CrystalDecisions.Shared.ExportOptions
        Dim myDiskFileDestinationOptions As CrystalDecisions.Shared.DiskFileDestinationOptions
        Dim myExportFile As String
        Dim RptInfTicket As New rptTicket


        Dim Err As String

        Dim vInt_IDExpediente As Integer
        Try

            vInt_IDExpediente = Session("vInt_IDExpediente")
            Dt_Ticket = DSInfoAtencion.Tables("InfoAtencion_Detalle")
            RptInfTicket.SetDataSource(Dt_Ticket)
            myExportFile = Page.MapPath(ConfigurationSettings.AppSettings("pdfpath")) & "\PDF1" & Session.SessionID.ToString & ".pdf"
            myDiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
            myDiskFileDestinationOptions.DiskFileName = myExportFile
            myExportOptions = RptInfTicket.ExportOptions


            With myExportOptions
                .DestinationOptions = myDiskFileDestinationOptions
                .ExportDestinationType = .ExportDestinationType.DiskFile
                ' .ExportDestinationType = .ExportDestinationType.NoDestination
                .ExportFormatType = .ExportFormatType.PortableDocFormat
            End With

            RptInfTicket.Export()

        Catch ex As Exception
            Dim er As String = ex.Message
        End Try

        Response.ClearContent()
        Response.ClearHeaders()
        Response.ContentType = "application/pdf"
        Response.WriteFile(myExportFile)
        Response.Flush()
        Response.Close()

        System.IO.File.Delete(myExportFile)
    End Sub


    Private Sub Mostrar_Informacion_Registro()
        If Ticket = 0 Then
            Exit Sub
        End If

        Try
            Dim dr As DataRow = DSInfoAtencion.Tables("InfoAtencion_Detalle").Rows(0)

            '===========================================================================
            ' 1ro) Panel de Información General
            '===========================================================================
            ''If dr.Item("Id_TPlaca") = 1 Then
            ''    Me.rbOriginales.Checked = True
            ''Else
            ''    Me.rbDuplicadas.Checked = True
            ''End If
            Me.txtNDocumento.Text = dr.Item("NDocumento")
            Me.cmbTDocumento.SelectedValue = dr.Item("Id_TDocumento")

        Catch ex As Exception
            MsgBox1.ShowMessage(ex.Message)
        End Try

    End Sub


    
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Accion = 2
        cmdNuevo.Visible = False
        cmdModificar.Visible = False
        cmdEliminar.Visible = False
        cmdAceptar.Visible = True
        cmdAceptar.Text = "Grabar"
        cmdAceptar.Enabled = True
        cmdCancelar.Visible = True
        cmdCancelar.Text = "Cancelar"
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Accion = 3
        cmdNuevo.Visible = False
        cmdModificar.Visible = False
        cmdEliminar.Visible = False
        cmdAceptar.Visible = True
        cmdAceptar.Enabled = True
        cmdAceptar.Text = "SI"
        cmdCancelar.Visible = True
        cmdCancelar.Text = "NO"
    End Sub

   
    Private Sub dtgAtencion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgAtencion.SelectedIndexChanged
        cmdElimina.Enabled = True
    End Sub
End Class
