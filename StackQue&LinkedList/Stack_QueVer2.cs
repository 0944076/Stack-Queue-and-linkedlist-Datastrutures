using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // TheStack mystack = new TheStack(10);
            // mystack.push("10");
            // Console.WriteLine("=====================================");
            // mystack.push("15");
            // Console.WriteLine("=====================================");
            // mystack.peek();
            // Console.WriteLine("=====================================");
            // mystack.pop();
            // mystack.displaytheStack();
            // USE DEFAULT(TYPENAME) TO GENERATE NO VALUE
            var b = default(double);
            Console.WriteLine(b);


        }
    }

    public class TheStack
    {
        public string[] stackArray;
        public int stackSize;
        public int topOfStack = -1;

        public TheStack(int size)
        {
            this.stackSize = size;
            this.stackArray = new string[size];
            Array.Fill(this.stackArray, "-1");
        }

        public void push(string input)
        {
            if (topOfStack + 1 < stackSize)
            {
                topOfStack++;
                stackArray[topOfStack] = input;
            }
            else
            {
                Console.WriteLine("Sorry, no room!");
            }
            displaytheStack();
        }

        public string pop()
        {
            if (topOfStack >= 0)
            {

                stackArray[topOfStack] = "-1";
                return stackArray[topOfStack--];
            }
            else
            {
                return "-1";

            }
        }

        public string peek()
        {
            displaytheStack();
            Console.WriteLine(stackArray[topOfStack] + " is at the top of the stack");
            return stackArray[topOfStack];
        }

        public void displaytheStack()
        {
            for (int i = 0; i < stackArray.Length; i++)
            {
                Console.WriteLine("{0} = {1}", i, stackArray[i]);
            }
        }
    }

    public class TheQueue
    {
        public string[] queueArray;
        public int queueSize;
        public int front, rear, numberOfItems = 0;

        TheQueue(int size)
        {
            queueSize = size;
            queueArray = new string[size];
            Array.Fill(queueArray, "-1");
        }

        public void Queue(string input)
        {
            if (numberOfItems + 1 <= queueSize)
            {
                queueArray[rear] = input;
                rear++;
                numberOfItems++;
                Console.WriteLine("The insertion of " + input + " was a succes");
            }
            else
            {
                Console.WriteLine("Sorry, there was no space!");
            }
        }

        public void Dequeue()
        {
            if (numberOfItems > 0)
            {
                Console.WriteLine("Remove " + queueArray[front] + " was a succes");
                queueArray[front] = "-1";
                front++;
                numberOfItems--;
            }
            else
            {
                Console.WriteLine("Sorry but Queue is empty!");
            }
        }

        public void peek()
        {
            Console.WriteLine("The first element is " + queueArray[front]);
        }
        public void displaytheQueue()
        {
            for (int i = 0; i < queueArray.Length; i++)
            {
                Console.WriteLine("{0} = {1}", i, queueArray[i]);
            }
        }
    }
}