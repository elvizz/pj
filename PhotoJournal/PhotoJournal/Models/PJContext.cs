using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PhotoJournal.Models;

namespace PhotoJournal.Models
{
    /// <summary>
    /// Главный класс, координирующий функциональность Entity Framework
    /// определяет, какие сущности включить в модель данных
    /// </summary>
    public class PJContext: DbContext
    {
        public DbSet<PhotoLenta> PhotoLentas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}