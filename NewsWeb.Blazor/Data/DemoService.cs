using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsWeb.Blazor.Data
{
    public class DemoService
    {
        public Task<int> Ham()
        {
            return Task.FromResult(1);
        }
    }
}
