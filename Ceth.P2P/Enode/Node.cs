using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ceth.P2P.Enr.Enr;

namespace Ceth.P2P.Enode
{
    // Node represents a host on the network.

    public class Node
    {
        public Record R { get; set; }
        public byte[]? ID { get; set; }
    }
    // ID is a unique identifier for each node.

    public class ID {
        public byte[]? Value { get; set; }
    }

}
