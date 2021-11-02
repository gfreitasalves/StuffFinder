using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Responses
{
    public class Response<T>
    {
        public Response()
        {
            _errors = new List<string>();
        }

        public Response(T entity)
        {
            Entity = entity;
        }

        public Response(T entity, List<string> errors)
        {
            _errors = errors;
            Entity = entity;
        }
        public T Entity { get; set; }

        public string Message { get; set; }

        internal List<string> _errors;

        public IReadOnlyCollection<string> Errors => _errors;
    }
}
