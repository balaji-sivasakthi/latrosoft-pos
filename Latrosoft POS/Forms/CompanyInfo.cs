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
    public partial class CompanyInfo : Form
    {
        DBHelper db = null;
        DataTable dt=null;
        public CompanyInfo()
        {
            InitializeComponent();
        }

      
        private void getCompanyInfo()
        {
            dt = db.executeDataTable("select * from company_tbl");
            foreach (DataRow dr in dt.Rows)
            {
                name_txt.Text = dr["Name"].ToString();
                type_cb.Text = dr["Type"].ToString();
                address_txt.Text = dr["Address"].ToString();
                city_txt.Text = dr["City"].ToString();
                state_txt.Text = dr["State"].ToString();
                country_txt.Text = dr["country"].ToString();
                pincode_txt.Text = dr["pincode"].ToString();
                email_txt.Text = dr["email"].ToString();
                phone_txt.Text = dr["phone"].ToString();
                gstin_txt.Text = dr["gstin"].ToString();
                pan_txt.Text = dr["pan"].ToString();
                currency_txt.Text = dr["currency id"].ToString();
                fax_txt.Text = dr["fax"].ToString();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validate();


            String sql = String.Format(@"INSERT INTO company_tbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')"
                                      ,name_txt.Text,type_cb.SelectedText,address_txt.Text,city_txt.Text,state_txt.Text,country_txt.Text,pincode_txt.Text,email_txt.Text
                                      ,phone_txt.Text,gstin_txt.Text,pan_txt.Text,currency_txt.Text,fax_txt.Text,""
                                      );

//            MessageBox.Show(sql);
            int result = db.executeNonQuery(sql);
            MessageBox.Show("Busniess Information Saved Successfullty");
            getCompanyInfo();

        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            db = new DBHelper();
            
            dt=  db.executeDataTable("SELECT * FROM company_tbl");
   
            if (dt.Rows.Count == 1 ) {
                button1.Enabled = false;
                button3.Enabled = true;
            }
            else
            {

                button1.Enabled = true;
                button3.Enabled = false;
            }
            getCompanyInfo();

        }

        public void validate()
        {
            if (String.IsNullOrEmpty(name_txt.Text))
            {
                MessageBox.Show("Please Enter Business name");
            }
            //else if(String.IsNullOrEmpty(address_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Business address");

            //}else if (type_cb.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Please Enter Business type");

            //}else if (String.IsNullOrEmpty(city_txt.Text))
            //{
            //    MessageBox.Show("Please enter city name");

            //}
            //else if(String.IsNullOrEmpty(state_txt.Text))
            //{
            //    MessageBox.Show("Please Enter state name");

            //}else if (String.IsNullOrEmpty(country_txt.Text))
            //{
            //    MessageBox.Show("Please Enter city");

            //}else if (String.IsNullOrEmpty(pincode_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Pincode");

            //}else if (String.IsNullOrEmpty(email_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Email");

            //}else if (String.IsNullOrEmpty(phone_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Phone No");

            //}else if (String.IsNullOrEmpty(gstin_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Business type");

            //}else if (String.IsNullOrEmpty(pan_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Business type");

            //}else if (String.IsNullOrEmpty(currency_txt.Text))
            //{
            //    MessageBox.Show("Please Enter Business type");
            //}
            //else if(logo_pic.Image == null) { }
            //{
            //    MessageBox.Show("Upload Logo");

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            validate();


            String sql = String.Format(@"UPDATE company_tbl SET NAME='{0}',TYPE='{1}',ADDRESS='{2}',CITY='{3}',STATE='{4}',COUNTRY='{5}',PINCODE='{6}',EMAIL='{7}',PHONE='{8}',GSTIN='{9}',PAN='{10}',[CURRENCY ID]='{11}',FAX='{12}',LOGO='{13}'"
                                      , name_txt.Text, type_cb.Items[type_cb.SelectedIndex].ToString(), address_txt.Text, city_txt.Text, state_txt.Text, country_txt.Text, pincode_txt.Text, email_txt.Text
                                      , phone_txt.Text, gstin_txt.Text, pan_txt.Text, currency_txt.Text, fax_txt.Text, ""
                                      );

           // MessageBox.Show(sql);
            int result = db.executeNonQuery(sql);
            MessageBox.Show("Busniess Information updated Successfullty");
            
            getCompanyInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes==ds)
            {
                this.Close();
            }
        }
    }
}
