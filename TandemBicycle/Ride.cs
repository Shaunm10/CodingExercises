namespace CodingExercises.TandemBicycle
{
    public class Ride
    {
        private readonly int redRiderSpeed;
        private readonly int blueRiderSpeed;
        public Ride(int redRiderSpeed, int blueRiderSpeed)
        {
            this.redRiderSpeed = redRiderSpeed;
            this.blueRiderSpeed = blueRiderSpeed;
        }

        public int Speed
        {
            get
            {
                return Math.Max(this.redRiderSpeed, this.blueRiderSpeed);
            }
        }
    }
}