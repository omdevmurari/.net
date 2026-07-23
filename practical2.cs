using System;

namespace PayrollSystem
{
    // 1. INTERFACE: The strict contract
    public interface IPayroll
    {
        decimal CalculateSalary();
    }

    // 2. INHERITANCE (Base Class)
    public abstract class Employee : IPayroll
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            Name = name;
        }

        public abstract decimal CalculateSalary();

        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID: {EmployeeId} | Name: {Name}");
        }
    }

    // 2. INHERITANCE (Derived Class 1)
    public class FullTimeEmployee : Employee
    {
        private decimal fixedMonthlySalary;

        public FullTimeEmployee(int id, string name, decimal salary) : base(id, name)
        {
            fixedMonthlySalary = salary;
        }

        // 3. POLYMORPHISM: Overriding for full-time math
        public override decimal CalculateSalary()
        {
            return fixedMonthlySalary; 
        }

        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails(); 
            Console.WriteLine($"Type: Full-Time | Monthly Pay: ${CalculateSalary()}");
        }
    }

    // 2. INHERITANCE (Derived Class 2)
    public class PartTimeEmployee : Employee
    {
        private decimal hourlyRate;
        private int hoursWorked;

        public PartTimeEmployee(int id, string name, decimal rate, int hours) : base(id, name)
        {
            hourlyRate = rate;
            hoursWorked = hours;
        }

        // 3. POLYMORPHISM: Overriding for part-time math
        public override decimal CalculateSalary()
        {
            return hourlyRate * hoursWorked; 
        }

        public override void DisplayEmployeeDetails()
        {
            base.DisplayEmployeeDetails();
            Console.WriteLine($"Type: Part-Time | Pay ({hoursWorked} hrs @ ${hourlyRate}/hr): ${CalculateSalary()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Employee Payroll System ---\n");

            // REPLACED LIST WITH AN ARRAY
            Employee[] companyEmployees = new Employee[2];

            // Assigning our specific employee types to the array slots
            companyEmployees[0] = new FullTimeEmployee(101, "Om Devmuari", 5000m);
            companyEmployees[1] = new PartTimeEmployee(102, "Venisha Makadia", 20m, 80);

            // POLYMORPHISM IN ACTION:
            foreach (Employee emp in companyEmployees)
            {
                emp.DisplayEmployeeDetails();
                Console.WriteLine("-------------------------------");
            }

            Console.ReadKey();
        }
    }
}