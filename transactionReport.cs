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
    public partial class transactionReport : Form
    {
        CrystalReport2 CR_transaction;
        public transactionReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void transactionReport_Load(object sender, EventArgs e)
        {
            CR_transaction = new CrystalReport2();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR_transaction;
        }
    }
}
