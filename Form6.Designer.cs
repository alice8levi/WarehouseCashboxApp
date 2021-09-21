namespace Kursovaya
{
    partial class GET
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
            this.GET_label = new System.Windows.Forms.Label();
            this.GET_Time = new System.Windows.Forms.DateTimePicker();
            this.GET_date = new System.Windows.Forms.DateTimePicker();
            this.GET_Save = new System.Windows.Forms.Button();
            this.GET_NEW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GET_label
            // 
            this.GET_label.AutoSize = true;
            this.GET_label.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GET_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GET_label.Location = new System.Drawing.Point(36, 22);
            this.GET_label.Name = "GET_label";
            this.GET_label.Size = new System.Drawing.Size(326, 54);
            this.GET_label.TabIndex = 17;
            this.GET_label.Text = "ПОСТУПЛЕНИЕ";
            // 
            // GET_Time
            // 
            this.GET_Time.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GET_Time.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GET_Time.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.GET_Time.Enabled = false;
            this.GET_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.GET_Time.Location = new System.Drawing.Point(142, 79);
            this.GET_Time.Name = "GET_Time";
            this.GET_Time.Size = new System.Drawing.Size(68, 20);
            this.GET_Time.TabIndex = 16;
            // 
            // GET_date
            // 
            this.GET_date.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GET_date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GET_date.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.GET_date.Enabled = false;
            this.GET_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.GET_date.Location = new System.Drawing.Point(45, 79);
            this.GET_date.Name = "GET_date";
            this.GET_date.Size = new System.Drawing.Size(85, 20);
            this.GET_date.TabIndex = 15;
            // 
            // GET_Save
            // 
            this.GET_Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GET_Save.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GET_Save.Location = new System.Drawing.Point(45, 376);
            this.GET_Save.Name = "GET_Save";
            this.GET_Save.Size = new System.Drawing.Size(152, 37);
            this.GET_Save.TabIndex = 14;
            this.GET_Save.Text = "Сохранить";
            this.GET_Save.UseVisualStyleBackColor = true;
            this.GET_Save.Click += new System.EventHandler(this.GET_Save_Click);
            // 
            // GET_NEW
            // 
            this.GET_NEW.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GET_NEW.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GET_NEW.Location = new System.Drawing.Point(316, 376);
            this.GET_NEW.Name = "GET_NEW";
            this.GET_NEW.Size = new System.Drawing.Size(152, 37);
            this.GET_NEW.TabIndex = 18;
            this.GET_NEW.Text = "Новый товар";
            this.GET_NEW.UseVisualStyleBackColor = true;
            this.GET_NEW.Click += new System.EventHandler(this.GET_NEW_Click);
            // 
            // GET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.GET_NEW);
            this.Controls.Add(this.GET_label);
            this.Controls.Add(this.GET_Time);
            this.Controls.Add(this.GET_date);
            this.Controls.Add(this.GET_Save);
            this.Name = "GET";
            this.Text = "Поступление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GET_label;
        private System.Windows.Forms.DateTimePicker GET_Time;
        private System.Windows.Forms.DateTimePicker GET_date;
        private System.Windows.Forms.Button GET_Save;
        private System.Windows.Forms.Button GET_NEW;
    }
}