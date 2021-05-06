Imports System.Web.Security
Public Class WebUserControl1

    Inherits System.Web.UI.UserControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents TreeView As System.Web.UI.WebControls.Literal

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
        Dim oTree As New obout_ASPTreeView_2_NET.Tree
        Dim html As String
        Dim j As Integer

        Dim ArbolMenu As DataTable
        Dim oMenu As New BNArchivoXML

        '=======================================
        ' Asocia el Folder de Imagener...
        '=======================================
        oTree.FolderIcons = "treeview/icons"
        '=======================================
        ' Asocia el Folder de Estilos...
        '=======================================
        'oTree.FolderStyle = "treeview/styles/TMenu"
        oTree.FolderStyle = "treeview/styles/MSDN"
        'oTree.FolderStyle = "treeview/styles/xpBlue"
        'oTree.FolderStyle = "treeview/styles/White"
        '=======================================
        ' Configuracion del Area del Menu...
        '=======================================
        oTree.Height = "435px"
        oTree.Width = "176px"
        oTree.Width_ScrollWider = "156px"

        ArbolMenu = oMenu.LeerFileXML("MenuXML.xml")

        For j = 0 To ArbolMenu.Rows.Count - 1
            'If Not Request.Cookies(ArbolMenu.Rows(j)(0)) Is Nothing Then
            '    If Request.Cookies(ArbolMenu.Rows(j)(0)).Value = "false" Then
            '        bExpandNode = False
            '    End If
            '    If Request.Cookies(ArbolMenu.Rows(j)(0)).Value = "true" Then
            '        bExpandNode = True
            '    End If
            'End If
            '======================================================
            ' Construyendo el Arbol de Nodos(Menu) con Estados...
            '======================================================
            If ArbolMenu.Rows(j)(1) = "0" Then
                oTree.Add("root", ArbolMenu.Rows(j)(0), ArbolMenu.Rows(j)(3), True)
            Else
                oTree.Add(ArbolMenu.Rows(j)(1), ArbolMenu.Rows(j)(0), ArbolMenu.Rows(j)(3), False)
            End If

        Next j

        'oTree.SelectedId = "1"
        'oTree.SelectedEnable = True
        'oTree.ExpandSingleEnable = True
        'oTree.KeyNavigationEnable = True
        TreeView.Text = oTree.HTML()
        oTree = Nothing

    End Sub

  
End Class
