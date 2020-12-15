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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            Users usr = db.Users.Find(textBox1.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть!");
                return;
            }

            usr = new Users();
            usr.Login = textBox1.Text;
            usr.Psw = textBox2.Text;
            usr.FIO = textBox3.Text;
            usr.Role = textBox4.Text;

            db.Users.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.Login + " зарегистрирован!");
            Avtoriz s = new Avtoriz();
            s.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtoriz db = new Avtoriz();
            db.Show();
        }
    }
}
