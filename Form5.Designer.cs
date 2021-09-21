namespace Kursovaya
{
    partial class BASE
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
            this.BASE_Time = new System.Windows.Forms.DateTimePicker();
            this.BASE_date = new System.Windows.Forms.DateTimePicker();
            this.BASE_RELOAD = new System.Windows.Forms.Button();
            this.BASE_labelSKLAD = new System.Windows.Forms.Label();
            this.MAIN_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MAIN_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BASE_Time
            // 
            this.BASE_Time.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASE_Time.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BASE_Time.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.BASE_Time.Enabled = false;
            this.BASE_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BASE_Time.Location = new System.Drawing.Point(682, 64);
            this.BASE_Time.Name = "BASE_Time";
            this.BASE_Time.Size = new System.Drawing.Size(68, 20);
            this.BASE_Time.TabIndex = 12;
            // 
            // BASE_date
            // 
            this.BASE_date.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASE_date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BASE_date.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.BASE_date.Enabled = false;
            this.BASE_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BASE_date.Location = new System.Drawing.Point(665, 37);
            this.BASE_date.Name = "BASE_date";
            this.BASE_date.Size = new System.Drawing.Size(85, 20);
            this.BASE_date.TabIndex = 11;
            // 
            // BASE_RELOAD
            // 
            this.BASE_RELOAD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BASE_RELOAD.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASE_RELOAD.Location = new System.Drawing.Point(324, 368);
            this.BASE_RELOAD.Name = "BASE_RELOAD";
            this.BASE_RELOAD.Size = new System.Drawing.Size(152, 37);
            this.BASE_RELOAD.TabIndex = 10;
            this.BASE_RELOAD.Text = "Обновить";
            this.BASE_RELOAD.UseVisualStyleBackColor = true;

            // 
            // BASE_labelSKLAD
            // 
            this.BASE_labelSKLAD.AutoSize = true;
            this.BASE_labelSKLAD.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BASE_labelSKLAD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BASE_labelSKLAD.Location = new System.Drawing.Point(22, 16);
            this.BASE_labelSKLAD.Name = "BASE_labelSKLAD";
            this.BASE_labelSKLAD.Size = new System.Drawing.Size(196, 65);
            this.BASE_labelSKLAD.TabIndex = 13;
            this.BASE_labelSKLAD.Text = "СКЛАД";
            // 
            // MAIN_dataGridView
            // 
            this.MAIN_dataGridView.AllowUserToAddRows = false;
            this.MAIN_dataGridView.AllowUserToDeleteRows = false;
            this.MAIN_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MAIN_dataGridView.Location = new System.Drawing.Point(39, 93);
            this.MAIN_dataGridView.Name = "MAIN_dataGridView";
            this.MAIN_dataGridView.ReadOnly = true;
            this.MAIN_dataGridView.Size = new System.Drawing.Size(710, 255);
            this.MAIN_dataGridView.TabIndex = 14;
            // 
            // BASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MAIN_dataGridView);
            this.Controls.Add(this.BASE_labelSKLAD);
            this.Controls.Add(this.BASE_Time);
            this.Controls.Add(this.BASE_date);
            this.Controls.Add(this.BASE_RELOAD);
            this.Name = "BASE";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.MAIN_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BASE_Time;
        private System.Windows.Forms.DateTimePicker BASE_date;
        private System.Windows.Forms.Button BASE_RELOAD;
        private System.Windows.Forms.Label BASE_labelSKLAD;
        private System.Windows.Forms.DataGridView MAIN_dataGridView;
    }
}