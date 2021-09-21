using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kursovaya
{   // окно склада (добавление нового товара и обновление количества уже созданных
    public partial class BASE : Form
    {
        SQLiteConnection DB = new SQLiteConnection("Data Source=DataBase.db;Version=3");  // подключение к дб
        DataTable mainbase = new DataTable();  //инициализация таблицы
        public BASE()
        {
            InitializeComponent();
        }

        private void BASE_Load(object sender, EventArgs e)
        {
            Upd();
        }

        // добавление в бд нового товара
        private void BASE_NEW_Click(object sender, EventArgs e)
        {
            if ((error(BASE_New_Name_textBox.Text.ToLower(), BASE_New_Cost_textBox.Text.ToLower(), BASE_New_Cnt_textBox.Text.ToLower()) == false)&&(cost_ch()==true))
            {

                if (name_check(BASE_New_Name_textBox.Text)==false)
                AddObj();
                else
                {
                    MessageBox.Show("Такой товар уже существует.");
                    BASE_New_Cost_textBox.Clear();
                    BASE_New_Cnt_textBox.Clear();
                    BASE_New_Name_textBox.Clear();
                }
            }       
        }
        // обновление количества товара на складе
        private void BASE_RELOAD_Click(object sender, EventArgs e)
        {

            if (error(BASE_Get_Name_textBox.Text, BASE_Get_Cnt__textBox.Text, "three")==false)
            {
                if (name_check(BASE_Get_Name_textBox.Text) == true)
                {
                    AddCount();
                }
                else
                {
                    MessageBox.Show("Не найден введенный товар. Проверьте введенное наименование или создайте новый");
                    BASE_Get_Name_textBox.Clear();
                }
            }
           
        }

        private void Upd()
        {
            DB.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = DB;
            cmd.CommandText = "Select * from MainDataBase"; // чтение всех столбцов
            using (SQLiteDataReader sdr = cmd.ExecuteReader())
            {
                //Load DataReader into the DataTable.
                mainbase.Load(sdr);
                sdr.Close();
                MAIN_dataGridView.DataSource = mainbase;
            }
            DB.Close();
        }

        private void BASE_Get_Cnt__textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == (char)Keys.Back)) return;
            else e.Handled = true;
        }

        private void BASE_New_Cost_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')) return;
            else e.Handled = true;
        }

        // ПРОВЕРКА заполнения полей
        bool error(string one, string two, string three)
        {
            if (one == string.Empty || two == string.Empty || three == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
                return true;
            }
            return false;
        }

        // ПРОВЕРКА НАЛИЧИЯ такого имени
        bool name_check(string name)
        {
            DB.Open();
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = DB;
                cmd.CommandText = "select Наименование from MainDataBase where Наименование like @name"; // поиск вхождений имени
                cmd.Parameters.Add("@name", System.Data.DbType.String).Value = name;

                int chek = 0;
                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        chek++;
                    }
                }
                switch (chek)
                {
                    case 0:
                        DB.Close();
                        return false;
                    default:
                        DB.Close();
                        return true;
                }
            }
        }

        // добавление нового товара
        private void AddObj()
        {
            DB.Open();
            SQLiteCommand new_item = DB.CreateCommand();
            new_item.CommandText = "insert into MainDataBase (Наименование, Цена, Количество, Единица_изм, Поступление) values (@name, @cost, @cnt ,@val, @date)";
            new_item.Parameters.Add("@name", System.Data.DbType.String).Value = BASE_New_Name_textBox.Text.ToLower();
            double cost = Convert.ToDouble(BASE_New_Cost_textBox.Text);
            new_item.Parameters.Add("@cost", System.Data.DbType.Double).Value = cost;
            new_item.Parameters.Add("@cnt", System.Data.DbType.Int64).Value = 0;
            new_item.Parameters.Add("@val", System.Data.DbType.String).Value = BASE_New_Cnt_textBox.Text.ToLower();
            DateTime today = DateTime.Today;
            string tdstring = today.ToShortDateString();
            new_item.Parameters.Add("@date", System.Data.DbType.String).Value = tdstring;
            new_item.ExecuteNonQuery();
            DB.Close();

            Upd();
            BASE_New_Name_textBox.Clear();
            BASE_New_Cost_textBox.Clear();
            BASE_New_Cnt_textBox.Clear();
        }

        //поступление товара
        private void AddCount()
        {
            DB.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = DB;
            cmd.CommandText = "select Наименование from MainDataBase where Наименование like @name"; // поиск вхождений имени
            cmd.Parameters.Add("@name", System.Data.DbType.String).Value = BASE_Get_Name_textBox.Text.ToLower();
            cmd.Parameters.Add("@cnt", System.Data.DbType.String).Value = BASE_Get_Cnt__textBox.Text.ToLower();
            cmd.CommandText = "update MainDataBase set Количество = (Количество + @cnt) where Наименование = @name";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update MainDataBase set Поступление = @date where Наименование = @name";
            DateTime today = DateTime.Today;
            string tdstring = today.ToShortDateString();
            cmd.Parameters.Add("@date", System.Data.DbType.String).Value = tdstring;
            cmd.ExecuteNonQuery();
            DB.Close();

            Upd();
            BASE_Get_Cnt__textBox.Clear();
            BASE_Get_Name_textBox.Clear();
        }

        bool cost_ch()
        {
            double ch = Convert.ToDouble(BASE_New_Cost_textBox.Text);
            double ch2 = ch * 100;

            string[] part = ch2.ToString().Split(',');
            int ch3 = Convert.ToInt32(part[0]);

           

            if (ch3!=ch2)
            {
                MessageBox.Show("Цена должна быть не более двух знаков после запятой");
                return false;
            }
            return true;
        }
    }


}

