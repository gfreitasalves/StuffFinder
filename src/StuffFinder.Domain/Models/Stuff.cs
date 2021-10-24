using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Models
{
    public class Stuff: BaseModel
    {
        public string Nome { get; set; }
        public int IdContainer { get; set; }
        public StuffContainer Container { get; set; }
    }
}
