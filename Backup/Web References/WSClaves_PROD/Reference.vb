﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5420
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.5420.
'
Namespace WSClaves_PROD
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="AutenticaRegSoapBinding", [Namespace]:="http://service.seguridad")>  _
    Partial Public Class AutenticaRegService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private claveHostOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://10.7.10.53:80/WSClaveHost/services/AutenticaReg"
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event claveHostCompleted As claveHostCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace:="http://service.seguridad", ResponseNamespace:="http://service.seguridad", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function claveHost(<System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)> ByVal info1 As String) As <System.Xml.Serialization.XmlElementAttribute("claveHostReturn", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=true)> String
            Dim results() As Object = Me.Invoke("claveHost", New Object() {info1})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginclaveHost(ByVal info1 As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("claveHost", New Object() {info1}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndclaveHost(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub claveHostAsync(ByVal info1 As String)
            Me.claveHostAsync(info1, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub claveHostAsync(ByVal info1 As String, ByVal userState As Object)
            If (Me.claveHostOperationCompleted Is Nothing) Then
                Me.claveHostOperationCompleted = AddressOf Me.OnclaveHostOperationCompleted
            End If
            Me.InvokeAsync("claveHost", New Object() {info1}, Me.claveHostOperationCompleted, userState)
        End Sub
        
        Private Sub OnclaveHostOperationCompleted(ByVal arg As Object)
            If (Not (Me.claveHostCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent claveHostCompleted(Me, New claveHostCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub claveHostCompletedEventHandler(ByVal sender As Object, ByVal e As claveHostCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class claveHostCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
