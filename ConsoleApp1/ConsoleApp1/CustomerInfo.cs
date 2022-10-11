using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPay
{
    public class CustomerInfo
    {
      public string FirstName  {get; set;}
      public string LastName  { get; set ;}
      public string AccNum { get; set; }
      public string PremNum  {get; set;}
      public string DueDate { get; set; }
      public string Address { get; set; }  

       public CustomerInfo()
        {

        }

    }
}
