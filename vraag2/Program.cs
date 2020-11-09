using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace vraag2
{
    class Program
    {
        static void Main(string[] args)
        {

            // VRAAG 2/ Maak een paswoordgenerator. 
            //Deze generator maakt een willekeurig paswoord aan van 5 willekeurige karakters (letters en/of cijfers) 

            //Breng eerst in een array de letters van het alfabet(kleine letters en hoofdletters) alsook de cijfers

            // Haal vervolgens 5 karakters uit deze array en breng deze onder in een nieuwe array

            // Geef vervolgens het paswoord op het scherm. 

            // Vraag aan de gebruiker of er nog een paswoord moet gegenereerd worden met ja of neen. 

            // Bij neen stopt het programma.



            //string[] unicode =  {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
            //                     "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
            //                     "1","2","3","4","5","6","7","8","9","10"};
            //StringBuilder PwString = new StringBuilder;
            //Random pWRandom = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    pWRandom.Append(unicode[pWRandom.Next(unicode.Length)]);
            //    Console.Write();
            //}


            string unicode = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
           
            char[] chars = new char[5];
            for (int i = 0; i < 4; i++)
            {
                chars[i] = unicode[random.Next(0, unicode.Length)];
                Console.Write(chars[i]);
            }
            
            Console.WriteLine("Do you want to change your pw then press 'enter'");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your new pw please then press 'enter' ");
            Console.ReadLine();




        }
} 
