namespace Yetkilendirme12M
{
    partial class formRolEkle
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
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRolKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(99, 11);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.txtRoleName.Properties.MaxLength = 20;
            this.txtRoleName.Size = new System.Drawing.Size(187, 22);
            this.txtRoleName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.labelControl1.Location = new System.Drawing.Point(3, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Rol Adı :";
            // 
            // btnRolKaydet
            // 
            this.btnRolKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRolKaydet.Image = global::Yetkilendirme12M.Properties.Resources.save;
            this.btnRolKaydet.Location = new System.Drawing.Point(290, 11);
            this.btnRolKaydet.Name = "btnRolKaydet";
            this.btnRolKaydet.Size = new System.Drawing.Size(81, 22);
            toolTipTitleItem1.Text = "Project Engineers List For User";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnRolKaydet.SuperTip = superToolTip1;
            this.btnRolKaydet.TabIndex = 2;
            this.btnRolKaydet.Text = "Kaydet";
            this.btnRolKaydet.Click += new System.EventHandler(this.btnRolKaydet_Click);
            // 
            // formRolEkle
            // 
            this.AcceptButton = this.btnRolKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 47);
            this.Controls.Add(this.btnRolKaydet);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formRolEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "   Rol Ekle";
            this.Load += new System.EventHandler(this.formRolEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRolKaydet;
    }
}