namespace db.test.impl
{
    /// <summary>
    /// Разность двух чисел.
    /// </summary>
    public class Subtraction : Plugin
    {
        public Subtraction() : base("Subtraction", "1.0", System.Drawing.Image.FromFile("Subtraction.jpg"), "Difference between two integers.") { }

        public override int Run(int reduced, int subtracted) => reduced - subtracted;
        
    }
}
