using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.ConsoleApplication2
{
    public class OthersProgram
    {
        public static void MainTwo(string[] args)
        {
            #if !Debug
                Console.WriteLine("----OTHERS-----");

                for (int i = 1; i <= 8; i++)
                {
                    Console.WriteLine("\n");
                    for (int j = 1; j <= 4; j++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("O ");
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.Write("X ");
                            Console.Write("O ");
                        }
                    }
                }

                Console.ReadLine();
            #endif
        }
    }
}