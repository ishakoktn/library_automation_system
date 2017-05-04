namespace Kutuphane_Otomasyon_Sistemi
{
    partial class singin_frm
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
            this.giris_btn = new System.Windows.Forms.Button();
            this.email_txtbx = new System.Windows.Forms.TextBox();
            this.psswrd_txtbx = new System.Windows.Forms.TextBox();
            this.kulllanici_kaydi_lnklbl = new System.Windows.Forms.LinkLabel();
            this.email_lbl = new System.Windows.Forms.Label();
            this.parola_lbl = new System.Windows.Forms.Label();
            this.msg_lbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(177, 175);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(149, 23);
            this.giris_btn.TabIndex = 0;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // email_txtbx
            // 
            this.email_txtbx.Location = new System.Drawing.Point(156, 99);
            this.email_txtbx.Name = "email_txtbx";
            this.email_txtbx.Size = new System.Drawing.Size(196, 20);
            this.email_txtbx.TabIndex = 1;
            // 
            // psswrd_txtbx
            // 
            this.psswrd_txtbx.Location = new System.Drawing.Point(156, 125);
            this.psswrd_txtbx.Name = "psswrd_txtbx";
            this.psswrd_txtbx.Size = new System.Drawing.Size(196, 20);
            this.psswrd_txtbx.TabIndex = 2;
            // 
            // kulllanici_kaydi_lnklbl
            // 
            this.kulllanici_kaydi_lnklbl.AutoSize = true;
            this.kulllanici_kaydi_lnklbl.Location = new System.Drawing.Point(193, 215);
            this.kulllanici_kaydi_lnklbl.Name = "kulllanici_kaydi_lnklbl";
            this.kulllanici_kaydi_lnklbl.Size = new System.Drawing.Size(99, 13);
            this.kulllanici_kaydi_lnklbl.TabIndex = 3;
            this.kulllanici_kaydi_lnklbl.TabStop = true;
            this.kulllanici_kaydi_lnklbl.Text = "Yeni Kullanıcı Kaydı";
            this.kulllanici_kaydi_lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kulllanici_kaydi_lnklbl_LinkClicked);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(90, 102);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(35, 13);
            this.email_lbl.TabIndex = 4;
            this.email_lbl.Text = "Email:";
            // 
            // parola_lbl
            // 
            this.parola_lbl.AutoSize = true;
            this.parola_lbl.Location = new System.Drawing.Point(90, 132);
            this.parola_lbl.Name = "parola_lbl";
            this.parola_lbl.Size = new System.Drawing.Size(40, 13);
            this.parola_lbl.TabIndex = 5;
            this.parola_lbl.Text = "Parola:";
            // 
            // msg_lbl
            // 
            this.msg_lbl.AutoSize = true;
            this.msg_lbl.Location = new System.Drawing.Point(111, 215);
            this.msg_lbl.Name = "msg_lbl";
            this.msg_lbl.Size = new System.Drawing.Size(0, 13);
            this.msg_lbl.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(204, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 34);
            this.label18.TabIndex = 33;
            this.label18.Text = "GİRİŞ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(174, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "made by Ishak OKUTAN";
            // 
            // singin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.msg_lbl);
            this.Controls.Add(this.parola_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.kulllanici_kaydi_lnklbl);
            this.Controls.Add(this.psswrd_txtbx);
            this.Controls.Add(this.email_txtbx);
            this.Controls.Add(this.giris_btn);
            this.Name = "singin_frm";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.singin_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.TextBox email_txtbx;
        private System.Windows.Forms.TextBox psswrd_txtbx;
        private System.Windows.Forms.LinkLabel kulllanici_kaydi_lnklbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label parola_lbl;
        private System.Windows.Forms.Label msg_lbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
    }
}

