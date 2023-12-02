using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Entities.Concrete.Common;

namespace MovieApp.Entities.Concrete
{
    internal class Film : BaseEntity
    {
        public string FilmName { get; set; }
        public string FilmDescription { get; set; }
        public decimal IMDB { get; set; }
        public string PhotoUrl { get; set; }
        public string VideoUrl { get; set; }
        public string CoverUrl { get; set; }
        public string SeoUrl { get; set; }
        public int ViewCount { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public List<FilmGenre> FilmGenres { get; set; }
        public List<FilmActors> FilmActors { get; set; }

    }
}
