using System.Collections.Generic;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                List<User> unsorted_name_list = Functions.ReadNames(arg);
                List<User> sorted_name_list = Functions.SortNames(unsorted_name_list);
                Functions.WriteNames(sorted_name_list);
            }
            System.Console.ReadLine();
        }
    }
}
