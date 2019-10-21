using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManaementSystemCSharp
{
    public partial class HomeD : Form
    {
        public HomeD()
        {
            InitializeComponent();
        }

        private void addDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorRegistration obj = new BloodBankManaementSystemCSharp.DonorRegistration();
            obj.ShowDialog();
        }

        private void addBloodDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodDonor obj1 = new BloodBankManaementSystemCSharp.BloodDonor();
            obj1.ShowDialog();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails obj2 = new BloodBankManaementSystemCSharp.StockDetails();
            obj2.ShowDialog();
        }

        private void viewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDoctor obj3 = new ViewDoctor();
            obj3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj4 = new BloodBankManaementSystemCSharp.Form1();
            obj4.ShowDialog();
        }

        private void HomeD_Load(object sender, EventArgs e)
        {

        }
    }
}
