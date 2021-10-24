using StuffFinder.Domain.Repositories;
using System;

namespace StuffFinder.Domain.Models
{
    public class BaseModel : IStorable
    {
        public int? Id { get; set; }
    }
}
