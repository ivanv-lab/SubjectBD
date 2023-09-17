using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectBD
{
    public partial class CreateRecTS : Form
    {
        SQLiteClass db = new SQLiteClass("Дисциплины");
        public CreateRecTS()
        {
            InitializeComponent();
            db.DBCreate();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "select name from subjects";
            db.SQLiteComboBox(query, comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = comboBox1.Text;
                string day = comboBox2.Text;
                string time = textBox3.Text;
                if(name=="" || day=="" || time=="")
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }
                int clas = Convert.ToInt32(textBox4.Text);
                string query = String.Format("Insert into timetable(name,day,time,class) values('{0}','{1}','{2}','{3}')", name, day, time, clas);
                db.SqliteExecute(query);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Заполните поля правильно");
            }
        }
    }
}


