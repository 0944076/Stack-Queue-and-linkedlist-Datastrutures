using System;

namespace StackQue
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TheStack
    {
        public string[] stackArray;
        public int stackSize;
        public int topofStack = -1;

        public TheStack(int size)
        {
            this.stackSize = size;
            this.stackArray = new string[size];

            Array.Fill(this.stackArray, "-1");
        }

        public void Push(string input)
        {
            if(topofStack + 1 < stackSize)
            {
                topofStack++;
                stackArray[topofStack] = input;
            }
            else
            {
                System.Console.WriteLine("sorry no room");
            }
        DisplaytheStack();
        System.Console.WriteLine("Push" + input + "was added to the stack");
        }

        public string pop()
        {
            
        }
    
    
    }   
}
