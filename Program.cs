using System;
using System.Collections.Generic;


public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string department { get; set; }
public class program
{
    static void Main()
    {
            HashSet<Employee> employees = new HashSet<Employee>();
            
            Console.WriteLine("enter employee ID");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter employee Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee department");
            string Department = Console.ReadLine();

            Employee employee = new Employee() { ID = Id, Name = name, department = Department };

            if (employees.Contains(employee))
            {
                Console.WriteLine("Employee already added");
            }
            else
            {
                employees.Add(employee);
            }
            




        }
}