using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Latrosoft_POS.DAL
{
    public  class DBHelper
    {
        
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;

        public DBHelper()
        {
            try
            {
                con = new SqlConnection("Data Source=balaji\\SQLEXPRESS;Initial Catalog=lspos;Integrated Security=True;");
                cmd = new SqlCommand("", con);
                dt = new DataTable();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public DataTable executeDataTable(string sqlcmd)
        {
            try
            {
                con.Open();
                dt.Clear();
                cmd.CommandText = sqlcmd;
                dt.Load(cmd.ExecuteReader());
                con.Close();
                return dt.Copy();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int executeNonQuery(string sqlcmd)
        {
            con.Open();
            cmd.CommandText = sqlcmd;
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return  result;
        }

        public object executeScalar(string sqlcmd)
        {
            con.Open();
            cmd.CommandText = sqlcmd;
            object obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

    }
}
