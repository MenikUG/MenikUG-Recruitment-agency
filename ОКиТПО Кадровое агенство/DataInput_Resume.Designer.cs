namespace Тест
{
    partial class DataInput_Resume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataInput_Resume));
            this.cB_Schedule = new System.Windows.Forms.ComboBox();
            this.cB_Profession = new System.Windows.Forms.ComboBox();
            this.tB_Mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_DesiredSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_WorkExperience = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_KeySkills = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Patronymic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_AboutMe = new System.Windows.Forms.TextBox();
            this.tB_Education = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
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
            // cB_Schedule
            // 
            this.cB_Schedule.DataSource = this.разновидностиграфикаработыBindingSource;
            this.cB_Schedule.DisplayMember = "График работы";
            this.cB_Schedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Schedule.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Schedule.FormattingEnabled = true;
            this.cB_Schedule.Location = new System.Drawing.Point(319, 322);
            this.cB_Schedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Schedule.Name = "cB_Schedule";
            this.cB_Schedule.Size = new System.Drawing.Size(296, 31);
            this.cB_Schedule.TabIndex = 7;
            this.cB_Schedule.ValueMember = "Id";
            // 
            // cB_Profession
            // 
            this.cB_Profession.DataSource = this.профессииBindingSource;
            this.cB_Profession.DisplayMember = "Название профессии";
            this.cB_Profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Profession.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Profession.FormattingEnabled = true;
            this.cB_Profession.Location = new System.Drawing.Point(319, 245);
            this.cB_Profession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Profession.Name = "cB_Profession";
            this.cB_Profession.Size = new System.Drawing.Size(296, 31);
            this.cB_Profession.TabIndex = 5;
            this.cB_Profession.ValueMember = "Id";
            // 
            // tB_Mail
            // 
            this.tB_Mail.BackColor = System.Drawing.SystemColors.Window;
            this.tB_Mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Mail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Mail.Location = new System.Drawing.Point(319, 513);
            this.tB_Mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Mail.Name = "tB_Mail";
            this.tB_Mail.Size = new System.Drawing.Size(296, 30);
            this.tB_Mail.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(117, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 30);
            this.label9.TabIndex = 51;
            this.label9.Text = "Почта";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(117, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 30);
            this.label10.TabIndex = 49;
            this.label10.Text = "Обо мне";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_DesiredSalary
            // 
            this.tB_DesiredSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_DesiredSalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_DesiredSalary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_DesiredSalary.Location = new System.Drawing.Point(319, 437);
            this.tB_DesiredSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_DesiredSalary.MaxLength = 20;
            this.tB_DesiredSalary.Name = "tB_DesiredSalary";
            this.tB_DesiredSalary.Size = new System.Drawing.Size(296, 30);
            this.tB_DesiredSalary.TabIndex = 10;
            this.tB_DesiredSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Age_KeyPress);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(117, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 30);
            this.label11.TabIndex = 47;
            this.label11.Text = "Желаемая З/П";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(117, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 30);
            this.label12.TabIndex = 45;
            this.label12.Text = "Образование";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_WorkExperience
            // 
            this.tB_WorkExperience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_WorkExperience.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_WorkExperience.Location = new System.Drawing.Point(319, 361);
            this.tB_WorkExperience.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_WorkExperience.MaxLength = 2;
            this.tB_WorkExperience.Name = "tB_WorkExperience";
            this.tB_WorkExperience.Size = new System.Drawing.Size(296, 30);
            this.tB_WorkExperience.TabIndex = 8;
            this.tB_WorkExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Age_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 30);
            this.label5.TabIndex = 43;
            this.label5.Text = "Опыт работы";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 31);
            this.label6.TabIndex = 41;
            this.label6.Text = "График работы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_KeySkills
            // 
            this.tB_KeySkills.AcceptsReturn = true;
            this.tB_KeySkills.AllowDrop = true;
            this.tB_KeySkills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_KeySkills.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_KeySkills.Location = new System.Drawing.Point(319, 284);
            this.tB_KeySkills.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_KeySkills.Multiline = true;
            this.tB_KeySkills.Name = "tB_KeySkills";
            this.tB_KeySkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_KeySkills.Size = new System.Drawing.Size(296, 30);
            this.tB_KeySkills.TabIndex = 6;
            this.tB_KeySkills.Enter += new System.EventHandler(this.tB_KeySkills_Enter);
            this.tB_KeySkills.Leave += new System.EventHandler(this.tB_KeySkills_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(117, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ключевые навыки";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 31);
            this.label8.TabIndex = 38;
            this.label8.Text = "Профессия";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Age
            // 
            this.tB_Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Age.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Age.Location = new System.Drawing.Point(319, 207);
            this.tB_Age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Age.MaxLength = 2;
            this.tB_Age.Name = "tB_Age";
            this.tB_Age.Size = new System.Drawing.Size(296, 30);
            this.tB_Age.TabIndex = 4;
            this.tB_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_Age_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 37;
            this.label3.Text = "Возраст";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Patronymic
            // 
            this.tB_Patronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Patronymic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Patronymic.Location = new System.Drawing.Point(319, 169);
            this.tB_Patronymic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Patronymic.MaxLength = 100;
            this.tB_Patronymic.Name = "tB_Patronymic";
            this.tB_Patronymic.Size = new System.Drawing.Size(296, 30);
            this.tB_Patronymic.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Отчество";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Name
            // 
            this.tB_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Name.Location = new System.Drawing.Point(319, 131);
            this.tB_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Name.MaxLength = 100;
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(296, 30);
            this.tB_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_Surname
            // 
            this.tB_Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Surname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Surname.Location = new System.Drawing.Point(319, 93);
            this.tB_Surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Surname.MaxLength = 100;
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(296, 30);
            this.tB_Surname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tB_AboutMe
            // 
            this.tB_AboutMe.AcceptsReturn = true;
            this.tB_AboutMe.AllowDrop = true;
            this.tB_AboutMe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_AboutMe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_AboutMe.Location = new System.Drawing.Point(319, 475);
            this.tB_AboutMe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_AboutMe.Multiline = true;
            this.tB_AboutMe.Name = "tB_AboutMe";
            this.tB_AboutMe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_AboutMe.Size = new System.Drawing.Size(296, 30);
            this.tB_AboutMe.TabIndex = 11;
            this.tB_AboutMe.Enter += new System.EventHandler(this.tB_KeySkills_Enter);
            this.tB_AboutMe.Leave += new System.EventHandler(this.tB_KeySkills_Leave);
            // 
            // tB_Education
            // 
            this.tB_Education.AcceptsReturn = true;
            this.tB_Education.AllowDrop = true;
            this.tB_Education.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Education.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Education.Location = new System.Drawing.Point(319, 399);
            this.tB_Education.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Education.Multiline = true;
            this.tB_Education.Name = "tB_Education";
            this.tB_Education.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_Education.Size = new System.Drawing.Size(296, 30);
            this.tB_Education.TabIndex = 9;
            this.tB_Education.Enter += new System.EventHandler(this.tB_KeySkills_Enter);
            this.tB_Education.Leave += new System.EventHandler(this.tB_KeySkills_Leave);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Location = new System.Drawing.Point(12, 680);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(328, 60);
            this.btn_Delete.TabIndex = 55;
            this.btn_Delete.Text = "Удалить запись";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Save.Location = new System.Drawing.Point(492, 680);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(328, 60);
            this.btn_Save.TabIndex = 54;
            this.btn_Save.Text = "Сохранить запись";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Blackadder ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(832, 77);
            this.label13.TabIndex = 56;
            this.label13.Text = "Заполнение данных";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // DataInput_Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(832, 753);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cB_Schedule);
            this.Controls.Add(this.cB_Profession);
            this.Controls.Add(this.tB_Mail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tB_DesiredSalary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tB_WorkExperience);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tB_KeySkills);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tB_Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_Patronymic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_AboutMe);
            this.Controls.Add(this.tB_Education);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataInput_Resume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных для Резюме";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recruitmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.разновидностиграфикаработыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cB_Schedule;
        private System.Windows.Forms.ComboBox cB_Profession;
        private System.Windows.Forms.TextBox tB_Mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_DesiredSalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tB_WorkExperience;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_KeySkills;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Patronymic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_AboutMe;
        private System.Windows.Forms.TextBox tB_Education;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label13;
        private ОКиТПО_Кадровое_агенство.RecruitmentDBDataSet recruitmentDBDataSet;
        private System.Windows.Forms.BindingSource профессииBindingSource;
        private ОКиТПО_Кадровое_агенство.RecruitmentDBDataSetTableAdapters.ПрофессииTableAdapter профессииTableAdapter;
        private System.Windows.Forms.BindingSource разновидностиграфикаработыBindingSource;
        private ОКиТПО_Кадровое_агенство.RecruitmentDBDataSetTableAdapters.Разновидности_графика_работыTableAdapter разновидности_графика_работыTableAdapter;
    }
}