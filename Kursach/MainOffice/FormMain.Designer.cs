namespace Kursach.MainOffice
{
    partial class FormMain
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
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.buttonCreatePriem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(54, 35);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowTemplate.Height = 25;
            this.dataGridViewService.Size = new System.Drawing.Size(536, 156);
            this.dataGridViewService.TabIndex = 0;
            // 
            // buttonCreatePriem
            // 
            this.buttonCreatePriem.Location = new System.Drawing.Point(475, 197);
            this.buttonCreatePriem.Name = "buttonCreatePriem";
            this.buttonCreatePriem.Size = new System.Drawing.Size(124, 30);
            this.buttonCreatePriem.TabIndex = 1;
            this.buttonCreatePriem.Text = "Запись на занятие";
            this.buttonCreatePriem.UseVisualStyleBackColor = true;
            this.buttonCreatePriem.Click += new System.EventHandler(this.buttonCreatePriem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 229);
            this.Controls.Add(this.buttonCreatePriem);
            this.Controls.Add(this.dataGridViewService);
            this.Name = "FormMain";
            this.Text = "Просмотр занятий";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewService;
        private Button buttonCreatePriem;
    }
}