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
 
    public partial class AddCustomer : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void SSN_ModifiedChanged(object sender, EventArgs e)
        {
            numberSSn.Text = SSN.Text.Count().ToString();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {


        }

        private void SSN_TextChanged(object sender, EventArgs e)
        {
            numberSSn.Text = SSN.Text.Count().ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into customer (cust_ssn , cust_address, cust_fname, cust_lname, cust_phone_number) values(:snn,:address,:fname,:lname,:phone)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ssn",SSN.Text);
            cmd.Parameters.Add("add",address.Text);
            cmd.Parameters.Add("fname",fName.Text);
            cmd.Parameters.Add("lname",Lname.Text);
            cmd.Parameters.Add("phone",phone.Text);
            try
            {
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("succuss");
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(" Error Check Your Enter Data");
            }
          


        }
    }
}
