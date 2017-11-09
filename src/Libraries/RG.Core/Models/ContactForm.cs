using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Core.Models
{
    public class ContactForm:BaseEntity
    {
        /// <summary>
        /// Contact name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contact Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Contact Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Contact Address
        /// </summary>
        public string Address { get; set; }
    }
}
