using System;
using System.Collections.Generic;
using System.Globalization;
using Employees.Entities;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(
                        Console.ReadLine(), CultureInfo.InvariantCulture);

                if(response == 'y' || response == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    list.Add(
                        new OutsourcedEmployee(
                            name,
                            hours,
                            valuePerHour,
                            addCharge));
                }
                else
                {
                    list.Add(
                        new Employee(
                            name,
                            hours,
                            valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(
                    emp.Name
                    + " - $"
                    + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
