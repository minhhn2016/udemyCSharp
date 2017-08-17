namespace udemyCSharp_s5_48_Loops
{
    class Exe1_DivisorCount
    {
        public static int DivisorCount()
        {
            var counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}