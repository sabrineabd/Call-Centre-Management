using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Caller : INotifyPropertyChanged
    {
        public string _callEnterTime = string.Empty;
        public int _callerNum = 0;
        public event PropertyChangedEventHandler PropertyChanged;

        public Caller(int num, string enterTime)
        {
            callerNum = num;
            callEnterTime = enterTime;
            
        }

        public string callEnterTime
        {
            get { return _callEnterTime; }
            set
            {
                _callEnterTime = value;
                OnPropertyChanged("callEnterTime");
            }
        }

        public int callerNum
        {
            get { return _callerNum; }
            set
            {
                _callerNum = value;
                OnPropertyChanged("callerNum");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }

}
