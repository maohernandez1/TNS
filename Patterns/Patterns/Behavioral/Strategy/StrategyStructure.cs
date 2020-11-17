using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral.Strategy
{
    class StrategyStructure
    {
        //static void Main()
        //{
        //    Context context;

        //    context = new Context(new ConcreteStrategyA());

        //    context.ContextInterface();

        //    context = new Context(new ConcreteStrategyB());
        //    context.ContextInterface();

        //    context = new Context(new ConcreteStrategyC());
        //    context.ContextInterface();

        //    Console.ReadKey();
        //}
    }

    class Context
    {
        private Strategy _strategy;

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyB : Strategy

    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    class ConcreteStrategyC : Strategy

    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }

    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
}
