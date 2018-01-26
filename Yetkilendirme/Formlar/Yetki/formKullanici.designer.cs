namespace Yetkilendirme12M
{
    partial class formKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKullanici));
            this.barMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridKullanicilar = new DevExpress.XtraGrid.GridControl();
            this.conMenuKullanici = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmKullaniciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmKullaniciGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmKullaniciSil = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKullanicilar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcuNameSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcuUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSirket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcuAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcuRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcuActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.glueRol = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRolAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKullaniciIzinleri = new DevExpress.XtraGrid.GridControl();
            this.conMenuIzinler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmTumunuSec = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTumunuKaldir = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKullaniciIzinleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcpPermName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcpReading = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCeOkuma = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcpWriting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCeYazma = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcpUpdating = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCeGuncelleme = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcpDeleting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCeSilme = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcpGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcpTip = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).BeginInit();
            this.conMenuKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glueRol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullaniciIzinleri)).BeginInit();
            this.conMenuIzinler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewKullaniciIzinleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeOkuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeYazma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeGuncelleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeSilme)).BeginInit();
            this.SuspendLayout();
            // 
            // barMenu
            // 
            this.barMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barMenu.DockControls.Add(this.barDockControlTop);
            this.barMenu.DockControls.Add(this.barDockControlBottom);
            this.barMenu.DockControls.Add(this.barDockControlLeft);
            this.barMenu.DockControls.Add(this.barDockControlRight);
            this.barMenu.Form = this;
            this.barMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnYenile,
            this.bbtnKaydet});
            this.barMenu.MainMenu = this.bar2;
            this.barMenu.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnKaydet, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnYenile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtnKaydet
            // 
            this.bbtnKaydet.Caption = "Kaydet";
            this.bbtnKaydet.Glyph = global::Yetkilendirme12M.Properties.Resources.save;
            this.bbtnKaydet.Id = 2;
            this.bbtnKaydet.Name = "bbtnKaydet";
            this.bbtnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnKaydet_ItemClick);
            // 
            // bbtnYenile
            // 
            this.bbtnYenile.Caption = "Yenile";
            this.bbtnYenile.Glyph = global::Yetkilendirme12M.Properties.Resources.refresh_16p;
            this.bbtnYenile.Id = 1;
            this.bbtnYenile.Name = "bbtnYenile";
            this.bbtnYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnYenile_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1084, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Size = new System.Drawing.Size(1084, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1084, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridKullanicilar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(514, 420);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Kullanıcı Listesi";
            // 
            // gridKullanicilar
            // 
            this.gridKullanicilar.ContextMenuStrip = this.conMenuKullanici;
            this.gridKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKullanicilar.Location = new System.Drawing.Point(2, 23);
            this.gridKullanicilar.MainView = this.viewKullanicilar;
            this.gridKullanicilar.Name = "gridKullanicilar";
            this.gridKullanicilar.Size = new System.Drawing.Size(510, 395);
            this.gridKullanicilar.TabIndex = 1;
            this.gridKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewKullanicilar});
            // 
            // conMenuKullanici
            // 
            this.conMenuKullanici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmKullaniciEkle,
            this.cmKullaniciGuncelle,
            this.cmKullaniciSil});
            this.conMenuKullanici.Name = "conMenuKullanici";
            this.conMenuKullanici.Size = new System.Drawing.Size(169, 70);
            // 
            // cmKullaniciEkle
            // 
            this.cmKullaniciEkle.Image = global::Yetkilendirme12M.Properties.Resources.add_user;
            this.cmKullaniciEkle.Name = "cmKullaniciEkle";
            this.cmKullaniciEkle.Size = new System.Drawing.Size(168, 22);
            this.cmKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            this.cmKullaniciEkle.Click += new System.EventHandler(this.cmKullaniciEkle_Click);
            // 
            // cmKullaniciGuncelle
            // 
            this.cmKullaniciGuncelle.Image = global::Yetkilendirme12M.Properties.Resources.user_edit;
            this.cmKullaniciGuncelle.Name = "cmKullaniciGuncelle";
            this.cmKullaniciGuncelle.Size = new System.Drawing.Size(168, 22);
            this.cmKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            this.cmKullaniciGuncelle.Click += new System.EventHandler(this.cmKullaniciGuncelle_Click);
            // 
            // cmKullaniciSil
            // 
            this.cmKullaniciSil.Image = global::Yetkilendirme12M.Properties.Resources.user_blue_delete;
            this.cmKullaniciSil.Name = "cmKullaniciSil";
            this.cmKullaniciSil.Size = new System.Drawing.Size(168, 22);
            this.cmKullaniciSil.Text = "Kullanıcıyı Sil";
            this.cmKullaniciSil.Click += new System.EventHandler(this.cmKullaniciSil_Click);
            // 
            // viewKullanicilar
            // 
            this.viewKullanicilar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcuID,
            this.gcuNameSurname,
            this.gcuUserName,
            this.gcSirket,
            this.gcTip,
            this.gcuAdmin,
            this.gcuRole,
            this.gcuActive});
            this.viewKullanicilar.GridControl = this.gridKullanicilar;
            this.viewKullanicilar.Name = "viewKullanicilar";
            this.viewKullanicilar.OptionsView.ColumnAutoWidth = false;
            this.viewKullanicilar.OptionsView.ShowAutoFilterRow = true;
            this.viewKullanicilar.OptionsView.ShowDetailButtons = false;
            this.viewKullanicilar.OptionsView.ShowFooter = true;
            this.viewKullanicilar.OptionsView.ShowGroupPanel = false;
            this.viewKullanicilar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.viewKullanicilar_FocusedRowChanged);
            // 
            // gcuID
            // 
            this.gcuID.Caption = "ID";
            this.gcuID.FieldName = "ID";
            this.gcuID.Name = "gcuID";
            this.gcuID.OptionsColumn.AllowEdit = false;
            this.gcuID.OptionsColumn.ReadOnly = true;
            this.gcuID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // gcuNameSurname
            // 
            this.gcuNameSurname.Caption = "Adı Soyadı";
            this.gcuNameSurname.FieldName = "AdSoyad";
            this.gcuNameSurname.Name = "gcuNameSurname";
            this.gcuNameSurname.OptionsColumn.AllowEdit = false;
            this.gcuNameSurname.Visible = true;
            this.gcuNameSurname.VisibleIndex = 1;
            this.gcuNameSurname.Width = 122;
            // 
            // gcuUserName
            // 
            this.gcuUserName.Caption = "Kullanıcı Adı";
            this.gcuUserName.FieldName = "Kod";
            this.gcuUserName.Name = "gcuUserName";
            this.gcuUserName.OptionsColumn.AllowEdit = false;
            this.gcuUserName.Visible = true;
            this.gcuUserName.VisibleIndex = 2;
            this.gcuUserName.Width = 112;
            // 
            // gcSirket
            // 
            this.gcSirket.Caption = "Şirket";
            this.gcSirket.FieldName = "Sirket";
            this.gcSirket.Name = "gcSirket";
            this.gcSirket.OptionsColumn.AllowEdit = false;
            this.gcSirket.Visible = true;
            this.gcSirket.VisibleIndex = 0;
            this.gcSirket.Width = 49;
            // 
            // gcTip
            // 
            this.gcTip.Caption = "Tip";
            this.gcTip.FieldName = "Tip";
            this.gcTip.Name = "gcTip";
            this.gcTip.OptionsColumn.AllowEdit = false;
            this.gcTip.Visible = true;
            this.gcTip.VisibleIndex = 3;
            this.gcTip.Width = 33;
            // 
            // gcuAdmin
            // 
            this.gcuAdmin.Caption = "Admin";
            this.gcuAdmin.FieldName = "Admin";
            this.gcuAdmin.Name = "gcuAdmin";
            this.gcuAdmin.OptionsColumn.AllowEdit = false;
            this.gcuAdmin.Visible = true;
            this.gcuAdmin.VisibleIndex = 4;
            this.gcuAdmin.Width = 36;
            // 
            // gcuRole
            // 
            this.gcuRole.Caption = "Rol ";
            this.gcuRole.FieldName = "RoleName";
            this.gcuRole.Name = "gcuRole";
            this.gcuRole.OptionsColumn.AllowEdit = false;
            this.gcuRole.Visible = true;
            this.gcuRole.VisibleIndex = 5;
            this.gcuRole.Width = 99;
            // 
            // gcuActive
            // 
            this.gcuActive.Caption = "Aktif";
            this.gcuActive.FieldName = "Aktif";
            this.gcuActive.Name = "gcuActive";
            this.gcuActive.OptionsColumn.AllowEdit = false;
            this.gcuActive.Visible = true;
            this.gcuActive.VisibleIndex = 6;
            this.gcuActive.Width = 39;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.gridKullaniciIzinleri);
            this.groupControl2.Location = new System.Drawing.Point(513, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(581, 420);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Kullanıcı İzinleri";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.glueRol);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(577, 33);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Uygulanacak Rol";
            // 
            // glueRol
            // 
            this.glueRol.Location = new System.Drawing.Point(143, 4);
            this.glueRol.Name = "glueRol";
            this.glueRol.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.glueRol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.glueRol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueRol.Properties.DisplayMember = "RoleName";
            this.glueRol.Properties.NullText = "";
            this.glueRol.Properties.PopupFormSize = new System.Drawing.Size(230, 200);
            this.glueRol.Properties.ValueMember = "RoleName";
            this.glueRol.Properties.View = this.gridLookUpEdit1View;
            this.glueRol.Size = new System.Drawing.Size(230, 22);
            this.glueRol.TabIndex = 0;
            this.glueRol.EditValueChanged += new System.EventHandler(this.glueRol_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRolAdi});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcRolAdi
            // 
            this.gcRolAdi.Caption = "Rol Adı";
            this.gcRolAdi.FieldName = "RoleName";
            this.gcRolAdi.Name = "gcRolAdi";
            this.gcRolAdi.OptionsColumn.ShowCaption = false;
            this.gcRolAdi.Visible = true;
            this.gcRolAdi.VisibleIndex = 0;
            // 
            // gridKullaniciIzinleri
            // 
            this.gridKullaniciIzinleri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKullaniciIzinleri.ContextMenuStrip = this.conMenuIzinler;
            this.gridKullaniciIzinleri.Location = new System.Drawing.Point(2, 57);
            this.gridKullaniciIzinleri.MainView = this.viewKullaniciIzinleri;
            this.gridKullaniciIzinleri.Name = "gridKullaniciIzinleri";
            this.gridKullaniciIzinleri.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCeOkuma,
            this.repCeYazma,
            this.repCeSilme,
            this.repCeGuncelleme});
            this.gridKullaniciIzinleri.Size = new System.Drawing.Size(569, 360);
            this.gridKullaniciIzinleri.TabIndex = 0;
            this.gridKullaniciIzinleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewKullaniciIzinleri});
            // 
            // conMenuIzinler
            // 
            this.conMenuIzinler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.cmTumunuSec,
            this.cmTumunuKaldir});
            this.conMenuIzinler.Name = "conMenuIzinler";
            this.conMenuIzinler.Size = new System.Drawing.Size(154, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // cmTumunuSec
            // 
            this.cmTumunuSec.Name = "cmTumunuSec";
            this.cmTumunuSec.Size = new System.Drawing.Size(153, 22);
            this.cmTumunuSec.Text = "Tümünü Seç";
            this.cmTumunuSec.Click += new System.EventHandler(this.cmTumunuSec_Click);
            // 
            // cmTumunuKaldir
            // 
            this.cmTumunuKaldir.Name = "cmTumunuKaldir";
            this.cmTumunuKaldir.Size = new System.Drawing.Size(153, 22);
            this.cmTumunuKaldir.Text = "Tümünü Kaldır";
            this.cmTumunuKaldir.Click += new System.EventHandler(this.cmTumunuKaldir_Click);
            // 
            // viewKullaniciIzinleri
            // 
            this.viewKullaniciIzinleri.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewKullaniciIzinleri.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewKullaniciIzinleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcpPermName,
            this.gcpReading,
            this.gcpWriting,
            this.gcpUpdating,
            this.gcpDeleting,
            this.gcpGroup,
            this.gcpTip});
            this.viewKullaniciIzinleri.GridControl = this.gridKullaniciIzinleri;
            this.viewKullaniciIzinleri.Name = "viewKullaniciIzinleri";
            this.viewKullaniciIzinleri.OptionsView.ColumnAutoWidth = false;
            this.viewKullaniciIzinleri.OptionsView.ShowAutoFilterRow = true;
            this.viewKullaniciIzinleri.OptionsView.ShowFooter = true;
            this.viewKullaniciIzinleri.OptionsView.ShowGroupPanel = false;
            // 
            // gcpPermName
            // 
            this.gcpPermName.Caption = "İzin Form";
            this.gcpPermName.FieldName = "PermName";
            this.gcpPermName.Name = "gcpPermName";
            this.gcpPermName.OptionsColumn.ReadOnly = true;
            this.gcpPermName.Visible = true;
            this.gcpPermName.VisibleIndex = 0;
            this.gcpPermName.Width = 180;
            // 
            // gcpReading
            // 
            this.gcpReading.Caption = "Okuma";
            this.gcpReading.ColumnEdit = this.repCeOkuma;
            this.gcpReading.FieldName = "Reading";
            this.gcpReading.Name = "gcpReading";
            this.gcpReading.Visible = true;
            this.gcpReading.VisibleIndex = 1;
            this.gcpReading.Width = 50;
            // 
            // repCeOkuma
            // 
            this.repCeOkuma.AutoHeight = false;
            this.repCeOkuma.Name = "repCeOkuma";
            this.repCeOkuma.CheckedChanged += new System.EventHandler(this.repCeOkuma_CheckedChanged);
            // 
            // gcpWriting
            // 
            this.gcpWriting.Caption = "Yazma";
            this.gcpWriting.ColumnEdit = this.repCeYazma;
            this.gcpWriting.FieldName = "Writing";
            this.gcpWriting.Name = "gcpWriting";
            this.gcpWriting.Visible = true;
            this.gcpWriting.VisibleIndex = 2;
            this.gcpWriting.Width = 50;
            // 
            // repCeYazma
            // 
            this.repCeYazma.AutoHeight = false;
            this.repCeYazma.Name = "repCeYazma";
            this.repCeYazma.CheckedChanged += new System.EventHandler(this.repCeYazma_CheckedChanged);
            // 
            // gcpUpdating
            // 
            this.gcpUpdating.Caption = "Güncelleme";
            this.gcpUpdating.ColumnEdit = this.repCeGuncelleme;
            this.gcpUpdating.FieldName = "Updating";
            this.gcpUpdating.Name = "gcpUpdating";
            this.gcpUpdating.Visible = true;
            this.gcpUpdating.VisibleIndex = 3;
            this.gcpUpdating.Width = 65;
            // 
            // repCeGuncelleme
            // 
            this.repCeGuncelleme.AutoHeight = false;
            this.repCeGuncelleme.Name = "repCeGuncelleme";
            this.repCeGuncelleme.CheckedChanged += new System.EventHandler(this.repCeGuncelleme_CheckedChanged);
            // 
            // gcpDeleting
            // 
            this.gcpDeleting.Caption = "Silme";
            this.gcpDeleting.ColumnEdit = this.repCeSilme;
            this.gcpDeleting.FieldName = "Deleting";
            this.gcpDeleting.Name = "gcpDeleting";
            this.gcpDeleting.Visible = true;
            this.gcpDeleting.VisibleIndex = 4;
            this.gcpDeleting.Width = 50;
            // 
            // repCeSilme
            // 
            this.repCeSilme.AutoHeight = false;
            this.repCeSilme.Name = "repCeSilme";
            this.repCeSilme.CheckedChanged += new System.EventHandler(this.repCeSilme_CheckedChanged);
            // 
            // gcpGroup
            // 
            this.gcpGroup.Caption = "Üst Grup";
            this.gcpGroup.FieldName = "Group";
            this.gcpGroup.Name = "gcpGroup";
            this.gcpGroup.OptionsColumn.ReadOnly = true;
            this.gcpGroup.Visible = true;
            this.gcpGroup.VisibleIndex = 5;
            this.gcpGroup.Width = 90;
            // 
            // gcpTip
            // 
            this.gcpTip.Caption = "Tip";
            this.gcpTip.FieldName = "Tip";
            this.gcpTip.Name = "gcpTip";
            this.gcpTip.OptionsColumn.ReadOnly = true;
            this.gcpTip.Visible = true;
            this.gcpTip.VisibleIndex = 6;
            this.gcpTip.Width = 70;
            // 
            // formKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 444);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formKullanici";
            this.Text = "Kullanıcı Tanımları";
            this.Load += new System.EventHandler(this.formKullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKullanicilar)).EndInit();
            this.conMenuKullanici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.glueRol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKullaniciIzinleri)).EndInit();
            this.conMenuIzinler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewKullaniciIzinleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeOkuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeYazma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeGuncelleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCeSilme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barMenu;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem bbtnYenile;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridKullaniciIzinleri;
        private DevExpress.XtraGrid.Views.Grid.GridView viewKullaniciIzinleri;
        private DevExpress.XtraGrid.Columns.GridColumn gcpPermName;
        private DevExpress.XtraGrid.Columns.GridColumn gcpReading;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeOkuma;
        private DevExpress.XtraGrid.Columns.GridColumn gcpWriting;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeYazma;
        private DevExpress.XtraBars.BarButtonItem bbtnKaydet;
        private DevExpress.XtraGrid.Columns.GridColumn gcpGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gcpDeleting;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeSilme;
        private DevExpress.XtraGrid.Columns.GridColumn gcpTip;
        private DevExpress.XtraGrid.GridControl gridKullanicilar;
        private DevExpress.XtraGrid.Views.Grid.GridView viewKullanicilar;
        private DevExpress.XtraGrid.Columns.GridColumn gcuID;
        private DevExpress.XtraGrid.Columns.GridColumn gcuNameSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gcuUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gcuAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn gcuRole;
        private DevExpress.XtraGrid.Columns.GridColumn gcuActive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip conMenuKullanici;
        private System.Windows.Forms.ToolStripMenuItem cmKullaniciEkle;
        private System.Windows.Forms.ToolStripMenuItem cmKullaniciGuncelle;
        private System.Windows.Forms.ToolStripMenuItem cmKullaniciSil;
        private DevExpress.XtraEditors.GridLookUpEdit glueRol;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gcRolAdi;
        private System.Windows.Forms.ContextMenuStrip conMenuIzinler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmTumunuSec;
        private System.Windows.Forms.ToolStripMenuItem cmTumunuKaldir;
        private DevExpress.XtraGrid.Columns.GridColumn gcpUpdating;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeGuncelleme;
        private DevExpress.XtraGrid.Columns.GridColumn gcSirket;
        private DevExpress.XtraGrid.Columns.GridColumn gcTip;
    }
}