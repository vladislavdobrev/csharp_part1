using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "";
        string middleName = "";
        string lastName = "";
        double balance = 0.0d;
        string bankName = "";
        string IBAN = "";
        string BIC = "";
        string[] creditCardNumber = new string[3];

        Console.WriteLine("Holder's first name type = {0}", firstName.GetTypeCode());
        Console.WriteLine("Holder's middle name type = {0}", middleName.GetTypeCode());
        Console.WriteLine("Holder's last name type = {0}", lastName.GetTypeCode());
        Console.WriteLine("Holder's balance type = {0}", balance.GetTypeCode());
        Console.WriteLine("Bank's name type = {0}", bankName.GetTypeCode());
        Console.WriteLine("Account IBAN type = {0}", IBAN.GetTypeCode());
        Console.WriteLine("Bank BIC type = {0}", BIC.GetTypeCode());
        Console.WriteLine("Credit cards type = {0}", creditCardNumber.GetType());
    }
}
