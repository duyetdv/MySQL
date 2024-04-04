namespace TinhHoaHong
{
    partial class TinhHoaHong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhHoaHong));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTroGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThayPin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoaHong = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnHH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChenhGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGiaBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(98, 13);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 22);
            this.txtGiaBan.TabIndex = 1;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá nhập:";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(98, 64);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.txtGiaNhap.TabIndex = 2;
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trợ giá:";
            // 
            // txtTroGia
            // 
            this.txtTroGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroGia.Location = new System.Drawing.Point(98, 90);
            this.txtTroGia.Name = "txtTroGia";
            this.txtTroGia.Size = new System.Drawing.Size(100, 22);
            this.txtTroGia.TabIndex = 3;
            this.txtTroGia.TextChanged += new System.EventHandler(this.txtTroGia_TextChanged);
            this.txtTroGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTroGia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thay Pin:";
            // 
            // txtThayPin
            // 
            this.txtThayPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThayPin.Location = new System.Drawing.Point(98, 116);
            this.txtThayPin.Name = "txtThayPin";
            this.txtThayPin.Size = new System.Drawing.Size(100, 22);
            this.txtThayPin.TabIndex = 4;
            this.txtThayPin.TextChanged += new System.EventHandler(this.txtThayPin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hoa Hồng:";
            // 
            // txtHoaHong
            // 
            this.txtHoaHong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaHong.Location = new System.Drawing.Point(98, 169);
            this.txtHoaHong.Name = "txtHoaHong";
            this.txtHoaHong.ReadOnly = true;
            this.txtHoaHong.Size = new System.Drawing.Size(100, 22);
            this.txtHoaHong.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(98, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkBox1_KeyPress);
            // 
            // btnHH
            // 
            this.btnHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHH.Image = ((System.Drawing.Image)(resources.GetObject("btnHH.Image")));
            this.btnHH.Location = new System.Drawing.Point(204, 169);
            this.btnHH.Name = "btnHH";
            this.btnHH.Size = new System.Drawing.Size(31, 24);
            this.btnHH.TabIndex = 8;
            this.btnHH.UseVisualStyleBackColor = false;
            this.btnHH.Click += new System.EventHandler(this.btnHH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chênh giá:";
            // 
            // txtChenhGia
            // 
            this.txtChenhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChenhGia.Location = new System.Drawing.Point(98, 141);
            this.txtChenhGia.Name = "txtChenhGia";
            this.txtChenhGia.ReadOnly = true;
            this.txtChenhGia.Size = new System.Drawing.Size(100, 22);
            this.txtChenhGia.TabIndex = 4;
            this.txtChenhGia.TextChanged += new System.EventHandler(this.txtThayPin_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá bán/1.1";
            // 
            // btnGiaBan
            // 
            this.btnGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGiaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaBan.Image")));
            this.btnGiaBan.Location = new System.Drawing.Point(204, 13);
            this.btnGiaBan.Name = "btnGiaBan";
            this.btnGiaBan.Size = new System.Drawing.Size(31, 24);
            this.btnGiaBan.TabIndex = 8;
            this.btnGiaBan.UseVisualStyleBackColor = false;
            this.btnGiaBan.Click += new System.EventHandler(this.btnGiaBan_Click);
            // 
            // TinhHoaHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 200);
            this.Controls.Add(this.btnGiaBan);
            this.Controls.Add(this.btnHH);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtHoaHong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChenhGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtThayPin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTroGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TinhHoaHong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Hoa Hồng";
            this.Load += new System.EventHandler(this.TinhHoaHong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTroGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThayPin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoaHong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChenhGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGiaBan;
    }
}

