using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructureOverview.Stacks
{
    public class StackExamples
    {
        public void Run()
        {
            Stack<int> stack = new Stack<int>();
            var numbers = new int[] {1 ,2 ,3 ,4 ,5};

            foreach(int number in numbers)
            {
                stack.Push(number);
            }

            var valueFromTop = stack.Peek();
            Console.WriteLine($"At the top of the stack we have the number {valueFromTop}.");

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}