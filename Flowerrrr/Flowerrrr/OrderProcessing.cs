
using System;

namespace FlowerShop4
{
    public class OrderProcessing
    {
        public Flower FlowerOrder;
        private int qty;

        public int Quantity
        {
            get { return qty; }
            set { qty = value; }
        }

        public OrderProcessing()
        {
            FlowerOrder = new Flower();
        }

        public decimal TotalPrice
        {
            get { return Quantity * FlowerOrder.UnitPrice; }
        }

        public void GetFlowerType()
        {
            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("Enter the Type of Flower Order");
                    Console.WriteLine("1. Roses");
                    Console.WriteLine("2. Lilies");
                    Console.WriteLine("3. Daisies");
                    Console.WriteLine("4. Carnations");
                    Console.WriteLine("5. Live Plant");
                    Console.WriteLine("6. Mixed");
                    Console.Write("Your Choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You failed to enter an " +
                                      "appropriate number!");
                }

                if ((choice < 1) || (choice > 6))
                    Console.WriteLine("Invalid Value: Please enter " +
                                      "a value between 1 and 6");
            } while ((choice < 1) || (choice > 6));

            switch (choice)
            {
                case 1:
                    FlowerOrder.Type = FlowerType.Roses;
                    break;
                case 2:
                    FlowerOrder.Type = FlowerType.Lilies;
                    break;
                case 3:
                    FlowerOrder.Type = FlowerType.Daisies;
                    break;
                case 4:
                    FlowerOrder.Type = FlowerType.Carnations;
                    break;
                case 5:
                    FlowerOrder.Type = FlowerType.LivePlant;
                    break;
                default:
                    FlowerOrder.Type = FlowerType.Mixed;
                    break;
            }
        }

        public void GetFlowerColor()
        {
            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("Enter the Color");
                    Console.WriteLine("1. Red");
                    Console.WriteLine("2. White");
                    Console.WriteLine("3. Yellow");
                    Console.WriteLine("4. Pink");
                    Console.WriteLine("5. Orange");
                    Console.WriteLine("6. Blue");
                    Console.WriteLine("7. Lavender");
                    Console.WriteLine("8. Mixed");
                    Console.Write("Your Choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You didn't enter an " +
                                      "appropriate number!");
                }

                if ((choice < 1) || (choice > 8))
                    Console.WriteLine("Invalid Value: Please " +
                                      "enter a value between 1 and 8");
            } while ((choice < 1) || (choice > 8));

            switch (choice)
            {
                case 1:
                    FlowerOrder.Color = FlowerColor.Red;
                    break;
                case 2:
                    FlowerOrder.Color = FlowerColor.White;
                    break;
                case 3:
                    FlowerOrder.Color = FlowerColor.Yellow;
                    break;
                case 4:
                    FlowerOrder.Color = FlowerColor.Pink;
                    break;
                case 5:
                    FlowerOrder.Color = FlowerColor.Yellow;
                    break;
                case 6:
                    FlowerOrder.Color = FlowerColor.Blue;
                    break;
                case 7:
                    FlowerOrder.Color = FlowerColor.Lavender;
                    break;
                default:
                    FlowerOrder.Color = FlowerColor.Mixed;
                    break;
            }
        }

        public void GetFlowerArrangement()
        {
            int choice = 0;

            do
            {
                try
                {
                    Console.WriteLine("Enter the Type of Arrangement");
                    Console.WriteLine("1. Bouquet");
                    Console.WriteLine("2. Vase");
                    Console.WriteLine("3. Basket");
                    Console.WriteLine("4. Mixed");
                    Console.Write("Your Choice: ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You didn't provide an " +
                                      "acceptable number!");
                }

                if ((choice < 1) || (choice > 4))
                    Console.WriteLine("Invalid Value: Please enter " +
                                      "a value between 1 and 4");
            } while ((choice < 1) || (choice > 4));

            switch (choice)
            {
                case 1:
                    FlowerOrder.Arrangement = FlowerArrangement.Bouquet;
                    break;
                case 2:
                    FlowerOrder.Arrangement = FlowerArrangement.Vase;
                    break;
                case 3:
                    FlowerOrder.Arrangement = FlowerArrangement.Basket;
                    break;
                default:
                    FlowerOrder.Arrangement = FlowerArrangement.Any;
                    break;
            }
        }

        public void ProcessOrder()
        {
            GetFlowerType();
            GetFlowerColor();
            GetFlowerArrangement();

            try
            {
                Console.Write("Enter the Unit Price: ");
                FlowerOrder.UnitPrice = 
                    Math.Abs(decimal.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't specify a valid price!");
            }

            try
            {
                Console.Write("Enter Quantity:       ");
                Quantity = Math.Abs(int.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine("The quantity you entered " +
                                  "is not acceptable!");
            }
        }

        public void ShowOrder()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("==-=-=Flower Shop=-=-==");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Flower Type:  {0}", 
                FlowerOrder.Type);
            Console.WriteLine("Flower Color: {0}", 
                FlowerOrder.Color);
            Console.WriteLine("Arrangement of flowers:  {0}",
                FlowerOrder.Arrangement);
            Console.WriteLine("Price for one flower:        {0:C}",
                FlowerOrder.UnitPrice);
            Console.WriteLine("Amount of flowers:     {0}", Quantity);
            Console.WriteLine("Total Price in $:  {0:C}", TotalPrice);
            Console.WriteLine("=======================");
        }
    }
}