using RG.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Services.ContactFormService
{
    public interface IContactFormService
    {
        void AddContactForm(ContactForm contactForm);
        IQueryable<ContactForm> Table { get; }
    }
}
