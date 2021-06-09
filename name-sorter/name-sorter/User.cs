using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    class User
    {
        public User(string name)
        {
            string[] names = name.Split(' ');
            full_name = name;
            given_name = name.Split(' ').Last();
            last_name = name.Replace(' ' + given_name, "");
        }
        public string full_name { get; set; }
        public string given_name { get; set; }
        public string last_name { get; set; }
    }
}
