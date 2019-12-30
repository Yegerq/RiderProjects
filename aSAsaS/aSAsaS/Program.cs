using System; 
  

class Car

{
    public int Weight;
    public void show() 
    { 
        Console.WriteLine("Base class"); 
    } 
} 

class Lorry : Car
{
    public int Weight = 5;
    // overriding 
    new public void show()  
    { 
        Console.WriteLine("Derived class"); 
    } 
} 
   
class GFG { 
      
    
    public static void Main() 
    {
        Car obj = new Car();
        obj.weight();
        obj = new Lorry();
        obj.show(); 
        Console.WriteLine();
    } 
}