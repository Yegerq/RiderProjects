using System;  
using System.Text;  
  
namespace OverrideAndNew  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Car bc = new Car();  
            Lorry dc = new Lorry();  
            Car bcdc = new Lorry();  
  
            bc.Method1();  
            bc.Method2();  
            dc.Method1();  
            dc.Method2();  
            bcdc.Method1();  
            bcdc.Method2();
        }  
    }  
  
    class Car
    {
        public int Weight;
        public int Power;
        public virtual void Method1()  
        {  
            Console.WriteLine("Base - Method1");  
        }  
  
        public virtual void Method2()  
        {  
            Console.WriteLine("Base - Method2");  
        }  
    }  
  
    class Lorry : Car
    {
        public int Weight = 10;
        public int Power;
        public int CarryWeight = 500;
        public override void Method1()  
        {  
            Console.WriteLine("Derived - Method1");  
        }  
  
        public new void Method2()  
        {  
            Console.WriteLine("Derived - Method2");
            Console.WriteLine(CarryWeight);
        }  
    }  
}