namespace leeperkins.experimental
{
    public class thing
    {
        public int Bobber { get; }

        public thing() {
            Bobber = 5;
        }

        public int GenerateDoubleBobber() {
            return 2 * Bobber;
        }

        public int GenerateTrippleBobber() {
            return Bobber * 3;
        }
    }
}