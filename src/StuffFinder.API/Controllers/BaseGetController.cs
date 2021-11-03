using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StuffFinder.Application.Services;
using StuffFinder.Domain.Repositories;
using StuffFinder.Domain.Responses;
using StuffFinder.Domain.Services;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuffFinder.API
{
    public class BaseGEtController<T, V> : BaseController where T : IStorable
    {
        private readonly IStorableService<T> Service;
        private readonly IMapper Mapper;

        public BaseGEtController(IStorableService<T> service, IMapper mapper)
        {
            Service = service;
            Mapper = mapper;
        }

        /// <summary>
        /// Get all T itens
        /// </summary>
        /// <returns>IEnumerable<T></returns>
        [SwaggerResponse(200, "Sucesso")]
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll() => Ok(Mapper.Map<IEnumerable<V>>(Service.Get().Data));

        /// <summary>
        /// Get Specific T by id
        /// </summary>
        /// <param name="id">unique identifier</param>
        /// <returns>T</returns>
        [SwaggerResponse(200, "Sucesso")]
        [SwaggerResponse(400, "Não encontrado")]
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id) => Ok(Mapper.Map<V>(Service.Get(id).Data));        
       
    }
}
