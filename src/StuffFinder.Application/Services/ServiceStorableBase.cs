using StuffFinder.Application.Filters;
using StuffFinder.Domain.Repositories;
using StuffFinder.Domain.Responses;
using StuffFinder.Domain.Services;
using StuffFinder.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffFinder.Application.Services
{
    /// <summary>
    /// Provides a base class for storable services which implements the storable functions.
    /// </summary>
    /// <typeparam name="T">A type of any object that implements <see cref="IStorable"/></typeparam>
    public abstract class ServiceStorableBase<T> : IStorableService<T> where T : IStorable, IModelValidator<T>
    {
        /// <summary>
        /// An instance of <see cref="IRepository{T}"/> that contains the methods exposed to manipulate the <see cref="IStorable"/> instance repository.
        /// </summary>
        protected readonly IRepository<T> Repository;

        /// <summary>
        /// Initialize an instance of <see cref="ServiceStorableBase{T}"/>.
        /// </summary>
        /// <param name="repository">An instance of <see cref="IRepository{T}"/>.</param>
        protected ServiceStorableBase(IRepository<T> repository) => Repository = repository;

        /// <inheritdoc />
        public virtual Response<int> Add(T entity)
        {
            var response = new Response<int>();

            var responseValid = entity.Validate();

            if (responseValid.Entity)
            {
                response = new Response<int>() { Entity = Repository.AddOrUpdate(entity) };
            }

            return response;
        }

        /// <inheritdoc />
        public virtual Response<bool> Update(T entity) {
            var response = new Response<bool>();

            var responseValid = entity.Validate();

            if (responseValid.Entity)
            {
                response = new Response<bool>() { Entity = Repository.AddOrUpdate(entity) == entity.Id };
            }

            return response;
        }

        /// <inheritdoc />
        public virtual Response<IEnumerable<T>> Get() => new Response<IEnumerable<T>>() { Entity = Repository.Get() };

        /// <inheritdoc />
        public virtual Response<T> Get(int id) => GetById(id);


        /// <inheritdoc />
        public virtual Response<bool> Delete(int id) => new Response<bool>() { Entity = Repository.Delete(customer => customer.IsId(id)) == 1 };

        /// <summary>
        /// Filter the repository to select a <see cref="Customer"/> using the identifier.
        /// </summary>
        /// <param name="id">The <see cref="Customer"/> identifier to search.</param>
        /// <returns>The <see cref="Customer"/> that matched with the identifier requested.</returns>
        protected Response<T> GetById(int id) => new Response<T>() { Entity = Repository.Get(customer => customer.IsId(id)).FirstOrDefault() };
    }
}
