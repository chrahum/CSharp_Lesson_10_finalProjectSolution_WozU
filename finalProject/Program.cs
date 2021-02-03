using System;
using System.Collections.Generic;
using System.Collections;
using ContractPayrollDemo; //using directive to use EmployeeInfo.cs
using TaxBrackets;
using System.Linq;

namespace finalProject
{
    class Program :Brackets
    {
        static void Main(string[] args)
        {
            //Makes an Employee array
            Employee[] empObj = new Employee[10];
            int num = 0, id, work;
            decimal rate, annualRate;
            string state, input;
            bool isState = false;



            //do-while to create 10 full objects and inserting to array
            do {
                //asks and gets for EMPLOYEE ID
                Console.Write("Please enter your four digit employee ID: ");
                input = Console.ReadLine();

                //if input is not an int it will ask again
                while (!Int32.TryParse(input, out id))
                {
                    Console.Write("\nThose are not  digits!\nPlease enter your four digit employee ID: ");
                    input = Console.ReadLine();
                }


                //Asks and gets how many hours a week employee works and multiplies by 52 weeks in a year
                Console.Write("How many hours do you work per week: ");
                input = Console.ReadLine();

                //if input is not an int it will ask again
                while (!Int32.TryParse(input, out work))
                {
                    Console.Write("\nThose are not numbers!\nHow many hours do you work per week: ");
                    input = Console.ReadLine();
                }
                //multiplies by 52 weeks in a year to get yearly salary
                work *= 52;

                //Asks and gets hourly pay rate
                Console.Write("What is your hourly pay rate: ");
                input = Console.ReadLine();
                //if input is not an int it will ask again
                while (!Decimal.TryParse(input, out rate))
                {
                    Console.Write("\nThat is not currency!\nWhat is your hourly pay rate: ");
                    input = Console.ReadLine();
                }

                //calculates annual salary
                annualRate = work * rate;

                //asks and gets the state they live in
                do
                {
                    isState = false;
                    Console.Write("What state do you live in: ");
                    input = Console.ReadLine();
                    //capitilizing first letter
                    state = input.First().ToString().ToUpper() + input.Substring(1);
                    
                    //checks is state is in Statelist
                    foreach (string x in StateList())
                    {
                        if (state.Contains(x))
                        {
                            isState = true;      
                        }
                    }

                    //only executes if isstate is still false
                    if (isState == false)
                    {
                        Console.WriteLine("\nPlease enter the correct spelling of a US state.");
                    }

                } while (isState != true);

                    
                //adds new object to the empObj to save into the array
                empObj[num] = new Employee(id, work, rate, state, annualRate);
                    
                //adds one to counter
                num++;                                                

                }while (num < 10);

            //prints out the array with all employees details
            Employee.printObj(empObj);



        }
    }
}
