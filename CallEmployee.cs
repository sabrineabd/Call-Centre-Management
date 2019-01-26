using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Project
{
    public class CallEmployee : INotifyPropertyChanged
    {
        public string Name { get; set;}
        public string _state;

        public event PropertyChangedEventHandler PropertyChanged;


        public CallEmployee(string name)
        {
            Name = name;
            State = "Free";
        }

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged("State");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
