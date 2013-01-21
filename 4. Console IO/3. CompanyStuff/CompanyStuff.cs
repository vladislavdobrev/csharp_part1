using System;

class CompanyStuff
{
    static void Main()
    {
        string companyName = null;
        string companyAddress = null;
        string companyPhone = null;
        string comapnyFax = null;
        string companyWebSite = null;
        string managerFirstName = null;
        string managerLastName = null;
        string managerAge = null;
        string managerPhone = null;

        Console.Write("Company name: ");
        companyName = Console.ReadLine();
        Console.Write("Company address: ");
        companyAddress = Console.ReadLine();
        Console.Write("Company phone: ");
        companyPhone = Console.ReadLine();
        Console.Write("Company fax: ");
        comapnyFax = Console.ReadLine();
        Console.Write("Company website: ");
        companyWebSite = Console.ReadLine();
        Console.Write("Company manager's first name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("Company manager's last name: ");
        managerLastName = Console.ReadLine();
        Console.Write("Company manager's age: ");
        managerAge = Console.ReadLine();
        Console.Write("Company manager's phone: ");
        managerPhone = Console.ReadLine();

        int intManagerAge = int.Parse(managerAge);

        Console.WriteLine();
        Console.WriteLine("Company name: {0}\nCompany address: {1}\nCompany phone: {2}\nCompany fax: {3}\nCompany website: {4}\nManger's first name: {5}\nManager's last name: {6}\nManager's age: {7}\nManager's phone: {8}",
            companyName, companyAddress, companyPhone, comapnyFax, companyWebSite, managerFirstName, managerLastName, intManagerAge, managerPhone);
    }
}
