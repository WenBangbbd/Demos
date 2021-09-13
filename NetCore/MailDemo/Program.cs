using System;
using System.Net;
using System.Net.Mail;

namespace MailDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailClient = new SmtpClient("smtp.qq.com");
            mailClient.EnableSsl = true;
            mailClient.UseDefaultCredentials = false;

            //授权,不是密码
            mailClient.Credentials = new NetworkCredential("763111123@qq.com", "bwckniwsvmgabeba");
            //信息，
            var message = new MailMessage(new MailAddress("763111123@qq.com"), new MailAddress("763111123@qq.com"));
            message.IsBodyHtml = false;
            message.Body = "http://www.baidu.com";
            message.Subject = "subject";
            //发送邮件
            mailClient.Send(message);
        }
    }
}
