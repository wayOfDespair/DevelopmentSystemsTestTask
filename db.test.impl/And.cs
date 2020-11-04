namespace db.test.impl
{
    /// <summary>
    /// Логическая побитная операция И для двух чисел.
    /// </summary>
    public class And : Plugin
    {
        public And() : base("And", "1.0", System.Drawing.Image.FromFile("And.jpg"), "And-bit operation for two integers.") { }

        public override int Run(int integer1, int integer2) =>  integer1 & integer2;
        
    }
}
