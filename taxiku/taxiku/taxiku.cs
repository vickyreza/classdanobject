
using System;
namespace taraa

{
    public class taxiku
    {
        public string drivername { get; set; }
        public bool onduty { get; set; }
        public int numpassenger { get; set; }


        public void taxiinfo()
        {
            Console.WriteLine("nama driver : {0}", drivername);
            if (onduty == true)
            {
                Console.WriteLine("on duty : yes");

            }
            if (onduty == false)
            {
                Console.WriteLine("on duty : no");
            }
            Console.WriteLine("number of passenger : {0}", numpassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", drivername);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", drivername);
        }
    }
}
