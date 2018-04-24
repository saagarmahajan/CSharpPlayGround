using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyList mylist = new MyList();
            mylist.AddtoBeginning(5);
            mylist.AddtoBeginning(10);
            mylist.AddToEnd(15);
        }
    }
}
