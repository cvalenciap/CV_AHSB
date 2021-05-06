<%@ Register TagPrefix="rjs" Namespace="RJS.Web.WebControl" Assembly="RJS.Web.WebControl.PopCalendar" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_atencion_cliente.aspx.vb" Inherits="AHSB.w_atencion_cliente" %>
<%@ Register TagPrefix="cc1" Namespace="MsgBox" Assembly="MsgBox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Atención de Clientes</title>
		<meta content="False" name="vs_snapToGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="HEIGHT: 224px" cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD style="WIDTH: 127px; HEIGHT: 20px" align="left"><asp:linkbutton id="lnkSalir" runat="server" Font-Size="7pt" Font-Names="Arial">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 284px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 57px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 60px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 78px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 84px; HEIGHT: 20px"></TD>
					<TD style="HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 435px; HEIGHT: 21px" align="center" colSpan="6">
						<P align="center"><asp:label id="lblTitulo" runat="server" Font-Names="Arial" Font-Bold="True" Width="406px"> Atención de Clientes</asp:label></P>
					</TD>
					<TD style="HEIGHT: 21px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 127px; HEIGHT: 9px" align="left"></TD>
					<TD style="WIDTH: 284px; HEIGHT: 9px"></TD>
					<TD style="WIDTH: 57px; HEIGHT: 9px"></TD>
					<TD style="WIDTH: 60px; HEIGHT: 9px">&nbsp;</TD>
					<TD style="WIDTH: 78px; HEIGHT: 9px"></TD>
					<TD style="WIDTH: 84px; HEIGHT: 9px"></TD>
					<TD style="HEIGHT: 9px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 435px; HEIGHT: 71px" align="center" colSpan="6">
						<TABLE id="Table4" style="WIDTH: 463px; HEIGHT: 42px" cellSpacing="1" cellPadding="1" width="463"
							border="0">
							<TR>
								<TD style="WIDTH: 262px">&nbsp;
									<asp:label id="lblNTicket" runat="server" Font-Size="10pt" Font-Names="Arial" Font-Bold="True"
										ForeColor="DimGray">Nro. Ticket:</asp:label>&nbsp;&nbsp;
									<asp:label id="lblTicket" runat="server" Font-Size="10pt" Font-Names="Arial" Font-Bold="True"
										ForeColor="DimGray"></asp:label>&nbsp;&nbsp;&nbsp;<asp:imagebutton id="cmdImprimir" runat="server" Height="21px" ImageUrl="imagenes\printer1.jpg"></asp:imagebutton></TD>
								<TD><asp:button id="cmdNuevo" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" Height="19px" Text="Nuevo" BorderStyle="Solid" BackColor="White"
										ToolTip="Ingresar un nuevo Evento de Riesgo" BorderWidth="1px" Visible="False"></asp:button><asp:button id="cmdAceptar" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" Height="19px" Text="Grabar " BorderStyle="Solid" BackColor="White" ToolTip="Grabar Ticket de Atención" BorderWidth="1px" Visible="False"></asp:button><asp:button id="cmdCancelar" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" Height="19px" Text="Cancelar" BorderStyle="Solid" BackColor="White" ToolTip="Cancelar cambios realizados" BorderWidth="1px"></asp:button><asp:button id="cmdModificar" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" Height="19px" Text="Modificar" BorderStyle="Solid" BackColor="White" ToolTip="Modificar Evento " BorderWidth="1px" Visible="False"></asp:button><asp:button id="cmdEliminar" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Width="60px" ForeColor="#CE2229" Height="19px" Text="Eliminar" BorderStyle="Solid" BackColor="White" ToolTip="Eliminar Evento" BorderWidth="1px" Visible="False"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
					<TD style="HEIGHT: 71px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 435px; HEIGHT: 142px" align="center" colSpan="6">
						<TABLE id="Table2" style="WIDTH: 467px; HEIGHT: 40px" borderColor="#993300" cellSpacing="0"
							cellPadding="0" width="467" border="1">
							<TR>
								<TD style="WIDTH: 106px" borderColor="#ffffff">&nbsp;<asp:label id="lblDocumento" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Height="4px">Doc. Identificación</asp:label></TD>
								<TD style="WIDTH: 150px">&nbsp;<asp:label id="lblTipo" runat="server" Font-Size="7pt" Font-Names="Arial" Width="32px">Tipo</asp:label><asp:dropdownlist id="cmbTDocumento" runat="server" Font-Size="7pt" Font-Names="Arial" Width="106px"></asp:dropdownlist></TD>
								<TD>&nbsp;<asp:label id="lblNumero" runat="server" Font-Size="7pt" Font-Names="Arial" Width="40px">Número</asp:label>&nbsp;
									<asp:textbox id="txtNDocumento" runat="server" Font-Size="7pt" Font-Names="Arial" Width="82px"
										MaxLength="15"></asp:textbox></TD>
							</TR>
						</TABLE>
						<TABLE id="Table3" style="WIDTH: 468px; HEIGHT: 63px" cellSpacing="1" cellPadding="1" width="468"
							border="1">
							<TR>
								<TD style="WIDTH: 102px; HEIGHT: 8px" borderColor="#ffffff">&nbsp;<asp:label id="lblDatosPlaca" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True"
										Width="64px">Datos Placa</asp:label></TD>
								<TD style="WIDTH: 147px; HEIGHT: 8px" bgColor="#f5f5f5"><asp:label id="lblTVehiculo" runat="server" Font-Size="7pt" Font-Names="Arial" Width="32px">Vehículo</asp:label><asp:dropdownlist id="cmbTVehiculo" runat="server" Font-Size="7pt" Font-Names="Arial" Width="104px"
										AutoPostBack="True"></asp:dropdownlist></TD>
								<TD style="WIDTH: 167px; HEIGHT: 8px" bgColor="#f5f5f5">&nbsp;
									<asp:label id="lblPlaca" runat="server" Font-Size="7pt" Font-Names="Arial" Width="40px">Placa</asp:label>&nbsp;<asp:textbox id="txtSerie" runat="server" Font-Size="7pt" Font-Names="Arial" Width="37px" MaxLength="3"></asp:textbox>&nbsp;
									<asp:label id="lblGuion" runat="server" Font-Size="9pt" Font-Names="Arial">-</asp:label>&nbsp;
									<asp:textbox id="txtNumero" runat="server" Font-Size="7pt" Font-Names="Arial" Width="40px" MaxLength="4"></asp:textbox></TD>
								<TD style="HEIGHT: 8px"><asp:imagebutton id="cmdVerificaStock" runat="server" Width="24px" Height="18px" ImageUrl="imagenes\verifica.jpg"
										ToolTip="Verifica existencia de placa" BorderWidth="1px"></asp:imagebutton></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 102px; HEIGHT: 21px" borderColor="#ffffff">&nbsp;<asp:label id="lblRefrendo" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Datos Refrendo</asp:label></TD>
								<TD style="WIDTH: 147px; HEIGHT: 21px" bgColor="#f5f5f5">&nbsp;<asp:label id="lblFRegistro" runat="server" Font-Size="7pt" Font-Names="Arial">Fecha</asp:label>&nbsp;
									<asp:textbox id="txtFRefrendo" runat="server" Font-Size="7pt" Font-Names="Arial" Width="56px"
										ReadOnly="True"></asp:textbox>&nbsp;&nbsp;
									<rjs:popcalendar id="PopCalendar1" runat="server" Control="txtFRefrendo" Separator="/"></rjs:popcalendar></TD>
								<TD style="WIDTH: 167px; HEIGHT: 21px" bgColor="#f5f5f5">&nbsp;<asp:label id="lblSecuencia" runat="server" Font-Size="7pt" Font-Names="Arial" Width="32px">Secuencia</asp:label>&nbsp;
									<asp:textbox id="txtNSecuencia" runat="server" Font-Size="7pt" Font-Names="Arial" Width="85px"
										MaxLength="6"></asp:textbox></TD>
								<TD style="HEIGHT: 21px"><asp:imagebutton id="cmdVerificaRefrendo" runat="server" Width="24px" Height="18px" ImageUrl="imagenes\verifica.jpg"
										ToolTip="Verifica valdez del refrendo" BorderWidth="1px"></asp:imagebutton></TD>
							</TR>
						</TABLE>
						<br>
						<asp:button id="cmdAgregar" runat="server" Font-Size="7pt" Font-Names="Arial" Width="59px" ForeColor="Maroon"
							Text="Agrega" BorderStyle="Solid" BackColor="White" ToolTip="Adiciona placa al ticket de Atención"
							BorderColor="#400000"></asp:button>&nbsp; &nbsp;
						<asp:button id="cmdElimina" runat="server" Font-Size="7pt" Font-Names="Arial" Width="55px" ForeColor="Maroon"
							Text="Elimina" BorderStyle="Solid" BackColor="White" ToolTip="Elimina placa del Ticket de Atención"
							BorderColor="#400000"></asp:button></TD>
					<TD style="HEIGHT: 142px" align="center"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 435px; HEIGHT: 13px" align="center" colSpan="6"><IMG src="imagenes\linearoja.gif"></TD>
					<TD style="HEIGHT: 13px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 435px; HEIGHT: 135px" align="center" colSpan="6"><asp:datagrid id="dtgAtencion" runat="server" Font-Size="7pt" Font-Names="Arial" Width="353px"
							Height="85px" BorderStyle="None" BackColor="White" ToolTip="Relación de Periodos" BorderWidth="1px" BorderColor="#CCCCCC" CellPadding="3">
							<FooterStyle ForeColor="Black" BackColor="White"></FooterStyle>
							<SelectedItemStyle Font-Bold="True" ForeColor="Black" BackColor="#FFFFCC"></SelectedItemStyle>
							<ItemStyle ForeColor="Black"></ItemStyle>
							<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#CE2229"></HeaderStyle>
							<PagerStyle HorizontalAlign="Left" ForeColor="Black" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></TD>
					<TD style="HEIGHT: 135px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 127px"><cc1:msgbox id="MsgBox1" runat="server"></cc1:msgbox></TD>
					<TD style="WIDTH: 284px"></TD>
					<TD style="WIDTH: 57px"></TD>
					<TD style="WIDTH: 60px"></TD>
					<TD style="WIDTH: 78px"></TD>
					<TD style="WIDTH: 84px"></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
