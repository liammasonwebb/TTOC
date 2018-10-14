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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void addlocation_Click(object sender, EventArgs e)
        {
            Hide();
            locations viwme = new locations();
            viwme.ShowDialog();
            this.Close();
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            Hide();
            login viwme = new login();
            viwme.ShowDialog();
            this.Close();
        }

        private void SearchEvent_Click(object sender, EventArgs e)
        {
            Hide();
            Event_types viwme = new Event_types();
            viwme.ShowDialog();
            this.Close();
        }
    }
}
