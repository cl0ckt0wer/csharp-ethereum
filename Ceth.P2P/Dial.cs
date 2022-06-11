using Ceth.P2P.Enode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P
{
    public interface NodeDialer
    {
        public Task<(Socket?, Exception?)> Dial(object obj, Node node);
    }
}
