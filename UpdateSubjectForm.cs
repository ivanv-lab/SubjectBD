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
    public partial class UpdateSubjectForm : Form
    {
        SQLiteClass db = new SQLiteClass("Дисциплины");
        public UpdateSubjectForm()
        {
            InitializeComponent();
            db.DBCreate();
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if(name=="")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            string query = String.Format("Update subjects set name='{0}' where name='{1}'", name, Data.subject);
            db.SqliteExecute(query);
            this.Close();
        }
    }
}
