using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        private int viTriPT;
        private int viTriCTPT;

        bool option;

        public frmTraSach()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            if (lkupMaTheDG.EditValue == null)
            {
                return;
            }
            string maTheDG = lkupMaTheDG.EditValue.ToString();

            bdsCTPhieuMuon.DataSource = Data.Instance.ChiTietPhieuMuon
                    .Where(t => t.PhieuMuon.MaTheDocGia == maTheDG && t.TrangThai == false).ToList();

            TheDocGia the = Data.Instance.TheDocGia.Find(maTheDG);
            txtHoTenDG.Text = the.DocGia.Ho + " " + the.DocGia.Ten;
            txtMaDG.Text = the.MaDG;
            bdsPhieuTra.DataSource = the.PhieuTra.ToList();
            if (bdsPhieuTra.Count > 0)
            {
                PhieuTra phieu = bdsPhieuTra.Current as PhieuTra;
                bdsCTPhieu.DataSource = phieu.ChiTietPhieuTra.ToList();
            }
            else
            {
                bdsCTPhieu.DataSource = null;
            }
            ChangeUpdateMode_PhieuMuon(false);
            ChangeUpdateMode_CTPM(false);
        }

        private void ChangeUpdateMode_PhieuMuon(bool isUpdating)
        {
            btnThemPhieu.Enabled = txtViTriHocPhi.Enabled = !isUpdating && (lkupMaTheDG.EditValue != null);
            btnTaiPhieu.Enabled = btnThoat.Enabled = !isUpdating;
            btnXoaPhieu.Enabled = btnSuaPhieu.Enabled = !isUpdating && (bdsPhieuTra.Count > 0);
            btnGhiPhieu.Enabled = btnHuyPhieu.Enabled = isUpdating;
            gbHocPhi.Enabled = isUpdating;

            gbTheDocGia.Enabled = gcHocPhi.Enabled = nvgtCTPhieu.Enabled = gcCTHocPhi.Enabled = !isUpdating;
        }

        private void ChangeUpdateMode_CTPM(bool isUpdating)
        {
            btnTaiCTPhieu.Enabled = btnThoat.Enabled = txtViTriCTDHP.Enabled = !isUpdating;
            btnThemCTPhieu.Enabled = !isUpdating && (bdsPhieuTra.Count > 0);
            btnXoaCTPhieu.Enabled = !isUpdating && (bdsCTPhieu.Count > 0);
            btnGhiCTPhieu.Enabled = btnHuyCTPhieu.Enabled = isUpdating;
            gbCTPM.Enabled = isUpdating;

            gbTheDocGia.Enabled = gcCTHocPhi.Enabled = nvgtPhieu.Enabled = gcHocPhi.Enabled = !isUpdating;
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            bdsTheDocGia.DataSource = Data.Instance.TheDocGia.Where(t => t.TrangThai == true).ToList();
            ChangeUpdateMode_PhieuMuon(false);
            ChangeUpdateMode_CTPM(false);
        }

        private void lkupMaTheDG_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvCTPM_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsPhieuTra.Count > 0)
            {
                PhieuTra phieu = bdsPhieuTra.Current as PhieuTra;
                bdsCTPhieu.DataSource = phieu.ChiTietPhieuTra.ToList();
            }
        }

        private void gvCTPM_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "Sach.TuaSach.HinhAnh");
                if (string.IsNullOrEmpty(fileName))
                {
                    e.Value = null;
                    return;
                }
                if (!ImageData.Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper
                            .FindingFileName(Application.StartupPath, ImageData.ImageDir + fileName, false);
                        img = Image.FromFile(filePath);
                    }
                    catch
                    {
                    }
                    ImageData.Images.Add(fileName, img);
                }
                e.Value = ImageData.Images[fileName];
            }
        }

        private void gvlkSach_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "Sach.TuaSach.HinhAnh");
                if (string.IsNullOrEmpty(fileName))
                {
                    e.Value = null;
                    return;
                }
                if (!ImageData.Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper
                            .FindingFileName(Application.StartupPath, ImageData.ImageDir + fileName, false);
                        img = Image.FromFile(filePath);
                    }
                    catch
                    {
                    }
                    ImageData.Images.Add(fileName, img);
                }
                e.Value = ImageData.Images[fileName];
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            option = true;
            viTriPT = bdsPhieuTra.Position;
            bdsPhieuTra.AddNew();
            txtMaPhieu.Text = CodeGenerator.SinhMaPhieuTra();
            bdsTheDocGia.EndEdit();
            ChangeUpdateMode_PhieuMuon(true);
        }

        private void btnXoaPM_Click(object sender, EventArgs e)
        {
            PhieuTra phieu = bdsPhieuTra.Current as PhieuTra;
            if (phieu.ChiTietPhieuTra.Count > 0)
            {
                XDialog.Error("Không thể xóa phiếu trả này vì phiếu trả này đã có chi tiết!");
                return;
            }

            if (XDialog.Confirm("Bạn có chắc muốn xóa phiếu trả này không?") != DialogResult.OK) return;

            int position = bdsPhieuTra.Position;
            try
            {
                Data.Instance.PhieuTra.Remove(phieu);
                Data.Instance.SaveChanges();
                LoadData();
                XDialog.Inform("Đã xóa phiếu trả!");
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi xóa phiếu trả này!\n" + ex.Message);
                LoadData();
            }
            bdsPhieuTra.Position = position;
            //ChangeUpdateMode_PhieuMuon(false);
            //ChangeUpdateMode_CTPM(false);
        }

        private void btnSuaPM_Click(object sender, EventArgs e)
        {
            option = false;
            viTriPT = bdsPhieuTra.Position;
            ChangeUpdateMode_PhieuMuon(true);
        }

        private void btnGhiPM_Click(object sender, EventArgs e)
        {
            if (dateNgayTra.Text.Trim() == "")
            {
                XDialog.Error("Bạn chưa chọn ngày trả!");
                return;
            }
            string maPhieuTra = txtMaPhieu.Text.Trim();
            string maTheDG = lkupMaTheDG.EditValue.ToString();
            DateTime ngayTra = dateNgayTra.DateTime;

            if (XDialog.Confirm("Bạn có chắc muốn ghi phiếu trả này không?") != DialogResult.OK) return;

            try
            {
                if (option)
                {
                    PhieuTra phieu = new PhieuTra()
                    {
                        MaPhieuTra = maPhieuTra,
                        MaTheDG = maTheDG,
                        NgayTra = ngayTra,
                        MaNV = Program.id
                    };
                    Data.Instance.PhieuTra.Add(phieu);
                }
                else
                {
                    PhieuTra phieu = Data.Instance.PhieuTra.Find(maPhieuTra);
                    phieu.NgayTra = ngayTra;
                }
                Data.Instance.SaveChanges();
                LoadData();
                XDialog.Inform("Đã ghi thông tin phiếu trả vào cơ sở dữ liệu!");
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi ghi phiếu trả!\n" + ex.Message);
                LoadData();
            }
            //ChangeUpdateMode_PhieuMuon(false);
            //ChangeUpdateMode_CTPM(false);
        }

        private void btnHuyPM_Click(object sender, EventArgs e)
        {
            if (option)
            {
                bdsPhieuTra.RemoveCurrent();
            }
            bdsPhieuTra.CancelEdit();
            bdsPhieuTra.Position = viTriPT;
            ChangeUpdateMode_PhieuMuon(false);
        }

        private void btnTaiPM_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateNgayMuon_Enter(object sender, EventArgs e)
        {
            dateNgayTra.Properties.MaxValue = DateTime.Now;
        }

        private void btnThemCTPM_Click(object sender, EventArgs e)
        {
            option = true;
            viTriCTPT = bdsCTPhieu.Position;
            viTriPT = bdsPhieuTra.Position;
            bdsCTPhieu.AddNew();
            ChangeUpdateMode_CTPM(true);
        }

        private void btnXoaCTPM_Click(object sender, EventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa chi tiết phiếu trả này không?") != DialogResult.OK) return;

            int position = bdsCTPhieu.Position;
            viTriPT = bdsPhieuTra.Position;
            try
            {
                
                ChiTietPhieuTra chiTiet = bdsCTPhieu.Current as ChiTietPhieuTra;
                ChiTietPhieuMuon ctpm = chiTiet.PhieuMuon.ChiTietPhieuMuon
                    .FirstOrDefault(p => p.MaSach == chiTiet.MaSach);
                // Đặt lại trạng thái của chi tiết phiếu mượn chưa trả và trạng thái sách là đang mượn
                ctpm.TrangThai = false;
                ctpm.Sach.TrangThai = false;
                Data.Instance.ChiTietPhieuTra.Remove(chiTiet);
                Data.Instance.SaveChanges();
                LoadData();
                bdsPhieuTra.Position = viTriPT;
                XDialog.Inform("Đã xóa chi tiết phiếu trả!");
            }
            catch (Exception ex)
            {
                bdsPhieuTra.Position = viTriPT;
                XDialog.Error("Đã xảy ra lỗi khi xóa chi tiết phiếu trả này!\n" + ex.Message);
                LoadData();
                bdsCTPhieu.Position = position;
                return;
            }

            if (bdsCTPhieu.Count == 0) btnXoaCTPhieu.Enabled = false;
        }

        private void btnGhiCTPM_Click(object sender, EventArgs e)
        {
            if (lkCTPM.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn chi tiết phiếu mượn sách để trả!");
                return;
            }
            int maSach = int.Parse(lkCTPM.EditValue.ToString());
            string maPM = (lkCTPM.GetSelectedDataRow() as ChiTietPhieuMuon).MaPhieuMuon;
            Sach book = Data.Instance.Sach.Find(maSach);
            ChiTietPhieuMuon ctpm = Data.Instance.ChiTietPhieuMuon.Find(maPM, maSach);

            if (XDialog.Confirm("Bạn có chắc muốn ghi chi tiết phiếu trả này không?") != DialogResult.OK) return;

            PhieuTra phieu = bdsPhieuTra.Current as PhieuTra;
            string maPhieu = phieu.MaPhieuTra;

            try
            {
                if (option)
                {
                    ChiTietPhieuTra chiTiet = new ChiTietPhieuTra()
                    {
                        MaPhieuTra = maPhieu,
                        MaSach = maSach,
                        MaPhieuMuon = maPM,
                        SoTienPhat = 0,
                        GhiChu = ""
                    };
                    Data.Instance.ChiTietPhieuTra.Add(chiTiet);
                    ctpm.TrangThai = true;
                    book.TrangThai = true;
                }
                Data.Instance.SaveChanges();
                LoadData();
                bdsPhieuTra.Position = viTriPT;
                XDialog.Inform("Đã ghi thông tin chi tiết phiếu trả vào cơ sở dữ liệu!");

            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi ghi chi tiết phiếu trả!\n" + ex.Message);
                LoadData();
            }
            //ChangeUpdateMode_CTPM(false);
        }

        private void btnHuyCTPM_Click(object sender, EventArgs e)
        {
            bdsCTPhieu.CancelEdit();
            bdsCTPhieu.Position = viTriCTPT;
            ChangeUpdateMode_CTPM(false);
        }

        private void btnTaiCTPM_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}