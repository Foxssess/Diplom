using Kursach.DbContextDate;
using Kursach.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.MainOffice
{
    public partial class FormCreatePriem : Form
    {
        private DbContextData dbContext;

        int selectedDoctor;

        int selectedPatient;

        string connectionString;

        public FormCreatePriem(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void buttonMoveCreatePatient_Click(object sender, EventArgs e)
        {
            FormCreatePatient formCreatePatient = new FormCreatePatient(connectionString);
            formCreatePatient.ShowDialog();
        }

        private void FormCreatePriem_Load(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            var receptions = dbContext.Receptions.ToArray();
            dataGridViewPriem.DataSource = receptions;
            dataGridViewPriem.Columns.Add("Doctor", "Doctor");
            dataGridViewPriem.Columns.Add("Patient", "Patient");
            dataGridViewPriem.Columns[0].Visible = false;
            dataGridViewPriem.Columns[2].Visible = false;
            dataGridViewPriem.Columns[7].Visible = false;
            dataGridViewPriem.Columns[1].HeaderText = "Время занятия";
            dataGridViewPriem.Columns[3].HeaderText = "Название услуги";
            dataGridViewPriem.Columns[4].HeaderText = "Стоимость";
            dataGridViewPriem.Columns[5].HeaderText = "Кабинет";
            dataGridViewPriem.Columns[6].HeaderText = "Дата";
            dataGridViewPriem.Columns[8].HeaderText = "Воспитатель";
            dataGridViewPriem.Columns[9].HeaderText = "Воспитанник";
         

            for (int i = 0; i < receptions.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells[2].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameTeacher;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells[7].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
            dataGridViewListDoctors.DataSource = dbContext.Doctors.ToArray();
            dataGridViewListPatients.DataSource = dbContext.Patients.ToArray();
            dataGridViewListDoctors.Columns[0].Visible = false;
            dataGridViewListPatients.Columns[0].Visible = false;
            var room = dbContext.Rooms.ToList();
            for (int i = 0; room.Count > i; i++)
            {
                comboBoxRoom.Items.Add(room[i].NameRoom);
            }
            if (connectionString == "Host=localhost;Port=5432;Database=MainOffice;Username=postgres;Password=Microla412")
            {
                buttonShowAll.Visible = true;
            }
            else
            {
                buttonShowAll.Visible = false;
            }

            dataGridViewListPatients.Columns[2].HeaderText = "Имя";
            dataGridViewListPatients.Columns[1].HeaderText = "Фамилия";
            dataGridViewListPatients.Columns[3].HeaderText = "Отчество";
            dataGridViewListPatients.Columns[4].HeaderText = "Пол";
            dataGridViewListPatients.Columns[5].HeaderText = "Адрес";
            dataGridViewListPatients.Columns[6].HeaderText = "День рождения";
            dataGridViewListPatients.Columns[7].HeaderText = "Телефон";
            dataGridViewListPatients.Columns[8].HeaderText = "Снилс";
            dataGridViewListPatients.Columns[9].HeaderText = "Полис";
            dataGridViewListPatients.Columns[10].HeaderText = "Свидетельство о рождении";
            dataGridViewListDoctors.Columns[2].HeaderText = "Имя";
            dataGridViewListDoctors.Columns[1].HeaderText = "Фамилия";
            dataGridViewListDoctors.Columns[3].HeaderText = "Отчество";
            dataGridViewListDoctors.Columns[4].HeaderText = "Должность";
            dataGridViewListDoctors.Columns[5].HeaderText = "День рождения";
            dataGridViewListDoctors.Columns[6].HeaderText = "Адрес";
            dataGridViewListDoctors.Columns[7].HeaderText = "Телефон";
            dataGridViewListDoctors.Columns[8].HeaderText = "Стаж работы";
            dataGridViewListDoctors.Columns[9].HeaderText = "Диплом";
            dataGridViewListDoctors.Columns[10].HeaderText = "Военный билет";
            dataGridViewListDoctors.Columns[11].HeaderText = "Снилс";
            dataGridViewListDoctors.Columns[12].HeaderText = "Паспорт";

        }

        private void buttonCreatePriem_Click(object sender, EventArgs e)
        {
            Reception reception = new Reception { Cost = textBoxCost.Text, Room = comboBoxRoom.Text, DoctorId = selectedDoctor, Data = DateOnly.FromDateTime(dateTimePickerPriem.Value), PatientId = selectedPatient, Time = textBoxPriemTime.Text};
           
            dbContext.Receptions.Add(reception);
            
            dbContext.SaveChanges();

            dataGridViewPriem.DataSource = dbContext.Receptions.ToArray();

            var receptions = dbContext.Receptions.ToArray();
            dataGridViewPriem.DataSource = receptions;
            for (int i = 0; i < receptions.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameTeacher;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
        }

        private void buttonMoveListDoctors_Click(object sender, EventArgs e)
        {
            FormListDoctors formListDoctors = new FormListDoctors(connectionString);
            formListDoctors.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var receptions = dbContext.Receptions.ToArray();
            dataGridViewPriem.DataSource = receptions;
            for (int i = 0; i < receptions.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameTeacher;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }

        }

        private void buttonSearchPriem_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Receptions.Where(d => d.NameService.Contains(textBoxSearchPriem.Text) || d.Room.Contains(textBoxSearchPriem.Text)|| d.Time.Contains(textBoxSearchPriem.Text));
            dataGridViewPriem.DataSource = searchResult.ToList();
            for (int i = 0; i < searchResult.Count(); i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameTeacher;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
            //dataGridViewPriem.Columns.RemoveAt(0);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            var receptions = dbContext.Receptions.ToList();

            dataGridViewPriem.DataSource = receptions ;

            var receptionsMain = dbContext.Receptions.ToArray();

            for (int i = 0; i < receptionsMain.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameTeacher;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
        }

        private void buttonMoveTimeWork_Click(object sender, EventArgs e)
        {
            FormTimeWork formTimeWork = new FormTimeWork(connectionString);
            formTimeWork.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void dataGridViewListPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedPatient = (int)dataGridViewListPatients.Rows[e.RowIndex].Cells[0].Value;
            }
            catch { 
            }
        }

        private void dataGridViewListDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedDoctor = (int)dataGridViewListDoctors.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {
            }
        }

        private void dataGridViewListPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridViewListPatients.Columns[2].HeaderText = "Имя";
            dataGridViewListPatients.Columns[1].HeaderText = "Фамилия";
            dataGridViewListPatients.Columns[3].HeaderText = "Отчество";
            dataGridViewListPatients.Columns[4].HeaderText = "Пол";
            dataGridViewListPatients.Columns[5].HeaderText = "Адрес";
            dataGridViewListPatients.Columns[6].HeaderText = "День рождения";
            dataGridViewListPatients.Columns[7].HeaderText = "Телефон";
            dataGridViewListPatients.Columns[8].HeaderText = "Снилс";
            dataGridViewListPatients.Columns[9].HeaderText = "Полис";
            dataGridViewListPatients.Columns[10].HeaderText = "Свидетельство о рождении";
        }

        private void dataGridViewListDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewListDoctors.Columns[2].HeaderText = "Имя";
            dataGridViewListDoctors.Columns[1].HeaderText = "Фамилия";
            dataGridViewListDoctors.Columns[3].HeaderText = "Отчество";
            dataGridViewListDoctors.Columns[4].HeaderText = "Должность";
            dataGridViewListDoctors.Columns[5].HeaderText = "День рождения";
            dataGridViewListDoctors.Columns[6].HeaderText = "Адрес";
            dataGridViewListDoctors.Columns[7].HeaderText = "Телефон";
            dataGridViewListDoctors.Columns[8].HeaderText = "Стаж работы";
            dataGridViewListDoctors.Columns[9].HeaderText = "Диплом";
            dataGridViewListDoctors.Columns[10].HeaderText = "Военный билет";
            dataGridViewListDoctors.Columns[11].HeaderText = "Снилс";
            dataGridViewListDoctors.Columns[12].HeaderText = "Паспорт";
        }
    }
}
