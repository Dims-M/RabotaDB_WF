using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabotaDB_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // МЕТОДЫ


            public void testBD()
        {

            using (Model db = new Model())
            {
                // создаем два объекта User
                User user1 = new User { Name = "ХреноTom", Age = 33 };
                User user2 = new User { Name = "ПедикоSam", Age = 26 };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                // Console.WriteLine("Объекты успешно сохранены");
               // MessageBox.Show("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users;
                textBox1.Text = "Список объектов:";
                //Console.WriteLine("Список объектов:");

                string tempB = "Добавлено в БД \t\n"; // 

                foreach (User u in users)
                {
                    // Console.WriteLine("{0}.{1} - {2}", u.Id, u.Name, u.Age);
                    tempB += $"{u.Id}.{u.Name} - {u.Age} \t\n";
                   // textBox1.Text += $"{u.Id}.{u.Name} - {u.Age}";
                }
               
                MessageBox.Show(tempB);
            }
            //Console.Read();
        }


            public void testMetod()
        {
            Model context = new Model();

            List<Countries> myList = new List<Countries>() { new Countries { Id = 1, Country = "TEST_Ivanov", Capital = "20" } };
                        //new Countries { FirstName = "Petr", LastName = "Petrov", Age = 15}]

            
           // context.Countries.AddRange(myList);
            context.SaveChanges();
        }


        // кнопка добавить
        private void button1_Click(object sender, EventArgs e)
        {
            testBD();
            //testMetod();
        }
    }



    public class Countries
    {

        public int Id { get; set; }

        public string Country { get; set; }

        public string Capital { get; set; }

    }
}
