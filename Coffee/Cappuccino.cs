namespace Coffe
{
    public class Cappuccino : Coffee
    {
        public Cappuccino()
            : base("Капучино") { }

        public override double Price()
        {
            return 25;
        }
    }
}
