using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPay
{
    public class BeforeTax
    {
        double Subtotal = 0.0;
        double FEAdjust = 0.0;
        double FuelIPP = 0.0;
        double result = 0.0;
        public double BeforeTa(double subtotal, double fEAdjust, double fuelIPP)
        {
            Subtotal = subtotal;
            FEAdjust = fEAdjust;
            FuelIPP = fuelIPP;

            result = Subtotal + FEAdjust + FuelIPP;
            
            return result; 
        }   
    }
}
