using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoJournal.Models
{
    public class ArticleRepository
    {
        private readonly PJContext _pjContext;

        public ArticleRepository(PJContext pjContext)
        {
            _pjContext = pjContext;
        }

        public IEnumerable<Article> GetAll()
        {
            return _pjContext.Articles;
        } 
    }
}