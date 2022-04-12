namespace Final_643450324_6_e
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pro4 = new System.Windows.Forms.Button();
            this.pro3 = new System.Windows.Forms.Button();
            this.pro2 = new System.Windows.Forms.Button();
            this.pro1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ราคา = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button11 = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 356);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pro4);
            this.groupBox1.Controls.Add(this.pro3);
            this.groupBox1.Controls.Add(this.pro2);
            this.groupBox1.Controls.Add(this.pro1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 337);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สินค้า";
            // 
            // pro4
            // 
            this.pro4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4.Location = new System.Drawing.Point(255, 195);
            this.pro4.Name = "pro4";
            this.pro4.Size = new System.Drawing.Size(206, 124);
            this.pro4.TabIndex = 14;
            this.pro4.Text = "MONITOR 24\'";
            this.pro4.UseVisualStyleBackColor = true;
            this.pro4.Click += new System.EventHandler(this.pro4_Click);
            // 
            // pro3
            // 
            this.pro3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro3.Location = new System.Drawing.Point(19, 51);
            this.pro3.Name = "pro3";
            this.pro3.Size = new System.Drawing.Size(193, 124);
            this.pro3.TabIndex = 13;
            this.pro3.Text = "VGA RTX3080";
            this.pro3.UseVisualStyleBackColor = true;
            this.pro3.Click += new System.EventHandler(this.pro3_Click);
            // 
            // pro2
            // 
            this.pro2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro2.Location = new System.Drawing.Point(255, 51);
            this.pro2.Name = "pro2";
            this.pro2.Size = new System.Drawing.Size(206, 124);
            this.pro2.TabIndex = 12;
            this.pro2.Text = "INTEL core i9";
            this.pro2.UseVisualStyleBackColor = true;
            this.pro2.Click += new System.EventHandler(this.pro2_Click);
            // 
            // pro1
            // 
            this.pro1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro1.Location = new System.Drawing.Point(19, 195);
            this.pro1.Name = "pro1";
            this.pro1.Size = new System.Drawing.Size(193, 124);
            this.pro1.TabIndex = 11;
            this.pro1.Text = "AMD RYZEN 5400";
            this.pro1.UseVisualStyleBackColor = true;
            this.pro1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ราคา});
            this.dataGridView1.Location = new System.Drawing.Point(533, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(527, 356);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "รายการ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "จำนวน";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // ราคา
            // 
            this.ราคา.HeaderText = "ราคา";
            this.ราคา.MinimumWidth = 6;
            this.ราคา.Name = "ราคา";
            this.ราคา.Width = 125;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(729, 466);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(119, 67);
            this.button11.TabIndex = 10;
            this.button11.Text = "ยืนยัน";
            this.button11.UseVisualStyleBackColor = true;
            //this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(716, 391);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(145, 57);
            this.tbTotal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(553, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "รวมทั้งสิน";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button pro4;
        private Button pro3;
        private Button pro2;
        private Button pro1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn ราคา;
        private Button button11;
        private TextBox tbTotal;
        private Label label1;
    }
}