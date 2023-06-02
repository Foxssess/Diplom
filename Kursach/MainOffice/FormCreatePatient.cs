using Kursach.DbContextDate;
using Kursach.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.MainOffice
{
    public partial class FormCreatePatient : Form
    {
        private DbContextData dbContext;

        string connectionString;
        public FormCreatePatient(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }   

        private void buttonCreatePatient_Click(object sender, EventArgs e)
        {
            

            Patient patient = new Patient { FirstName = textBoxFirstName.Text, SecondName = textBoxSecondName.Text, FatherName = textBoxFatherName.Text, Address = textBoxAddress.Text, BirthDay = DateOnly.FromDateTime(dateTimePickerBirthDay.Value),Gender = comboBoxGender.Text, Phone = textBoxPhone.Text, Passport = textBoxPassport.Text, Polis = textBoxPolis.Text, Snils = textBoxSnils.Text };
            

            dbContext.Patients.Add(patient);

            dbContext.SaveChanges(); 

        

            
        }

        private void FormCreatePatient_Load(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            dataGridViewPatients.DataSource = dbContext.Patients.ToArray();
            dataGridViewPatients.Columns[0].Visible = false;
            dataGridViewPatients.Columns[2].HeaderText = "Имя";
            dataGridViewPatients.Columns[1].HeaderText = "Фамилия";
            dataGridViewPatients.Columns[3].HeaderText = "Отчество";
            dataGridViewPatients.Columns[4].HeaderText = "Пол";
            dataGridViewPatients.Columns[5].HeaderText = "Адрес";
            dataGridViewPatients.Columns[6].HeaderText = "День рождения";
            dataGridViewPatients.Columns[7].HeaderText = "Телефон";
            dataGridViewPatients.Columns[8].HeaderText = "Снилс";
            dataGridViewPatients.Columns[9].HeaderText = "Полис";
            dataGridViewPatients.Columns[10].HeaderText = "Свидетельство о рождении";
            
        }

        private void buttonChangePatient_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.DataSource = dbContext.Patients.ToArray();

        }

        private void buttonSearchPatient_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Patients.Where(d => d.SecondName.Contains(textBoxSecondNameSearch.Text) || d.Address.Contains(textBoxSecondNameSearch.Text) || d.Phone.Contains(textBoxSecondNameSearch.Text)
            || d.FirstName.Contains(textBoxSecondNameSearch.Text) || d.FatherName.Contains(textBoxSecondNameSearch.Text));
            dataGridViewPatients.DataSource = searchResult.ToList();
            dataGridViewPatients.Columns.RemoveAt(0);
        }
    }
} 
                            