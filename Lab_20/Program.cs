using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20
{
    class Program
    {
        delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = PowerAB;
            int r = myDelegate(2, 10);
            Console.WriteLine(r);

            myDelegate = PowerBA;
            r = myDelegate(2, 10);
            Console.WriteLine(r);

            Console.ReadKey();
        }
    
        static int PowerAB (int a, int b) => (int)Math.Pow(a, b);
        static int PowerBA (int a, int b) => (int)Math.Pow(b, a);
       
    }
}
