using System;
using System.Collections.Generic;

namespace doublylinkedlist
{
    class Program3
    {
        static void Main2(string[] args)
        {
            //Driver code
            Console.WriteLine("Its me!");
            var a = new DoublyLinkedList();
            a.InsertAtFirstPosition(5);
            a.InsertAfterKey(1,5);
            a.InsertAfterKey(6,1);
            a.display();
            Console.WriteLine();
            a.InsertBeforeKey(10,5);
            a.display();
            Console.WriteLine();
            a.remove(1);
            a.display();
            Console.WriteLine();
            a.remove(10);
            a.display();
        }
    }
    public class Node
    {
        public Node Previous;
        public Node Next;
        public int Data;
        public Node(int d)
        {
            this.Data = d;
        }
    }

    public class DoublyLinkedList
    {
        public Node Head;
        public Node Tail;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void display()
        {
            var start = Head;
            while (start.Next != null )
            {
                Console.WriteLine(start.Data);
                start = start.Next;
            }
            Console.WriteLine(start.Data);
        }
        public bool isEmpty()
        {
            if(Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InsertAtFirstPosition(int value)
        {
            Node new_node = new Node(value);
            if (isEmpty())
            {
                Tail = new_node;
            }
            else
            {
                Head.Previous = new_node;
            }
            new_node.Next = Head;
            Head = new_node;
        }

        public void InsertAtLastPosition(int value)
        {
            Node new_node = new Node(value);
            if (isEmpty())
            {
                Head = new_node;
            }
            else
            {
                Tail.Next = new_node;
                new_node.Previous = Tail;
            }
            Tail = new_node;
        }
        public void InsertAfterKey(int value, int key)
        {
            Node new_node = new Node(value);
            Node current_node = Head;

            while (current_node.Data != key)
            {
                current_node = current_node.Next;

                if(current_node == null)
                {
                    return;
                }
            }

            if (current_node == Tail)
            {
                new_node.Next = null;
                Tail = new_node;
            }
            
            else
            {
                new_node.Next = current_node.Next;
                current_node.Next.Previous = new_node;
            }
            new_node.Previous = current_node;
            current_node.Next = new_node;
            return;
        }

        public void InsertBeforeKey(int value, int key)
        {
            Node new_node = new Node(value);
            Node current_node = Tail;
            while (current_node.Data != key)
            {
                current_node = current_node.Previous;
                if (current_node == null)
                {
                    return;
                }
            }
            if (current_node == Head)
            {
                new_node.Previous = null;
                Head = new_node;
            }
            else
            {
                new_node.Previous = current_node.Previous;
                current_node.Previous.Next = new_node;
            }
            new_node.Next = current_node;
            current_node.Previous = new_node;
        }
        
        public void remove(int key)
        {
            if (key == Head.Data)
            {
                Head.Next.Previous = null;
                Head = Head.Next; 
            }
            if (key == Tail.Data)
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
                return;
            }
            var start = Head;
            while (start.Next != null)
            {
                if (key == start.Data)
                {
                    start.Previous.Next = start.Next;
                    start.Next.Previous = start.Previous;
                }
                start = start.Next;
            }
        }
    }
}