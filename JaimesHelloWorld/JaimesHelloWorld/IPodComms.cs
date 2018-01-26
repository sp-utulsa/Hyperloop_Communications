using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaimesHelloWorld
{
    public interface IPodComms
    {
        bool IsConnected { get;}
        double Position { get; set; }
        bool MotorIsRunning { get; }
        void StartPump();
        void StopPump();
    }
}
