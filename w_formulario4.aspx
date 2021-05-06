<%@ Register TagPrefix="cc2" Namespace="MsgBox" Assembly="MsgBox" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="w_formulario4.aspx.vb" Inherits="AHSB.w_formulario4" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Formatos Ahorros</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
			<script type="text/javascript" >
			    var isGoodLink = false;
			    window.onbeforeunload = function (e) {
			        var message = "";

			        e = e || window.event;
			        if ((window.event.clientX < 0) || (window.event.clientY < 0)) {
			            isGoodLink = false;;
			        }
			        else {
			            isGoodLink = true;
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
			        isGoodLink = true;
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
			<TABLE id="Table1" style="WIDTH: 856px; HEIGHT: 736px" cellSpacing="1" cellPadding="1"
				width="856">
				<TR>
					<TD style="WIDTH: 45px; HEIGHT: 20px" align="center"><asp:linkbutton id="lnkSalir" runat="server" Font-Names="Arial" Font-Size="7pt">Salir</asp:linkbutton></TD>
					<TD style="WIDTH: 92px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 71px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 73px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 48px; HEIGHT: 20px"></TD>
					<TD style="WIDTH: 178px; HEIGHT: 20px"></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 5px" align="center" colSpan="6"><asp:label id="lblTitulo" runat="server" Font-Names="Lucida Sans Unicode" Font-Size="14pt"
							Font-Bold="True" Width="816px">Comisiones por Transferencias CCE</asp:label></TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 201px" align="center" colSpan="6">
						<DIV align="center">
							<TABLE id="Table3" style="WIDTH: 314px; HEIGHT: 24px" cellSpacing="1" cellPadding="1" width="314"
								align="left" border="0">
							</TABLE>
						</DIV>
						<DIV align="center"><asp:panel id="pnlDetalle" runat="server" Width="818px" Height="133px">
								<DIV>
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
										<TABLE id="Table2" style="WIDTH: 562px; HEIGHT: 77px" cellSpacing="0" cellPadding="1" width="562"
											align="center" background="imagenes\FondoBN.gif" border="1">
											<TR>
												<TD style="WIDTH: 271px; HEIGHT: 25px" vAlign="middle" align="left">
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
												<TD style="WIDTH: 271px" vAlign="middle" align="left">
													<P align="right">&nbsp;
														<asp:label id="lblFuncionario" runat="server" Font-Size="8pt" Font-Names="Arial" Width="184px"
															Font-Bold="True" Height="14px">Funcionario Responsable</asp:label></P>
												</TD>
												<TD>&nbsp;&nbsp;
													<asp:label id="lblaFuncionario" runat="server" Font-Size="9pt" Font-Names="Arial" Width="304px"
														Font-Bold="True"></asp:label></TD>
											</TR>
											<TR>
												<TD style="WIDTH: 271px" vAlign="middle" align="left">
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
										<asp:Panel id="Panel1" runat="server" Height="255px">
											<TABLE id="Table12" style="WIDTH: 776px; HEIGHT: 164px" cellSpacing="0" cellPadding="0"
												width="776" bgColor="#f5f5f5" border="1">
												<TR>
													<TD style="WIDTH: 111px; HEIGHT: 28px" vAlign="middle" align="left">
														<asp:label id="lblTCliente" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">T.Cliente</asp:label></TD>
													<TD style="WIDTH: 251px; HEIGHT: 28px">
														<asp:dropdownlist id="cmbTCliente" runat="server" Font-Size="7pt" Font-Names="Arial" Width="327px"
															Height="24px" AutoPostBack="True"></asp:dropdownlist></TD>
													<TD style="WIDTH: 91px; HEIGHT: 28px">
														<asp:label id="lblMoneda" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Moneda</asp:label></TD>
													<TD style="HEIGHT: 28px">
														<asp:dropdownlist id="cmbMoneda" runat="server" Font-Size="7pt" Font-Names="Arial" Width="313px" AutoPostBack="True"></asp:dropdownlist></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 111px; HEIGHT: 22px" vAlign="middle" align="left">
														<asp:label id="lblOperacion" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Operación</asp:label></TD>
													<TD style="WIDTH: 251px; HEIGHT: 22px">
														<asp:dropdownlist id="cmbOperacion" runat="server" Font-Size="7pt" Font-Names="Arial" Width="327px"
															Height="24px" AutoPostBack="True"></asp:dropdownlist></TD>
													<TD style="WIDTH: 91px; HEIGHT: 22px">
														<asp:label id="lblCCobro" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">C.Cobro</asp:label></TD>
													<TD style="HEIGHT: 22px">
														<asp:dropdownlist id="cmbConcepto" runat="server" Font-Size="7pt" Font-Names="Arial" Width="313px"
															AutoPostBack="True"></asp:dropdownlist></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 111px; HEIGHT: 30px" vAlign="middle" align="left">
														<asp:label id="lblPlaza" runat="server" Font-Size="8pt" Font-Names="Arial" Width="121px" Font-Bold="True">Plaza</asp:label></TD>
													<TD style="WIDTH: 251px; HEIGHT: 30px">
														<asp:dropdownlist id="cmbPlaza" runat="server" Font-Size="7pt" Font-Names="Arial" Width="330px"></asp:dropdownlist></TD>
													<TD style="WIDTH: 91px; HEIGHT: 30px">
														<asp:label id="lblCliente" runat="server" Font-Size="8pt" Font-Names="Arial" Width="121px"
															Font-Bold="True">Cliente Asume Comis.</asp:label></TD>
													<TD style="HEIGHT: 30px">
														<asp:dropdownlist id="cmbCliente" runat="server" Font-Size="7pt" Font-Names="Arial" Width="312px"></asp:dropdownlist></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 60px; HEIGHT: 156px" vAlign="middle" align="left" colSpan="5">&nbsp;&nbsp;&nbsp;
														<TABLE id="Table4" style="WIDTH: 886px; HEIGHT: 128px" cellSpacing="1" cellPadding="1"
															width="886" border="1">
															<TR>
																<TD style="WIDTH: 64px">
																	<asp:label id="Label1" runat="server" Font-Size="8pt" Font-Names="Arial" Width="117px" Font-Bold="True">Canal Ventanilla</asp:label></TD>
																<TD style="WIDTH: 54px">
																	<asp:label id="lblMontoMin" runat="server" Font-Size="8pt" Font-Names="Arial" Width="42px"
																		Font-Bold="True">M.Mín.</asp:label></TD>
																<TD style="WIDTH: 93px">
																	<asp:textbox id="txtMontoMinV" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Mínimo de Comisión - Ventanilla">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator4" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtMontoMinV" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="lblMontoMax" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">M.Máx</asp:label></TD>
																<TD style="WIDTH: 103px">
																	<asp:textbox id="txtMontoMaxV" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Máximo de Comisión - Ventanilla">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator5" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> Min"
																		ControlToValidate="txtMontoMaxV" Type="Double" ValueToCompare=" " Operator="GreaterThanEqual" ControlToCompare="txtMontoMinV"></asp:CompareValidator></TD>
																<TD style="WIDTH: 33px">
																	<asp:label id="lblTasa" runat="server" Font-Size="8pt" Font-Names="Arial" Width="18px" Font-Bold="True">Tasa</asp:label></TD>
																<TD style="WIDTH: 97px">
																	<asp:textbox id="txtTasaV" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Tasa de Comisión - Ventanilla">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator9" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtTasaV" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="lblComisV" runat="server" Font-Size="8pt" Font-Names="Arial" Width="4px" Font-Bold="True">Com.Fija</asp:label></TD>
																<TD>
																	<asp:textbox id="txtComisV" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Comisión Fija - Ventanilla">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator13" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtComisV" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 64px">
																	<asp:label id="Label2" runat="server" Font-Size="8pt" Font-Names="Arial" Width="106px" Font-Bold="True">Canal Cajeros Aut.</asp:label></TD>
																<TD style="WIDTH: 54px">
																	<asp:label id="Label3" runat="server" Font-Size="8pt" Font-Names="Arial" Width="42px" Font-Bold="True">M.Mín.</asp:label></TD>
																<TD style="WIDTH: 93px">
																	<asp:textbox id="txtMontoMinCA" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Mínimo de Comisión - Cajeros Automáticos">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator1" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtMontoMinCA" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="Label4" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">M.Máx</asp:label></TD>
																<TD style="WIDTH: 103px">
																	<asp:textbox id="txtMontoMaxCA" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Máximo de Comisión - Cajeros Atumáticos">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator6" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> Min"
																		ControlToValidate="txtMontoMaxCA" Type="Double" ValueToCompare=" " Operator="GreaterThanEqual" ControlToCompare="txtMontoMinCA"></asp:CompareValidator></TD>
																<TD style="WIDTH: 33px">
																	<asp:label id="Label5" runat="server" Font-Size="8pt" Font-Names="Arial" Width="18px" Font-Bold="True">Tasa</asp:label></TD>
																<TD style="WIDTH: 97px">
																	<asp:textbox id="txtTasaCA" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Tasa de Comisión - Cajeros Automáticos">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator10" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtTasaCA" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="Label6" runat="server" Font-Size="8pt" Font-Names="Arial" Width="4px" Font-Bold="True">Com.Fija</asp:label></TD>
																<TD>
																	<asp:textbox id="txtComisCA" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Comisión Fija - Cajeros Automáticos">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator14" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtComisCA" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 64px">
																	<asp:label id="Label7" runat="server" Font-Size="8pt" Font-Names="Arial" Width="81px" Font-Bold="True">Canal Internet</asp:label></TD>
																<TD style="WIDTH: 54px">
																	<asp:label id="Label8" runat="server" Font-Size="8pt" Font-Names="Arial" Width="42px" Font-Bold="True">M.Mín.</asp:label></TD>
																<TD style="WIDTH: 93px">
																	<asp:textbox id="txtMontoMinI" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Mínimo de Comisión - Internet">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator2" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtMontoMinI" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="Label9" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">M.Máx</asp:label></TD>
																<TD style="WIDTH: 103px">
																	<asp:textbox id="txtMontoMaxI" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Máximo de Comisión - Internet">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator7" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> Min"
																		ControlToValidate="txtMontoMaxI" Type="Double" ValueToCompare=" " Operator="GreaterThanEqual" ControlToCompare="txtMontoMinI"></asp:CompareValidator></TD>
																<TD style="WIDTH: 33px">
																	<asp:label id="Label10" runat="server" Font-Size="8pt" Font-Names="Arial" Width="18px" Font-Bold="True">Tasa</asp:label></TD>
																<TD style="WIDTH: 97px">
																	<asp:textbox id="txtTasaI" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Tasa de Comisión - Internet">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator11" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtTasaI" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="Label11" runat="server" Font-Size="8pt" Font-Names="Arial" Width="4px" Font-Bold="True">Com.Fija</asp:label></TD>
																<TD>
																	<asp:textbox id="txtComisI" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Comisión Fija - Internet">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator15" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtComisI" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 64px">
																	<asp:label id="Label12" runat="server" Font-Size="8pt" Font-Names="Arial" Width="80px" Font-Bold="True">Otros Canales</asp:label></TD>
																<TD style="WIDTH: 54px">
																	<asp:label id="Label13" runat="server" Font-Size="8pt" Font-Names="Arial" Width="42px" Font-Bold="True">M.Mín.</asp:label></TD>
																<TD style="WIDTH: 93px">
																	<asp:textbox id="txtMontoMinO" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Mínimo de Comisión - Otros Canales">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator3" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtMontoMinO" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="Label14" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">M.Máx</asp:label></TD>
																<TD style="WIDTH: 103px">
																	<asp:textbox id="txtMontoMaxO" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px"
																		ToolTip="Rango Máximo de Comisión - Otros Canales">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator8" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> Min"
																		ControlToValidate="txtMontoMaxO" Type="Double" ValueToCompare=" " Operator="GreaterThanEqual" ControlToCompare="txtMontoMinO"></asp:CompareValidator></TD>
																<TD style="WIDTH: 33px">
																	<asp:label id="Label15" runat="server" Font-Size="8pt" Font-Names="Arial" Width="18px" Font-Bold="True">Tasa</asp:label></TD>
																<TD style="WIDTH: 97px">
																	<asp:textbox id="txtTasaO" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Tasa de Comisión - Otros Canales">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator12" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtTasaO" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
																<TD>
																	<asp:label id="Label16" runat="server" Font-Size="8pt" Font-Names="Arial" Width="4px" Font-Bold="True">Com.Fija</asp:label></TD>
																<TD>
																	<asp:textbox id="txtComisO" runat="server" Font-Size="7pt" Font-Names="Arial" Width="64px" ToolTip="Comisión Fija - Otros Canales">0.000</asp:textbox>
																	<asp:CompareValidator id="CompareValidator16" runat="server" Font-Size="8pt" Font-Bold="True" ErrorMessage="> 0"
																		ControlToValidate="txtComisO" Type="Double" ValueToCompare="0" Operator="GreaterThanEqual"></asp:CompareValidator></TD>
															</TR>
														</TABLE>
													</TD>
												</TR>
												<TR>
													<TD style="WIDTH: 111px" vAlign="middle" align="left">
														<asp:label id="lblObservaciones" runat="server" Font-Size="8pt" Font-Names="Arial" Font-Bold="True">Observaciones</asp:label></TD>
													<TD colSpan="3">
														<asp:TextBox id="txtObservaciones" runat="server" Font-Size="8pt" Width="576px" ToolTip="Colocar toda aquella observación que se considere relevante"
															TextMode="MultiLine"></asp:TextBox>&nbsp;&nbsp;&nbsp;
														<asp:Label id="lblIndx" runat="server" Font-Size="6pt" Visible="False"></asp:Label></TD>
												</TR>
											</TABLE>
										</asp:Panel>
										<asp:button id="cmdAgrega" runat="server" Font-Size="8pt" Font-Names="Arial" Width="69px" BorderStyle="Double"
											BackColor="White" ForeColor="Maroon" Text="Agrega" BorderColor="#400000"></asp:button>&nbsp;&nbsp;
										<asp:button id="cmdElimina" runat="server" Font-Size="8pt" Font-Names="Arial" Width="63px" BorderStyle="Double"
											BackColor="White" ForeColor="Maroon" Text="Elimina" BorderColor="#400000"></asp:button></DIV>
								</DIV>
								<DIV>&nbsp;</DIV>
							</asp:panel></DIV>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 532px; HEIGHT: 135px" align="center" colSpan="6"><asp:panel id="pnlGrilla" runat="server" Width="632px" Height="120px">
							<asp:datagrid id="dtgRegistro" runat="server" Font-Size="7pt" Font-Names="Arial" Width="896px"
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
