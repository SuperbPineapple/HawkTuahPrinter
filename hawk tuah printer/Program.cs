using System;

namespace HawkTuahPrinter
{

    public class HawkTuahPrinter
    {
        public static void Main()
        {
            bool hawktuah = true;
            while (hawktuah == true)
            {
                // wait borrowed from https://stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
                int milliseconds = 2000;
                Thread.Sleep(milliseconds);
                // random from https://blog.newtum.com/csharp-random-number-generator-program/
                var randvalue = new Random();
                int hawkint = randvalue.Next(1, 101);
                if (hawkint > 45)
                {
                    Console.WriteLine("Hawk Tuah!");
                }
                else
                {
                    Console.WriteLine("Hawk Tuah failed. Please wait two seconds...");
                }
            }
        }
    }
}