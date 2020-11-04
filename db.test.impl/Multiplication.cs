namespace db.test.impl
{
    /// <summary>
    /// Произведение двух чисел.
    /// </summary>
    public class Multiplication : Plugin
    {
        public Multiplication() : base("Multiplication", "1.0", System.Drawing.Image.FromFile("Multiplication.jpg"), "Multiplication of two integers.") { }

        public override int Run(int int1, int int2) => int1 * int2;
        
    }
}
