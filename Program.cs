using System;

class Program
    {

    string filename = "student.doc";
    string name = "Hari krishna reddy";
    public Program(string sname) { 

      Console.WriteLine(sname);
      this.name = sname;
    }

    public Program(string sname, string id)
    {

        Console.WriteLine($"my name is {sname} and my id is {id}");
        this.name = sname;
    }


    static void Main(string[] args)
    {
        Program k1 = new Program("student2");
        Program k2 = new Program("Hari, 10");
        method();
        Console.WriteLine("hi this from main method");
    }
     static void method()
     {
        Console.WriteLine("hello");
     }



     }
    
   
