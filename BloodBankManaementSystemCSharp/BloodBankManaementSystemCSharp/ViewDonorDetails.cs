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
    public partial class ViewDonorDetails : Form
    {
        public ViewDonorDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Japan Job Prepartion\C# Project\BloodBankManaementSystemCSharp\BloodBankManaementSystemCSharp\BBank.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM BDonor where id='"+textBox1.Text +"'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void ViewDonorDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bBankDataSet4.BDonor' table. You can move, or remove it, as needed.
            this.bDonorTableAdapter.Fill(this.bBankDataSet4.BDonor);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Japan Job Prepartion\C# Project\BloodBankManaementSystemCSharp\BloodBankManaementSystemCSharp\BBank.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM BDonor";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
