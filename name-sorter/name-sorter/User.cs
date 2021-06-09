using System.Linq;

namespace NameSorter
{
    public class User
    {
        public User(string name)
        {
            Full_name = name;
            Given_name = name.Split(' ').Last();
            Last_name = name.Replace(' ' + Given_name, "");
        }
        public string Full_name { get; set; }
        public string Given_name { get; set; }
        public string Last_name { get; set; }
    }
}
