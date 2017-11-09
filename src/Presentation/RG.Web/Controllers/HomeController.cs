using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RG.Services.ContactFormService;
using RG.Core.Models;

namespace RG.Web.Controllers
{
    public class HomeController : Controller
    {
        private IContactFormService _contactFormServices;
        public HomeController(IContactFormService contactFormServices)
        {
            this._contactFormServices = contactFormServices;
        }
        public IActionResult Index()
        {
            var forms = _contactFormServices.Table;
            if (forms == null)
                throw new ArgumentNullException("empty forms");
            return View(forms);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                _contactFormServices.AddContactForm(form);
                return RedirectToAction("Index");

            }
            return View();
        }
        
    }
}