using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        { 
         return x + y; 
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool z)
        {
            var total = x + y;

            if (z == true && total > 1)
            {
                return $"{total} dollars";
            }
            else if (z == true && total == 1)
            {
                return $"{total} dollar";
            }
            else if (z == true && total < 1)
            {
                return $"{total} dollars";
            }
            else
            {
                return total.ToString();
            }
             

        }
    }
}
