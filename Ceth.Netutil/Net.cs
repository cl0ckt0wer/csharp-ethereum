using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.Netutil
{
    public class Net
    {
        public class IPNet
        {
            public IPAddress[]? IP { get; set; }
            public byte[]? IPMask { get; set; }
        }
    }
}
