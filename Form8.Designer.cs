namespace Kursovaya
{
    partial class SELL
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
            this.SELL_Time = new System.Windows.Forms.DateTimePicker();
            this.SELL_date = new System.Windows.Forms.DateTimePicker();
            this.SELL_labelSELLER_NAME = new System.Windows.Forms.Label();
            this.SELL_labelSELLER = new System.Windows.Forms.Label();
            this.NEW_Save = new System.Windows.Forms.Button();
            this.SELL_label_SUMM = new System.Windows.Forms.Label();
            this.SELL_textBox_SUMM = new System.Windows.Forms.TextBox();
            this.SELL_labelPROMO2 = new System.Windows.Forms.Label();
            this.SELL_labelPROMO = new System.Windows.Forms.Label();
            this.SELL_labelNAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SELL_Time
            // 
            this.SELL_Time.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_Time.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SELL_Time.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.SELL_Time.Enabled = false;
            this.SELL_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SELL_Time.Location = new System.Drawing.Point(411, 65);
            this.SELL_Time.Name = "SELL_Time";
            this.SELL_Time.Size = new System.Drawing.Size(68, 20);
            this.SELL_Time.TabIndex = 14;
            // 
            // SELL_date
            // 
            this.SELL_date.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SELL_date.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.SELL_date.Enabled = false;
            this.SELL_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SELL_date.Location = new System.Drawing.Point(394, 38);
            this.SELL_date.Name = "SELL_date";
            this.SELL_date.Size = new System.Drawing.Size(85, 20);
            this.SELL_date.TabIndex = 13;
            // 
            // SELL_labelSELLER_NAME
            // 
            this.SELL_labelSELLER_NAME.AutoSize = true;
            this.SELL_labelSELLER_NAME.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_labelSELLER_NAME.Location = new System.Drawing.Point(107, 455);
            this.SELL_labelSELLER_NAME.Name = "SELL_labelSELLER_NAME";
            this.SELL_labelSELLER_NAME.Size = new System.Drawing.Size(214, 20);
            this.SELL_labelSELLER_NAME.TabIndex = 17;
            this.SELL_labelSELLER_NAME.Text = "Алиса Лучший Создатель Игр";
            // 
            // SELL_labelSELLER
            // 
            this.SELL_labelSELLER.AutoSize = true;
            this.SELL_labelSELLER.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_labelSELLER.Location = new System.Drawing.Point(20, 454);
            this.SELL_labelSELLER.Name = "SELL_labelSELLER";
            this.SELL_labelSELLER.Size = new System.Drawing.Size(85, 21);
            this.SELL_labelSELLER.TabIndex = 16;
            this.SELL_labelSELLER.Text = "Продавец:";
            // 
            // NEW_Save
            // 
            this.NEW_Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NEW_Save.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_Save.Location = new System.Drawing.Point(327, 447);
            this.NEW_Save.Name = "NEW_Save";
            this.NEW_Save.Size = new System.Drawing.Size(152, 37);
            this.NEW_Save.TabIndex = 20;
            this.NEW_Save.Text = "Провести";
            this.NEW_Save.UseVisualStyleBackColor = true;
            this.NEW_Save.Click += new System.EventHandler(this.NEW_Save_Click);
            // 
            // SELL_label_SUMM
            // 
            this.SELL_label_SUMM.AutoSize = true;
            this.SELL_label_SUMM.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_label_SUMM.Location = new System.Drawing.Point(301, 363);
            this.SELL_label_SUMM.Name = "SELL_label_SUMM";
            this.SELL_label_SUMM.Size = new System.Drawing.Size(54, 20);
            this.SELL_label_SUMM.TabIndex = 21;
            this.SELL_label_SUMM.Text = "ИТОГ:";
            // 
            // SELL_textBox_SUMM
            // 
            this.SELL_textBox_SUMM.Location = new System.Drawing.Point(360, 363);
            this.SELL_textBox_SUMM.Name = "SELL_textBox_SUMM";
            this.SELL_textBox_SUMM.Size = new System.Drawing.Size(119, 20);
            this.SELL_textBox_SUMM.TabIndex = 22;
            // 
            // SELL_labelPROMO2
            // 
            this.SELL_labelPROMO2.AutoSize = true;
            this.SELL_labelPROMO2.Font = new System.Drawing.Font("Micra", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SELL_labelPROMO2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SELL_labelPROMO2.Location = new System.Drawing.Point(310, 426);
            this.SELL_labelPROMO2.Name = "SELL_labelPROMO2";
            this.SELL_labelPROMO2.Size = new System.Drawing.Size(52, 12);
            this.SELL_labelPROMO2.TabIndex = 24;
            this.SELL_labelPROMO2.Text = "Light";
            // 
            // SELL_labelPROMO
            // 
            this.SELL_labelPROMO.AutoSize = true;
            this.SELL_labelPROMO.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL_labelPROMO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SELL_labelPROMO.Location = new System.Drawing.Point(300, 389);
            this.SELL_labelPROMO.Name = "SELL_labelPROMO";
            this.SELL_labelPROMO.Size = new System.Drawing.Size(179, 41);
            this.SELL_labelPROMO.TabIndex = 23;
            this.SELL_labelPROMO.Text = "MagBase";
            // 
            // SELL_labelNAME
            // 
            this.SELL_labelNAME.AutoSize = true;
            this.SELL_labelNAME.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SELL_labelNAME.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SELL_labelNAME.Location = new System.Drawing.Point(16, 24);
            this.SELL_labelNAME.Name = "SELL_labelNAME";
            this.SELL_labelNAME.Size = new System.Drawing.Size(235, 46);
            this.SELL_labelNAME.TabIndex = 26;
            this.SELL_labelNAME.Text = "магазин 24";
            // 
            // SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 515);
            this.Controls.Add(this.SELL_labelNAME);
            this.Controls.Add(this.SELL_labelPROMO2);
            this.Controls.Add(this.SELL_labelPROMO);
            this.Controls.Add(this.SELL_textBox_SUMM);
            this.Controls.Add(this.SELL_label_SUMM);
            this.Controls.Add(this.NEW_Save);
            this.Controls.Add(this.SELL_labelSELLER_NAME);
            this.Controls.Add(this.SELL_labelSELLER);
            this.Controls.Add(this.SELL_Time);
            this.Controls.Add(this.SELL_date);
            this.Name = "SELL";
            this.Text = "Продажа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SELL_Time;
        private System.Windows.Forms.DateTimePicker SELL_date;
        private System.Windows.Forms.Label SELL_labelSELLER_NAME;
        private System.Windows.Forms.Label SELL_labelSELLER;
        private System.Windows.Forms.Button NEW_Save;
        private System.Windows.Forms.Label SELL_label_SUMM;
        private System.Windows.Forms.TextBox SELL_textBox_SUMM;
        private System.Windows.Forms.Label SELL_labelPROMO2;
        private System.Windows.Forms.Label SELL_labelPROMO;
        private System.Windows.Forms.Label SELL_labelNAME;
    }
}