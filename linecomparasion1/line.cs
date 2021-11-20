using System;

namespace LineComprison
{
    class line
    {
        static void Main(string[] args)
           
            {
                Console.Write("Enter the Co-rdinate p1: ");
                Double p1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Co-rdinate q1: ");
                Double q1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Co-rdinate p2: ");
                Double p2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Co-rdinate q2: ");
                Double q2 = Convert.ToDouble(Console.ReadLine());

            double Powofpoints1 = Math.Pow(2, (p2 - p1));
                double Powofpoints2 = Math.Pow(2, (q2 - q1));
                double LengthofLine = Math.Sqrt((Powofpoints1 + Powofpoints2));

                Console.WriteLine("Length of the Line is: " + LengthofLine);
                Console.ReadLine();
            }
        }
    }
