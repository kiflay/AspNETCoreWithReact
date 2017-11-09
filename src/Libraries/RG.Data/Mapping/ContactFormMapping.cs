
using RG.Core.Models;
using RG.Data.RGContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Data.Mapping
{
    public class ContactFormMapping: RGEntityTypeConfiguration<ContactForm>
    {
        public ContactFormMapping()
        {
            this.ToTable("Contact Forms");
            this.HasKey(c => c.Id);
            this.Property(c => c.Name);
            this.Property(c => c.Email);
            this.Property(c => c.Address);
            this.Property(c => c.Message);
        }
    }
}
