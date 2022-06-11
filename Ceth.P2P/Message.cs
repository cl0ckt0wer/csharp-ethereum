using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceth.P2P
{
    public class Msg
    {
        public UInt64 Code { get; set; }
        public UInt32 Size { get; set; }
        public Stream? Payload { get; set; }
        public DateTime Time { get; set; }
        public Cap? MeterCap { get; set; }
        public UInt64 MeterCode { get; set; }
        public UInt32 MeterSize { get; set; }
    }
    public interface IMsgReadWriter
    {
        IMsgReader MsgReader { get; set; }
        IMsgWriter MsgWriter { get; set; }
    }
    public interface IMsgReader
    {
        Task<(Msg?, Exception?)> ReadMsg();
    }
    public interface IMsgWriter
    {
        Task<Exception?> WriteMsg(Msg msg);
    }
    
}
