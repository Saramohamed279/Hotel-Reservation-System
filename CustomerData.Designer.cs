
namespace Hotel_Reservation_Project
{
    partial class CustomerData
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
            this.cbm_snn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secondName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbm_snn
            // 
            this.cbm_snn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_snn.FormattingEnabled = true;
            this.cbm_snn.Location = new System.Drawing.Point(338, 129);
            this.cbm_snn.Name = "cbm_snn";
            this.cbm_snn.Size = new System.Drawing.Size(194, 28);
            this.cbm_snn.TabIndex = 31;
            this.cbm_snn.SelectedIndexChanged += new System.EventHandler(this.cbm_snn_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(204, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Customer SNN";
            // 
            // firstName
            // 
            this.firstName.Enabled = false;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(191, 213);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(194, 27);
            this.firstName.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "First name";
            // 
            // secondName
            // 
            this.secondName.Enabled = false;
            this.secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondName.Location = new System.Drawing.Point(552, 213);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(194, 27);
            this.secondName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Second Name";
            // 
            // address
            // 
            this.address.Enabled = false;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(191, 272);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(194, 27);
            this.address.TabIndex = 39;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(28, 272);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(71, 20);
            this.lab.TabIndex = 38;
            this.lab.Text = "Address";
            // 
            // phone
            // 
            this.phone.Enabled = false;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(552, 272);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(194, 27);
            this.phone.TabIndex = 37;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(404, 272);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(56, 20);
            this.lable.TabIndex = 36;
            this.lable.Text = "Phone";
            // 
            // CustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbm_snn);
            this.Controls.Add(this.label8);
            this.Name = "CustomerData";
            this.Text = "CustomerData";
            this.Load += new System.EventHandler(this.CustomerData_Load);
            this.DoubleClick += new System.EventHandler(this.CustomerData_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbm_snn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label lable;
    }
}