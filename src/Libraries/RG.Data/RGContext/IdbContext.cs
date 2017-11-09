using RG.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Data.RGContext
{
    public interface IDbContext
    {
        /// <summary>
        /// Set Enity(Table) values
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

        /// <summary>
        /// Save Entity(table) contents to Database
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}
