using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SchmittAssignment2
{
    internal class Employee
    {
        //consts
        private const double FederalRate = 0.18;
        private const double SSRate = 0.10;
        private const double RetirementRate = 0.10;

        //propreties
        internal double Federal { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set;}

        internal string Name { get { return FirstName + " " + LastName;  } }
        internal double Retirement { get; private set; }
        internal double Sales { get; set; }
        internal double SS { get; private set; }

        internal Employee(string fName, string lName, double sales)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Sales = sales;
        }

        internal double CalculateCommissionIncome()
        {
            return Sales * 0.07;
        }

        internal void CalculateFederal(double totalSales)
        {
            Federal = totalSales * FederalRate;
        }

        internal void CalculateSS(double totalSales)
        {
            SS = totalSales * SSRate;
        }

        internal void CalculateRetirement(double totalSales)
        {
            Retirement = totalSales * RetirementRate;
        }

        internal void CalculateWithholdings(double salesIncome)
        {
            CalculateFederal(salesIncome);
            CalculateSS(salesIncome);
            CalculateRetirement(salesIncome);
        }

        public override string ToString()
        {
            double income = CalculateCommissionIncome();
            Console.Write(income);

            CalculateWithholdings(income);

            StringBuilder sb = new StringBuilder();
            sb.Append("\nEmployee Name:\t\t\t").Append(Name).Append("\n");
            sb.Append("\nEmployee Gross Income:\t\t" + string.Format("{0:C0}", income));
            sb.Append("\nFederal Tax Widtheld:\t\t" + string.Format("{0:C0}", Federal));
            sb.Append("\nSocial Security Witheld:\t" + string.Format("{0:C0}", SS));
            sb.Append("\nRetirement Contributions:\t" + string.Format("{0:C0}", Retirement));
            sb.Append("\n\nEmployee Net Pay:\t\t" + string.Format("{0:C0}", income - Federal - SS - Retirement));

            return sb.ToString();
        }
    }
}
