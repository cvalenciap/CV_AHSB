Imports System.Web.Security
Public Class w_central

    Inherits System.Web.UI.Page
    Private xColor As DataTable
    Private xFondoLetra As DataSet
    Private Id_FondoLetra As Integer

    Protected WithEvents dtgColores As System.Web.UI.WebControls.DataGrid
    Protected WithEvents pnlDatos As System.Web.UI.WebControls.Panel
    Protected WithEvents lblUsuario As System.Web.UI.WebControls.Label
    Protected WithEvents lblDependencia As System.Web.UI.WebControls.Label
    Protected WithEvents lblNivelSeguridad As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents ImageButton1 As System.Web.UI.WebControls.ImageButton
    Private ErrMsg As String
    Protected WithEvents lblMensError As System.Web.UI.WebControls.Label
    Private MensErr As String
#Region "   * * * Informacion de Logeado en el Sistema * * *   "

    Private ReadOnly Property Trabajador() As String
        Get
            Return Session("xNomTrabajador")
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

    Private ReadOnly Property LogOnPerfil() As String
        Get
            Return Session("xLogOnPerfil")
        End Get
    End Property

    Private ReadOnly Property CodUsuario() As String
        Get
            Return Session("xCodTrabajador")
        End Get
    End Property

#End Region
#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

   End Sub
    Protected WithEvents cmdCancelar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdEliminar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdAceptar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdModificar As System.Web.UI.WebControls.Button
    Protected WithEvents cmdNuevo As System.Web.UI.WebControls.Button
    Protected WithEvents lblTitulo As System.Web.UI.WebControls.Label
    Protected WithEvents rbFondo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbLetra As System.Web.UI.WebControls.RadioButton
    Protected WithEvents cmbColor As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblColor As System.Web.UI.WebControls.Label

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()


    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Session("xLogOnPerfil") Is Nothing Then
            FormsAuthentication.SignOut()
            '    Response.Redirect("PaginaSesionCaducada.htm")
        End If
        If Not Page.IsPostBack Then
            Dim oBDSQL As New BNOperacion

            'If LogOnPerfil.Equals(REG) Or LogOnPerfil.Equals(EDI) Then
            '    CodUsuario = CodTrabajador
            'End If

            ErrMsg = Request.QueryString("ErrMsg")
            Me.lblMensError.Text = ErrMsg
            '==================================================
            ' Mostrar Informacion sobre Usuario Logeado
            '==================================================
            lblUsuario.Text = "USUARIO : " & Trabajador
            lblDependencia.Text = "DEPENDENCIA : " & Dependencia
            lblNivelSeguridad.Text = "NIVEL DE SEGURIDAD : " & LogOnPerfil.ToUpper

        End If

    End Sub







End Class
