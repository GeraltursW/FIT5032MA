using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032MA.Service
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";
        public void Send(String toEmail, String subject, String contents)
        {

            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("hello@yunwanggg.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }
    }
}