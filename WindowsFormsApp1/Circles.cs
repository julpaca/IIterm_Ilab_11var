using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Circle
    {
        private double xCoord;
        private double yCoord;
        private double radius;
        public double xC
        {
            get { return xCoord; }
            set { xCoord = value; }
        }
        public double yC
        {
            get { return yCoord; }
            set { yCoord = value; }
        }
        public double rad
        {
            get { return radius; }
            set { radius = value; }
        }
        /*public Circle(double x,double y,double z)
        {
            double xCoord=x;
            double yCoord=y;
            double radius=z;
        }*/

        /*public class FirstCircle : Circle
        {
            public double[] GetValues()
            {
                double[] arr = { xCoord, yCoord, radius };
                return arr;
            }
        }
        public class SecondCircle : Circle 
        {
            *//*    public static double xCoord;
                public static double yCoord;
                public static double radius;*/
        /*public double[] GetValues()
        {
            double[] arr = { xCoord, yCoord, radius };
            return arr;
        }*//*
    }*/
    }
}
