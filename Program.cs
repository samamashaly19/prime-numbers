using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int i = 0;
            int prime = 0;
            Console.WriteLine("please enter the first number");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int n2=int.Parse(Console.ReadLine());
            
            for( i = n1;i <= n2;i++)
            {
                j = 2;
                prime = 0;
                while(j<=(i/2))
                {
                    if(i%j==0)
                    {
                        prime = 1;
                        break;
                    }
                    j++;    
                }
                if(prime==0)
                    Console.WriteLine(i + " ");
            }
        }
    }
}
