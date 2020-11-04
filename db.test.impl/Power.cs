using System.Drawing;

namespace db.test.impl
{
    /// <summary>
    /// Возведение числа в указанную степень.
    /// </summary>
    public class Power : Plugin
    {
        public Power() : base("Power", "1.0", Image.FromFile("Pow.jpg"), "Rising an integer to the power.") { }

        public override int Run(int integer, int power)
        {
            if (power < 0) return integer % 2 == 0 ? 0 : -1;
            
            var res = 1;

            for (var i = power; i > 0; i--)
            {
                res *= integer;
            }

            return res;

        }
    }
}
