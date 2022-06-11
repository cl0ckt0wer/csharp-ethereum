using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P.Enr
{
    public interface IEntry
    {
        Task<string?> ENRKey();
    }
}
