//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main(string[] args)
    {

    string firstName = "Ivan";
    string lastName = "Ivanov";
    int age = 20;
    char gender = 'm';              //
    long personalID = 8306112507;
    long employeeID = 27560000;     // …27569999)

    string display = @"
    
Employee {5}
===============================
    First name:             {0}
    Last name:              {1}
    Age:                    {2}
    Gender:                 {3}
    Personal ID number      {4}
    
";

    Console.WriteLine(display,firstName,lastName,age,gender,personalID,employeeID);
    }
}