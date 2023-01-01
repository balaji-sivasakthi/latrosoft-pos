using Latrosoft_POS.DAL;
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
    public partial class AddStaff : Form
    {
        public DBHelper db;
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            db= new DBHelper();
            DataTable dt= db.executeDataTable("SELECT * FROM user_tbl");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.Remove("PASSWORD");
        }
    }
}
