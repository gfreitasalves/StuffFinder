using Microsoft.AspNetCore.Mvc;
using StuffFinder.Application.Services;
using StuffFinder.Domain.Models;
using StuffFinder.Domain.Services;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuffFinder.API
{    
    [Route("api/v1/stuff")]
    public class StuffController : BaseStorableController<Stuff>
    {
        public StuffController(IStuffService service) : base(service)
        {
        }
    }
}
