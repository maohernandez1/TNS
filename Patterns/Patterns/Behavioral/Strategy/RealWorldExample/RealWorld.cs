using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Behavioral.Strategy.RealWorldExample
{
    class RealWorld
    {
        //static void Main()
        //{
        //    SortedList studentRecords = new SortedList();

        //    studentRecords.Add("Samual");
        //    studentRecords.Add("Jimmy");
        //    studentRecords.Add("Sandra");
        //    studentRecords.Add("Vivek");
        //    studentRecords.Add("Anna");

        //    studentRecords.SetSortStrategy(new QuickSort());
        //    studentRecords.Sort();

        //    studentRecords.SetSortStrategy(new ShellSort());
        //    studentRecords.Sort();

        //    studentRecords.SetSortStrategy(new MergeSort());
        //    studentRecords.Sort();
        //}
    }

    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortStrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }

    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    class QuickSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort

            Console.WriteLine("QuickSorted list ");
        }
    }
    class ShellSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented

            Console.WriteLine("ShellSorted list ");
        }
    }

    class MergeSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented

            Console.WriteLine("MergeSorted list ");
        }
    }
}
