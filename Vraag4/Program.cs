using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag4
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int xPos = 0;
            int yPos = 0;
            int xInput = -1;
            int yInput = -1;
            bool IsRestart = false;
            bool playGame = true;
            char[,] tabel = new char[10, 10];
            do//this only loops again when the game is restarted
            {
                playGame = true;//the game loop should play
                IsRestart = false;//the game should not restart by default after a game loop
                xPos = random.Next(tabel.GetLength(0));//new random value assigned
                yPos = random.Next(tabel.GetLength(0));
                for (int i = 0; i < tabel.GetLength(0); i++)//table is filled with '-'
                {
                    for (int j = 0; j < tabel.GetLength(1); j++)
                    {
                        tabel[i, j] = '-';
                    }
                }
                do//main game loop
                {
                    //Console.WriteLine($"x = {xPos}");
                    //Console.WriteLine($"y = {yPos}");
                    Compare(xInput, xPos, 'x');
                    Compare(yInput, yPos, 'y');
                    for (int i = 0; i < tabel.GetLength(0); i++)//the table is shown
                    {
                        for (int j = 0; j < tabel.GetLength(1); j++)
                        {
                            Console.Write($"{tabel[j, i]}\t");
                        }
                        Console.WriteLine();
                    }
                    //user input
                    Console.WriteLine("\nGeef een rij (0-9)");
                    xInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geef een kolom (0-9)");
                    yInput = Convert.ToInt32(Console.ReadLine());
                    tabel[xInput, yInput] = 'x';
                    Console.Clear();
                    if (xInput == xPos && yInput == yPos)//check if user found the egg
                    {
                        Console.WriteLine($"x = {xPos}");
                        Console.WriteLine($"y = {yPos}");
                        Console.WriteLine("Je hebt het ei gevonden!");
                        Console.WriteLine("Druk <enter> om opnieuw to spelen of typ <e> om te stoppen");
                        if (Console.ReadLine().ToLower() == "e")
                        {
                            playGame = false;
                            Console.Clear();
                        }
                        else
                        {
                            //when enter is pressed without typing anything or the character entered is not 'e' 
                            IsRestart = true;
                            playGame = false;
                            //user input is reset
                            xInput = -1;
                            yInput = -1;
                            Console.Clear();
                        }
                    }
                } while (playGame);//end of main game loop   
            } while (IsRestart);
        }
        static void Compare(int input, int pos, char orientation)//tells the user which orientation the egg is pointed compared to the user input
        {
            if (input != -1)
            {
                if (orientation == 'x')
                {
                    if (input > pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het westen.");
                    }
                    else if (input < pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het oosten.");
                    }
                }
                else if (orientation == 'y')
                {
                    if (input > pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het noorden.");
                    }
                    else if (input < pos)
                    {
                        Console.WriteLine("Het ei ligt meer in het zuiden.");
                    }
                }
            }

        }
    }
}
