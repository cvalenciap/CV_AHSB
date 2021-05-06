Imports DBConexion_SQL
Imports System.IO


Imports System.Data.SqlClient

Public Class BNOperacion

   Inherits DBConexion
   '== Constantes ============================================================
  

#Region "   * * * Creación del Arbol de Navegacion * * *   "

   Public Function Arbol_Navegacion(ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "") As DataTable
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_ArbolNavegacion", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@CodTrabajador", CodUsuario)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "ArbolNavegacion")

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet.Tables("ArbolNavegacion")

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try

   End Function

#End Region
#Region "   * * * Formato 1 * * *   "

   Public Function Get_FormFormato1(Optional ByRef ErrMsg As String = "") As DataSet
      Try
         AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormFormato1", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "FormFormato1")

         Me.dbDataSet.Tables(0).TableName = "Operacion"
         Me.dbDataSet.Tables(1).TableName = "TOperacion"
         Me.dbDataSet.Tables(2).TableName = "Estado"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Get_InfoFormato1(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)
         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_InfoFormato1", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato1")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Grabar_NuevoForm1Cabecera(ByVal Periodo As String, ByVal CodBCR As String, ByVal Normativa As String, ByVal nReporte As String, _
                                              ByVal aFuncionario As String, ByVal qTCAutomatico As Integer, ByVal qTCCorresponsal As Integer, _
                                              ByVal qTPuntos As Integer, ByVal qTTarjetas As Integer, _
                                              ByVal qTLCredito As Integer, ByVal qTClientes As Integer, _
                                              Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_RegistroForm1", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@CodBCR", CodBCR)
         dbCommand.Parameters.Add("@Normativa", Normativa)
         dbCommand.Parameters.Add("@Funcionario", aFuncionario)
         dbCommand.Parameters.Add("@nReporte", nReporte)
         dbCommand.Parameters.Add("@qCAutoma", qTCAutomatico)
         dbCommand.Parameters.Add("@qCCorresp", qTCCorresponsal)
         dbCommand.Parameters.Add("@qPuntos", qTPuntos)
         dbCommand.Parameters.Add("@qTarjetas", qTTarjetas)
         dbCommand.Parameters.Add("@qTLCredito", qTLCredito)
         dbCommand.Parameters.Add("@qTClientes", qTClientes)



         dbCommand.ExecuteNonQuery()
         'Grabar_NuevoForm1Cabecera = dbCommand.ExecuteScalar()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Modificar_Form1Cabecera(ByVal Periodo As String, ByVal nReporte As String, _
                                                 ByVal qTCAutomatico As Integer, ByVal qTCCorresponsal As Integer, _
                                                 ByVal qTPuntos As Integer, ByVal qTTarjetas As Integer, _
                                                 ByVal qTLCredito As Integer, ByVal qTClientes As Integer, _
                                                  Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_RegistroForm1", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@nReporte", nReporte)
         dbCommand.Parameters.Add("@qCAutoma", qTCAutomatico)
         dbCommand.Parameters.Add("@qCCorresp", qTCCorresponsal)
         dbCommand.Parameters.Add("@qPuntos", qTPuntos)
         dbCommand.Parameters.Add("@qTarjetas", qTTarjetas)
         dbCommand.Parameters.Add("@qTLCredito", qTLCredito)
         dbCommand.Parameters.Add("@qTClientes", qTClientes)


         dbCommand.ExecuteNonQuery()
         'Grabar_NuevoForm1Cabecera = dbCommand.ExecuteScalar()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   'Public Sub Modificar_FormRegistro(ByVal Periodo As Integer, ByVal cOperacion As Integer, ByVal TOperacion As Integer, _
   '                                  ByVal cEstado As Integer, ByVal sOperaciones As Decimal, ByVal Observaciones As String, ByVal IDUsuario As String, _
   '                                 Optional ByRef ErrMsg As String = "")



   '   Try
   '      Me.AbrirConexion(ErrMsg)

   '      dbCommand = New SqlCommand("BNSP_Modificar_RegistroForm1", dbConnection)
   '      dbCommand.CommandType = CommandType.StoredProcedure
   '      dbCommand.Parameters.Add("@cOperacion", cOperacion)
   '      dbCommand.Parameters.Add("@TOperacion", TOperacion)
   '      dbCommand.Parameters.Add("@cEstado", cEstado)
   '      dbCommand.Parameters.Add("@sOperaciones", sOperaciones)
   '      dbCommand.Parameters.Add("@Observaciones", Observaciones)
   '      dbCommand.Parameters.Add("@UsuActualiza", IDUsuario)

   '      dbCommand.ExecuteNonQuery()
   '      Me.CerrarConexion(ErrMsg)

   '   Catch ex As Exception
   '      ErrMsg = ex.Message
   '   End Try
   'End Sub

   Public Sub Eliminar_Form1Registro(ByVal Periodo As String, ByVal Accion As Integer, ByVal IDUsuario As String, Optional ByRef ErrMsg As String = "")
      ' Elimina detalle para reemplazarlo
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Eliminacion_DetalleForm1", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@Accion", Accion)
         dbCommand.Parameters.Add("@UsuActualiza", IDUsuario)


         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Insertar_DetalleForm1(ByVal Periodo As String, ByVal cOperacion As Integer, ByVal TOperacion As Integer, ByVal cEstado As Integer, _
                                             ByVal sOperaciones As Integer, ByVal Observaciones As String, ByVal IDUsuario As String, _
                                              ByVal cOficina As String, ByVal FechaCrea As Date, Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_DetalleForm1", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@cOperacion", cOperacion)
         dbCommand.Parameters.Add("@TOperacion", TOperacion)
         dbCommand.Parameters.Add("@cEstado", cEstado)
         dbCommand.Parameters.Add("@sOperaciones", sOperaciones)
         dbCommand.Parameters.Add("@Observaciones", Observaciones)
         dbCommand.Parameters.Add("@UsuCreacion", IDUsuario)
         dbCommand.Parameters.Add("@cOficina", cOficina)
         dbCommand.Parameters.Add("@FechaCrea", FechaCrea)
         'Insertar_DetalleForm1 = dbCommand.ExecuteScalar()
         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function


   Public Sub Eliminar_DetalleForm1xRegistro(ByVal IDRegistro As Integer, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Eliminar_DetalleForm1xRegistro", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@IDRegistro", IDRegistro)

         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub


