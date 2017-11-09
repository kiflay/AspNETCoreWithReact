using RG.Core.Models;
using RG.Data.RGContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RG.Data.Repository
{
    public class RGRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Fields
        /// <summary>
        /// Initialise db context
        /// </summary>
        private IDbContext db;

        /// <summary>
        /// Intitialise Entities(tables)
        /// </summary>
        private IDbSet<TEntity> entities;

        /// <summary>
        /// Set Entitity(table)
        /// </summary>
        protected virtual IDbSet<TEntity> _Entities
        {
            get
            {
                if (entities == null)
                    this.entities = db.Set<TEntity>();
                return entities;
            }
        }

        /// <summary>
        /// Get Entity (table) contents
        /// </summary>
        public IQueryable<TEntity> Table
        {
            get {
                return this._Entities;
                }
        }
        #endregion

        #region Constructor
        public RGRepository(IDbContext context)
            {
                this.db = context;
            }
        #endregion

        #region Methods
        /// <summary>
        /// Add new Entity(table) contents to database
        /// </summary>
        /// <param name="T"></param>
        public void Add(TEntity T)
        {
            try
            {
                if (T == null)
                    throw new ArgumentNullException("Empty table");
                this._Entities.Add(T);
                this.db.SaveChanges();
            }
            catch(DbEntityValidationException dbException)
            {
                throw new Exception($"Can't Insert table contents to database:{ dbException.Message }");
            }
        }
        #endregion
    }
}
