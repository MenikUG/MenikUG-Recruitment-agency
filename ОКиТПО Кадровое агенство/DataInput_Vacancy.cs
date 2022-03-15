using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Тест
{
    public partial class DataInput_Vacancy : Form
    {
        
        Welcome main;
        private SqlConnection sqlConnection = null;
        bool ModeEdit = false;
        Vacancy CurrentVacancy;

        public DataInput_Vacancy(bool mode)
        {
            InitializeComponent();
            ModeEdit = mode;
            btn_Delete.Visible = false;
        }

        public DataInput_Vacancy(bool mode, Vacancy vacancy)
        {
            InitializeComponent();
            ModeEdit = mode;
            label13.Text = "Редактирование данных";
            CurrentVacancy = vacancy;
        }

        private void DataInput_Vacancy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recruitmentDBDataSet.Разновидности_графика_работы". При необходимости она может быть перемещена или удалена.
            this.разновидности_графика_работыTableAdapter.Fill(this.recruitmentDBDataSet.Разновидности_графика_работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recruitmentDBDataSet.Профессии". При необходимости она может быть перемещена или удалена.
            this.профессииTableAdapter.Fill(this.recruitmentDBDataSet.Профессии);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recruitmentDBDataSet.Профессии". При необходимости она может быть перемещена или удалена.
            this.профессииTableAdapter.Fill(this.recruitmentDBDataSet.Профессии);
            fillData(CurrentVacancy);
            main = this.Owner as Welcome;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RecruitmentDB"].ConnectionString);
            sqlConnection.Open();
        }
        public void fillData(Vacancy SelectedVacancy)
        {
            if (ModeEdit)
            {
                CurrentVacancy = SelectedVacancy;
            }
            else
            {
                CurrentVacancy.clear();
            }
            cB_Profession.Text = CurrentVacancy.Profession;
            tB_Company.Text = CurrentVacancy.Company;
            tB_WorkExperience.Text = CurrentVacancy.WorkExperience;
            tB_Salary.Text = CurrentVacancy.Salary;
            cB_Schedule.Text = CurrentVacancy.Schedule;
            tB_Requirements.Text = CurrentVacancy.Requirements;
            tB_Tasks.Text = CurrentVacancy.Tasks;
            tB_KeySkills.Text = CurrentVacancy.KeySkills;
            tB_AboutUs.Text = CurrentVacancy.AboutUs;
            tB_Mail.Text = CurrentVacancy.Mail;
        }

        private int Temp_Height;
        private int Temp_Width;

        private void tB_Requirements_Enter(object sender, EventArgs e)
        {
            Temp_Height = ((TextBox)sender).Height;
            Temp_Width = ((TextBox)sender).Width;
            ((TextBox)sender).Height = 200;
            ((TextBox)sender).Width = 500;
            ((TextBox)sender).BringToFront();
        }

        private void tB_Requirements_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Height = Temp_Height;
            ((TextBox)sender).Width = Temp_Width;
            ((TextBox)sender).SendToBack();
        }

        private void tB_WorkExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public void sqladd(SqlCommand command, string message)
        {
            try
            {
                command.Parameters.AddWithValue("Профессия", cB_Profession.SelectedValue.ToString());
                command.Parameters.AddWithValue("Компания", tB_Company.Text);
                command.Parameters.AddWithValue("Требуемый_опыт_работы", tB_WorkExperience.Text);
                command.Parameters.AddWithValue("Зарплата", tB_Salary.Text);
                command.Parameters.AddWithValue("График_работы", cB_Schedule.SelectedValue.ToString());
                command.Parameters.AddWithValue("Требования", tB_Requirements.Text);
                command.Parameters.AddWithValue("Ваши_задачи", tB_Tasks.Text);
                command.Parameters.AddWithValue("Ключевые_навыки", tB_KeySkills.Text);
                command.Parameters.AddWithValue("О_нас", tB_AboutUs.Text);
                command.Parameters.AddWithValue("Почта", tB_Mail.Text);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cB_Profession.Text == "" || tB_Company.Text == "" || tB_WorkExperience.Text == "" || tB_Salary.Text == "" || cB_Schedule.Text == "" || tB_Requirements.Text == "" || tB_Tasks.Text == "" || tB_KeySkills.Text == "" || tB_AboutUs.Text == "" || tB_Mail.Text == "")
            {
                MessageBox.Show("Заполните все данные");
            }
            else
            {
                SqlCommand sqlCommand;
                switch (ModeEdit)
                {
                    case false:
                        sqlCommand = new SqlCommand($"Insert INTO [Вакансии] (Профессия, Компания, [Требуемый опыт работы], Зарплата, [График работы], Требования, [Ваши задачи], [Ключевые навыки], [О нас], Почта) " +
                                $"VALUES (@Профессия, @Компания, @Требуемый_опыт_работы, @Зарплата, @График_работы, @Требования, @Ваши_задачи, @Ключевые_навыки, @О_нас, @Почта)", sqlConnection);
                        sqladd(sqlCommand, "Вакансия добавлена в БД");
                        break;
                    case true:
                        sqlCommand = new SqlCommand($"Update [Вакансии] set Профессия = @Профессия, Компания = @Компания, [Требуемый опыт работы] = @Требуемый_опыт_работы, Зарплата = @Зарплата, [График работы] = @График_работы, Требования = @Требования, [Ваши задачи] = @Ваши_задачи, [Ключевые навыки] = @Ключевые_навыки, [О нас] = @О_нас, Почта = @Почта " +
                                $"Where Id={CurrentVacancy.id}", sqlConnection);
                        sqladd(sqlCommand, "Вакансия изменена в БД");
                        break;
                }
                main.showDB_VACANCY();
                this.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand($"Delete [Вакансии] Where Id={CurrentVacancy.id}", sqlConnection);
                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вакансия удалена из БД");
                }
                sqlCommand.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            main.showDB_VACANCY();
            this.Close();
        }
    }
}