#End Region
#Region "   * * * Formato 2 * * *   "

   Public Function Get_FormFormato2(Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormFormato2", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "FormFormato2")

         Me.dbDataSet.Tables(0).TableName = "InstPago"
         Me.dbDataSet.Tables(1).TableName = "TipoTxn"
         Me.dbDataSet.Tables(2).TableName = "Canal"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Get_InfoFormato2(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_InfoFormato2", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato2")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Grabar_NuevoForm2Cabecera(ByVal Periodo As String, ByVal CodBCR As String, ByVal Normativa As String, _
                                              ByVal nReporte As Integer, ByVal aFuncionario As String, ByVal qNInstMN As Integer, _
                                              ByVal qNInstME As Integer, ByVal sNInstMN As Double, ByVal sNInstME As Double, _
                                               Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_RegistroForm2", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@CodBCR", CodBCR)
         dbCommand.Parameters.Add("@Normativa", Normativa)
         dbCommand.Parameters.Add("@Funcionario", aFuncionario)
         dbCommand.Parameters.Add("@nReporte", nReporte)
         dbCommand.Parameters.Add("@qNInstMN", qNInstMN)
         dbCommand.Parameters.Add("@qNInstME", qNInstME)
         dbCommand.Parameters.Add("@sNInstMN", sNInstMN)
         dbCommand.Parameters.Add("@sNInstME", sNInstME)




         dbCommand.ExecuteNonQuery()
         'Grabar_NuevoForm1Cabecera = dbCommand.ExecuteScalar()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Modificar_Form2Cabecera(ByVal Periodo As String, _
                                                 ByVal nReporte As Integer, ByVal qNInstMN As Integer, _
                                                 ByVal qNInstME As Integer, ByVal sNInstMN As Double, ByVal sNInstME As Double, _
                                                  Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_RegistroForm2", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@nReporte", nReporte)
         dbCommand.Parameters.Add("@qNInstMN", qNInstMN)
         dbCommand.Parameters.Add("@qNInstME", qNInstME)
         dbCommand.Parameters.Add("@sNInstMN", sNInstMN)
         dbCommand.Parameters.Add("@sNInstME", sNInstME)




         dbCommand.ExecuteNonQuery()
         'Grabar_NuevoForm1Cabecera = dbCommand.ExecuteScalar()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Sub Eliminar_Form2Registro(ByVal Periodo As String, ByVal Accion As Integer, ByVal IDUsuario As String, Optional ByRef ErrMsg As String = "")
      ' Elimina detalle para reemplazarlo
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Eliminacion_DetalleForm2", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@Accion", Accion)
         dbCommand.Parameters.Add("@UsuActualiza", IDUsuario)


         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Insertar_DetalleForm2(ByVal Periodo As String, ByVal cInstPago As Integer, ByVal cTipoTxn As Integer, ByVal cCanal As Integer, _
                                             ByVal nroOperaMN As Integer, ByVal nroOperaME As Integer, ByVal vOperaMN As Decimal, ByVal vOperaME As Decimal, _
                                             ByVal Observaciones As String, ByVal IDUsuario As String, _
                                              ByVal cOficina As String, ByVal FechaCrea As Date, Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_DetalleForm2", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@cInstPago", cInstPago)
         dbCommand.Parameters.Add("@cTipoTxn", cTipoTxn)
         dbCommand.Parameters.Add("@cCanal", cCanal)
         dbCommand.Parameters.Add("@nroOperaMN", nroOperaMN)
         dbCommand.Parameters.Add("@nroOperaME", nroOperaME)
         dbCommand.Parameters.Add("@vOperaMN", vOperaMN)
         dbCommand.Parameters.Add("@vOperaME", vOperaME)
         dbCommand.Parameters.Add("@Observaciones", Observaciones)
         dbCommand.Parameters.Add("@UsuCreacion", IDUsuario)
         dbCommand.Parameters.Add("@cOficina", cOficina)
         dbCommand.Parameters.Add("@FechaCrea", FechaCrea)

         'Insertar_DetalleForm1 = dbCommand.ExecuteScalar()
         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function


