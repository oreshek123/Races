using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Races.DAL.Cars
{
    public delegate void FinishGame(Car winner);
    public delegate void PropertyeventHandler(object sender, PropertyEventArgs e);
    public abstract class Car : IPropertychanged
    {
        public event PropertyeventHandler Propertychanged;
        public FinishGame Finish;
        protected Random Rnd = new Random();
        private double position_;
        public double Position
        {
            get => position_;
            set
            {
                position_ = value;

                OnPropertychanged(new PropertyEventArgs(position_, "Position"));

                Console.WriteLine(this.Name + " on position " + position_);
                if (position_ > 100) Finish(this);
            }
        }

        public string Name { get; set; }
        public double SumV { get; set; }

        public abstract void Drive();

        public void Join(Game game)
        {
            game.Drive += this.Drive;
            game.MoveTo += this.MoveTo;
            Finish += game.OnFinish;
        }
        public void MoveTo(int pos)
        {
            this.Position = pos;
        }

        protected virtual void OnPropertychanged(PropertyEventArgs e)
        {
            Console.WriteLine(e.ToString() +": was changed");
        }
    }
}
