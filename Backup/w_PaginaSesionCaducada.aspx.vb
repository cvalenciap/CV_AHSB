Imports System.Web.Security
Imports System.Web.UI

Public Class w_PaginaSesionCaducada
    Inherits System.Web.UI.Page
    Private ErrMsg As String

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label9 As System.Web.UI.WebControls.Label
    Protected WithEvents lblMensajeError As System.Web.UI.WebControls.Label

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
        'Put user code to initialize the page here

        Dim oBDSQL As New BNOperacion
        Dim Periodo As String
        Dim CodTrabajador As String
        CodTrabajador = Session("xCodTrabajador")

        Try
            oBDSQL.Actualizar_RegistroControl_CS(CodTrabajador)

        Catch ex As Exception
            lblMensajeError.Text = ErrMsg

        End Try

    End Sub

End Class
