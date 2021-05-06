Imports System.Web.Security
Public Class w_mninstpago

   Inherits System.Web.UI.Page

   Protected WithEvents lnkSalir As System.Web.UI.WebControls.LinkButton
   Protected WithEvents lblCoperacion As System.Web.UI.WebControls.Label
   Protected WithEvents lblDescripcion As System.Web.UI.WebControls.Label
   Protected WithEvents txtDescripcion As System.Web.UI.WebControls.TextBox
   Protected WithEvents txtInstPago As System.Web.UI.WebControls.TextBox
   Protected WithEvents cmbInstPago As System.Web.UI.WebControls.DropDownList
   Protected WithEvents RangeValidator1 As System.Web.UI.WebControls.RangeValidator
   Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
   Private oLoad As Boolean
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
   Protected WithEvents MsgBox1 As MsgBox.MsgBox

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
#Region "**** Variables Generales ***"
   Private XInstPago As DataTable
   Private Codigo As Integer
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
#Region "**** Cargar Controles*****"

   Public Property DTInstPago() As DataTable
      Get
         Return Session("xInstPago")
      End Get
      Set(ByVal Value As DataTable)
         Session("xInstPago") = Value

      End Set
   End Property
   Private Sub Cargar_Controles()
      Dim oDBSQL As New BNOperacion
      Dim dsControles As DataSet = oDBSQL.Get_FormMNInstPago(ErrMsg)

      DTInstPago = dsControles.Tables("InstPago")

      Me.cmbInstPago.DataSource = DTInstPago
      Me.cmbInstPago.DataValueField = DTInstPago.Columns(0).ColumnName
      Me.cmbInstPago.DataTextField = DTInstPago.Columns(1).ColumnName
      Me.cmbInstPago.DataBind()


   End Sub

#End Region

   Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      If Session("xLogOnPerfil") Is Nothing Then
         FormsAuthentication.SignOut()
            Response.Redirect("w_PaginaSesionCaducada.aspx")
      End If
      If Mid(Session("xCadPermiso"), 3 * BNAccesos.PERMISO.ADM_TABLAS, 1) = "N" Then
         Response.Redirect("w_central.aspx?ErrMsg=" & ErrorAcceso)
      End If
      cmdNuevo.Visible = True
      cmdModificar.Visible = True
      'cmdEliminar.Visible = True
      cmdAceptar.Visible = False
      cmdCancelar.Visible = False
      If Not Page.IsPostBack Then
         '  cmbTVehiculo_SelectedIndexChanged(sender, e)
      End If
   End Sub

#Region "*** Opcion Proceso ****"



   Private Sub cmdNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevo.Click
      Session("Accion") = 1
      Me.txtInstPago.Visible = True
      Me.txtDescripcion.Visible = True


      Me.cmbInstPago.Visible = False

      Me.cmdNuevo.Visible = False
      Me.cmdModificar.Visible = False
      Me.cmdEliminar.Visible = False
      Me.cmdAceptar.Visible = True
      Me.cmdCancelar.Visible = True
   End Sub

   Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
      Session("Accion") = 2
      Me.cmdNuevo.Visible = False
      Me.cmdModificar.Visible = False
      Me.cmdEliminar.Visible = False

      txtDescripcion.Text = cmbInstPago.SelectedItem.Text
      txtInstPago.Text = cmbInstPago.SelectedValue.ToString

      Me.txtInstPago.ReadOnly = True
      Me.txtInstPago.Visible = True
      Me.txtDescripcion.Visible = True
      Me.cmbInstPago.Visible = False

      Me.cmdAceptar.Visible = True
      Me.cmdCancelar.Visible = True
   End Sub

   Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

      Session("Accion") = 3

      Me.cmdNuevo.Visible = False
      Me.cmdModificar.Visible = False
      Me.cmdEliminar.Visible = False
      Me.cmdAceptar.Visible = True
      Me.cmdCancelar.Visible = True
      Me.cmdAceptar.Text = "SI"
      Me.cmdCancelar.Text = "NO"

   End Sub

   Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
      cmbInstPago.Visible = True
      Me.txtInstPago.Visible = False
      Me.txtDescripcion.Visible = False

      txtInstPago.Text = ""
      txtDescripcion.Text = ""
      cmdAceptar.Visible = False
      cmdCancelar.Visible = False
      cmdModificar.Visible = True
      'cmdEliminar.Visible = True
      cmdNuevo.Visible = True
      cmdAceptar.Text = "Grabar"
      cmdCancelar.Text = "Cancelar"
   End Sub
