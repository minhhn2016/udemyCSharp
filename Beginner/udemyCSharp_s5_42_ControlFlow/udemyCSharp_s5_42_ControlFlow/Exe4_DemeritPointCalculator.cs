namespace udemyCSharp_s5_42_ControlFlow
{
    class Exe4_DemeritPointCalculator
    {
        public static int DemeritPointCalculator(int speedLimit, int carSpeed)
        {
            const int speedPerPoint = 5;
            var demeritPoints = carSpeed > speedLimit ? (carSpeed - speedLimit) / speedPerPoint : 0;
            return demeritPoints;
        }
    }
}