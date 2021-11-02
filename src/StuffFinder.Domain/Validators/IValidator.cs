using FluentValidation;
using StuffFinder.Domain.Models;
using StuffFinder.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Validators
{
    public interface IModelValidator<T>
    {
        Response<bool> Validate();
    }
}
