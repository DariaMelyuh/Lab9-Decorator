using Coffe;
using Lab9;
namespace Additive
{
   public class Sugar : Decorator
    {
        public Sugar(Coffee coffee)
            : base(coffee, 1, ", Сахар") { }
    }
}
