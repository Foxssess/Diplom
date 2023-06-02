namespace Kursach.MainOffice
{
    partial class FormListDoctors
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
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.buttonSearchDoctors = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSnils = new System.Windows.Forms.TextBox();
            this.textBoxDiplom = new System.Windows.Forms.TextBox();
            this.textBoxWarTicket = new System.Windows.Forms.TextBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.buttonAddDoctors = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(39, 40);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowTemplate.Height = 25;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(457, 359);
            this.dataGridViewDoctors.TabIndex = 0;
            // 
            // buttonSearchDoctors
            // 
            this.buttonSearchDoctors.Location = new System.Drawing.Point(359, 405);
            this.buttonSearchDoctors.Name = "buttonSearchDoctors";
            this.buttonSearchDoctors.Size = new System.Drawing.Size(137, 32);
            this.buttonSearchDoctors.TabIndex = 1;
            this.buttonSearchDoctors.Text = "Поиск";
            this.buttonSearchDoctors.UseVisualStyleBackColor = true;
            this.buttonSearchDoctors.Click += new System.EventHandler(this.buttonSearchDoctors_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(162, 411);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(191, 23);
            this.textBoxSearch.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(534, 53);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(255, 23);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(534, 99);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(121, 23);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Location = new System.Drawing.Point(689, 99);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFatherName.TabIndex = 5;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Items.AddRange(new object[] {
            "Ортодонт",
            "Стоматолог - хирург",
            "Стоматолог- терапевт"});
            this.comboBoxPost.Location = new System.Drawing.Point(689, 153);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(100, 23);
            this.comboBoxPost.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(534, 196);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(255, 23);
            this.textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(534, 240);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(135, 23);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxSnils
            // 
            this.textBoxSnils.Location = new System.Drawing.Point(534, 283);
            this.textBoxSnils.Name = "textBoxSnils";
            this.textBoxSnils.Size = new System.Drawing.Size(121, 23);
            this.textBoxSnils.TabIndex = 10;
            // 
            // textBoxDiplom
            // 
            this.textBoxDiplom.Location = new System.Drawing.Point(669, 283);
            this.textBoxDiplom.Name = "textBoxDiplom";
            this.textBoxDiplom.Size = new System.Drawing.Size(120, 23);
            this.textBoxDiplom.TabIndex = 11;
            // 
            // textBoxWarTicket
            // 
            this.textBoxWarTicket.Location = new System.Drawing.Point(534, 331);
            this.textBoxWarTicket.Name = "textBoxWarTicket";
            this.textBoxWarTicket.Size = new System.Drawing.Size(121, 23);
            this.textBoxWarTicket.TabIndex = 12;
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(669, 331);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(120, 23);
            this.textBoxExperience.TabIndex = 13;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(689, 240);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassport.TabIndex = 14;
            // 
            // buttonAddDoctors
            // 
            this.buttonAddDoctors.Location = new System.Drawing.Point(534, 367);
            this.buttonAddDoctors.Name = "buttonAddDoctors";
            this.buttonAddDoctors.Size = new System.Drawing.Size(121, 32);
            this.buttonAddDoctors.TabIndex = 15;
            this.buttonAddDoctors.Text = "Добавить";
            this.buttonAddDoctors.UseVisualStyleBackColor = true;
            this.buttonAddDoctors.Click += new System.EventHandler(this.buttonAddDoctors_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(674, 367);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(115, 32);
            this.buttonChange.TabIndex = 16;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(710, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(710, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Паспорт";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Снилс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(710, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Диплом";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Военный билет";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(700, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Стаж работы";
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(534, 153);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(121, 23);
            this.dateTimePickerBirthDay.TabIndex = 29;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(39, 405);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(117, 32);
            this.buttonRefresh.TabIndex = 30;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormListDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 452);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dateTimePickerBirthDay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAddDoctors);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.textBoxWarTicket);
            this.Controls.Add(this.textBoxDiplom);
            this.Controls.Add(this.textBoxSnils);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.comboBoxPost);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearchDoctors);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Name = "FormListDoctors";
            this.Text = "Добавление воспитателя";
            this.Load += new System.EventHandler(this.FormListDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewDoctors;
        private Button buttonSearchDoctors;
        private TextBox textBoxSearch;
        private TextBox textBoxSurname;
        private TextBox textBoxFirstName;
        private TextBox textBoxFatherName;
        private ComboBox comboBoxPost;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxSnils;
        private TextBox textBoxDiplom;
        private TextBox textBoxWarTicket;
        private TextBox textBoxExperience;
        private TextBox textBoxPassport;
        private Button buttonAddDoctors;
        private Button buttonChange;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dateTimePickerBirthDay;
        private Button buttonRefresh;
    }
}