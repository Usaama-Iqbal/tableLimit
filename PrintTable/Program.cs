using System;
using System.Collections.Generic;
using System.Text;

public class table
{
    public static void Main(string[] args)
    {
        int result;
        
        Console.Write("Please Give a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the limit : ");
        int limit = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= limit; i++)
        {
             result = number * i;
            Console.WriteLine(number+ " * " +i+  " = " +result );
           
        }

    }
}
    