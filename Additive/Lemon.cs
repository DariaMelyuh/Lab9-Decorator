using Coffe;
using Lab9;
namespace Additive
{
    public class Lemon : Decorator
    {
        public Lemon(Coffee coffee)
            : base(coffee, 3, ", Лимон") { }
    }
}
