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
    [Route("api/v1/stuffContainer")]
    public class StuffContainerController : BaseStorableController<StuffContainer>
    {       
        public StuffContainerController(IStuffContainerService service):base(service)
        {
        }
        
    }
}
