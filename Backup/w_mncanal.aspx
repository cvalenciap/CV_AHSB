<%@ Register TagPrefix="cc1" Namespace="MsgBox" Assembly="MsgBox" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_mncanal.aspx.vb" Inherits="AHSB.w_mncanal" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Mantenimiento de Modelos</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="WIDTH: 488px; HEIGHT: 290px" cellSpacing="1" cellPadding="1"
				width="488">
				<TR>
					<TD style="WIDTH: 45px; HEIGHT: 20px" align="center"><asp:linkbutton id="lnkSalir" runat="server" Font-Names="Arial" Font-Size="7pt">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 77px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 72px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 92px; HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 439px; HEIGHT: 20px" align="center" colSpan="6">
						<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="lblTitulo" runat="server" Font-Names="Arial" Font-Bold="True" Width="155px"> Códigos de Canal</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 45px; HEIGHT: 35px" align="left"></TD>
					<TD style="WIDTH: 77px; HEIGHT: 35px"></TD>
					<TD style="WIDTH: 72px; HEIGHT: 35px">
						<TABLE id="Table6" style="WIDTH: 140px; HEIGHT: 23px" cellSpacing="1" cellPadding="1" width="140"
							align="center" border="0">
							<TR>
								<TD><asp:button id="cmdNuevo" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" BorderColor="Black"
										Text="Nuevo" Visible="False" ToolTip="Adicionar nuevo registro" Height="19px" BorderWidth="1px"></asp:button></TD>
								<TD><asp:button id="cmdModificar" runat="server" Font-Names="Tahoma" Font-Size="XX-Small" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" BorderColor="Black"
										Text="Modificar" Visible="False" ToolTip="Modificar registro" Height="19px" BorderWidth="1px"></asp:button><asp:button id="cmdAceptar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" BorderColor="Black" Text="Grabar" ToolTip="Grabar registro" Height="19px" BorderWidth="1px"></asp:button></TD>
								<TD><asp:button id="cmdEliminar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" BorderColor="Black"
										Text="Eliminar" Visible="False" ToolTip="Eliminar registro" Height="19px" BorderWidth="1px"></asp:button><asp:button id="cmdCancelar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" BorderColor="Black" Text="Cancelar" ToolTip="Cancelar cambios realizados" Height="19px" BorderWidth="1px"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
					<TD style="WIDTH: 73px; HEIGHT: 35px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 35px"></TD>
					<TD style="WIDTH: 92px; HEIGHT: 35px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 439px; HEIGHT: 117px" align="center" colSpan="6">&nbsp;
						<TABLE id="Table2" style="WIDTH: 494px; HEIGHT: 103px" cellSpacing="0" cellPadding="1"
							width="494" align="center" border="2">
							<TR>
								<TD style="WIDTH: 132px; HEIGHT: 34px" vAlign="middle" align="center"><asp:label id="lblcCanal" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="109px" Height="32px">Codigo de Canal</asp:label></TD>
								<TD style="HEIGHT: 34px" align="left">&nbsp;
									<asp:textbox id="txtCanal" runat="server" Font-Names="Arial" Font-Size="9pt" Width="68px" Visible="False"
										ToolTip="Código de Operación " Height="19px" MaxLength="3"></asp:textbox>
									<asp:RangeValidator id="RangeValidator1" runat="server" Font-Bold="True" ErrorMessage="*" Type="Integer"
										MinimumValue="001" MaximumValue="999" ControlToValidate="txtCanal"></asp:RangeValidator></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 132px; HEIGHT: 53px" vAlign="middle" align="center">&nbsp;
									<asp:label id="lblDescripcion" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="85px" Height="18px">Descripción</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
								<TD style="HEIGHT: 53px" align="left">&nbsp;
									<asp:dropdownlist id="cmbCanal" runat="server" Font-Names="Arial" Font-Size="9pt" Width="320px" AutoPostBack="True"></asp:dropdownlist>&nbsp;
									<asp:textbox id="txtDescripcion" runat="server" Font-Names="Arial" Font-Size="9pt" Width="320px"
										Visible="False" ToolTip="Descripción del Código de Canal de Atención" Height="26px" TextMode="MultiLine"></asp:textbox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Font-Bold="True" ErrorMessage="*" ControlToValidate="txtDescripcion"></asp:RequiredFieldValidator></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 45px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 77px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 72px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 21px"></TD>
					<TD style="WIDTH: 92px; HEIGHT: 21px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 37px"><cc1:msgbox id="MsgBox1" runat="server"></cc1:msgbox></TD>
					<TD style="WIDTH: 77px"></TD>
					<TD style="WIDTH: 72px"></TD>
					<TD style="WIDTH: 73px"></TD>
					<TD style="WIDTH: 48px"></TD>
					<TD style="WIDTH: 92px"></TD>
				</TR>
			</TABLE>
			<TABLE id="Table5" style="WIDTH: 301px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="301"
				align="center" border="0">
			</TABLE>
		</form>
	</body>
</HTML>
