using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testsddddzaxcdvv
{
    public partial class locations : Form
    {
        public locations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            admin viwme = new admin();
            viwme.ShowDialog();
            this.Close();
        }
    }
}
