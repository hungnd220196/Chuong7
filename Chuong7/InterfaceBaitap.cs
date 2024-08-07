using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong7
{


    //bt11
    public interface ISHowId
    {
        public string Id { get; set; }

    }
    class Employee : ISHowId
    {
        public string _id = "rk-009";
        public string Id

        {
           get => _id; set => _id = value;
        }
    }


    //b12
    public interface IDimensions
    {
        double Area();
        double Circumference();
    }

    public class Circle : IDimensions
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

    }


    //b13
    interface IPoint
    {
        // Property signatures:
        int x
        {
            get;
            set;
        }
        int y
        {
            get;
            set;
        }
    }
    class MyPoint : IPoint
    {
        // Fields:
        private int myX;
        private int myY;
        // Constructor:
        public MyPoint(int x, int y)
        {
            myX = x;
            myY = y;
        }
        // Property implementation:
        public int x
        {
            get
            {
                return myX;
            }
            set
            {
                myX = value;
            }
        }
        public int y
        {
            get
            {
                return myY;
            }
            set
            {
                myY = value;
            }
        }
    }


    //bt14
    interface IDisplay
    {
        string Getname();

    }

    class Dog : IDisplay
    {
        public string name;
        public Dog(string name)
        {
            this.name = name;
        }

        string IDisplay.Getname()
        {
            return name;
        }
    }

    class Cat : IDisplay
    {
        public string name;

        public Cat(string name)
        {
            this.name = name;
        }

        string IDisplay.Getname()
        {
            return name;
        }

    }
}



