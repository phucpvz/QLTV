
namespace QLTV.GUI
{
    partial class frmTraSach
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
            System.Windows.Forms.Label nGAYDONGLabel;
            System.Windows.Forms.Label maPhieuMuonLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraSach));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcCTHocPhi = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPhieu = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhieuMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTienPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nvgtCTPhieu = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtViTriCTDHP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemCTPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnXoaCTPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnGhiCTPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnHuyCTPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnTaiCTPhieu = new System.Windows.Forms.ToolStripButton();
            this.gbHocPhi = new DevExpress.XtraEditors.GroupControl();
            this.dateNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.bdsPhieuTra = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuTra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nvgtPhieu = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.txtViTriHocPhi = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnXoaPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnSuaPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnGhiPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnHuyPhieu = new System.Windows.Forms.ToolStripButton();
            this.btnTaiPhieu = new System.Windows.Forms.ToolStripButton();
            this.gbTheDocGia = new DevExpress.XtraEditors.GroupControl();
            this.lkupMaTheDG = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsTheDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.txtMaDG = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.txtHoTenDG = new DevExpress.XtraEditors.TextEdit();
            this.gbCTPM = new DevExpress.XtraEditors.GroupControl();
            this.lkCTPM = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bdsCTPhieuMuon = new System.Windows.Forms.BindingSource(this.components);
            this.gvlkSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuMuon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSach1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKeSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuMuon1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuMuon2 = new DevExpress.XtraGrid.Columns.GridColumn();
            nGAYDONGLabel = new System.Windows.Forms.Label();
            maPhieuMuonLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtCTPhieu)).BeginInit();
            this.nvgtCTPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbHocPhi)).BeginInit();
            this.gbHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtPhieu)).BeginInit();
            this.nvgtPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTheDocGia)).BeginInit();
            this.gbTheDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMaTheDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPM)).BeginInit();
            this.gbCTPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCTPM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlkSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYDONGLabel
            // 
            nGAYDONGLabel.AutoSize = true;
            nGAYDONGLabel.Location = new System.Drawing.Point(84, 54);
            nGAYDONGLabel.Name = "nGAYDONGLabel";
            nGAYDONGLabel.Size = new System.Drawing.Size(43, 17);
            nGAYDONGLabel.TabIndex = 0;
            nGAYDONGLabel.Text = "Sách:";
            // 
            // maPhieuMuonLabel
            // 
            maPhieuMuonLabel.AutoSize = true;
            maPhieuMuonLabel.Location = new System.Drawing.Point(22, 52);
            maPhieuMuonLabel.Name = "maPhieuMuonLabel";
            maPhieuMuonLabel.Size = new System.Drawing.Size(88, 17);
            maPhieuMuonLabel.TabIndex = 0;
            maPhieuMuonLabel.Text = "Mã phiếu trả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(400, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 17);
            label2.TabIndex = 2;
            label2.Text = "Ngày trả:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThoat});
            this.barManager1.MainMenu = this.bar6;
            this.barManager1.MaxItemId = 1;
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.FloatLocation = new System.Drawing.Point(459, 537);
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 0;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1139, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 859);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1139, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 829);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1139, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 829);
            // 
            // gcCTHocPhi
            // 
            this.gcCTHocPhi.DataSource = this.bdsCTPhieu;
            this.gcCTHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTHocPhi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTHocPhi.Location = new System.Drawing.Point(0, 460);
            this.gcCTHocPhi.MainView = this.gvCTPM;
            this.gcCTHocPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcCTHocPhi.MenuManager = this.barManager1;
            this.gcCTHocPhi.Name = "gcCTHocPhi";
            this.gcCTHocPhi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gcCTHocPhi.Size = new System.Drawing.Size(1139, 225);
            this.gcCTHocPhi.TabIndex = 45;
            this.gcCTHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPM});
            // 
            // bdsCTPhieu
            // 
            this.bdsCTPhieu.DataSource = typeof(QLTV.Entity.ChiTietPhieuTra);
            // 
            // gvCTPM
            // 
            this.gvCTPM.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvCTPM.Appearance.ViewCaption.Options.UseFont = true;
            this.gvCTPM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSach,
            this.colSach,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.colMaPhieuMuon,
            this.colSoTienPhat,
            this.colGhiChu});
            this.gvCTPM.DetailHeight = 431;
            this.gvCTPM.GridControl = this.gcCTHocPhi;
            this.gvCTPM.Name = "gvCTPM";
            this.gvCTPM.OptionsBehavior.Editable = false;
            this.gvCTPM.OptionsView.ShowViewCaption = true;
            this.gvCTPM.RowHeight = 50;
            this.gvCTPM.ViewCaption = "CHI TIẾT PHIẾU TRẢ";
            this.gvCTPM.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCTPM_FocusedRowChanged);
            this.gvCTPM.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvCTPM_CustomUnboundColumnData);
            // 
            // colMaSach
            // 
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.MinWidth = 25;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 0;
            this.colMaSach.Width = 98;
            // 
            // colSach
            // 
            this.colSach.Caption = "Mã ISBN";
            this.colSach.FieldName = "Sach.MaISBN";
            this.colSach.MinWidth = 25;
            this.colSach.Name = "colSach";
            this.colSach.Visible = true;
            this.colSach.VisibleIndex = 1;
            this.colSach.Width = 98;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Hình ảnh";
            this.gridColumn2.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn2.FieldName = "Image";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 98;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sách";
            this.gridColumn1.FieldName = "Sach.TuaSach.TenSach";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "HinhAnh";
            this.gridColumn3.FieldName = "Sach.TuaSach.HinhAnh";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chiều dài";
            this.gridColumn4.FieldName = "Sach.TuaSach.ChieuDai";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 71;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chiều rộng";
            this.gridColumn5.FieldName = "Sach.TuaSach.ChieuRong";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 83;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Chất liệu giấy";
            this.gridColumn6.FieldName = "Sach.TuaSach.ChatLieuGiay";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 98;
            // 
            // colMaPhieuMuon
            // 
            this.colMaPhieuMuon.FieldName = "MaPhieuMuon";
            this.colMaPhieuMuon.MinWidth = 25;
            this.colMaPhieuMuon.Name = "colMaPhieuMuon";
            this.colMaPhieuMuon.Visible = true;
            this.colMaPhieuMuon.VisibleIndex = 7;
            this.colMaPhieuMuon.Width = 105;
            // 
            // colSoTienPhat
            // 
            this.colSoTienPhat.FieldName = "SoTienPhat";
            this.colSoTienPhat.MinWidth = 25;
            this.colSoTienPhat.Name = "colSoTienPhat";
            this.colSoTienPhat.Visible = true;
            this.colSoTienPhat.VisibleIndex = 8;
            this.colSoTienPhat.Width = 85;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MinWidth = 25;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            this.colGhiChu.Width = 183;
            // 
            // nvgtCTPhieu
            // 
            this.nvgtCTPhieu.AddNewItem = null;
            this.nvgtCTPhieu.CountItem = this.toolStripLabel1;
            this.nvgtCTPhieu.DeleteItem = null;
            this.nvgtCTPhieu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nvgtCTPhieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.txtViTriCTDHP,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.btnThemCTPhieu,
            this.btnXoaCTPhieu,
            this.btnGhiCTPhieu,
            this.btnHuyCTPhieu,
            this.btnTaiCTPhieu});
            this.nvgtCTPhieu.Location = new System.Drawing.Point(0, 433);
            this.nvgtCTPhieu.MoveFirstItem = this.toolStripButton4;
            this.nvgtCTPhieu.MoveLastItem = this.toolStripButton7;
            this.nvgtCTPhieu.MoveNextItem = this.toolStripButton6;
            this.nvgtCTPhieu.MovePreviousItem = this.toolStripButton5;
            this.nvgtCTPhieu.Name = "nvgtCTPhieu";
            this.nvgtCTPhieu.PositionItem = this.txtViTriCTDHP;
            this.nvgtCTPhieu.Size = new System.Drawing.Size(1139, 27);
            this.nvgtCTPhieu.TabIndex = 46;
            this.nvgtCTPhieu.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 24);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Move first";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // txtViTriCTDHP
            // 
            this.txtViTriCTDHP.AccessibleName = "Position";
            this.txtViTriCTDHP.AutoSize = false;
            this.txtViTriCTDHP.Name = "txtViTriCTDHP";
            this.txtViTriCTDHP.Size = new System.Drawing.Size(58, 27);
            this.txtViTriCTDHP.Text = "0";
            this.txtViTriCTDHP.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "Move next";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThemCTPhieu
            // 
            this.btnThemCTPhieu.Image = global::QLTV.Properties.Resources.btnThem_ImageOptions_Image;
            this.btnThemCTPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemCTPhieu.Name = "btnThemCTPhieu";
            this.btnThemCTPhieu.Size = new System.Drawing.Size(70, 24);
            this.btnThemCTPhieu.Text = "Thêm";
            this.btnThemCTPhieu.Click += new System.EventHandler(this.btnThemCTPM_Click);
            // 
            // btnXoaCTPhieu
            // 
            this.btnXoaCTPhieu.Image = global::QLTV.Properties.Resources.btnXoa_ImageOptions_Image;
            this.btnXoaCTPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaCTPhieu.Name = "btnXoaCTPhieu";
            this.btnXoaCTPhieu.Size = new System.Drawing.Size(59, 24);
            this.btnXoaCTPhieu.Text = "Xóa";
            this.btnXoaCTPhieu.Click += new System.EventHandler(this.btnXoaCTPM_Click);
            // 
            // btnGhiCTPhieu
            // 
            this.btnGhiCTPhieu.Enabled = false;
            this.btnGhiCTPhieu.Image = global::QLTV.Properties.Resources.btnGhi_ImageOptions_Image;
            this.btnGhiCTPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhiCTPhieu.Name = "btnGhiCTPhieu";
            this.btnGhiCTPhieu.Size = new System.Drawing.Size(55, 24);
            this.btnGhiCTPhieu.Text = "Ghi";
            this.btnGhiCTPhieu.Click += new System.EventHandler(this.btnGhiCTPM_Click);
            // 
            // btnHuyCTPhieu
            // 
            this.btnHuyCTPhieu.Enabled = false;
            this.btnHuyCTPhieu.Image = global::QLTV.Properties.Resources.btnHuy_ImageOptions_Image;
            this.btnHuyCTPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyCTPhieu.Name = "btnHuyCTPhieu";
            this.btnHuyCTPhieu.Size = new System.Drawing.Size(59, 24);
            this.btnHuyCTPhieu.Text = "Hủy";
            this.btnHuyCTPhieu.Click += new System.EventHandler(this.btnHuyCTPM_Click);
            // 
            // btnTaiCTPhieu
            // 
            this.btnTaiCTPhieu.Image = global::QLTV.Properties.Resources.btnReload_ImageOptions_Image;
            this.btnTaiCTPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiCTPhieu.Name = "btnTaiCTPhieu";
            this.btnTaiCTPhieu.Size = new System.Drawing.Size(73, 24);
            this.btnTaiCTPhieu.Text = "Tải lại";
            this.btnTaiCTPhieu.Click += new System.EventHandler(this.btnTaiCTPM_Click);
            // 
            // gbHocPhi
            // 
            this.gbHocPhi.Controls.Add(label2);
            this.gbHocPhi.Controls.Add(this.dateNgayTra);
            this.gbHocPhi.Controls.Add(maPhieuMuonLabel);
            this.gbHocPhi.Controls.Add(this.txtMaPhieu);
            this.gbHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHocPhi.Enabled = false;
            this.gbHocPhi.Location = new System.Drawing.Point(0, 339);
            this.gbHocPhi.Margin = new System.Windows.Forms.Padding(5);
            this.gbHocPhi.Name = "gbHocPhi";
            this.gbHocPhi.Size = new System.Drawing.Size(1139, 94);
            this.gbHocPhi.TabIndex = 44;
            this.gbHocPhi.Text = "Phiếu trả";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuTra, "NgayTra", true));
            this.dateNgayTra.EditValue = null;
            this.dateNgayTra.Location = new System.Drawing.Point(484, 49);
            this.dateNgayTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayTra.MenuManager = this.barManager1;
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayTra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayTra.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayTra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayTra.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayTra.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayTra.Size = new System.Drawing.Size(203, 22);
            this.dateNgayTra.TabIndex = 3;
            this.dateNgayTra.Enter += new System.EventHandler(this.dateNgayMuon_Enter);
            // 
            // bdsPhieuTra
            // 
            this.bdsPhieuTra.AllowNew = true;
            this.bdsPhieuTra.DataSource = typeof(QLTV.Entity.PhieuTra);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuTra, "MaPhieuTra", true));
            this.txtMaPhieu.Location = new System.Drawing.Point(133, 49);
            this.txtMaPhieu.MenuManager = this.barManager1;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Properties.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(203, 22);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsPhieuTra;
            this.gcHocPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcHocPhi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.gcHocPhi.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcHocPhi.Location = new System.Drawing.Point(0, 147);
            this.gcHocPhi.MainView = this.gvPhieuTra;
            this.gcHocPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(1139, 192);
            this.gcHocPhi.TabIndex = 43;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuTra});
            // 
            // gvPhieuTra
            // 
            this.gvPhieuTra.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvPhieuTra.Appearance.ViewCaption.Options.UseFont = true;
            this.gvPhieuTra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuTra,
            this.colNgayTra,
            this.colMaNV,
            this.colNhanVien});
            this.gvPhieuTra.DetailHeight = 431;
            this.gvPhieuTra.GridControl = this.gcHocPhi;
            this.gvPhieuTra.Name = "gvPhieuTra";
            this.gvPhieuTra.OptionsBehavior.Editable = false;
            this.gvPhieuTra.OptionsView.ShowViewCaption = true;
            this.gvPhieuTra.ViewCaption = "PHIẾU TRẢ";
            // 
            // colMaPhieuTra
            // 
            this.colMaPhieuTra.FieldName = "MaPhieuTra";
            this.colMaPhieuTra.MinWidth = 25;
            this.colMaPhieuTra.Name = "colMaPhieuTra";
            this.colMaPhieuTra.Visible = true;
            this.colMaPhieuTra.VisibleIndex = 0;
            this.colMaPhieuTra.Width = 94;
            // 
            // colNgayTra
            // 
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.MinWidth = 25;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 1;
            this.colNgayTra.Width = 94;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 25;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            this.colMaNV.Width = 94;
            // 
            // colNhanVien
            // 
            this.colNhanVien.FieldName = "HoTenNhanVien";
            this.colNhanVien.MinWidth = 25;
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.UnboundExpression = "NhanVien.Ho + \' \' + NhanVien.Ten";
            this.colNhanVien.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colNhanVien.Visible = true;
            this.colNhanVien.VisibleIndex = 3;
            this.colNhanVien.Width = 94;
            // 
            // nvgtPhieu
            // 
            this.nvgtPhieu.AddNewItem = null;
            this.nvgtPhieu.BindingSource = this.bdsPhieuTra;
            this.nvgtPhieu.CountItem = this.bindingNavigatorCountItem;
            this.nvgtPhieu.DeleteItem = null;
            this.nvgtPhieu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nvgtPhieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.txtViTriHocPhi,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnThemPhieu,
            this.btnXoaPhieu,
            this.btnSuaPhieu,
            this.btnGhiPhieu,
            this.btnHuyPhieu,
            this.btnTaiPhieu});
            this.nvgtPhieu.Location = new System.Drawing.Point(0, 120);
            this.nvgtPhieu.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgtPhieu.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgtPhieu.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgtPhieu.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgtPhieu.Name = "nvgtPhieu";
            this.nvgtPhieu.PositionItem = this.txtViTriHocPhi;
            this.nvgtPhieu.Size = new System.Drawing.Size(1139, 27);
            this.nvgtPhieu.TabIndex = 42;
            this.nvgtPhieu.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // txtViTriHocPhi
            // 
            this.txtViTriHocPhi.AccessibleName = "Position";
            this.txtViTriHocPhi.AutoSize = false;
            this.txtViTriHocPhi.Name = "txtViTriHocPhi";
            this.txtViTriHocPhi.Size = new System.Drawing.Size(58, 27);
            this.txtViTriHocPhi.Text = "0";
            this.txtViTriHocPhi.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Image = global::QLTV.Properties.Resources.btnThem_ImageOptions_Image;
            this.btnThemPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(70, 24);
            this.btnThemPhieu.Text = "Thêm";
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPM_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Image = global::QLTV.Properties.Resources.btnXoa_ImageOptions_Image;
            this.btnXoaPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(59, 24);
            this.btnXoaPhieu.Text = "Xóa";
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPM_Click);
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.Image = global::QLTV.Properties.Resources.btnSua_ImageOptions_Image;
            this.btnSuaPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(58, 24);
            this.btnSuaPhieu.Text = "Sửa";
            this.btnSuaPhieu.Click += new System.EventHandler(this.btnSuaPM_Click);
            // 
            // btnGhiPhieu
            // 
            this.btnGhiPhieu.Enabled = false;
            this.btnGhiPhieu.Image = global::QLTV.Properties.Resources.btnGhi_ImageOptions_Image;
            this.btnGhiPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGhiPhieu.Name = "btnGhiPhieu";
            this.btnGhiPhieu.Size = new System.Drawing.Size(55, 24);
            this.btnGhiPhieu.Text = "Ghi";
            this.btnGhiPhieu.Click += new System.EventHandler(this.btnGhiPM_Click);
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.Enabled = false;
            this.btnHuyPhieu.Image = global::QLTV.Properties.Resources.btnHuy_ImageOptions_Image;
            this.btnHuyPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(59, 24);
            this.btnHuyPhieu.Text = "Hủy";
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPM_Click);
            // 
            // btnTaiPhieu
            // 
            this.btnTaiPhieu.Image = global::QLTV.Properties.Resources.btnReload_ImageOptions_Image;
            this.btnTaiPhieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiPhieu.Name = "btnTaiPhieu";
            this.btnTaiPhieu.Size = new System.Drawing.Size(73, 24);
            this.btnTaiPhieu.Text = "Tải lại";
            this.btnTaiPhieu.Click += new System.EventHandler(this.btnTaiPM_Click);
            // 
            // gbTheDocGia
            // 
            this.gbTheDocGia.Controls.Add(this.lkupMaTheDG);
            this.gbTheDocGia.Controls.Add(this.mAMHLabel);
            this.gbTheDocGia.Controls.Add(this.txtMaDG);
            this.gbTheDocGia.Controls.Add(this.label1);
            this.gbTheDocGia.Controls.Add(this.tENMHLabel);
            this.gbTheDocGia.Controls.Add(this.txtHoTenDG);
            this.gbTheDocGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTheDocGia.Location = new System.Drawing.Point(0, 30);
            this.gbTheDocGia.Margin = new System.Windows.Forms.Padding(5);
            this.gbTheDocGia.Name = "gbTheDocGia";
            this.gbTheDocGia.Size = new System.Drawing.Size(1139, 90);
            this.gbTheDocGia.TabIndex = 41;
            this.gbTheDocGia.Text = "Thông tin thẻ độc giả";
            // 
            // lkupMaTheDG
            // 
            this.lkupMaTheDG.Location = new System.Drawing.Point(162, 45);
            this.lkupMaTheDG.Margin = new System.Windows.Forms.Padding(5);
            this.lkupMaTheDG.Name = "lkupMaTheDG";
            this.lkupMaTheDG.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkupMaTheDG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupMaTheDG.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTheDG", "Ma The DG", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDG", "Ma DG", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgayLapThe", "Ngay Lap The", 88, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgayHetHan", "Ngay Het Han", 87, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoLuongMuonToiDa", "So Luong Muon Toi Da", 139, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrangThai", "Trang Thai", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkupMaTheDG.Properties.DataSource = this.bdsTheDocGia;
            this.lkupMaTheDG.Properties.DisplayMember = "MaTheDG";
            this.lkupMaTheDG.Properties.NullText = "Chọn mã thẻ độc giả ...";
            this.lkupMaTheDG.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkupMaTheDG.Properties.ValueMember = "MaTheDG";
            this.lkupMaTheDG.Size = new System.Drawing.Size(237, 22);
            this.lkupMaTheDG.TabIndex = 4;
            this.lkupMaTheDG.EditValueChanged += new System.EventHandler(this.lkupMaTheDG_EditValueChanged);
            // 
            // bdsTheDocGia
            // 
            this.bdsTheDocGia.DataSource = typeof(QLTV.Entity.TheDocGia);
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Location = new System.Drawing.Point(50, 48);
            this.mAMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(102, 17);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "Mã thẻ độc giả:";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(948, 45);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Properties.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(177, 22);
            this.txtMaDG.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã độc giả:";
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Location = new System.Drawing.Point(430, 48);
            this.tENMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(102, 17);
            this.tENMHLabel.TabIndex = 2;
            this.tENMHLabel.Text = "Họ tên độc giả:";
            // 
            // txtHoTenDG
            // 
            this.txtHoTenDG.Location = new System.Drawing.Point(551, 44);
            this.txtHoTenDG.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTenDG.Name = "txtHoTenDG";
            this.txtHoTenDG.Properties.ReadOnly = true;
            this.txtHoTenDG.Size = new System.Drawing.Size(281, 22);
            this.txtHoTenDG.TabIndex = 3;
            // 
            // gbCTPM
            // 
            this.gbCTPM.Controls.Add(nGAYDONGLabel);
            this.gbCTPM.Controls.Add(this.lkCTPM);
            this.gbCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPM.Location = new System.Drawing.Point(0, 685);
            this.gbCTPM.Margin = new System.Windows.Forms.Padding(5);
            this.gbCTPM.Name = "gbCTPM";
            this.gbCTPM.Size = new System.Drawing.Size(1139, 174);
            this.gbCTPM.TabIndex = 51;
            this.gbCTPM.Text = "Chi tiết phiếu trả";
            // 
            // lkCTPM
            // 
            this.lkCTPM.Location = new System.Drawing.Point(133, 51);
            this.lkCTPM.MenuManager = this.barManager1;
            this.lkCTPM.Name = "lkCTPM";
            this.lkCTPM.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkCTPM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCTPM.Properties.DataSource = this.bdsCTPhieuMuon;
            this.lkCTPM.Properties.DisplayMember = "Sach.TuaSach.TenSach";
            this.lkCTPM.Properties.NullText = "Chọn sách đã mượn ...";
            this.lkCTPM.Properties.PopupView = this.gvlkSach;
            this.lkCTPM.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit2});
            this.lkCTPM.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.lkCTPM.Properties.ValueMember = "MaSach";
            this.lkCTPM.Size = new System.Drawing.Size(816, 22);
            this.lkCTPM.TabIndex = 6;
            // 
            // bdsCTPhieuMuon
            // 
            this.bdsCTPhieuMuon.DataSource = typeof(QLTV.Entity.ChiTietPhieuMuon);
            // 
            // gvlkSach
            // 
            this.gvlkSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuMuon1,
            this.colMaSach1,
            this.colMaISBN,
            this.gridColumn8,
            this.gridColumn9,
            this.colKeSach,
            this.gridColumn7,
            this.colTrangThai1,
            this.colTuaSach,
            this.colPhieuMuon,
            this.colPhieuMuon1,
            this.colPhieuMuon2});
            this.gvlkSach.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvlkSach.Name = "gvlkSach";
            this.gvlkSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvlkSach.OptionsView.ShowGroupPanel = false;
            this.gvlkSach.RowHeight = 50;
            this.gvlkSach.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvlkSach_CustomUnboundColumnData);
            // 
            // colMaPhieuMuon1
            // 
            this.colMaPhieuMuon1.FieldName = "MaPhieuMuon";
            this.colMaPhieuMuon1.Name = "colMaPhieuMuon1";
            this.colMaPhieuMuon1.Visible = true;
            this.colMaPhieuMuon1.VisibleIndex = 0;
            this.colMaPhieuMuon1.Width = 98;
            // 
            // colMaSach1
            // 
            this.colMaSach1.FieldName = "MaSach";
            this.colMaSach1.Name = "colMaSach1";
            this.colMaSach1.Visible = true;
            this.colMaSach1.VisibleIndex = 1;
            this.colMaSach1.Width = 98;
            // 
            // colMaISBN
            // 
            this.colMaISBN.FieldName = "Sach.MaISBN";
            this.colMaISBN.Name = "colMaISBN";
            this.colMaISBN.Visible = true;
            this.colMaISBN.VisibleIndex = 2;
            this.colMaISBN.Width = 98;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Hình ảnh";
            this.gridColumn8.ColumnEdit = this.repositoryItemPictureEdit2;
            this.gridColumn8.FieldName = "Image";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 98;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên sách";
            this.gridColumn9.FieldName = "Sach.TuaSach.TenSach";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 98;
            // 
            // colKeSach
            // 
            this.colKeSach.Caption = "Tên khu";
            this.colKeSach.FieldName = "Sach.KeSach.Khu.TenKhu";
            this.colKeSach.Name = "colKeSach";
            this.colKeSach.Visible = true;
            this.colKeSach.VisibleIndex = 5;
            this.colKeSach.Width = 70;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên kệ";
            this.gridColumn7.FieldName = "Sach.KeSach.TenKe";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // colTrangThai1
            // 
            this.colTrangThai1.FieldName = "TrangThai";
            this.colTrangThai1.Name = "colTrangThai1";
            this.colTrangThai1.Visible = true;
            this.colTrangThai1.VisibleIndex = 7;
            this.colTrangThai1.Width = 82;
            // 
            // colTuaSach
            // 
            this.colTuaSach.Caption = "HinhAnh";
            this.colTuaSach.FieldName = "Sach.TuaSach.HinhAnh";
            this.colTuaSach.Name = "colTuaSach";
            // 
            // colPhieuMuon
            // 
            this.colPhieuMuon.Caption = "Ngày mượn";
            this.colPhieuMuon.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPhieuMuon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPhieuMuon.FieldName = "PhieuMuon.NgayMuon";
            this.colPhieuMuon.Name = "colPhieuMuon";
            this.colPhieuMuon.Visible = true;
            this.colPhieuMuon.VisibleIndex = 8;
            this.colPhieuMuon.Width = 89;
            // 
            // colPhieuMuon1
            // 
            this.colPhieuMuon1.Caption = "Ngày hẹn trả";
            this.colPhieuMuon1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colPhieuMuon1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPhieuMuon1.FieldName = "PhieuMuon.NgayHenTra";
            this.colPhieuMuon1.Name = "colPhieuMuon1";
            this.colPhieuMuon1.Visible = true;
            this.colPhieuMuon1.VisibleIndex = 9;
            this.colPhieuMuon1.Width = 94;
            // 
            // colPhieuMuon2
            // 
            this.colPhieuMuon2.Caption = "Nhân viên cho mượn";
            this.colPhieuMuon2.FieldName = "NhanVienChoMuon";
            this.colPhieuMuon2.Name = "colPhieuMuon2";
            this.colPhieuMuon2.UnboundExpression = "PhieuMuon.NhanVien.Ho + \' \' + PhieuMuon.NhanVien.Ten";
            this.colPhieuMuon2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colPhieuMuon2.Visible = true;
            this.colPhieuMuon2.VisibleIndex = 10;
            this.colPhieuMuon2.Width = 187;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 859);
            this.Controls.Add(this.gbCTPM);
            this.Controls.Add(this.gcCTHocPhi);
            this.Controls.Add(this.nvgtCTPhieu);
            this.Controls.Add(this.gbHocPhi);
            this.Controls.Add(this.gcHocPhi);
            this.Controls.Add(this.nvgtPhieu);
            this.Controls.Add(this.gbTheDocGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLTV.Properties.Resources.favpng_book_depository_16x17;
            this.Name = "frmTraSach";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtCTPhieu)).EndInit();
            this.nvgtCTPhieu.ResumeLayout(false);
            this.nvgtCTPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbHocPhi)).EndInit();
            this.gbHocPhi.ResumeLayout(false);
            this.gbHocPhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgtPhieu)).EndInit();
            this.nvgtPhieu.ResumeLayout(false);
            this.nvgtPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbTheDocGia)).EndInit();
            this.gbTheDocGia.ResumeLayout(false);
            this.gbTheDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkupMaTheDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPM)).EndInit();
            this.gbCTPM.ResumeLayout(false);
            this.gbCTPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCTPM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlkSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcCTHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPM;
        private System.Windows.Forms.BindingNavigator nvgtCTPhieu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtViTriCTDHP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnThemCTPhieu;
        private System.Windows.Forms.ToolStripButton btnXoaCTPhieu;
        private System.Windows.Forms.ToolStripButton btnGhiCTPhieu;
        private System.Windows.Forms.ToolStripButton btnHuyCTPhieu;
        private System.Windows.Forms.ToolStripButton btnTaiCTPhieu;
        private DevExpress.XtraEditors.GroupControl gbHocPhi;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuTra;
        private System.Windows.Forms.BindingNavigator nvgtPhieu;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox txtViTriHocPhi;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnThemPhieu;
        private System.Windows.Forms.ToolStripButton btnXoaPhieu;
        private System.Windows.Forms.ToolStripButton btnSuaPhieu;
        private System.Windows.Forms.ToolStripButton btnGhiPhieu;
        private System.Windows.Forms.ToolStripButton btnHuyPhieu;
        private System.Windows.Forms.ToolStripButton btnTaiPhieu;
        private DevExpress.XtraEditors.GroupControl gbTheDocGia;
        private DevExpress.XtraEditors.LookUpEdit lkupMaTheDG;
        private System.Windows.Forms.Label mAMHLabel;
        private DevExpress.XtraEditors.TextEdit txtMaDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tENMHLabel;
        private DevExpress.XtraEditors.TextEdit txtHoTenDG;
        private System.Windows.Forms.BindingSource bdsPhieuTra;
        private System.Windows.Forms.BindingSource bdsTheDocGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.GroupControl gbCTPM;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.DateEdit dateNgayTra;
        private DevExpress.XtraEditors.GridLookUpEdit lkCTPM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlkSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaISBN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colKeSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai1;
        private DevExpress.XtraGrid.Columns.GridColumn colTuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.BindingSource bdsCTPhieu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuTra;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTienPhat;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.Windows.Forms.BindingSource bdsCTPhieuMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuMuon1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuMuon1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuMuon2;
    }
}