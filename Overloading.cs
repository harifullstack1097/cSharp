using System;
    public class Overloading
    {



    public void Overloading1() 
    {
        Console.WriteLine("No parameter in this code");
     }
    public void Overloading1(string name)
    {
        Console.WriteLine($"Hi hell {name}");
    }
    public void Overloading1(string name, int age) 
    {
        Console.WriteLine($"{name} and age is {age}");
    }


    static void Main() 
    {
        Console.WriteLine("Hi hello");
        Overloading overloading = new Overloading();

        Console.WriteLine("calling no parameter method ");
        overloading.Overloading1();

        Console.WriteLine("calling single parameter method ");
        overloading.Overloading1("Abishek");

        Console.WriteLine("calling two parameter method ");
        overloading.Overloading1("Raj",18);

        Console.WriteLine("This is Method overloading");
    }

    }

