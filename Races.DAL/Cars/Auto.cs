using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Races.DAL.Cars
{
    public enum TypeOfCar
    {
        SportCar, Truck, PassangerCar, Bus
    }
    public class Auto : Car
    {
        public int Speed { get; set; }
        public TypeOfCar Type { get; set; }
        public override void Drive()
        {
            Random Rnd = new Random();
            switch (Position)
            {
                case double position when Position > 10 && Position <= 20:
                    {
                        Speed = Rnd.Next(2);
                        break;
                    }
                case double position when Position > 20 && Position <= 30:
                    {
                        Speed = Rnd.Next(3);
                        break;
                    }
                case double position when Position > 30 && Position <= 40:
                    {
                        Speed = Rnd.Next(4);
                        break;
                    }
                case double position when Position > 40 && Position <= 50:
                    {
                        Speed = Rnd.Next(2);
                        break;
                    }
                case double position when Position > 50 && Position <= 60:
                    {
                        Speed = Rnd.Next(6);
                        break;
                    }
                case double position when Position > 70 && Position <= 80:
                    {
                        Speed = Rnd.Next(5);
                        break;
                    }
                case double position when Position > 80 && Position <= 90:
                    {

                        break;
                    }
                case double position when Position > 90 && Position <= 100:
                    {
                        Speed = Rnd.Next(7);
                        break;
                    }
            }
            Position += Speed;
            Thread.Sleep(50);
        }
    }




}
