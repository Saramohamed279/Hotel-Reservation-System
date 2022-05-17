using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Hotel_Reservation_Project
{
    public partial class DataHistory : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;
        public DataHistory()
        {
            InitializeComponent();
        }

        private void DataHistorycs_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from transaction_for_room";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            myTable.DataSource = table;
            while (dr.Read())
            {
                 roomNumber.DataGridView.Rows.Add(dr[1].ToString(),dr[1].ToString());
                
            }
        }
    }
}
