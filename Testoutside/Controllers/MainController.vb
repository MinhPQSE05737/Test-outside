Imports System.Web.Mvc
Imports System.Net
Imports System.Net.Mail
Imports System.Web.Services
Imports System.Configuration
Imports System.Net.Configuration

Namespace Controllers

    Public Class MainController
        Inherits System.Web.Mvc.Controller

        <WebMethod(EnableSession:=True)>
        Public Function SendEmail(ByVal toEmail As String, ByVal subject As String, ByVal body As String) As String
            Dim smtpSection As SmtpSection = CType(ConfigurationManager.GetSection("system.net/mailSettings/smtp"), SmtpSection)
            Using mm As MailMessage = New MailMessage(smtpSection.From, toEmail)
                mm.Subject = subject
                mm.Body = body
                mm.IsBodyHtml = False
                Dim smtp As SmtpClient = New SmtpClient
                smtp.Host = smtpSection.Network.Host
                smtp.EnableSsl = smtpSection.Network.EnableSsl
                Dim networkCred As NetworkCredential = New NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password)
                smtp.UseDefaultCredentials = smtpSection.Network.DefaultCredentials
                smtp.Credentials = networkCred
                smtp.Port = smtpSection.Network.Port
                smtp.Send(mm)
            End Using
            Return "Email sent."
        End Function

    End Class
End Namespace