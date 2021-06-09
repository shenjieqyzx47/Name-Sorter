using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NameSorter
{
    class Functions
    {
        //read names from unsorted text file and put them into a list.
        public static List<User> ReadNames(string file_address) {
            List<User> unsorted_name_list = new List<User>();
            string line;
            try
            {
                StreamReader file = new StreamReader(file_address);
                while ((line = file.ReadLine()) != null)
                {
                    unsorted_name_list.Add(new User(line));
                }
                file.Close();
            }
            catch (Exception exception) {
                Console.Write(exception);
            }
            return unsorted_name_list;
        }

        //sort the unsorted_name_list 
        public static List<User> SortNames(List<User> unsorted_name_list) {
            List<User> sorted_name_list = unsorted_name_list.OrderBy(x => x.Given_name).ToList();
            return sorted_name_list;
        }

        //print the sorted_name_list to screen and write into sorted-names-list.txt
        public static void WriteNames(List<User> sorted_name_list) {
            using (StreamWriter target_text_file = new StreamWriter("sorted-names-list.txt"))
            foreach (User user in sorted_name_list)
            {
                Console.WriteLine(user.Full_name);
                target_text_file.WriteLine(user.Full_name);
            }
        }
    }
}
