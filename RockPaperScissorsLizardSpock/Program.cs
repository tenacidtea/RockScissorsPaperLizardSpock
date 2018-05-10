using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nWelcome to the Rock, Paper, Scissors, Lizard, Spock Game!");
            Console.WriteLine("\n\nPlease choose the number of Players:");
            Console.SetCursorPosition(36, 5);
            string numberOfPlayers = Console.ReadLine();
        }
    }
}
