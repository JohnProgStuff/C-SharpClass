using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsExample
{
    public class GenericList<T>
    {


        //Inner helper class is only accessible by the outer class
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

            // not the default constructor because it requires an argument
            public Node(T t)
            {
                this.next = null;
                this.data = t;
            }

        }

        // implementation of the GenericList class:

        private Node head;
        private Node foot;

        // constructor:
        public GenericList()
        {
            head = null;
            foot = null;
        }

        // methods:
        public void AddHead(T t)
        {
            Node node = new Node(t);
            node.Next = head;
            head = node;
            if (foot == null)
            {
                foot = node;
            }
        }

        // try implementing a AddFoot member and function
        public void AddFoot(T t)
        {
            if (head == null)
            {
                AddHead(t);
                return;
            }
            Node node = new Node(t);
            node.Next = null;
            foot.Next = node;
            foot = node;
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
                yield return current.Data; // return but yield won't terminate function call
                current = current.Next;
            }
        }

    }

}
