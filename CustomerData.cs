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
    public partial class CustomerData : Form
    {
        int type;
        bool finish = false;
        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
       
        OracleConnection conn;
        public CustomerData()
        {
            InitializeComponent();
        }

        private void CustomerData_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open(); 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select c.cust_ssn from customer c";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbm_snn.Items.Add(dr[0].ToString());

            }

        }

        private void cbm_snn_SelectedIndexChanged(object sender, EventArgs e)
        {
            finish = false;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "getCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("ssn", cbm_snn.SelectedItem.ToString());
            cmd.Parameters.Add("fname", OracleDbType.Varchar2, 20000).Direction= ParameterDirection.Output;
            cmd.Parameters.Add("lname", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("address", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("phone", OracleDbType.Varchar2, 20000).Direction = ParameterDirection.Output;
          
            cmd.ExecuteNonQuery();
            firstName.Text = cmd.Parameters["fname"].Value.ToString();
            secondName.Text = cmd.Parameters["lname"].Value.ToString();
            phone.Text = cmd.Parameters["phone"].Value.ToString();
            address.Text = cmd.Parameters["address"].Value.ToString();


            finish = true;


            //   cmd.Parameters.Add("fname", OracleDbType.Varchar2, ParameterDirection.Output);
            //  cmd.Parameters.Add("lname", OracleDbType.Varchar2, ParameterDirection.Output);
            //  cmd.Parameters.Add("address", OracleDbType.Varchar2, ParameterDirection.Output);
            //  cmd.Parameters.Add("phone", OracleDbType.Varchar2, ParameterDirection.Output);
            
           

           
        }

        private void CustomerData_DoubleClick(object sender, EventArgs e)
        {
            cbm_snn.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select cust_ssn from customer  where cust_ssn like :val";
            cmd.Parameters.Add("SSN", cbm_snn.Text + "%");
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbm_snn.Items.Add(dr[0].ToString());

            }
        }
    }
}
