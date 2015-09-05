using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int t = Convert.ToInt32(Console.ReadLine());
            long sum = 0;

                String elements = Console.ReadLine();
                String[] split_elements = elements.Split(' ');
                
                for (int i = 0; i < t; i++)
                {
                    sum += Convert.ToInt32(split_elements[i]);
                }
              
                Console.WriteLine(sum);
                Console.ReadLine();
            
        }
    }
}