#End Region
#Region "   * * * Formato 3 * * *   "

   Public Function Get_FormFormato3(Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormFormato3", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "FormFormato3")

         Me.dbDataSet.Tables(0).TableName = "Concepto"
         Me.dbDataSet.Tables(1).TableName = "Canal"
         Me.dbDataSet.Tables(2).TableName = "Comision"
         Me.dbDataSet.Tables(3).TableName = "Cliente"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Get_InfoFormato3(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_InfoFormato3", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@nReporte", 3)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato3")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Grabar_NuevoForm3Cabecera(ByVal Periodo As String, ByVal CodBCR As String, ByVal Normativa As String, _
                                              ByVal nReporte As Integer, ByVal aFuncionario As String, _
                                               Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_RegistroForm3y4", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@CodBCR", CodBCR)
         dbCommand.Parameters.Add("@Normativa", Normativa)
         dbCommand.Parameters.Add("@Funcionario", aFuncionario)
         dbCommand.Parameters.Add("@nReporte", nReporte)


         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function


   Public Sub Eliminar_Form3Registro(ByVal Periodo As String, ByVal Accion As Integer, ByVal IDUsuario As String, Optional ByRef ErrMsg As String = "")
      ' Elimina detalle para reemplazarlo
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Eliminacion_DetalleForm3", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@Accion", Accion)
         dbCommand.Parameters.Add("@UsuActualiza", IDUsuario)


         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Insertar_DetalleForm3(ByVal Periodo As String, ByVal IdConcepto As Integer, ByVal IdCanal As Integer, ByVal IdComision As Integer, _
                                             ByVal IdCliente As Integer, ByVal sTarifaMN As Double, ByVal sTarifaME As Double, _
                                             ByVal Observaciones As String, ByVal IDUsuario As String, _
                                             ByVal cOficina As String, ByVal FechaCrea As Date, Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_DetalleForm3", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@IdConcepto", IdConcepto)
         dbCommand.Parameters.Add("@IdCanal", IdCanal)
         dbCommand.Parameters.Add("@IdComision", IdComision)
         dbCommand.Parameters.Add("@IdCliente", IdCliente)
         dbCommand.Parameters.Add("@sTarifaMN", sTarifaMN)
         dbCommand.Parameters.Add("@sTarifaME", sTarifaME)
         dbCommand.Parameters.Add("@Observaciones", Observaciones)
         dbCommand.Parameters.Add("@UsuCreacion", IDUsuario)
         dbCommand.Parameters.Add("@cOficina", cOficina)
         dbCommand.Parameters.Add("@FechaCrea", FechaCrea)
         'Insertar_DetalleForm1 = dbCommand.ExecuteScalar()
         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function


