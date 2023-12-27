using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROC.MyLinkedLIST
{
    public class MyLinkedList<T> where T : IComparable<T>
    {
        private Node<T> _head;
        public MyLinkedList()
        {
            _head = null;
        }
        public void Add(T item)
        {
            Node<T> tmp = _head;

            if (_head == null)
            {
                _head = new Node<T>(item);
            }
            else
            {
                while (tmp._next != null)
                {
                    tmp = tmp._next;

                }
                tmp._next = new Node<T>(item);
            }
        }
        public void AddFront(T item)
        {
            Node<T> tmp = new Node<T>(item);
            tmp._next = _head;
            _head = tmp;
        }
        public void DeleteByValue(T item)
        {
            Node<T> tmp = _head;

            if (_head.Value.CompareTo(item) == 0)
            {
                _head = _head._next;
            }
            else
            {
                while (tmp._next != null)
                {
                    if (tmp._next.Value.CompareTo(item) == 0)

                    {
                        tmp._next = tmp._next._next;
                        break;

                    }

                    tmp = tmp._next;
                }

            }


        }
        public override string ToString()
        {
            string result = string.Empty;

            Node<T> tmp = _head;
            if (tmp == null)
            {
                return "";
            }
            else
            {
                result += _head.Value;

                while (tmp._next != null)
                {
                    tmp = tmp._next;
                    result += tmp.Value;
                }
            }

            return result;
        }
        public T GetByIndex(int index)
        {
            int i = 0;
            Node<T> tmp = _head;
            while (tmp._next != null)
            {
                if (i == index) 
                {
                    return tmp.Value;
                }
                i++;
                tmp = tmp._next;

            }
            return tmp.Value;
        }
        public void Reverse()
        {
            Node<T> tmp = _head;
            Node<T> tmp2 =  new Node<T>(tmp.Value);
            Node<T> nHead = null;

            while (tmp._next != null)
            {
                tmp = tmp._next;
                

            }
            

        }

    }

}
