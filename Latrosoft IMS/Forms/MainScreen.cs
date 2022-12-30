using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latrosoft_IMS.Forms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void companyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfo frm = new CompanyInfo();
              
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if(result==DialogResult.Yes)
            {
                   Application.Exit();
            }
            else
            {

            }
        }

        private void staddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff frm = new AddStaff();
            
            frm.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductMaster frm = new ProductMaster();
            frm.Show();
        }
    }
}
