using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Races.DAL.Cars;
using Console = System.Console;

namespace Races.DAL
{
    public class Service
    {
       
        public void PrintStart()
        {
            Console.WriteLine("---------Start of Game----------");
            for (int i = 3; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }

            Console.WriteLine("-------------START--------------");
            
        }

        public void PrintWinner(Game game)
        {
            Console.WriteLine("------------WINNER--------------");
            Console.WriteLine($"               {game.Winner.Name}    ");
            Console.WriteLine("--------------------------------");
        }
    }
}
