namespace _02DistanceTravelled;

class Program
{
    static void Main(string[] args)
    {
        // accepts two command line args
        // intent: use two vars (speed and duration)
        // can be multiplied to computer total distance travelled
        // distance = speed * duration
        // print out: speed (km/h), duration (hrs), and total distance travelled (km)

        // two command line arguments --> args[0] and args[1]
        string input_speed = args[0];
        string input_duration = args[1];

        // convert string to numbers
        double speed = double.Parse(input_speed);
        double duration = double.Parse(input_duration);

        // calculate total distance travelled
        double totalDistanceTravelled = speed * duration;

        // output calculation values
        Console.WriteLine("Speed: " + speed + " km/h");
        Console.WriteLine("Duration: " + duration + " hours");
        Console.WriteLine("Travelled: " + totalDistanceTravelled + " km");
    }
}
