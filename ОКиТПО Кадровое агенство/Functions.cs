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
    internal class Functions
    {

	}

    public struct Resume
    {
        public int id;
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Age;
        public string Profession;
        public string KeySkills;
        public string Schedule;
        public string WorkExperience;
        public string Education;
        public string DesiredSalary;
        public string AboutMe;
        public string Mail;

        public void clear()
        {
            id = 0;
            Surname = null;
            Name = null;
            Patronymic = null;
            Age = null;
            Profession = null;
            KeySkills = null;
            Schedule = null;
            WorkExperience = null;
            Education = null;
            DesiredSalary = null;
            AboutMe = null;
            Mail = null;
        }
    }

    public struct Vacancy
    {
        public int id;
        public string Profession;
        public string Company;
        public string WorkExperience;
        public string Salary;
        public string Schedule;
        public string Requirements;
        public string Tasks;
        public string KeySkills;
        public string AboutUs;
        public string Mail;

        public void clear()
        {
            id = 0;
            Profession = null;
            Company = null;
            WorkExperience = null;
            Salary = null;
            Schedule = null;
            Requirements = null;
            Tasks = null;
            KeySkills = null;
            AboutUs = null;
            Mail = null;
        }
    }
}
