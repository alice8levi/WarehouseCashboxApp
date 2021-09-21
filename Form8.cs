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
using System.IO;

namespace Kursovaya
{ // окно продажи товара и создания чека
    public partial class SELL : Form

    {
        string selling_nowPath;
        string selling_logPath;
        SQLiteConnection DBSell = new SQLiteConnection("Data Source=DataBase.db;Version=3");  // подключение к бд
        DataTable sellbase = new DataTable();  //инициализация таблицы
        double summa;
        

        public SELL(string Selling_now, string Selling_log)
        {

            InitializeComponent();

            SELL_textBox_SUMM.Text = "0.00";
            summa = 0.00;

            selling_nowPath = Selling_now;
            if (!(File.Exists(Selling_now)))
                using (FileStream fs = new FileStream(Selling_now, FileMode.CreateNew)) ;

            selling_logPath = Selling_log;
            if (!(File.Exists(Selling_log)))
                using (FileStream fs = new FileStream(Selling_log, FileMode.CreateNew)) ;
            
        }

        private void SELL_Load(object sender, EventArgs e)
        {
            Upd();
        }

        // кнопка ПРОВЕСТИ
        private void NEW_Save_Click(object sender, EventArgs e)
        {            
            ChangeMainBase();
            Save(summa);
            ClearAll();
            Upd();            
        }           
        
