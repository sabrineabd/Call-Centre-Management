namespace Project
{
    partial class CallForm
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
            this.generateCall = new System.Windows.Forms.Button();
            this.callQueue = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.custServiceView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.callQueue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custServiceView)).BeginInit();
            this.SuspendLayout();
            // 
            // generateCall
            // 
            this.generateCall.Location = new System.Drawing.Point(38, 33);
            this.generateCall.Name = "generateCall";
            this.generateCall.Size = new System.Drawing.Size(106, 50);
            this.generateCall.TabIndex = 0;
            this.generateCall.Text = "Generate New Caller";
            this.generateCall.UseVisualStyleBackColor = true;
            // 
            // callQueue
            // 
            this.callQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.callQueue.Location = new System.Drawing.Point(21, 66);
            this.callQueue.Name = "callQueue";
            this.callQueue.Size = new System.Drawing.Size(252, 150);
            this.callQueue.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.callQueue);
            this.groupBox1.Location = new System.Drawing.Point(38, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 267);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caller Queue";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.custServiceView);
            this.groupBox2.Location = new System.Drawing.Point(478, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Service State";
            // 
            // custServiceView
            // 
            this.custServiceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custServiceView.Location = new System.Drawing.Point(29, 50);
            this.custServiceView.Name = "custServiceView";
            this.custServiceView.Size = new System.Drawing.Size(238, 182);
            this.custServiceView.TabIndex = 0;
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateCall);
            this.Name = "CallForm";
            this.Text = "Call Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.callQueue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custServiceView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateCall;
        private System.Windows.Forms.DataGridView callQueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView custServiceView;
    }
}

