
using System;

namespace Complications
{
    internal class LinkedList
    {
        private Node head = null;

        public LinkedList() { }

        public LinkedList(Node head)
        {
            this.head = head;
        }

        public void Add(int value)
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public string Display()
        {
            Node current = head;
            string allList = string.Empty;
            int index = 0;
            while (current != null)
            {
                if (index == 0) allList += current.ToString();
                else allList += "->" + current.ToString();
                current = current.Next;
                index++;
            }
            return allList;
        }

        public int Length()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void RemoveValue(int value)
        {
            if (head == null) return;

            if (head.GetValue() == value)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.GetValue() == value)
                {
                    previous.Next = current.Next;
                    return;
                }
                previous = current;
                current = current.Next;
            }
        }

        public void RemoveAllValues(int value)
        {
            while (Find(value) != -1 && head != null)
            {
                RemoveValue(value);
            }
        }

        public void RemoveIndex(int index)
        {
            if (head == null) return;

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node previous = null;
            int counter = 0;

            while (current != null && counter < index)
            {
                previous = current;
                current = current.Next;
                counter++;
            }

            if (current != null)
            {
                previous.Next = current.Next;
            }
        }

        public int Find(int value)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.GetValue() == value)
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        public int Get(int index)
        {
            Node current = head;
            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    return current.GetValue();
                }
                i++;
                current = current.Next;
            }
            return -1;  
        }
    }
}
