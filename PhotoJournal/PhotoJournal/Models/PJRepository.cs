using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoJournal.Models
{
    public class PJRepository
    {
        private static PJRepository _pjRepository;

        public static PJRepository Instance()
        {
            return _pjRepository ?? (_pjRepository = new PJRepository());
        }

        private readonly PJContext _pjContext;

        public PJRepository()
        {
            _pjContext = new PJContext();
        }

        public PhotoLenta GetItem(Guid id)
        {
            return _pjContext.PhotoLentas.SingleOrDefault(l => l.Id == id);
        }
    }
}