#End Region
#Region "   * * * Formato 4 * * *   "

   Public Function Get_FormFormato4(Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormFormato4", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "FormFormato4")

         Me.dbDataSet.Tables(0).TableName = "TCliente"
         Me.dbDataSet.Tables(1).TableName = "Moneda"
         Me.dbDataSet.Tables(2).TableName = "Cliente"
         Me.dbDataSet.Tables(3).TableName = "Plaza"
         Me.dbDataSet.Tables(4).TableName = "Operacion"
         Me.dbDataSet.Tables(5).TableName = "Concepto"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Function Get_InfoFormato4(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_InfoFormato4", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@nReporte", 4)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato4")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Grabar_NuevoForm4Cabecera(ByVal Periodo As String, ByVal CodBCR As String, ByVal Normativa As String, _
                                              ByVal nReporte As Integer, ByVal aFuncionario As String, _
                                               Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_RegistroForm3y4", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@CodBCR", CodBCR)
         dbCommand.Parameters.Add("@Normativa", Normativa)
         dbCommand.Parameters.Add("@Funcionario", aFuncionario)
         dbCommand.Parameters.Add("@nReporte", nReporte)


         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function


   Public Sub Eliminar_Form4Registro(ByVal Periodo As String, ByVal Accion As Integer, ByVal IDUsuario As String, Optional ByRef ErrMsg As String = "")
      ' Elimina detalle para reemplazarlo
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Eliminacion_DetalleForm4", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@Accion", Accion)
         dbCommand.Parameters.Add("@UsuActualiza", IDUsuario)


         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Insertar_DetalleForm4(ByVal Periodo As String, ByVal IdTCliente As Integer, _
                                             ByVal IdMoneda As Integer, ByVal IdCliente As Integer, ByVal IdPlaza As Integer, _
                                             ByVal IdOperacion As Integer, ByVal IdConcepto As Integer, _
                                             ByVal sTasaV As Double, ByVal sMMinimoV As Double, ByVal sMMaximoV As Double, ByVal sComFijaV As Double, _
                                             ByVal sTasaCA As Double, ByVal sMMinimoCA As Double, ByVal sMMaximoCA As Double, ByVal sComFijaCA As Double, _
                                             ByVal sTasaI As Double, ByVal sMMinimoI As Double, ByVal sMMaximoI As Double, ByVal sComFijaI As Double, _
                                             ByVal sTasaO As Double, ByVal sMMinimoO As Double, ByVal sMMaximoO As Double, ByVal sComFijaO As Double, _
                                             ByVal Observaciones As String, ByVal IDUsuario As String, _
                                             ByVal cOficina As String, ByVal FechaCrea As Date, _
                                             Optional ByRef ErrMsg As String = "") As Integer


      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_DetalleForm4", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Periodo", Periodo)
         dbCommand.Parameters.Add("@IdTCliente", IdTCliente)
         dbCommand.Parameters.Add("@IdMoneda", IdMoneda)
         dbCommand.Parameters.Add("@IdCliente", IdCliente)
         dbCommand.Parameters.Add("@IdPlaza", IdPlaza)
         dbCommand.Parameters.Add("@IdOperacion", IdOperacion)
         dbCommand.Parameters.Add("@IdConcepto", IdConcepto)
         dbCommand.Parameters.Add("@sTasaV", sTasaV)
         dbCommand.Parameters.Add("@sMMinimoV", sMMinimoV)
         dbCommand.Parameters.Add("@sMMaximoV", sMMaximoV)
         dbCommand.Parameters.Add("@sComFijaV", sComFijaV)
         dbCommand.Parameters.Add("@sTasaCA", sTasaCA)
         dbCommand.Parameters.Add("@sMMinimoCA", sMMinimoCA)
         dbCommand.Parameters.Add("@sMMaximoCA", sMMaximoCA)
         dbCommand.Parameters.Add("@sComFijaCA", sComFijaCA)
         dbCommand.Parameters.Add("@sTasaI", sTasaI)
         dbCommand.Parameters.Add("@sMMinimoI", sMMinimoI)
         dbCommand.Parameters.Add("@sMMaximoI", sMMaximoI)
         dbCommand.Parameters.Add("@sComFijaI", sComFijaI)
         dbCommand.Parameters.Add("@sTasaO", sTasaO)
         dbCommand.Parameters.Add("@sMMinimoO", sMMinimoO)
         dbCommand.Parameters.Add("@sMMaximoO", sMMaximoO)
         dbCommand.Parameters.Add("@sComFijaO", sComFijaO)
         dbCommand.Parameters.Add("@Observaciones", Observaciones)
         dbCommand.Parameters.Add("@UsuCreacion", IDUsuario)
         dbCommand.Parameters.Add("@cOficina", cOficina)
         dbCommand.Parameters.Add("@FechaCrea", FechaCrea)

         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function


