using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Entities.Concrete
{
    internal class FilmActors
    {
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
    }
}
