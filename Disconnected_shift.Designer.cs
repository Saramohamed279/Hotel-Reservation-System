
namespace Hotel_Reservation_Project
{
    partial class Disconnected_shift
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
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.radMornningShift = new System.Windows.Forms.RadioButton();
            this.radNightShift = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(906, 58);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(101, 46);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(837, 588);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(149, 46);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // radMornningShift
            // 
            this.radMornningShift.AutoSize = true;
            this.radMornningShift.Location = new System.Drawing.Point(16, 36);
            this.radMornningShift.Name = "radMornningShift";
            this.radMornningShift.Size = new System.Drawing.Size(120, 21);
            this.radMornningShift.TabIndex = 4;
            this.radMornningShift.TabStop = true;
            this.radMornningShift.Text = "Mornning Shift";
            this.radMornningShift.UseVisualStyleBackColor = true;
            this.radMornningShift.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radNightShift
            // 
            this.radNightShift.AutoSize = true;
            this.radNightShift.Location = new System.Drawing.Point(16, 78);
            this.radNightShift.Name = "radNightShift";
            this.radNightShift.Size = new System.Drawing.Size(94, 21);
            this.radNightShift.TabIndex = 5;
            this.radNightShift.TabStop = true;
            this.radNightShift.Text = "Night Shift";
            this.radNightShift.UseVisualStyleBackColor = true;
            this.radNightShift.CheckedChanged += new System.EventHandler(this.radNightShift_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMornningShift);
            this.groupBox1.Controls.Add(this.radNightShift);
            this.groupBox1.Location = new System.Drawing.Point(552, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Disconnected_shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 638);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Name = "Disconnected_shift";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.RadioButton radMornningShift;
        private System.Windows.Forms.RadioButton radNightShift;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}