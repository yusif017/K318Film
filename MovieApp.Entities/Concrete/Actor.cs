using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Entities.Concrete.Common;

namespace MovieApp.Entities.Concrete
{
    internal class Actor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhotoUrl { get; set; }

        public List<FilmActors>  FilmActors{ get; set; }
    }
}
