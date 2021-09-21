using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// форма регистрации
namespace Kursovaya
{
    public partial class Registration : Form
    {
        string pathTextLogPass;
        const string pathAdmPass = @"D:\admpass.txt";

        public Registration(string pathTextLogPass)
        {
            InitializeComponent();            

            this.pathTextLogPass = pathTextLogPass;
            if (!(File.Exists(pathTextLogPass)))
                using (FileStream fs = new FileStream(pathTextLogPass, FileMode.CreateNew)) { }
            if (!(File.Exists(pathAdmPass)))
                File.WriteAllText(pathAdmPass, "sygtv{");                
        }
        // кнопка Назад
        private void IN_IN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // кнопка регистрация
        private void button1_Click(object sender, EventArgs e)
        {
            if(errors()==false)
            {
                if (Save(IN_LOGIN_textBox.Text, IN_PASS_textBox.Text) == true)
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Пользователь успешно зарегистрирован");
                    return;
                }
                else return;
            }
            else return;


        }
        // проверка ошибок
        bool errors()
        {
            if (IN_LOGIN_textBox.Text == string.Empty)
            {
                MessageBox.Show("Создайте логин");
                return true;
            }
            if (IN_PASS_textBox.Text == string.Empty || IN_PASS_textBox2.Text == string.Empty)
            {
                MessageBox.Show("Поле с паролем не заполнено");
                return true;
            }
            if (IN_PASS_textBox2.Text != IN_PASS_textBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return true;
            }
            if (AdmCheck(pathAdmPass) == false)
            {
                MessageBox.Show("Неправильный пароль администратора");
                return true;
            }
            return false;
        }
        // сохраняем пару логин/пароль в файл
        bool Save(string login, string pasword)
        {
            try
            {
                if (NewLoginCheck(pathTextLogPass))
                {
                    File.AppendAllLines(pathTextLogPass, new[] { Encryption(login + "|" + pasword) }, Encoding.Default);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        // проверка логина на существование
        bool NewLoginCheck(string pathTextLogPass)
        {
            string[] lines = File.ReadAllLines(pathTextLogPass, Encoding.Default);
            foreach (string line in lines)
            {
                if (Decryption(line).Split('|')[0].ToLower() == IN_LOGIN_textBox.Text.ToLower())
                {
                    MessageBox.Show("Такой логин уже существует");
                    return false;
                }
            }

            return true;
        }

        // проверка пароля администратора
        bool AdmCheck(string pathAdmPass)
        {
            string[] lines = File.ReadAllLines(pathAdmPass, Encoding.Default);
            foreach (string line in lines)
            {
                if (Decryption(line) == IN_adm_textBox.Text)
                {                  
                    return true;
                }
            }
            return false;
        }

        // шифрование пары логин/пароль
        string Encryption(string str)
        {
            StringBuilder strB = new StringBuilder(str);
            for (int i = 0; i < strB.Length; i++)
                strB[i] = (char)(strB[i] + 2); 
            return strB.ToString();
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
