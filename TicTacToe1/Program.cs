using System;

namespace TicTacToe1
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            {

                Console.WriteLine("     |     |      ");

                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]); ;

                Console.WriteLine("_____|_____|_____ ");

                Console.WriteLine("     |     |      ");

                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

                Console.WriteLine("_____|_____|_____ ");

                Console.WriteLine("     |     |      ");

                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

                Console.WriteLine("     |     |      ");


                Console.WriteLine("Player 1 chose x or o");
                string input = Console.ReadLine().ToLower();
                if (input == "x")
                {

                }
               
            }
        }
    }
}