        // КНОПКА добавления товара в чек
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                if ((name_check(textBox1.Text.ToLower()) == true)&&(cnt_check(textBox1.Text.ToLower(),textBox2.Text)==true))
                {
                    AddStringToCh();
                }               
            }
            else MessageBox.Show("Заполните все поля");
        }
        
        private void clear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void Base_btn_Click(object sender, EventArgs e)
        {
            BASE Base = new BASE();            
            Base.ShowDialog();            
        }

        private void SELL_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearAll();
        }

        // ПРОВЕРКА НАЛИЧИЯ товара в базе
        bool name_check(string name)
        {
            DBSell.Open();
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = DBSell;
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
                        {
                            MessageBox.Show("Не найден введенный товар. Проверьте введенное наименование.");
                            textBox1.Text = "товар";
                            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                            textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
                            DBSell.Close();
                            return false;
                        }
                    default:
                        DBSell.Close();
                        return true;
                }
            }   
        }

        // ПРОВЕРКА НАЛИЧИЯ Количества товара
        bool cnt_check(string name, string count)
        {
            DBSell.Open();
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = DBSell;
                cmd.CommandText = "select Количество from MainDataBase where Наименование like @name";
                cmd.Parameters.Add("@name", System.Data.DbType.String).Value = name;
                int cnt_ch = Convert.ToInt32(cmd.ExecuteScalar());
                cnt_ch = cnt_ch - Convert.ToInt32(count);
                if (cnt_ch < 0)
                {
                    MessageBox.Show("Недостаточно товара на складе");
                    DBSell.Close();
                    return false;
                }
            }
            DBSell.Close();
            return true;
        }

        // добавление строки в таблицу чека
        private void AddStringToCh()
        {
            try
            {
                DBSell.Open();

                using(SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = DBSell;
                    cmd.CommandText = "insert into Sell (Наименование, Цена, Количество, Сумма) values (@name, @price, @cnt, @summ)";
                    cmd.Parameters.Add("@cnt", System.Data.DbType.String).Value = textBox2.Text.ToLower();
                    cmd.Parameters.Add("@name", System.Data.DbType.String).Value = textBox1.Text.ToLower();

                    SQLiteCommand temp = new SQLiteCommand("select Цена from MainDataBase where Наименование like @name");
                    temp.Connection = DBSell;
                    temp.Parameters.Add("@name", System.Data.DbType.String).Value = textBox1.Text.ToLower();


                    double tmp = Convert.ToDouble(temp.ExecuteScalar()) * Convert.ToDouble(textBox2.Text);

                    cmd.Parameters.Add("@price", System.Data.DbType.Double).Value = Convert.ToDouble(temp.ExecuteScalar());
                    cmd.Parameters.Add("@summ", System.Data.DbType.Double).Value = tmp;
                    cmd.ExecuteNonQuery();

                    summa += tmp; 
                    SELL_textBox_SUMM.Text = Convert.ToString(summa);
                }
                DBSell.Close();
                Upd();
                textBox1.Clear();
                textBox2.Text = "1";
                return;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                textBox1.Clear();
                textBox2.Text = "1";
                DBSell.Close();
            }
        }

        //внесение изменений в склад
        private void ChangeMainBase()
        {
            DBSell.Open();
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = DBSell;
                cmd.CommandText = "Select * from Sell"; // чтение всех столбцов
                using (SQLiteCommand cmd2 = new SQLiteCommand())
                {
                    cmd2.Connection = DBSell;
                    cmd2.CommandText = "Select * from Sell"; // чтение всех столбцов
                    cmd2.CommandText = "Update MainDataBase Set Количество = (Количество - @cnt) Where Наименование = @name";

                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {
                            string name = dataReader["Наименование"].ToString();
                            string count = dataReader["Количество"].ToString();
                            cmd2.Parameters.Add("@name", System.Data.DbType.String).Value = name;
                            cmd2.Parameters.Add("@cnt", System.Data.DbType.String).Value = count;
                            cmd2.ExecuteNonQuery();
                        }
                    }           
                }
            };
            DBSell.Close();
        }

        // очистка таблицы чека
        private void ClearAll()
        {
            DBSell.Open();
            using (SQLiteCommand temp = new SQLiteCommand("Delete from Sell"))
            {
                temp.Connection = DBSell;
                temp.ExecuteNonQuery();
            }
            sellbase.Clear();
            DBSell.Close();
            summa = 0.00;
            SELL_textBox_SUMM.Text = Convert.ToString(summa);
        }

        // сохранение чека в файлы
        private void Save(double summ)
        {
            DBSell.Open();
            try
            {
                using (StreamWriter nw = new StreamWriter(selling_nowPath, false))
                {

                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = DBSell;
                    cmd.CommandText = "Select * from Sell"; // чтение всех столбцов
                    nw.WriteLine(" {0,-20}{1,-10}{2,10}{3,12}", "Наименование ", "Количество", "Цена", "Сумма");
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            //MessageBox.Show(dataReader["Наименование"].ToString()+" | "+ dataReader["Количество"].ToString() + " | " + dataReader["Цена"].ToString() + " | " + dataReader["Сумма"].ToString() );
                            nw.WriteLine(" {0,-20}{1,-10}{2,10}{3,12}", dataReader["Наименование"].ToString(), dataReader["Количество"].ToString(), dataReader["Цена"].ToString(), dataReader["Сумма"].ToString());
                        }
                        nw.WriteLine(" Итого: " + summ + " руб.");
                        DateTime today = DateTime.Now;
                        nw.WriteLine(Convert.ToString(today));
                    }

                }

                using (StreamReader logread = new StreamReader(selling_nowPath))
                {
                    using (StreamWriter log = new StreamWriter(selling_logPath, true))
                    {
                        log.Write(logread.ReadToEnd());
                        log.WriteLine();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка записи");
            }
            DBSell.Close();
        }

        // обновление таблицы чека
        private void Upd()
        {
            DBSell.Open();
            using (SQLiteCommand cmd3 = new SQLiteCommand())
            {
                cmd3.Connection = DBSell;
                cmd3.CommandText = "Select * from Sell"; // чтение всех столбцов
                using (SQLiteDataReader sdr2 = cmd3.ExecuteReader())
                {
                    //Load DataReader into the DataTable.
                    sellbase.Load(sdr2);
                    sdr2.Close();
                    SELL_dataGridView.DataSource = sellbase;
                }
            };
            DBSell.Close();
        } 

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "товар")
            {
                this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            }
            textBox1.Text = string.Empty;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == (char)Keys.Back)) return;
            else e.Handled = true;
        }              
    }
}
