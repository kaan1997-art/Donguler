using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]
            {
                "Çağıl",
                "Leo",
                "Angel"
            };
            int i = 0;
            foreach (string student in students)
            {
                i++;
                Console.WriteLine($"{i}. Öğrenci: {student}");
            }
            for (int r = 0; r < students.Length; r++)
            {
                Console.WriteLine((r + 1) + ". Öğrenci" + students[r]);
            }

            int j = 0;
            while (j < students.Length)
            {
                Console.WriteLine((j + 1) + ". Öğrenci" + students[j]);
                j++;
            }
            int k = 0;
            do
            {
                Console.WriteLine("{0}. Öğrenci: {1}", k + 1, students[k]);
                k++;
            } while (k < students.Length);
            

            Console.ReadLine();
            
        }
    }
}
