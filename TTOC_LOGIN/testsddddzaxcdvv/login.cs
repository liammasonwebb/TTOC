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
using testsddddzaxcdvv;

namespace testsddddzaxcdvv
{
    public partial class login : Form
    {
        

        public login()
        {
            

            string connstring = "Server=localhost;Port=3306;Database=ttocapp;Uid=root;Pwd=root;";
            MySqlConnection cnn = new MySqlConnection(connstring);
            cnn.Open();
            InitializeComponent();
        }
        private bool validate_login(string user, string pass)
        {
            string con1 = "Server=localhost;Port=3306;Database=ttocapp;Uid=root;Pwd=root;";
            MySqlConnection cnn = new MySqlConnection(con1);
            cnn.Open();

            string sql = "Select * from user_ where username='" + user + "' and password_='" + pass + "' and userStatus = 1";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                cnn.Close();
                Hide();
                admin viwme = new admin();
                viwme.ShowDialog();
                this.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        private bool validate_login_op(string user, string pass)
        {
            string con1 = "Server=localhost;Port=3306;Database=ttocapp;Uid=root;Pwd=root;";
            MySqlConnection cnn = new MySqlConnection(con1);
            cnn.Open();

            string sql = "Select * from user_ where username='" + user + "' and password_='" + pass + "' and userStatus = 0";
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                cnn.Close();
                Hide();
                Main_Menu viwme = new Main_Menu();
                viwme.ShowDialog();
                this.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
                MessageBox.Show("Correct Login Credentials AD");
            else
                MessageBox.Show("Incorrect Login Credentials");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            bool r = validate_login_op(user, pass);
            if (r)
                MessageBox.Show("Correct Login Credentials OP");



            else
                MessageBox.Show("Incorrect Login Credentials");

           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
