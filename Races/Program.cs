using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Races.DAL.Cars;

namespace Races
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            Car sportCar = new Auto()
            {
                Name = "Sport Car",
                Speed = 1
            };
            Car Bus = new Auto()
            {
                Name = "Bus",
                Speed = 1
            };
            Car Track = new Auto()
            {
                Name = "Track",
                Speed = 1
            };
            Car PassangerCar = new Auto()
            {
                Name = "Passanger Car",
                Speed = 1
            };


            sportCar.Join(game);
            Bus.Join(game);
            Track.Join(game);
            PassangerCar.Join(game);


            game.StartGame();

            game.Win(game);

            Console.ReadLine();
        }

    }
}
