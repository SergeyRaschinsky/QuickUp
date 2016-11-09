using System.Collections.Generic;
using WebApplication1.Services.Contracts;

namespace WebApplication1.Services
{
    public class ValuesService : IValuesService
    {
        private readonly List<int> _values = new List<int> { 1, 2, 3, 4, 5 };

        public ValuesService()
        {
        }

        public IEnumerable<int> GetValues()
        {
            return _values;
        }
    }
}
