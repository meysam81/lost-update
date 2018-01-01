using System;
using System.Threading;
namespace Rextester
{
    public class Program
    {
        static int x = 0;
        public static void f1()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("f1(" + i + "): " + x++ + "\n");
        }
        public static void f2()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine("f2(" + i + "): " + x++ + "\n");
        }
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(f1));
            Thread t2 = new Thread(new ThreadStart(f2));
            t1.Start();
            t2.Start();
        }
    }
}
