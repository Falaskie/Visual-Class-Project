// See https://aka.ms/new-console-template for more information
using BillPay;

Console.WriteLine("Welcome to the Bill Payment System");

//Variables
int CurrRead = 0, PrevRead = 0, CustCharge = 455, Early = 0;
double PrevBal = 0.0, Payments = 0.0, BalBroFor = 0.0, CurrChar = 0.0, TotAmDue = 0.0, dCurrUsage = 0.0,
    Taxes = 0.0, Rate = 9.66, EarlyDis = 250.00, CurrUsage = 0.0, CurrPeriChar = 0.0, FuelRate = 0.0, GCTcharge = 0.0,
    Subtotal = 0.0, FuelIPP = 0.0, FEAdjust = 0.0, Gross = 0.0;

Console.SetWindowSize(100, 40);
BeforeTax beforeTax = new BeforeTax();
GCT GCT = new GCT();
EarlyPay Early1 = new EarlyPay();
CustomerInfo customer = new CustomerInfo();


//Entering of informations

Console.WriteLine("Please enter customer's current meter reading");
CurrRead = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter the pervious meter reading.");
PrevRead = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter current usage rate");
CurrUsage = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Fuel Adjustment Rate");
FuelRate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Was last Bill paid early or on due date? Enter 'Y' for yes, and 'N' for No");
Early = Convert.ToInt32(Early1.Early());


dCurrUsage = CurrUsage;



//Customer Information
customer.FirstName = "Delawna ";
customer.LastName = "Brown ";
customer.AccNum = " 0010310010";
customer.PremNum = " 450";
customer.DueDate = " Due Date: October 25,2022";
customer.Address = " May Pen, May Pen P.O. Clarendon";


//Calculations
CurrPeriChar = CurrUsage * Rate;
CurrChar = CurrUsage * Rate;
Subtotal = CurrPeriChar + CustCharge;
FuelIPP = CurrUsage * 21.794;
FEAdjust = Subtotal * FuelRate;
Gross = beforeTax.BeforeTa(Subtotal, FEAdjust, FuelIPP);

//Customer's Information
Console.Clear();
Console.WriteLine("\n");
Console.WriteLine(" Account #: {0,10} {1,50}",  customer.AccNum, DateTime.Now);
Console.WriteLine(" Name: {0,15} {1,1} {2,48}", customer.FirstName, customer.LastName, customer.DueDate);
Console.WriteLine(" Premises #: {0,5}", customer.PremNum);
Console.WriteLine(" Address: {0,5}", customer.Address);

Console.WriteLine(("").PadRight(100, '_'));
Console.WriteLine(("").PadRight(100, '_'));

Console.Write(" Previous Balance | " .PadRight(10, ' '));
Console.Write(" Payments | " .PadRight(10, ' '));
Console.Write(" Balance brought Forward | " .PadRight(10, ' '));
Console.WriteLine(" Current Charges |".PadRight(20, ' '));
Console.WriteLine("  {0:c2} {1,20:c2} {2,20:c2} {3,20:c2}", PrevBal, Payments,BalBroFor, CurrChar);

Console.WriteLine(("").PadRight(100, '_'));
Console.WriteLine(("").PadRight(100, '_'));

Console.Write((" Current Reading | ") .PadRight(20, ' '));
Console.Write((" Previous Reading | ").PadRight(20, ' '));
Console.Write((" Current Usage Rate | ").PadRight(20, ' '));
Console.Write(("  Rate  | ").PadRight(8, ' '));
Console.WriteLine((" Current Period Charges").PadRight(20, ' '));

Console.WriteLine(" {0} {1,20} {2,20} {3,21} {4,15:c2}", CurrRead, PrevRead, CurrUsage, Rate, CurrPeriChar);

Console.WriteLine(("").PadRight(100, '_'));
Console.WriteLine(("").PadRight(100, '_'));

Console.WriteLine(" Cust Charge {0,53:c2}", CustCharge);


Console.WriteLine(" Subtotal {0,56:c2}", Subtotal);
Console.WriteLine(" F/E Adjust {0,52:c2}", FEAdjust);
Console.WriteLine(" Fuel & IPP Charge {0,45:c2}", FuelIPP);
Console.WriteLine(" Total current electricity charges before tax {0,20:c2}", Gross);

Console.WriteLine(("").PadRight(100, '_'));

Console.WriteLine(" GCT @ 16.5% {0,51:c2} \n", GCT.GC(CurrUsage,Gross));
Console.WriteLine(("").PadRight(100, '_'));

Console.WriteLine(" Early Payment Incentive {0,39:c2} \n" ,Early);
Console.WriteLine(" TOTAL AMOUNT DUE {0,48:c2} \n", Gross + Early + GCT.GC(CurrUsage,Gross));
