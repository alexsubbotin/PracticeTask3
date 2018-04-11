using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask3
{
    class Program
    {
        // Task: check if point with coordinates X and Y belongs to the region y>=|x|, |x| <=1 and y>=1, |x| < 1.
        // Student: Subbotin Alexey. Group: SE-17-1.
        static void Main(string[] args)
        {
            // Input coordinates.
            double x, y;

            // Getting the coordinates.
            bool ok;
            do
            {
                Console.Write("Enter the X coordinate: ");
                ok = Double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("Input error! Perhaps you didn't enter a real number.");
            } while (!ok);

            do
            {
                Console.Write("Enter the Y coordinate: ");
                ok = Double.TryParse(Console.ReadLine(), out y);
                if (!ok)
                    Console.WriteLine("Input error! Perhaps you didn't enter a real number.");
            } while (!ok);

            // Checking.
            bool belongs = false;

            // If |x| <= 1 then check if y >= |x|
            if(Math.Abs(x) <= 1)
            {
                if (y >= Math.Abs(x))
                    belongs = true;
            }
            // If |x| > 1 then check if y >= 1
            else
            {
                if (y >= 1)
                    belongs = true;
            }

            Console.WriteLine("Result: {0}", belongs);
            Console.ReadLine();
        }
    }
}
