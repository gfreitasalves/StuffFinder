using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Models
{
    public class Stuff: BaseModel
    {
        public Stuff()
        {

        }
        public Stuff(int id ,string nome)
        {
            Id = id;
            Nome = nome;
        }
        public string Nome { get; set; }
        public int IdContainer { get; set; }
        public StuffContainer Container { get; set; }
    }
}
