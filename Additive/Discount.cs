using Coffe;
using Lab9;
namespace Additive
{
    public class Discount : Decorator
    {
        public Discount(Coffee coffee)
            : base(coffee, coffee.Price() * (-0.05), " + Скидка") { }
    }
}
