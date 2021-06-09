using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                List<User> unsorted_name_list = functions.ReadNames(arg);
                List<User> sorted_name_list = functions.SortNames(unsorted_name_list);
                functions.WriteNames(sorted_name_list);
            }
            System.Console.ReadLine();
        }
    }
}
