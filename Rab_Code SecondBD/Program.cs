using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rab_Code_SecondBD
{
    class Program
    {
        static void Main(string[] args)
        {
             VividBD();

         


        }

        /// <summary>
        /// Вывод данных из БД
        /// </summary>
        static public void VividBD()
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;

                foreach (User u in users)
                {

                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                    Console.ReadKey(true);
                }
            }
        }
    }
}
