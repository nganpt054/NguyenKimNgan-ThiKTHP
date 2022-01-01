using QLSVTT.BLL;
using QLSVTT.DAL;
using QLSVTT.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVTT
{
    public partial class frmSVTT : Form
    {
        public frmSVTT()
        {
            InitializeComponent();
            NapSinhvien();
        }
        void NapSinhvien()
        {
            var ls = SinhVienBLL.GetListViewModel();
            SinhvienbindingSource.DataSource = ls;
            dataGridView1.DataSource = SinhvienbindingSource;
        }
        public void get()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var rows = model.SinhViens.Select(row => row);
            SinhvienbindingSource.DataSource = rows;
            dataGridView1.DataSource = SinhvienbindingSource;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var sinhVien = SinhvienbindingSource.Current as SinhvienViewModel;
            if(sinhVien != null)
            {
                SinhVienBLL.Delete(sinhVien.TenSV);
                MessageBox.Show("Xóa thành công", "Thông báo");
                NapSinhvien();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new ThemSV();
            var rs = f.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapSinhvien();
            }
        }
        int i;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            i = dataGridView1.CurrentRow.Index;
            lbl.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtMSV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenSV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtns.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtdc.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtsdt.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSV.Text) || string.IsNullOrEmpty(txtTenSV.Text) || string.IsNullOrEmpty(txtns.Text) || string.IsNullOrEmpty(txtdc.Text) || string.IsNullOrEmpty(txtsdt.Text) || string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa");
            }
            else
            {
                QLSinhVienModel model = new QLSinhVienModel();
                var lh = model.SinhViens.Where(t => t.TenSV == lbl.Text).FirstOrDefault();
                lh.MaSV = txtMSV.Text;
                lh.TenSV = txtTenSV.Text;
                lh.NoiSinh = txtns.Text;
                lh.DiaChi = txtdc.Text;
                lh.SDT = txtsdt.Text;
                lh.Email = txtemail.Text;
                model.SinhViens.Add(lh);
                model.SaveChanges();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Cập nhật thành công");
                NapSinhvien();
            }
        }
    }
}
