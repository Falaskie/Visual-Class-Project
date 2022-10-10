using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPay
{
    public class EarlyPay
    {
        public EarlyPay()
        {

        }
        public int Early()
        {
            string Ans = Console.ReadLine();

            if (Ans == "Y" || Ans == "y")
            {
                return -250;
            }
            else
            {
                return 0;
            }
        }
    }
}
