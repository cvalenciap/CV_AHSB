<%@ Page CodeBehind="w_PaginaSesionCaducada.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="AHSB.w_PaginaSesionCaducada" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML xmlns:asp>
	<HEAD>
		<title>Sistema Web Adm. de Riesgos - Pagina de Error</title>
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="ProgId" content="VisualStudio.HTML">
		<meta name="Originator" content="Microsoft Visual Studio .NET 7.1">
		<script language="javascript">
		var limit="0:05"   
		if (document.images)
		{	var parselimit=limit.split(":")
			parselimit=parselimit[0]*60+parselimit[1]*1
		}
		function begintimer()
		{	
			checkStatus();
			if (!document.images) 
				return
			if (parselimit==1)
				window.location="w_login.aspx"
			else
			{	parselimit-=1
				curmin=Math.floor(parselimit/60)
				cursec=parselimit%60
				if (curmin!=0)
					curtime=curmin+" minutes and "+cursec+" seconds left"
				else
					curtime="Redirecci?n Automatica en " + cursec + " segundo(s)"
					
				window.status=curtime
				setTimeout("begintimer()",1000)
			}
		}
		
        function checkStatus() 
        {
                page = self.location.href;
                if (page != top.location.href) 
                {
                        top.location.href = page;
                }
        }		 
		</script>
	</HEAD>
	<body onLoad="begintimer()">
		<P>
			<TABLE id="Table1" style="WIDTH: 513px; HEIGHT: 62px" cellSpacing="1" cellPadding="1" width="513"
				border="0">
				<TR>
					<TD style="WIDTH: 80px"><IMG style="WIDTH: 80px; HEIGHT: 46px" height="46" alt="" src="imagenes/isotipo.jpg"
							width="80"></TD>
					<TD>
						<asp:label id="Label9" Width="427px" Font-Names="Garamond" Font-Size="Medium" Font-Overline="True"
							Font-Underline="True" Font-Bold="True" runat="server">
							<STRONG><U><FONT face="Arial">La&nbsp;Sesi?n Actual ha Caducado...</FONT></U></STRONG></asp:label></TD>
				</TR>
			</TABLE>
		</P>
		<P>&nbsp;</P>
		<P>&nbsp;</P>
		<P align="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<FONT face="Arial">&nbsp;</FONT><STRONG><FONT face="Arial">Ingrese 
					al Aplicativo nuevamente.</FONT></STRONG></P>
		<P align="center"><STRONG><FONT face="Arial"><EM>Si la aplicaci?n esta inactiva,&nbsp;<STRONG><FONT face="Arial"><EM>por 
									seguridad, </EM></FONT></STRONG>la </EM></FONT></STRONG>
		</P>
		<P align="center"><STRONG><FONT face="Arial"><EM>sesi?n caduca </EM></FONT></STRONG>
			<STRONG><FONT face="Arial"><EM>despu?s </EM></FONT></STRONG><STRONG><FONT face="Arial"><EM>de 
						20 minutos.</EM></FONT></STRONG></P>
		<P align="center"><STRONG><FONT face="Arial">Por favor aguarde, en breve sera 
					redireccionado....</FONT></STRONG></P>
		<P align="center"><STRONG><FONT face="Arial"></FONT></STRONG>&nbsp;</P>
		<P align="center"><STRONG><FONT face="Arial"></FONT></STRONG>&nbsp;</P>
		<P align="center"><STRONG><FONT face="Arial"></FONT></STRONG>&nbsp;</P>
		<P align="center"><STRONG><FONT face="Arial">
					<asp:label id="lblMensajeError" runat="server" Font-Bold="True" Font-Size="8pt" Font-Names="Arial"></asp:label></FONT></STRONG></P>
		<P align="center"><STRONG><FONT face="Arial"></FONT></STRONG>&nbsp;</P>
		<P align="center"><STRONG><FONT face="Arial"></FONT></STRONG>&nbsp;</P>
		<P align="center">&nbsp;</P>
	</body>
</HTML>
