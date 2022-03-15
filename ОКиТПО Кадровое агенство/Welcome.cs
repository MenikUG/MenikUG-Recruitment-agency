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
	public partial class Welcome : Form
	{
		private SqlConnection sqlConnection = null;
		Resume SelectedResume;
		Vacancy SelectedVacancy;
		DataInput_Resume dataInput_Resume;
		DataInput_Vacancy dataInput_Vacancy;
		public Welcome()
		{
			InitializeComponent();
			SelectedResume.id = 0;
			SelectedVacancy.id = 0;
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RecruitmentDB"].ConnectionString);
			sqlConnection.Open();
		}

		public void showDB_REZUME()
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Р.Id, Р.Фамилия, Р.Имя, Р.Отчество, Р.Возраст," +
                "Профессии.[Название профессии], Р.[Ключевые навыки], Рграфраб.[График работы], Р.[Опыт работы]," +
                "Р.Образование, Р.[Желаемая З/П], Р.[Обо мне], Р.Почта FROM Резюме AS Р " +
				"Join Профессии ON Р.Профессия = Профессии.Id " +
				"Join Разновидности_графика_работы AS Рграфраб ON Р.[График работы] = Рграфраб.Id", sqlConnection);

			DataSet dataset = new DataSet();
			dataAdapter.Fill(dataset);
			advancedDataGridView_Resume.DataSource = dataset.Tables[0];
			advancedDataGridView_Resume.Columns[0].Width = 23;
			advancedDataGridView_Resume.Columns[1].Width = 100;
			advancedDataGridView_Resume.Columns[2].Width = 100;
			advancedDataGridView_Resume.Columns[3].Width = 107;
			advancedDataGridView_Resume.Columns[4].Width = 73;
			advancedDataGridView_Resume.Columns[5].Width = 130;
			advancedDataGridView_Resume.Columns[6].Width = 250;
			advancedDataGridView_Resume.Columns[7].Width = 90;
			advancedDataGridView_Resume.Columns[8].Width = 70;
			advancedDataGridView_Resume.Columns[9].Width = 171;
			advancedDataGridView_Resume.Columns[10].Width = 91;
			advancedDataGridView_Resume.Columns[11].Width = 463;
			advancedDataGridView_Resume.Columns[12].Width = 228;
		}

		public void showDB_VACANCY()
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT В.Id, Профессии.[Название профессии]," +
                "В.Компания, В.[Требуемый опыт работы], В.Зарплата, Рграфраб.[График работы], В.Требования," +
                "В.[Ваши задачи], В.[Ключевые навыки], В.[О нас], В.Почта FROM Вакансии AS В " +
                "Join Профессии ON В.Профессия = Профессии.Id " +
                "Join Разновидности_графика_работы AS Рграфраб ON В.[График работы] = Рграфраб.Id", sqlConnection);

			DataSet dataset = new DataSet();
			dataAdapter.Fill(dataset);
			advancedDataGridView_Vacancy.DataSource = dataset.Tables[0];
            advancedDataGridView_Vacancy.Columns[0].Width = 27;
            advancedDataGridView_Vacancy.Columns[1].Width = 134;
            advancedDataGridView_Vacancy.Columns[2].Width = 174;
            advancedDataGridView_Vacancy.Columns[3].Width = 98;
            advancedDataGridView_Vacancy.Columns[4].Width = 80;
            advancedDataGridView_Vacancy.Columns[5].Width = 92;
            advancedDataGridView_Vacancy.Columns[6].Width = 380;
            advancedDataGridView_Vacancy.Columns[7].Width = 225;
            advancedDataGridView_Vacancy.Columns[8].Width = 246;
            advancedDataGridView_Vacancy.Columns[9].Width = 235;
            advancedDataGridView_Vacancy.Columns[10].Width = 200;
        }

		private void Welcome_Load(object sender, EventArgs e)
		{
            showDB_REZUME();
			showDB_VACANCY();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
            //if (textBox1.Text != "")
            //{
            //    (advancedDataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Id > {textBox1.Text}";
            //}
        }

		private void btn_Save_Resume_Click(object sender, EventArgs e)
        {
			dataInput_Resume = new DataInput_Resume(false);
			dataInput_Resume.Owner = this;
			dataInput_Resume.ShowDialog();
		}

        private void btn_Edit_Resume_Click(object sender, EventArgs e)
        {
			if(SelectedResume.id != 0)
            {
				dataInput_Resume = new DataInput_Resume(true, SelectedResume);
				dataInput_Resume.Owner = this;
				dataInput_Resume.ShowDialog();
			}
            else
            {
				MessageBox.Show("Выберите запись для редактирования");
            }
        }

        private void btn_Delete_Resume_Click(object sender, EventArgs e)
        {
			try
			{
				SqlCommand sqlCommand = new SqlCommand($"Delete [Резюме] Where Id={SelectedResume.id}", sqlConnection);
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
			showDB_REZUME();
		}

		private void btn_Save_Vacancy_Click(object sender, EventArgs e)
		{
			dataInput_Vacancy = new DataInput_Vacancy(false);
			dataInput_Vacancy.Owner = this;
			dataInput_Vacancy.ShowDialog();
		}

		private void btn_Edit_Vacancy_Click(object sender, EventArgs e)
		{
			if (SelectedVacancy.id != 0)
			{
				dataInput_Vacancy = new DataInput_Vacancy(true, SelectedVacancy);
				dataInput_Vacancy.Owner = this;
				dataInput_Vacancy.ShowDialog();
			}
			else
			{
				MessageBox.Show("Выберите запись для редактирования");
			}
		}

		private void btn_Delete_Vacancy_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand sqlCommand = new SqlCommand($"Delete [Вакансии] Where Id={SelectedVacancy.id}", sqlConnection);
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
			showDB_VACANCY();
		}

        private void btn_addProfession_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand($"Insert INTO [Профессии] ([Название профессии]) VALUES (@Профессия)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Профессия", tB_addProfession.Text);

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Профессия добавлена в БД");
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }			
		}

		private void advancedDataGridView_Resume_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
				SelectedResume.id = Convert.ToInt32(advancedDataGridView_Resume.SelectedRows[0].Cells[0].Value.ToString());
				SelectedResume.Surname = advancedDataGridView_Resume.SelectedRows[0].Cells[1].Value.ToString();
				SelectedResume.Name = advancedDataGridView_Resume.SelectedRows[0].Cells[2].Value.ToString();
				SelectedResume.Patronymic = advancedDataGridView_Resume.SelectedRows[0].Cells[3].Value.ToString();
				SelectedResume.Age = advancedDataGridView_Resume.SelectedRows[0].Cells[4].Value.ToString();
				SelectedResume.Profession = advancedDataGridView_Resume.SelectedRows[0].Cells[5].Value.ToString();
				SelectedResume.KeySkills = advancedDataGridView_Resume.SelectedRows[0].Cells[6].Value.ToString();
				SelectedResume.Schedule = advancedDataGridView_Resume.SelectedRows[0].Cells[7].Value.ToString();
				SelectedResume.WorkExperience = advancedDataGridView_Resume.SelectedRows[0].Cells[8].Value.ToString();
				SelectedResume.Education = advancedDataGridView_Resume.SelectedRows[0].Cells[9].Value.ToString();
				SelectedResume.DesiredSalary = advancedDataGridView_Resume.SelectedRows[0].Cells[10].Value.ToString();
				SelectedResume.AboutMe = advancedDataGridView_Resume.SelectedRows[0].Cells[11].Value.ToString();
				SelectedResume.Mail = advancedDataGridView_Resume.SelectedRows[0].Cells[12].Value.ToString();
			}
            catch (Exception ex)
            {
				//MessageBox.Show(ex.Message);
            }
		}

		private void advancedDataGridView_Vacancy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
				SelectedVacancy.id = Convert.ToInt32(advancedDataGridView_Vacancy.SelectedRows[0].Cells[0].Value.ToString());
				SelectedVacancy.Profession = advancedDataGridView_Vacancy.SelectedRows[0].Cells[1].Value.ToString();
				SelectedVacancy.Company = advancedDataGridView_Vacancy.SelectedRows[0].Cells[2].Value.ToString();
				SelectedVacancy.WorkExperience = advancedDataGridView_Vacancy.SelectedRows[0].Cells[3].Value.ToString();
				SelectedVacancy.Salary = advancedDataGridView_Vacancy.SelectedRows[0].Cells[4].Value.ToString();
				SelectedVacancy.Schedule = advancedDataGridView_Vacancy.SelectedRows[0].Cells[5].Value.ToString();
				SelectedVacancy.Requirements = advancedDataGridView_Vacancy.SelectedRows[0].Cells[6].Value.ToString();
				SelectedVacancy.Tasks = advancedDataGridView_Vacancy.SelectedRows[0].Cells[7].Value.ToString();
				SelectedVacancy.KeySkills = advancedDataGridView_Vacancy.SelectedRows[0].Cells[8].Value.ToString();
				SelectedVacancy.AboutUs = advancedDataGridView_Vacancy.SelectedRows[0].Cells[9].Value.ToString();
				SelectedVacancy.Mail = advancedDataGridView_Vacancy.SelectedRows[0].Cells[10].Value.ToString();
			}
            catch (Exception ex)
            {
				//MessageBox.Show(ex.Message);
            }
		}

        private void advancedDataGridView_Vacancy_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			advancedDataGridView_Vacancy.ClearSelection();
			SelectedVacancy.clear();
        }

        private void advancedDataGridView_Resume_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
			advancedDataGridView_Resume.ClearSelection();
			SelectedResume.clear();
		}
    }
}
