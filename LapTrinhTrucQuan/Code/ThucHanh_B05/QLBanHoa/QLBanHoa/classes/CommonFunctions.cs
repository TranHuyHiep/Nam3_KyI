using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace QLBanHoa.classes
{
    internal class CommonFunctions
    {
        classes.ConnectData connectData = new classes.ConnectData();
        public void FillComboBox(ComboBox comboName, DataTable data, string displayMenber, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMenber;
            comboName.ValueMember = valueMember;
        }
        public string AutoCode(string tableName, string columnName, string startValue) 
        {
            string code = "";
            bool check = false;
            int id = 0;
            code = startValue + id.ToString();
            do
            {
                DataTable dataTable = connectData.ReadData("select * from " + tableName +
                    " where " + columnName + " = " + code);
                if(dataTable.Rows.Count == 0)
                {
                    check = true;
                } else
                {
                    id++;
                }
            } while(check == false);

            return code;
        }
    }
}
