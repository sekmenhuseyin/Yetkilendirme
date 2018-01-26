namespace Yetkilendirme12M
{
    partial class formRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRol));
            this.barMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridRoles = new DevExpress.XtraGrid.GridControl();
            this.conMenuRoller = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmRolEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRolGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRolSil = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridRoleIzinleri = new DevExpress.XtraGrid.GridControl();
            this.conMenuIzinler = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmIzinFormEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmIzinFormGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmIzinFormSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmTumunuSec = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTumunuKaldir = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRoleIzinleri = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).BeginInit();
            this.conMenuRoller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRoleIzinleri)).BeginInit();
            this.conMenuIzinler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRoleIzinleri)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(984, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Size = new System.Drawing.Size(984, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(984, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridRoles);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(237, 420);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Rol Listesi";
            // 
            // gridRoles
            // 
            this.gridRoles.ContextMenuStrip = this.conMenuRoller;
            this.gridRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRoles.Location = new System.Drawing.Point(2, 23);
            this.gridRoles.MainView = this.viewRoles;
            this.gridRoles.MenuManager = this.barMenu;
            this.gridRoles.Name = "gridRoles";
            this.gridRoles.Size = new System.Drawing.Size(233, 395);
            this.gridRoles.TabIndex = 0;
            this.gridRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewRoles});
            // 
            // conMenuRoller
            // 
            this.conMenuRoller.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRolEkle,
            this.cmRolGuncelle,
            this.cmRolSil});
            this.conMenuRoller.Name = "conMenuRoller";
            this.conMenuRoller.Size = new System.Drawing.Size(142, 70);
            // 
            // cmRolEkle
            // 
            this.cmRolEkle.Image = global::Yetkilendirme12M.Properties.Resources.Add;
            this.cmRolEkle.Name = "cmRolEkle";
            this.cmRolEkle.Size = new System.Drawing.Size(141, 22);
            this.cmRolEkle.Text = "Yeni Rol Ekle";
            this.cmRolEkle.Click += new System.EventHandler(this.cmRolEkle_Click);
            // 
            // cmRolGuncelle
            // 
            this.cmRolGuncelle.Image = global::Yetkilendirme12M.Properties.Resources.form_edit_16p;
            this.cmRolGuncelle.Name = "cmRolGuncelle";
            this.cmRolGuncelle.Size = new System.Drawing.Size(141, 22);
            this.cmRolGuncelle.Text = "Rol Güncelle";
            this.cmRolGuncelle.Click += new System.EventHandler(this.cmRolGuncelle_Click);
            // 
            // cmRolSil
            // 
            this.cmRolSil.Image = global::Yetkilendirme12M.Properties.Resources.delete;
            this.cmRolSil.Name = "cmRolSil";
            this.cmRolSil.Size = new System.Drawing.Size(141, 22);
            this.cmRolSil.Text = "Rol Sil";
            this.cmRolSil.Click += new System.EventHandler(this.cmRolSil_Click);
            // 
            // viewRoles
            // 
            this.viewRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRoleName});
            this.viewRoles.GridControl = this.gridRoles;
            this.viewRoles.Name = "viewRoles";
            this.viewRoles.OptionsBehavior.Editable = false;
            this.viewRoles.OptionsBehavior.ReadOnly = true;
            this.viewRoles.OptionsCustomization.AllowColumnMoving = false;
            this.viewRoles.OptionsCustomization.AllowGroup = false;
            this.viewRoles.OptionsMenu.EnableColumnMenu = false;
            this.viewRoles.OptionsSelection.InvertSelection = true;
            this.viewRoles.OptionsView.ColumnAutoWidth = false;
            this.viewRoles.OptionsView.ShowAutoFilterRow = true;
            this.viewRoles.OptionsView.ShowDetailButtons = false;
            this.viewRoles.OptionsView.ShowFooter = true;
            this.viewRoles.OptionsView.ShowGroupPanel = false;
            this.viewRoles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.viewRoles_FocusedRowChanged);
            // 
            // gcRoleName
            // 
            this.gcRoleName.Caption = "Rol Adı";
            this.gcRoleName.FieldName = "RoleName";
            this.gcRoleName.Name = "gcRoleName";
            this.gcRoleName.Visible = true;
            this.gcRoleName.VisibleIndex = 0;
            this.gcRoleName.Width = 140;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridRoleIzinleri);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(237, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(690, 420);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Rol İzinleri";
            // 
            // gridRoleIzinleri
            // 
            this.gridRoleIzinleri.ContextMenuStrip = this.conMenuIzinler;
            this.gridRoleIzinleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRoleIzinleri.Location = new System.Drawing.Point(2, 23);
            this.gridRoleIzinleri.MainView = this.viewRoleIzinleri;
            this.gridRoleIzinleri.Name = "gridRoleIzinleri";
            this.gridRoleIzinleri.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCeOkuma,
            this.repCeYazma,
            this.repCeSilme,
            this.repCeGuncelleme});
            this.gridRoleIzinleri.Size = new System.Drawing.Size(686, 395);
            this.gridRoleIzinleri.TabIndex = 0;
            this.gridRoleIzinleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewRoleIzinleri});
            // 
            // conMenuIzinler
            // 
            this.conMenuIzinler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmIzinFormEkle,
            this.cmIzinFormGuncelle,
            this.cmIzinFormSil,
            this.toolStripSeparator1,
            this.cmTumunuSec,
            this.cmTumunuKaldir});
            this.conMenuIzinler.Name = "conMenuIzinler";
            this.conMenuIzinler.Size = new System.Drawing.Size(173, 120);
            // 
            // cmIzinFormEkle
            // 
            this.cmIzinFormEkle.Image = global::Yetkilendirme12M.Properties.Resources.Add;
            this.cmIzinFormEkle.Name = "cmIzinFormEkle";
            this.cmIzinFormEkle.Size = new System.Drawing.Size(172, 22);
            this.cmIzinFormEkle.Text = "İzin Form Ekle";
            this.cmIzinFormEkle.Click += new System.EventHandler(this.cmIzinFormEkle_Click);
            // 
            // cmIzinFormGuncelle
            // 
            this.cmIzinFormGuncelle.Image = global::Yetkilendirme12M.Properties.Resources.form_edit_16p;
            this.cmIzinFormGuncelle.Name = "cmIzinFormGuncelle";
            this.cmIzinFormGuncelle.Size = new System.Drawing.Size(172, 22);
            this.cmIzinFormGuncelle.Text = "İzin Form Güncelle";
            this.cmIzinFormGuncelle.Click += new System.EventHandler(this.cmIzinFormGuncelle_Click);
            // 
            // cmIzinFormSil
            // 
            this.cmIzinFormSil.Image = global::Yetkilendirme12M.Properties.Resources.delete;
            this.cmIzinFormSil.Name = "cmIzinFormSil";
            this.cmIzinFormSil.Size = new System.Drawing.Size(172, 22);
            this.cmIzinFormSil.Text = "İzin Form Sil";
            this.cmIzinFormSil.Click += new System.EventHandler(this.cmIzinFormSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // cmTumunuSec
            // 
            this.cmTumunuSec.Name = "cmTumunuSec";
            this.cmTumunuSec.Size = new System.Drawing.Size(172, 22);
            this.cmTumunuSec.Text = "Tümünü Seç";
            this.cmTumunuSec.Click += new System.EventHandler(this.cmTumunuSec_Click);
            // 
            // cmTumunuKaldir
            // 
            this.cmTumunuKaldir.Name = "cmTumunuKaldir";
            this.cmTumunuKaldir.Size = new System.Drawing.Size(172, 22);
            this.cmTumunuKaldir.Text = "Tümünü Kaldır";
            this.cmTumunuKaldir.Click += new System.EventHandler(this.cmTumunuKaldir_Click);
            // 
            // viewRoleIzinleri
            // 
            this.viewRoleIzinleri.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewRoleIzinleri.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewRoleIzinleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcpPermName,
            this.gcpReading,
            this.gcpWriting,
            this.gcpUpdating,
            this.gcpDeleting,
            this.gcpGroup,
            this.gcpTip});
            this.viewRoleIzinleri.GridControl = this.gridRoleIzinleri;
            this.viewRoleIzinleri.Name = "viewRoleIzinleri";
            this.viewRoleIzinleri.OptionsView.ColumnAutoWidth = false;
            this.viewRoleIzinleri.OptionsView.ShowAutoFilterRow = true;
            this.viewRoleIzinleri.OptionsView.ShowFooter = true;
            this.viewRoleIzinleri.OptionsView.ShowGroupPanel = false;
            // 
            // gcpPermName
            // 
            this.gcpPermName.Caption = "İzin Form";
            this.gcpPermName.FieldName = "PermName";
            this.gcpPermName.Name = "gcpPermName";
            this.gcpPermName.OptionsColumn.ReadOnly = true;
            this.gcpPermName.Visible = true;
            this.gcpPermName.VisibleIndex = 0;
            this.gcpPermName.Width = 210;
            // 
            // gcpReading
            // 
            this.gcpReading.Caption = "Okuma";
            this.gcpReading.ColumnEdit = this.repCeOkuma;
            this.gcpReading.FieldName = "Reading";
            this.gcpReading.Name = "gcpReading";
            this.gcpReading.Visible = true;
            this.gcpReading.VisibleIndex = 1;
            this.gcpReading.Width = 60;
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
            this.gcpWriting.Width = 60;
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
            this.gcpDeleting.Width = 60;
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
            this.gcpGroup.Width = 100;
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
            // formRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 444);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formRol";
            this.Text = "Rol Tanımları";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoles)).EndInit();
            this.conMenuRoller.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRoleIzinleri)).EndInit();
            this.conMenuIzinler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRoleIzinleri)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView viewRoles;
        private DevExpress.XtraGrid.Columns.GridColumn gcRoleName;
        private DevExpress.XtraBars.BarButtonItem bbtnYenile;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridRoleIzinleri;
        private DevExpress.XtraGrid.Views.Grid.GridView viewRoleIzinleri;
        private DevExpress.XtraGrid.Columns.GridColumn gcpPermName;
        private DevExpress.XtraGrid.Columns.GridColumn gcpReading;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeOkuma;
        private DevExpress.XtraGrid.Columns.GridColumn gcpWriting;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeYazma;
        private DevExpress.XtraBars.BarButtonItem bbtnKaydet;
        private DevExpress.XtraGrid.Columns.GridColumn gcpGroup;
        private DevExpress.XtraGrid.Columns.GridColumn gcpDeleting;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeSilme;
        private System.Windows.Forms.ContextMenuStrip conMenuRoller;
        private System.Windows.Forms.ToolStripMenuItem cmRolEkle;
        private System.Windows.Forms.ToolStripMenuItem cmRolGuncelle;
        private System.Windows.Forms.ToolStripMenuItem cmRolSil;
        private System.Windows.Forms.ContextMenuStrip conMenuIzinler;
        private System.Windows.Forms.ToolStripMenuItem cmIzinFormEkle;
        private System.Windows.Forms.ToolStripMenuItem cmIzinFormSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmTumunuSec;
        private System.Windows.Forms.ToolStripMenuItem cmTumunuKaldir;
        private System.Windows.Forms.ToolStripMenuItem cmIzinFormGuncelle;
        private DevExpress.XtraGrid.Columns.GridColumn gcpTip;
        private DevExpress.XtraGrid.Columns.GridColumn gcpUpdating;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCeGuncelleme;
    }
}