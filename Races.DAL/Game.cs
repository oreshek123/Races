using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RandomNameGenerator;

namespace Races.DAL.Cars
{

    public delegate void Drive();
    public delegate void SetPosition(int position);
    public delegate void Printstart();
    public delegate void PrintWinner(Game game);

    public class Game
    {
        protected bool isStart = true;
        public Drive Drive;
        public SetPosition MoveTo;
        public Car Winner;
        public Printstart OnStart;
        public PrintWinner Win;
        public void StartGame()
        {
            Service service = new Service();
            OnStart += service.PrintStart;
            OnStart();
            MoveTo(0);
            while (isStart)
            {    
                Drive();
                Thread.Sleep(100);
                Console.Clear();
            }

            Win = service.PrintWinner;
        }

        public void OnFinish(Car winner)
        {
            
            isStart = false;
            this.Winner = winner;
        }

        
    }
}
