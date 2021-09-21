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
{
    public partial class GET : Form
    {
        public GET()
        {
            InitializeComponent();
        }

        private void GET_Save_Click(object sender, EventArgs e)
        {

        }

        private void GET_NEW_Click(object sender, EventArgs e)
        {
            NEW New = new NEW();
            New.ShowDialog();
        }
    }
}
