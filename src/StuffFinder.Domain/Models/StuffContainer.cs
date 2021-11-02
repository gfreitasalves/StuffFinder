using StuffFinder.Domain.Repositories;
using StuffFinder.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Models
{
    public class StuffContainer : BaseValidateModel<StuffContainerValidator, StuffContainer>, IModelValidator<StuffContainer>
    {
        public StuffContainer()
        {

        }

        public StuffContainer(string name, Stuff stuff)
        {
            Name = name;
            Stuffs = new List<Stuff>();
            Stuffs.Add(stuff);
        }

        public string Name { get; set; }
        public int? IdInsideOfContainer { get; set; }
        public StuffContainer InsideOfContainer { get; set; }
        public ICollection<Stuff> Stuffs { get; set; }
        public ICollection<StuffContainer> Containers { get; set; }

    }
}
