<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_formulario2.aspx.vb" Inherits="AHSB.w_formulario2" %>
<%@ Register TagPrefix="cc2" Namespace="MsgBox" Assembly="MsgBox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Formularios Ahorros</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript"> 
			var isGoodLink=false;
				window.onbeforeunload = function (e) {
				var message = "";
				
				e = e || window.event;
				if((window.event.clientX<0) || (window.event.clientY<0))
				{
				 isGoodLink=false;;
				 }
				 else
				 {
				  isGoodLink=true;
				 }
									
					
				if (!isGoodLink) {
				// For IE and Firefox
				if (e) {
					e.returnValue = message;
									
				}
				
				 //For Safari
				   return message;
				 
				}
				};
				function setGoodLink() {
				isGoodLink=true;
				}
		
		function bye() {
				if (!isGoodLink) {
				window.open('w_PaginaSesionCaducada.aspx');
				}
				}
		</script>
	</HEAD>
	<body leftMargin="0" onunload="bye()">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" style="WIDTH: 801px; HEIGHT: 680px" cellSpacing="1" cellPadding="1"
				width="801">
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
					<TD style="WIDTH: 94px; HEIGHT: 34px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 34px" align="center" colSpan="6"><asp:label id="lblTitulo" runat="server" Font-Size="14pt" Font-Names="Lucida Sans Unicode"
							Font-Bold="True" Width="864px">Transacciones con Instrumentos de Pago</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 235px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 235px" align="center" colSpan="6">
						<DIV align="center">
							<TABLE id="Table3" style="WIDTH: 314px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="314"
								align="left" border="0">
							</TABLE>
						</DIV>
						<DIV align="center"><asp:panel id="pnlDetalle" runat="server" Width="846px" Height="400px">
								<DIV>&nbsp;&nbsp;
									<TABLE id="Table17" style="WIDTH: 246px; HEIGHT: 42px" cellSpacing="1" cellPadding="1"
										width="246" align="center" border="0">
										<TR>
											<TD style="WIDTH: 72px">
												<asp:button id="cmdNuevo" runat="server" Font-Names="Arial" Font-Size="8pt" Width="60px" Font-Bold="True"
													Height="19px" Text="Nuevo" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" Visible="False"
													BorderWidth="1px" ToolTip="Ingresar un nuevo Evento de Riesgo"></asp:button></TD>
											<TD>
												<asp:button id="cmdModificar" runat="server" Font-Names="Arial" Font-Size="8pt" Width="60px"
													Font-Bold="True" Height="19px" Text="Modificar" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid"
													Visible="False" BorderWidth="1px" ToolTip="Modificar Evento "></asp:button>
												<asp:button id="cmdAceptar" runat="server" Font-Names="Arial" Font-Size="8pt" Width="60px" Font-Bold="True"
													Height="19px" Text="Aceptar" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid" BorderWidth="1px"
													ToolTip="Grabar cambios realizados"></asp:button></TD>
											<TD>
												<asp:button id="cmdEliminar" runat="server" Font-Names="Arial" Font-Size="8pt" Width="60px"
													Font-Bold="True" Height="19px" Text="Eliminar" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid"
													Visible="False" BorderWidth="1px" ToolTip="Eliminar Evento"></asp:button>
												<asp:button id="cmdCancelar" runat="server" Font-Names="Arial" Font-Size="8pt" Width="60px"
													Font-Bold="True" Height="19px" Text="Cancelar" ForeColor="#CE2229" BackColor="White" BorderStyle="Solid"
													Visible="False" BorderWidth="1px" ToolTip="Cancelar cambios realizados"></asp:button></TD>
										</TR>
									</TABLE>
									<P></P>
									<TABLE id="Table2" style="WIDTH: 686px; HEIGHT: 77px" cellSpacing="0" cellPadding="1" width="686"
										align="center" background="imagenes\FondoBN.gif" border="1">
										<TR>
											<TD style="WIDTH: 307px; HEIGHT: 25px" vAlign="middle" align="left">
												<P align="right">&nbsp;
													<asp:label id="lblCodBCR" runat="server" Font-Names="Arial" Font-Size="8pt" Width="94px" Font-Bold="True"
														Height="14px">Código BCR  :</asp:label>&nbsp;
													<asp:label id="lblaCodBCR" runat="server" Font-Names="Arial" Font-Size="9pt" Width="64px" Font-Bold="True"></asp:label></P>
											</TD>
											<TD style="HEIGHT: 25px">&nbsp;
												<asp:label id="lblNormativa" runat="server" Font-Names="Arial" Font-Size="8pt" Width="64px"
													Font-Bold="True">Normativa:</asp:label>&nbsp;&nbsp;
												<asp:label id="lblaNormativa" runat="server" Font-Names="Arial" Font-Size="9pt" Width="64px"
													Font-Bold="True"></asp:label></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 307px" vAlign="middle" align="left">
												<P align="right">&nbsp;
													<asp:label id="lblFuncionario" runat="server" Font-Names="Arial" Font-Size="8pt" Width="184px"
														Font-Bold="True" Height="14px">Funcionario Responsable</asp:label></P>
											</TD>
											<TD>&nbsp;&nbsp;
												<asp:label id="lblaFuncionario" runat="server" Font-Names="Arial" Font-Size="9pt" Width="304px"
													Font-Bold="True"></asp:label></TD>
										</TR>
										<TR>
											<TD style="WIDTH: 307px" vAlign="middle" align="left">
												<P align="right">&nbsp;
													<asp:label id="lblPeriodo" runat="server" Font-Names="Arial" Font-Size="8pt" Width="184" Font-Bold="True"
														Height="14">Periodo   (Mes / Año)</asp:label></P>
											</TD>
											<TD>
												<asp:dropdownlist id="cmbMes" runat="server" Font-Names="Arial" Font-Size="8pt" Width="120px" AutoPostBack="True"></asp:dropdownlist>&nbsp;
												<asp:textbox id="txtAnno" runat="server" Font-Names="Arial" Font-Size="8pt" Width="48px" MaxLength="4"></asp:textbox>
												<asp:RangeValidator id="RangeValidator1" runat="server" Font-Names="Arial" Font-Size="7pt" MaximumValue="2050"
													MinimumValue="2009" ControlToValidate="txtAnno" ErrorMessage="2009 - 2050"></asp:RangeValidator>&nbsp;
												<asp:button id="cmdAceptaP" runat="server" Font-Size="8pt" Font-Bold="True" Text="Aceptar"></asp:button></TD>
										</TR>
									</TABLE>
									<P></P>
									<asp:Panel id="Panel1" runat="server" Width="864px">
										<TABLE id="Table4" style="WIDTH: 710px; HEIGHT: 60px" borderColor="#993300" cellSpacing="0"
											cellPadding="0" width="710" align="center" bgColor="#ffffff" border="1">
											<TR>
												<TD style="WIDTH: 275px">
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
																<asp:textbox id="txtNInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="92px"
																	ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
															<TD>
																<asp:label id="lblVInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="55px"
																	Font-Bold="True" Font-Italic="True">Valor</asp:label></TD>
															<TD>
																<asp:textbox id="txtVInstPagoMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="113px"
																	ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
														</TR>
													</TABLE>
												</TD>
												<TD style="WIDTH: 131px">
													<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="300" align="center" border="0">
														<TR>
															<TD align="center" bgColor="gainsboro" colSpan="4">
																<asp:label id="lblME" runat="server" Font-Names="Arial" Font-Size="9pt" Width="144px" Font-Bold="True"
																	Font-Italic="True">Txns. Inst. Pago ME</asp:label></TD>
														</TR>
														<TR>
															<TD>
																<asp:label id="lblNInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="79px"
																	Font-Bold="True" Font-Italic="True">Número</asp:label></TD>
															<TD>
																<asp:textbox id="txtNInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="101px"
																	ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
															<TD>
																<asp:label id="lbVInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True"
																	Font-Italic="True">Valor</asp:label></TD>
															<TD>
																<asp:textbox id="txtVInstPagoME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="118px"
																	ToolTip="Número de dispositivos, tarjetas y/o Clientes" ReadOnly="True"></asp:textbox></TD>
														</TR>
													</TABLE>
												</TD>
											</TR>
										</TABLE>
										<TABLE id="Table12" style="WIDTH: 805px; HEIGHT: 143px" cellSpacing="0" cellPadding="0"
											width="805" bgColor="#f5f5f5" border="1">
											<TR>
												<TD style="WIDTH: 115px; HEIGHT: 28px" vAlign="middle" align="left">
													<asp:label id="lblInstPago" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True">Inst.Pago</asp:label></TD>
												<TD style="WIDTH: 262px; HEIGHT: 28px">
													<asp:dropdownlist id="cmbInstPago" runat="server" Font-Names="Arial" Font-Size="7pt" Width="308px"
														Height="24px" AutoPostBack="True"></asp:dropdownlist></TD>
												<TD style="WIDTH: 91px; HEIGHT: 28px">
													<asp:label id="lblTOperacion" runat="server" Font-Names="Arial" Font-Size="8pt" Width="120px"
														Font-Bold="True">Tipo de Transacción</asp:label></TD>
												<TD style="HEIGHT: 28px">
													<asp:dropdownlist id="cmbTipoTxn" runat="server" Font-Names="Arial" Font-Size="7pt" Width="278px"></asp:dropdownlist></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 115px; HEIGHT: 1px" vAlign="middle" align="left">
													<asp:label id="lblCanal" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True">Canal</asp:label></TD>
												<TD style="WIDTH: 262px; HEIGHT: 1px">
													<asp:dropdownlist id="cmbCanal" runat="server" Font-Names="Arial" Font-Size="7pt" Width="304px" AutoPostBack="True"></asp:dropdownlist></TD>
												<TD style="WIDTH: 91px; HEIGHT: 1px"></TD>
												<TD style="HEIGHT: 1px"></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 115px; HEIGHT: 32px" vAlign="middle" align="left">
													<asp:label id="lblNroOperaMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="121px"
														Font-Bold="True">Nro Operaciones MN</asp:label></TD>
												<TD style="WIDTH: 262px; HEIGHT: 32px">
													<asp:textbox id="txtNroOperaMN" runat="server" Font-Names="Arial" Font-Size="7pt" Width="128px"
														ToolTip="Número de Operaciones en Moneda Nacional" MaxLength="10">0</asp:textbox>
													<asp:CompareValidator id="CompareValidator1" runat="server" Font-Size="8pt" Font-Bold="True" ControlToValidate="txtNroOperaMN"
														ErrorMessage="Debe ser numérico" Operator="GreaterThanEqual" ValueToCompare="0" Type="Integer"></asp:CompareValidator></TD>
												<TD style="WIDTH: 91px; HEIGHT: 32px">
													<asp:label id="VOperacionesMN" runat="server" Font-Names="Arial" Font-Size="8pt" Width="121px"
														Font-Bold="True">Val. Operaciones MN</asp:label></TD>
												<TD style="HEIGHT: 32px">
													<asp:textbox id="txtVOperaMN" runat="server" Font-Names="Arial" Font-Size="7pt" Width="120px"
														ToolTip="Valor de Operaciones en Moneda Nacional" AutoPostBack="True" MaxLength="19">0</asp:textbox>
													<asp:CompareValidator id="CompareValidator3" runat="server" Font-Size="8pt" Font-Bold="True" ControlToValidate="txtVOperaMN"
														ErrorMessage="Debe ser numérico" Operator="GreaterThanEqual" ValueToCompare="0" Type="Double"></asp:CompareValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 115px; HEIGHT: 22px" vAlign="middle" align="left">
													<asp:label id="lblNroOperaME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="121px"
														Font-Bold="True">Nro Operaciones ME</asp:label></TD>
												<TD style="WIDTH: 262px; HEIGHT: 22px">
													<asp:textbox id="txtNroOperaME" runat="server" Font-Names="Arial" Font-Size="7pt" Width="128px"
														ToolTip="Número de Operaciones en Moneda Extranjera" MaxLength="10">0</asp:textbox>
													<asp:CompareValidator id="CompareValidator2" runat="server" Font-Size="8pt" Font-Bold="True" ControlToValidate="txtNroOperaME"
														ErrorMessage="Debe ser numérico" Operator="GreaterThanEqual" ValueToCompare="0" Type="Integer"></asp:CompareValidator></TD>
												<TD style="WIDTH: 91px; HEIGHT: 22px">
													<asp:label id="VOperacionesME" runat="server" Font-Names="Arial" Font-Size="8pt" Width="121px"
														Font-Bold="True">Val. Operaciones ME</asp:label></TD>
												<TD style="HEIGHT: 22px">
													<asp:textbox id="txtVOperaME" runat="server" Font-Names="Arial" Font-Size="7pt" Width="120px"
														ToolTip="Valor de Operaciones en Moneda Extranjera" MaxLength="19">0</asp:textbox>
													<asp:CompareValidator id="CompareValidator4" runat="server" Font-Size="8pt" Font-Bold="True" ControlToValidate="txtVOperaME"
														ErrorMessage="Debe ser numérico" Operator="GreaterThanEqual" ValueToCompare="0" Type="Double"></asp:CompareValidator></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 115px" vAlign="middle" align="left">
													<asp:label id="lblObservaciones" runat="server" Font-Names="Arial" Font-Size="8pt" Font-Bold="True">Observaciones</asp:label></TD>
												<TD colSpan="3">
													<asp:TextBox id="txtObservaciones" runat="server" Font-Size="8pt" Width="576px" ToolTip="Colocar toda aquella observación que se considere relevante"
														TextMode="MultiLine"></asp:TextBox>&nbsp;&nbsp;&nbsp;
												</TD>
											</TR>
										</TABLE>
									</asp:Panel>
									<P></P>
									<asp:button id="cmdAgrega" runat="server" Font-Names="Arial" Font-Size="8pt" Width="69px" Text="Agrega"
										ForeColor="Maroon" BackColor="White" BorderStyle="Double" BorderColor="#400000"></asp:button>&nbsp;&nbsp;
									<asp:button id="cmdElimina" runat="server" Font-Names="Arial" Font-Size="8pt" Width="63px" Text="Elimina"
										ForeColor="Maroon" BackColor="White" BorderStyle="Double" BorderColor="#400000"></asp:button></DIV>
								<DIV>&nbsp;</DIV>
							</asp:panel></DIV>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 145px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 145px" align="center" colSpan="6"><asp:panel id="pnlGrilla" runat="server" Width="632px" Height="80px">
							<asp:datagrid id="dtgRegistro" runat="server" Font-Names="Arial" Font-Size="7pt" Width="872px"
								Height="85px" BackColor="White" BorderStyle="None" BorderWidth="1px" ToolTip="Campos Formato 1"
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
