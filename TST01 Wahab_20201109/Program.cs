using System;

namespace TST01_Wahab_20201109
{
    class Program
    {
        static void Main(string[] args)
        {
            //////  VRAAG 1 : 1/Lees een bedrag in van een factuur. 
            //////  2/ Indien het bedrag groter is dan 5000 euro, dan wordt er een korting van 5 % toegestaan.
            //////  3/Toon het uiteindelijke resultaat. 
            Console.WriteLine("if your invoice is bigger than 5000 $ then you will get 5% discount \n Enjoy the discount");
            Console.WriteLine(" Insert your invoice? ");
            double invoice = 0.0d;
            invoice = double.Parse(Console.ReadLine());
            double yourDiscount = 0.0d;
            double toPay = 0;

            if (invoice > 5000.00)
            {
                yourDiscount = invoice * 5 / 100;
                toPay = invoice - yourDiscount;
                Console.WriteLine($"your discount is {yourDiscount} so you have to pay {toPay} $ please");
            }
            else
            {
                Console.WriteLine("unfortunaly your invoice is less than 500 $ ");
                Console.WriteLine($"you have to pay {invoice} $ please ");
            }
            Console.WriteLine("thank you for visting us \n see you next time");
            Console.ReadLine();
        }
    }
}
