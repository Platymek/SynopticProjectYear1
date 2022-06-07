using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SynopticProject2
{
    public interface LocationInteface
    {
        Task<decimal[]> getNearestLocationAsync();
    }
}
