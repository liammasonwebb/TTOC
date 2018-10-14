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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            Hide();
            login viwme = new login();
            viwme.ShowDialog();
            this.Close();
        }

        private void LogEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
