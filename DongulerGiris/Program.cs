using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongulerGiris
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 1; i < 20;i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i =1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            for (int i = 2; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 20; i > 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int index = 65; index <= 90; index++)
            {
                Console.WriteLine((char)index + " ");
            }
            for (char index = 'A'; index <= 'Z'; index++)
            {
                Console.WriteLine(index + " ");
            }
            for (char index = 'A'; index <='z'; index++)
            {
                if((index >= 'A' && index <= 'Z') || (index >= 'a' && index <= 'z'))
                {
                    Console.WriteLine(index + " ");
                }                
            }
            int x;
            for (x = 1; x <= 5; x++)
            {

            }
            Console.WriteLine(x);
            for (int i = 1; i <= 5; i++ )
            {
                for(int r = 1; r <= i; r++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int r = 1; r <= i; r++)
                {
                    Console.Write("*");
                }
                    
                Console.WriteLine();
            }
            for (int i = 5; i >= 0; i--)
            {
                for (int r = i; r >= 0; r--)
                {
                    Console.Write("*");
                }
                    
                Console.WriteLine();
            }
            for(int i = 0; i<=10; i++)
            {
                if(i<=5)
                {
                    for(int r = 0; r < i; r++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for(int r = 10; r > i; r--)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
    }
}
