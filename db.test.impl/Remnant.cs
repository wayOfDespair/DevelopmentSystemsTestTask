namespace db.test.impl
{
    /// <summary>
    /// Получение остатка от деления двух чисел. При делении на ноль возвращает 0.
    /// </summary>
    public class Remnant : Plugin
    {
        public Remnant() : base("Remnant", "1.0", System.Drawing.Image.FromFile("Remnant.jpg"), "Remainder of division of two integers.") { }

        public override int Run(int divisible, int divisor) => divisor == 0 ? 0 : (divisible % divisor);
        
    }
}
