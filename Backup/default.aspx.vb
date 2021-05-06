Imports System.Web.Security
Imports System.Text

Public Class w_default
    Inherits System.Web.UI.Page

#Region " Código generado por el Diseñador de Web Forms "

    'El Diseñador de Web Forms requiere esta llamada.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    'Protected WithEvents ContextMenu1 As Msdn.ContextMenu
    Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton
    Protected WithEvents txtIDNodoSeleccionado As System.Web.UI.WebControls.TextBox
    ' Protected WithEvents BNMenu As skmMenu.Menu
    Protected WithEvents lblUsuario As System.Web.UI.WebControls.Label
    Protected WithEvents lblDependencia As System.Web.UI.WebControls.Label
    Protected WithEvents lblNivelSeguridad As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label

    'NOTA: el Diseñador de Web Forms necesita la siguiente declaración del marcador de posición.
    'No se debe eliminar o mover.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: el Diseñador de Web Forms requiere esta llamada de método
        'No la modifique con el editor de código.
        InitializeComponent()
        Asignar_MenuOpciones()
    End Sub

#End Region

    Private TipoObjeto As String
    Private ID_Nodo As Integer

#Region "   * * * Informacion de Logeado en el Sistema * * *   "

    Private ReadOnly Property Trabajador() As String
        Get
            Return Session("xNomTrabajador")
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

#End Region

#Region "   * * * DataTable con el Arbol de Navegacion * * *   "

    Private ReadOnly Property DTArbol() As DataTable
        Get
            Return Session("xArbolNavegacion")
        End Get
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Not Page.IsPostBack Then
        '    Configurar_Menu()
        '    lblUsuario.Text = "USUARIO : " & Replace(Trabajador, "/", " ")
        '    lblDependencia.Text = "DEPENDENCIA : " & Dependencia
        '    lblNivelSeguridad.Text = "NIVEL DE SEGURIDAD : " & LogOnPerfil.ToUpper
        'End If
    End Sub

    'Private Sub Configurar_Menu()
    '    '==================================================
    '    ' Configuro el Perfil de acuerdo al Usuario Logeado
    '    '==================================================
    '    BNMenu.UserRoles.Add(LogOnPerfil)
    '    '==================================================
    '    BNMenu.ForeColor = Color.Black
    '    BNMenu.Opacity = 90
    '    BNMenu.zIndex = 100
    '    '==================================================
    '    BNMenu.DataSource = Server.MapPath("RolesXML.xml")
    '    BNMenu.DataBind()
    'End Sub

    Private Sub lnk_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormsAuthentication.SignOut()
        Response.Redirect("w_login.aspx")

    End Sub

    Private Sub Asignar_MenuOpciones()
        'Dim ocItem As Msdn.ContextMenuItem

        'ocItem = New Msdn.ContextMenuItem("Modificar...", "cmdModificar")
        'ContextMenu1.ContextMenuItems.Add(ocItem)
        'ocItem = New Msdn.ContextMenuItem("Eliminar...", "cmdEliminar")
        'ContextMenu1.ContextMenuItems.Add(ocItem)
        'ocItem = New Msdn.ContextMenuItem("*** Mas Opciones ***", "cmdXXX")
        'ContextMenu1.ContextMenuItems.Add(ocItem)

        'ContextMenu1.BoundControls.Add(Me.Controls.Item(1))

    End Sub

    'Private Sub ContextMenu1_ItemCommand(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.CommandEventArgs) Handles ContextMenu1.ItemCommand

    '    ID_Nodo = CInt(txtIDNodoSeleccionado.Text)

    '    Select Case e.CommandName
    '        Case Is = "cmdModificar"
    '            ID_Nodo = Get_ID_ObjetoReal()
    '            If TipoObjeto = "S" Then
    '                Response.Redirect("w_subproceso.aspx?ID_Nodo=" & ID_Nodo)
    '            ElseIf TipoObjeto = "R" Then
    '                Response.Redirect("w_eventoriesgo.aspx?ID_Nodo=" & ID_Nodo)
    '            End If
    '            Response.Write(Messbox("No se puede Modificar la Opción Seleccionada."))

    '        Case Is = "cmdEliminar"
    '            ID_Nodo = Get_ID_ObjetoReal()
    '            If TipoObjeto = "S" Then

    '            ElseIf TipoObjeto = "R" Then

    '            End If
    '            Response.Write(Messbox("No se puede Eliminar la Opción Seleccionada."))

    '        Case Is = "cmdXXX"
    '            'Mas Opciones.....
    '            Response.Write(Messbox("El Sistema puede Realizar Otras Acciones."))

    '    End Select

    'End Sub

    Private Sub lnkSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkSalir.Click
        Response.Redirect("w_login.aspx")
    End Sub

    'Private Function Get_ID_ObjetoReal() As Integer
    '    Dim dvArbol As DataView

    '    dvArbol = DTArbol.DefaultView
    '    dvArbol.RowFilter = "Codigo = " & CType(ID_Nodo, String)

    '    If dvArbol.Count > 0 Then
    '        Get_ID_ObjetoReal = CType(Mid(dvArbol.Item(0).Item("CodigoReal"), 2), Integer)
    '        TipoObjeto = Mid(dvArbol.Item(0).Item("CodigoReal"), 1, 1)
    '    Else
    '        Get_ID_ObjetoReal = 0
    '        TipoObjeto = ""
    '    End If

    'End Function

    Private Function Messbox(ByVal Mensaje As String) As StringBuilder
        Messbox = New StringBuilder
        Messbox.Append("<script>")
        Messbox.Append("alert('" & Mensaje & "')")
        Messbox.Append("</script>")
    End Function

End Class