#End Region
#Region "*** Interaccion BD ***"


   Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
      Dim Descripcion As String
      Dim Codigo As Integer
      Descripcion = txtDescripcion.Text.Trim.ToUpper
      'Codigo = CInt(txtInstPago.Text)

      'If Session("Accion") < 3 And (Descripcion = "" Or Codigo = 0) Then
      '   MsgBox1.ShowMessage("No puede grabar datos en blanco")
      '   Exit Sub
      'End If
      Dim msgAccionEvento As String

      Select Case Session("Accion")
         Case Is = 1
            msgAccionEvento = "Esta seguro de Grabar?"
         Case Is = 2
            msgAccionEvento = "Esta seguro de Modificar?"
         Case Is = 3
            msgAccionEvento = "Esta seguro de Eliminar?"
      End Select

      MsgBox1.ShowConfirmation(msgAccionEvento, "GRABAR", True, True)
   End Sub

   Private Sub EjecutaProceso()
      Dim Descripcion As String
      Dim Codigo As Integer
      Dim sender As System.Object
      Dim e As System.EventArgs
      '***** 
      ' Dim CodUsuario As String = "0293784"
      '*****
      If Session("Accion") > 1 Then
         Codigo = cmbInstPago.SelectedValue
      Else
         Codigo = CInt(txtInstPago.Text)
      End If
      Descripcion = txtDescripcion.Text.Trim.ToUpper


      If Session("Accion") < 3 And (Descripcion = "" Or Codigo = 0) Then
         MsgBox1.ShowMessage("No puede grabar datos en blanco")
         Exit Sub
      End If

      Dim oDBSQL As New BNOperacion
      Dim mensaje As String
      Try


         Select Case Session("Accion")

            Case Is = 1

               Try
                  oDBSQL.Grabar_FormMNInstPago(Codigo, Descripcion, CodUsuario)

               Catch ex As Exception
                  Dim Err$ = ex.Message
                  MsgBox1.ShowMessage(err)
               End Try

               mensaje = "Instrumento de Pago Adicionado"

            Case Is = 2
               oDBSQL.Modificar_FormMNInstPago(Codigo, Descripcion, CodUsuario)
               mensaje = "Instrumento de Pago Modificado"

            Case Is = 3
               oDBSQL.Eliminar_FormMNInstPago(Codigo, CodUsuario)
               mensaje = "Instrumento de Pago Eliminado"

         End Select


      Catch ex As Exception
         Dim Err$ = ex.Message
         MsgBox1.ShowMessage(err)
      End Try
      MsgBox1.ShowMessage(mensaje)
      cmdCancelar_Click(Nothing, Nothing)
      Cargar_Controles()

   End Sub
#End Region
#Region "****** Rutinas *****"
   Private Sub lnkSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkSalir.Click
      Response.Redirect("w_central.aspx")
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
#End Region


   Private Sub cmbInstPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

      Dim dvInstPago As New DataView
      dvInstPago = DTInstPago.DefaultView
      dvInstPago.RowFilter = "ID_Codigo = " & CType(cmbInstPago.SelectedValue, String)
      Dim dr2 As DataRowView

      'For Each dr2 In dvOperacion
      'txtCOperacion.Text = dr2.Item("Serieini")
      'Next



   End Sub

End Class
