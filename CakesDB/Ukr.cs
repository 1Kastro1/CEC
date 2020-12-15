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
    public partial class Ukr : Form
    {
        public Ukr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Avtoriz db = new Avtoriz();
            db.Show();
        }
        Model1 db = new Model1();
        private void button2_Click(object sender, EventArgs e)
        {
            Ukrashenia i = (Ukrashenia)ukrasheniaBindingSource.Current;

            string str = $"Вы действительно хотите удалить - {i.Nomer}";
            DialogResult dr = MessageBox.Show(str, "Удаление ингредиент", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                db.Ukrashenia.Remove(i);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show($"Украшения - {i.Name} успешно удален!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка - " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ukrashenia i = (Ukrashenia)ukrasheniaBindingSource.Current;

            Ukr a = new Ukr();
            a.db = db;
            a.i = i;

            DialogResult dr = a.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ukrasheniaBindingSource.DataSource = db.Ingredients.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ukrashenia i = (Ukrashenia)ukrasheniaBindingSource.Current;
            Ukr a = new Ukr();
            a.db = db;

            DialogResult dr = a.ShowDialog();
            if (dr == DialogResult.OK)
            {
               ukrasheniaBindingSource.DataSource = db.Ingredients.ToList();
            }
        }

        private void Ukr_Load(object sender, EventArgs e)
        {
            ukrasheniaBindingSource.DataSource = db.Ukrashenia.ToList();
        }
    }
}

