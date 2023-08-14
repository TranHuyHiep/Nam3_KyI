using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    internal class Connection
    {
        private string connect = "Data Source=MYPC;Initial Catalog=BanHang;Integrated Security=True";
        private SqlConnection sqlConnection = null;
        public void onloadData()
        {
            sqlConnection = new SqlConnection(connect);
            if(sqlConnection != null)
            {
                sqlConnection.Open();
            }
        }
        
        public DataTable readData(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }
}
