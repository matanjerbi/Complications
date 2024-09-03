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

        
        public void Add(Node node)
        {
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
            while (current != null)
            {
                allList += "->" + current.ToString();  
                current = current.Next;  
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
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    return;  
                }
                previous = current;  
                current = current.Next;  
            }
        }
    }
}
