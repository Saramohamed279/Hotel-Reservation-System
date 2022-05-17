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
    public partial class AddRoom : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;
        public AddRoom(string name)
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
      
            cbm_RoomType.Items.Add("single");
            cbm_RoomType.Items.Add("double");
            cbm_RoomType.Items.Add("triple");

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into room(room_number, price_per_night, room_availability, room_type) values (:numberr,:pricee,'T',:typee)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("number", Convert.ToInt32(roomNumber.Text));
            cmd.Parameters.Add("price", Convert.ToInt32(price.Text));
            cmd.Parameters.Add("type", cbm_RoomType.SelectedItem.ToString());
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
