using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Library.Model
{
    public class Libraryy
    {
        public Libraryy()
        {
            Console.WriteLine("Добро пожаловать!\n1)Зарегестрироваться\n2)Войти");
            string chose = Console.ReadLine();
            if (chose == "1")
            {
                AdminService.CreateReader();
            }
            else if (chose == "2")
            {
                string adminOrReader = Console.ReadLine();
                if (adminOrReader == "1")
                {
                    Console.WriteLine("Введите логин: ");
                    string login = Console.ReadLine();
                    Console.WriteLine("Введите пароль: ");
                    string password = Console.ReadLine();
                    using (var db = new LiteDatabase(@""))
                    {
                        var col = db.GetCollection<Reader>("readers");

                        var result = col.FindAll();
                        foreach (Reader r in result)
                        {
                            if (r.login == login && r.password == password)
                            {
                                Console.WriteLine("Вы успешно авторизовались!");
                            }
                            else
                            {
                                Console.WriteLine("Повторите пароль заново");
                            }
                        }
                    }
                }

            }
        }
    }
}
