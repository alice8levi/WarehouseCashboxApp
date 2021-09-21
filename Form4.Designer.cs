namespace Kursovaya
{
    partial class MainMenu
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
            this.MainMenu_SELL = new System.Windows.Forms.Button();
            this.MainMenu_GET = new System.Windows.Forms.Button();
            this.MainMenu_Base = new System.Windows.Forms.Button();
            this.MainMenu_EXIT = new System.Windows.Forms.Button();
            this.MainMenu_date = new System.Windows.Forms.DateTimePicker();
            this.MainMenu_Time = new System.Windows.Forms.DateTimePicker();
            this.MainMenu_labelSELLER = new System.Windows.Forms.Label();
            this.MainMenu_labelSELLER_NAME = new System.Windows.Forms.Label();
            this.MainMenu_linkLabel_CHANGEuser = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenu_SELL
            // 
            this.MainMenu_SELL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenu_SELL.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_SELL.Location = new System.Drawing.Point(34, 193);
            this.MainMenu_SELL.Name = "MainMenu_SELL";
            this.MainMenu_SELL.Size = new System.Drawing.Size(152, 37);
            this.MainMenu_SELL.TabIndex = 6;
            this.MainMenu_SELL.Text = "Продажа";
            this.MainMenu_SELL.UseVisualStyleBackColor = true;
            this.MainMenu_SELL.Click += new System.EventHandler(this.MainMenu_SELL_Click);
            // 
            // MainMenu_GET
            // 
            this.MainMenu_GET.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenu_GET.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_GET.Location = new System.Drawing.Point(192, 129);
            this.MainMenu_GET.Name = "MainMenu_GET";
            this.MainMenu_GET.Size = new System.Drawing.Size(152, 37);
            this.MainMenu_GET.TabIndex = 5;
            this.MainMenu_GET.Text = "Поступление";
            this.MainMenu_GET.UseVisualStyleBackColor = true;
            this.MainMenu_GET.Click += new System.EventHandler(this.MainMenu_GET_Click);
            // 
            // MainMenu_Base
            // 
            this.MainMenu_Base.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenu_Base.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Base.Location = new System.Drawing.Point(34, 129);
            this.MainMenu_Base.Name = "MainMenu_Base";
            this.MainMenu_Base.Size = new System.Drawing.Size(152, 37);
            this.MainMenu_Base.TabIndex = 4;
            this.MainMenu_Base.Text = "Склад";
            this.MainMenu_Base.UseVisualStyleBackColor = true;
            this.MainMenu_Base.Click += new System.EventHandler(this.MainMenu_Base_Click);
            // 
            // MainMenu_EXIT
            // 
            this.MainMenu_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MainMenu_EXIT.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_EXIT.Location = new System.Drawing.Point(192, 193);
            this.MainMenu_EXIT.Name = "MainMenu_EXIT";
            this.MainMenu_EXIT.Size = new System.Drawing.Size(152, 37);
            this.MainMenu_EXIT.TabIndex = 7;
            this.MainMenu_EXIT.Text = "Выход";
            this.MainMenu_EXIT.UseVisualStyleBackColor = true;
            this.MainMenu_EXIT.Click += new System.EventHandler(this.MainMenu_EXIT_Click);
            // 
            // MainMenu_date
            // 
            this.MainMenu_date.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainMenu_date.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenu_date.Enabled = false;
            this.MainMenu_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MainMenu_date.Location = new System.Drawing.Point(259, 45);
            this.MainMenu_date.Name = "MainMenu_date";
            this.MainMenu_date.Size = new System.Drawing.Size(85, 20);
            this.MainMenu_date.TabIndex = 8;
            this.MainMenu_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MainMenu_Time
            // 
            this.MainMenu_Time.CalendarFont = new System.Drawing.Font("Malgun Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Time.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainMenu_Time.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenu_Time.Enabled = false;
            this.MainMenu_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.MainMenu_Time.Location = new System.Drawing.Point(276, 72);
            this.MainMenu_Time.Name = "MainMenu_Time";
            this.MainMenu_Time.Size = new System.Drawing.Size(68, 20);
            this.MainMenu_Time.TabIndex = 9;
            // 
            // MainMenu_labelSELLER
            // 
            this.MainMenu_labelSELLER.AutoSize = true;
            this.MainMenu_labelSELLER.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_labelSELLER.Location = new System.Drawing.Point(33, 286);
            this.MainMenu_labelSELLER.Name = "MainMenu_labelSELLER";
            this.MainMenu_labelSELLER.Size = new System.Drawing.Size(85, 21);
            this.MainMenu_labelSELLER.TabIndex = 10;
            this.MainMenu_labelSELLER.Text = "Продавец:";
            // 
            // MainMenu_labelSELLER_NAME
            // 
            this.MainMenu_labelSELLER_NAME.AutoSize = true;
            this.MainMenu_labelSELLER_NAME.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_labelSELLER_NAME.Location = new System.Drawing.Point(130, 287);
            this.MainMenu_labelSELLER_NAME.Name = "MainMenu_labelSELLER_NAME";
            this.MainMenu_labelSELLER_NAME.Size = new System.Drawing.Size(214, 20);
            this.MainMenu_labelSELLER_NAME.TabIndex = 11;
            this.MainMenu_labelSELLER_NAME.Text = "Алиса Лучший Создатель Игр";
            // 
            // MainMenu_linkLabel_CHANGEuser
            // 
            this.MainMenu_linkLabel_CHANGEuser.ActiveLinkColor = System.Drawing.Color.Green;
            this.MainMenu_linkLabel_CHANGEuser.AutoSize = true;
            this.MainMenu_linkLabel_CHANGEuser.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_linkLabel_CHANGEuser.LinkColor = System.Drawing.Color.Gray;
            this.MainMenu_linkLabel_CHANGEuser.Location = new System.Drawing.Point(228, 319);
            this.MainMenu_linkLabel_CHANGEuser.Name = "MainMenu_linkLabel_CHANGEuser";
            this.MainMenu_linkLabel_CHANGEuser.Size = new System.Drawing.Size(116, 13);
            this.MainMenu_linkLabel_CHANGEuser.TabIndex = 12;
            this.MainMenu_linkLabel_CHANGEuser.TabStop = true;
            this.MainMenu_linkLabel_CHANGEuser.Text = "Смена пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(30, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "MagBase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Micra", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Light";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 358);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainMenu_linkLabel_CHANGEuser);
            this.Controls.Add(this.MainMenu_labelSELLER_NAME);
            this.Controls.Add(this.MainMenu_labelSELLER);
            this.Controls.Add(this.MainMenu_Time);
            this.Controls.Add(this.MainMenu_date);
            this.Controls.Add(this.MainMenu_EXIT);
            this.Controls.Add(this.MainMenu_SELL);
            this.Controls.Add(this.MainMenu_GET);
            this.Controls.Add(this.MainMenu_Base);
            this.Name = "MainMenu";
            this.Text = "MagBase v0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu_SELL;
        private System.Windows.Forms.Button MainMenu_GET;
        private System.Windows.Forms.Button MainMenu_Base;
        private System.Windows.Forms.Button MainMenu_EXIT;
        private System.Windows.Forms.DateTimePicker MainMenu_date;
        private System.Windows.Forms.DateTimePicker MainMenu_Time;
        private System.Windows.Forms.Label MainMenu_labelSELLER;
        private System.Windows.Forms.Label MainMenu_labelSELLER_NAME;
        private System.Windows.Forms.LinkLabel MainMenu_linkLabel_CHANGEuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}