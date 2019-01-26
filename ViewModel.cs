using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Project
{
    public class ViewModel : INotifyPropertyChanged
    {
        //EMPLOYER FORM
        public readonly List<string> allEmployees = new List<string>(){ "Jessica Smith", "James Lee", "Abdul Rahman", "José Hernandez",
            "Nancy Thornton", "Harry Cooke" , "Jaxon Lambert" , "Anderson Castaneda", "Kyler Oneal", "Lamar Cohen", "Nola Zhang", "Mathias Gilbert"};
        public static BindingList<CallEmployee> workingEmployees = new BindingList<CallEmployee>();

        //CALL FORM
        public List<Caller> callerList;
        public static int callerCount = 0;
        public static SynchronizationContext SynchronizationContext;
        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            SynchronizationContext = SynchronizationContext.Current;
            callerList = new List<Caller>(); 
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    /*========================================== EMPLOYER FORM ===============================================================*/

        public static void generateWorkingEmployees(List<string> list)
        {
            foreach(var name in list)
            {
                workingEmployees.Add(new CallEmployee(name));
            }
        }



        /*============================================= CALL FORM ================================================================*/

        public void generateCall()
        {
            bool callAnswered = false;
            
            //hand call over to an employee if there's a free employee
            foreach(var employee in workingEmployees)
            {
                if(employee.State == "Free")
                {
                    startCall(employee);
                    callAnswered = true;
                    break;
                }
            }

            //if all employees are busy, put on waiting list
            if (!callAnswered)
            {
                addToWaitingList();
            }
        }


        private void addToWaitingList()
        {
            //create new caller and add to waiting list
            var time = DateTime.Now;
            string callTime = time.Hour.ToString() + ":" + time.Minute.ToString() + ":" + time.Second.ToString();

            callerList.Add(new Caller(++callerCount, callTime));
            OnPropertyChanged("callerList"); //list has been updated

        }

        private void startCall(CallEmployee employee)
        {
            employee.State = "Busy";

            Random r = new Random();
            int callLength = r.Next(5, 7); //produces a call length

            Task.Delay(callLength*1000).ContinueWith(t => endCall(employee));
        }


        private void endCall(CallEmployee employee)
        {
            employee.State = "Free";
            Task.Delay(1000).ContinueWith(t => takeNextCall(employee));
        }

        private void takeNextCall(CallEmployee employee)
        {
            //employee takes next call if there are callers waiting
            if (callerList.Any())
            {
                callerList.RemoveAt(0);
                OnPropertyChanged("callerList"); //list has been updated
                startCall(employee);
            }
            else
            {
                callerCount = 0;
            }

        }

       


    }
}
