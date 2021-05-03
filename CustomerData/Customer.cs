using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        private int code;
        private decimal kWhUsed;
        private decimal billTotal;

        private static int nextCode = 1;

        public string Fname { get; set; }
        public string Lname { get; set; }

        public decimal KWhUsed
        {
            get { return kWhUsed; }
            set
            {
                if (value >= 0)
                    kWhUsed = value;
                else kWhUsed = 0;
            }
        }

        public decimal BillTotal
        {
            get { return billTotal; }
        }

      
        public Customer(string fn="Unknown", string ln="Unknown", decimal n = 0.0m, decimal b = 0.0m)
        {
            code = nextCode;
            nextCode++;
            Fname = fn;
            Lname = ln;
            kWhUsed = n;
            billTotal = b;

        }


        //override ToString

        public override string ToString()  //set the format of customer data displayed in the listbox
        {
            return code.ToString() + ":" + Fname + " " + Lname + "," + kWhUsed.ToString("f") + "," + billTotal.ToString("f");
        }









    }




}
