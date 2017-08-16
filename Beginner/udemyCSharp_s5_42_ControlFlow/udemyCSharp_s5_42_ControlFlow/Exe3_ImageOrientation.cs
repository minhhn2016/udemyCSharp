namespace udemyCSharp_s5_42_ControlFlow
{
    class Exe3_ImageOrientation
    {
        public static bool ImageOrientation(int a, int b)
        {
            var isPortrait = a <= b ? true : false;
            return isPortrait;
        }
    }
}