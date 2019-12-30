using System;
namespace ConsoleApp1
{
    class Truck : Vehicle
    {
        public Truck(string model, string manufacturer, int weight, string color, int maxSpeed) : 
            base(model, manufacturer, weight, color, maxSpeed)
        {
        }
    }
}