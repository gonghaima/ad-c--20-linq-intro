﻿using System;
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
        var filteredEmployees = employeeList.Filter(emp => emp.IsManager == true );

        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine($"First Name: {employee.FirstName}");
            Console.WriteLine($"Last Name: {employee.LastName}");
            Console.WriteLine($"Annual Salary: {employee.AnnualSalary}");
            Console.WriteLine($"Manager: {employee.IsManager}");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

