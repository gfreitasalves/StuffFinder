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
    public class BaseStorableController<T>  : BaseController where T : IStorable    
    {
        private readonly IStorableService<T> Service;
        public BaseStorableController(IStorableService<T> service)
        {
            Service = service;
        }
        /// <summary>
        /// Get all T itens
        /// </summary>
        /// <returns>IEnumerable<T></returns>
        [SwaggerResponse(200, "Sucesso")]
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll() => Ok(Service.Get());

        /// <summary>
        /// Get Specific T by id
        /// </summary>
        /// <param name="id">unique identifier</param>
        /// <returns>T</returns>
        [SwaggerResponse(200, "Sucesso")]
        [SwaggerResponse(400, "Não encontrado")]
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id) =>  Ok(Service.Get(id));

        /// <summary>
        /// Create an T
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>int</returns>
        [SwaggerResponse(200, "Sucesso")]
        [HttpGet]
        [Route("Create")]
        public IActionResult Create(T entity) => Ok(Service.Add(entity));
       
        /// <summary>
        /// Edit an existing stuff
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>bool</returns>
        [SwaggerResponse(200, "Sucesso")]
        [SwaggerResponse(400, "Não encontrado")]
        [HttpGet]
        [Route("Edit")]
        public IActionResult Edit(T entity) => Ok(Service.Update(entity));
        
        /// <summary>
        /// delete an existing T
        /// </summary>
        /// <param name="id"></param>
        /// <returns>bool</returns>
        [SwaggerResponse(200, "Sucesso")]
        [SwaggerResponse(400, "Não encontrado")]
        [HttpGet]
        [Route("Delete")]
        public IActionResult Delete(int id)=> Ok(Service.Delete(id));
        
    }
}
