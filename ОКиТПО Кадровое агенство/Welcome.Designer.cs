namespace Тест
{
    partial class Welcome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.advancedDataGridView_Resume = new Zuby.ADGV.AdvancedDataGridView();
            this.btn_DeleteResume = new System.Windows.Forms.Button();
            this.btn_EditResume = new System.Windows.Forms.Button();
            this.btn_SaveResume = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.advancedDataGridView_Vacancy = new Zuby.ADGV.AdvancedDataGridView();
            this.btn_Delete_Vacancy = new System.Windows.Forms.Button();
            this.btn_Edit_Vacancy = new System.Windows.Forms.Button();
            this.btn_Save_Vacancy = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_addProfession = new System.Windows.Forms.Button();
            this.tB_addProfession = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_Resume)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_Vacancy)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1020, 642);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.advancedDataGridView_Resume);
            this.tabPage1.Controls.Add(this.btn_DeleteResume);
            this.tabPage1.Controls.Add(this.btn_EditResume);
            this.tabPage1.Controls.Add(this.btn_SaveResume);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1012, 606);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Резюме";
            // 
            // advancedDataGridView_Resume
            // 
            this.advancedDataGridView_Resume.AllowUserToAddRows = false;
            this.advancedDataGridView_Resume.AllowUserToDeleteRows = false;
            this.advancedDataGridView_Resume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView_Resume.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_Resume.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.advancedDataGridView_Resume.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_Resume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.advancedDataGridView_Resume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_Resume.DefaultCellStyle = dataGridViewCellStyle8;
            this.advancedDataGridView_Resume.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_Resume.FilterAndSortEnabled = true;
            this.advancedDataGridView_Resume.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView_Resume.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            this.advancedDataGridView_Resume.Location = new System.Drawing.Point(-4, 0);
            this.advancedDataGridView_Resume.MultiSelect = false;
            this.advancedDataGridView_Resume.Name = "advancedDataGridView_Resume";
            this.advancedDataGridView_Resume.ReadOnly = true;
            this.advancedDataGridView_Resume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView_Resume.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_Resume.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.advancedDataGridView_Resume.RowHeadersVisible = false;
            this.advancedDataGridView_Resume.RowHeadersWidth = 51;
            this.advancedDataGridView_Resume.RowTemplate.Height = 24;
            this.advancedDataGridView_Resume.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView_Resume.Size = new System.Drawing.Size(1020, 530);
            this.advancedDataGridView_Resume.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView_Resume.TabIndex = 32;
            this.advancedDataGridView_Resume.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_Resume_CellClick);
            this.advancedDataGridView_Resume.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.advancedDataGridView_Resume_DataBindingComplete);
            // 
            // btn_DeleteResume
            // 
            this.btn_DeleteResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteResume.BackColor = System.Drawing.Color.Firebrick;
            this.btn_DeleteResume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteResume.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeleteResume.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DeleteResume.Location = new System.Drawing.Point(676, 537);
            this.btn_DeleteResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteResume.Name = "btn_DeleteResume";
            this.btn_DeleteResume.Size = new System.Drawing.Size(328, 60);
            this.btn_DeleteResume.TabIndex = 31;
            this.btn_DeleteResume.Text = "Удалить запись";
            this.btn_DeleteResume.UseVisualStyleBackColor = false;
            this.btn_DeleteResume.Click += new System.EventHandler(this.btn_Delete_Resume_Click);
            // 
            // btn_EditResume
            // 
            this.btn_EditResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EditResume.BackColor = System.Drawing.Color.Indigo;
            this.btn_EditResume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_EditResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditResume.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditResume.Location = new System.Drawing.Point(342, 537);
            this.btn_EditResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_EditResume.Name = "btn_EditResume";
            this.btn_EditResume.Size = new System.Drawing.Size(328, 60);
            this.btn_EditResume.TabIndex = 30;
            this.btn_EditResume.Text = "Редактировать запись";
            this.btn_EditResume.UseVisualStyleBackColor = false;
            this.btn_EditResume.Click += new System.EventHandler(this.btn_Edit_Resume_Click);
            // 
            // btn_SaveResume
            // 
            this.btn_SaveResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SaveResume.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_SaveResume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SaveResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveResume.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveResume.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SaveResume.Location = new System.Drawing.Point(8, 537);
            this.btn_SaveResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveResume.Name = "btn_SaveResume";
            this.btn_SaveResume.Size = new System.Drawing.Size(328, 60);
            this.btn_SaveResume.TabIndex = 3;
            this.btn_SaveResume.Text = "Добавить новое резюме";
            this.btn_SaveResume.UseVisualStyleBackColor = false;
            this.btn_SaveResume.Click += new System.EventHandler(this.btn_Save_Resume_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.advancedDataGridView_Vacancy);
            this.tabPage2.Controls.Add(this.btn_Delete_Vacancy);
            this.tabPage2.Controls.Add(this.btn_Edit_Vacancy);
            this.tabPage2.Controls.Add(this.btn_Save_Vacancy);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1012, 606);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Вакансии";
            // 
            // advancedDataGridView_Vacancy
            // 
            this.advancedDataGridView_Vacancy.AllowUserToAddRows = false;
            this.advancedDataGridView_Vacancy.AllowUserToDeleteRows = false;
            this.advancedDataGridView_Vacancy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView_Vacancy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.advancedDataGridView_Vacancy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.advancedDataGridView_Vacancy.CausesValidation = false;
            this.advancedDataGridView_Vacancy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_Vacancy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.advancedDataGridView_Vacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_Vacancy.DefaultCellStyle = dataGridViewCellStyle11;
            this.advancedDataGridView_Vacancy.EnableHeadersVisualStyles = false;
            this.advancedDataGridView_Vacancy.FilterAndSortEnabled = true;
            this.advancedDataGridView_Vacancy.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView_Vacancy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            this.advancedDataGridView_Vacancy.Location = new System.Drawing.Point(-2, 0);
            this.advancedDataGridView_Vacancy.MultiSelect = false;
            this.advancedDataGridView_Vacancy.Name = "advancedDataGridView_Vacancy";
            this.advancedDataGridView_Vacancy.ReadOnly = true;
            this.advancedDataGridView_Vacancy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView_Vacancy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedDataGridView_Vacancy.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.advancedDataGridView_Vacancy.RowHeadersVisible = false;
            this.advancedDataGridView_Vacancy.RowHeadersWidth = 51;
            this.advancedDataGridView_Vacancy.RowTemplate.Height = 24;
            this.advancedDataGridView_Vacancy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView_Vacancy.Size = new System.Drawing.Size(1016, 530);
            this.advancedDataGridView_Vacancy.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.advancedDataGridView_Vacancy.TabIndex = 36;
            this.advancedDataGridView_Vacancy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView_Vacancy_CellClick);
            this.advancedDataGridView_Vacancy.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.advancedDataGridView_Vacancy_DataBindingComplete);
            // 
            // btn_Delete_Vacancy
            // 
            this.btn_Delete_Vacancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete_Vacancy.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete_Vacancy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Vacancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Vacancy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete_Vacancy.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Delete_Vacancy.Location = new System.Drawing.Point(676, 537);
            this.btn_Delete_Vacancy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Delete_Vacancy.Name = "btn_Delete_Vacancy";
            this.btn_Delete_Vacancy.Size = new System.Drawing.Size(328, 60);
            this.btn_Delete_Vacancy.TabIndex = 35;
            this.btn_Delete_Vacancy.Text = "Удалить запись";
            this.btn_Delete_Vacancy.UseVisualStyleBackColor = false;
            this.btn_Delete_Vacancy.Click += new System.EventHandler(this.btn_Delete_Vacancy_Click);
            // 
            // btn_Edit_Vacancy
            // 
            this.btn_Edit_Vacancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit_Vacancy.BackColor = System.Drawing.Color.Indigo;
            this.btn_Edit_Vacancy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Edit_Vacancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit_Vacancy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Edit_Vacancy.Location = new System.Drawing.Point(342, 537);
            this.btn_Edit_Vacancy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit_Vacancy.Name = "btn_Edit_Vacancy";
            this.btn_Edit_Vacancy.Size = new System.Drawing.Size(328, 60);
            this.btn_Edit_Vacancy.TabIndex = 34;
            this.btn_Edit_Vacancy.Text = "Редактировать запись";
            this.btn_Edit_Vacancy.UseVisualStyleBackColor = false;
            this.btn_Edit_Vacancy.Click += new System.EventHandler(this.btn_Edit_Vacancy_Click);
            // 
            // btn_Save_Vacancy
            // 
            this.btn_Save_Vacancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save_Vacancy.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Save_Vacancy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Save_Vacancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_Vacancy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save_Vacancy.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Save_Vacancy.Location = new System.Drawing.Point(8, 537);
            this.btn_Save_Vacancy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save_Vacancy.Name = "btn_Save_Vacancy";
            this.btn_Save_Vacancy.Size = new System.Drawing.Size(328, 60);
            this.btn_Save_Vacancy.TabIndex = 33;
            this.btn_Save_Vacancy.Text = "Добавить новое резюме";
            this.btn_Save_Vacancy.UseVisualStyleBackColor = false;
            this.btn_Save_Vacancy.Click += new System.EventHandler(this.btn_Save_Vacancy_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.tabPage3.Controls.Add(this.btn_addProfession);
            this.tabPage3.Controls.Add(this.tB_addProfession);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1012, 606);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Добавить новую профессию";
            // 
            // btn_addProfession
            // 
            this.btn_addProfession.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_addProfession.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_addProfession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProfession.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addProfession.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addProfession.Location = new System.Drawing.Point(12, 87);
            this.btn_addProfession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addProfession.Name = "btn_addProfession";
            this.btn_addProfession.Size = new System.Drawing.Size(328, 60);
            this.btn_addProfession.TabIndex = 34;
            this.btn_addProfession.Text = "Добавить профессию";
            this.btn_addProfession.UseVisualStyleBackColor = false;
            this.btn_addProfession.Click += new System.EventHandler(this.btn_addProfession_Click);
            // 
            // tB_addProfession
            // 
            this.tB_addProfession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_addProfession.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_addProfession.Location = new System.Drawing.Point(12, 45);
            this.tB_addProfession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_addProfession.MaxLength = 100;
            this.tB_addProfession.Name = "tB_addProfession";
            this.tB_addProfession.Size = new System.Drawing.Size(328, 34);
            this.tB_addProfession.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(312, 38);
            this.label13.TabIndex = 33;
            this.label13.Text = "Введите название профессии";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1020, 642);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(207)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Welcome";
            this.Text = "Программный модуль \"Кадровое агенство\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_Resume)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView_Vacancy)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_SaveResume;
        private System.Windows.Forms.Button btn_EditResume;
        private System.Windows.Forms.Button btn_DeleteResume;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView_Resume;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tB_addProfession;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_addProfession;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView_Vacancy;
        private System.Windows.Forms.Button btn_Delete_Vacancy;
        private System.Windows.Forms.Button btn_Edit_Vacancy;
        private System.Windows.Forms.Button btn_Save_Vacancy;
    }
}

