using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionProject
{
    class UnderstandingStack
    {
        Stack<string> mystack;
        public UnderstandingStack()
        {
            mystack = new Stack<string>();
        }
        void AddItemsToStack()
        {
            //mystack.Push("Red");
            //mystack.Push("Green");
            //mystack.Push("Black");
            mystack.Push("Red");
            mystack.Push("Green");
            mystack.Push("Black");

        }
        void PrintStack()
        {
            //foreach (var item in mystack)
            //{
            //    Console.WriteLine(item);
            //}
            while (mystack.Count > 0)
            {
                Console.WriteLine(mystack.Pop());
            }
            Console.WriteLine(mystack.Count);

        }
        static void Main(string[] a)
        {
            //    UnderstandingStack understandingStack = new UnderstandingStack();
            //    understandingStack.AddItemsToStack();
            //    understandingStack.PrintStack();
            //    Console.ReadKey();
        }
    }
}