using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Entities.Concrete.Common;

namespace MovieApp.Entities.Concrete
{
    internal class FilmGenre : BaseEntity
    {
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
