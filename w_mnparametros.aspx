<%@ Register TagPrefix="cc2" Namespace="MsgBox" Assembly="MsgBox" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_mnparametros.aspx.vb" Inherits="AHSB.w_mnparametros" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Configuración de Parametros</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<FORM id="Form1" method="post" runat="server">
			<P>
				<asp:linkbutton id="Linkbutton1" runat="server" Font-Size="7pt" Font-Names="Arial">Salir</asp:linkbutton></P>
			<P>
				<TABLE id="Table2" style="WIDTH: 476px; HEIGHT: 170px" cellSpacing="1" cellPadding="1"
					width="476" border="0">
					<TR>
						<TD style="WIDTH: 214px; HEIGHT: 51px" bgColor="#f5f5f5"><asp:label id="Label2" runat="server" Font-Names="Arial" Font-Size="8pt" Width="130px" Font-Bold="True">Código BCR :</asp:label><asp:label id="Label5" runat="server" Font-Names="Arial" Font-Size="7pt" Width="197px" ForeColor="Black"
								Font-Bold="True"> (Identificador del Banco de la Nación ante la SBS)</asp:label></TD>
						<TD style="WIDTH: 271px; HEIGHT: 51px" vAlign="middle"><asp:textbox id="txtCodSBS" runat="server" Font-Names="Arial" Font-Size="7pt" Width="65px" ReadOnly="True"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 214px; HEIGHT: 51px" bgColor="whitesmoke" colSpan="1" rowSpan="1"><asp:label id="Label1" runat="server" Font-Names="Arial" Font-Size="8pt" Width="130px" Font-Bold="True"> Normativa:</asp:label><asp:label id="Label4" runat="server" Font-Names="Arial" Font-Size="7pt" Width="188px" ForeColor="Black"
								Font-Bold="True"> (Número del documento oficial de la SBS que norma la entrega de información operativa)</asp:label></TD>
						<TD style="WIDTH: 271px; HEIGHT: 51px" vAlign="middle"><asp:textbox id="txtNormativa" runat="server" Font-Names="Arial" Font-Size="7pt" Width="56px"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 214px; HEIGHT: 63px" bgColor="#f5f5f5"><asp:label id="Label3" runat="server" Font-Names="Arial" Font-Size="8pt" Width="168px" Font-Bold="True">Funcionario Responsable :</asp:label><asp:label id="Label6" runat="server" Font-Names="Arial" Font-Size="7pt" Width="193px" ForeColor="Black"
								Font-Bold="True"> (Funcionario del BN responsable ante la SBS de la información proporcionada)</asp:label></TD>
						<TD style="WIDTH: 271px; HEIGHT: 63px" vAlign="middle" noWrap><asp:textbox id="txtFuncionario" runat="server" Font-Names="Arial" Font-Size="7pt" Width="279px"
								Height="57px" TextMode="MultiLine"></asp:textbox></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 214px; HEIGHT: 30px" colSpan="1" rowSpan="1">
						<TD style="WIDTH: 271px; HEIGHT: 30px" vAlign="top"><asp:button id="cmdGuardar" runat="server" Font-Names="Tahoma" Font-Size="XX-Small" Width="70px"
								ForeColor="#CE2229" Height="21px" Font-Bold="True" ToolTip="Guarda los Parametros Actuales..." BackColor="White" BorderStyle="Solid" BorderWidth="1px"
								Text="Guardar"></asp:button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
					</TR>
				</TABLE>
			</P>
			<cc2:msgbox id="MsgBox1" runat="server"></cc2:msgbox></FORM>
	</body>
</HTML>
