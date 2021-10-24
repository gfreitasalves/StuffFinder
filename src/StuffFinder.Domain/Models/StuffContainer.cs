using StuffFinder.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Models
{
    public class StuffContainer : BaseModel
    {
        public StuffContainer(string nome, Stuff stuff)
        {
            Nome = nome;
            Stuffs = new List<Stuff>();
            Stuffs.Add(stuff);
        }
        public string Nome { get; set; }
        public int? IdInsideOfContainer { get; set; }
        public StuffContainer InsideOfContainer { get; set; }
        public ICollection<Stuff> Stuffs { get; set; }
        public ICollection<StuffContainer> Containers { get; set; }

    }
}
