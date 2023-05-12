using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    static public class Recursividade
    {
        public static void ContarRegressivamente(int i)
        {
            Console.WriteLine(i);
            if (i <= 0) return;
            else ContarRegressivamente(i - 1);
        }

        public static int CalcularFatorial(int x)
        {
            if (x == 1) return 1;
            else return x * (CalcularFatorial(x - 1));
        }
    }
}
