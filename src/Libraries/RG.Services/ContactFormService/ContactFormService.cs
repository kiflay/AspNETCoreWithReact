
using RG.Core.Models;
using RG.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Services.ContactFormService
{
    public class ContactFormService :IContactFormService
    {
        
        public ContactFormService(IRepository<ContactForm> RepositoryContactformService)
        {
            this._RepositoryContactformService = RepositoryContactformService;
        }
        #region Fields
        public IQueryable<ContactForm> Table
        { get {
                return this._RepositoryContactformService.Table;

            }
        }
        private IRepository<ContactForm> _RepositoryContactformService;

        #endregion

        #region Methods
        /// <summary>
        /// Insert new contact form to database
        /// </summary>
        /// <param name="contactForm"></param>
        public void AddContactForm(ContactForm contactForm)
        {
            try
            {
                if (contactForm == null)
                    throw new ArgumentNullException($"Empty Contact form contents");
                this._RepositoryContactformService.Add(contactForm);
            }
            catch (Exception ex)
            {
                throw new Exception($"Empty form: {ex.Message}");
            }
        }

       
        #endregion
    }
}
