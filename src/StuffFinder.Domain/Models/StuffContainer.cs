using StuffFinder.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Models
{
    public class StuffContainer : BaseModel
    {

        public int? IdInsideOfContainer { get; set; }
        public StuffContainer InsideOfContainer { get; set; }
        public ICollection<Stuff> Stuff { get; set; }
        public ICollection<StuffContainer> Containers { get; set; }

    }
}
