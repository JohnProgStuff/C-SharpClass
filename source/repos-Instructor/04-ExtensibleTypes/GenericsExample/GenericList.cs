using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class GenericList<T>
    {
        // inner helper class
        private class Node
        {
            private T data;
            private Node next;

            public T Data
            {
                get { return this.data; }
                set { this.data = value; }
            }

            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            public Node(T t)
            {
                this.next = null;
                this.data = t;
            }


        }

        // implementation of the GenericList class:
        private Node head;

        // constructor:
        public GenericList()
        {
            head = null;
        }

        // methods: T as method parameter type
        public void AddHead(T t)
        {
            Node node = new Node(t);
            node.Next = head;
            head = node;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Node node = head;
            while(node != null)
            {
                builder.Append(node.Data);
                builder.Append(" ");
                node = node.Next;
            }
            return builder.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }
}
