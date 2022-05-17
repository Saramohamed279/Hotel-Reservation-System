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
    public partial class Login : Form
    {
        int type;
        string ordb = "Data Source=ORCL;User Id=scott;password=1234;";
        OracleConnection conn;
      


        public Login(int type)
        {
            this.type = type;
            InitializeComponent();
            
          
           

        }


       
        private void Login_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
      

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (email.Text.ToString() != "" && password.Text.ToString() != "")
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                if (type == 0)
                {

                    cmd.CommandText = "select a.admin_fname,a.admin_lname  from hotle_admin a where a.admin_ssn = :email and a.admin_password = :password";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("email", email.Text);
                    cmd.Parameters.Add("password", password.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string name = dr[0].ToString()+" " +dr[1].ToString();
                     
                        Admin rec = new Admin(name);
                        rec.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check email or Password");
                    }

                }
                else
                {

                    cmd.CommandText = "select r.receptionist_fname ,r.receptionist_lname, r.receptionist_ssn from receptionist r where receptionist_email = :email and receptionist_password =:password";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("email", email.Text);
                    cmd.Parameters.Add("password", password.Text);
                    OracleDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string name = dr[0].ToString() + " " + dr[1].ToString();
                        string ssn = dr[2].ToString();
                        REC rec = new REC(name,ssn);
                        rec.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Check email or Password");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Enter Emial and Password");
            }
          
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
