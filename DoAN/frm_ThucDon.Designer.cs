namespace DoAN
{
    partial class frm_ThucDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mathucdon = new System.Windows.Forms.TextBox();
            this.txt_tenthucdon = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cbb_ghichu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dem = new System.Windows.Forms.Button();
            this.txt_dem = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewthucdon = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_tenHinh = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthucdon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thực Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thực Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi Chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // txt_mathucdon
            // 
            this.txt_mathucdon.Location = new System.Drawing.Point(225, 31);
            this.txt_mathucdon.Name = "txt_mathucdon";
            this.txt_mathucdon.Size = new System.Drawing.Size(229, 22);
            this.txt_mathucdon.TabIndex = 5;
            // 
            // txt_tenthucdon
            // 
            this.txt_tenthucdon.Location = new System.Drawing.Point(225, 94);
            this.txt_tenthucdon.Name = "txt_tenthucdon";
            this.txt_tenthucdon.Size = new System.Drawing.Size(229, 22);
            this.txt_tenthucdon.TabIndex = 6;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(225, 167);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(229, 22);
            this.txt_soluong.TabIndex = 7;
            // 
            // cbb_ghichu
            // 
            this.cbb_ghichu.FormattingEnabled = true;
            this.cbb_ghichu.Items.AddRange(new object[] {
            "Ít Đường",
            "Nhiều Đường",
            "Nhiều Đá",
            "Ít Đá"});
            this.cbb_ghichu.Location = new System.Drawing.Point(225, 245);
            this.cbb_ghichu.Name = "cbb_ghichu";
            this.cbb_ghichu.Size = new System.Drawing.Size(229, 24);
            this.cbb_ghichu.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(173, 390);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 39);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(306, 390);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 39);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dem
            // 
            this.btn_dem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dem.Location = new System.Drawing.Point(57, 307);
            this.btn_dem.Name = "btn_dem";
            this.btn_dem.Size = new System.Drawing.Size(75, 39);
            this.btn_dem.TabIndex = 13;
            this.btn_dem.Text = "Đếm";
            this.btn_dem.UseVisualStyleBackColor = true;
            this.btn_dem.Click += new System.EventHandler(this.btn_dem_Click);
            // 
            // txt_dem
            // 
            this.txt_dem.Location = new System.Drawing.Point(225, 315);
            this.txt_dem.Name = "txt_dem";
            this.txt_dem.Size = new System.Drawing.Size(229, 22);
            this.txt_dem.TabIndex = 14;
            // 
            // dataGridViewthucdon
            // 
            this.dataGridViewthucdon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthucdon.Location = new System.Drawing.Point(846, 12);
            this.dataGridViewthucdon.Name = "dataGridViewthucdon";
            this.dataGridViewthucdon.RowHeadersWidth = 51;
            this.dataGridViewthucdon.RowTemplate.Height = 24;
            this.dataGridViewthucdon.Size = new System.Drawing.Size(793, 500);
            this.dataGridViewthucdon.TabIndex = 16;
            this.dataGridViewthucdon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewthucdon_CellClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::DoAN.Properties.Resources.picturebox;
            this.pictureBox.Location = new System.Drawing.Point(460, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(340, 405);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(46, 390);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 39);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(77, 449);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 39);
            this.btn_load.TabIndex = 17;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_tenHinh
            // 
            this.txt_tenHinh.Location = new System.Drawing.Point(515, 457);
            this.txt_tenHinh.Name = "txt_tenHinh";
            this.txt_tenHinh.Size = new System.Drawing.Size(229, 22);
            this.txt_tenHinh.TabIndex = 18;
            this.txt_tenHinh.Text = "trasua.jpg";
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(198, 449);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 39);
            this.btn_tim.TabIndex = 19;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(291, 457);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(114, 22);
            this.txt_tim.TabIndex = 20;
            // 
            // frm_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 559);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tenHinh);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridViewthucdon);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txt_dem);
            this.Controls.Add(this.btn_dem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbb_ghichu);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenthucdon);
            this.Controls.Add(this.txt_mathucdon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThucDon";
            this.Text = "frm_ThucDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthucdon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mathucdon;
        private System.Windows.Forms.TextBox txt_tenthucdon;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.ComboBox cbb_ghichu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dem;
        private System.Windows.Forms.TextBox txt_dem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewthucdon;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txt_tenHinh;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
    }
}