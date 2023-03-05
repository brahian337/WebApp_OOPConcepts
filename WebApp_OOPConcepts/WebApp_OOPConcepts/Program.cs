using System;

namespace WebApp_OOPConcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("********************");
                Console.WriteLine("*My first day class*");
                Console.WriteLine("********************");
                Console.WriteLine("");

                Console.WriteLine("Please type your year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Please type your day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                var dateObject = new Date(year, month, day);
                Console.Write("The date entered is: ");
                Console.WriteLine(dateObject);

                Employee salaryEmployee = new SalaryEmployee()
                { 
                    Id = 1,
                    FirstName = "Patricia",
                    LastName = "Alvarez",
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = 1160000
                };

                Console.WriteLine(salaryEmployee.ToString());

                
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
            }
            
        }
    }
}
