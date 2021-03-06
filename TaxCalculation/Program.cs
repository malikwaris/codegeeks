﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string empName;
            string fName;
            string citizenNo;
            float Salary;
            string userInput;

            double netPay;
            double taxonSalary;
            double grossPay;
            double editedTax2;
            double hrsWorked;
            double ovtWorked;
            double payRate;

            const double FED_TAX = .28;
            const double SS_TAX = 7.65;




            // step 1
            Console.WriteLine("       WEEKLY PAYROLL INFORMATION");

            // step 2
            Console.WriteLine("       --------------------------");

            // step 3
            Console.Write("\n       Please enter the employer's name: ");
            empName = Console.ReadLine();

            //step 4
            Console.Write("\n       Please enter the number of hours worked this week: ");
            userInput = Console.ReadLine();
            hrsWorked = Convert.ToDouble(userInput);

            // step 5
            Console.Write("\n       Please enter the number of OVERTIME HOURS worked this week: ");
            userInput = Console.ReadLine();
            ovtWorked = Convert.ToInt32(userInput);

            // step 6
            Console.Write("\n       Please enter employee's HOURLY PAY RATE: ");
            userInput = Console.ReadLine();
            payRate = Convert.ToDouble(userInput);

            // step 7
            grossPay = (hrsWorked * payRate + ovtWorked * 1.5 * payRate);

            // step 8
            editedTax1 = FED_TAX * grossPay;

            // step 9
            editedTax2 = SS_TAX * grossPay;

            // step 10
            netPay = editedTax1 + editedTax2 - grossPay;

            // step 11
            Console.WriteLine("\n\n       The weekly payroll information summary for: " + empName);

            Console.WriteLine("\n       Gross pay:                             {0:C2}    ", grossPay);

            // step 12
            Console.WriteLine("       Federal income taxes witheld:          {0:C2}      ", editedTax1);
            Console.WriteLine("       Social Security taxes witheld:         {0:C2}    ", editedTax2);
            Console.WriteLine("       Net Pay:                               {0:C2}", netPay);




        }
    }
}
