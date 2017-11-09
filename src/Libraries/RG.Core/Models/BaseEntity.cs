using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Core.Models
{
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Unique contact form identifier
        /// </summary>
        public int Id { get; set; }
    }
}
