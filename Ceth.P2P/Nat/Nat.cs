using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P.Nat
{
    // An implementation of nat.Interface can map local ports to ports
    // accessible from the Internet.
    public interface IInterface
    {
        // These methods manage a mapping between a port on the local
        // machine to a port that can be connected to from the internet.
        //
        // protocol is "UDP" or "TCP". Some implementations allow setting
        // a display name for the mapping. The mapping may be removed by
        // the gateway when its lifetime ends.
        Task<Exception?> AddMapping(string protocol, int extport, int intport, string name, TimeSpan duration);
        Task<Exception?> DeleteMapping(string protocol, int extport, int intport);
        // This method should return the external (Internet-facing)
        // address of the gateway device.
        Task<(IPAddress?, Exception?)> ExternalIP();
        // Should return name of the method. This is used for logging.
        Task<string> String();
    }
}
