using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeditrainSouth.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace MeditrainSouth.Controllers
{
    public class ContactController : Controller
    {
       

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            if (!ModelState.IsValid) {
                return View(message);
            }
            message.CurrentTime = DateTime.Now;

            //create the mail message
            MailMessage mail = new MailMessage();

            //set the addresses
            mail.From = new MailAddress("Notification@meditrainsouth.co.nz");
            mail.To.Add("waverdt@gmail.com");

            //set the content
            mail.Subject = "Confirmation of Testing";
            mail.Body = "Did you see this message? if not please configure it.";

            //send the message
            SmtpClient smtp = new SmtpClient("localhost");
            smtp.Credentials = new NetworkCredential("Notification@meditrainsouth.co.nz", "PleskNtfMail1!");

            smtp.Send(mail);


            return View();
        }
    }
}
