using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileVeDoWhile
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i + " ");
                i++;
            }

            Console.WriteLine("Begin");
            i = 1;
            do
            {
                Console.WriteLine(i + " ");
                i++;
            } while (i <= 10);
            Console.WriteLine("End");


            Console.ReadLine();
        }
    }
}
