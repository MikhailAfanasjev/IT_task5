using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    abstract public class Automobile : ITransport
    {
        private int hp;
        private double width;
        private double height;
        private double length;
        private double v_tank;
        public int HP
        {
            get { return hp; }
            set { if (value > 0 && value < 1000)
                    hp = value;
                else hp = 100;
            }
        }

        public string Mark
        {
            get;
            set;
        }

        public double Width {
            get { return width; }
            set
            {
                if (value > 0 && value < 30)
                    width = value;
                else width = 1;
            }
        }
        public double Height {
            get { return height; }
            set
            {
                if (value > 0 && value < 10)
                    height = value;
                else height = 0.5;
            }
        }
        public double Length {
            get { return length; }
            set
            {
                if (value > 0 && value < 50)
                    length = value;
                else length = 1;
            }
        }
        public double TransportTax()
        {
            double result = 0;
            if (hp < 100)
                result = hp * 20;
            else if (hp < 150)
                result = hp * 30;
            else result = hp * 50;
            return result;
        }
        public double GetWatts()
        {
            return hp * 735;
        }
        public double GetSquare()
        {
            return width * height * length;
        }
    }
}
