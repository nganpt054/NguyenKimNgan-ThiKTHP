using QLSVTT.DAL;
using QLSVTT.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSVTT
{
    public partial class ThemSV : Form
    {
        SinhvienViewModel sinhVien;
        public ThemSV()
        {
            InitializeComponent();
            this.sinhVien = sinhVien;
            if (sinhVien == null)
            {
                this.Text = "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật dữ liệu";
                txtTenSV.Text = sinhVien.TenSV;
                txtns.Text = sinhVien.NoiSinh;
                txtdc.Text = sinhVien.DiaChi;
                txtsdt.Text = sinhVien.SDT;
                txtemail.Text = sinhVien.Email;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                errorProvider1.Clear();
                var sinhVien = txtTenSV.Text;
                var sinhVien2 = txtns.Text;
                var sinhVien3 = txtdc.Text;
                var sinhVien4 = txtsdt.Text;
                var sinhVien5 = txtemail.Text;
                QLSinhVienModel model = new QLSinhVienModel();
                var lh = model.SinhViens.Where(t => t.TenSV == sinhVien.ToString()).FirstOrDefault();
                if (lh != null)
                {
                    MessageBox.Show(" sinh viên đã tồn tại ", "Chú ý");
                    return;
                }
                else
                {
                    lh = new SinhVien
                    {
                        TenSV = sinhVien,
                        NoiSinh = sinhVien2,
                        DiaChi = sinhVien3,
                        SDT = sinhVien4,
                        Email = sinhVien5

                    };
                    model.SinhViens.Add(lh);
                    model.SaveChanges();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show(" thêm thành công");
                }
            
        }
    }

}

