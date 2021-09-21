namespace Kursovaya
{
    partial class NEW
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
            this.NEW_RETURN = new System.Windows.Forms.Button();
            this.NEW_label = new System.Windows.Forms.Label();
            this.NEW_Time = new System.Windows.Forms.DateTimePicker();
            this.NEW_date = new System.Windows.Forms.DateTimePicker();
            this.NEW_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NEW_RETURN
            // 
            this.NEW_RETURN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NEW_RETURN.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_RETURN.Location = new System.Drawing.Point(321, 379);
            this.NEW_RETURN.Name = "NEW_RETURN";
            this.NEW_RETURN.Size = new System.Drawing.Size(152, 37);
            this.NEW_RETURN.TabIndex = 23;
            this.NEW_RETURN.Text = "Вернуться";
            this.NEW_RETURN.UseVisualStyleBackColor = true;
            this.NEW_RETURN.Click += new System.EventHandler(this.NEW_RETURN_Click);
            // 
            // NEW_label
            // 
            this.NEW_label.AutoSize = true;
            this.NEW_label.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.NEW_label.Location = new System.Drawing.Point(25, 25);
            this.NEW_label.Name = "NEW_label";
            this.NEW_label.Size = new System.Drawing.Size(323, 54);
            this.NEW_label.TabIndex = 22;
            this.NEW_label.Text = "НОВЫЙ ТОВАР";
            // 
            // NEW_Time
            // 
            this.NEW_Time.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_Time.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NEW_Time.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.NEW_Time.Enabled = false;
            this.NEW_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NEW_Time.Location = new System.Drawing.Point(134, 82);
            this.NEW_Time.Name = "NEW_Time";
            this.NEW_Time.Size = new System.Drawing.Size(68, 20);
            this.NEW_Time.TabIndex = 21;
            // 
            // NEW_date
            // 
            this.NEW_date.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NEW_date.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.NEW_date.Enabled = false;
            this.NEW_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NEW_date.Location = new System.Drawing.Point(37, 82);
            this.NEW_date.Name = "NEW_date";
            this.NEW_date.Size = new System.Drawing.Size(85, 20);
            this.NEW_date.TabIndex = 20;
            // 
            // NEW_Save
            // 
            this.NEW_Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NEW_Save.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW_Save.Location = new System.Drawing.Point(37, 379);
            this.NEW_Save.Name = "NEW_Save";
            this.NEW_Save.Size = new System.Drawing.Size(152, 37);
            this.NEW_Save.TabIndex = 19;
            this.NEW_Save.Text = "Сохранить";
            this.NEW_Save.UseVisualStyleBackColor = true;
            this.NEW_Save.Click += new System.EventHandler(this.NEW_Save_Click);
            // 
            // NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.NEW_RETURN);
            this.Controls.Add(this.NEW_label);
            this.Controls.Add(this.NEW_Time);
            this.Controls.Add(this.NEW_date);
            this.Controls.Add(this.NEW_Save);
            this.Name = "NEW";
            this.Text = "Новый товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NEW_RETURN;
        private System.Windows.Forms.Label NEW_label;
        private System.Windows.Forms.DateTimePicker NEW_Time;
        private System.Windows.Forms.DateTimePicker NEW_date;
        private System.Windows.Forms.Button NEW_Save;
    }
}