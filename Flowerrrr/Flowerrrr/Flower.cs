using System;

namespace FlowerShop4
{
    public enum FlowerType
    {
        Roses = 1,
        Lilies,
        Daisies,
        Carnations,
        LivePlant,
        Mixed
    }

    public enum FlowerColor
    {
        Red = 1,
        White,
        Yellow,
        Pink,
        Orange,
        Blue,
        Lavender,
        Mixed
    }

    public enum FlowerArrangement
    {
        Bouquet = 1,
        Vase,
        Basket,
        Any
    }

    public sealed class Flower
    {
        private decimal pc;
        public FlowerType Type;
        public FlowerColor Color;
        public FlowerArrangement Arrangement;

        public Flower()
        {
            Type = FlowerType.Mixed;
            Color = FlowerColor.Mixed;
            Arrangement = FlowerArrangement.Vase;
            pc = 0.00M;
        }

        public Flower(FlowerType type, FlowerColor color,
            FlowerArrangement argn, decimal price)
        {
            Type = type;
            Color = color;
            Arrangement = argn;
            pc = price;
        }

        public decimal UnitPrice
        {
            get { return pc; }
            set { pc = value; }
        }
    }
}