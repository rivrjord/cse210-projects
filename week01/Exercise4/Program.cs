using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");


        // This block gets the user input and saves it into the list (number) 
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of number (enter 0 to finish): ");
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            // this condition ensures that only numbers other than "0"  saved
            if (userNumber !=0 )
            {
                numbers.Add(userNumber);
            }
        }

        // displays the total number in the list
        Console.WriteLine("The total number in the list is: " + numbers.Count);

        // This block calculates and displays the sum of the numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers in the list is: {sum}");

        // This calculates and displays the average of the numbers in the list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // This block generates and displays the highest number in the list
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The max is: {maxNumber}");

        // This block generates and displays the lowest positive number.
        // I used the Linq library to achieve this 
        var positiveNumbers = numbers.Where(n => n > 0);
        int minPositive = positiveNumbers.Min();
        
        Console.WriteLine($"The smallest positive number is: {minPositive}");

        // This block generates and show the sorted list
        numbers.Sort();
        Console.WriteLine("\nSorted list is:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}