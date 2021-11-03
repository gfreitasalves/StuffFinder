using System;
using System.Collections.Generic;
using System.Text;

namespace StuffFinder.Domain.Responses
{
    public class IResponse
    {
        int Code;
        string Message;
        IReadOnlyCollection<string> Errors;
    }
}
