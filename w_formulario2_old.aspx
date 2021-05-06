<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_formulario2.aspx.vb" Inherits="AHSB.w_formulario2" %>
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
			<TABLE id="Table1" style="WIDTH: 600px; HEIGHT: 725px" cellSpacing="1" cellPadding="1"
				width="600">
				<TR>
					<TD style="WIDTH: 45px; HEIGHT: 20px" align="center"><asp:linkbutton id="lnkSalir" runat="server" Font-Names="Arial" Font-Size="7pt">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 92px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 71px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 178px; HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 29px" align="center" colSpan="6">
						<P align="center"><asp:label id="lblTitulo" runat="server" Font-Names="Arial" Font-Bold="True" Width="406px">Registro de Formulario Nro. 2</asp:label></P>
						<P align="center">&nbsp;</P>
					</TD>
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
										Width="60px" ToolTip="Modificar Evento " BorderWidth="1px" Height="19px" Visible="False" BorderStyle="Solid"
										BackColor="White" ForeColor="#CE2229" Text="Modificar"></asp:button><asp:button id="cmdAceptar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Grabar cambios realizados" BorderWidth="1px" Height="19px" BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Aceptar"></asp:button></TD>
								<TD><asp:button id="cmdEliminar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Eliminar Evento" BorderWidth="1px" Height="19px" Visible="False" BorderStyle="Solid"
										BackColor="White" ForeColor="#CE2229" Text="Eliminar"></asp:button><asp:button id="cmdCancelar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
										Width="60px" ToolTip="Cancelar cambios realizados" BorderWidth="1px" Height="19px" Visible="False" BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Cancelar"></asp:button></TD>
							</TR>
						</TABLE>
					</TD>
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
									<asp:label id="lblCodBCR" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px">Cod. BCR</asp:label>&nbsp;
									<asp:textbox id="txtCodBCR" runat="server" Font-Size="7pt" Font-Names="Arial" Width="73px" ReadOnly="True"></asp:textbox></TD>
								<TD>&nbsp;
									<asp:label id="lblNormativa" runat="server" Font-Size="7pt" Font-Names="Arial" Width="88px">Normativa</asp:label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:textbox id="txtNormativa" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
										ReadOnly="True"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 205px" vAlign="middle" align="left"><asp:label id="lblPeriodo" runat="server" Font-Names="Arial" Font-Size="7pt" Width="64px">Periodo</asp:label>
									<asp:dropdownlist id="Dropdownlist1" runat="server" Font-Size="7pt" Font-Names="Arial" Width="73px"
										AutoPostBack="True"></asp:dropdownlist>
									<asp:textbox id="txtPeriodo" runat="server" Font-Names="Arial" Font-Size="7pt" Width="48px" ReadOnly="True"></asp:textbox></TD>
								<TD>&nbsp;
									<asp:label id="lblFuncionario" runat="server" Font-Names="Arial" Font-Size="7pt" Width="136px">Funcionario Responsable</asp:label>
									<asp:textbox id="txtFuncionario" runat="server" Font-Names="Arial" Font-Size="7pt" Width="184px"
										MaxLength="15" ReadOnly="True"></asp:textbox></TD>
							</TR>
						</TABLE>
						<P>&nbsp;</P>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 181px" align="center" colSpan="6"><asp:panel id="pnlDetalle" runat="server" Height="235px" Width="520px" DESIGNTIMEDRAGDROP="59">
							<DIV>
								<TABLE id="Table12" style="WIDTH: 552px; HEIGHT: 174px" cellSpacing="0" cellPadding="1"
									width="552" bgColor="whitesmoke" border="1">
									<TR>
										<TD style="WIDTH: 100px; HEIGHT: 28px" vAlign="middle" align="left">
											<asp:label id="lblInstPago" runat="server" Font-Size="7pt" Font-Names="Arial" Width="79px">Instrumento Pago</asp:label><BR>
										</TD>
										<TD style="HEIGHT: 28px">&nbsp;
											<asp:dropdownlist id="cmbInstPago" runat="server" Font-Size="7pt" Font-Names="Arial" Width="136px"
												AutoPostBack="True"></asp:dropdownlist><BR>
										</TD>
										<TD style="WIDTH: 125px; HEIGHT: 28px" colSpan="2"><BR>
											<asp:label id="lblTransaccion" runat="server" Font-Size="7pt" Font-Names="Arial" Width="96px">Tipo de Transaccion</asp:label><BR>
										</TD>
										<TD style="WIDTH: 5px; HEIGHT: 28px" colSpan="2">
											<DIV>
												<asp:dropdownlist id="cmbTransaccion" runat="server" Font-Size="7pt" Font-Names="Arial" Width="120px"></asp:dropdownlist></DIV>
										</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 100px; HEIGHT: 28px" vAlign="middle" align="left">
											<asp:label id="lblCanal" runat="server" Font-Size="7pt" Font-Names="Arial">Canal</asp:label></TD>
										<TD style="HEIGHT: 28px">
											<asp:dropdownlist id="cmbCanal" runat="server" Font-Size="7pt" Font-Names="Arial" Width="88px"></asp:dropdownlist></TD>
										<TD style="WIDTH: 45px; HEIGHT: 28px" colSpan="4">
											<asp:label id="lblObservaciones" runat="server" Font-Size="7pt" Font-Names="Arial">Observaciones</asp:label>
											<asp:TextBox id="txtObservaciones" runat="server" Width="248px" ToolTip="Colocar toda aquella observación que se considere relevante"
												TextMode="MultiLine"></asp:TextBox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 100px; HEIGHT: 32px" vAlign="middle" align="left">
											<asp:label id="lblNroOperaMN" runat="server" Font-Size="7pt" Font-Names="Arial" Width="96px">Nro.Operaciones MN</asp:label></TD>
										<TD style="WIDTH: 195px; HEIGHT: 32px" colSpan="2">&nbsp;&nbsp;<BR>
											&nbsp;&nbsp;&nbsp;
											<asp:textbox id="txtNroOperaMN" runat="server" Font-Size="7pt" Font-Names="Arial" Width="104px"
												ReadOnly="True"></asp:textbox></TD>
										<TD style="WIDTH: 125px; HEIGHT: 32px"><BR>
											<asp:label id="lblValorOperaMN" runat="server" Font-Size="7pt" Font-Names="Arial" Width="96px">Valor Operaciones MN</asp:label></TD>
										<TD style="HEIGHT: 32px" colSpan="2">
											<asp:textbox id="txtValorOperaMN" runat="server" Font-Size="7pt" Font-Names="Arial" Width="104px"
												ReadOnly="True"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 100px" vAlign="middle" align="left">
											<asp:label id="lblNroOperaME" runat="server" Font-Size="7pt" Font-Names="Arial" Width="96px">Nro.Operaciones ME</asp:label></TD>
										<TD style="WIDTH: 195px" colSpan="2">&nbsp;&nbsp;
											<asp:textbox id="txtNroOperaME" runat="server" Font-Size="7pt" Font-Names="Arial" Width="104px"
												ReadOnly="True"></asp:textbox></TD>
										<TD style="WIDTH: 125px">
											<asp:label id="lblValorOperaME" runat="server" Font-Size="7pt" Font-Names="Arial" Width="96px">Valor Operaciones ME</asp:label></TD>
										<TD colSpan="2">
											<asp:textbox id="txtValorOperaME" runat="server" Font-Size="7pt" Font-Names="Arial" Width="104px"
												ReadOnly="True"></asp:textbox></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 100px" vAlign="middle" align="left"></TD>
										<TD colSpan="5">&nbsp;&nbsp;
										</TD>
									</TR>
									<DIV>&nbsp;</DIV>
								</TABLE>
							</DIV>
							<DIV>&nbsp;</DIV>
							<DIV>
								<asp:button id="cmdAgrega" runat="server" Font-Size="7pt" Font-Names="Arial" Width="69px" Text="Agrega"
									ForeColor="Maroon" BackColor="White" BorderStyle="Double" BorderColor="#400000"></asp:button>&nbsp;
								<asp:button id="cmdElimina" runat="server" Font-Size="7pt" Font-Names="Arial" Width="63px" Text="Elimina"
									ForeColor="Maroon" BackColor="White" BorderStyle="Double" BorderColor="#400000"></asp:button></DIV>
						</asp:panel>&nbsp;</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 8px" align="center" colSpan="6"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 142px" align="center" colSpan="6"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 37px"></TD>
					<TD style="WIDTH: 92px"></TD>
					<TD style="WIDTH: 71px"></TD>
					<TD style="WIDTH: 73px"></TD>
					<TD style="WIDTH: 48px"></TD>
					<TD style="WIDTH: 178px"></TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
