namespace Kursach.MainOffice
{
    partial class FormCreatePriem
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
            this.dateTimePickerPriem = new System.Windows.Forms.DateTimePicker();
            this.textBoxPriemTime = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.dataGridViewPriem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreatePriem = new System.Windows.Forms.Button();
            this.buttonMoveCreatePatient = new System.Windows.Forms.Button();
            this.buttonSearchPriem = new System.Windows.Forms.Button();
            this.textBoxSearchPriem = new System.Windows.Forms.TextBox();
            this.buttonMoveListDoctors = new System.Windows.Forms.Button();
            this.buttonMoveTimeWork = new System.Windows.Forms.Button();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.dataGridViewListPatients = new System.Windows.Forms.DataGridView();
            this.dataGridViewListDoctors = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerPriem
            // 
            this.dateTimePickerPriem.Location = new System.Drawing.Point(282, 538);
            this.dateTimePickerPriem.Name = "dateTimePickerPriem";
            this.dateTimePickerPriem.Size = new System.Drawing.Size(170, 23);
            this.dateTimePickerPriem.TabIndex = 0;
            // 
            // textBoxPriemTime
            // 
            this.textBoxPriemTime.Location = new System.Drawing.Point(471, 538);
            this.textBoxPriemTime.Name = "textBoxPriemTime";
            this.textBoxPriemTime.Size = new System.Drawing.Size(156, 23);
            this.textBoxPriemTime.TabIndex = 1;
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "Познавательное развитие",
            "Речевое развитие",
            "Художественно-эстетическое развитие"});
            this.comboBoxService.Location = new System.Drawing.Point(179, 480);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(218, 23);
            this.comboBoxService.TabIndex = 2;
            // 
            // dataGridViewPriem
            // 
            this.dataGridViewPriem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriem.Location = new System.Drawing.Point(22, 44);
            this.dataGridViewPriem.Name = "dataGridViewPriem";
            this.dataGridViewPriem.RowTemplate.Height = 25;
            this.dataGridViewPriem.Size = new System.Drawing.Size(871, 167);
            this.dataGridViewPriem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата и время приёма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Услуга";
            // 
            // buttonCreatePriem
            // 
            this.buttonCreatePriem.Location = new System.Drawing.Point(384, 576);
            this.buttonCreatePriem.Name = "buttonCreatePriem";
            this.buttonCreatePriem.Size = new System.Drawing.Size(172, 32);
            this.buttonCreatePriem.TabIndex = 9;
            this.buttonCreatePriem.Text = "Cоздать занятие";
            this.buttonCreatePriem.UseVisualStyleBackColor = true;
            this.buttonCreatePriem.Click += new System.EventHandler(this.buttonCreatePriem_Click);
            // 
            // buttonMoveCreatePatient
            // 
            this.buttonMoveCreatePatient.Location = new System.Drawing.Point(22, 220);
            this.buttonMoveCreatePatient.Name = "buttonMoveCreatePatient";
            this.buttonMoveCreatePatient.Size = new System.Drawing.Size(172, 33);
            this.buttonMoveCreatePatient.TabIndex = 10;
            this.buttonMoveCreatePatient.Text = "Добавить ребёнка";
            this.buttonMoveCreatePatient.UseVisualStyleBackColor = true;
            this.buttonMoveCreatePatient.Click += new System.EventHandler(this.buttonMoveCreatePatient_Click);
            // 
            // buttonSearchPriem
            // 
            this.buttonSearchPriem.Location = new System.Drawing.Point(319, 12);
            this.buttonSearchPriem.Name = "buttonSearchPriem";
            this.buttonSearchPriem.Size = new System.Drawing.Size(142, 23);
            this.buttonSearchPriem.TabIndex = 11;
            this.buttonSearchPriem.Text = "Поиск";
            this.buttonSearchPriem.UseVisualStyleBackColor = true;
            this.buttonSearchPriem.Click += new System.EventHandler(this.buttonSearchPriem_Click);
            // 
            // textBoxSearchPriem
            // 
            this.textBoxSearchPriem.Location = new System.Drawing.Point(139, 12);
            this.textBoxSearchPriem.Name = "textBoxSearchPriem";
            this.textBoxSearchPriem.Size = new System.Drawing.Size(174, 23);
            this.textBoxSearchPriem.TabIndex = 12;
            // 
            // buttonMoveListDoctors
            // 
            this.buttonMoveListDoctors.Location = new System.Drawing.Point(485, 218);
            this.buttonMoveListDoctors.Name = "buttonMoveListDoctors";
            this.buttonMoveListDoctors.Size = new System.Drawing.Size(156, 33);
            this.buttonMoveListDoctors.TabIndex = 13;
            this.buttonMoveListDoctors.Text = "Список воспитателей";
            this.buttonMoveListDoctors.UseVisualStyleBackColor = true;
            this.buttonMoveListDoctors.Click += new System.EventHandler(this.buttonMoveListDoctors_Click);
            // 
            // buttonMoveTimeWork
            // 
            this.buttonMoveTimeWork.Location = new System.Drawing.Point(282, 219);
            this.buttonMoveTimeWork.Name = "buttonMoveTimeWork";
            this.buttonMoveTimeWork.Size = new System.Drawing.Size(170, 33);
            this.buttonMoveTimeWork.TabIndex = 14;
            this.buttonMoveTimeWork.Text = "Время работы";
            this.buttonMoveTimeWork.UseVisualStyleBackColor = true;
            this.buttonMoveTimeWork.Click += new System.EventHandler(this.buttonMoveTimeWork_Click);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(403, 480);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(170, 23);
            this.textBoxCost.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цена";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(579, 480);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(191, 23);
            this.comboBoxRoom.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Кабинет";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(121, 23);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(576, 12);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(194, 26);
            this.buttonShowAll.TabIndex = 23;
            this.buttonShowAll.Text = "Отобразить все записи";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Visible = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(669, 220);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(156, 32);
            this.buttonChange.TabIndex = 24;
            this.buttonChange.Text = "Изменить данные";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // dataGridViewListPatients
            // 
            this.dataGridViewListPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPatients.Location = new System.Drawing.Point(22, 276);
            this.dataGridViewListPatients.Name = "dataGridViewListPatients";
            this.dataGridViewListPatients.RowTemplate.Height = 25;
            this.dataGridViewListPatients.Size = new System.Drawing.Size(430, 166);
            this.dataGridViewListPatients.TabIndex = 25;
            this.dataGridViewListPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPatients_CellClick);
            this.dataGridViewListPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPatients_CellContentClick);
            // 
            // dataGridViewListDoctors
            // 
            this.dataGridViewListDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListDoctors.Location = new System.Drawing.Point(477, 276);
            this.dataGridViewListDoctors.Name = "dataGridViewListDoctors";
            this.dataGridViewListDoctors.RowTemplate.Height = 25;
            this.dataGridViewListDoctors.Size = new System.Drawing.Size(416, 166);
            this.dataGridViewListDoctors.TabIndex = 26;
            this.dataGridViewListDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListDoctors_CellClick);
            this.dataGridViewListDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListDoctors_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дети";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список воспитателей";
            // 
            // FormCreatePriem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 693);
            this.Controls.Add(this.dataGridViewListDoctors);
            this.Controls.Add(this.dataGridViewListPatients);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMoveTimeWork);
            this.Controls.Add(this.buttonMoveListDoctors);
            this.Controls.Add(this.textBoxSearchPriem);
            this.Controls.Add(this.buttonSearchPriem);
            this.Controls.Add(this.buttonMoveCreatePatient);
            this.Controls.Add(this.buttonCreatePriem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPriem);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.textBoxPriemTime);
            this.Controls.Add(this.dateTimePickerPriem);
            this.Name = "FormCreatePriem";
            this.Text = "Добавление занятия";
            this.Load += new System.EventHandler(this.FormCreatePriem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePickerPriem;
        private TextBox textBoxPriemTime;
        private ComboBox comboBoxService;
        private DataGridView dataGridViewPriem;
        private Label label1;
        private Label label3;
        private Button buttonCreatePriem;
        private Button buttonMoveCreatePatient;
        private Button buttonSearchPriem;
        private TextBox textBoxSearchPriem;
        private Button buttonMoveListDoctors;
        private Button buttonMoveTimeWork;
        private TextBox textBoxCost;
        private Label label5;
        private ComboBox comboBoxRoom;
        private Label label6;
        private Button buttonRefresh;
        private Button buttonShowAll;
        private Button buttonChange;
        private DataGridView dataGridViewListPatients;
        private DataGridView dataGridViewListDoctors;
        private Label label4;
        private Label label2;
    }
}