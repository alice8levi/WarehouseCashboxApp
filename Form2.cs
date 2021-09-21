using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursovaya
{
    public partial class IN_form : Form
    {
        const string pathTextLogPass = @"D:\pass.txt";

        public IN_form(string pathTextLogPass)
        {
            InitializeComponent();
        }
        // кнопка регистрации
        private void IN_REG_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Hide();
            Registration reg_form = new Registration(pathTextLogPass);
            reg_form.ShowDialog();           
        }
        // вход
        private void IN_IN_Click(object sender, EventArgs e)
        {
            if (pass_chek() == true)
            {
                DialogResult = DialogResult.OK;
                this.Hide();
                MainMenu Main = new MainMenu();
                Main.ShowDialog();
                return;
            }
            else MessageBox.Show("Такого логина или пароля не существует. \n Повторите ввод или зарегистрируйтесь!");
        }

        // проверка пары логин/пароль
        bool pass_chek()
        {
            string login;
            string pasword;

            if (File.Exists(pathTextLogPass))
            {                
                string[] lines = File.ReadAllLines(pathTextLogPass, Encoding.Default);
                foreach (string line in lines)
                {
                    string[] linesDec = Decryption(line).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    login = linesDec[0];
                    pasword = linesDec[1];

                    if (login.ToLower() == IN_LOGIN_textBox.Text.ToLower() && pasword == IN_PASS_textBox.Text)
                    {
                        return true;
                    }
                }                
            }
            return false;
        }
        // расшифрование пары логин/пароль
        string Decryption(string str)
        {
            StringBuilder strB = new StringBuilder(str);
            for (int i = 0; i < strB.Length; i++)
                strB[i] = (char)(strB[i] - 2);

            return strB.ToString();
        }
    }
}
