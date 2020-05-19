using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку символов: ");
            string s = Convert.ToString(Console.ReadLine());
            string prepin = " ,.!:;?-";
            string[] razd = s.Split(prepin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(razd, (a, b) => a.Length - b.Length);
            foreach (string w in razd)
            {
                Console.WriteLine(w);
            }
            Console.ReadKey();
        }
    }
}
