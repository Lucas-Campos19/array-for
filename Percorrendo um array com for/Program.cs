using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percorrendo_um_array_com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = i;
                Console.WriteLine("O valor do array e i: {0}= {1} ",num[i],i);
            }
            Console.ReadKey();
        }
    }
}
