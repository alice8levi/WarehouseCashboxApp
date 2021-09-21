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
    public partial class StartForm : Form
    {
        const string pathTextLogPass = @"D:\pass.txt";
    
        public StartForm()
        {
            InitializeComponent();           
        }

        private void Start_IN_Click(object sender, EventArgs e)
        {
            IN_form in_form = new IN_form(pathTextLogPass);            
            in_form.ShowDialog();
        }

        private void Start_REG_Click(object sender, EventArgs e)
        {
            Registration reg_form = new Registration(pathTextLogPass);
            reg_form.ShowDialog();
        }

        private void Start_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
