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
        /// <summary>
        /// Свойство предоставляет доступ к таблице PhotoLenta
        /// </summary>
        public DbSet<PhotoLenta> PhotoLentas { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        
        /// <summary>
        /// Метод защищает имена таблиц от плюрализации
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}