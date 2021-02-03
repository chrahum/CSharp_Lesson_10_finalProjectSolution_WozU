using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TaxBrackets;

namespace ContractPayrollDemo
{

    //created for ICOMPARER to sort
    public class myComparer : IComparer
    {
        int IComparer.Compare(object xx, object yy)
        {
            Employee x = (Employee)xx;
            Employee y = (Employee)yy;
            return x.yearlySalary.CompareTo(y.yearlySalary);
        }
    }
    public class Employee : Brackets //inheriting from tax brackets file
    {

        //field and accessor for empID, numWorked, rateHour, yearly salary
        public int empID { get; set; }
        public int numWorked { get; set; }
        public decimal rateHour { get; set; }
        public string state { get; set; }
        public decimal yearlySalary { get; set; }

        //method to pull tax bracket from file
        public decimal Tax()
        {
            //creating variable to return
            decimal taxesPaid = 0;

            //creates the dictionary table to pass the key and get the income brackets
            var StateTaxes =  Table()[state];

            //new salary varible to not override original salary for part 2
            decimal salary = yearlySalary;

            //starting from the last income bracket and going backward
            for (int i = StateTaxes.Length - 2; i >= 0; i -= 2)
            {
                //variables to store the brackets and rates
                decimal taxBracket = StateTaxes[i];
                decimal taxRate = StateTaxes[i + 1];

                //checks to see if the yearly tax bracket is greater than the last taxbracket 
                //if its true it will then start calculating the tax rate and store it into var
                
                    if (salary > taxBracket)
                    {
                        taxesPaid += (salary - taxBracket) * taxRate;

                        //makes yearly salary equal your taxBracket so you can continue pay the taxes at new rate
                        salary = taxBracket;
                    }
            }

            //returns the taxesPaid from the loop
            return taxesPaid;
        }

        //default constructor
        public Employee()
        {

        }
        //constructor with 5 paramaters
        public Employee(int ID, int hours, decimal rate, string state, decimal salary)
        {
            this.empID = ID;
            this.numWorked = hours;
            this.rateHour = rate;
            this.state = state;
            this.yearlySalary = salary;
        }

        //print object
        public static void printObj(Employee[] x)
        {
            ArrayList sortList = new ArrayList();
            for (int i = 0; i < x.Length; i++)
            {

                #region Formatting to look nice in console and adds to sort list
                Console.WriteLine(".............................");
                Console.WriteLine(".............................");
                Console.WriteLine(String.Format("....Employee ID: {0,12:}", x[i].empID));
                Console.WriteLine(String.Format("....Yearly Salary: {0,10:C}", x[i].yearlySalary));
                Console.WriteLine(String.Format("....Hourly Rate: {0,12:C}", x[i].rateHour));
                Console.WriteLine(String.Format("....State: {0,18:}", x[i].state));
                Console.WriteLine(String.Format("....Taxes Paid: {0,13:C}", x[i].Tax()));
                sortList.Add(x[i]); //adds object to sort later

                #endregion
            }

            //Sorted list
            Console.WriteLine(".........Sorted.........");

            //syntax to sort
            sortList.Sort(new myComparer());
            foreach (Employee item in sortList)
            {
                Console.WriteLine("Employee ID: {0}, Salary: {1:C}, State: {2}, " +
                    "Taxes Paid: {3:C}", item.empID, item.yearlySalary, item.state, item.Tax());
            }

        }

       
    }
   
}




