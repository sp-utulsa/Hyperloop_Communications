using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SimpleMvvmToolkit;

namespace JaimesHelloWorld
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            _PodComms = new MockPodComms();
            _StartPumpCommand = new DelegateCommand(new Action(() =>
            {
                PodComms.StartPump();

            }),new Func<bool>(() => 
            {
                return PodComms.IsConnected;//changed from true to isconnected
            }));
            //new 1/25
            _StopPumpCommand = new DelegateCommand(new Action(() =>
            {
                PodComms.StopPump();
            }), new Func<bool>(() =>
             {
                 return PodComms.IsConnected;//changed from true to isconnected
             }));
        }

        private IPodComms _PodComms;
        public IPodComms PodComms
        {
            get { return _PodComms; }
            set { _PodComms = value; }
        }

        private ICommand _StartPumpCommand;
        public ICommand StartPumpCommand
        {
            get { return _StartPumpCommand; }
        }

        //new addition 1/25-stop pump
        private ICommand _StopPumpCommand;
        public ICommand StopPumpCommand
        {
            get { return _StopPumpCommand; }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
