using FluentValidation;
using StuffFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Validators
{
    public class StuffValidator: AbstractValidator<Stuff>
    {
        public StuffValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A Entidade não pode ser vazia");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O Nome não pode ser vazio");
        }
    }
}
