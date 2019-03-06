using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Person
    {
        
        public Person(string login, string password, string name)
        {
            this.login = login;
            this.password = password;
            this.name = name;
        }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
   

    }
}
