using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Algorytm_Eratostenesa
{
  

    static class Program
    {

        private static bool[] Array = new bool[101];

    public static void Main()
        {
            int n = 100;
            bool[] primes = new bool[n + 1];

            fillArr(primes);

            Algorymt(primes);

            DisplayArray(primes);

          
      
            Console.ReadLine();
        }

     private static void fillArr(bool[] arr)
        {
            for(int i = 2; i <= arr.Length-1; i++)
            {
                arr[i] = true;
            }

           
        }

    private static void Algorymt(bool[]arr)
       {

            for(int i=2; i*i <= arr.Length-1; i++)
            {
                if (arr[i] == true)
                {
                    for(int j = i * i; j <= arr.Length-1; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }
        }           
        

   private static void DisplayArray(bool[] arr)
        {
            for(int i =2; i < arr.Length-1; i++)
            {
                if (arr[i])
                {
                    Console.WriteLine("," + i);
                }
            }
        }


    }
}
