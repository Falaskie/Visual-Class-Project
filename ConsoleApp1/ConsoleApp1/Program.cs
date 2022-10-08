// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Bill Payment System");

string HolderName = " ", HolderAddress = " ", PremNum = " ", AccNum = " ";
int  CurrRead = 0, PrevRead = 0, CustCharge = 455;
double PrevBal = 0.0, Payments = 0.0, BalBroFor = 0.0, CurrChar = 0.0, TotAmDue = 0.0,
    Taxes = 0.0, Rate = 9.66, EarlyDis = 250.00, CurrUsage = 0.0, CurrPeriChar = 0.0, FuelRate = 0.0, GCTcharge = 0.0;

Console.WriteLine("Please enter customer's current meter reading");
CurrRead = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter the pervious meter reading.");
PrevRead = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter current usage rate");
CurrUsage = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Fuel Adjustment Rate");
FuelRate = Convert.ToDouble(Console.ReadLine());

if (CurrUsage > 150)
{
    GCTcharge = CurrUsage * 0.165;
}
else
{
    GCTcharge = 0;
}
GCTcharge = Math.Round(GCTcharge, 2);
Console.WriteLine(GCTcharge);