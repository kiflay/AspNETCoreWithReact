using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RG.Core.Models;
using System.Reflection;
using System.Configuration;

namespace RG.Data.RGContext
{
    public class RGDbContext : DbContext,IDbContext
    {
        #region Constructor
        string connectionString = ConfigurationManager.AppSettings["connectionString"]
        public RGDbContext():base("data source =.\\SQLEXPRESS; initial catalog = RG; Trusted_Connection=True;MultipleActiveResultSets=True;Language=British;Connect Timeout = 180;"){

        }
        #endregion

        public IDbSet<ContactForm> forms { get; set; }
        #region Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //dynamically load all configuration
            //System.Type configType = typeof(productMap); // any of configuration maps
            //Var typesToRegister = Assembly.GetAssembly(configType).GetTypes();
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                                  .Where(type => String.IsNullOrEmpty(type.Namespace))
                                  .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(RGEntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            

            base.OnModelCreating(modelBuilder);
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
        #endregion
    }
}
