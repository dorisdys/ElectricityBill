
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnBillCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkWhUsed = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCustomers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalkWh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAverageBill = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBillCalculate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBillAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtkWhUsed);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbLname);
            this.groupBox1.Controls.Add(this.lbFname);
            this.groupBox1.Location = new System.Drawing.Point(56, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter New Customer";
            // 
            // btnBillCalculate
            // 
            this.btnBillCalculate.Location = new System.Drawing.Point(54, 207);
            this.btnBillCalculate.Name = "btnBillCalculate";
            this.btnBillCalculate.Size = new System.Drawing.Size(245, 48);
            this.btnBillCalculate.TabIndex = 9;
            this.btnBillCalculate.Text = "Calculate the bill";
            this.btnBillCalculate.UseVisualStyleBackColor = true;
            this.btnBillCalculate.Click += new System.EventHandler(this.btnBillCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(205, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 50);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(44, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(178, 264);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(142, 35);
            this.txtBillAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bill Amount";
            // 
            // txtkWhUsed
            // 
            this.txtkWhUsed.Location = new System.Drawing.Point(178, 159);
            this.txtkWhUsed.Name = "txtkWhUsed";
            this.txtkWhUsed.Size = new System.Drawing.Size(142, 35);
            this.txtkWhUsed.TabIndex = 5;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(178, 100);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(142, 35);
            this.txtLname.TabIndex = 4;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(178, 39);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(142, 35);
            this.txtFname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "kWh Used";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.Location = new System.Drawing.Point(41, 100);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(128, 29);
            this.lbLname.TabIndex = 1;
            this.lbLname.Text = "Last Name";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Location = new System.Drawing.Point(38, 39);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(131, 29);
            this.lbFname.TabIndex = 0;
            this.lbFname.Text = "First Name";
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 29;
            this.lstCustomer.Location = new System.Drawing.Point(443, 55);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(336, 381);
            this.lstCustomer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "No. of Customers";
            // 
            // txtTotalCustomers
            // 
            this.txtTotalCustomers.Location = new System.Drawing.Point(375, 472);
            this.txtTotalCustomers.Name = "txtTotalCustomers";
            this.txtTotalCustomers.ReadOnly = true;
            this.txtTotalCustomers.Size = new System.Drawing.Size(202, 35);
            this.txtTotalCustomers.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total kWh used";
            // 
            // txtTotalkWh
            // 
            this.txtTotalkWh.Location = new System.Drawing.Point(375, 527);
            this.txtTotalkWh.Name = "txtTotalkWh";
            this.txtTotalkWh.ReadOnly = true;
            this.txtTotalkWh.Size = new System.Drawing.Size(202, 35);
            this.txtTotalkWh.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 574);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Average bill amount";
            // 
            // txtAverageBill
            // 
            this.txtAverageBill.Location = new System.Drawing.Point(375, 585);
            this.txtAverageBill.Name = "txtAverageBill";
            this.txtAverageBill.ReadOnly = true;
            this.txtAverageBill.Size = new System.Drawing.Size(202, 35);
            this.txtAverageBill.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAverageBill);
            this.Controls.Add(this.txtTotalkWh);
            this.Controls.Add(this.txtTotalCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstCustomer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkWhUsed;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalkWh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAverageBill;
        private System.Windows.Forms.Button btnBillCalculate;
    }
}

