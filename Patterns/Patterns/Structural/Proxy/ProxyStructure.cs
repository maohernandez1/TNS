using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Proxy
{
    class ProxyStructure
    {
        //static void Main()
        //{
        //    ProxyPattern proxy = new ProxyPattern();
        //    proxy.Request();

        //    Console.ReadKey();
        //}

        private class ProxyPattern : Subject
        {
            private RealSubject _realSubject;
            public override void Request()
            {
                //Lazi Init
                _realSubject ??= new RealSubject();
                _realSubject.Request();
            }
        }

        abstract class Subject
        {
            public abstract void Request();
        }

        class RealSubject : Subject
        {
            
            public override void Request()
            {
                Console.WriteLine("Called RealSubject.Request()");
            }
        }
    }
}
