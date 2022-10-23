namespace CodingExercises.TandemBicycle
{
    public class Exercise
    {

        /*
        A tandem bicycle is a bicycle that's operated by two people: person A and person B. 
        Both people pedal the bicycle, but the person that pedals faster dictates 
        the speed of the bicycle. So if person A pedals at a speed of 5, and 
        person B pedals at a speed of 4, the tandem bicycle moves at a 
        speed of 5 (i.e., tandemSpeed = max(speedA, speedB)).

        You're given two lists of positive integers: one that contains the 
        speeds of riders wearing red shirts and one that contains the speeds 
        of riders wearing blue shirts. Each rider is represented by a single 
        positive integer, which is the speed that they pedal a tandem bicycle at. 
        Both lists have the same length, meaning that there are as many 
        red-shirt riders as there are blue-shirt riders. Your goal is to pair 
        every rider wearing a red shirt with a rider wearing a blue shirt to operate a tandem bicycle.

        Write a function that returns the maximum possible total speed or the minimum possible total speed 
        of all of the tandem bicycles being ridden based on an input parameter, fastest. 
        If fastest = true, your function should return the maximum possible total speed; 
        otherwise it should return the minimum total speed.

        "Total speed" is defined as the sum of the speeds of all the tandem bicycles being ridden. 
        For example, if there are 4 riders (2 red-shirt riders and 2 blue-shirt riders) who have 
        speeds of 1, 3, 4, 5, and if they're paired on tandem bicycles as follows: [1, 4], [5, 3], 
        then the total speed of these tandem bicycles is 4 + 5 = 9.
        */
        public static int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            var redShirtSpeedsList = redShirtSpeeds.ToList();
            var blueShirtSpeedsList = blueShirtSpeeds.ToList();

            var rides = new List<Ride>();

            if (fastest)
            {
                // assumption: 
                var riderCount = Math.Min(redShirtSpeedsList.Count(), redShirtSpeedsList.Count());

                for (int i = 0; i < riderCount; i++)
                {
                    var maxRed = redShirtSpeedsList.Max();
                    var maxBlue = redShirtSpeedsList.Max();

                    // if blue is the fastest speed
                    if (maxBlue > maxRed)
                    {
                        // we want to drive this ride by the blue rider.
                        var redMin = redShirtSpeedsList.Min();
                        rides.Add(new Ride(redMin, maxBlue));
                        redShirtSpeedsList.Remove(redMin);
                        blueShirtSpeedsList.Remove(maxBlue);

                    }
                    else
                    {
                        // we want to drive this ride by the red rider.
                        var blueMin = blueShirtSpeedsList.Min();
                        rides.Add(new Ride(maxRed, blueMin));
                        redShirtSpeedsList.Remove(maxRed);
                        blueShirtSpeedsList.Remove(blueMin);
                    }
                }

                return rides.Sum(x => x.Speed);
            }

            var slowestRedRider = redShirtSpeeds.Max();
            var slowestBlueRider = blueShirtSpeeds.Max();
            return Math.Max(slowestBlueRider, slowestRedRider);

        }

    }
}