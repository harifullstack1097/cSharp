using System;
using System.CodeDom;

public class BaiscPratice
{

    static void Main()
    {
        Console.WriteLine("THis is for loop");
        int i = 5;
        int age = 18;
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }


        if (age >= 18)
        {
            Console.WriteLine("hi you are eligible to Vote");
        }
        else
        {
            Console.WriteLine("Sorry! you are not eligible to vote");
        }

        Console.WriteLine("This is While loop");
        while (i <= 10) 
        {
            age = +i;
            Console.WriteLine($"hi this while loop{age}");
            i++;        
        }
       
        
    }
}




