/*
 * Classname: BankingApp
 * Information: Logical operators demo
 * Version 1
 * Author: Dr James Connolly
 * Date: September 2024
 */

//Call the BankingApp method to begin application
using System.Xml.Serialization;

BuildBankingApp();

//functions / methods should be verbs.
//With C# Pasca; Case should be used with function names starting with a capital letter.
// Function names should not have underscores.

void BuildBankingApp()
{
    //Initialise variable
    //Note that an amount is not assigned to the variable
    int choice;
    double depositAmount;
    double withdrawalAmount;
    double accountBalance = 1000.00;

    //Display the main menu screen
    Console.WriteLine("Please choose an opstion");
    Console.WriteLine("========================");
    Console.WriteLine("1 - deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    //Read choice for the main menu
    //explicitly typecast the string input
    //from the keyboard and convert to
    //an integer so we can then use it within the if statements
    choice = Convert.ToInt32(Console.ReadLine());

    //The "||" in the loop represents OR
    //which means that a menu choice of 1 OR 2 is accepcted
    //this is an example of a logical operation
    if (choice == 1 || choice == 2)
    {
        Console.WriteLine("Please choose an option");
        Console.WriteLine("1 - Deposit funds");
        Console.WriteLine("2 - Withdraw funds");
        Console.WriteLine("Please choose an option (1-2)");

        //explicitly typecase the string input
        //from the keyboard and convert to
        //an integer so we can then use it within the if statements
        choice= Convert.ToInt32(Console.ReadLine());

        // The "==" in this loop is an example of
        //a comparison operation
        if (choice == 1)
        {
            Console.WriteLine("How much do you want to deposit?");
            Console.WriteLine("Enter the amount including pence using a decimal point");
            //typically a currency value is input as a decimal
            //value so the "double" type is required to store the
            //deposit amount. This is an example of an explicit typecast
            depositAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The original balance was {0}", accountBalance);
            //This is read as "account balance = account balance + deposit amount"
            //This is an example of an assignment operator
            accountBalance += depositAmount;
            Console.WriteLine("The new balance is now {0}", accountBalance);
        }
        if (choice == 2)
        {
            Console.WriteLine("How much do you want to withdraw from account?");
            Console.WriteLine("Enter amount including pence using a decimal point");
            withdrawalAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The original balance was {0}", accountBalance);
            //This is read as "account balance = account balance - withdrawal amount"
            //this is an example of an assignment operator
            accountBalance -= withdrawalAmount;
            Console.WriteLine("The new balance for account is {0}", accountBalance);
        }

    }
    else
    {
        //An invalid number has been selected. Advise the user accordingly
        Console.WriteLine("Please choose a valid menu option between 1-2");
    }
}