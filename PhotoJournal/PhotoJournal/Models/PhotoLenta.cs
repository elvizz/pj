using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhotoJournal.Models
{
    /// <summary>
    /// Класс определяет сущности для таблицы PhotoLenta
    /// </summary>
    public class PhotoLenta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// Конструктор по умолчанию, автогенерация Guid
        /// </summary>
        public PhotoLenta()
        {
            Id = Guid.NewGuid();
        }
    }
}