using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class EmployerForm : Form
    {
        public BindingSource source = new BindingSource();
        public EmployerForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            submit.Click += new EventHandler(Submit_Click);
            source.DataSource = ViewModel.allEmployees;
            employeeList.DataSource = source;

        }

        public void Submit_Click(object sender, EventArgs e)
        {
            List<string> list = employeeList.CheckedItems.OfType<string>().ToList(); //list of checked employees
            ViewModel.generateWorkingEmployees(list); //sending information to ViewModel

            openNextForm(); 
           
        }

        public void openNextForm()
        {
            Hide();
            var callForm = new CallForm();
            callForm.Closed += (s, args) => Close();
            callForm.Show();
        }
    }
}
