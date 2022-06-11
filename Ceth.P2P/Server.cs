using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Ceth.P2P.Enode;
using static Ceth.Netutil.Net;
using System.Net.Sockets;
using Ceth.P2P.Nat;
using Microsoft.Extensions.Logging;

namespace Ceth.P2P
{
    public class Config
    {
         public CngKey? PrivateKey { get; set; }
        public int MaxPeers { get; set; }
        public int MaxPendingPeers { get; set; }
        public int DialRatio { get; set; }
        public bool NoDiscovery { get; set; }
        public bool DiscoveryV5 { get; set; }
        public string? Name { get; set; }
        public Node[]? BootstrapNodes { get; set; }
        public Node[]? BootstrapNodesV5 { get; set; }
        public Node[]? StaticNodes { get; set; }
        public Node[]? TrustedNodes { get; set; }
        public IPNet[]? NetRestrict { get; set; }
        public string? NodeDatabase { get; set; }
        // Protocols should contain the protocols supported
        // by the server. Matching protocols are launched for
        // each peer.
        public Protocol[]? Protocols { get; set; }
        // If ListenAddr is set to a non-nil address, the server
        // will listen for incoming connections.
        //
        // If the port is zero, the operating system will pick a port. The
        // ListenAddr field will be updated with the actual address when
        // the server is started.
        public string? ListenAddr { get; set; }
        // If set to a non-nil value, the given NAT port mapper
        // is used to make the listening port available to the
        // Internet.
        public  IInterface? NAT { get; set; }
        // If Dialer is set to a non-nil value, the given Dialer
        // is used to dial outbound peer connections.
        public NodeDialer? Dialer { get; set; }
        // If NoDial is true, the server will not dial any peers.
        public bool NoDial { get; set; }
        // If EnableMsgEvents is set then the server will emit PeerEvents
        // whenever a message is sent to or received from a peer
        public bool EnableMsgEvents { get; set; }
        // Logger is a custom logger to use with the p2p.Server.
        public ILogger? Logger { get; set; }

    }
    public class Conn
    {
        public Socket? Fd { get; set; }
        public Transport? Transport { get; set; }
    }
    public interface Transport
    {
        Task<(CngKey?, Exception?)> DoEncHandshake(CngKey privateKey);
        Task<(ProtoHandshake?, Exception?)> DoProtoHandshake(ProtoHandshake our); 
        public IMsgReadWriter? MsgReadWriter { get; set; }
        Task Close(Exception exception);
    }
}
