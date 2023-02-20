using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace Generic_20_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringList strList = new StringList();
            MyList<string> strList = new MyList<string>();


            strList.Add("Abbas");
            strList.Add("Elnur");
            strList.Add("Ismayil");

            strList.Remove(2);


            foreach (var item in strList.Arr)
            {
                Console.WriteLine(item);
            }



            IntList intList = new IntList();

            intList.Add(5);
            intList.Add(10);
            intList.Add(15);

            Console.WriteLine("======Dictionary======");

            Dictionary<string, int> students = new Dictionary<string, int>();

            students.Add("Abbas", 10);
            students.Add("Elnur", 20);

            Console.WriteLine(students.ContainsKey("Abbas"));


            Dictionary<int, string> teacers = new Dictionary<int, string>();

            teacers.Add(101, "Fuad");
            teacers.Add(102, "Ulvi");
            teacers.Add(103, "Ismayil");
            teacers.Add(104, "Ferid");

            foreach (var item in teacers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n============SortedList===============");
            SortedList<string, int> sortedList = new SortedList<string, int>();

            sortedList.Add("Tofiq", 10);
            sortedList.Add("Yusif", 10);
            sortedList.Add("Miri", 10);
            sortedList.Add("Aziz", 10);

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========Stack=========");

            Stack <int>stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            
            var value=stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("==========Queue=======");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(20);
            queue.Enqueue(40);
            queue.Enqueue(60);

            value = queue.Dequeue();
            value =queue.Peek();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }



            
        }
    }
}
