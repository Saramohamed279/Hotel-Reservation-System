
namespace Hotel_Reservation_Project
{
    partial class showAvailableRoom
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
            this.cbm_AvaRoom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pricePerType = new System.Windows.Forms.TextBox();
            this.roomType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbm_AvaRoom
            // 
            this.cbm_AvaRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_AvaRoom.FormattingEnabled = true;
            this.cbm_AvaRoom.Location = new System.Drawing.Point(175, 78);
            this.cbm_AvaRoom.Name = "cbm_AvaRoom";
            this.cbm_AvaRoom.Size = new System.Drawing.Size(192, 28);
            this.cbm_AvaRoom.TabIndex = 24;
            this.cbm_AvaRoom.SelectedIndexChanged += new System.EventHandler(this.cbm_ssn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Available Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "price per night";
            // 
            // pricePerType
            // 
            this.pricePerType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pricePerType.Enabled = false;
            this.pricePerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerType.Location = new System.Drawing.Point(173, 164);
            this.pricePerType.Name = "pricePerType";
            this.pricePerType.Size = new System.Drawing.Size(194, 30);
            this.pricePerType.TabIndex = 27;
            // 
            // roomType
            // 
            this.roomType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.roomType.Enabled = false;
            this.roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.Location = new System.Drawing.Point(173, 249);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(194, 30);
            this.roomType.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Room Type";
            // 
            // showAvailableRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pricePerType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbm_AvaRoom);
            this.Controls.Add(this.label1);
            this.Name = "showAvailableRoom";
            this.Text = "showAvailableRoom";
            this.Load += new System.EventHandler(this.showAvailableRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbm_AvaRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pricePerType;
        private System.Windows.Forms.TextBox roomType;
        private System.Windows.Forms.Label label3;
    }
}