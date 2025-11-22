using System;

    public class MethodOveriding
    {
    public virtual void MethodParent() 
        {
            Console.WriteLine("Hi hello");
        }
    public void Show(string name)
    {
        Console.WriteLine($"i am {name}");
    }

    }
class M1 : MethodOveriding
{
    public override void MethodParent()
    {
        Console.WriteLine("Iam from sencod class ");
    }

}
class MethodOveriding1
{
    public void MethodParent() 
    {
     Console.WriteLine("This is from class 3");
    }
    static void Main() 
    {
        MethodOveriding m1 = new MethodOveriding();
        MethodOveriding m2 = new M1();
        m1.Show("hari");
        m1.MethodParent(); 
        m2.MethodParent();
        MethodOveriding m3 = new MethodOveriding();
        m3.MethodParent();
    } 
}




