namespace SubjectBD
{
    partial class MainScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SubjectsPage = new System.Windows.Forms.TabPage();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnCreateRec = new System.Windows.Forms.Button();
            this.btnShowTabl = new System.Windows.Forms.Button();
            this.btnCreateTabl = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimetablePage = new System.Windows.Forms.TabPage();
            this.btnUpdateRecTS = new System.Windows.Forms.Button();
            this.btnDeleteRecTS = new System.Windows.Forms.Button();
            this.btnCreateRecTS = new System.Windows.Forms.Button();
            this.btnShowTableTS = new System.Windows.Forms.Button();
            this.btnCreateTableTS = new System.Windows.Forms.Button();
            this.dgvTimesheet = new System.Windows.Forms.DataGridView();
            this.SubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.SubjectsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.TimetablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimesheet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SubjectsPage);
            this.tabControl1.Controls.Add(this.TimetablePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 720);
            this.tabControl1.TabIndex = 0;
            // 
            // SubjectsPage
            // 
            this.SubjectsPage.BackColor = System.Drawing.SystemColors.Info;
            this.SubjectsPage.Controls.Add(this.btnUpdateSubject);
            this.SubjectsPage.Controls.Add(this.btnDeleteSubject);
            this.SubjectsPage.Controls.Add(this.btnCreateRec);
            this.SubjectsPage.Controls.Add(this.btnShowTabl);
            this.SubjectsPage.Controls.Add(this.btnCreateTabl);
            this.SubjectsPage.Controls.Add(this.dgvSubjects);
            this.SubjectsPage.Location = new System.Drawing.Point(4, 33);
            this.SubjectsPage.Name = "SubjectsPage";
            this.SubjectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectsPage.Size = new System.Drawing.Size(983, 683);
            this.SubjectsPage.TabIndex = 0;
            this.SubjectsPage.Text = "Дисциплины";
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(527, 537);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(221, 60);
            this.btnUpdateSubject.TabIndex = 5;
            this.btnUpdateSubject.Text = "Изменить запись";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(754, 537);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(221, 60);
            this.btnDeleteSubject.TabIndex = 4;
            this.btnDeleteSubject.Text = "Удалить запись";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnCreateRec
            // 
            this.btnCreateRec.Location = new System.Drawing.Point(754, 471);
            this.btnCreateRec.Name = "btnCreateRec";
            this.btnCreateRec.Size = new System.Drawing.Size(221, 60);
            this.btnCreateRec.TabIndex = 3;
            this.btnCreateRec.Text = "Создать запись";
            this.btnCreateRec.UseVisualStyleBackColor = true;
            this.btnCreateRec.Click += new System.EventHandler(this.btnCreateRec_Click);
            // 
            // btnShowTabl
            // 
            this.btnShowTabl.Location = new System.Drawing.Point(8, 537);
            this.btnShowTabl.Name = "btnShowTabl";
            this.btnShowTabl.Size = new System.Drawing.Size(147, 60);
            this.btnShowTabl.TabIndex = 2;
            this.btnShowTabl.Text = "Отобразить таблицу";
            this.btnShowTabl.UseVisualStyleBackColor = true;
            this.btnShowTabl.Click += new System.EventHandler(this.btnShowTabl_Click);
            // 
            // btnCreateTabl
            // 
            this.btnCreateTabl.Location = new System.Drawing.Point(8, 471);
            this.btnCreateTabl.Name = "btnCreateTabl";
            this.btnCreateTabl.Size = new System.Drawing.Size(147, 60);
            this.btnCreateTabl.TabIndex = 1;
            this.btnCreateTabl.Text = "Создать таблицу";
            this.btnCreateTabl.UseVisualStyleBackColor = true;
            this.btnCreateTabl.Click += new System.EventHandler(this.btnCreateTabl_Click);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName});
            this.dgvSubjects.Location = new System.Drawing.Point(6, 6);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.Size = new System.Drawing.Size(971, 459);
            this.dgvSubjects.TabIndex = 0;
            this.dgvSubjects.Visible = false;
            this.dgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellClick);
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Название дисциплины";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // TimetablePage
            // 
            this.TimetablePage.BackColor = System.Drawing.SystemColors.Info;
            this.TimetablePage.Controls.Add(this.groupBox1);
            this.TimetablePage.Controls.Add(this.btnUpdateRecTS);
            this.TimetablePage.Controls.Add(this.btnDeleteRecTS);
            this.TimetablePage.Controls.Add(this.btnCreateRecTS);
            this.TimetablePage.Controls.Add(this.btnShowTableTS);
            this.TimetablePage.Controls.Add(this.btnCreateTableTS);
            this.TimetablePage.Controls.Add(this.dgvTimesheet);
            this.TimetablePage.Location = new System.Drawing.Point(4, 33);
            this.TimetablePage.Name = "TimetablePage";
            this.TimetablePage.Padding = new System.Windows.Forms.Padding(3);
            this.TimetablePage.Size = new System.Drawing.Size(983, 683);
            this.TimetablePage.TabIndex = 1;
            this.TimetablePage.Text = "Расписание";
            // 
            // btnUpdateRecTS
            // 
            this.btnUpdateRecTS.Location = new System.Drawing.Point(754, 603);
            this.btnUpdateRecTS.Name = "btnUpdateRecTS";
            this.btnUpdateRecTS.Size = new System.Drawing.Size(221, 60);
            this.btnUpdateRecTS.TabIndex = 11;
            this.btnUpdateRecTS.Text = "Изменить запись";
            this.btnUpdateRecTS.UseVisualStyleBackColor = true;
            this.btnUpdateRecTS.Click += new System.EventHandler(this.btnUpdateRecTS_Click);
            // 
            // btnDeleteRecTS
            // 
            this.btnDeleteRecTS.Location = new System.Drawing.Point(754, 537);
            this.btnDeleteRecTS.Name = "btnDeleteRecTS";
            this.btnDeleteRecTS.Size = new System.Drawing.Size(221, 60);
            this.btnDeleteRecTS.TabIndex = 10;
            this.btnDeleteRecTS.Text = "Удалить запись";
            this.btnDeleteRecTS.UseVisualStyleBackColor = true;
            this.btnDeleteRecTS.Click += new System.EventHandler(this.btnDeleteRecTS_Click);
            // 
            // btnCreateRecTS
            // 
            this.btnCreateRecTS.Location = new System.Drawing.Point(754, 471);
            this.btnCreateRecTS.Name = "btnCreateRecTS";
            this.btnCreateRecTS.Size = new System.Drawing.Size(221, 60);
            this.btnCreateRecTS.TabIndex = 9;
            this.btnCreateRecTS.Text = "Создать запись";
            this.btnCreateRecTS.UseVisualStyleBackColor = true;
            this.btnCreateRecTS.Click += new System.EventHandler(this.btnCreateRecTS_Click);
            // 
            // btnShowTableTS
            // 
            this.btnShowTableTS.Location = new System.Drawing.Point(8, 537);
            this.btnShowTableTS.Name = "btnShowTableTS";
            this.btnShowTableTS.Size = new System.Drawing.Size(147, 60);
            this.btnShowTableTS.TabIndex = 8;
            this.btnShowTableTS.Text = "Отобразить таблицу";
            this.btnShowTableTS.UseVisualStyleBackColor = true;
            this.btnShowTableTS.Click += new System.EventHandler(this.btnShowTableTS_Click);
            // 
            // btnCreateTableTS
            // 
            this.btnCreateTableTS.Location = new System.Drawing.Point(8, 471);
            this.btnCreateTableTS.Name = "btnCreateTableTS";
            this.btnCreateTableTS.Size = new System.Drawing.Size(147, 60);
            this.btnCreateTableTS.TabIndex = 7;
            this.btnCreateTableTS.Text = "Создать таблицу";
            this.btnCreateTableTS.UseVisualStyleBackColor = true;
            this.btnCreateTableTS.Click += new System.EventHandler(this.btnCreateTableTS_Click);
            // 
            // dgvTimesheet
            // 
            this.dgvTimesheet.AllowUserToAddRows = false;
            this.dgvTimesheet.AllowUserToDeleteRows = false;
            this.dgvTimesheet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimesheet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimesheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubName,
            this.Day,
            this.Time,
            this.Classroom});
            this.dgvTimesheet.Location = new System.Drawing.Point(6, 6);
            this.dgvTimesheet.Name = "dgvTimesheet";
            this.dgvTimesheet.ReadOnly = true;
            this.dgvTimesheet.RowHeadersVisible = false;
            this.dgvTimesheet.Size = new System.Drawing.Size(971, 459);
            this.dgvTimesheet.TabIndex = 6;
            this.dgvTimesheet.Visible = false;
            this.dgvTimesheet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimesheet_CellClick);
            // 
            // SubName
            // 
            this.SubName.HeaderText = "Название дисциплины";
            this.SubName.Name = "SubName";
            this.SubName.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "День недели";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Classroom
            // 
            this.Classroom.HeaderText = "Аудитория";
            this.Classroom.Name = "Classroom";
            this.Classroom.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(181, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(260, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Показать все расписание";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(299, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Показать расписание на день";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 148);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(339, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Показать расписание дисциплины";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.comboBox1.Location = new System.Drawing.Point(370, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 32);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(370, 147);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 32);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(991, 720);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание занятий";
            this.tabControl1.ResumeLayout(false);
            this.SubjectsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.TimetablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimesheet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SubjectsPage;
        private System.Windows.Forms.TabPage TimetablePage;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnCreateTabl;
        private System.Windows.Forms.Button btnShowTabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.Button btnCreateRec;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnUpdateRecTS;
        private System.Windows.Forms.Button btnDeleteRecTS;
        private System.Windows.Forms.Button btnCreateRecTS;
        private System.Windows.Forms.Button btnShowTableTS;
        private System.Windows.Forms.Button btnCreateTableTS;
        private System.Windows.Forms.DataGridView dgvTimesheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classroom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

