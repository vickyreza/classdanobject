using System;

namespace taraa
{
    public class program
    {
        static void Main(string[] args)
        {
            taxiku taxi = new taxiku();

            taxi.drivername = "dias;";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            taxi.taxiinfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        }
    }
}