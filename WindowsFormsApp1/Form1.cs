using CustomerData;
using ElectricityBills;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //form-level declarations
        List<Customer> customers = new List<Customer>(); //create a new Customer list
        //
        decimal billTotal = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        //add a new customer to the list
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fname;
            string lname;
            decimal kwhUsed;
            Customer newCust;
            if (Validator.IsPresent(txtFname, "First Name") && Validator.IsPresent(txtLname, "Last Name")
                && Validator.IsNonNegativeDecimal(txtkWhUsed, "kWh Used")
                 && Validator.IsPresent(txtkWhUsed, "kWh Used")
                )
            {
                fname = txtFname.Text;
                lname = txtLname.Text;
                kwhUsed = Convert.ToDecimal(txtkWhUsed.Text);
                newCust = new Customer(fname, lname, kwhUsed,billTotal);
                customers.Add(newCust);

                DisplayCustomers();
            }


        }

        private void DisplayCustomers()         //display the customers data in the list box
            {
                lstCustomer.Items.Clear(); //start from empty
                foreach (Customer c in customers)
                    lstCustomer.Items.Add(c);

                //display stats


                txtTotalCustomers.Text = customers.Count.ToString(); //display the customers amount

                decimal kWhTotal = CalculateKWhTotal();
                txtTotalkWh.Text = kWhTotal.ToString("f");

                decimal averageBillAmount = CalculateAverageBill();
                txtAverageBill.Text = averageBillAmount.ToString("c"); //display average bill
            }
        //calculate the total number of kWh Used
        private decimal CalculateKWhTotal()
        {
            decimal total = 0;
            foreach (Customer c in customers)
                total += c.KWhUsed;
            return total;
        }
        //calculate the average bill of all customers
        private decimal CalculateAverageBill()
        {
            decimal total = 0;
            decimal ava = 0;
            foreach (Customer c in customers)
                total += c.BillTotal;
            if (customers.Count > 0)
                ava = total / customers.Count;
            return ava;
        }

        
        //clear the entries
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtkWhUsed.Text = "";
            txtBillAmount.Text = "";
            txtFname.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }
        //calculate the bill total and display
        private void btnBillCalculate_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsNonNegativeDecimal(txtkWhUsed, "kwhUser"))
            {
                billTotal = CalculateBillAmount();
                txtBillAmount.Text = billTotal.ToString("c"); //display bill 
            }
        }

        private decimal CalculateBillAmount()
        {
            const int adminFee = 12;
            const decimal rate = 0.07m;
            decimal kwhUsed = Convert.ToDecimal(txtkWhUsed.Text);
            decimal bill = adminFee * rate * kwhUsed;
            return bill;
        }

      
    }
}

