using ApplicationCore.Services.IServices;
using System.Net;
using System.Net.Mail;

namespace ApplicationCore.Services.Services
{
    public class EnviarEmail : IEnviarEmail
    {
        public void enviar(string titulo, string corpo, string para, string copia)
        {
            var fromAddress = new MailAddress("hamilton.valnet@gmail.com", "Venda Direta");
            var toAddress = new MailAddress(para, "Usuário");
            const string fromPassword = "fm1bl2xml33";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

        }
    }
}
