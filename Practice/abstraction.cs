using System.Collections.Generic;

namespace flyer_expo_api.Practice
{
    public class Abstraction
    {
    }

    // Abstraction is "the process of identifying common patterns that have systematic variations; an abstraction represents the common pattern and provides a means for specifying which variation to use" (Richard Gabriel).

    public enum Gender
    {
        Male,
        Female,
        NotSpecific
    }

    public abstract class BaseDetails
    {
        public List<int> BasicSalary { get; set; }

        public abstract int CalculateSalary();
    }

    public class Employee : BaseDetails
    {
        public override int CalculateSalary()
        {
            int totalSalary = 0;
            foreach (var salary in BasicSalary)
            {
                totalSalary += salary;
            }
            return totalSalary;
        }
    }

    // For the worker we have another additional Bonus and due to abstraction we can modify the employee salary
    public class Worker : BaseDetails
    {
        public List<int> Bonus { get; set; }

        public override int CalculateSalary()
        {
            int totalSalary = 0;
            foreach (var salary in BasicSalary)
            {
                totalSalary += salary;
            }

            foreach (var bonusAmount in Bonus)
            {
                totalSalary += bonusAmount;
            }
            return totalSalary;
        }
    }


    // Example of Overriding for IT employee
    public class ITEmployee : Employee
    {
        public int VariablePay;
        public sealed override int CalculateSalary()
        {
            int totalCalculatedSalary = base.CalculateSalary();
            totalCalculatedSalary += VariablePay;
            return totalCalculatedSalary;
        }
    }

    // As SWZ is an IT client so it/this should not override the Calculate Salary, Hence in the parent sealed keyword is added hence not able to override the Calculate Salary method.
    public class SWZOrganizationEmployee : ITEmployee
    {
        // Below Code is giving error as virtual/abstract method is sealed in its parent class. 
        //public override int CalculateSalary()
        //{
        //}

        // But you can start new virtualization from this class. So from this client you can completly scrap the implemnetation which is in base and start new implementation.
        public virtual int CalculateSalary()
        {
            return 0;
        }
    }

    // Realtime implementation of above abstraction structure
    public class SalaryCalculationService
    {
        // Evaluate Employees Salary
        void EvaluateEmployeesCurrentMonthSalary()
        {
            // If you have an object of Only Employee with Base salary 100, 50
            Employee employee = new Employee();
            employee.BasicSalary = new List<int>();
            employee.BasicSalary.AddRange(new[] { 100, 50 });
            var calculateEmployeeSalary = employee.CalculateSalary();

            // So the current salary of employee is : 150



            // If you have an object of Only SWZOrganizationEmployee with Base salary 100, 50
            SWZOrganizationEmployee swzemployee = new SWZOrganizationEmployee();
            swzemployee.BasicSalary = new List<int>();
            swzemployee.BasicSalary.AddRange(new[] { 100, 50 });
            var calculateSWZEmployeeSalary = swzemployee.CalculateSalary();

            // So the current salary of employee is : 150
        }

        // Evaluate SWZ Client Employees Salary
        void EvaluateSWZOrgEmployeesCurrentMonthSalary()
        {
            // If you have an object of Only SWZOrganizationEmployee with Base salary 100, 50
            SWZOrganizationEmployee swzemployee = new SWZOrganizationEmployee();
            swzemployee.BasicSalary = new List<int>();
            swzemployee.BasicSalary.AddRange(new[] { 100, 50 });
            var calculateSWZEmployeeSalary = swzemployee.CalculateSalary();

            // So the current salary of employee is : 0 as we have shadowed the Calculate Salary Method. and will be consider as new implmenetion for 
        }


    }
}
