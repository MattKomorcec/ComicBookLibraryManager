using ComicBookShared.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ComicBookShared.Data
{
    public class ArtistsRepository : BaseRepository<Artist>
    {
        public ArtistsRepository(Context context) : base(context) { }

        public override Artist GetById(int id, bool includeRelatedEntities = true)
        {
            var artist = Context.Artists.AsQueryable();

            if (includeRelatedEntities)
            {
                artist = artist
                    .Include(a => a.ComicBooks.Select(s => s.ComicBook.Series))
                    .Include(a => a.ComicBooks.Select(s => s.Role));
            }

            return artist
                    .Where(a => a.Id == id)
                    .SingleOrDefault();
        }

        public override IList<Artist> GetList()
        {
            return Context.Artists
                .OrderBy(a => a.Name)
                .ToList();
        }

        public bool DoesArtistExist(string name)
        {
            return GetList()
                    .Any(a => a.Name == name);
        }
    }
}
