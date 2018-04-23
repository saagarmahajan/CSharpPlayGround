using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("test1");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");
            list.Add("test5");
            list.Add("test6");
            list.Add("test7");
            list.Add("test8");
            list.Add("test9");
            list.Add("test10");
            list.Add(5,"extranode");

            list.Remove("extranode");
            list.Remove("test1");

           int index= list.IndexOf("test9");
        }
    }
}
