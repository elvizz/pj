using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoJournal.Models
{
    /// <summary>
    /// Класс предоставляет доступ к свойствам и методам всех моделей данных
    /// </summary>
    public class DataManger
    {
        private readonly PJContext _pjContext;
        /// <summary>
        /// Инициализирует объект для работы с сущностями в модели данных
        /// </summary>
        public DataManger()
        {
            _pjContext = new PJContext();
        }

        private LentaRepository _lentaRepository;
        /// <summary>
        /// Свойство предоставляет доступ к классу LentaRepository
        /// </summary>
        public LentaRepository Lenta
        {
            get
            {
                if (_lentaRepository==null)
                {
                    _lentaRepository = new LentaRepository(_pjContext);
                }
                return _lentaRepository;
            }
        }

        private ArticleRepository _articleRepository;
        public ArticleRepository Article
        {
            get
            {
                if (_articleRepository==null)
                {
                    _articleRepository = new ArticleRepository(_pjContext);
                }
                return _articleRepository;
            }
        }
    }
}