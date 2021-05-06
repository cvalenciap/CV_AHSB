Imports System.Web.UI.Page
Imports System.Web.Security

Public Class w_login
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
   Protected WithEvents lblUsuario As System.Web.UI.WebControls.Label
    Protected WithEvents txtUsuario As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblClave As System.Web.UI.WebControls.Label
    Protected WithEvents txtClave As System.Web.UI.WebControls.TextBox
   Protected WithEvents lblMensajeError As System.Web.UI.WebControls.Label
   Protected WithEvents cmdSalir As System.Web.UI.WebControls.Button
   Protected WithEvents Image1 As System.Web.UI.WebControls.Image
   Protected WithEvents cmd_Ingresar As System.Web.UI.WebControls.Button

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    

#End Region


   
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   Private Sub cmd_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Ingresar.Click
      Dim Usuario As String
      Dim Password As String
      Dim Mensaje As String
      Dim oSeguridad As New BNSeguridad

      Usuario = txtUsuario.Text
      Password = txtClave.Text

      If oSeguridad.IniciarSesion(Usuario, Password, Mensaje) Then
         Session("xCodTrabajador") = oSeguridad.CodTrabajador.Trim
         Session("xNomTrabajador") = Replace(oSeguridad.NomTrabajador.Trim, "/", " ")
         Session("xDepTrabajador") = oSeguridad.DepTrabajador.Trim
         Session("xLogOnPerfil") = oSeguridad.LogOnPerfil
         Session("xCadPermiso") = oSeguridad.CadPermiso
         Session("xCodDependencia") = oSeguridad.CodDependencia.Trim
         FormsAuthentication.RedirectFromLoginPage(Usuario, False)
      End If

      lblMensajeError.Text = Mensaje
   End Sub


End Class
