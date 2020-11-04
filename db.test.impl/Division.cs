namespace db.test.impl
{
    /// <summary>
    /// Деление двух чисел. При делении на 0 возвращает максимально возможное значение.
    /// </summary>
    public class Division : Plugin
    {
        public Division() : base("Division", "1.0", System.Drawing.Image.FromFile("Division.jpg"), "The quotient of two integers.") { }

        public override int Run(int divisible, int divisor) => divisor == 0 ? int.MaxValue : (divisible / divisor);
    }
}
