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
            if (coffee == null)
            {
                throw new ArgumentNullException(nameof(coffee), "Кофе не может быть пустым");
            }

            if (price < 0)
            {
                throw new ArgumentException("Цена не может быть отрицательной", nameof(price));
            }

            _coffee = coffee;
            _price = price;
        }

        public override double Price()
        {
            return _coffee.Price() + _price;
        }
    }
}
