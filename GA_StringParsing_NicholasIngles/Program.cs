// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        string myString = "8";

        try
        {
            int myNumber = int.Parse(myString); 

            Console.WriteLine($"Your number was an Integral: {myNumber}"); 

        }
        catch
        {

            
            Console.WriteLine("You had an error");
        } 
        Console.Write("Enter your first number: ");
        string stringNumber1 = Console.ReadLine();
    
        Console.Write("Enter your second number: ");
        string stringNumber2 = Console.ReadLine();
        
        Console.Write("Enter your third number: ");
        string stringNumber3 = Console.ReadLine();


        try
        { 
          
            double userNumber1 = double.Parse(stringNumber1);
            double userNumber2 = double.Parse(stringNumber2);
            double userNumber3 = double.Parse(stringNumber3);

            
            double sumAllNumbers = userNumber1 + userNumber2 + userNumber3; 
            double average = sumAllNumbers / 3; 

          
            Console.WriteLine($"The average of your 3 numbers is {average}");

        } 
        catch
        { 

          
            Console.WriteLine("You had an error");
        }


    }
}