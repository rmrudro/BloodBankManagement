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
    public partial class ViewStock : Form
    {
        public ViewStock()
        {
            InitializeComponent();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bBankDataSet5.stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.bBankDataSet5.stock);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Japan Job Prepartion\C# Project\BloodBankManaementSystemCSharp\BloodBankManaementSystemCSharp\BBank.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM stock";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
