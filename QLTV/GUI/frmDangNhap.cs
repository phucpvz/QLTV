﻿using DevExpress.XtraEditors;
using QLTV.DAO;
using QLTV.Entity;
using QLTV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void ckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = !ckShowPassword.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                XDialog.Error("Bạn chưa nhập username!");
                return;
            }
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                XDialog.Error("Bạn chưa nhập password!");
                return;
            }
            bool isEmployee = (bool)rgRole.EditValue;
            if (isEmployee)
            {
                TaiKhoanNV account = Data.Instance.TaiKhoanNV.
                    FirstOrDefault(t => t.TenDangNhap == username && t.MatKhau == password);
                if (account == null)
                {
                    XDialog.Error("Tên đăng nhập hoặc mật khẩu của bạn không chính xác!");
                    return;
                }
                NhanVien emp = Data.Instance.NhanVien.FirstOrDefault(n => n.MaNV == account.MaNV);
                Program.id = emp.MaNV;
                Program.frmChinh.PhanQuyen(emp);
            }
            else
            {
                TaiKhoanDG account = Data.Instance.TaiKhoanDG.
                    FirstOrDefault(t => t.TenDangNhap == username && t.MatKhau == password);
                if (account == null)
                {
                    XDialog.Error("Tên đăng nhập hoặc mật khẩu của bạn không chính xác!");
                    return;
                }
                int soTheHopLe = account.DocGia.TheDocGia
                    .Where(t => t.TrangThai == true).ToList().Count;
                if (soTheHopLe == 0)
                {
                    XDialog.Error("Tài khoản của bạn không thể đăng nhập vì bạn không có thẻ độc giả hợp lệ!");
                    return;
                }
                DocGia reader = Data.Instance.DocGia.FirstOrDefault(n => n.MaDG == account.MaDG);
                Program.id = reader.MaDG;
                Program.frmChinh.HienThi(reader);
            }
            Close();
        }
    }
}