using System;

class ConstructerO
    {

    string filename = "student.doc";
    string name = "Hari krishna reddy";
    public ConstructerO(string sname) { 

      Console.WriteLine(sname);
      this.name = sname;
    }

    public ConstructerO(string sname, string id)
    {

        Console.WriteLine($"my name is {sname} and my id is {id}");
        this.name = sname;
    }

    static void Main(string[] args)
    {
        ConstructerO k1 = new ConstructerO("student2");
        ConstructerO k2 = new ConstructerO("Hari, 10");
        method();
        Console.WriteLine("hi this from main method");
    }
     static void method()
     {
        Console.WriteLine("hello");
     }

     }
    
   
