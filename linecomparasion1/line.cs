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

            double PowofpointsX = Math.Pow(2, (p2 - q1));
            double PowofpointsY = Math.Pow(2, (p2 - q1));
            double LengthofLine1 = Math.Sqrt((PowofpointsX + PowofpointsY));
            Console.WriteLine("Length of the Line is: " + LengthofLine1);

            double PowofpointsA = Math.Pow(2, (A2 - A1));
            double PowofpointsB = Math.Pow(2, (B2 - B1));
            double LengthofLine2 = Math.Sqrt((PowofpointsA + PowofpointsB));
            Console.WriteLine("Length of the Line is: " + LengthofLine2);

            Console.WriteLine(LengthofLine1.Equals(LengthofLine2));
            Console.ReadLine();
        }
    }
}
