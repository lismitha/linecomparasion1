using System;

namespace LineComprison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Line");
            Console.Write("Enter the Co-rdinate p1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate q1: ");
            double q1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate p2: ");
            double p2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the Co-rdinate q2: ");
            double q2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second Line");
            Console.Write("Enter the Co-rdinate A1: ");
            double A1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the Co-rdinate B1: ");
            double B1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the Co-rdinate A2: ");
            double A2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate B2: ");
            double B2 = Convert.ToDouble(Console.ReadLine());


            double PowofpointsX = Math.Pow(2, (p2 - p1));
            double PowofpointsY = Math.Pow(2, (q2 - q1));
            double LengthofLine1 = Math.Sqrt((PowofpointsX + PowofpointsY));
            Console.WriteLine("Length of the First Line is: " + LengthofLine1);

            double PowofpointsA = Math.Pow(2, (A2 - A1));
            double PowofpointsB = Math.Pow(2, (B2 - B1));
            double LengthofLine2 = Math.Sqrt((PowofpointsA + PowofpointsB));
            Console.WriteLine("Length of the Second Line is: " + LengthofLine2);

            Console.WriteLine(LengthofLine1.CompareTo(LengthofLine2));
            //Above syntax compares the length of line 1 with length of line 2. Here if length of line 1 is bigger it 
            //gives the ouput as 1, if equals then 0 and if smaller gives the ouput as -1.
            Console.ReadLine();
        }
    }
}
