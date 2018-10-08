using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    static public class TriangleSolver
    {
        static public string Analyze(int a, int b, int c)
        {
            // check if it is a triangle
            if ((a + b < c) || (b + c < a) || (a + c < b))
            {
                return "NotATriangle";
            }
            // check if it is equilateral or isosceles
            // considering the 3 variations
            if (a == b)
            {
                if (a == c)
                {
                    return "equilateral";
                }
                return "isosceles";
            }
            if (a == c)
            {
                if (a == b)
                {
                    return "equilateral";
                }
                return "isosceles";
            }
            if (b == c)
            {
                if (b == a)
                {
                    return "equilateral";
                }
                return "isosceles";
            }
            // if none of above, it's scalene
            return "scalene";
        }
    }
}