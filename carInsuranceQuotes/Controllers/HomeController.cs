using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using carInsuranceQuotes.Models;

namespace carInsuranceQuotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake, string carModel,
                                    string tickets, bool dui = false, bool fullCoverage = false)

        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)
                || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || string.IsNullOrEmpty(carMake)
                || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(tickets))  //Validating to make sure it's not null or empty
            {
                return View("~/Views/Shared/Error.cshtml");                      //Root path to our error page
            }
            else
            {
                double BasePolicy = 50;

                var age = UserAge();
                int UserAge()                                                                   //Get age
                {
                    DateTime tDay = DateTime.Now;
                    int years = tDay.Year - Convert.ToDateTime(dateOfBirth).Year;
                    return years;
                }
                if (age < 18)                                                                  //Parameters verified 
                {
                    
                    BasePolicy += 100;
                    
                }
                else if ((age > 17 && age < 25) || age > 100)
                {
                    BasePolicy += 25;
                }
                if (Convert.ToInt32(carYear) < 2000 || Convert.ToInt32(carYear) > 2015)
                {
                    BasePolicy += 25;
                }
                if (carMake == "Porsche" || carMake == "porsche")
                {
                    BasePolicy += 25;
                }
                if ((carMake == "Porsche" || carMake == "porsche") && (carModel == "911 Carrera" || carModel == "911 carrera"))
                {
                    BasePolicy += 25;
                }
                if (Convert.ToInt32(tickets) > 0)
                {
                    BasePolicy += (Convert.ToInt32(tickets) * 10);
                }
                if (dui == true)
                {
                    BasePolicy += (BasePolicy * .25);
                }
                if (fullCoverage == true)
                {
                    BasePolicy += (BasePolicy * .50);
                }
                ViewBag.Name = firstName;
                ViewBag.Message = BasePolicy;
                using (CarInsuranceQuotesEntities db = new CarInsuranceQuotesEntities())                //Using Entity Framework
                {
                    var quote = new Quote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateofBirth = dateOfBirth;
                    quote.CarYear = Convert.ToInt32(carYear);
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.Tickets = Convert.ToInt32(tickets);
                    quote.Dui = dui;
                    quote.FullCoverage = fullCoverage;
                    quote.BasePolicy = BasePolicy;

                    db.Quotes.Add(quote);
                    db.SaveChanges();
                }

                return View("result");                                                                 //Returns our quote for the user
            }
        }
    }
}

