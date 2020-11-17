using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Facade
{
    class Structure
    {
        //public static void Main()
        //{
        //    Facade facade = new Facade();
        //    facade.MethodA();
        //    facade.MethodB();

        //    Console.WriteLine();
        //}
    }

    public class Facade
    {
        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ----");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ----");
            _two.MethodTwo();
            _four.MethodFour();
        }
    }

    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemOne");
        }
    }
    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemTwo");
        }
    }
    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemThree");
        }
    }
    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubSystemFour");
        }
    }
}
