// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using inheritance.Entities;
using System.Globalization;

List<Employee> list = new List<Employee>();

Console.Write("Enter the number of employees: ");
int n =int.Parse(Console.ReadLine());

for(int i=1;i<=n; i++)
{
    Console.Write($"Employee #{i} data:");
    Console.Write("Oursourced (y/n)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write( "Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour  = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);    
    if (ch == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));  
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}
Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach(Employee employee in list)
{
    Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2"),CultureInfo.InvariantCulture);
}
