using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_Project
{
    public partial class REC : Form
    {
        string name;
        string ssn;
        public REC(string name, string ssn)
        {
            this.name = name;
            this.ssn = ssn;
            InitializeComponent();
        }

        private void REC_Load(object sender, EventArgs e)
        {
            titleName.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction(ssn);
            addTransaction.Show();
        }

      

        private void button1_Click_2(object sender, EventArgs e)
        {

            showAvailableRoom showRoom = new showAvailableRoom();
            showRoom.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            CustomerData customerData = new CustomerData();
            customerData.Show();
        }
    }
}
