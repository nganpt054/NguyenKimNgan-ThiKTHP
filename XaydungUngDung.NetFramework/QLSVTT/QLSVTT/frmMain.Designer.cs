
namespace QLSVTT
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnBoMon = new System.Windows.Forms.Button();
            this.btnHSGV = new System.Windows.Forms.Button();
            this.btnHSSV = new System.Windows.Forms.Button();
            this.btnSVTT = new System.Windows.Forms.Button();
            this.btnQLGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "Quan ly he thong";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(105, 22);
            this.toolStripLabel2.Text = "Quan ly danh muc";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(145, 22);
            this.toolStripLabel3.Text = "Quan ly sinh vien thuc tap";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(153, 22);
            this.toolStripLabel4.Text = "Quan ly giang vien thuc tap";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBangDiem);
            this.groupBox1.Controls.Add(this.btnLop);
            this.groupBox1.Controls.Add(this.btnBoMon);
            this.groupBox1.Controls.Add(this.btnHSGV);
            this.groupBox1.Controls.Add(this.btnHSSV);
            this.groupBox1.Controls.Add(this.btnSVTT);
            this.groupBox1.Controls.Add(this.btnQLGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý hệ thống";
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangDiem.Location = new System.Drawing.Point(6, 349);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(181, 35);
            this.btnBangDiem.TabIndex = 6;
            this.btnBangDiem.Text = "Bảng điểm";
            this.btnBangDiem.UseVisualStyleBackColor = true;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // btnLop
            // 
            this.btnLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLop.Location = new System.Drawing.Point(6, 299);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(181, 35);
            this.btnLop.TabIndex = 5;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnBoMon
            // 
            this.btnBoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoMon.Location = new System.Drawing.Point(6, 245);
            this.btnBoMon.Name = "btnBoMon";
            this.btnBoMon.Size = new System.Drawing.Size(181, 35);
            this.btnBoMon.TabIndex = 4;
            this.btnBoMon.Text = "Bộ môn";
            this.btnBoMon.UseVisualStyleBackColor = true;
            this.btnBoMon.Click += new System.EventHandler(this.btnBoMon_Click);
            // 
            // btnHSGV
            // 
            this.btnHSGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSGV.Location = new System.Drawing.Point(6, 195);
            this.btnHSGV.Name = "btnHSGV";
            this.btnHSGV.Size = new System.Drawing.Size(181, 35);
            this.btnHSGV.TabIndex = 3;
            this.btnHSGV.Text = "Hồ sơ giảng viên";
            this.btnHSGV.UseVisualStyleBackColor = true;
            this.btnHSGV.Click += new System.EventHandler(this.btnHSGV_Click);
            // 
            // btnHSSV
            // 
            this.btnHSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHSSV.Location = new System.Drawing.Point(6, 142);
            this.btnHSSV.Name = "btnHSSV";
            this.btnHSSV.Size = new System.Drawing.Size(181, 35);
            this.btnHSSV.TabIndex = 2;
            this.btnHSSV.Text = "Hồ sơ sinh viên";
            this.btnHSSV.UseVisualStyleBackColor = true;
            this.btnHSSV.Click += new System.EventHandler(this.btnHSSV_Click);
            // 
            // btnSVTT
            // 
            this.btnSVTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSVTT.Location = new System.Drawing.Point(6, 92);
            this.btnSVTT.Name = "btnSVTT";
            this.btnSVTT.Size = new System.Drawing.Size(181, 35);
            this.btnSVTT.TabIndex = 1;
            this.btnSVTT.Text = "Quản lý sinh viên thực tập";
            this.btnSVTT.UseVisualStyleBackColor = true;
            this.btnSVTT.Click += new System.EventHandler(this.btnSVTT_Click);
            // 
            // btnQLGV
            // 
            this.btnQLGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLGV.Location = new System.Drawing.Point(6, 42);
            this.btnQLGV.Name = "btnQLGV";
            this.btnQLGV.Size = new System.Drawing.Size(181, 35);
            this.btnQLGV.TabIndex = 0;
            this.btnQLGV.Text = "Quản lý giảng viên thực tập";
            this.btnQLGV.UseVisualStyleBackColor = true;
            this.btnQLGV.Click += new System.EventHandler(this.btnQLGV_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Quản lý sinh viên thực tập";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBangDiem;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnBoMon;
        private System.Windows.Forms.Button btnHSGV;
        private System.Windows.Forms.Button btnHSSV;
        private System.Windows.Forms.Button btnSVTT;
        private System.Windows.Forms.Button btnQLGV;
    }
}

