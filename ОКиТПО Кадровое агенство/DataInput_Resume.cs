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
	public partial class DataInput_Resume : Form
	{
		
		Welcome main;
		private SqlConnection sqlConnection = null;
		bool ModeEdit = false;
		Resume CurrentResume;

		public DataInput_Resume(bool mode)
		{		
			InitializeComponent();
			ModeEdit = mode;
			btn_Delete.Visible = false;
		}
		public DataInput_Resume(bool mode, Resume resume)
		{
			InitializeComponent();
			ModeEdit = mode;
			label13.Text = "Редактирование данных";
			CurrentResume = resume;
		}

		private void DataInput_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recruitmentDBDataSet.Разновидности_графика_работы". При необходимости она может быть перемещена или удалена.
            this.разновидности_графика_работыTableAdapter.Fill(this.recruitmentDBDataSet.Разновидности_графика_работы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "recruitmentDBDataSet.Профессии". При необходимости она может быть перемещена или удалена.
            this.профессииTableAdapter.Fill(this.recruitmentDBDataSet.Профессии);
            fillData(CurrentResume);
            main = this.Owner as Welcome;
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RecruitmentDB"].ConnectionString);
			sqlConnection.Open();
		}

		public void fillData(Resume SelectedResume) 
        {
            if (ModeEdit)
            {
				CurrentResume = SelectedResume;
			}
            else
            {
				CurrentResume.clear();
            }			
			tB_Surname.Text = CurrentResume.Surname;
			tB_Name.Text = CurrentResume.Name;
			tB_Patronymic.Text = CurrentResume.Patronymic;
			tB_Age.Text = CurrentResume.Age;
			cB_Profession.Text = CurrentResume.Profession;
			tB_KeySkills.Text = CurrentResume.KeySkills;
			cB_Schedule.Text = CurrentResume.Schedule;
			tB_WorkExperience.Text = CurrentResume.WorkExperience;
			tB_Education.Text = CurrentResume.Education;
			tB_DesiredSalary.Text = CurrentResume.DesiredSalary;
			tB_AboutMe.Text = CurrentResume.AboutMe;
			tB_Mail.Text = CurrentResume.Mail;
		}

		private int Temp_Height;
		private int Temp_Width;
		private void tB_KeySkills_Enter(object sender, EventArgs e)
		{
			Temp_Height = ((TextBox)sender).Height;
			Temp_Width = ((TextBox)sender).Width;
			((TextBox)sender).Height = 200;
			((TextBox)sender).Width = 500;
			((TextBox)sender).BringToFront();
		}

		private void tB_KeySkills_Leave(object sender, EventArgs e)
		{
			((TextBox)sender).Height = Temp_Height;
			((TextBox)sender).Width = Temp_Width;
			((TextBox)sender).SendToBack();
		}

        private void tB_Age_KeyPress(object sender, KeyPressEventArgs e)
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
				command.Parameters.AddWithValue("Фамилия", tB_Surname.Text);
				command.Parameters.AddWithValue("Имя", tB_Name.Text);
				command.Parameters.AddWithValue("Отчество", tB_Patronymic.Text);
				command.Parameters.AddWithValue("Возраст", tB_Age.Text);
				command.Parameters.AddWithValue("Профессия", cB_Profession.SelectedValue.ToString());
				command.Parameters.AddWithValue("Ключевые_навыки", tB_KeySkills.Text);
				command.Parameters.AddWithValue("График_работы", cB_Schedule.SelectedValue.ToString());
				command.Parameters.AddWithValue("Опыт_работы", tB_WorkExperience.Text);
				command.Parameters.AddWithValue("Образование", tB_Education.Text);
				command.Parameters.AddWithValue("Желаемая_ЗП", tB_DesiredSalary.Text);
				command.Parameters.AddWithValue("Обо_мне", tB_AboutMe.Text);
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
            if (tB_Surname.Text == "" || tB_Name.Text == "" || tB_Age.Text == "" || cB_Profession.Text == "" || tB_KeySkills.Text == "" || cB_Schedule.Text == "" || tB_WorkExperience.Text == "" || tB_Education.Text == "" || tB_DesiredSalary.Text == "" || tB_AboutMe.Text == "" || tB_Mail.Text == "")
            {
                MessageBox.Show("Заполните все данные");
            }
            else
            {
                SqlCommand sqlCommand;
                switch (ModeEdit)
                {
                    case false:
                        sqlCommand = new SqlCommand($"Insert INTO [Резюме] (Фамилия, Имя, Отчество, Возраст, Профессия, [Ключевые навыки], [График работы], [Опыт работы], Образование, [Желаемая З/П], [Обо мне], Почта) " +
                                $"VALUES (@Фамилия, @Имя, @Отчество, @Возраст, @Профессия, @Ключевые_навыки, @График_работы, @Опыт_работы, @Образование, @Желаемая_ЗП, @Обо_мне, @Почта)", sqlConnection);
                        sqladd(sqlCommand, "Резюме добавлено в БД");
                        break;
                    case true:
                        sqlCommand = new SqlCommand($"Update [Резюме] set Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество, Возраст = @Возраст, Профессия = @Профессия, [Ключевые навыки] = @Ключевые_навыки, [График работы] = @График_работы, [Опыт работы] = @Опыт_работы, Образование = @Образование, [Желаемая З/П] = @Желаемая_ЗП, [Обо мне] = @Обо_мне, Почта = @Почта " +
                                $"Where Id={CurrentResume.id}", sqlConnection);
                        sqladd(sqlCommand, "Резюме изменено в БД");
                        break;
                }
                main.showDB_REZUME();
                this.Close();
            }
        }

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand sqlCommand = new SqlCommand($"Delete [Резюме] Where Id={CurrentResume.id}", sqlConnection);
				if (sqlCommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Резюме удалено из БД");
				}
				sqlCommand.Parameters.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			main.showDB_REZUME();
			this.Close();
		}
    }
}
