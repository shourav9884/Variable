using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathObj = new Math(3, 4);
            System.Console.WriteLine(mathObj.Add());
            mathObj.setxy(5, 6);
            System.Console.WriteLine(mathObj.Add());
            System.Console.ReadLine();

        }
    }
}
