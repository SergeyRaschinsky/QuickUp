using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services.Contracts
{
    public interface IValuesService
    {
        IEnumerable<int> GetValues();
    }
}
