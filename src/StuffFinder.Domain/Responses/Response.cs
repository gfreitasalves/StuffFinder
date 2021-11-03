using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Responses
{
    public class Response<T>: IResponse
    {
        public Response()
        {
            _errors = new List<string>();
            Code = 200;
        }

        public Response(T entity)
        {
            Data = entity;
            Code = 200;
        }

        public Response(T entity, List<string> errors)
        {
            _errors = errors;
            Data = entity;
            Code = 500;
        }
        public int Code { get; set; }

        public T Data { get; set; }

        public string Message { get; set; }

        internal List<string> _errors;

        public IReadOnlyCollection<string> Errors => _errors;
    }
}
