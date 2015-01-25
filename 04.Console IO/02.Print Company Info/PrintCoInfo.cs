﻿/*
 * 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. 
 *  The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;



class PrintCoInfo
{
    static string ParseNum(string inputstr)
    {

        return inputstr.Replace(" ", null).Replace("-", null).Replace("(", null).Replace(")", null).Replace("/", null);
        
    }

    static void Main(string[] args)
    {
        Console.Write("Please enter company name: ");
        string coName = Console.ReadLine();
        Console.Write(" address: ");
        string coAddress = Console.ReadLine();
        Console.Write(" phone number: ");
        int coPhone;
        string tmp = ParseNum(coPhone);
        bool phoneParse = int.TryParse(Parser(coPhone), out coPhone);
        Console.Write(" fax number: ");
        string coFax = Console.ReadLine();
        Console.Write(" web site: ");
        string coWebsite = Console.ReadLine();
        coWebsite = coWebsite.StartsWith("http://")? coWebsite : "http://" + coWebsite;

        Console.Write("Manager first name: ");
        string mgrFirstname = Console.ReadLine();
        mgrFirstname = mgrFirstname.Length == 0 ? "no firstname" : mgrFirstname;
        Console.Write(" last name: ");
        string mgrLastname = Console.ReadLine() ?? "(no lastname)";
        Console.Write(" age: ");
        string mgrAge = Console.ReadLine();
        Console.Write(" phone number: ");
        string mgrPhone = Console.ReadLine();

        Console.WriteLine(@"
{0}
Address: {1}
Tel. {2,6:+### ### ## ## ##} 
Fax: {3,6:+### ### ## ## ##}
Web site: {4,6}
Manager: {5} {6} (age: {7}, tel. {8,1:+### ## ### ###})  
", coName, coAddress, coPhone, coFax, coWebsite, mgrFirstname, mgrLastname, mgrAge, mgrPhone);



    }
}
