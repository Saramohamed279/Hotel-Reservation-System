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
    public partial class showAvailableRoom : Form
    {

        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;
       
        public showAvailableRoom()
        {
            InitializeComponent();
        }

    

        private void cbm_ssn_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select r.price_per_night,r.room_type from room r where r.room_number = :roomNumber";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("roomNumber", cbm_AvaRoom.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                pricePerType.Text = dr[0].ToString();
                roomType.Text = dr[1].ToString();
            }
            dr.Close();
        }

     

        private void showAvailableRoom_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select room_number from room where room_availability = 'T'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbm_AvaRoom.Items.Add(dr[0].ToString());
            }
            dr.Close();


        }

      
    }
}
