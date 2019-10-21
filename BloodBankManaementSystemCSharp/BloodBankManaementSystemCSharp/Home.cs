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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorRegistration obj = new BloodBankManaementSystemCSharp.doctorRegistration();
            obj.ShowDialog();
        }

        private void addCampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camp obj1 = new BloodBankManaementSystemCSharp.Camp();
            obj1.ShowDialog();
        }

        private void addDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorRegistration obj2 = new BloodBankManaementSystemCSharp.DonorRegistration();
            obj2.ShowDialog();
        }

        private void viewDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDoctor obj3 = new ViewDoctor();
            obj3.ShowDialog();
        }

        private void viewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDonorDetails obj4 = new ViewDonorDetails();
            obj4.ShowDialog();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStock obj5 = new ViewStock();
            obj5.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj6 = new BloodBankManaementSystemCSharp.Form1();
            obj6.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
