using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Calculator
{
    public delegate T Formula<T>(T num1, T num2);
    internal class CalculatorClass
    {
        
        public Formula<double> formula;

        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetDifference(double x, double y)
        {
            return x - y;
        }
        public double GetProduct(double x, double y)
        {
            return x * y;
        }
        public double GetQuotient(double x, double y)
        {
            return x / y;
        }
        public event Formula<double> CalculateEvent
        {
            add
            {
                MessageBox.Show("Added the Delegate: " + value);
                formula += value;
            }
            remove
            {
                MessageBox.Show("Removed the Delegate: " + value);
                formula -= value;
            }
        }
    }
}
