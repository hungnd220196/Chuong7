using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong7
{
    abstract class Demo // abstract class
    {
         public int x = 100;
         public int y = 200;

        public abstract void Abstractmethod(); // abstract method

    }
    class DerivedClass: Demo
    {
        public override void Abstractmethod()
        {
            x++;
            y++;
        }
    }

    // demo interface
    interface ISampleInterface
    {
        void SampleMethod();
    }

    // khai bao lop cai dat interface
    class ImplementInterface: ISampleInterface 
    {
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("day la sample method");

        }
    }

    // interface chua phuong thuc thao tac chieu dai la inch
    interface IEnglishDemensions
    {
        float Length();
        float Width();

    }
    //interface thao tac voi chieu dai la cm
    interface IMetricDimensions
    {
        float Length();
        float Width();
    }
    // Khai bao lop cai dat 2 interface
    class Box : IEnglishDemensions, IMetricDimensions
    {
        float length;
        float width;

        public Box(float length, float width) { 
            this.length = length;
            this.width = width;
        }
        // cat dat cac pt cua interface IENglish theo kieu explicitly
        float IEnglishDemensions.Length()
        {
            return length;
        } 
        float IEnglishDemensions.Width()
        {
            return width;
        }
        // cat dat 
        float IMetricDimensions.Length()
        {
            return length*2.54f;
        }
        float IMetricDimensions.Width()
        {
            return width*2.54f;
        }
        
    }

}
