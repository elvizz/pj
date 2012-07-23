using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoJournal.Models
{
    /// <summary>
    /// Класс для работы с сущностью PhotoLenta
    /// </summary>
    public class LentaRepository
    {
        private readonly PJContext _pjContext;
        /// <summary>
        /// Конструктор инициализирует обьект, для работы с множеством сущностей модели данных
        /// </summary>
        /// <param name="pjContext">Обьект для работы с множеством сущностей модели данных</param>
        public LentaRepository(PJContext pjContext)
        {
            _pjContext = pjContext;
        }

        /// <summary>
        /// Достает из базы данных поле по Id
        /// </summary>
        /// <param name="id">Id поля</param>
        /// <returns></returns>
        public PhotoLenta GetItem(Guid id)
        {
            return _pjContext.PhotoLentas.SingleOrDefault(l => l.Id == id);
        }

        /// <summary>
        /// Достает из базы данных все поля
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PhotoLenta> GetAll()
        {
          return _pjContext.PhotoLentas.OrderByDescending(l => l.DateTime);
        } 
    }
}