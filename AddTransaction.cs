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


    public partial class AddTransaction : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;
        int number = 0;
        int price = 0;
        float total = 0.0f;
        string checkIn ;
        DateTime checkOut;
        string checkout;
        int numberOfRoom;
        string ssn;
        public AddTransaction(string ssn)
        {
            this.ssn = ssn;
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
           
            
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();


            checkin_Text.Text = DateTime.Now.ToString();
            checkIn = DateTime.Now.Day.ToString() + '/' + DateTime.Now.Month.ToString() + '/' + DateTime.Now.Year.ToString();

            paymentType.Items.Add("Cash");
            paymentType.Items.Add("visa");
            cbm_type.Items.Add("single");
            cbm_type.Items.Add("double");
            cbm_type.Items.Add("triple");




           
            cmd.Connection = conn;
            cmd.CommandText = "select c.cust_ssn from customer c ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbm_ssn.Items.Add(dr[0].ToString());
            }
            dr.Close();
    


        }

      

       

        private void cbm_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            // cmd.CommandText = "select r.room_number from room r where room_availability = 'T' and r.room_type = :type";
            // cmd.Parameters.Add("type", cbm_type.SelectedItem.ToString());
            cmd.CommandText = "getRoomNumber";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("type", cbm_type.SelectedItem.ToString());
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            cbm_room.Items.Clear();
            while (dr.Read())
            {
                cbm_room.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void numberOfNights_TextChanged(object sender, EventArgs e)
        {
            if (!numberOfNights.Text.Equals(""))
            number = Convert.ToInt32(numberOfNights.Text.ToString());
            checkoutText.Text = DateTime.Now.AddDays(number).ToString();
            checkOut = DateTime.Now.AddDays(number);
            checkout = checkOut.Day.ToString() + '/' + checkOut.Month.ToString() + '/' + checkOut.Year.ToString();
            total = number * price;
            totalPayment.Text = total.ToString() + " EGP"; 

        }



        private void cbm_room_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select r.price_per_night from room r where r.room_number = :num";
            cmd.Parameters.Add("number", cbm_room.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                PricePerNight.Text = dr[0].ToString();
            }

            price = Convert.ToInt32(PricePerNight.Text.ToString());

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string type;
            if (cbm_type.SelectedIndex.ToString() == "Visa")
            {
                type = "V";
            }
            else
            {
                type = "C";
            }
            DateTime data =  DateTime.Now;
 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = " insert into transaction_for_room (rec_ssn , room_num , cust_ssn , check_in_date , check_out_date , payment_type, total_payment , total_price)values(:res_ssn, :numRoom, :cus_ssn, TO_DATE(:checkIn, 'DD/MM/YYYY'), TO_DATE(:checkOut, 'DD/MM/YYYY'), :TypePayment,  :totalpayment ,:totalprice)";

            
            cmd.Parameters.Add("rec_ssn", ssn);
            cmd.Parameters.Add("room_num", Convert.ToInt32(cbm_room.SelectedItem.ToString()));
            cmd.Parameters.Add("cust_ssn",cbm_ssn.SelectedItem.ToString());
            cmd.Parameters.Add("check_in_date", checkIn);
            cmd.Parameters.Add("check_out_date",checkout);
            cmd.Parameters.Add("payment_type", type);
            cmd.Parameters.Add("total_payment", price);
            cmd.Parameters.Add("total_price", total);
            int dr = cmd.ExecuteNonQuery();

            if(dr != -1)
            {
                MessageBox.Show("Insert Succsuffly");
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "update room  set room_availability = 'N' where room_number = :room_type";
                cm.Parameters.Add("rom_typee", Convert.ToInt32(cbm_room.SelectedItem.ToString()));
                int r =cm.ExecuteNonQuery();
                if(r != -1)
                {
                   
                }

            }


        }
    }
}
