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
        int Usage = 0;

        public double GCT(int usage)
        {
            Usage = usage;

            return rate * Usage;
        }

        
    }
}
