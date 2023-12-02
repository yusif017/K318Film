using MovieApp.Entities.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}