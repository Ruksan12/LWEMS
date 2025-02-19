using System;
using System.Collections.Generic;


public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string department { get; set; }

    public Employee(int id, string name, string department)
    {
        ID = id;
        Name = name;
        this.department = department;
    }
    public override bool Equals(object obj)
    {
        return obj is Employee employee && ID == employee.ID;
    }
    public override int GetHashCode()
    {
        return ID.GetHashCode();
    }
}

class EmployeeManageemnt
{

    HashSet<Employee> employees = new HashSet<Employee>();
    public void AddEmployee()
    {
        try
        {
            Console.WriteLine("Enter employee Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter employee department");
            string department = Console.ReadLine();

            Employee employee = new Employee(id, name, department);
            if (employees.Add(employee))
            {
                Console.WriteLine("Employee added successfully");
            }
            else
            {
                Console.WriteLine("Duplicate employee id");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error : " + ex.Message);
        }

    }

    public void DeleteEmployee()
    {
        Console.WriteLine("Enter employee Id to delete");
        int id = int.Parse(Console.ReadLine());
        Employee employee = new Employee(id, "", "");
        if (employees.Remove(employee))
        {
            Console.WriteLine("Employee deleted successfully");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }

    public void SearchEmployee()
    {
        Console.WriteLine("Enter the employee id to search");
        int id = int.Parse(Console.ReadLine());
        Employee employee = new Employee(id, "", "");
        if (employees.Contains(employee))
        {
            Console.WriteLine("Employee found");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }

    }

    public void DisplayEmployees()
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine("Employee Id : " + employee.ID);
            Console.WriteLine("Employee Name : " + employee.Name);
            Console.WriteLine("Employee Department : " + employee.department);
            Console.WriteLine("-------------------------------");
        }
    }
}
    public class program
    {
        static void Main()
        {
        EmployeeManageemnt employeeManageemnt = new EmployeeManageemnt();
        while (true)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Delete Employee");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("4. Display Employees");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    employeeManageemnt.AddEmployee();
                    break;
                case 2:
                    employeeManageemnt.DeleteEmployee();
                    break;
                case 3:
                    employeeManageemnt.SearchEmployee();
                    break;
                case 4:
                    employeeManageemnt.DisplayEmployees();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

    }
    }


