'*-------------------------------------------------------------------------
'* Banco de la Nación :  Sistema NOTAS DE CARGO/ABONO INTRANET - SINO                                 
'* Autor   : MIGUEL SAAVEDRA                                               
'* Archivo : Clase BNFunciones                                                  
'* Fecha de Creacion    : ABRIL 2007. 
'* Ultima Actualizacion : ABRIL 2007                                     
'*-------------------------------------------------------------------------
'Esta Clase contiene las Librerias necesarias para la aplicacion 
Imports System.Xml

Public Class BNFunciones
   Public Shared Function GetEncrypDesencryp(ByVal STRCadena As String, ByVal BlnValor As Boolean) As String
      Dim Cadena As String
      If BlnValor Then
         Cadena = Encryptor.EncryptTripleDES(STRCadena)
      Else
         Cadena = Encryptor.DecryptTripleDES(STRCadena)
      End If
      Return Cadena
   End Function

   Public Shared Function GetFecha() As String
      Return Year(Now()).ToString & Right("00" & Month(Now()), 2) & Right("00" & Day(Now()), 2)
   End Function

   Public Shared Function GetFechaYYYYMMDD(ByVal Fecha As String) As String
      Return Year(CDate(Fecha)).ToString & Right("00" & Month(CDate(Fecha)), 2) & Right("00" & Day(CDate(Fecha)), 2)
   End Function

   Public Shared Function GetHora() As String
      Return Right("00" & Hour(Now()), 2) & Right("00" & Minute(Now()), 2) & Right("00" & Second(Now()), 2)
   End Function

   Public Shared Function GetCodigoFormat8Dig(ByVal StrCodigo) As String
      Return Right("00000000" & StrCodigo, 8)
   End Function

   Public Shared Function GetCodigoFormat6Dig(ByVal StrCodigo) As String
      Return Right("000000" & StrCodigo, 6)
   End Function

   Public Shared Function GetCodigoFormat4Dig(ByVal StrCodigo) As String
      Return Right("0000" & StrCodigo, 4)
   End Function

   Public Shared Function GetCodigoFormat3Dig(ByVal StrCodigo) As String
      Return Right("000" & StrCodigo, 3)
   End Function

   Public Shared Function GetCodigoFormat2Dig(ByVal StrCodigo) As String
      Return Right("00" & StrCodigo, 2)
   End Function

   Public Shared Function GetAnos(ByVal AnoInicio As Integer, ByVal AnoFin As Integer) As DataTable
      Dim tblAno As DataTable
      Dim dtrAno As DataRow
      tblAno = New DataTable
      tblAno.Columns.Add(New DataColumn("Valor", GetType(String)))
      tblAno.Columns.Add(New DataColumn("Texto", GetType(String)))
      Dim i As Integer
      dtrAno = tblAno.NewRow()
      dtrAno(0) = "0000"
      dtrAno(1) = "<AÑO>"
      tblAno.Rows.Add(dtrAno)
      For i = AnoFin To AnoInicio Step -1
         dtrAno = tblAno.NewRow()
         dtrAno(0) = i.ToString
         dtrAno(1) = i.ToString
         tblAno.Rows.Add(dtrAno)
      Next
      Return tblAno
   End Function

   Public Shared Function GetQuincena() As DataTable
      Dim tblQuincena As DataTable
      Dim dtrQuincena As DataRow
      tblQuincena = New DataTable
      tblQuincena.Columns.Add(New DataColumn("Valor", GetType(String)))
      tblQuincena.Columns.Add(New DataColumn("Texto", GetType(String)))

      dtrQuincena = tblQuincena.NewRow()
      dtrQuincena(0) = "00"
      dtrQuincena(1) = "<QUINCENA>"
      tblQuincena.Rows.Add(dtrQuincena)

      dtrQuincena = tblQuincena.NewRow()
      dtrQuincena(0) = "01"
      dtrQuincena(1) = "1era Quincena"
      tblQuincena.Rows.Add(dtrQuincena)

      dtrQuincena = tblQuincena.NewRow()
      dtrQuincena(0) = "02"
      dtrQuincena(1) = "2da Quincena"
      tblQuincena.Rows.Add(dtrQuincena)

      Return tblQuincena
   End Function

   Public Shared Function GetSemanal() As DataTable
      Dim tblSemanal As DataTable
      Dim dtrSemanal As DataRow
      tblSemanal = New DataTable
      tblSemanal.Columns.Add(New DataColumn("Valor", GetType(String)))
      tblSemanal.Columns.Add(New DataColumn("Texto", GetType(String)))

      dtrSemanal = tblSemanal.NewRow()
      dtrSemanal(0) = "00"
      dtrSemanal(1) = "<SEMANA>"
      tblSemanal.Rows.Add(dtrSemanal)

      dtrSemanal = tblSemanal.NewRow()
      dtrSemanal(0) = "01"
      dtrSemanal(1) = "1ra Semana"
      tblSemanal.Rows.Add(dtrSemanal)

      dtrSemanal = tblSemanal.NewRow()
      dtrSemanal(0) = "02"
      dtrSemanal(1) = "2da Semana"
      tblSemanal.Rows.Add(dtrSemanal)

      dtrSemanal = tblSemanal.NewRow()
      dtrSemanal(0) = "03"
      dtrSemanal(1) = "3ra Semana"
      tblSemanal.Rows.Add(dtrSemanal)

      dtrSemanal = tblSemanal.NewRow()
      dtrSemanal(0) = "04"
      dtrSemanal(1) = "4ta Semana"
      tblSemanal.Rows.Add(dtrSemanal)

      Return tblSemanal
   End Function

   Public Shared Function GetFrecuencia() As DataTable
      Dim tblFrecuencia As DataTable
      Dim dtrFrecuencia As DataRow
      tblFrecuencia = New DataTable
      tblFrecuencia.Columns.Add(New DataColumn("Valor", GetType(String)))
      tblFrecuencia.Columns.Add(New DataColumn("Texto", GetType(String)))

      dtrFrecuencia = tblFrecuencia.NewRow()
      dtrFrecuencia(0) = "00"
      dtrFrecuencia(1) = "<FRECUENCIA>"
      tblFrecuencia.Rows.Add(dtrFrecuencia)

      dtrFrecuencia = tblFrecuencia.NewRow()
      dtrFrecuencia(0) = "01"
      dtrFrecuencia(1) = "Mensual"
      tblFrecuencia.Rows.Add(dtrFrecuencia)

      dtrFrecuencia = tblFrecuencia.NewRow()
      dtrFrecuencia(0) = "02"
      dtrFrecuencia(1) = "Quincenal"
      tblFrecuencia.Rows.Add(dtrFrecuencia)

      dtrFrecuencia = tblFrecuencia.NewRow()
      dtrFrecuencia(0) = "03"
      dtrFrecuencia(1) = "Semanal"
      tblFrecuencia.Rows.Add(dtrFrecuencia)

      dtrFrecuencia = tblFrecuencia.NewRow()
      dtrFrecuencia(0) = "04"
      dtrFrecuencia(1) = "Diario"
      tblFrecuencia.Rows.Add(dtrFrecuencia)

      Return tblFrecuencia
   End Function


   Public Shared Function GetMeses() As DataTable
      Dim tblMes As DataTable
      Dim dtrMes As DataRow
      tblMes = New DataTable
      tblMes.Columns.Add(New DataColumn("Valor", GetType(String)))
      tblMes.Columns.Add(New DataColumn("Texto", GetType(String)))

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "00"
      dtrMes(1) = "<MES>"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "01"
      dtrMes(1) = "Enero"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "02"
      dtrMes(1) = "Febrero"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "03"
      dtrMes(1) = "Marzo"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "04"
      dtrMes(1) = "Abril"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "05"
      dtrMes(1) = "Mayo"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "06"
      dtrMes(1) = "Junio"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "07"
      dtrMes(1) = "Julio"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "08"
      dtrMes(1) = "Agosto"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "09"
      dtrMes(1) = "Setiembre"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "10"
      dtrMes(1) = "Octubre"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "11"
      dtrMes(1) = "Noviembre"
      tblMes.Rows.Add(dtrMes)

      dtrMes = tblMes.NewRow()
      dtrMes(0) = "12"
      dtrMes(1) = "Diciembre"
      tblMes.Rows.Add(dtrMes)

      Return tblMes
   End Function

   Public Shared Function GetDias() As DataTable
      Dim tblDia As DataTable
      Dim dtrDia As DataRow
      tblDia = New DataTable
      tblDia.Columns.Add(New DataColumn("Valor", GetType(String)))
      tblDia.Columns.Add(New DataColumn("Texto", GetType(String)))
      Dim i As Integer
      dtrDia = tblDia.NewRow()
      dtrDia(0) = "00"
      dtrDia(1) = "<DIA>"
      tblDia.Rows.Add(dtrDia)
      For i = 1 To 9
         dtrDia = tblDia.NewRow()
         dtrDia(0) = "0" & i.ToString
         dtrDia(1) = "0" & i.ToString
         tblDia.Rows.Add(dtrDia)
      Next
      For i = 10 To 31
         dtrDia = tblDia.NewRow()
         dtrDia(0) = i.ToString
         dtrDia(1) = i.ToString
         tblDia.Rows.Add(dtrDia)
      Next
      Return tblDia
   End Function

   Public Shared Function SetFechaFormatoFecha(ByVal Fecha As String, Optional ByVal sChar As String = "/") As String
      Return Mid(Fecha, 7, 2) & sChar & Mid(Fecha, 5, 2) & sChar & Mid(Fecha, 1, 4)
   End Function

   Public Shared Function SetHoraFormatoHora(ByVal Fecha As String) As String
      Fecha = Right("0" & Fecha, 6)
      Return Mid(Fecha, 1, 2) & ":" & Mid(Fecha, 3, 2) & ":" & Mid(Fecha, 5, 2)
   End Function

   Public Shared Function FormatoYYYYMMDD(ByVal sFecha As String) As String
      'DD/MM/YYYY
      Dim dFecha As String
      If sFecha.Length = 10 Then
         dFecha = sFecha.Substring(6, 4) & sFecha.Substring(3, 2) & sFecha.Substring(0, 2)
      Else
         dFecha = ""
      End If

      Return dFecha
   End Function

   Public Shared Function SetPeriodoFormatoFecha(ByVal Periodo As String) As String
      Dim mes As String
      Dim ano As String
      mes = Mid(Periodo, 5, 2)
      ano = Mid(Periodo, 1, 4)
      Return SetMesFormatoNombre(mes) & "-" & ano
   End Function

   Public Shared Function SetMesFormatoNombre(ByVal Mes As String) As String
      Dim StrMes As String = ""
      Select Case Mes
         Case "01"
            StrMes = "Enero"
         Case "02"
            StrMes = "Febrero"
         Case "03"
            StrMes = "Marzo"
         Case "04"
            StrMes = "Abril"
         Case "05"
            StrMes = "Mayo"
         Case "06"
            StrMes = "Junio"
         Case "07"
            StrMes = "Julio"
         Case "08"
            StrMes = "Agosto"
         Case "09"
            StrMes = "Setiembre"
         Case "10"
            StrMes = "Octubre"
         Case "11"
            StrMes = "Noviembre"
         Case "12"
            StrMes = "Diciembre"
      End Select
      Return StrMes
   End Function


   Public Sub Dispose()
      GC.SuppressFinalize(Me)
   End Sub

End Class
