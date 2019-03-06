using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Library.Model
{
    class ReaderService
    {
        public void CreateNewBookReader(Reader reader)
        {
            BookService.CreateBook(reader);
        }
        public void FindBook(Reader reader)
        {
            BookService.SearchBook(reader);
        }
        public void PassBook(Reader reader)
        {
            using (var db = new LiteDatabase(@"Readers.db"))
            {
                var col = db.GetCollection<Reader>("readers");

                var result = col.FindAll();
                foreach (Reader r in result)
                {
                    if (reader == r)
                    {
                        r.tokenBooks.Remove(r);
                    }
                }
            }
        }
  
    }
}
