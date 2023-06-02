using Kursach.DbContextDate;
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
    public partial class FormMain : Form
    {
        string connectionString;
        DbContextData dbContext;
        public FormMain(string connection)
        {
            
            connectionString = connection;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            dbContext.Database.EnsureCreated();
            dataGridViewService.DataSource = dbContext.Services.ToArray();
            dataGridViewService.Columns[1].HeaderText = "Название занятия";
            dataGridViewService.Columns[2].HeaderText = "Стоимость";
            dataGridViewService.Columns[0].Visible = false;
            dataGridViewService.Columns[3].Visible = false;

        }

        private void buttonCreatePriem_Click(object sender, EventArgs e)
        {
            FormCreatePriem formCreatePriem = new FormCreatePriem(connectionString);
            formCreatePriem.ShowDialog();
        }

      
    }
}
