using Coffe;
namespace Lab9
{
    public class Decorator : Coffee
    {
        private Coffee _coffee;
        private double _price;

        public Decorator(Coffee coffee, double price, string descriptionAddition)
            : base(coffee.GetDescription() + descriptionAddition)
        {
            _coffee = coffee;
            _price = price;
        }

        public override double Price()
        {
            return _coffee.Price() + _price;
        }
    }
}
