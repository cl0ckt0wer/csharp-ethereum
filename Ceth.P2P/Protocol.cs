using Ceth.P2P.Enr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P
{
    // Protocol represents a P2P subprotocol implementation.
    public class Protocol
    {
        // Name should contain the official protocol name,
        // often a three-letter word.
        public string? Name { get; set; }
        // Version should contain the version number of the protocol.
        public uint Version { get; set; }
        // Length should contain the number of message codes used
        // by the protocol.
        public UInt64 Length { get; set; }
        // Run is called in a new goroutine when the protocol has been
        // negotiated with a peer. It should read and write messages from
        // rw. The Payload for each message must be fully consumed.
        //
        // The peer connection is closed when Start returns. It should return
        // any protocol-level error (such as an I/O error) that is
        // encountered.
        public Func<Peer, IMsgReadWriter, Exception?>? Run;
        // NodeInfo is an optional helper method to retrieve protocol specific metadata
        // about the host node.
        public Action? NodeInfo;
        // PeerInfo is an optional helper method to retrieve protocol specific metadata
        // about a certain peer in the network. If an info retrieval function is set,
        // but returns nil, it is assumed that the protocol handshake is still running.
        public Func<Enode.ID>? PeerInfo;
        // DialCandidates, if non-nil, is a way to tell Server about protocol-specific nodes
        // that should be dialed. The server continuously reads nodes from the iterator and
        // attempts to create connections to them.
        public IEnumerable<Enode.Node>? DialCandidates;
        // Attributes contains protocol specific information for the node record.

        public IEntry? Attributes { get; set; }
    }
    public class Cap
    {
        public string? Name { get; set; }
        public uint Version { get; set; }

    }
}
