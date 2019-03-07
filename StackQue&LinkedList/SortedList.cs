using System;
using System.Collections;
using System.Collections.Generic;

namespace Lecture_3A
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("hello world!");

        }
    }
    public class SinglySortedList<T> where T:IComparable
    {
        public Node<T> Head;

        SinglySortedList()
        {
            Head = null;
        }

        public void Insert(T value) 
        {
            var newNode = new Node<T>(value);
            if (Head == null || Head.Data.CompareTo(value) == 0)
            {
                newNode.Next = Head;
                Head = newNode;
                return;               
            }
            var currentNode = Head;
            while(currentNode.Next != null && currentNode.Next.Data.CompareTo(value) <= 0)
            {
                currentNode = currentNode.Next;
            }
            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
            
        }

        public void Delete(T value)
        {
            if(Head == null || Head.Data.CompareTo(value) == 0)
            {
                return;
            }

            else if(Head.Data.Equals(value))
            {
                Head = Head.Next;
            }

            var currentNode = Head;
            while(currentNode != null && currentNode.Next.Data.CompareTo(value) <= 0)
            {
                if (currentNode.Next.Data.Equals(value))
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }

                currentNode = currentNode.Next;
            }

            return;

        }

        public Node<T> Search(T value)
        {
            var currentNode = Head;
            while (!currentNode.Data.Equals(value) && currentNode != null)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

    }
    public class Node<T> where T:IComparable
    {
        public Node<T> Next;
        public T Data;

        public Node (T data)
        {
            this.Data = data;
        }
    }
}
