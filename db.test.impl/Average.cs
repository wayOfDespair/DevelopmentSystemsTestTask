namespace db.test.impl
{
    /// <summary>
    /// Получение среднего двух чисел.
    /// </summary>
    public class Average : Plugin
    {
        public Average() : base("Average", "1.0", System.Drawing.Image.FromFile("Average.jpg"),
            "Average of two integers")
        {
        }

        public override int Run(int integer1, int integer2) => (integer1 + integer2) / 2;
    }
}
