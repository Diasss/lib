using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Admin : Person
    {
        public Admin(string login, string password, string name):base(login, password, name)
        {

        }
        public int id { get; set; }
        
        
    }
}
