using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.MyLinkedLIST
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set;}

        public Node<T> _next;

        public Node(T value)
        {
            Value = value;
            _next = null;
        }
        public override bool Equals(object? obj)
        {

            if (obj is T)
            {
                var castedObject = (T)obj;
                if (Value.CompareTo(castedObject) == 0)
                    return true;
            }
            return false;
        }
    }
}
