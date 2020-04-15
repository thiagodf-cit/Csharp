using System;
using System.Globalization;
using CourseEnums.Entities.Enums;
using CourseEnums.Entities;

namespace CourseEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////
            // Order order = new Order
            // {
            //     Id = 3082,
            //     Moment = DateTime.Now,
            //     Status = OrderStatus.PendingPayment
            // };

            // Console.WriteLine("Pedido: " + order);

            // string txt = OrderStatus.PendingPayment.ToString();

            // OrderStatus os = Enum.Parse<OrderStatus>("Shipped");

            // Console.WriteLine(txt);
            // Console.WriteLine(os);
            ///
            ////////////////////////////////////////////////////////////////////
            ///
            Console.Write("Enter with Department name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("\nHow many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for {monthAndYear} : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}