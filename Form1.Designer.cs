namespace CSharp_listbos
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblquanlinhanvien = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(79, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 49);
            this.txtName.TabIndex = 11;
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(79, 265);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(530, 147);
            this.lbsketqua.TabIndex = 10;
            this.lbsketqua.SelectedIndexChanged += new System.EventHandler(this.lbsketqua_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(439, 175);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(170, 56);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhâp họ và tên ";
            // 
            // lblquanlinhanvien
            // 
            this.lblquanlinhanvien.AutoSize = true;
            this.lblquanlinhanvien.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquanlinhanvien.Location = new System.Drawing.Point(193, 42);
            this.lblquanlinhanvien.Name = "lblquanlinhanvien";
            this.lblquanlinhanvien.Size = new System.Drawing.Size(396, 46);
            this.lblquanlinhanvien.TabIndex = 7;
            this.lblquanlinhanvien.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(618, 175);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(170, 56);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(618, 265);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(170, 56);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblquanlinhanvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lbsketqua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblquanlinhanvien;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
    }
}

