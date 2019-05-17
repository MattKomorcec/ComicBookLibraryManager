using ComicBookShared.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ComicBookShared.Data
{
    public class Repository
    {
        private Context _context;

        public Repository(Context context)
        {
            _context = context;
        }        
    }
}
