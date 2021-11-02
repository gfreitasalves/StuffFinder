using FluentValidation;
using StuffFinder.Domain.Repositories;
using StuffFinder.Domain.Responses;
using StuffFinder.Domain.Validators;
using System;
using System.Linq;

namespace StuffFinder.Domain.Models
{
    public class BaseValidateModel<T,M> : BaseModel where T : AbstractValidator<M>,new() where M : BaseValidateModel<T,M>, new()
    {
        public Response<bool> Validate()
        {   
            var validator = new T();

            var result =  validator.Validate(((M)this));

            var errors = result.Errors.Select(r => r.ErrorMessage).ToList();

            var response = new Response<bool>(result.IsValid,errors);

            return response;
        }
    }
}
