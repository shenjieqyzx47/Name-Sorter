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
                //read the given file and put all names into a list.
                List<User> users = new List<User>();
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(arg);
                while ((line = file.ReadLine()) != null)
                {
                    users.Add(new User(line));
                }
                file.Close();   //end reading txt file.
                                //sort the list by the given name
                IEnumerable<User> sorted_users = from user in users
                                                 orderby user.given_name
                                                 select user;   //end sorting
                                                                //print the sorted names as well as write into a new txt file
                using (StreamWriter sorted_names_list = new StreamWriter("sorted-names-list.txt"))
                    foreach (User user in sorted_users)
                    {
                        System.Console.WriteLine(user.full_name);
                        sorted_names_list.WriteLine(user.full_name);
                    }   //end printing and writing
                System.Console.ReadLine();
            }
        }
    }
}
