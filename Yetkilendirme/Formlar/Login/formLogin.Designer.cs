namespace Yetkilendirme12M
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.lueSirket = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labSirket = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.labParola = new DevExpress.XtraEditors.LabelControl();
            this.labKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSirket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.19469F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.txtPass);
            this.groupControl1.Controls.Add(this.txtUserID);
            this.groupControl1.Controls.Add(this.lueSirket);
            this.groupControl1.Controls.Add(this.labSirket);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.labParola);
            this.groupControl1.Controls.Add(this.labKullaniciAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(446, 173);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kullanıcı Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yetkilendirme12M.Properties.Resources.userlogin128;
            this.pictureBox1.Location = new System.Drawing.Point(5, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(262, 71);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtPass.Properties.MaxLength = 10;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(172, 22);
            this.txtPass.TabIndex = 2;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(262, 41);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtUserID.Properties.MaxLength = 5;
            this.txtUserID.Size = new System.Drawing.Size(172, 22);
            this.txtUserID.TabIndex = 1;
            // 
            // lueSirket
            // 
            this.lueSirket.Location = new System.Drawing.Point(262, 101);
            this.lueSirket.Name = "lueSirket";
            this.lueSirket.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lueSirket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSirket.Properties.DisplayMember = "KisaAdi";
            this.lueSirket.Properties.NullText = "";
            this.lueSirket.Properties.PopupFormSize = new System.Drawing.Size(350, 300);
            this.lueSirket.Properties.ValueMember = "Kod";
            this.lueSirket.Properties.View = this.gridView21;
            this.lueSirket.Size = new System.Drawing.Size(172, 22);
            this.lueSirket.TabIndex = 3;
            this.lueSirket.Tag = "";
            // 
            // gridView21
            // 
            this.gridView21.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView21.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView21.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView21.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView21.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView21.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView21.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView21.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView21.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView21.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView21.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView21.Appearance.Empty.Options.UseBackColor = true;
            this.gridView21.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.gridView21.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.gridView21.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView21.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gridView21.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView21.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView21.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView21.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView21.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView21.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView21.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView21.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView21.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView21.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.gridView21.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView21.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView21.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView21.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView21.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.gridView21.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView21.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView21.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView21.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView21.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.gridView21.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView21.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView21.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView21.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.gridView21.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.gridView21.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView21.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView21.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView21.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView21.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView21.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView21.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView21.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView21.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView21.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView21.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView21.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.gridView21.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView21.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView21.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView21.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView21.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.gridView21.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView21.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView21.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView21.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.gridView21.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.gridView21.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView21.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView21.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.gridView21.Appearance.HorzLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.gridView21.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView21.Appearance.HorzLine.Options.UseBorderColor = true;
            this.gridView21.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView21.Appearance.OddRow.Options.UseBorderColor = true;
            this.gridView21.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView21.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.gridView21.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView21.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.gridView21.Appearance.Preview.Options.UseBackColor = true;
            this.gridView21.Appearance.Preview.Options.UseFont = true;
            this.gridView21.Appearance.Preview.Options.UseForeColor = true;
            this.gridView21.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.Row.Options.UseBackColor = true;
            this.gridView21.Appearance.Row.Options.UseForeColor = true;
            this.gridView21.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.gridView21.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView21.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView21.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.gridView21.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView21.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView21.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView21.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView21.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView21.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.gridView21.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.gridView21.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView21.Appearance.VertLine.Options.UseBorderColor = true;
            this.gridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView21.Name = "gridView21";
            this.gridView21.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView21.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView21.OptionsView.EnableAppearanceOddRow = true;
            this.gridView21.OptionsView.ShowAutoFilterRow = true;
            this.gridView21.OptionsView.ShowGroupPanel = false;
            // 
            // labSirket
            // 
            this.labSirket.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.19469F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSirket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labSirket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labSirket.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labSirket.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labSirket.Location = new System.Drawing.Point(139, 101);
            this.labSirket.Name = "labSirket";
            this.labSirket.Size = new System.Drawing.Size(117, 22);
            this.labSirket.TabIndex = 31;
            this.labSirket.Text = "Şirket";
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.19469F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseTextOptions = true;
            this.btnLogin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnLogin.BackgroundImage = global::Yetkilendirme12M.Properties.Resources.keylogin32;
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Image = global::Yetkilendirme12M.Properties.Resources.keylogin32;
            this.btnLogin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(262, 137);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labParola
            // 
            this.labParola.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.19469F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labParola.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labParola.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labParola.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labParola.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labParola.Location = new System.Drawing.Point(139, 71);
            this.labParola.Name = "labParola";
            this.labParola.Size = new System.Drawing.Size(117, 22);
            this.labParola.TabIndex = 29;
            this.labParola.Text = "Parola";
            // 
            // labKullaniciAdi
            // 
            this.labKullaniciAdi.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.19469F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labKullaniciAdi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labKullaniciAdi.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labKullaniciAdi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labKullaniciAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labKullaniciAdi.Location = new System.Drawing.Point(139, 41);
            this.labKullaniciAdi.Name = "labKullaniciAdi";
            this.labKullaniciAdi.Size = new System.Drawing.Size(117, 22);
            this.labKullaniciAdi.TabIndex = 27;
            this.labKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 173);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                   ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSirket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labSirket;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labParola;
        private DevExpress.XtraEditors.LabelControl labKullaniciAdi;
        private DevExpress.XtraEditors.GridLookUpEdit lueSirket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
        private System.Windows.Forms.PictureBox pictureBox1;
        public DevExpress.XtraEditors.TextEdit txtUserID;
        public DevExpress.XtraEditors.TextEdit txtPass;
    }
}