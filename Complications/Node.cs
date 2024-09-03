using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complications
{
    internal class Node
    {

        public int Value;
        public Node Next;

        public Node(int value)
        {
            SetValue(value);
            SetNext(null);
        }

        public int GetValue()
        {
            return Value;
        }
        public void SetValue(int value)
        {
            Value = value;
        }
        public Node GetNext()
        {
            return Next;
        }
        public void SetNext(Node next)
        {
            Next = next;
        }






    }
}
