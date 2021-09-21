namespace Kursovaya
{
    partial class IN_form
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
            this.IN_LOGIN_label = new System.Windows.Forms.Label();
            this.IN_LOGIN_textBox = new System.Windows.Forms.TextBox();
            this.IN_PASS_textBox = new System.Windows.Forms.TextBox();
            this.IN_PASS_label = new System.Windows.Forms.Label();
            this.IN_REG = new System.Windows.Forms.Button();
            this.IN_IN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IN_LOGIN_label
            // 
            this.IN_LOGIN_label.AutoSize = true;
            this.IN_LOGIN_label.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_LOGIN_label.Location = new System.Drawing.Point(66, 56);
            this.IN_LOGIN_label.Name = "IN_LOGIN_label";
            this.IN_LOGIN_label.Size = new System.Drawing.Size(46, 17);
            this.IN_LOGIN_label.TabIndex = 0;
            this.IN_LOGIN_label.Text = "Логин";
            // 
            // IN_LOGIN_textBox
            // 
            this.IN_LOGIN_textBox.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_LOGIN_textBox.Location = new System.Drawing.Point(141, 51);
            this.IN_LOGIN_textBox.Name = "IN_LOGIN_textBox";
            this.IN_LOGIN_textBox.Size = new System.Drawing.Size(232, 25);
            this.IN_LOGIN_textBox.TabIndex = 1;
            // 
            // IN_PASS_textBox
            // 
            this.IN_PASS_textBox.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_PASS_textBox.Location = new System.Drawing.Point(141, 107);
            this.IN_PASS_textBox.Name = "IN_PASS_textBox";
            this.IN_PASS_textBox.Size = new System.Drawing.Size(232, 25);
            this.IN_PASS_textBox.TabIndex = 3;
            // 
            // IN_PASS_label
            // 
            this.IN_PASS_label.AutoSize = true;
            this.IN_PASS_label.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_PASS_label.Location = new System.Drawing.Point(66, 112);
            this.IN_PASS_label.Name = "IN_PASS_label";
            this.IN_PASS_label.Size = new System.Drawing.Size(54, 17);
            this.IN_PASS_label.TabIndex = 2;
            this.IN_PASS_label.Text = "Пароль";
            // 
            // IN_REG
            // 
            this.IN_REG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IN_REG.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_REG.Location = new System.Drawing.Point(235, 179);
            this.IN_REG.Name = "IN_REG";
            this.IN_REG.Size = new System.Drawing.Size(138, 34);
            this.IN_REG.TabIndex = 5;
            this.IN_REG.Text = "Регистрация";
            this.IN_REG.UseVisualStyleBackColor = true;
            this.IN_REG.Click += new System.EventHandler(this.IN_REG_Click);
            // 
            // IN_IN
            // 
            this.IN_IN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IN_IN.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IN_IN.Location = new System.Drawing.Point(61, 179);
            this.IN_IN.Name = "IN_IN";
            this.IN_IN.Size = new System.Drawing.Size(138, 34);
            this.IN_IN.TabIndex = 4;
            this.IN_IN.Text = "Вход";
            this.IN_IN.UseVisualStyleBackColor = true;
            this.IN_IN.Click += new System.EventHandler(this.IN_IN_Click);
            // 
            // IN_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 276);
            this.Controls.Add(this.IN_REG);
            this.Controls.Add(this.IN_IN);
            this.Controls.Add(this.IN_PASS_textBox);
            this.Controls.Add(this.IN_PASS_label);
            this.Controls.Add(this.IN_LOGIN_textBox);
            this.Controls.Add(this.IN_LOGIN_label);
            this.Name = "IN_form";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IN_LOGIN_label;
        private System.Windows.Forms.TextBox IN_LOGIN_textBox;
        private System.Windows.Forms.TextBox IN_PASS_textBox;
        private System.Windows.Forms.Label IN_PASS_label;
        private System.Windows.Forms.Button IN_REG;
        private System.Windows.Forms.Button IN_IN;
    }
}