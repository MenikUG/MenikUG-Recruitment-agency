namespace Тест
{
    partial class DataInput_Vacancy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataInput_Vacancy));
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cB_Schedule = new System.Windows.Forms.ComboBox();
            this.cB_Profession = new System.Windows.Forms.ComboBox();
            this.tB_AboutUs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_Mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_WorkExperience = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Company = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_KeySkills = new System.Windows.Forms.TextBox();
            this.tB_Requirements = new System.Windows.Forms.TextBox();
            this.tB_Tasks = new System.Windows.Forms.TextBox();
            this.recruitmentDBDataSet = new ОКиТПО_Кадровое_агенство.RecruitmentDBDataSet();
            this.профессииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.профессииTableAdapter = new ОКиТПО_Кадровое_агенство.RecruitmentDBDataSetTableAdapters.ПрофессииTableAdapter();
            this.разновидностиграфикаработыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.разновидности_графика_работыTableAdapter = new ОКиТПО_Кадровое_агенство.RecruitmentDBDataSetTableAdapters.Разновидности_графика_работыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.разновидностиграфикаработыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(832, 77);
            this.label13.TabIndex = 83;
            this.label13.Text = "Заполнение данных";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Location = new System.Drawing.Point(12, 610);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(328, 60);
            this.btn_Delete.TabIndex = 82;
            this.btn_Delete.Text = "Удалить запись";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Save.Location = new System.Drawing.Point(492, 610);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(328, 60);
            this.btn_Save.TabIndex = 81;
            this.btn_Save.Text = "Сохранить запись";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cB_Schedule
            // 
            this.cB_Schedule.BackColor = System.Drawing.SystemColors.Window;
            this.cB_Schedule.DataSource = this.разновидностиграфикаработыBindingSource;
            this.cB_Schedule.DisplayMember = "График работы";
            this.cB_Schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Schedule.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Schedule.FormattingEnabled = true;
            this.cB_Schedule.Location = new System.Drawing.Point(319, 251);
            this.cB_Schedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Schedule.Name = "cB_Schedule";
            this.cB_Schedule.Size = new System.Drawing.Size(380, 31);
            this.cB_Schedule.TabIndex = 5;
            this.cB_Schedule.ValueMember = "Id";
            // 
            // cB_Profession
            // 
            this.cB_Profession.DataSource = this.профессииBindingSource;
            this.cB_Profession.DisplayMember = "Название профессии";
            this.cB_Profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Profession.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Profession.FormattingEnabled = true;
            this.cB_Profession.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cB_Profession.Location = new System.Drawing.Point(319, 98);
            this.cB_Profession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Profession.Name = "cB_Profession";
            this.cB_Profession.Size = new System.Drawing.Size(380, 31);
            this.cB_Profession.TabIndex = 1;
            this.cB_Profession.ValueMember = "Id";
            // 
            // tB_AboutUs
            // 
            this.tB_AboutUs.AcceptsReturn = true;
            this.tB_AboutUs.AllowDrop = true;
            this.tB_AboutUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_AboutUs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_AboutUs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_AboutUs.Location = new System.Drawing.Point(319, 404);
            this.tB_AboutUs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_AboutUs.Multiline = true;
            this.tB_AboutUs.Name = "tB_AboutUs";
            this.tB_AboutUs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_AboutUs.Size = new System.Drawing.Size(380, 30);
            this.tB_AboutUs.TabIndex = 9;
            this.tB_AboutUs.Enter += new System.EventHandler(this.tB_Requirements_Enter);
            this.tB_AboutUs.Leave += new System.EventHandler(this.tB_Requirements_Leave);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 30);
            this.label11.TabIndex = 74;
            this.label11.Text = "О нас";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 30);
            this.label12.TabIndex = 72;
            this.label12.Text = "Ключевые навыки";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Mail
            // 
            this.tB_Mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Mail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Mail.Location = new System.Drawing.Point(319, 442);
            this.tB_Mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Mail.MaxLength = 100;
            this.tB_Mail.Name = "tB_Mail";
            this.tB_Mail.Size = new System.Drawing.Size(380, 30);
            this.tB_Mail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 30);
            this.label5.TabIndex = 70;
            this.label5.Text = "Почта";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 30);
            this.label6.TabIndex = 68;
            this.label6.Text = "Ваши задачи";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 30);
            this.label7.TabIndex = 67;
            this.label7.Text = "Требования";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 31);
            this.label8.TabIndex = 65;
            this.label8.Text = "График работы";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Salary
            // 
            this.tB_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Salary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Salary.Location = new System.Drawing.Point(319, 213);
            this.tB_Salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Salary.MaxLength = 20;
            this.tB_Salary.Name = "tB_Salary";
            this.tB_Salary.Size = new System.Drawing.Size(380, 30);
            this.tB_Salary.TabIndex = 4;
            this.tB_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_WorkExperience_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 30);
            this.label3.TabIndex = 64;
            this.label3.Text = "Зарплата";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_WorkExperience
            // 
            this.tB_WorkExperience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_WorkExperience.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_WorkExperience.Location = new System.Drawing.Point(319, 175);
            this.tB_WorkExperience.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_WorkExperience.MaxLength = 2;
            this.tB_WorkExperience.Name = "tB_WorkExperience";
            this.tB_WorkExperience.Size = new System.Drawing.Size(380, 30);
            this.tB_WorkExperience.TabIndex = 3;
            this.tB_WorkExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_WorkExperience_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 30);
            this.label4.TabIndex = 62;
            this.label4.Text = "Требуемый опыт работы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Company
            // 
            this.tB_Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Company.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Company.Location = new System.Drawing.Point(319, 137);
            this.tB_Company.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Company.MaxLength = 100;
            this.tB_Company.Name = "tB_Company";
            this.tB_Company.Size = new System.Drawing.Size(380, 30);
            this.tB_Company.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 30);
            this.label2.TabIndex = 60;
            this.label2.Text = "Компания";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Профессия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_KeySkills
            // 
            this.tB_KeySkills.AcceptsReturn = true;
            this.tB_KeySkills.AllowDrop = true;
            this.tB_KeySkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_KeySkills.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_KeySkills.Location = new System.Drawing.Point(319, 366);
            this.tB_KeySkills.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_KeySkills.Multiline = true;
            this.tB_KeySkills.Name = "tB_KeySkills";
            this.tB_KeySkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_KeySkills.Size = new System.Drawing.Size(380, 30);
            this.tB_KeySkills.TabIndex = 8;
            this.tB_KeySkills.Enter += new System.EventHandler(this.tB_Requirements_Enter);
            this.tB_KeySkills.Leave += new System.EventHandler(this.tB_Requirements_Leave);
            // 
            // tB_Requirements
            // 
            this.tB_Requirements.AcceptsReturn = true;
            this.tB_Requirements.AllowDrop = true;
            this.tB_Requirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Requirements.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Requirements.Location = new System.Drawing.Point(319, 290);
            this.tB_Requirements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Requirements.Multiline = true;
            this.tB_Requirements.Name = "tB_Requirements";
            this.tB_Requirements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_Requirements.Size = new System.Drawing.Size(380, 30);
            this.tB_Requirements.TabIndex = 6;
            this.tB_Requirements.Enter += new System.EventHandler(this.tB_Requirements_Enter);
            this.tB_Requirements.Leave += new System.EventHandler(this.tB_Requirements_Leave);
            // 
            // tB_Tasks
            // 
            this.tB_Tasks.AcceptsReturn = true;
            this.tB_Tasks.AllowDrop = true;
            this.tB_Tasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Tasks.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Tasks.Location = new System.Drawing.Point(319, 328);
            this.tB_Tasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Tasks.Multiline = true;
            this.tB_Tasks.Name = "tB_Tasks";
            this.tB_Tasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_Tasks.Size = new System.Drawing.Size(380, 30);
            this.tB_Tasks.TabIndex = 7;
            this.tB_Tasks.Enter += new System.EventHandler(this.tB_Requirements_Enter);
            this.tB_Tasks.Leave += new System.EventHandler(this.tB_Requirements_Leave);
            // 
            // recruitmentDBDataSet
            // 
            this.recruitmentDBDataSet.DataSetName = "RecruitmentDBDataSet";
            this.recruitmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // профессииBindingSource
            // 
            this.профессииBindingSource.DataMember = "Профессии";
            this.профессииBindingSource.DataSource = this.recruitmentDBDataSet;
            // 
            // профессииTableAdapter
            // 
            this.профессииTableAdapter.ClearBeforeFill = true;
            // 
            // разновидностиграфикаработыBindingSource
            // 
            this.разновидностиграфикаработыBindingSource.DataMember = "Разновидности_графика_работы";
            this.разновидностиграфикаработыBindingSource.DataSource = this.recruitmentDBDataSet;
            // 
            // разновидности_графика_работыTableAdapter
            // 
            this.разновидности_графика_работыTableAdapter.ClearBeforeFill = true;
            // 
            // DataInput_Vacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(832, 683);
            this.Controls.Add(this.tB_Tasks);
            this.Controls.Add(this.tB_Requirements);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cB_Schedule);
            this.Controls.Add(this.cB_Profession);
            this.Controls.Add(this.tB_AboutUs);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tB_Mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_WorkExperience);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_Company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_KeySkills);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataInput_Vacancy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных для Вакансии";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataInput_Vacancy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разновидностиграфикаработыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cB_Schedule;
        private System.Windows.Forms.ComboBox cB_Profession;
        private System.Windows.Forms.TextBox tB_AboutUs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tB_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_WorkExperience;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_KeySkills;
        private System.Windows.Forms.TextBox tB_Requirements;
        private System.Windows.Forms.TextBox tB_Tasks;
        private ОКиТПО_Кадровое_агенство.RecruitmentDBDataSet recruitmentDBDataSet;
        private System.Windows.Forms.BindingSource профессииBindingSource;
        private ОКиТПО_Кадровое_агенство.RecruitmentDBDataSetTableAdapters.ПрофессииTableAdapter профессииTableAdapter;
        private System.Windows.Forms.BindingSource разновидностиграфикаработыBindingSource;
        private ОКиТПО_Кадровое_агенство.RecruitmentDBDataSetTableAdapters.Разновидности_графика_работыTableAdapter разновидности_графика_работыTableAdapter;
    }
}