using Kursach.DbContextDate;
using Kursach.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Kursach.MainOffice
{
    public partial class FormTimeWork : Form
    {
        private DbContextData dbContext;

        string connectionString;
        public FormTimeWork(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void FormTimeWork_Load(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            dataGridViewWorkTime.DataSource = dbContext.WorkTimes.ToList();
            dataGridViewWorkTime.Columns[0].Visible = false;
            dataGridViewWorkTime.Columns[1].Visible = false;
            dataGridViewWorkTime.Columns[2].HeaderText = "Тип смены";
            dataGridViewWorkTime.Columns[3].HeaderText = "Начало смены";
            dataGridViewWorkTime.Columns[4].HeaderText = "Конец смены";
            dataGridViewWorkTime.Columns[5].HeaderText = "Дата";
            var doctorIds = dbContext.Doctors.ToList();
            for (int i = 0; doctorIds.Count > i; i++)
            {
                comboBoxListDoctors.Items.Add(doctorIds[i].SecondNameTeacher);
            }


        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewWorkTime.DataSource = dbContext.WorkTimes.ToArray();
        }

        private void buttonAddWorkTime_Click(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            WorkTime workTime = new WorkTime { DoctorId = comboBoxListDoctors.SelectedIndex + 1, BeginShift = textBoxBeginShift.Text, EndShift = textBoxEndShift.Text};

            dbContext.WorkTimes.Add(workTime);

            dbContext.SaveChanges();
        }

        private void buttonChangeWorkTime_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void buttonSearchWorkTime_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.WorkTimes.Where(d => d.TypeShift.Contains(textBoxSearch.Text) );
            dataGridViewWorkTime.DataSource = searchResult.ToList();
            dataGridViewWorkTime.Columns.RemoveAt(0);
        }
    }
}
