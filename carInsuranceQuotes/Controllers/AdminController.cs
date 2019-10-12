using carInsuranceQuotes.Models;
using carInsuranceQuotes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace carInsuranceQuotes.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceQuotesEntities db = new CarInsuranceQuotesEntities())
            {
                var quotes = (from c in db.Quotes select c).ToList();                         //Using linq to aquire our database
                
                List<QuoteVM> quoteVms = new List<QuoteVM>();                                 //ViewModel
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVM();
                    quoteVm.Id = quote.Id;
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.BasePolicy = Convert.ToDouble(quote.BasePolicy);

                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}