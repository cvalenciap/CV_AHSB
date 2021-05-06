<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_formulario3.aspx.vb" Inherits="AHSB.w_formulario3" %>
<%@ Register TagPrefix="cc2" Namespace="MsgBox" Assembly="MsgBox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Formatos Ahorros</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		
	</HEAD>
	<body leftMargin="0" onunload="bye()">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="WIDTH: 868px; HEIGHT: 504px" cellSpacing="1" cellPadding="1"
				width="868">
				<TR>
					<TD style="WIDTH: 1px; HEIGHT: 20px" align="center"></TD>
					<TD style="WIDTH: 45px; HEIGHT: 20px" align="center"><asp:linkbutton id="lnkSalir" runat="server" Font-Names="Arial" Font-Size="7pt">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 92px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 71px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 178px; HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 1px; HEIGHT: 18px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 18px" align="center" colSpan="6"><asp:label id="lblTitulo" runat="server" Font-Names="Lucida Sans Unicode" Font-Size="14pt"
							Font-Bold="True" Width="852px">Comisiones por Transferencias LBTR</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 1px; HEIGHT: 173px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 173px" align="center" colSpan="6">
						<p></p>
						<asp:panel id="pnlDetalle" runat="server" Width="856px" Height="152px">
							<DIV align="center">
								<DIV align="center">
									<TABLE id="Table17" style="WIDTH: 240px; HEIGHT: 42px" cellSpacing="1" cellPadding="1"
										width="240" align="center" border="0">
										<TR>
											<TD style="WIDTH: 72px">
												<asp:button id="cmdNuevo" runat="server" Font-Size="8pt" Font-Names="Arial" Width="60px" Font-Bold="True"
													Height="19px" ToolTip="Ingresar un nuevo Evento de Riesgo" BorderWidth="1px" Visible="False"
													BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Nuevo"></asp:button></TD>
											<TD>
												<asp:button id="cmdModificar" runat="server" Font-Size="8pt" Font-Names="Arial" Width="60px"
													Font-Bold="True" Height="19px" ToolTip="Modificar Evento " BorderWidth="1px" Visible="False"
													BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Modificar"></asp:button>
												<asp:button id="cmdAceptar" runat="server" Font-Size="8pt" Font-Names="Arial" Width="60px" Font-Bold="True"
													Height="19px" ToolTip="Grabar cambios realizados" BorderWidth="1px" BorderStyle="Solid"
													BackColor="White" ForeColor="#CE2229" Text="Aceptar"></asp:button></TD>
											<TD>
												<asp:button id="cmdEliminar" runat="server" Font-Size="8pt" Font-Names="Arial" Width="60px"
													Font-Bold="True" Height="19px" ToolTip="Eliminar Evento" BorderWidth="1px" Visible="False"
													BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Eliminar"></asp:button>
												<asp:button id="cmdCancelar" runat="server" Font-Size="8pt" Font-Names="Arial" Width="60px"
													Font-Bold="True" Height="19px" ToolTip="Cancelar cambios realizados" BorderWidth="1px" Visible="False"
													BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Cancelar"></asp:button></TD>
										</TR>
									</TABLE>
									&nbsp;&nbsp;
									<TABLE id="Table2" style="WIDTH: 656px; HEIGHT: 77px" cellSpacing="0" cellPadding="1" width="656"
										align="center" background="imagenes\FondoBN.gif" border="1">
										<TR>
											<TD style="WIDTH: 283px; HEIGHT: 25px" vAlign="middle" align="left">
												<P align="right">&nbsp;
													<asp:label id="lblCodBCR" runat="server" Font-Size="8pt" Font-Names="Arial" Width="94px" Font-Bold="True"
														Height="14px">Código BCR  :</asp:label>&nbsp;
													<asp:label id="lblaCodBCR" runat="server" Font-Size="9pt" Font-Names="Arial" Width="64px" Font-Bold="True"></asp:label></P>
											</TD>
											<TD style="HEIGHT: 25px">&nbsp;
												<asp:label id="lblNormativa" runat="server" Font-Size="8pt" Font-Names="Arial" Width="64px"
													Font-Bold="True">Normativa:</asp:label>&nbsp;&nbsp;
												<asp:label id="lblaNormativa" runat="server" Font-Size="9pt" Font-Names="Arial" Width="64px"
													Font-Bold="True"></asp:label></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 283px; HEIGHT: 2px" vAlign="middle" align="left">
												<P align="right">&nbsp;
													<asp:label id="lblFuncionario" runat="server" Font-Size="8pt" Font-Names="Arial" Width="184px"
														Font-Bold="True" Height="14px">Funcionario Responsable</asp:label></P>
											</TD>
											<TD style="HEIGHT: 2px">&nbsp;&nbsp;
												<asp:label id="lblaFuncionario" runat="server" Font-Size="9pt" Font-Names="Arial" Width="304px"
													Font-Bold="True"></asp:label></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 283px" vAlign="middle" align="left">
												<P align="right">&nbsp;
													<asp:label id="lblPeriodo" runat="server" Font-Size="8pt" Font-Names="Arial" Width="184" Font-Bold="True"
														Height="14">Periodo   (Mes / Año)</asp:label></P>
											</TD>
											<TD>&nbsp;
												<asp:dropdownlist id="cmbMes" runat="server" Font-Size="8pt" Font-Names="Arial" Width="120px" AutoPostBack="True"></asp:dropdownlist>&nbsp;
												<asp:textbox id="txtAnno" runat="server" Font-Size="8pt" Font-Names="Arial" Width="48px" MaxLength="4"></asp:textbox>&nbsp;
												<asp:button id="cmdAceptaP" runat="server" Font-Size="8pt" Font-Bold="True" Text="Aceptar"></asp:button></TD>
										</TR>
									</TABLE>
								</DIV>
								<P></P>
								<asp:Panel id="Panel1" runat="server">
									<TABLE id="Table12" style="WIDTH: 683px; HEIGHT: 80px" cellSpacing="0" cellPadding="0"
										width="683" bgColor="#f5f5f5" border="1">
										<TR>
											<TD style="WIDTH: 60px; HEIGHT: 28px" vAlign="middle" align="left">
												<asp:label id="lblCCobro" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">C.Cobro</asp:label></TD>
											<TD style="WIDTH: 224px; HEIGHT: 28px">
												<asp:dropdownlist id="cmbConcepto" runat="server" Font-Size="7pt" Font-Names="Arial" Width="316px"
													Height="24px" AutoPostBack="True"></asp:dropdownlist></TD>
											<TD style="WIDTH: 91px; HEIGHT: 28px">
												<asp:label id="lblCanal" runat="server" Font-Size="8pt" Font-Names="Arial" Width="120px" Font-Bold="True">Canal</asp:label></TD>
											<TD style="HEIGHT: 28px">
												<asp:dropdownlist id="cmbCanal" runat="server" Font-Size="7pt" Font-Names="Arial" Width="323px"></asp:dropdownlist></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 60px; HEIGHT: 22px" vAlign="middle" align="left">
												<asp:label id="lblComision" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Comisión BCR</asp:label></TD>
											<TD style="WIDTH: 224px; HEIGHT: 22px">
												<asp:dropdownlist id="cmbComision" runat="server" Font-Size="7pt" Font-Names="Arial" Width="314px"
													AutoPostBack="True"></asp:dropdownlist></TD>
											<TD style="WIDTH: 91px; HEIGHT: 22px">
												<asp:label id="lblCliente" runat="server" Font-Size="8pt" Font-Names="Arial" Width="121px"
													Font-Bold="True">Cliente Asume Comis.</asp:label></TD>
											<TD style="HEIGHT: 22px">
												<asp:dropdownlist id="cmbCliente" runat="server" Font-Size="7pt" Font-Names="Arial" Width="322px"></asp:dropdownlist></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 60px; HEIGHT: 21px" vAlign="middle" align="left">
												<asp:label id="lblTarifaMN" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Tarifa MN</asp:label></TD>
											<TD style="WIDTH: 224px; HEIGHT: 21px">
												<asp:textbox id="txtTarifaMN" runat="server" Font-Size="7pt" Font-Names="Arial" Width="107px"
													ToolTip="Número de dispositivos, tarjetas y/o Clientes" MaxLength="7">0.00</asp:textbox>
												<asp:CompareValidator id="CompareValidator1" runat="server" Font-Size="8pt" Font-Bold="True" Type="Double"
													ValueToCompare="0" Operator="GreaterThanEqual" ErrorMessage="Debe ser numérico" ControlToValidate="txtTarifaMN"></asp:CompareValidator></TD>
											<TD style="WIDTH: 91px; HEIGHT: 21px">
												<asp:label id="lblTarifaME" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Tarifa ME</asp:label></TD>
											<TD style="HEIGHT: 21px">
												<asp:textbox id="txtTarifaME" runat="server" Font-Size="7pt" Font-Names="Arial" Width="94px"
													ToolTip="Número de dispositivos, tarjetas y/o Clientes" MaxLength="7">0.00</asp:textbox>
												<asp:CompareValidator id="CompareValidator2" runat="server" Font-Size="8pt" Font-Bold="True" Type="Double"
													ValueToCompare="0" Operator="GreaterThanEqual" ErrorMessage="Debe ser numérico" ControlToValidate="txtTarifaME"></asp:CompareValidator></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 60px" vAlign="middle" align="left">
												<asp:label id="lblObservaciones" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Observaciones</asp:label></TD>
											<TD colSpan="3">
												<asp:TextBox id="txtObservaciones" runat="server" Font-Size="8pt" Width="576px" ToolTip="Colocar toda aquella observación que se considere relevante"
													TextMode="MultiLine"></asp:TextBox>&nbsp;&nbsp;&nbsp;
											</TD>
										</TR>
									</TABLE>
								</asp:Panel>
								<asp:button id="cmdAgrega" runat="server" Font-Size="8pt" Font-Names="Arial" Width="69px" BorderStyle="Double"
									BackColor="White" ForeColor="Maroon" Text="Agrega" BorderColor="#400000"></asp:button>&nbsp;&nbsp;
								<asp:button id="cmdElimina" runat="server" Font-Size="8pt" Font-Names="Arial" Width="63px" BorderStyle="Double"
									BackColor="White" ForeColor="Maroon" Text="Elimina" BorderColor="#400000"></asp:button></DIV>
							<DIV>&nbsp;</DIV>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 1px; HEIGHT: 129px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 129px" align="center" colSpan="6"><asp:panel id="pnlGrilla" runat="server" Width="632px" Height="120px">
							<asp:datagrid id="dtgRegistro" runat="server" Font-Size="7pt" Font-Names="Arial" Width="856px"
								Height="85px" ToolTip="Campos Formato 1" BorderWidth="1px" BorderStyle="None" BackColor="White"
								BorderColor="#CCCCCC" CellPadding="3">
								<FooterStyle ForeColor="Black" BackColor="White"></FooterStyle>
								<SelectedItemStyle Font-Bold="True" ForeColor="Black" BackColor="#FFFFCC"></SelectedItemStyle>
								<ItemStyle ForeColor="Black"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#CE2229"></HeaderStyle>
								<PagerStyle HorizontalAlign="Left" ForeColor="Black" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 1px"></TD>
					<TD style="WIDTH: 37px"><cc2:msgbox id="MsgBox1" runat="server"></cc2:msgbox></TD>
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
