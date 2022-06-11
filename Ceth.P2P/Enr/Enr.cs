using Ceth.P2P.Rlp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P.Enr
{
    public class Enr
    {
        public struct Record
        {
            public UInt64 Seq { get; set; }
            public byte[] Signature { get; set; }
            public byte[] Raw { get; set; }
            public Pair Pairs { get; set; }

        }
        public struct Pair
        {
            public string? K { get; set; }
            public byte[] RawValue { get; set; }
        }
    }
}
