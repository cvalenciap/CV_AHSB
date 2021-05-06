<%@ Register TagPrefix="cc1" Namespace="MsgBox" Assembly="MsgBox" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_mnttransac.aspx.vb" Inherits="AHSB.w_mnttransac" %>
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
			<TABLE id="Table1" style="WIDTH: 512px; HEIGHT: 306px" cellSpacing="1" cellPadding="1"
				width="512">
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
						<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:label id="lblTitulo" runat="server" Font-Names="Arial" Font-Bold="True" Width="202px"> Tipos de Transacción</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
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
					<TD style="WIDTH: 439px; HEIGHT: 132px" align="center" colSpan="6" rowSpan="1">
						<DIV align="center">&nbsp;&nbsp;
						</DIV>
						<DIV align="center">
							<TABLE id="Table2" style="WIDTH: 487px; HEIGHT: 112px" cellSpacing="0" cellPadding="1"
								width="487" align="center" border="2">
								<TR>
									<TD style="WIDTH: 131px; HEIGHT: 34px" vAlign="middle" align="center"><asp:label id="lblCoperacion" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
											Width="109px" Height="32px">Código</asp:label></TD>
									<TD style="HEIGHT: 34px" align="left" colSpan="1" rowSpan="1">&nbsp;
										<asp:textbox id="txtCOperacion" runat="server" Font-Names="Arial" Font-Size="9pt" Width="68px"
											Visible="False" ToolTip="Código de Operación " Height="19px" MaxLength="3"></asp:textbox>
										<asp:RangeValidator id="RangeValidator1" runat="server" Font-Bold="True" ErrorMessage="*" ControlToValidate="txtCOperacion"
											MaximumValue="999" Type="Integer" MinimumValue="001"></asp:RangeValidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 131px; HEIGHT: 36px" vAlign="middle" align="center">
										<P align="center">&nbsp;
											<asp:label id="lblDescripcion" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
												Width="85px" Height="14px">Descripción</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P>
									</TD>
									<TD style="HEIGHT: 37px" align="left">
										<P align="center">&nbsp;
											<asp:dropdownlist id="cmbTtxn" runat="server" Font-Names="Arial" Font-Size="9pt" Width="347px" Height="26px"
												AutoPostBack="True"></asp:dropdownlist>&nbsp;
											<asp:textbox id="txtDescripcion" runat="server" Font-Names="Arial" Font-Size="9pt" Width="321"
												Visible="False" ToolTip="Descripción del Código de Transacción" Height="26" MaxLength="100"
												TextMode="MultiLine"></asp:textbox>
											<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Font-Bold="True" ErrorMessage="*" ControlToValidate="txtDescripcion"></asp:RequiredFieldValidator></P>
									</TD>
								</TR>
							</TABLE>
						</DIV>
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
