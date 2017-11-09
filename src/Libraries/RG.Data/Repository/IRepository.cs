using RG.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Data.Repository
{
    public interface IRepository<TEntity> where TEntity:BaseEntity
    {
        /// <summary>
        /// Add new Entity(table) contents
        /// </summary>
        /// <param name="T"></param>
        void Add(TEntity T);

        /// <summary>
        /// Return Entity(table) contents
        /// </summary>
        IQueryable<TEntity> Table { get; }

        
    }
}
