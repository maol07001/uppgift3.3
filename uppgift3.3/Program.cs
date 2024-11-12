using System;

namespace uppgift_3._3
{
    class Program
    {
        static void Main()
        {
            int timAvgift = 80;
            int maxDagAvgift = 950;

            Console.Write("Hur många timmar vill du hyra bilen? ");
            int timmar = int.Parse(Console.ReadLine());

            int kostnad = timmar * timAvgift;

                if (kostnad > maxDagAvgift)
                {
                    kostnad = maxDagAvgift;
                }

            Console.WriteLine("Kostnaden för att hyra bilen är " + kostnad + " kr.");
        }
    }
}