<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_login.aspx.vb" Inherits="AHSB.w_login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Autenticación</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body background="imagenes\fondoi.gif" topMargin="1">
		<form id="Form1" method="post" runat="server">
			<P>&nbsp;</P>
			<P>
				<TABLE id="Table3" style="WIDTH: 904px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="904"
					border="0">
					<TR>
						<TD><asp:image id="Image1" runat="server" ImageUrl="imagenes\logobn.jpg"></asp:image></TD>
					</TR>
				</TABLE>
			</P>
			<TABLE id="Table2" style="WIDTH: 506px; HEIGHT: 428px" cellSpacing="1" cellPadding="1"
				width="506" align="center" bgColor="#990000" border="1">
				<TR>
					<TD>
						<TABLE id="Table1" style="WIDTH: 346px; BORDER-TOP-STYLE: none; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; HEIGHT: 364px; BORDER-BOTTOM-STYLE: none"
							height="364" cellSpacing="1" cellPadding="1" width="346" align="center" bgColor="#ffffff"
							background="imagenes\FondoBN.gif">
							<TR>
								<TD style="WIDTH: 45px; HEIGHT: 21px" align="center"></TD>
								<TD style="WIDTH: 78px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 93px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 245px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 51px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 140px; HEIGHT: 21px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 404px; HEIGHT: 22px" align="center" colSpan="6">
									<P align="center"><STRONG><FONT face="Lucida Sans Unicode" size="4">SECCION AHORROS</FONT></STRONG>
									</P>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 404px; HEIGHT: 22px" align="center" colSpan="6">
									<P align="center"><FONT size="5"><STRONG><FONT face="Lucida Sans Unicode" size="4"> FORMATOS&nbsp;BCR</FONT></STRONG>
										</FONT>
									</P>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 45px; HEIGHT: 35px" align="left"></TD>
								<TD style="WIDTH: 78px; HEIGHT: 35px"></TD>
								<TD style="WIDTH: 93px; HEIGHT: 35px"></TD>
								<TD style="WIDTH: 245px; HEIGHT: 35px"></TD>
								<TD style="WIDTH: 51px; HEIGHT: 35px"></TD>
								<TD style="WIDTH: 140px; HEIGHT: 35px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 45px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 78px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 93px; HEIGHT: 21px">
									<P>&nbsp;</P>
								</TD>
								<TD style="WIDTH: 245px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 51px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 140px; HEIGHT: 21px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 45px; HEIGHT: 27px"></TD>
								<TD style="WIDTH: 78px; HEIGHT: 27px"></TD>
								<TD style="WIDTH: 93px; HEIGHT: 27px">
									<P align="center"><asp:label id="lblUsuario" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="9pt">Usuario</asp:label></P>
								</TD>
								<TD style="WIDTH: 245px; HEIGHT: 27px">&nbsp;&nbsp;&nbsp;&nbsp;<asp:textbox id="txtUsuario" runat="server" Font-Bold="True" Font-Size="9pt" Width="120px" MaxLength="4"></asp:textbox></TD>
								<TD style="WIDTH: 51px; HEIGHT: 27px"></TD>
								<TD style="WIDTH: 140px; HEIGHT: 27px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 45px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 78px; HEIGHT: 21px"></TD>
								<TD style="WIDTH: 93px; HEIGHT: 21px">
									<P align="center"><asp:label id="lblClave" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="9pt"
											Width="45px">Clave  </asp:label></P>
								</TD>
								<TD style="WIDTH: 245px; HEIGHT: 21px">&nbsp;&nbsp;&nbsp;&nbsp;<asp:textbox id="txtClave" runat="server" Font-Bold="True" Font-Size="9pt" Width="120px" MaxLength="8"
										TextMode="Password"></asp:textbox></TD>
								<TD style="WIDTH: 51px; HEIGHT: 21px">
									<P>&nbsp;</P>
									<P>&nbsp;</P>
								</TD>
								<TD style="WIDTH: 140px; HEIGHT: 21px"></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 45px; HEIGHT: 21px" vAlign="middle" align="center">
									<P align="center">&nbsp;</P>
								</TD>
								<TD style="WIDTH: 78px; HEIGHT: 21px" vAlign="middle" align="center">
									<P align="center">&nbsp;&nbsp;</P>
								</TD>
								<TD style="WIDTH: 93px; HEIGHT: 21px" vAlign="middle" align="center">
									<P align="center">
									</P>
								</TD>
								<TD style="WIDTH: 245px; HEIGHT: 21px" vAlign="middle" align="center">
									<P align="center">
										<asp:button id="cmd_Ingresar" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"
											Width="74px" BorderWidth="1px" Height="23px" Text="Ingresar" BorderColor="Black" BorderStyle="Groove"
											BackColor="#CE2229" ForeColor="White"></asp:button>
										<asp:button id="cmdSalir" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"
											Width="74" BorderWidth="1px" Height="23" Text="Salir" BorderColor="Black" BorderStyle="Groove"
											BackColor="#CE2229" ForeColor="White"></asp:button></P>
								</TD>
								<TD style="WIDTH: 51px; HEIGHT: 21px" vAlign="middle" align="center">
									<P align="center">&nbsp;</P>
								</TD>
								<TD style="WIDTH: 140px; HEIGHT: 21px" vAlign="middle" align="center">
									<P align="center">&nbsp;</P>
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 404px; HEIGHT: 72px" colSpan="6" align="center">
									<asp:label id="lblMensajeError" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"></asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 37px"></TD>
								<TD style="WIDTH: 78px"></TD>
								<TD style="WIDTH: 93px"></TD>
								<TD style="WIDTH: 245px"></TD>
								<TD style="WIDTH: 51px"></TD>
								<TD style="WIDTH: 140px"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
