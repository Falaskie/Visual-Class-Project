using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPay
{
    public class GCT
    {
       private double rate = 0.165;
        double CurrUsage = 0;
        double gross;
       

        public double GC(double usage, double Gross)
        {
            CurrUsage = usage;
            gross = Gross;
            if (CurrUsage < 150)
            {
                return 0.0;
            }
            else
            {
                return Math.Round((gross * rate), 2);
            }
            
        }

        
    }
}
