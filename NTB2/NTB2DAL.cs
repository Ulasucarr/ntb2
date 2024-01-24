using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTB2
{
    public class NTB2DAL
    {
        // Connection string değişkeni tanımla
        private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ULASCAN_UCAR_NTB2\NTB2\NTB2\NTB2DB.mdf;Integrated Security=True";

        SqlConnection con;
        SqlCommand cmd;
        

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (con = new SqlConnection(conStr))
                {
                    using (cmd = new SqlCommand(cmdtext, con))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);

                        }
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        { 
            try
            {
                con = new SqlConnection(conStr);
                cmd = new SqlCommand(cmdtext, con);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);

                }
                con.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 

    }
} 
