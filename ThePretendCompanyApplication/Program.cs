using System;
using System.Collections.Generic;
using TCPData;
using TCPExtensions;
using System.Linq;

namespace ThePretendCompanyApplication;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employeeList = Data.GetEmployees();
        // var filteredEmployees = employeeList.Filter(emp => emp.IsManager == true );
        // var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary < 50000);

        // foreach (var employee in filteredEmployees)
        // {
        //     Console.WriteLine($"First Name: {employee.FirstName}");
        //     Console.WriteLine($"Last Name: {employee.LastName}");
        //     Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
        //     Console.WriteLine($"Manager: {employee.IsManager}");
        //     Console.WriteLine();
        // }

        List<Department> departmentList = Data.GetDepartments();

        // var filteredDepartments = departmentList.Where(dept => dept.ShortName == "TE" || dept.ShortName == "HR");
        var filteredDepartments = departmentList.Filter(dept => dept.Id > 1);
        foreach (var department in filteredDepartments)
        {
            Console.WriteLine($"Id: {department.Id}");
            Console.WriteLine($"Short Name: {department.ShortName}");
            Console.WriteLine($"Long Name: {department.LongName}");
            Console.WriteLine();
        }


        Console.ReadLine();
    }
}

