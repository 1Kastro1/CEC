using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CakesDB
{
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
        }
        public static Avtoriz vh { get; set; }
        public static Users us { get; set; }

        readonly Model1 db = new Model1();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }
            Users usr = db.Users.Find(textBox1.Text);
            if ((usr != null) && (usr.Psw == textBox2.Text))
            {
                us = usr;
                vh = this;
                if (usr.Role == "Менеджер по продажам")
                {
                    manProd m = new manProd();
                    m.Show();
                    this.Hide();
                }
                if (usr.Role == "Директор")
                {
                    dir d = new dir();
                    d.Show();
                    this.Hide();
                }
                if (usr.Role == "Мастер")
                {
                    master m = new master();
                    m.Show();
                    this.Hide();
                }
                if (usr.Role == "Менеджер по закупкам")
                {
                    manZak m = new manZak();
                    m.Show();
                    this.Hide();
                }
                if (usr.Role == "Заказчик")
                {
                    zakazchik z = new zakazchik();
                    this.Hide();
                    z.Show();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет в системе!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg db = new reg();
            db.Show();
        }
    }
}

          