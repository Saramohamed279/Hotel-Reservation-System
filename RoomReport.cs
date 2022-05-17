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
    public partial class RoomReport : Form
    {
        CrystalReport1 CR_ROOMS;

        public RoomReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR_ROOMS;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CR_ROOMS = new CrystalReport1();
        }
    }
}
