using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang.Classes
{
    internal class CommonFunctions
    {
        Classes.ConnectData data = new Classes.ConnectData();
        public void FillComboBox(ComboBox comboName,DataTable data,string displayMember,string valueMember)
        {
            comboName.DataSource=data;
            comboName.DisplayMember =displayMember;
            comboName.ValueMember = valueMember;
        }
        public string AutoCode(string tableName, string columnName, string startvalue)
        {
            string code;
            bool check = false;
            int id = 0;
            code = startvalue+ id.ToString();
            do
            {
                DataTable dtData = data.ReadData("select *from " + tableName + " where " + columnName + "='" + code+"'");
                if (dtData.Rows.Count == 0)
                    check = true;
                else
                    id++;
            } while (check == false);
            return code;

        }
    }
}
