<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_formulario1.aspx.vb" Inherits="AHSB.w_formulario1" %>
<%@ Register TagPrefix="cc2" Namespace="MsgBox" Assembly="MsgBox" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Formatos Ahorros</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script type="text/javascript" > 
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
			<TABLE id="Table1" style="WIDTH: 672px; HEIGHT: 652px" cellSpacing="1" cellPadding="1"
				width="672">
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
					<TD style="WIDTH: 94px; HEIGHT: 12px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 12px" align="center" colSpan="6"><asp:label id="lblTitulo" runat="server" Font-Size="14pt" Font-Names="Lucida Sans Unicode"
							Width="763px" Font-Bold="True"> Cajeros y Tarjetas de Pago</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 205px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 205px" align="center" colSpan="6">
						<DIV align="center">
							<TABLE id="Table3" style="WIDTH: 314px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="314"
								align="left" border="0">
							</TABLE>
						</DIV>
						<DIV align="center"><asp:panel id="pnlDetalle" runat="server" Width="786px" Height="176px">
								<DIV>&nbsp;&nbsp;
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
									<P></P>
									<DIV align="center">
										<TABLE id="Table2" style="WIDTH: 531px; HEIGHT: 77px" cellSpacing="1" cellPadding="1" width="531"
											align="center" background="imagenes\FondoBN.gif" border="1">
											<TR>
												<TD style="WIDTH: 271px; HEIGHT: 25px" vAlign="middle" align="center">
													<P align="right">&nbsp;
														<asp:label id="lblCodBCR" runat="server" Font-Size="8pt" Font-Names="Arial" Width="94px" Font-Bold="True"
															Height="14px">Código BCR  :</asp:label>&nbsp;
														<asp:label id="lblaCodBCR" runat="server" Font-Size="9pt" Font-Names="Arial" Width="64px" Font-Bold="True"></asp:label></P>
												</TD>
												<TD style="HEIGHT: 25px" vAlign="middle" align="center">
													<P align="left">&nbsp;
														<asp:label id="lblNormativa" runat="server" Font-Size="8pt" Font-Names="Arial" Width="64px"
															Font-Bold="True">Normativa:</asp:label>&nbsp;&nbsp;
														<asp:label id="lblaNormativa" runat="server" Font-Size="9pt" Font-Names="Arial" Width="64px"
															Font-Bold="True"></asp:label></P>
												</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 271px" vAlign="middle" align="center">
													<P align="right">&nbsp;
														<asp:label id="lblFuncionario" runat="server" Font-Size="8pt" Font-Names="Arial" Width="184px"
															Font-Bold="True" Height="14px">Funcionario Responsable</asp:label></P>
												</TD>
												<TD>
													<P align="left">&nbsp;&nbsp;
														<asp:label id="lblaFuncionario" runat="server" Font-Size="9pt" Font-Names="Arial" Width="304px"
															Font-Bold="True"></asp:label></P>
												</TD>
											</TR>
											<TR>
												<TD style="WIDTH: 271px" vAlign="middle" align="center">
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
										<P></P>
									</DIV>
									<P></P>
									<asp:Panel id="Panel1" runat="server">
										<TABLE id="Table4" style="WIDTH: 575px; HEIGHT: 43px" borderColor="#993300" cellSpacing="0"
											cellPadding="0" width="575" bgColor="#ffffff" border="1">
											<TR>
												<TD style="WIDTH: 87px">
													<asp:label id="lblTCAutomaticos" runat="server" Font-Size="8pt" Font-Names="Arial" Width="80px"
														Font-Bold="True" Font-Italic="True">Cajeros Automáticos</asp:label></TD>
												<TD style="WIDTH: 96px">
													<asp:textbox id="txtTCAutomaticos" runat="server" Font-Size="8pt" Font-Names="Arial" Width="95px"
														ToolTip="Número Total de Cajeros Automáticos" ReadOnly="True"></asp:textbox></TD>
												<TD>
													<asp:label id="lblTCCorresponsal" runat="server" Font-Size="8pt" Font-Names="Arial" Width="115px"
														Font-Bold="True" Font-Italic="True">Cajeros Corresponsales</asp:label></TD>
												<TD>
													<asp:textbox id="txtTCCorresponsal" runat="server" Font-Size="8pt" Font-Names="Arial" Width="92px"
														ToolTip="Número Total de Cajeros Corresponsales" ReadOnly="True"></asp:textbox></TD>
												<TD style="WIDTH: 70px">
													<asp:label id="lblTPuntosCaja" runat="server" Font-Size="8pt" Font-Names="Arial" Width="56px"
														Font-Bold="True" Font-Italic="True">Puntos de Caja</asp:label></TD>
												<TD>
													<asp:textbox id="txtTPuntosCaja" runat="server" Font-Size="8pt" Font-Names="Arial" Width="90px"
														ToolTip="Número Total de Puntos de Caja" ReadOnly="True"></asp:textbox></TD>
												<TD>
													<asp:label id="lblTTarjetas" runat="server" Font-Size="8pt" Font-Names="Arial" Width="58px"
														Font-Bold="True" Font-Italic="True">Tarjetas</asp:label></TD>
												<TD>
													<asp:textbox id="txtTTarjetas" runat="server" Font-Size="8pt" Font-Names="Arial" Width="98px"
														ToolTip="Número Total de Tarjetas" ReadOnly="True"></asp:textbox></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 87px"></TD>
												<TD style="WIDTH: 96px">
													<asp:label id="lblTLCredito" runat="server" Font-Size="8pt" Font-Names="Arial" Width="80px"
														Font-Bold="True" Font-Italic="True">Lineas Crédito Paralelas</asp:label></TD>
												<TD>
													<asp:textbox id="txtTLCredito" runat="server" Font-Size="8pt" Font-Names="Arial" Width="92px"
														ToolTip="Número Total de Líneas de Crpedito Paralelas" ReadOnly="True"></asp:textbox></TD>
												<TD></TD>
												<TD style="WIDTH: 70px"></TD>
												<TD>
													<asp:label id="lblTClientes" runat="server" Font-Size="8pt" Font-Names="Arial" Width="80px"
														Font-Bold="True" Font-Italic="True">Nro.Clientes Banca Movil</asp:label></TD>
												<TD>
													<asp:textbox id="txtTClientes" runat="server" Font-Size="8pt" Font-Names="Arial" Width="92px"
														ToolTip="Número Total de Clientes Registrados en Banca Movil" ReadOnly="True"></asp:textbox></TD>
												<TD></TD>
											</TR>
										</TABLE>
										<TABLE id="Table12" style="WIDTH: 757px; HEIGHT: 103px" cellSpacing="0" cellPadding="0"
											width="757" bgColor="#f5f5f5" border="1">
											<TR>
												<TD style="WIDTH: 60px; HEIGHT: 28px" vAlign="middle" align="left">
													<asp:label id="lblOperacion" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Operación</asp:label></TD>
												<TD style="WIDTH: 243px; HEIGHT: 28px">
													<asp:dropdownlist id="cmbOperacion" runat="server" Font-Size="7pt" Font-Names="Arial" Width="307px"
														Height="18" AutoPostBack="True"></asp:dropdownlist></TD>
												<TD style="WIDTH: 91px; HEIGHT: 28px">
													<asp:label id="lblTOperacion" runat="server" Font-Size="8pt" Font-Names="Arial" Width="120px"
														Font-Bold="True">Tipo de Operación</asp:label></TD>
												<TD style="HEIGHT: 28px">
													<asp:dropdownlist id="cmbTOperacion" runat="server" Font-Size="7pt" Font-Names="Arial" Width="288px"></asp:dropdownlist></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 60px; HEIGHT: 23px" vAlign="middle" align="left">
													<asp:label id="lblEstado" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Estado</asp:label></TD>
												<TD style="WIDTH: 243px; HEIGHT: 23px">
													<asp:dropdownlist id="cmbEstado" runat="server" Font-Size="7pt" Font-Names="Arial" Width="304px" Height="18px"
														AutoPostBack="True"></asp:dropdownlist></TD>
												<TD style="WIDTH: 91px; HEIGHT: 23px">
													<asp:label id="lblNroOpera" runat="server" Font-Size="8pt" Font-Names="Arial" Width="121px"
														Font-Bold="True">Número Operaciones</asp:label></TD>
												<TD style="HEIGHT: 23px">
													<asp:textbox id="txtNroOpera" runat="server" Font-Size="7pt" Font-Names="Arial" Width="88px"
														ToolTip="Número de dispositivos, tarjetas y/o Clientes" MaxLength="10">0</asp:textbox>
													<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" Font-Size="8pt" Font-Bold="True" ControlToValidate="txtNroOpera"
														ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>&nbsp;
													<asp:CompareValidator id="CompareValidator1" runat="server" Font-Size="8pt" Font-Bold="True" ControlToValidate="txtNroOpera"
														ErrorMessage="Debe ser numérico" Type="Integer" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
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
							</asp:panel></DIV>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 94px; HEIGHT: 135px" align="center"></TD>
					<TD style="WIDTH: 532px; HEIGHT: 135px" align="center" colSpan="6"><asp:panel id="pnlGrilla" runat="server" Width="632px" Height="120px">
							<asp:datagrid id="dtgRegistro" runat="server" Font-Size="7pt" Font-Names="Arial" Width="816px"
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
