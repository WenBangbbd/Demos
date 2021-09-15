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
            mailClient.Credentials = new NetworkCredential("....@qq.com", "授权码");
            //信息，
            var message = new MailMessage(new MailAddress("...@qq.com"), new MailAddress("...@qq.com"));
            message.IsBodyHtml = false;
            message.Body = "http://www.baidu.com";
            message.Subject = "subject";
            //发送邮件
            mailClient.Send(message);
        }
    }
}
