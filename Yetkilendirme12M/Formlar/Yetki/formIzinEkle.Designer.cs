namespace Yetkilendirme12M
{
    partial class formIzinEkle
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.txtIzinFormAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnIzinKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.chkAktif = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTip = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIzinFormAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAktif.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIzinFormAdi
            // 
            this.txtIzinFormAdi.Location = new System.Drawing.Point(3, 32);
            this.txtIzinFormAdi.Name = "txtIzinFormAdi";
            this.txtIzinFormAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtIzinFormAdi.Properties.MaxLength = 50;
            this.txtIzinFormAdi.Size = new System.Drawing.Size(196, 22);
            this.txtIzinFormAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(3, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(196, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İzin Form Adı";
            // 
            // btnIzinKaydet
            // 
            this.btnIzinKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnIzinKaydet.Image = global::Yetkilendirme12M.Properties.Resources.save;
            this.btnIzinKaydet.Location = new System.Drawing.Point(488, 32);
            this.btnIzinKaydet.Name = "btnIzinKaydet";
            this.btnIzinKaydet.Size = new System.Drawing.Size(84, 23);
            toolTipTitleItem1.Text = "Project Engineers List For User";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnIzinKaydet.SuperTip = superToolTip1;
            this.btnIzinKaydet.TabIndex = 8;
            this.btnIzinKaydet.Text = "Kaydet";
            this.btnIzinKaydet.Click += new System.EventHandler(this.btnIzinKaydet_Click);
            // 
            // chkAktif
            // 
            this.chkAktif.EditValue = true;
            this.chkAktif.Location = new System.Drawing.Point(443, 32);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.chkAktif.Properties.Caption = "";
            this.chkAktif.Size = new System.Drawing.Size(26, 23);
            this.chkAktif.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl2.Location = new System.Drawing.Point(423, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 20);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Aktif";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl5.Location = new System.Drawing.Point(203, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 20);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Grup Adı";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Location = new System.Drawing.Point(203, 32);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtGrupAdi.Properties.MaxLength = 50;
            this.txtGrupAdi.Size = new System.Drawing.Size(138, 22);
            this.txtGrupAdi.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl3.Location = new System.Drawing.Point(345, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tip";
            // 
            // cmbTip
            // 
            this.cmbTip.EditValue = "Form";
            this.cmbTip.Location = new System.Drawing.Point(345, 32);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.cmbTip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTip.Properties.Items.AddRange(new object[] {
            "Form",
            "Kontrol"});
            this.cmbTip.Properties.MaxLength = 20;
            this.cmbTip.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbTip.Size = new System.Drawing.Size(74, 22);
            this.cmbTip.TabIndex = 5;
            // 
            // formIzinEkle
            // 
            this.AcceptButton = this.btnIzinKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 58);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.btnIzinKaydet);
            this.Controls.Add(this.txtGrupAdi);
            this.Controls.Add(this.txtIzinFormAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formIzinEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "   İzin Form Ekle";
            this.Load += new System.EventHandler(this.formRolEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIzinFormAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAktif.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtIzinFormAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIzinKaydet;
        private DevExpress.XtraEditors.CheckEdit chkAktif;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTip;
    }
}