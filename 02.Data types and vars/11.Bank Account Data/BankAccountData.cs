//Problem 11. Bank Account Data

//  A bank account has a holder name (first name, middle name and last name), 
//  available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//  Declare the variables needed to keep the information for a single bank account 
//  using the appropriate data types and descriptive names.


using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Unknown";
        string middleName = null;
        string lastName = "Unknown";
        object acctHolderName = firstName + ' ' + middleName + ' ' + lastName;
        
        double balance = 0.0;
        string bankName = "Unknown Bank";
        string iban = null;
        ulong? creditCardNr1 = null;
        ulong? creditCardNr2 = null;
        ulong? creditCardNr3 = null;
        
    
    }

}
