
namespace Hotel_Reservation_Project
{
    partial class REC
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.titleName = new System.Windows.Forms.Label();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.showAvailableRooms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.Color.Coral;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(469, 146);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(169, 94);
            this.buttonAddCustomer.TabIndex = 2;
            this.buttonAddCustomer.Text = "Add Costumer";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.Location = new System.Drawing.Point(322, 31);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(316, 38);
            this.titleName.TabIndex = 3;
            this.titleName.Text = "Name of receiptionst";
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.BackColor = System.Drawing.Color.Coral;
            this.buttonAddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTransaction.Location = new System.Drawing.Point(142, 146);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(178, 96);
            this.buttonAddTransaction.TabIndex = 4;
            this.buttonAddTransaction.Text = "Add Transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = false;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // showAvailableRooms
            // 
            this.showAvailableRooms.BackColor = System.Drawing.Color.Coral;
            this.showAvailableRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAvailableRooms.Location = new System.Drawing.Point(142, 298);
            this.showAvailableRooms.Name = "showAvailableRooms";
            this.showAvailableRooms.Size = new System.Drawing.Size(178, 96);
            this.showAvailableRooms.TabIndex = 5;
            this.showAvailableRooms.Text = "Show available room";
            this.showAvailableRooms.UseVisualStyleBackColor = false;
            this.showAvailableRooms.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 96);
            this.button1.TabIndex = 6;
            this.button1.Text = "Costumer Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // REC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showAvailableRooms);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.label1);
            this.Name = "REC";
            this.Text = "REC";
            this.Load += new System.EventHandler(this.REC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Button showAvailableRooms;
        private System.Windows.Forms.Button button1;
    }
}