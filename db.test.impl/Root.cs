namespace db.test.impl
{
    /// <summary>
    /// Вычисление корня числа указанной степени. При некорректных данных возвращает 0 или -1 в случае  отрицательной нечётной степени и отрицательного числа.
    /// </summary>
    public class Root : Plugin
    {
        public Root() : base("Root", "1.0", System.Drawing.Image.FromFile("Root.jpg"), "Root of an integer of a degree.") { }

        public override int Run(int integer, int rootDegree)
        {
            if (integer <= 0 && rootDegree % 2 == 0 || integer == 0 || rootDegree <= 0)
                if (rootDegree % 2 < 0 && integer < 0)
                    return -1;
                else
                    return 0;

            var mod = integer > 0 ? 1 : -1;
            var i = 0;
            int t;
            
            do
            {
                i++;
                t = i;
                for (var k = rootDegree - 1; k > 0; k--)
                {
                    t *= i;
                }
                
            } while (t < mod * integer);
            
            return mod * i;
        }
    }
}
