using System;


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
            do
            {
                playGame = true;
                IsRestart = false;
                xPos = random.Next(tabel.GetLength(0));
                yPos = random.Next(tabel.GetLength(0));
                for (int i = 0; i < tabel.GetLength(0); i++)
                {
                    for (int j = 0; j < tabel.GetLength(1); j++)
                    {
                        tabel[i, j] = '-';
                    }
                }
                do
                {
                    Compare(xInput, xPos, 'x');
                    Compare(yInput, yPos, 'y');
                    for (int i = 0; i < tabel.GetLength(0); i++)
                    {
                        for (int j = 0; j < tabel.GetLength(1); j++)
                        {
                            Console.Write($"{tabel[j, i]}\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nGeef een rij (0-9)");
                    xInput = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Geef een kolom (0-9)");
                    yInput = Convert.ToInt32(Console.ReadLine());
                    tabel[xInput, yInput] = 'x';
                    Console.Clear();
                    if (xInput == xPos && yInput == yPos)
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
                            IsRestart = true;
                            playGame = false;
                            xInput = -1;
                            yInput = -1;
                            Console.Clear();
                        }
                    }
                } while (playGame);  
            } while (IsRestart);
        }
        static void Compare(int input, int pos, char orientation)
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
