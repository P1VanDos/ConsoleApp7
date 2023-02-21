using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*int[] array = new int[12];
            Random rand = new Random();
            
              for(int i=0 ; i<array.Length; i++) 
                        {
                            array[i] = rand.Next(0,111);
                            if (array[i] < 100)
                            {
                                Console.WriteLine(array[i]);
                            }

                        }//---- 2(б)*/
            /*     int[] array = {3,4,1,4,2,7,8,3,12} ;
              for (int i = 0; i < array.Length; i++) 

               {

                   if (array[i] % 2 ==0)
                   {
                       Console.Write(array[i] + " ");
                   }
               }*///---- 2(в)





            /*  int[] array = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
              int negCount = 0;
              foreach (int number in array)
                  if (number < 0)
                      negCount++;
              Console.Write(negCount);*///---- 3

            /* int[] array = new int[12];
             Random rand = new Random();
             for (int i=0;i< array.Length; i++) 
             {
                 array[i] = rand.Next(0,100);
                 Console.WriteLine(array[i]*5);

             }*///---- 5



        }
    }
}