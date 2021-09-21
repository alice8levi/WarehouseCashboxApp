namespace Kursovaya
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start_EXIT = new System.Windows.Forms.Button();
            this.Start_REG = new System.Windows.Forms.Button();
            this.Start_IN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Micra", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(95, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Light";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(85, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "MagBase";
            // 
            // Start_EXIT
            // 
            this.Start_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start_EXIT.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_EXIT.Location = new System.Drawing.Point(92, 235);
            this.Start_EXIT.Name = "Start_EXIT";
            this.Start_EXIT.Size = new System.Drawing.Size(152, 37);
            this.Start_EXIT.TabIndex = 17;
            this.Start_EXIT.Text = "Выход";
            this.Start_EXIT.UseVisualStyleBackColor = true;
            this.Start_EXIT.Click += new System.EventHandler(this.Start_EXIT_Click);
            // 
            // Start_REG
            // 
            this.Start_REG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start_REG.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_REG.Location = new System.Drawing.Point(92, 174);
            this.Start_REG.Name = "Start_REG";
            this.Start_REG.Size = new System.Drawing.Size(152, 37);
            this.Start_REG.TabIndex = 16;
            this.Start_REG.Text = "Регистрация";
            this.Start_REG.UseVisualStyleBackColor = true;
            this.Start_REG.Click += new System.EventHandler(this.Start_REG_Click);
            // 
            // Start_IN
            // 
            this.Start_IN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start_IN.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_IN.Location = new System.Drawing.Point(92, 113);
            this.Start_IN.Name = "Start_IN";
            this.Start_IN.Size = new System.Drawing.Size(152, 37);
            this.Start_IN.TabIndex = 15;
            this.Start_IN.Text = "Вход";
            this.Start_IN.UseVisualStyleBackColor = true;
            this.Start_IN.Click += new System.EventHandler(this.Start_IN_Click);
            // 
            // StartForm
            // 
            this.ClientSize = new System.Drawing.Size(339, 326);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start_EXIT);
            this.Controls.Add(this.Start_REG);
            this.Controls.Add(this.Start_IN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartDobroPoj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Start_EXIT;
        private System.Windows.Forms.Button Start_REG;
        private System.Windows.Forms.Button Start_IN;
    }
}

