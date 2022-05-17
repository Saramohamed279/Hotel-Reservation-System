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
    public partial class Disconnected_shift : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Disconnected_shift()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {



        }





        private void search_btn_Click(object sender, EventArgs e)
        {
                        string constr = "Data Source=ORCL;User Id=scott;password=1234;";

            string cmdstr = "";
            
            if(radMornningShift.Checked)
            {
                cmdstr = "select * from receptionist where receptionist_shift = 'M' ";
            }
            else if (radNightShift.Checked)
            {
                cmdstr = "select * from receptionist where receptionist_shift = 'N' ";
            }
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();

            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radNightShift_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
