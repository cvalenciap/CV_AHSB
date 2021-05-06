<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_formulario3.aspx.vb" Inherits="AHSB.w_formulario3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Registro de Placas</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="HEIGHT: 545px" cellSpacing="1" cellPadding="1" width="100%">
				<TR>
					<TD style="WIDTH: 45px; HEIGHT: 20px" align="center"><asp:linkbutton id="lnkSalir" runat="server" Font-Names="Arial" Font-Size="7pt">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 92px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 71px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 178px; HEIGHT: 20px"></TD>
					<TD style="HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 29px" align="center" colSpan="6">
						<P align="center"><asp:label id="lblTitulo" runat="server" Font-Names="Arial" Font-Bold="True" Width="406px">Registro de Formulario Nro. 3</asp:label></P>
						<P align="center">&nbsp;</P>
					</TD>
					<TD style="HEIGHT: 29px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 40px" align="center" colSpan="6">
						<TABLE id="Table17" style="WIDTH: 220px; HEIGHT: 42px" cellSpacing="1" cellPadding="1"
							width="220" align="center" border="0">
							<TR>
								<TD style="WIDTH: 72px"><asp:button id="cmdNuevo" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Ingresar un nuevo Evento de Riesgo" BorderWidth="1px" Height="19px" Visible="False" BorderStyle="Solid"
										BackColor="White" ForeColor="#CE2229" Text="Nuevo"></asp:button></TD>
								<TD><asp:button id="cmdModificar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Modificar Evento " BorderWidth="1px" Height="19px" Visible="False"
										BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Modificar"></asp:button><asp:button id="cmdAceptar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Grabar cambios realizados" BorderWidth="1px" Height="19px" BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Aceptar"></asp:button></TD>
								<TD><asp:button id="cmdEliminar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Eliminar Evento" BorderWidth="1px" Height="19px" Visible="False" BorderStyle="Solid"
										BackColor="White" ForeColor="#CE2229" Text="Eliminar"></asp:button><asp:button id="cmdCancelar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Cancelar cambios realizados" BorderWidth="1px" Height="19px" Visible="False" BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Cancelar"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
					<TD style="HEIGHT: 40px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 60px" align="center" colSpan="6">
						<TABLE id="Table3" style="WIDTH: 314px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="314"
							border="0">
						</TABLE>
						<TABLE id="Table2" style="WIDTH: 552px; HEIGHT: 69px" cellSpacing="0" cellPadding="1" width="552"
							border="1">
							<TR>
								<TD style="WIDTH: 205px" vAlign="middle" align="left">
									<asp:label style="Z-INDEX: 0" id="lblCodBCR" runat="server" Font-Size="7pt" Font-Names="Arial"
										Width="64px">Cod. BCR</asp:label>&nbsp;
									<asp:textbox style="Z-INDEX: 0" id="txtCodBCR" runat="server" Font-Size="7pt" Font-Names="Arial"
										Width="73px" ReadOnly="True"></asp:textbox></TD>
								<TD>&nbsp;
									<asp:label style="Z-INDEX: 0" id="lblNormativa" runat="server" Font-Size="7pt" Font-Names="Arial"
										Width="88px">Normativa</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:textbox style="Z-INDEX: 0" id="txtNormativa" runat="server" Font-Size="7pt" Font-Names="Arial"
										Width="64px" ReadOnly="True"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 205px" vAlign="middle" align="left"><asp:label id="lblPeriodo" runat="server" Font-Names="Arial" Font-Size="7pt" style="Z-INDEX: 0"
										Width="64px">Periodo</asp:label>
									<asp:dropdownlist style="Z-INDEX: 0" id="cmbMes" runat="server" Font-Size="7pt" Font-Names="Arial"
										Width="73px" AutoPostBack="True"></asp:dropdownlist>
									<asp:textbox id="txtAnno" runat="server" Font-Names="Arial" Font-Size="7pt" Width="48px" ReadOnly="True"
										style="Z-INDEX: 0"></asp:textbox></TD>
								<TD>&nbsp;
									<asp:label id="lblFuncionario" runat="server" Font-Names="Arial" Font-Size="7pt" style="Z-INDEX: 0"
										Width="136px">Funcionario Responsable</asp:label>
									<asp:textbox id="txtFuncionario" runat="server" Font-Names="Arial" Font-Size="7pt" Width="184px"
										MaxLength="15" style="Z-INDEX: 0"></asp:textbox></TD>
							</TR>
						</TABLE>
						<P>&nbsp;</P>
					</TD>
					<TD style="HEIGHT: 60px"></TD>
				</TR>
				<TR>
					<TD style="Z-INDEX: 0; WIDTH: 532px; HEIGHT: 181px" align="center" colSpan="6"><asp:panel id="pnlDetalle" runat="server" Height="160px">
							<DIV>
								<TABLE style="WIDTH: 486px; HEIGHT: 88px" id="Table12" border="1" cellSpacing="0" cellPadding="1"
									width="486" bgColor="whitesmoke">
									<TR>
										<TD style="WIDTH: 102px; HEIGHT: 28px" vAlign="middle" align="left">
											<asp:label id="lblConcepto" runat="server" Font-Size="7pt" Font-Names="Arial">Concepto Cobro</asp:label><BR>
										</TD>
										<TD style="HEIGHT: 28px">
											<asp:dropdownlist id="cmbConcepto" runat="server" Font-Size="7pt" Font-Names="Arial" Width="136px"
												AutoPostBack="True"></asp:dropdownlist><BR>
										</TD>
										<TD style="WIDTH: 137px; HEIGHT: 28px">
											<asp:label id="lblCanal" runat="server" Font-Size="7pt" Font-Names="Arial">Canal</asp:label><BR>
										</TD>
										<TD style="HEIGHT: 28px">
											<asp:dropdownlist id="cmbCanal" runat="server" Font-Size="7pt" Font-Names="Arial" Width="88px"></asp:dropdownlist><BR>
										</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 102px" vAlign="middle" align="left">
											<asp:label style="Z-INDEX: 0" id="lblComision" runat="server" Font-Size="7pt" Font-Names="Arial">Comisión BCR</asp:label></TD>
										<TD>
											<asp:dropdownlist style="Z-INDEX: 0" id="cmbComisionBCR" runat="server" Font-Size="7pt" Font-Names="Arial"
												Width="88px"></asp:dropdownlist></TD>
										<TD style="WIDTH: 137px"><BR>
											<asp:label style="Z-INDEX: 0" id="lblClienteCom" runat="server" Font-Size="7pt" Font-Names="Arial">Cliente Asume Comision</asp:label></TD>
										<TD><BR>
											<asp:dropdownlist style="Z-INDEX: 0" id="cmbClienteCom" runat="server" Font-Size="7pt" Font-Names="Arial"
												Width="136px" Height="26px" AutoPostBack="True"></asp:dropdownlist></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 102px" vAlign="middle" align="left">
											<asp:label style="Z-INDEX: 0" id="lbTarifaMN" runat="server" Font-Size="7pt" Font-Names="Arial">Tarifa MN</asp:label></TD>
										<TD>
											<asp:textbox style="Z-INDEX: 0" id="txtTarifaMN" runat="server" Font-Size="7pt" Font-Names="Arial"
												Width="104px" ReadOnly="True"></asp:textbox></TD>
										<TD style="WIDTH: 137px">
											<asp:label style="Z-INDEX: 0" id="lblTarifaME" runat="server" Font-Size="7pt" Font-Names="Arial">Tarifa ME</asp:label></TD>
										<TD>
											<asp:textbox style="Z-INDEX: 0" id="txtTarifaME" runat="server" Font-Size="7pt" Font-Names="Arial"
												Width="104px" ReadOnly="True"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 102px" vAlign="middle" align="left">
											<asp:label style="Z-INDEX: 0" id="lblObservaciones" runat="server" Font-Size="7pt" Font-Names="Arial">Observaciones</asp:label></TD>
										<TD colSpan="3">
											<asp:TextBox id="txtObservaciones" runat="server" Width="395px" TextMode="MultiLine"></asp:TextBox></TD>
									</TR>
									<DIV></DIV>
								</TABLE>
							</DIV>
							<DIV>&nbsp;</DIV>
							<DIV>
								<asp:button style="Z-INDEX: 0" id="cmdAgrega" runat="server" Font-Size="7pt" Font-Names="Arial"
									Width="69px" Text="Agrega" ForeColor="Maroon" BackColor="White" BorderStyle="Double" BorderColor="#400000"></asp:button>&nbsp;
								<asp:button style="Z-INDEX: 0" id="cmdElimina" runat="server" Font-Size="7pt" Font-Names="Arial"
									Width="63px" Text="Elimina" ForeColor="Maroon" BackColor="White" BorderStyle="Double" BorderColor="#400000"></asp:button></DIV>
						</asp:panel>&nbsp;</TD>
					<TD style="Z-INDEX: 0; HEIGHT: 181px">&nbsp;&nbsp;
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 8px" align="center" colSpan="6"></TD>
					<TD style="HEIGHT: 8px"></TD>
				</TR>
				<TR>
					<TD style="Z-INDEX: 0; WIDTH: 532px; HEIGHT: 142px" align="center" colSpan="6"></TD>
					<TD style="Z-INDEX: 0; HEIGHT: 142px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 37px"></TD>
					<TD style="WIDTH: 92px"></TD>
					<TD style="WIDTH: 71px"></TD>
					<TD style="WIDTH: 73px"></TD>
					<TD style="WIDTH: 48px"></TD>
					<TD style="WIDTH: 178px"></TD>
					<TD></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
