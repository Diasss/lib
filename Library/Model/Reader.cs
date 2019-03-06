using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Reader : Person
    {
        public int id { get; set; }
       
        public Reader(string login, string password, string name, string address, string email, string telephoneNumber, bool bannedUser) : base(login, password, name)
        {
            this.address = address;
            this.email = email;
            this.telephoneNumber = telephoneNumber;
            this.bannedUser = bannedUser;
        }

        

        public string address { get; set; }
        public string email { get; set; }
        public string telephoneNumber { get; set; }
        public bool bannedUser { get; set; }
        public SortedList<Book, bool> tokenBooks { get; set; }
    }
}
