using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCommonAreaOfCirclesSearch
{
    public class Circle
    {
        private double _xCoord;
        private double _yCoord;
        private double _radius;
        public double XC
        {
            get { return _xCoord; }
            set { _xCoord = value; }
        }
        public double YC
        {
            get { return _yCoord; }
            set { _yCoord = value; }
        }
        public double Rad
        {
            get { return _radius; }
            set { _radius = value; }
        }
    }
}
