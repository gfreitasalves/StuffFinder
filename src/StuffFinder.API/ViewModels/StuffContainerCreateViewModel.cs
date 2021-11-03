using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuffFinder.API.ViewModels
{
    public class StuffContainerCreateViewModel
    {
        public string Name { get; set; }
        public int? IdInsideOfContainer { get; set; }
    }
}
