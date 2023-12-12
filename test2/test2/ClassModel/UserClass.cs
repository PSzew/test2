using System;
using System.Collections.Generic;
using System.Text;

namespace test2.ClassModel
{
    internal class UserClass
    {
        public UserClass(string name, string url)
        {
            Name = name;
            URL = url;
        }
        public string Name { get; set; }
        public string URL { get; set; }
    }
}