#End Region
#Region "   * * * Consolidado 1* * *   "
   Public Function Get_InfoConsolidadoF1(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_ConsolidadoF1", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato1")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Get_InfoOficinaF1(ByVal Id_Periodo As String, ByVal Id_Operacion As Integer, ByVal Id_TOperacion As Integer, _
   ByVal Id_Estado As Integer, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_OficinaF1", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Id_Periodo)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdOperacion", Id_Operacion)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdTOperacion", Id_TOperacion)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdEstado", Id_Estado)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetDetalleFormato1")

         Me.dbDataSet.Tables(0).TableName = "InfoOficina"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Consolidado 2* * *   "
   Public Function Get_InfoConsolidadoF2(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_ConsolidadoF2", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato2")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Get_InfoOficinaF2(ByVal IdPeriodo As String, ByVal IdInstPago As Integer, ByVal IdTTxn As Integer, _
   ByVal IdCanal As Integer, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_OficinaF2", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", IdPeriodo)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdInstPago", IdInstPago)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdTTxn", IdTTxn)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdCanal", IdCanal)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetDetalleFormato2")

         Me.dbDataSet.Tables(0).TableName = "InfoOficina"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Consolidado 3* * *   "
   Public Function Get_InfoConsolidadoF3(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_ConsolidadoF3", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato3")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Get_InfoOficinaF3(ByVal IdPeriodo As String, ByVal IdConcepto As Integer, ByVal IdCanal As Integer, _
                  ByVal IdComision As Integer, ByVal IdCliente As Integer, _
                  Optional ByRef ErrMsg As String = "") As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_OficinaF3", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", IdPeriodo)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdConcepto", IdConcepto)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdCanal", IdCanal)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdComision", IdComision)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdCliente", IdCliente)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetDetalleFormato3")

         Me.dbDataSet.Tables(0).TableName = "InfoOficina"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Consolidado 4* * *   "
   Public Function Get_InfoConsolidadoF4(ByVal Periodo As String, Optional ByRef ErrMsg As String = "") As DataSet
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_ConsolidadoF4", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", Periodo)
         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetInfoFormato4")

         Me.dbDataSet.Tables(0).TableName = "InfoRegistro_General"
         Me.dbDataSet.Tables(1).TableName = "InfoRegistro_Detalle"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Function Get_InfoOficinaF4(ByVal IdPeriodo As String, ByVal IdTCliente As Integer, _
                        ByVal IdMoneda As Integer, ByVal IdCliente As Integer, ByVal IdPlaza As Integer, _
   ByVal IdOperacion As Integer, ByVal IdConcepto As Integer, Optional ByRef ErrMsg As String = "") As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_Get_OficinaF4", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@Periodo", IdPeriodo)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdTCliente", IdTCliente)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdMoneda", IdMoneda)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdCliente", IdCliente)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdPlaza", IdPlaza)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdOperacion", IdOperacion)
         Me.dbDataAdapter.SelectCommand.Parameters.Add("@IdConcepto", IdConcepto)

         Me.dbDataAdapter.Fill(Me.dbDataSet, "GetDetalleFormato4")

         Me.dbDataSet.Tables(0).TableName = "InfoOficina"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Mantenedor Operacion  * * *   "
   Public Function Get_FormMNOperacion(ByRef ErrMsg As String) As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormMNOperacion", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "ControlesOperacion")

         Me.dbDataSet.Tables(0).TableName = "Operacion"


         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try

   End Function
   Public Function Grabar_FormMNOperacion(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                        ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")

      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_MNOperacion ", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuCreacion", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)
      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Sub Modificar_FormMNOperacion(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                        ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_MNOperacion", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Eliminar_FormMNOperacion(ByVal Codigo As Integer, _
                                         ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_EliminacionLogica_MNOperacion", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Mantenedor Instrumentos Pago * * *   "
   Public Function Get_FormMNInstPago(ByRef ErrMsg As String) As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormMNInstPago", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "ControlesInstPago")

         Me.dbDataSet.Tables(0).TableName = "InstPago"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try

   End Function
   Public Function Grabar_FormMNInstPAgo(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                       ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")

      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_MNInstPago ", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuCreacion", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)
      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Sub Modificar_FormMNInstPago(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                   ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_MNInstPago", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Eliminar_FormMNInstPago(ByVal Codigo As Integer, _
                                         ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_EliminacionLogica_MNInstPago", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Mantenedor Canal * * *   "
   Public Function Get_FormMNCanal(ByRef ErrMsg As String) As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormMNCanal", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "ControlesCanal")

         Me.dbDataSet.Tables(0).TableName = "Canal"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try

   End Function
   Public Function Grabar_FormMNCanal(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                       ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")

      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_MNCanal ", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuCreacion", CodUsuario)

         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)
      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Sub Modificar_FormMNCanal(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                   ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_MNCanal", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Eliminar_FormMNCanal(ByVal Codigo As Integer, _
                                         ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_EliminacionLogica_MNCanal", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Mantenedor Comisión BCR * * *   "
   Public Function Get_FormMNComisBCR(ByRef ErrMsg As String) As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormMNComision", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "ComisBCR")

         Me.dbDataSet.Tables(0).TableName = "ComisBCR"

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try

   End Function

   Public Function Grabar_FormMNComisBCR(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                        ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")

      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_MNComisBCR", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuCreacion", CodUsuario)

         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)
      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
   Public Sub Modificar_FormMNComisBCR(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                    ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_MNComisBCR", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Eliminar_FormMNComisBCR(ByVal Codigo As Integer, _
                                          ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_EliminacionLogica_MNComisBCR", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Mantenedor Transacción  * * *   "
   Public Function Get_FormMNTTransac(ByRef ErrMsg As String) As DataSet

      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_FormMNTTransac", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "ControlesTransaccion")

         Me.dbDataSet.Tables(0).TableName = "Transaccion"


         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try

   End Function
   Public Function Grabar_FormMNTTransac(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                        ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")

      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Insertar_MNTTransac", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuCreacion", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)
      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function

   Public Sub Modificar_FormMNTTransac(ByVal Codigo As Integer, ByVal Descripcion As String, _
                                        ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_Modificar_MNTTransac", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@Descripcion", Descripcion)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub
   Public Function Eliminar_FormMNTTransac(ByVal Codigo As Integer, _
                                         ByVal CodUsuario As String, Optional ByRef ErrMsg As String = "")
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_EliminacionLogica_MNTTransac", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@Codigo", Codigo)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)
         dbCommand.ExecuteNonQuery()

         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Function
