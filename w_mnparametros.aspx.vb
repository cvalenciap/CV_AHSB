Imports System.Web.Security

Public Class w_mnparametros
   Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

   'El Diseñador de Web Forms requiere esta llamada.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

   End Sub
   Protected WithEvents Label1 As System.Web.UI.WebControls.Label
   Protected WithEvents Label2 As System.Web.UI.WebControls.Label
   Protected WithEvents Label3 As System.Web.UI.WebControls.Label
   Protected WithEvents cmdGuardar As System.Web.UI.WebControls.Button
   Protected WithEvents Label4 As System.Web.UI.WebControls.Label
   Protected WithEvents Label5 As System.Web.UI.WebControls.Label
   Protected WithEvents Label6 As System.Web.UI.WebControls.Label
   Protected WithEvents MsgBox1 As MsgBox.MsgBox
   Protected WithEvents txtCodSBS As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtNormativa As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtFuncionario As System.Web.UI.WebControls.TextBox
   Protected WithEvents Linkbutton1 As System.Web.UI.WebControls.LinkButton

   'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
   'No se debe eliminar o mover.
   Private designerPlaceholderDeclaration As System.Object

   Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
      'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
      'No la modifique con el editor de código.
      InitializeComponent()
   End Sub

#End Region


#Region "**** Variables Generales ***"

   Private ErrMsg As String
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
#End Region
   Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      If Session("xLogOnPerfil") Is Nothing Then
         FormsAuthentication.SignOut()
            Response.Redirect("w_PaginaSesionCaducada.aspx")
      End If

      If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.ADM_TABLAS, 1) = "N" Then
         Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
      End If

      If Not Page.IsPostBack Then
         Leer_Parametros()

         'Response.Write("<script>")
         'Response.Write("top.frames['header'].document.getElementById('txtTitulo').value = ""Configuración de Parametros"";")
         'Response.Write("</script>")
      End If
   End Sub

   Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
      Dim msgAccionEvento As String
      msgAccionEvento = "Esta seguro de Grabar?"
      MsgBox1.ShowConfirmation(msgAccionEvento, "GRABAR", True, True)
   End Sub

   Private Sub EjecutaProceso()
      Dim oDBSQL As New BNOperacion
      Dim CodSBS As String, Normativa As String, Funcionario As String

      CodSBS = txtCodSBS.Text
      Normativa = txtNormativa.Text
      Funcionario = txtFuncionario.Text
      Try
         oDBSQL.Grabar_Parametros(CodSBS, Normativa, Funcionario, CodUsuario, ErrMsg)
         MsgBox1.ShowMessage("Datos Modificados Correctamente!")
      Catch ex As Exception
         MsgBox1.ShowMessage(ex.Message)
      End Try
   End Sub

   Private Sub Leer_Parametros()
      Dim oDBSQL As New BNOperacion
      Dim dtParametro As DataTable

      dtParametro = oDBSQL.Leer_Parametros(ErrMsg)

      txtCodSBS.Text = dtParametro.Rows(0).Item("CodBCR").ToString
      txtNormativa.Text = dtParametro.Rows(0).Item("Normativa").ToString
      txtFuncionario.Text = dtParametro.Rows(0).Item("Funcionario").ToString

   End Sub

   Private Sub lnkSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Response.Redirect("w_main.aspx")
   End Sub

   Private Sub MsgBox1_YesChoosed(ByVal sender As Object, ByVal Key As String) Handles MsgBox1.YesChoosed
      Select Case Key
         Case "GRABAR"
            'Se confirmó que se desea grabar 
            EjecutaProceso()
         Case "ELIMINAR"
            'No se utiliza esta opcion.

      End Select
   End Sub
   Private Sub MsgBox1_NoChoosed(ByVal sender As Object, ByVal Key As String) Handles MsgBox1.NoChoosed
      Select Case Key
         Case "GRABAR"
            MsgBox1.ShowMessage("Accion Cancelada")
         Case "ELIMINAR"
            'No se utiliza esta opcion.
            '. 
      End Select
   End Sub

   Private Sub Linkbutton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Linkbutton1.Click
      Response.Redirect("w_central.aspx")
   End Sub
End Class
