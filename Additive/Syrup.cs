using Coffe;
using Lab9;
namespace Additive
{
    public class Syrup : Decorator
    {
        public Syrup(Coffee coffee)
            : base(coffee, 1, ", Сироп") { }
    }
}
