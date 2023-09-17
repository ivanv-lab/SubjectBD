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
    public partial class MainScreen : Form
    {
        SQLiteClass db = new SQLiteClass("Дисциплины");
        public int i, j;
        public MainScreen()
        {
            InitializeComponent();
            db.DBCreate();
            comboBox1.SelectedIndex = 1;
            string query = "select name from subjects";
            db.SQLiteComboBox(query, comboBox2);
        }

        public void TableUpdate()
        {
            string query = "select name from subjects";
            dgvSubjects.Visible = true;
            dgvSubjects.ColumnCount = 1;
            db.SQLiteTable(query, dgvSubjects);
        }

        public void TableUpdateTS()
        {
            string query = "select name,day,time,class from timetable";
            dgvTimesheet.Visible = true;
            dgvTimesheet.ColumnCount = 4;
            db.SQLiteTable(query, dgvTimesheet);
        }

        private void btnCreateTabl_Click(object sender, EventArgs e)
        {
            string query = "Create table subjects(id integer NOT NULL Primary key autoincrement unique, name text NOT NULL unique)";
            db.SqliteExecute(query);
        }

        private void btnShowTabl_Click(object sender, EventArgs e)
        {
            TableUpdate();
        }

        private void btnCreateRec_Click(object sender, EventArgs e)
        {
            CreateSubjectForm createSubjectForm = new CreateSubjectForm();
            createSubjectForm.ShowDialog();
            TableUpdate();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            string name = dgvSubjects.Rows[i].Cells[0].Value.ToString();
            string query = String.Format("Delete from subjects where name='{0}'", name);
            db.SqliteExecute(query);
            TableUpdate();
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
           Data.subject = dgvSubjects.Rows[i].Cells[0].Value.ToString();
          UpdateSubjectForm dlg=new UpdateSubjectForm();
            dlg.ShowDialog();
            TableUpdate();
        }

        private void btnCreateTableTS_Click(object sender, EventArgs e)
        {
            string query = "Create table timetable(id integer NOT NULL Primary key autoincrement unique, name text NOT NULL, day text NOT NULL, time text NOT NULL, class integer NOT NULL)";
            db.SqliteExecute(query);
        }

        private void btnShowTableTS_Click(object sender, EventArgs e)
        {
            TableUpdateTS();
        }

        private void btnCreateRecTS_Click(object sender, EventArgs e)
        {
            CreateRecTS dlg=new CreateRecTS();
            dlg.ShowDialog();
            TableUpdateTS();
        }

        private void btnDeleteRecTS_Click(object sender, EventArgs e)
        {
            string name = dgvTimesheet.Rows[i].Cells[0].Value.ToString();
            string day = dgvTimesheet.Rows[i].Cells[1].Value.ToString();
            string time = dgvTimesheet.Rows[i].Cells[2].Value.ToString();
            int clas = Convert.ToInt32(dgvTimesheet.Rows[i].Cells[3].Value);
            string query = String.Format("Delete from timetable where name='{0}' and day='{1}' and time='{2}' and class='{3}'", name, day, time, clas);
            db.SqliteExecute(query);
            TableUpdateTS();
        }

        private void dgvTimesheet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvTimesheet.CurrentRow.Index;
        }

        private void btnUpdateRecTS_Click(object sender, EventArgs e)
        {
            Data.name = dgvTimesheet.Rows[i].Cells[0].Value.ToString();
            Data.day= dgvTimesheet.Rows[i].Cells[1].Value.ToString();
            Data.time= dgvTimesheet.Rows[i].Cells[2].Value.ToString();
            Data.clas = Convert.ToInt32(dgvTimesheet.Rows[i].Cells[3].Value);
            UpdateRecTS dlg = new UpdateRecTS();
            dlg.ShowDialog();
            TableUpdateTS();
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TableUpdateTS();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string day = comboBox1.Text;
                string query = String.Format("select name,day,time,class from timetable where day='{0}'", day);
                db.SQLiteTable(query, dgvTimesheet);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                string name = comboBox2.Text;
                string query = String.Format("select name,day,time,class from timetable where name='{0}'", name);
                db.SQLiteTable(query, dgvTimesheet);

            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgvSubjects.CurrentRow.Index;
        }
    }
}
