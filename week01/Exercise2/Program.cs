using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {
        // This code prompts the user for an input which is the converted to a number
        Console.Write("Hello! Please kindly input a grade value: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        // This block assigns the appropriate grade letter to the user input
        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // This block generates the + or -
        int lastDigit = number % 10;
        string sign = "";
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // This block recognizes and handles the A+ and F scenarios
        
        if (letter == "A" && lastDigit >= 7)
        {
            sign = "";
        }
        
        if (letter == "F")
        {
            sign = "";
        }

        // This block displays the grade letter add the remarks to the user
        {
            Console.WriteLine($"Your grade is {letter}{sign}");
        }
        if (number >= 70)
        {
            Console.WriteLine("Congratulations, You have passed the test");
        }
        else
        {
            Console.WriteLine("Sorry, Try harder next time");
        }
        

    }
}