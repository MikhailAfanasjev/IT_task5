using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Truck: Automobile
    {
        private double carryingCapasity;
        private double weight;
        private double vt;
        private double fuel100;
        public double CarryingCapasity
        {
            get { return carryingCapasity; }
            set
            {
                if (value > 0 && value < 1000)
                    carryingCapasity = value;
                else carryingCapasity = 1;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0 && value < 1000)
                    weight = value;
                else weight = 3.5;
            }
        }
        public double VT 
        {
            get { return vt; }
            set
            {
                if (value > 0 && value < 1000)
                    vt = value;
                else vt = 50;
            }
        }
        public double Fuel100
        {
            get { return fuel100; }
            set
            {
                if (value > 0 && value < 1000)
                    fuel100 = value;
                else fuel100 = 3.5;
            }
        }
        public double FullMass()
        {
            return carryingCapasity + weight;
        }
        public double Distanse()
        {
            return vt / fuel100 * 100;
        }
    }
}
