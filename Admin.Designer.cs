
namespace Hotel_Reservation_Project
{
    partial class Admin
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
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.titleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataHistory = new System.Windows.Forms.Button();
            this.RoomReport_button = new System.Windows.Forms.Button();
            this.transactionReport_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.BackColor = System.Drawing.Color.Coral;
            this.buttonAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTransaction.Location = new System.Drawing.Point(95, 129);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(178, 96);
            this.buttonAddTransaction.TabIndex = 5;
            this.buttonAddTransaction.Text = "Add Room";
            this.buttonAddTransaction.UseVisualStyleBackColor = false;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.Location = new System.Drawing.Point(325, 33);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(316, 38);
            this.titleName.TabIndex = 7;
            this.titleName.Text = "Name of receiptionst";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            // 
            // dataHistory
            // 
            this.dataHistory.BackColor = System.Drawing.Color.Coral;
            this.dataHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataHistory.Location = new System.Drawing.Point(516, 129);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.Size = new System.Drawing.Size(178, 96);
            this.dataHistory.TabIndex = 8;
            this.dataHistory.Text = "Data History";
            this.dataHistory.UseVisualStyleBackColor = false;
            this.dataHistory.Click += new System.EventHandler(this.dataHistory_Click);
            // 
            // RoomReport_button
            // 
            this.RoomReport_button.BackColor = System.Drawing.Color.Coral;
            this.RoomReport_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomReport_button.Location = new System.Drawing.Point(95, 289);
            this.RoomReport_button.Name = "RoomReport_button";
            this.RoomReport_button.Size = new System.Drawing.Size(178, 96);
            this.RoomReport_button.TabIndex = 9;
            this.RoomReport_button.Text = "Room Report";
            this.RoomReport_button.UseVisualStyleBackColor = false;
            this.RoomReport_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionReport_button
            // 
            this.transactionReport_button.BackColor = System.Drawing.Color.Coral;
            this.transactionReport_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionReport_button.Location = new System.Drawing.Point(516, 279);
            this.transactionReport_button.Name = "transactionReport_button";
            this.transactionReport_button.Size = new System.Drawing.Size(178, 96);
            this.transactionReport_button.TabIndex = 10;
            this.transactionReport_button.Text = "Transaction Report";
            this.transactionReport_button.UseVisualStyleBackColor = false;
            this.transactionReport_button.Click += new System.EventHandler(this.transactionReport_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Coral;
            this.edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(313, 201);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(178, 96);
            this.edit_button.TabIndex = 11;
            this.edit_button.Text = "Edit Data";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.transactionReport_button);
            this.Controls.Add(this.RoomReport_button);
            this.Controls.Add(this.dataHistory);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTransaction);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dataHistory;
        private System.Windows.Forms.Button RoomReport_button;
        private System.Windows.Forms.Button transactionReport_button;
        private System.Windows.Forms.Button edit_button;
    }
}