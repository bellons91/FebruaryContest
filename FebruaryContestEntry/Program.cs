using System;

namespace FebruaryContestEntry
{
    class Program
    {
        const char block = '▓';

        static void Main(string[] args)
        {
            // The solution implementation goes here

            PrintSquare();

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Yay, a colorful shape!");
            Console.ReadLine();
        }

        static void PrintSquare()
        {
            int maxRows = 15;
            int maxCols = 30;

            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (col == 0 || row == 0 || col == (maxCols - 1) || row == (maxRows - 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(block);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(block);
                        Console.ResetColor();
                    }

                    if (col == maxCols - 1)
                        Console.WriteLine();

                }

            }

        }
    }


}
