using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace JaimesHelloWorld
{
    public class MockPodComms : IPodComms, INotifyPropertyChanged
    {
        public MockPodComms()
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Elapsed += tmr_Elapsed;
            tmr.Start();
        }

        void tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            IsConnected = !IsConnected;
            
        }

        public void StartPump()
        {
            MotorIsRunning = true;
        }

        public void StopPump()
        {
            MotorIsRunning = false;
        }
        

        private bool _IsConnected = false;
        public bool IsConnected
        {
            get { return _IsConnected; }
            private set
            {
                if (_IsConnected != value)
                {
                    _IsConnected = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("IsConnected"));
                }
            }
        }

        private bool _MotorIsRunning = false;
        public bool MotorIsRunning
        {
            get { return _MotorIsRunning; }
            private set
            {
                if (_MotorIsRunning != value)
                {
                    _MotorIsRunning = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("MotorIsRunning"));
                }
            }
        }

        private double _Position;
        public double Position
        {
            get { return _Position; }
            set 
            { 
                if (_Position != value)
                {
                    _Position = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Position"));
                }
            }
        }
        


   

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
