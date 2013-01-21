using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName = "";
        string familyName = "";
        byte age = 0;
        char gender = '\u0000';
        int idNumber = 0;
        uint uniqueEmployeeNumber = 0;

        Console.WriteLine("Employee's first name: type = {0}", firstName.GetTypeCode());
        Console.WriteLine("Employee's family name: type = {0}", familyName.GetTypeCode());
        Console.WriteLine("Employee's age: type = {0}", age.GetTypeCode());
        Console.WriteLine("Employee's gender: type = {0}", gender.GetTypeCode());
        Console.WriteLine("Employee's ID number: type = {0}", idNumber.GetTypeCode());
        Console.WriteLine("Employee's Unique employee number: type = {0}", uniqueEmployeeNumber.GetTypeCode());
    }
}
