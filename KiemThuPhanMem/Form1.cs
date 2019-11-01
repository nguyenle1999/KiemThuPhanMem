using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Thongtindatvexe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.Items.Add("Nam");
            cbDiemDi.Items.Add("TP HCM");
            cbDiemDi.Items.Add("Đà Lạt");
            cbDiemDi.Items.Add("Hà Nội");
            cbDiemDi.Items.Add("Đà Nẵng");
            cbDiemDen.Items.Add("TP HCM");
            cbDiemDen.Items.Add("Đà Lạt");
            cbDiemDen.Items.Add("Hà Nội");
            cbDiemDen.Items.Add("Đà Nẵng");
            cbNgayDi.Items.Add("2/11/2019");
            cbNgayDi.Items.Add("3/11/2019");
            cbNgayDi.Items.Add("4/11/2019");
            cbNgayDi.Items.Add("5/11/2019");
            cbGioDi.Items.Add("9h");
            cbGioDi.Items.Add("10h");
            cbGioDi.Items.Add("11h");
            cbGioDi.Items.Add("12h");
            cbSoGhe.Items.Add("1A");
            cbSoGhe.Items.Add("2A");
            cbSoGhe.Items.Add("2B");
            cbSoGhe.Items.Add("1B");
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            Nhapdulieu();
            txtHoTen.Text = "";
            cbGioiTinh.Text = "";
            dtNgaySinh.Text = "";
            txtSdt.Text = "";
            cbDiemDi.Text = "";
            cbDiemDen.Text = "";
            cbNgayDi.Text = "";
            cbGioDi.Text = "";
            cbSoGhe.Text = "";
            txtGhiChu.Text = "";
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string HoTen, GioiTinh, DiemDi, DiemDen, GioDi, SoGhe, GhiChu, NgayDi;
        public int SDT;
        public DateTime NgaySinh;
        private void Nhapdulieu()
        {
            Class1.ketnoi();
            Class1.ThucThiLenh("INSERT INTO THONG_TIN (HoTen,GioiTinh,NgaySinh,SDT,DiemDi,DiemDen,NgayDi,GioDi,SoGhe,GhiChu) VALUES('" + HoTen + "', '" + GioiTinh + "', '" + NgaySinh + "', " + SDT + ", '" + DiemDi + "', '" + DiemDen + "', '" + NgayDi + "', '" + GioDi + "', '" + SoGhe + "', '" + GhiChu + "')");
            MessageBox.Show("Đặt vé thành công");
        }
        private void LayDuLieu()
        {
            HoTen = txtHoTen.Text;
            GioiTinh = cbGioiTinh.Text;
            NgaySinh = dtNgaySinh.Value.Date;
            SDT = Int32.Parse(txtSdt.Text.ToString());
            DiemDi = cbDiemDi.Text;
            DiemDen = cbDiemDen.Text;
            NgayDi = cbNgayDi.Text;
            GioDi = cbGioDi.Text;
            SoGhe = cbSoGhe.Text;
            GhiChu = txtGhiChu.Text;
        }
        private void lblGioDi_Click(object sender, EventArgs e)
        {

        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