#End Region
#Region "   * * * Parametros * * *   "

   Public Function Leer_Parametros(ByRef ErrMsg As String) As DataTable
      Try
         Me.AbrirConexion(ErrMsg)

         Me.dbDataSet = New Data.DataSet
         Me.dbDataAdapter = New Data.SqlClient.SqlDataAdapter("BNSP_LeerParametros", Me.dbConnection)
         Me.dbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
         Me.dbDataAdapter.Fill(Me.dbDataSet, "Parametros")

         Me.CerrarConexion(ErrMsg)
         Return Me.dbDataSet.Tables(0)

      Catch ex As Exception


         ErrMsg = ex.Message
      End Try

   End Function

   Public Sub Grabar_Parametros(ByVal CodBCR As String, ByVal Normativa As String, ByVal Funcionario As String, _
                                ByVal CodUsuario As String, ByRef ErrMsg As String)
      Try
         Me.AbrirConexion(ErrMsg)

         dbCommand = New SqlCommand("BNSP_GrabarParametros", dbConnection)
         dbCommand.CommandType = CommandType.StoredProcedure
         dbCommand.Parameters.Add("@CodBCR", CodBCR)
         dbCommand.Parameters.Add("@Normativa", Normativa)
         dbCommand.Parameters.Add("@Funcionario", Funcionario)
         dbCommand.Parameters.Add("@UsuActualiza", CodUsuario)

         dbCommand.ExecuteNonQuery()
         Me.CerrarConexion(ErrMsg)

      Catch ex As Exception
         ErrMsg = ex.Message
      End Try
   End Sub

