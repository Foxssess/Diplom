namespace Kursach.MainOffice
{
    partial class FormTimeWork
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
            this.dataGridViewWorkTime = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchWorkTime = new System.Windows.Forms.Button();
            this.comboBoxListDoctors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBeginShift = new System.Windows.Forms.TextBox();
            this.textBoxEndShift = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddWorkTime = new System.Windows.Forms.Button();
            this.buttonChangeWorkTime = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxTypeShift = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkTime
            // 
            this.dataGridViewWorkTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkTime.Location = new System.Drawing.Point(33, 42);
            this.dataGridViewWorkTime.Name = "dataGridViewWorkTime";
            this.dataGridViewWorkTime.RowTemplate.Height = 25;
            this.dataGridViewWorkTime.Size = new System.Drawing.Size(459, 367);
            this.dataGridViewWorkTime.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(168, 415);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(183, 23);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearchWorkTime
            // 
            this.buttonSearchWorkTime.Location = new System.Drawing.Point(87, 415);
            this.buttonSearchWorkTime.Name = "buttonSearchWorkTime";
            this.buttonSearchWorkTime.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchWorkTime.TabIndex = 2;
            this.buttonSearchWorkTime.Text = "Поиск";
            this.buttonSearchWorkTime.UseVisualStyleBackColor = true;
            this.buttonSearchWorkTime.Click += new System.EventHandler(this.buttonSearchWorkTime_Click);
            // 
            // comboBoxListDoctors
            // 
            this.comboBoxListDoctors.FormattingEnabled = true;
            this.comboBoxListDoctors.Location = new System.Drawing.Point(519, 102);
            this.comboBoxListDoctors.Name = "comboBoxListDoctors";
            this.comboBoxListDoctors.Size = new System.Drawing.Size(256, 23);
            this.comboBoxListDoctors.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список воспитателей";
            // 
            // textBoxBeginShift
            // 
            this.textBoxBeginShift.Location = new System.Drawing.Point(519, 250);
            this.textBoxBeginShift.Name = "textBoxBeginShift";
            this.textBoxBeginShift.Size = new System.Drawing.Size(113, 23);
            this.textBoxBeginShift.TabIndex = 6;
            // 
            // textBoxEndShift
            // 
            this.textBoxEndShift.Location = new System.Drawing.Point(670, 250);
            this.textBoxEndShift.Name = "textBoxEndShift";
            this.textBoxEndShift.Size = new System.Drawing.Size(105, 23);
            this.textBoxEndShift.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Начало смены";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Конец смены";
            // 
            // buttonAddWorkTime
            // 
            this.buttonAddWorkTime.Location = new System.Drawing.Point(594, 320);
            this.buttonAddWorkTime.Name = "buttonAddWorkTime";
            this.buttonAddWorkTime.Size = new System.Drawing.Size(120, 30);
            this.buttonAddWorkTime.TabIndex = 13;
            this.buttonAddWorkTime.Text = "Добавить смену";
            this.buttonAddWorkTime.UseVisualStyleBackColor = true;
            this.buttonAddWorkTime.Click += new System.EventHandler(this.buttonAddWorkTime_Click);
            // 
            // buttonChangeWorkTime
            // 
            this.buttonChangeWorkTime.Location = new System.Drawing.Point(594, 356);
            this.buttonChangeWorkTime.Name = "buttonChangeWorkTime";
            this.buttonChangeWorkTime.Size = new System.Drawing.Size(120, 31);
            this.buttonChangeWorkTime.TabIndex = 14;
            this.buttonChangeWorkTime.Text = "Изменить данные";
            this.buttonChangeWorkTime.UseVisualStyleBackColor = true;
            this.buttonChangeWorkTime.Click += new System.EventHandler(this.buttonChangeWorkTime_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(360, 416);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxTypeShift
            // 
            this.comboBoxTypeShift.FormattingEnabled = true;
            this.comboBoxTypeShift.Items.AddRange(new object[] {
            "Первая",
            "Вторая"});
            this.comboBoxTypeShift.Location = new System.Drawing.Point(519, 175);
            this.comboBoxTypeShift.Name = "comboBoxTypeShift";
            this.comboBoxTypeShift.Size = new System.Drawing.Size(256, 23);
            this.comboBoxTypeShift.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Смена";
            // 
            // FormTimeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTypeShift);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonChangeWorkTime);
            this.Controls.Add(this.buttonAddWorkTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEndShift);
            this.Controls.Add(this.textBoxBeginShift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxListDoctors);
            this.Controls.Add(this.buttonSearchWorkTime);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewWorkTime);
            this.Name = "FormTimeWork";
            this.Text = "Расписание преподавателя";
            this.Load += new System.EventHandler(this.FormTimeWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewWorkTime;
        private TextBox textBoxSearch;
        private Button buttonSearchWorkTime;
        private ComboBox comboBoxListDoctors;
        private Label label1;
        private TextBox textBoxBeginShift;
        private TextBox textBoxEndShift;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonAddWorkTime;
        private Button buttonChangeWorkTime;
        private Button buttonRefresh;
        private ComboBox comboBoxTypeShift;
        private Label label6;
    }
}