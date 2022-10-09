// See https://aka.ms/new-console-template for more information
using BillPay;

Console.WriteLine("Welcome to the Bill Payment System");

//Variables
int  CurrRead = 0, PrevRead = 0, CustCharge = 455;
double PrevBal = 0.0, Payments = 0.0, BalBroFor = 0.0, CurrChar = 0.0, TotAmDue = 0.0,
    Taxes = 0.0, Rate = 9.66, EarlyDis = 250.00, CurrUsage = 0.0, CurrPeriChar = 0.0, FuelRate = 0.0, GCTcharge = 0.0,
    Subtotal = 0.0, FuelIPP = 0.0, FEAdjust = 0.0;
Console.SetWindowSize(100, 25);

/*
//Entering of informations
Console.WriteLine("Please enter customer's current meter reading");
CurrRead = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter the pervious meter reading.");
PrevRead = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter current usage rate");
CurrUsage = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the Fuel Adjustment Rate");
FuelRate = Convert.ToDouble(Console.ReadLine());
*/

//Customer Information
CustomerInfo customer = new CustomerInfo();
customer.FirstName = "Delawna ";
customer.LastName = "Brown ";
customer.AccNum = " 0010310010";
customer.PremNum = " 450";

CurrChar = CurrUsage * Rate;
Subtotal = CurrPeriChar + CustCharge;
FuelIPP = CurrUsage * 21.794;
FEAdjust = Subtotal * FuelRate;

Console.Clear();

Console.WriteLine("Account # " +  customer.AccNum);
Console.WriteLine("Name       " + customer.FirstName + customer.LastName);
Console.WriteLine("Premises # " + customer.PremNum);
Console.WriteLine("*************************************************************************************************** /n");