namespace WinTestApp
{
    partial class AnaForm
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
            this.btnRolePerm = new System.Windows.Forms.Button();
            this.btnYazma = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.btnUserPerm = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSifreli = new System.Windows.Forms.TextBox();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.txtCozulmus = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRolePerm
            // 
            this.btnRolePerm.Location = new System.Drawing.Point(12, 13);
            this.btnRolePerm.Name = "btnRolePerm";
            this.btnRolePerm.Size = new System.Drawing.Size(157, 40);
            this.btnRolePerm.TabIndex = 0;
            this.btnRolePerm.Text = "ROLE PERM";
            this.btnRolePerm.UseVisualStyleBackColor = true;
            this.btnRolePerm.Click += new System.EventHandler(this.btnRolePerm_Click);
            // 
            // btnYazma
            // 
            this.btnYazma.Location = new System.Drawing.Point(355, 12);
            this.btnYazma.Name = "btnYazma";
            this.btnYazma.Size = new System.Drawing.Size(85, 40);
            this.btnYazma.TabIndex = 0;
            this.btnYazma.Text = "YAZMA";
            this.btnYazma.UseVisualStyleBackColor = true;
            this.btnYazma.Click += new System.EventHandler(this.btnYazma_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(446, 12);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(85, 40);
            this.btnSilme.TabIndex = 0;
            this.btnSilme.Text = "SİLME";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnUserPerm
            // 
            this.btnUserPerm.Location = new System.Drawing.Point(12, 59);
            this.btnUserPerm.Name = "btnUserPerm";
            this.btnUserPerm.Size = new System.Drawing.Size(157, 40);
            this.btnUserPerm.TabIndex = 0;
            this.btnUserPerm.Text = "USER PERM";
            this.btnUserPerm.UseVisualStyleBackColor = true;
            this.btnUserPerm.Click += new System.EventHandler(this.btnUserPerm_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGİN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSifreli
            // 
            this.txtSifreli.Location = new System.Drawing.Point(12, 208);
            this.txtSifreli.Name = "txtSifreli";
            this.txtSifreli.Size = new System.Drawing.Size(498, 20);
            this.txtSifreli.TabIndex = 1;
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.Location = new System.Drawing.Point(310, 243);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(200, 23);
            this.btnSifreCoz.TabIndex = 2;
            this.btnSifreCoz.Text = "Şifre Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // txtCozulmus
            // 
            this.txtCozulmus.Location = new System.Drawing.Point(12, 288);
            this.txtCozulmus.Name = "txtCozulmus";
            this.txtCozulmus.Size = new System.Drawing.Size(498, 20);
            this.txtCozulmus.TabIndex = 3;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(12, 243);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(188, 23);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 356);
            this.Controls.Add(this.txtCozulmus);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.txtSifreli);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnYazma);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnUserPerm);
            this.Controls.Add(this.btnRolePerm);
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ana Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRolePerm;
        private System.Windows.Forms.Button btnYazma;
        private System.Windows.Forms.Button btnSilme;
        private System.Windows.Forms.Button btnUserPerm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtSifreli;
        private System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.TextBox txtCozulmus;
        private System.Windows.Forms.Button btnSifrele;
    }
}

