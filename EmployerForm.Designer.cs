namespace Project
{
    partial class EmployerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeList = new System.Windows.Forms.CheckedListBox();
            this.submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeList);
            this.groupBox1.Location = new System.Drawing.Point(117, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select which employees are working today";
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.Location = new System.Drawing.Point(101, 30);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(254, 214);
            this.employeeList.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(310, 375);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(79, 42);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployerForm";
            this.Text = "Employer Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox employeeList;
        private System.Windows.Forms.Button submit;
    }
}