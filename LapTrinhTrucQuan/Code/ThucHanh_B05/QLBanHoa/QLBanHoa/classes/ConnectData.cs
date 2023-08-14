using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHoa.classes
{
    internal class ConnectData
    {
        string strConnect = "Data Source=MYPC;Initial Catalog=DuLieu;Integrated Security=True";
        SqlConnection sqlConnection = null;
        
        // open connect method
        void OpenConnect()
        {
            sqlConnection = new SqlConnection(strConnect);
            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        // closing connect method
        void CloseConnect()
        {
            if(sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        //insert, update, delete data
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            CloseConnect();
            sqlCommand.Dispose();
        }

        // select data to return a DataTable
        //insert, update, delete data
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelect, sqlConnection);
            sqlDataAdapter.Fill(dt);
            CloseConnect();
            sqlDataAdapter.Dispose();
            return dt;
        }

    }
}
