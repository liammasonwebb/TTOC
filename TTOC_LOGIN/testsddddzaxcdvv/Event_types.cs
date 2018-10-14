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
    public partial class Event_types : Form
    {
        public Event_types()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            admin viwme = new admin();
            viwme.ShowDialog();
            this.Close();
        }
    }
}
