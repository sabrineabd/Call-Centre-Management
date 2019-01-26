using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;

namespace Project
{
    public partial class CallForm : Form
    {
        public BindingSource employeeSource = new BindingSource();
        public ViewModel vm = new ViewModel(); 

        public CallForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            custServiceView.CellFormatting += new DataGridViewCellFormattingEventHandler(custServiceViewCellFormatting);
            generateCall.Click += new EventHandler(generateCall_Click);

            employeeSource.DataSource = ViewModel.workingEmployees;
            custServiceView.DataSource = employeeSource;

            callQueue.DataSource = updateCallerView();
            vm.PropertyChanged += PropertyChangedHandler; 

        }


        private void generateCall_Click(object sender, EventArgs e)
        {
           vm.generateCall();
        }

        //styling customer service view state cells 
        private void custServiceViewCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (custServiceView.Columns[e.ColumnIndex].Name == "State")
            {
                e.CellStyle.BackColor = (e.Value.ToString() == "Busy") ? Color.Red : Color.Green;
                e.FormattingApplied = true;
            }
        }


     
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => PropertyChangedHandler(sender, e))); return;
            }

            switch(e.PropertyName){
                case "callerList" : callQueue.DataSource = updateCallerView(); break;
            }
            
        }

        /* this method adds columns / rows to datagridview callQueue with
            the most recent caller list information */
        private DataTable updateCallerView()
        {
            List<Caller> list = vm.callerList;
            DataTable table = new DataTable();
            string[] colNames = { "Call Enter Time", "Caller #" };

            int columns = 2;
            // add columns & set column names
            for (int i = 0; i < columns; i++)
            {
                var col = table.Columns.Add();
                col.ColumnName = colNames[i];
            }

            // add rows
            foreach (var caller in list)
            {
                table.Rows.Add(caller.callEnterTime, caller.callerNum);
            }

            Invalidate();

            return table; //returns up-to-date table

        }



    }



}
