namespace Kursach.MainOffice
{
    partial class FormCreatePatient
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
            this.buttonCreatePatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxSnils = new System.Windows.Forms.TextBox();
            this.textBoxPolis = new System.Windows.Forms.TextBox();
            this.textBoxSecondNameSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSearchPatient = new System.Windows.Forms.Button();
            this.buttonChangePatient = new System.Windows.Forms.Button();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreatePatient
            // 
            this.buttonCreatePatient.Location = new System.Drawing.Point(686, 359);
            this.buttonCreatePatient.Name = "buttonCreatePatient";
            this.buttonCreatePatient.Size = new System.Drawing.Size(150, 30);
            this.buttonCreatePatient.TabIndex = 0;
            this.buttonCreatePatient.Text = "Добавить ребёнка";
            this.buttonCreatePatient.UseVisualStyleBackColor = true;
            this.buttonCreatePatient.Click += new System.EventHandler(this.buttonCreatePatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(64, 42);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowTemplate.Height = 25;
            this.dataGridViewPatients.Size = new System.Drawing.Size(524, 364);
            this.dataGridViewPatients.TabIndex = 1;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(649, 79);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(196, 23);
            this.textBoxSecondName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(612, 125);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(122, 23);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Location = new System.Drawing.Point(759, 125);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(121, 23);
            this.textBoxFatherName.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(759, 171);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGender.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(612, 214);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(265, 23);
            this.textBoxAddress.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(612, 255);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(122, 23);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(759, 255);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(121, 23);
            this.textBoxPassport.TabIndex = 9;
            // 
            // textBoxSnils
            // 
            this.textBoxSnils.Location = new System.Drawing.Point(612, 300);
            this.textBoxSnils.Name = "textBoxSnils";
            this.textBoxSnils.Size = new System.Drawing.Size(122, 23);
            this.textBoxSnils.TabIndex = 10;
            // 
            // textBoxPolis
            // 
            this.textBoxPolis.Location = new System.Drawing.Point(759, 300);
            this.textBoxPolis.Name = "textBoxPolis";
            this.textBoxPolis.Size = new System.Drawing.Size(118, 23);
            this.textBoxPolis.TabIndex = 11;
            // 
            // textBoxSecondNameSearch
            // 
            this.textBoxSecondNameSearch.Location = new System.Drawing.Point(196, 436);
            this.textBoxSecondNameSearch.Name = "textBoxSecondNameSearch";
            this.textBoxSecondNameSearch.Size = new System.Drawing.Size(265, 23);
            this.textBoxSecondNameSearch.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(720, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 15);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Телефон родителей";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Св-во о рождении";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Снилс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Полис";
            // 
            // buttonSearchPatient
            // 
            this.buttonSearchPatient.Location = new System.Drawing.Point(64, 430);
            this.buttonSearchPatient.Name = "buttonSearchPatient";
            this.buttonSearchPatient.Size = new System.Drawing.Size(100, 32);
            this.buttonSearchPatient.TabIndex = 23;
            this.buttonSearchPatient.Text = "Поиск";
            this.buttonSearchPatient.UseVisualStyleBackColor = true;
            this.buttonSearchPatient.Click += new System.EventHandler(this.buttonSearchPatient_Click);
            // 
            // buttonChangePatient
            // 
            this.buttonChangePatient.Location = new System.Drawing.Point(686, 405);
            this.buttonChangePatient.Name = "buttonChangePatient";
            this.buttonChangePatient.Size = new System.Drawing.Size(150, 30);
            this.buttonChangePatient.TabIndex = 24;
            this.buttonChangePatient.Text = "Изменить данные";
            this.buttonChangePatient.UseVisualStyleBackColor = true;
            this.buttonChangePatient.Click += new System.EventHandler(this.buttonChangePatient_Click);
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(612, 171);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(122, 23);
            this.dateTimePickerBirthDay.TabIndex = 25;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(491, 427);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(97, 32);
            this.buttonRefresh.TabIndex = 26;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormCreatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 477);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dateTimePickerBirthDay);
            this.Controls.Add(this.buttonChangePatient);
            this.Controls.Add(this.buttonSearchPatient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.textBoxSecondNameSearch);
            this.Controls.Add(this.textBoxPolis);
            this.Controls.Add(this.textBoxSnils);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.buttonCreatePatient);
            this.Name = "FormCreatePatient";
            this.Text = "Добавление ребёнка";
            this.Load += new System.EventHandler(this.FormCreatePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCreatePatient;
        private DataGridView dataGridViewPatients;
        private TextBox textBoxSecondName;
        private TextBox textBoxFirstName;
        private TextBox textBoxFatherName;
        private ComboBox comboBoxGender;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxPassport;
        private TextBox textBoxSnils;
        private TextBox textBoxPolis;
        private TextBox textBoxSecondNameSearch;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button buttonSearchPatient;
        private Button buttonChangePatient;
        private DateTimePicker dateTimePickerBirthDay;
        private Button buttonRefresh;
    }
}