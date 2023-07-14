using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int numEmployees = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of working days for each employee: ");
        int numWorkingDays = int.Parse(Console.ReadLine());

        int[][] salaries = new int[numEmployees][];

        for (int i = 0; i < numEmployees; i++)
        {
            salaries[i] = new int[numWorkingDays];

            for (int j = 0; j < numWorkingDays; j++)
            {
                Console.Write($"Enter the salary for day {j + 1} of employee {i + 1}: ");
                salaries[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nDisplaying the weekly salaries:");
        for (int i = 0; i < numEmployees; i++)
        {
            Console.Write($"Employee {i + 1}: ");
            int totalSalary = 0;
            for (int j = 0; j < numWorkingDays; j++)
            {
                Console.Write($"{salaries[i][j]} ");
                totalSalary += salaries[i][j];
            }
            Console.WriteLine($"\nTotal Salary: {totalSalary}\n");
        }

        Console.ReadLine();
    }
}