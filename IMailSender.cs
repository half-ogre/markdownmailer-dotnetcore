﻿using System;
using System.Net.Mail;

namespace MarkdownMailer
{
    public interface IMailSender : IDisposable
    {
        void Send(
            string fromAddress,
            string toAddress,
            string subject,
            string markdownBody);

        void Send(
            MailAddress fromAddress,
            MailAddress toAddress,
            string subject,
            string markdownBody);

        void Send(MailMessage mailMessage);
    }
}