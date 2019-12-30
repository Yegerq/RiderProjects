using System;

class Car
{
    public virtual void Y()
    {
        Console.WriteLine("A.Y");
    }
}

class B : Car
{
    public override void Y()
    {
        Console.WriteLine("B.Y");
    }
}


class Program
{
    static void Main()
    {
        Car ab = new B();
        ab.Y();
    }
}