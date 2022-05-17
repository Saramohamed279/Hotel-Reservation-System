
namespace Hotel_Reservation_Project
{
    partial class AddTransaction
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkin_Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPayment = new System.Windows.Forms.TextBox();
            this.checkoutText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbm_ssn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.paymentType = new System.Windows.Forms.ComboBox();
            this.numberOfNights = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbm_room = new System.Windows.Forms.ComboBox();
            this.cbm_type = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PricePerNight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Coral;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(440, 367);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(257, 44);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkin_Text
            // 
            this.checkin_Text.Enabled = false;
            this.checkin_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkin_Text.Location = new System.Drawing.Point(175, 146);
            this.checkin_Text.Name = "checkin_Text";
            this.checkin_Text.Size = new System.Drawing.Size(194, 27);
            this.checkin_Text.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date checkIN";
            // 
            // totalPayment
            // 
            this.totalPayment.BackColor = System.Drawing.SystemColors.HighlightText;
            this.totalPayment.Enabled = false;
            this.totalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayment.Location = new System.Drawing.Point(536, 294);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(194, 30);
            this.totalPayment.TabIndex = 17;
            // 
            // checkoutText
            // 
            this.checkoutText.Enabled = false;
            this.checkoutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutText.Location = new System.Drawing.Point(536, 146);
            this.checkoutText.Name = "checkoutText";
            this.checkoutText.Size = new System.Drawing.Size(194, 27);
            this.checkoutText.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date checkOut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer SSN";
            // 
            // cbm_ssn
            // 
            this.cbm_ssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_ssn.FormattingEnabled = true;
            this.cbm_ssn.Location = new System.Drawing.Point(177, 220);
            this.cbm_ssn.Name = "cbm_ssn";
            this.cbm_ssn.Size = new System.Drawing.Size(192, 28);
            this.cbm_ssn.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "payment Type";
            // 
            // paymentType
            // 
            this.paymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType.FormattingEnabled = true;
            this.paymentType.Location = new System.Drawing.Point(175, 367);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(194, 28);
            this.paymentType.TabIndex = 24;
            // 
            // numberOfNights
            // 
            this.numberOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfNights.Location = new System.Drawing.Point(178, 291);
            this.numberOfNights.Name = "numberOfNights";
            this.numberOfNights.Size = new System.Drawing.Size(191, 30);
            this.numberOfNights.TabIndex = 26;
            this.numberOfNights.TextChanged += new System.EventHandler(this.numberOfNights_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "number of nights";
            // 
            // cbm_room
            // 
            this.cbm_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_room.FormattingEnabled = true;
            this.cbm_room.Location = new System.Drawing.Point(536, 66);
            this.cbm_room.Name = "cbm_room";
            this.cbm_room.Size = new System.Drawing.Size(192, 28);
            this.cbm_room.TabIndex = 27;
            this.cbm_room.SelectedIndexChanged += new System.EventHandler(this.cbm_room_SelectedIndexChanged_1);
            // 
            // cbm_type
            // 
            this.cbm_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_type.FormattingEnabled = true;
            this.cbm_type.Location = new System.Drawing.Point(175, 71);
            this.cbm_type.Name = "cbm_type";
            this.cbm_type.Size = new System.Drawing.Size(194, 28);
            this.cbm_type.TabIndex = 29;
            this.cbm_type.SelectedIndexChanged += new System.EventHandler(this.cbm_type_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "type of Room";
            // 
            // PricePerNight
            // 
            this.PricePerNight.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PricePerNight.Enabled = false;
            this.PricePerNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePerNight.Location = new System.Drawing.Point(536, 220);
            this.PricePerNight.Name = "PricePerNight";
            this.PricePerNight.Size = new System.Drawing.Size(194, 30);
            this.PricePerNight.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Price per Night";
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PricePerNight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbm_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbm_room);
            this.Controls.Add(this.numberOfNights);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbm_ssn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkin_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPayment);
            this.Controls.Add(this.checkoutText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox checkin_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalPayment;
        private System.Windows.Forms.TextBox checkoutText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbm_ssn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox paymentType;
        private System.Windows.Forms.TextBox numberOfNights;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbm_room;
        private System.Windows.Forms.ComboBox cbm_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PricePerNight;
        private System.Windows.Forms.Label label9;
    }
}