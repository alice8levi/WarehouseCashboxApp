using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{   // главное окно
    public partial class MainMenu : Form
    {
        const string Selling_now = @"D:\now.txt";
        const string Selling_log = @"D:\log.txt";
        public MainMenu()
        {
            InitializeComponent();
            MainMenu_linkLabel_CHANGEuser.Hide(); //
        }

        private void MainMenu_Base_Click(object sender, EventArgs e)
        {
            BASE Base = new BASE();          
            Base.ShowDialog();
        }
               
        private void MainMenu_SELL_Click(object sender, EventArgs e)
        {
            SELL Sell = new SELL(Selling_now, Selling_log);        
            Sell.ShowDialog();
        }

        private void MainMenu_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
