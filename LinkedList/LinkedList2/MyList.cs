using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class MyList
    {
        public Node headnode;
        public MyList()
        {
            headnode = null;
            
        }
        public void AddtoBeginning(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headnode;
                headnode = temp;
            }

        }
        public void AddToEnd(int data)
        {
            Node newnode = new Node(data);
            if (headnode == null)
            {
                headnode = newnode;
            }
            else
            {
                Node current = headnode;
                while (current.next != null)
                {
                    current = current.next;
                        
                }
                current.next = newnode;
            }
        }
        public void Remove(int data)
        {
            if (headnode == null) return;
            Node current = headnode;

            if (headnode.data == data)
            {
                headnode = headnode.next;
                return;
            }
            while (current.next != null)
            {
                if (current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }
        public int IndexOf(int data)
        {
            Node current = this.headnode;
            int index = 0;

            while (current.next != null)
            {

                if (current.data == data)
                    return index;
                current = current.next;
                index++;
            }
            return -1;
        }
        public void clear()
        {
            headnode = null;
        }

    }
}
