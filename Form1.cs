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
    public partial class Form1 : Form
    {
        static string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select actorname  from actors where actorid = 1";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login(0);
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login login = new Login(1);
            login.Show();

          
        }
    }
}
