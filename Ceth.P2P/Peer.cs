using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P
{
    public class Peer
    {
        public int MyProperty { get; set; }
    }
    // protoHandshake is the RLP structure of the protocol handshake.
    public class ProtoHandshake
    {
        public UInt64 Version { get; set; }
        public string? Name { get; set; }
        public Cap[]? Caps { get; set; }
        public UInt64  ListenPort { get; set; }
        public byte[]? ID { get; set; }// secp256k1 public key
                                       // Ignore additional fields (for forward compatibility).
        public byte[]? RawValue { get; set; }
    }
}
