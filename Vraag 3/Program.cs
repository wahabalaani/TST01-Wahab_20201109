using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a postcode ");
            string[] steden = { "Allest", "Antwerpen", "Brussel", "Dondermonde", "Gent", "Kortrijk", "oudenaarde", "turenhout" };
            int[] postCoden = { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };

            int postCode = Int32.Parse(Console.ReadLine());
            int o = 0;

            do
            {



                if (postCode == postCoden[o])
                {
                    Console.WriteLine($"{postCoden[o]} is the post code of {steden[o]}");
                    break;
                }

                if (postCode != postCoden[0])
                {
                    Console.WriteLine($"not valid");
                }
                o++;

            } while (o == postCoden.Length);





            Console.ReadLine();

            //for (int i = 0; i < steden.Length; i++)
            //{
            //    if (postCode == postCoden[i])
            //    {

            //        Console.WriteLine($"{postCoden[i]} is the post code of {steden[i]}");
            //        break;
            //    }
            //}

        }
    }
}

