using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodBankManaementSystemCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox1.Text == "rifat" || textBox2.Text == "rifat")
                {
                    MessageBox.Show("You are logged in successfully..");
                    this.Visible = false;
                    Home obj1 = new Home();
                    obj1.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Japan Job Prepartion\C# Project\BloodBankManaementSystemCSharp\BloodBankManaementSystemCSharp\BBank.mdf;Integrated Security=True");
                con.Open();
                string str = "SELECT id FROM doctor WHERE name = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    HomeD obj2 = new HomeD();
                    obj2.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "--Select--";
                }
                else
                {
                    MessageBox.Show("Invalid username and Password.");
                }
            }
        }
    }
}
