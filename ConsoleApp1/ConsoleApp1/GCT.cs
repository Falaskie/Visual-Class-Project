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
        int CurrUsage = 0;

       

        public double GC(int usage)
        {
            CurrUsage = usage;
            if (CurrUsage > 150)
            {
                return Math.Round((CurrUsage * 0.165), 2);
            }
            else
            {
                return 0.0;
            }
            
        }

        
    }
}
