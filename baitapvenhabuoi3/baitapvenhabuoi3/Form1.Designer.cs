namespace baitapvenhabuoi3
{
    partial class Form1
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
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_mssv = new System.Windows.Forms.Label();
            this.lb_cccd = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_mssv = new System.Windows.Forms.TextBox();
            this.tb_cccd = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lb_Id = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.lsvSinhVien = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(19, 89);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(95, 24);
            this.lb_ten.TabIndex = 0;
            this.lb_ten.Text = "Họ và tên:";
            // 
            // lb_mssv
            // 
            this.lb_mssv.AutoSize = true;
            this.lb_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mssv.Location = new System.Drawing.Point(19, 140);
            this.lb_mssv.Name = "lb_mssv";
            this.lb_mssv.Size = new System.Drawing.Size(146, 24);
            this.lb_mssv.TabIndex = 1;
            this.lb_mssv.Text = "Mã số sinh viên:";
            // 
            // lb_cccd
            // 
            this.lb_cccd.AutoSize = true;
            this.lb_cccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cccd.Location = new System.Drawing.Point(20, 197);
            this.lb_cccd.Name = "lb_cccd";
            this.lb_cccd.Size = new System.Drawing.Size(67, 24);
            this.lb_cccd.TabIndex = 2;
            this.lb_cccd.Text = "CCCD:";
            // 
            // tb_ten
            // 
            this.tb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Location = new System.Drawing.Point(181, 91);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(236, 28);
            this.tb_ten.TabIndex = 3;
            // 
            // tb_mssv
            // 
            this.tb_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mssv.Location = new System.Drawing.Point(181, 140);
            this.tb_mssv.Name = "tb_mssv";
            this.tb_mssv.Size = new System.Drawing.Size(236, 28);
            this.tb_mssv.TabIndex = 3;
            // 
            // tb_cccd
            // 
            this.tb_cccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cccd.Location = new System.Drawing.Point(181, 193);
            this.tb_cccd.Name = "tb_cccd";
            this.tb_cccd.Size = new System.Drawing.Size(236, 28);
            this.tb_cccd.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(12, 340);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(102, 41);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(169, 340);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(102, 41);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(315, 340);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(102, 41);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.Location = new System.Drawing.Point(20, 40);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(30, 24);
            this.lb_Id.TabIndex = 0;
            this.lb_Id.Text = "Id:";
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(181, 40);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(236, 28);
            this.tb_Id.TabIndex = 3;
            // 
            // lsvSinhVien
            // 
            this.lsvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTen,
            this.colMssv,
            this.colCCCD});
            this.lsvSinhVien.HideSelection = false;
            this.lsvSinhVien.Location = new System.Drawing.Point(455, 40);
            this.lsvSinhVien.Name = "lsvSinhVien";
            this.lsvSinhVien.Size = new System.Drawing.Size(435, 363);
            this.lsvSinhVien.TabIndex = 6;
            this.lsvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lsvSinhVien.View = System.Windows.Forms.View.Details;
            this.lsvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lsvSinhVien_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colTen
            // 
            this.colTen.Text = "Họ và tên";
            // 
            // colMssv
            // 
            this.colMssv.Text = "Mã số sinh viên";
            // 
            // colCCCD
            // 
            this.colCCCD.Text = "CCCD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.lsvSinhVien);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tb_cccd);
            this.Controls.Add(this.tb_mssv);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.lb_cccd);
            this.Controls.Add(this.lb_mssv);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.lb_ten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_mssv;
        private System.Windows.Forms.Label lb_cccd;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_mssv;
        private System.Windows.Forms.TextBox tb_cccd;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.ListView lsvSinhVien;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colMssv;
        private System.Windows.Forms.ColumnHeader colCCCD;
    }
}

