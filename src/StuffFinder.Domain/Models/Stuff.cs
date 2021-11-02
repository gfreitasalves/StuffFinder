using StuffFinder.Domain.Responses;
using StuffFinder.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Models
{
    public class Stuff : BaseValidateModel<StuffValidator, Stuff>, IModelValidator<Stuff>
    {
        public Stuff()
        {

        }
        public Stuff(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }
        public int IdContainer { get; set; }
        public StuffContainer Container { get; set; }
    }
}
