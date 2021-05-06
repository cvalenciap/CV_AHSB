Imports System.Web.Security
Public Class w_cabecera

    Inherits System.Web.UI.Page
    Private xColor As DataTable
    Private xFondoLetra As DataSet
    Private Id_FondoLetra As Integer

    Protected WithEvents dtgColores As System.Web.UI.WebControls.DataGrid
    Protected WithEvents pnlDatos As System.Web.UI.WebControls.Panel
    Protected WithEvents lnkTerminarSesion As System.Web.UI.WebControls.LinkButton
    Private ErrMsg As String
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
            'Response.Redirect("PaginaSesionCaducada.htm")
        End If

    End Sub







    Private Sub lnkTerminarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkTerminarSesion.Click
        FormsAuthentication.SignOut()
        ' Response.Redirect("PaginaSesionCaducada.htm")
        Response.Redirect("w_PaginaSesionCaducada.aspx")
    End Sub

End Class
