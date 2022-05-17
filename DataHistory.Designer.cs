
namespace Hotel_Reservation_Project
{
    partial class DataHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTable = new System.Windows.Forms.DataGridView();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recSsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.myTable)).BeginInit();
            this.SuspendLayout();
            // 
            // myTable
            // 
            this.myTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumber,
            this.checkIN,
            this.checkOut,
            this.totalPayment,
            this.customerSsn,
            this.recSsc});
            this.myTable.Location = new System.Drawing.Point(1, 184);
            this.myTable.Name = "myTable";
            this.myTable.RowHeadersWidth = 51;
            this.myTable.RowTemplate.Height = 24;
            this.myTable.Size = new System.Drawing.Size(776, 150);
            this.myTable.TabIndex = 0;
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.MinimumWidth = 6;
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Width = 125;
            // 
            // checkIN
            // 
            this.checkIN.HeaderText = "Check IN";
            this.checkIN.MinimumWidth = 6;
            this.checkIN.Name = "checkIN";
            this.checkIN.Width = 125;
            // 
            // checkOut
            // 
            this.checkOut.HeaderText = "Check Out";
            this.checkOut.MinimumWidth = 6;
            this.checkOut.Name = "checkOut";
            this.checkOut.Width = 125;
            // 
            // totalPayment
            // 
            this.totalPayment.HeaderText = "Total Payment";
            this.totalPayment.MinimumWidth = 6;
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Width = 125;
            // 
            // customerSsn
            // 
            this.customerSsn.HeaderText = "Customer SSN";
            this.customerSsn.MinimumWidth = 6;
            this.customerSsn.Name = "customerSsn";
            this.customerSsn.Width = 125;
            // 
            // recSsc
            // 
            this.recSsc.HeaderText = "REC SSN";
            this.recSsc.MinimumWidth = 6;
            this.recSsc.Name = "recSsc";
            this.recSsc.Width = 125;
            // 
            // DataHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.myTable);
            this.Name = "DataHistory";
            this.Text = "DataHistorycs";
            this.Load += new System.EventHandler(this.DataHistorycs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView myTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recSsc;
    }
}