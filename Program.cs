namespace Car2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Car();
            ferrari.Color = "Red";
            ferrari.Brand = "Ferrari";
            ferrari.MaxSpeed = 200;

            Car volvo = new Car();
            volvo.Brand = "Volvo";
            volvo.Color = "Black";
            volvo.MaxSpeed = 250;

            ferrari.ShowInfo();
            ferrari.Drive();

            volvo.ShowInfo();
            volvo.Drive();

        }
    }
}
