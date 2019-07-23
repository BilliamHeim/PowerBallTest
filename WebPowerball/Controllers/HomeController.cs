using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPowerball.Models;

namespace WebPowerball.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult EnterNew()
        {
            AddTicketViewModel model = new AddTicketViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult EnterNew(AddTicketViewModel model)
        {
            Ticket ticket = new Ticket
            {
                Name = model.Name,
                Numbers = new int[6] { model.Numbers1, model.Numbers2, model.Numbers3,
                                       model.Numbers4, model.Numbers5, model.Numbers6 }
        };
            TicketRepo.Add(ticket);
            return View("DisplayTicket", TicketRepo.GetAll().LastOrDefault() );
            //if !IsValid: return View(model);
        }

        public ActionResult FindTicket()
        {
            int id = 0;
            return View(id);
        }
        [HttpPost]
        public ActionResult FindTicket(int id)
        {
            Ticket ticket=TicketRepo.Get(id);
            return View("DisplayTicket",ticket);
        }

        public ActionResult DisplayTicket(Ticket ticket)
        {
            return View();
        }
     
        public ActionResult Draw()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Draw(int[] pick)
        {
            return View("Index");
        }
    }
}