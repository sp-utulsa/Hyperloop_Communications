using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace JaimesHelloWorld
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    struct TelemetryFrame
    {
        public byte teamid;
        public byte status;
        public int accel;
        public int position;
        public int velocity;
        public int voltage;
        public int current;
        public int batteryTemp;
        public int podTemp;
        public UInt32 stripeCount;
    }

    public class Transport
    {

    }
}