#End Region
#Region "   * * * LOG * * *   "

   Public Sub CrearLogTXT(ByVal Datos As String)
      Dim stbRegistro As New System.Text.StringBuilder
      Try
         stbRegistro.Append(Datos)
         Dim fstRegistro As New System.IO.FileStream("C:\LOG\log.txt", FileMode.Append)    'ConfigurationSettings.AppSettings("RutaLog")
         Dim stwConstancia As New System.IO.StreamWriter(fstRegistro)
         stwConstancia.WriteLine(stbRegistro)
         stwConstancia.Close()
         fstRegistro.Close()

      Catch ex As Exception
         'Throw ex
      End Try
   End Sub
#End Region
    Public Function Verificar_RegistroControl(ByVal NroForm As String, ByVal Usuario As String, _
                                             Optional ByRef ErrMsg As String = "") As Integer

        Try
            Me.AbrirConexion(ErrMsg)

            dbCommand = New SqlCommand("BNSP_Verifica_RegistroControl", dbConnection)
            dbCommand.CommandType = CommandType.StoredProcedure
            dbCommand.Parameters.Add("@NroForm", NroForm)
            dbCommand.Parameters.Add("@Usuario", Usuario)
            Verificar_RegistroControl = dbCommand.ExecuteScalar()
            Me.CerrarConexion(ErrMsg)

        Catch ex As Exception
            ErrMsg = ex.Message
        End Try
    End Function
    Public Function Grabar_RegistroControl(ByVal NroForm As String, ByVal Periodo As String, ByVal Usuario As String, _
                                         Optional ByRef ErrMsg As String = "") As Integer

        Try
            Me.AbrirConexion(ErrMsg)

            dbCommand = New SqlCommand("BNSP_Insertar_RegistroControl", dbConnection)
            dbCommand.CommandType = CommandType.StoredProcedure
            dbCommand.Parameters.Add("@NroForm", NroForm)
            dbCommand.Parameters.Add("@Periodo", Periodo)
            dbCommand.Parameters.Add("@Usuario", Usuario)
            Grabar_RegistroControl = dbCommand.ExecuteScalar()
            Me.CerrarConexion(ErrMsg)

        Catch ex As Exception
            ErrMsg = ex.Message
        End Try
    End Function
    Public Function Actualizar_RegistroControl(ByVal NroForm As String, ByVal Periodo As String, ByVal Usuario As String, _
                                         Optional ByRef ErrMsg As String = "") As Integer

        Try
            Me.AbrirConexion(ErrMsg)

            'dbCommand = New SqlCommand("BNSP_Actualizar_RegistroControl", dbConnection)
            dbCommand = New SqlCommand("BNSP_Actualizar_RegistroControl_CierreSesion", dbConnection)
            dbCommand.CommandType = CommandType.StoredProcedure
            'dbCommand.Parameters.Add("@NroForm", NroForm)
            'dbCommand.Parameters.Add("@Periodo", Periodo)
            dbCommand.Parameters.Add("@Usuario", Usuario)
            dbCommand.ExecuteNonQuery()
            Me.CerrarConexion(ErrMsg)

        Catch ex As Exception
            ErrMsg = ex.Message
        End Try
    End Function
    Public Function Actualizar_RegistroControl_CS(ByVal Usuario As String, _
                                         Optional ByRef ErrMsg As String = "") As Integer

        Try
            Me.AbrirConexion(ErrMsg)

            dbCommand = New SqlCommand("BNSP_Actualizar_RegistroControl_CierreSesion", dbConnection)
            dbCommand.CommandType = CommandType.StoredProcedure
            dbCommand.Parameters.Add("@Usuario", Usuario)
            dbCommand.ExecuteNonQuery()
            Me.CerrarConexion(ErrMsg)

        Catch ex As Exception
            ErrMsg = ex.Message
        End Try
    End Function
End Class
