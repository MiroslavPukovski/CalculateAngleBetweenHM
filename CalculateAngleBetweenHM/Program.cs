



namespace CalculateAngleBetweenHM
{

    class Program
    {
        static void Main(string[] args)
        {
            InputDisplay();
        }

        static void InputDisplay()
        {
            bool hourInput = true;
            bool minuteInput = true;
            int hours;
            int minutes;
            double result;

            //Verifying hours input
            do
            {
                Console.Write("Please Enter the hours: ");
                bool isHours = Int32.TryParse(Console.ReadLine(), out hours);
                if (!isHours)
                    Console.WriteLine("Input must be only numbers");

                if (hours < 0 || hours > 12)
                    Console.WriteLine("Wrong input, must be between 0 and 12");
                else if(isHours)
                    hourInput = false;
                    

            } while (hourInput);

            //Verifying minutes input
            do
            {
                Console.Write("Please Enter the minutes: ");
                bool isMinutes = Int32.TryParse(Console.ReadLine(), out minutes);
                if(!isMinutes)
                    Console.WriteLine("Input must be only numbers");

                if (minutes < 0 || minutes > 60)
                    Console.WriteLine("Wrong input, must be between 0 and 60");
                else if(isMinutes)
                    minuteInput = false;

            } while (minuteInput);



            result = HMdegreeCalculation(hours, minutes);

            Console.WriteLine("*********************************************");
            Console.WriteLine($"  Angle between {hours}h and {minutes}m is {result} degrees   ");
            Console.WriteLine("*********************************************");
        }

        //Calculation Logic
        static double HMdegreeCalculation(int H, int M)
        {
            double Hdegrees = (H * 30) + (M * 30.0 / 60);
            double Mdegrees = M * 6;

            double HMdifference = Math.Abs(Hdegrees - Mdegrees);

            if (HMdifference > 180)
                HMdifference -= 360;

            return Math.Abs(HMdifference);
        }


    }






}
