using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public object Add(int index, dynamic o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index: " +index);
            if (index > count)
                index = count;

            Node current = this.head;
            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                   current = current.Next;

                current.Next = new Node(o, current.Next);
            }
            count++;
            return o;
        }
        public object Add(dynamic o)
        {
            return this.Add(Count,o);
        }
        public void Remove(object data)
        {
            if (this.head == null) return;
            Node current = this.head;

            if (head.Data == data)
            {
                head = head.Next;
                count = count - 1;
                return;
            }
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    count = count - 1;
                    return;
                }
                current = current.Next;
            }
        }
        public void Clear()
        {
            this.head = null;
        }
        public int IndexOf(object o)
        {
            Node current = this.head;
            int index = 0;

            while (current.Next != null)
            {

                if (current.Data==o)
                    return index;
                current = current.Next;
                index++;
            }
            return -1;
        }
    }
    
}
