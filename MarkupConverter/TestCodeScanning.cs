using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkupConverter
{
    internal class TestCodeScanning
    {
        static int i = 0;
        public int TestMethod()
        {
            for(i++; i%3!=0;i++)
            Console.WriteLine(i);
            return i;
        }

    }
}

class Bad
{
    public static double SolveQuadratic(double a, double b, double c)
    {
        // TODO: handle case where a == 0
        return (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
    }
}
