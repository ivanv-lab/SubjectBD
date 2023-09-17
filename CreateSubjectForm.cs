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
    public partial class CreateSubjectForm : Form
    {
        SQLiteClass db = new SQLiteClass("Дисциплины");
        public CreateSubjectForm()
        {
            InitializeComponent();
            db.DBCreate();
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            string subject = textBox1.Text;
            if(subject=="")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            string query = String.Format("insert into subjects (name) values ('{0}') ", subject);
            db.SqliteExecute(query);
            this.Close();
        }
    }
}
