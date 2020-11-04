namespace db.test.impl
{
    /// <summary>
    /// Получение минимального из двух чисел.
    /// </summary>
    public class Min : Plugin
    {
        public Min() : base("Minimum", "1.0", System.Drawing.Image.FromFile("Min.jpg"), "Minimum of two integers.") { }

        public override int Run(int integer1, int integer2) =>  integer1 <= integer2 ? integer1 : integer2;
        
    }
}
