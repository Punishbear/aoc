using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3 {
    class Program {
        static void Main(string[] args) {
            int input = 265149;
            int[,] dings = new int[515, 515];
            dings[207, 207] = 1;
            dings[207, 208] = 2;
            dings[206, 208] = 3;
            dings[206, 207] = 4;

            Console.ReadKey();
        }
    }
}
