using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabotaDB_WindowsForms
{
    /// <summary>
    /// Класс для работы с БД. Каждое свойство в классе будет равнятся отдельным столбцом
    /// </summary>
   public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
