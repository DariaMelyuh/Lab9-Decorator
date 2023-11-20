namespace Coffe
{
    public class Latte : Coffee
    {
        public Latte()
            : base("Латте") { }

        public override double Price()
        {
            return 20;
        }
    }
}
