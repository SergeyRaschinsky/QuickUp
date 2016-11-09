using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Exceptions
{
    public class ValidationException : Exception
    {
        public string Name { get; set; }

        public ValidationException(string name, string message) : base(message)
        {
            Name = name;
        }
    }
}
