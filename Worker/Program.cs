using System;
using System.Globalization;
using ExWorker.Entities;
using ExWorker.Entities.Enums;

namespace ExWorker
{
    class Program
        {
            static void Main(string[] args)
            {

                Console.Write("Enter department's name: ");
                string departmentName = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Enter worker data: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Level: ");
                WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
                Console.Write("Base salary: ");
                double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Worker worker =  new Worker(name, level, baseSalary, new Department(departmentName));

                Console.Write("How many contracts to this worker? ");
                int n = int.Parse(Console.ReadLine());

                for(int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Enter #{i} contract data: ");
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Duration: ");
                    int hours = int.Parse(Console.ReadLine());

                    worker.AddContract(new HourContract(date, valuePerHour, hours));
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.Write("Enter month and year to calculate income (MM/YYYY): ");
                string monthandYear = Console.ReadLine();
                int month = int.Parse(monthandYear.Substring(0, 2));
                int year = int.Parse(monthandYear.Substring(3));
                Console.WriteLine($"Name: {worker.Name}");
                Console.WriteLine($"Department: {worker.Department.Name}");
                Console.WriteLine($"Income for: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");

            }
    }
}
