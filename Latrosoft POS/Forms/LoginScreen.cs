using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latrosoft_POS.Forms
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Select User Role");
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Casheir");
            comboBox1.SelectedIndex = 0;
        }
        public void validate()
        {
            if(comboBox1.SelectedIndex==0)
            {
                MessageBox.Show("Please Select User Role");
            }else if(textBox1.Text.Length==0) {
                MessageBox.Show("Please Enter User Name");
            }else if(textBox2.Text.Length==0)
            {
                MessageBox.Show("Please Enter Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validate();
            
        }
    }
}
