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
    public partial class UpdateRecTS : Form
    {
        SQLiteClass db = new SQLiteClass("Дисциплины");
        public UpdateRecTS()
        {
            InitializeComponent();
            db.DBCreate();
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
                string query = String.Format("update timetable set name='{0}',day='{1}',time='{2}',class='{3}' where name='{4}' and day='{5}' and time='{6}' and class='{7}'", name, day, time, clas, Data.name, Data.day, Data.time, Data.clas);
                db.SqliteExecute(query);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Заполните поля правильно");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string query = "select name from subjects";
            db.SQLiteComboBox(query, comboBox1);
        }
    }
}
