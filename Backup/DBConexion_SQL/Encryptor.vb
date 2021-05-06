'*-------------------------------------------------------------------------
'* Banco de la Nación :  Sistema ESTADOS CTAS CTES INTRANET - ECCI   
'* Autor   : MIGUEL SAAVEDRA                                               
'* Archivo : Clase BNEncryptor                                                
'* Fecha de Creacion    : OCTUBRE 2007.  
'* Ultima Actualizacion : OCTUBRE 2007.                                      
'*-------------------------------------------------------------------------
'Esta Clase se utiliza para Encrytar y desencryptar los datos. 
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text

Friend NotInheritable Class Encryptor

    Public Shared Function EncryptTripleDES(ByVal Plaintext As String) As String
        Dim DES As New TripleDESCryptoServiceProvider
        Dim hashMD5 As New MD5CryptoServiceProvider
        DES.Key = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(KEY))
        DES.Mode = System.Security.Cryptography.CipherMode.ECB
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        Dim Buffer() As Byte = ASCIIEncoding.ASCII.GetBytes(Plaintext)
        EncryptTripleDES = Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Shared Function DecryptTripleDES(ByVal base64Text As String) As String
        Dim DES As New TripleDESCryptoServiceProvider
        Dim hashMD5 As New MD5CryptoServiceProvider
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(KEY))
        DES.Mode = CipherMode.ECB
        Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
        Dim Buffer() As Byte = Convert.FromBase64String(base64Text)
        DecryptTripleDES = ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function


End Class
