<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_consolidado2.aspx.vb" Inherits="AHSB.w_consolidado2" %>
<%@ Register TagPrefix="cc2" Namespace="MsgBox" Assembly="MsgBox" %>
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
			<TABLE id="Table1" style="WIDTH: 794px; HEIGHT: 400px" cellSpacing="1" cellPadding="1"
				width="794">
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 20px" align="center"></TD>
					<TD style="WIDTH: 45px; HEIGHT: 20px" align="center"><asp:linkbutton id="lnkSalir" runat="server" Font-Size="7pt" Font-Names="Arial">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 92px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 71px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 178px; HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 9px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 9px" align="center" colSpan="6"><asp:label id="lblTitulo" runat="server" Font-Size="14pt" Font-Names="Lucida Sans Unicode"
							Width="787px" Font-Bold="True"> CONSOLIDADO FORMATO 2</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 28px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 28px" align="center" colSpan="6">
						<DIV align="center">
							<TABLE id="Table3" style="WIDTH: 314px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="314"
								align="left" border="0">
							</TABLE>
						</DIV>
						<DIV align="center"><asp:panel id="pnlDetalle" runat="server" Width="785px" Height="72px">
								<DIV>&nbsp;&nbsp;
									<DIV align="center">
										<TABLE id="Table17" style="WIDTH: 240px; HEIGHT: 42px" cellSpacing="1" cellPadding="1"
											width="240" align="center" border="0">
											<TR>
												<TD align="center">
													<asp:button id="cmdAceptar" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
														Width="157px" Height="19px" ToolTip="Generar Archivo texto para remitir al BCR" BorderWidth="1px"
														BorderStyle="Solid" BackColor="White" ForeColor="#CE2229" Text="Generar Texto"></asp:button></TD>
											</TR>
										</TABLE>
									</DIV>
									<TABLE id="Table2" style="WIDTH: 531px; HEIGHT: 77px" cellSpacing="1" cellPadding="1" width="531"
										align="center" background="imagenes\FondoBN.gif" border="1">
										<TR>
											<TD style="WIDTH: 271px; HEIGHT: 25px" vAlign="middle" align="center">
												<P align="right">&nbsp;
													<asp:label id="lblCodBCR" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
														Width="94px" Height="14px">Código BCR  :</asp:label>&nbsp;
													<asp:label id="lblaCodBCR" runat="server" Font-Names="Arial" Font-Size="9pt" Font-Bold="True"
														Width="64px"></asp:label></P>
											</TD>
											<TD style="HEIGHT: 25px" vAlign="middle" align="center">
												<P align="left">&nbsp;
													<asp:label id="lblNormativa" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
														Width="64px">Normativa:</asp:label>&nbsp;&nbsp;
													<asp:label id="lblaNormativa" runat="server" Font-Names="Arial" Font-Size="9pt" Font-Bold="True"
														Width="64px"></asp:label></P>
											</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 271px" vAlign="middle" align="center">
												<P align="right">&nbsp;
													<asp:label id="lblFuncionario" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
														Width="184px" Height="14px">Funcionario Responsable</asp:label></P>
											</TD>
											<TD>
												<P align="left">&nbsp;&nbsp;
													<asp:label id="lblaFuncionario" runat="server" Font-Names="Arial" Font-Size="9pt" Font-Bold="True"
														Width="304px"></asp:label></P>
											</TD>
										</TR>
										<TR>
											<TD style="WIDTH: 271px" vAlign="middle" align="center">
												<P align="right">&nbsp;
													<asp:label id="lblPeriodo" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
														Width="184" Height="14">Periodo   (Mes / Año)</asp:label></P>
											</TD>
											<TD>&nbsp;
												<asp:dropdownlist id="cmbMes" runat="server" Font-Names="Arial" Font-Size="8pt" Width="120px" AutoPostBack="True"></asp:dropdownlist>&nbsp;
												<asp:textbox id="txtAnno" runat="server" Font-Names="Arial" Font-Size="8pt" Width="48px" MaxLength="4"></asp:textbox>&nbsp;
												<asp:button id="cmdAceptaP" runat="server" Font-Size="8pt" Font-Bold="True" Text="Aceptar"></asp:button></TD>
										</TR>
									</TABLE>
									<TABLE id="Table4" style="WIDTH: 762px; HEIGHT: 60px" borderColor="#993300" cellSpacing="0"
										cellPadding="0" width="762" align="center" bgColor="#ffffff" border="1">
										<TR>
											<TD style="WIDTH: 133px">
												<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="300" align="center" border="0">
													<TR>
														<TD align="center" bgColor="gainsboro" colSpan="4">
															<asp:label id="lblMN" runat="server" Font-Names="Arial" Font-Size="9pt" Font-Bold="True" Font-Italic="True">Txns.  Inst.Pago MN</asp:label></TD>
													</TR>
													<TR>
														<TD>
															<asp:label id="lblNInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
																Font-Italic="True">Número</asp:label></TD>
														<TD>
															<asp:textbox id="txtNInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="120px"
																ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
														<TD>
															<asp:label id="lblVInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
																Width="71px" Font-Italic="True">Valor</asp:label></TD>
														<TD>
															<asp:textbox id="txtVInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="128px"
																ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
													</TR>
												</TABLE>
											</TD>
											<TD style="WIDTH: 131px">
												<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="300" align="center" border="0">
													<TR>
														<TD align="center" bgColor="gainsboro" colSpan="4">
															<asp:label id="lblME" runat="server" Font-Names="Arial" Font-Size="9pt" Font-Bold="True" Width="144px"
																Font-Italic="True">Txns. Inst. Pago ME</asp:label></TD>
													</TR>
													<TR>
														<TD>
															<asp:label id="lblNInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
																Width="71px" Font-Italic="True">Número</asp:label></TD>
														<TD>
															<asp:textbox id="txtNInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="108px"
																ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
														<TD>
															<asp:label id="lbVInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
																Font-Italic="True">Valor</asp:label></TD>
														<TD>
															<asp:textbox id="txtVInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="126px"
																ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
													</TR>
												</TABLE>
											</TD>
										</TR>
									</TABLE>
								</DIV>
								<DIV>&nbsp;</DIV>
							</asp:panel></DIV>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 135px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 135px" align="center" colSpan="6"><asp:panel id="pnlGrilla" runat="server" Width="632px" Height="120px">
							<asp:datagrid id="dtgRegistro" runat="server" Font-Names="Arial" Font-Size="7pt" Width="776px"
								Height="80px" ToolTip="Campos Formato 1" BorderWidth="1px" BorderStyle="None" BackColor="White"
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
					<TD style="WIDTH: 94px; HEIGHT: 135px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 135px" align="center" colSpan="6"><asp:panel id="Panel1" runat="server">
							<asp:Label id="lblOficina" runat="server" Font-Names="Lucida Sans Unicode" Font-Size="9pt"
								Font-Bold="True">DETALLE POR OFICINAS</asp:Label>
							<asp:datagrid id="dtgDetalle" runat="server" Font-Names="Arial" Font-Size="7pt" Width="776px"
								Height="80px" ToolTip="Campos Formato 1" BorderWidth="1px" BorderStyle="None" BackColor="LightGray"
								BorderColor="#C00000" CellPadding="3" Visible="False">
								<FooterStyle ForeColor="Black" BackColor="White"></FooterStyle>
								<SelectedItemStyle Font-Bold="True" ForeColor="Black" BackColor="#FFFFCC"></SelectedItemStyle>
								<ItemStyle ForeColor="Black"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#CE2229"></HeaderStyle>
								<PagerStyle HorizontalAlign="Left" ForeColor="Black" BackColor="White" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
						</asp:panel></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px"></TD>
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
