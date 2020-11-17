﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral
{
    class ObserverStructure
    {
        //static void Main()
        //{
        //    ConcreteSubject s = new ConcreteSubject();

        //    s.Attach(new ConcreteObserver(s, "X"));
        //    s.Attach(new ConcreteObserver(s, "Y"));
        //    s.Attach(new ConcreteObserver(s, "Z"));

        //    s.SubjectState = "ABC";
        //    s.Notify();
        //    Console.ReadKey();
        //}

        abstract class Subject
        {
            private List<Observer> _observers = new List<Observer>();

            public void Attach(Observer observer)
            {
                _observers.Add(observer);
            }

            public void Detach(Observer observer)
            {
                _observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (Observer o in _observers)
                {
                    o.Update();
                }
            }
        }

        class ConcreteObserver : Observer
        {
            private string _name;
            private string _observerState;
            private ConcreteSubject _subject;

            public ConcreteObserver(ConcreteSubject subject, string name)
            {
                this._subject = subject;
                this._name = name;
            }

            public override void Update()
            {
                _observerState = _subject.SubjectState;
                Console.WriteLine("Observer {0}'s new state is {1}",
                    _name, _observerState);
            }

            public ConcreteSubject Subject
            {
                get { return _subject; }
                set { _subject = value; }
            }
        }

        abstract class Observer
        {
            public abstract void Update();
        }

        private class ConcreteSubject : Subject
        {
            private string _subjectState;

            public string SubjectState
            {
                get { return _subjectState; }
                set { _subjectState = value; }
            }
        }
    }
}
