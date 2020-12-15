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
    public partial class ingr : Form
    {
        public ingr()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            Avtoriz db = new Avtoriz();
            db.Show();
        }

        private void ingr_Load(object sender, EventArgs e)
        {
            ingredientsBindingSource.DataSource = db.Ingredients.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ingredients i = (Ingredients)ingredientsBindingSource.Current;

            ingr a = new ingr();
            a.db = db;
            a.i = i;

            DialogResult dr = a.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ingredientsBindingSource.DataSource = db.Ingredients.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingredients i = (Ingredients)ingredientsBindingSource.Current;

            string str = $"Вы действительно хотите удалить - {i.Nomer}";
            DialogResult dr = MessageBox.Show(str, "Удаление ингредиент", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                db.Ingredients.Remove(i);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show($"Ингредиент - {i.Name} успешно удален!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка - " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingredients i = (Ingredients)ingredientsBindingSource.Current;
            ingr a = new ingr();
            a.db = db;

            DialogResult dr = a.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ingredientsBindingSource.DataSource = db.Ingredients.ToList();
            }
        }

    }
}

