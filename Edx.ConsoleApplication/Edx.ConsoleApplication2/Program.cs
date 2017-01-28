using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx.ConsoleApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
             #if Debug
                Console.WriteLine("----LP-----");

                string chessBoard;

                for (int i = 0; i < 8; i++)
                {
                    chessBoard = i % 2 == 0 ? "X" : "O";

                    for (int j = 0; j < 7; j++)
                    {
                        chessBoard = string.Format("{0}{1}", chessBoard, chessBoard[j] == 'O' ? "X" : "O");
                    }

                    Console.WriteLine(chessBoard);
                }

                Console.ReadKey();
            #else
                OthersProgram.MainTwo(null);
            #endif


        }
    }
}
