using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StuffFinder.API.ViewModels;
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
    public class StuffController : BaseGEtController<Stuff, StuffEditViewModel>
    {

        private readonly IStuffService Service;
        private readonly IMapper Mapper;

        public StuffController(IStuffService service, IMapper imapper) : base(service, imapper)
        {
            Service = service;
            Mapper = imapper;
        }

        /// <summary>
        /// Create an T
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>int</returns>
        [SwaggerResponse(200, "Sucesso")]
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(StuffCreateViewModel entity) => Ok(Service.Add(Mapper.Map<Stuff>(entity)).Data);

        /// <summary>
        /// Edit an existing stuff
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool</returns>
        [SwaggerResponse(200, "Sucesso")]
        [SwaggerResponse(400, "Não encontrado")]
        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit(StuffEditViewModel entity) => Ok(Service.Update(Mapper.Map<Stuff>(entity)).Data);

        /// <summary>
        /// delete an existing T
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        [SwaggerResponse(200, "Sucesso")]
        [SwaggerResponse(400, "Não encontrado")]
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id) => Ok(Service.Delete(id).Data);
    }
}
