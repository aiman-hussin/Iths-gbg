using System;

namespace Iths_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = 0;

            string input = "ff29535123p48723487597645723645";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!int.TryParse(input[i].ToString(), out _))
                {
                    continue;
                }
                string number = "";
                for (int e = i + 1; e < input.Length; e++)
                {
                    if (!int.TryParse(input[e].ToString(), out _))
                    {
                        break;
                    }
                    if (input[i] == input[e])
                    {
                        for (int a = i; a <= e; a++)
                        {
                            number += input[a];
                        }
                        total += long.Parse(number);

                        for (int s = 0; s < input.Length; s++)
                        {
                            if (s >= i && s <= e)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.Write(input[s]);
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        break;
                    }
                }
            }
            Console.WriteLine("\nToltal is " + total.ToString());
        }
    }
}
