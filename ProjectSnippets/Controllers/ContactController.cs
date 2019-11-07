using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementPortal.Models;
using System.Net.Mail;
using System.Web.Mvc;
using System.Text;
using System.Threading;
using System.Net;

namespace ManagementPortal.Controllers
{
    public class ContactUsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ContactUs userInput)
        {
            if (ModelState.IsValid)
            {
                var toAddress = "liveprojectdummyacct@gmail.com";
                var fromAddress = userInput.Email.ToString();
                var subject = userInput.Subject;
                var message = "<b>Name: </b>" + userInput.Name + "<br>" + "<b>Email: </b>" + userInput.Email + "<br>" + "<b>Telephone: </b>" + userInput.Phone + "<br><br>" + "<b>Message: </b>" + userInput.Message;

                SendEmail(toAddress, fromAddress, subject, message);
                return View("Success");
            }
            return View();
        }

        public void SendEmail(string toAddress, string fromAddress, string subject, string message)
        {
            using (MailMessage newMessage = new MailMessage())
            {
                newMessage.From = new MailAddress(fromAddress);
                newMessage.To.Add(new MailAddress(toAddress));
                newMessage.Subject = subject;
                newMessage.Body = message.ToString();
                newMessage.IsBodyHtml = true;
                try
                {
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new NetworkCredential
                    ("liveprojectdummyacct@gmail.com", "ASDqwe123!");
                    smtp.EnableSsl = true;
                    smtp.Send(newMessage);
                    ModelState.Clear();
                    ViewBag.Message = "Thank you for contacting us! Someone will get back to you shortly. ";
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    foreach (SmtpFailedRecipientException t in ex.InnerExceptions)
                    {
                        var status = t.StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy ||
                            status == SmtpStatusCode.MailboxUnavailable)
                        {
                            Response.Write("Delivery failed - retrying in 5 seconds.");
                            Thread.Sleep(5000);
                            //resend
                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.Credentials = new NetworkCredential
                            ("liveprojectdummyacct@gmail.com", "ASDqwe123!");
                            smtp.EnableSsl = true;
                            smtp.Send(newMessage);
                        }
                        else
                        {
                            ViewBag.Message = $"Failed to deliver message to " + t.FailedRecipient;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Message = $"A secure connection or the client was not authenticated.";
                }
                finally
                {
                    newMessage.Dispose();
                }
            }
        }
    }
}
