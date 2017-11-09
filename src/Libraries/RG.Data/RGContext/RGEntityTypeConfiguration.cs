using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Data.RGContext
{
    public abstract class RGEntityTypeConfiguration<T>: EntityTypeConfiguration<T> where T:class
    {
    }
}
