using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<string> GetEmployees() {
            // I will return a List of strings
            List<string> employees = new List<string>();
            // Collect user values until the value is an empty string
           while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                // Get a name from the console and assign it to a variable
                string input = Console.ReadLine();
                // Break if the user hits ENTER without typing a name
                if (input == "") {
                    break;
                }
                // Create a new Employee instance
                Employee currentEmployee = new Employee();
                employees.Add(input);
            }
            // This is important!!!
            return employees;
        }

        static void PrintEmployees(List<string> employees) {
            // Loop over the list of employees and print them in the console
            for(int i = 0; i < employees.Count; i++) {
                Console.WriteLine(employees[i]);
            }
        }

        static void Main(string[] args)
        {
            // This will get the employees from the following method
           List<string> employees = GetEmployees();
           PrintEmployees(employees);
        }
    }
}
