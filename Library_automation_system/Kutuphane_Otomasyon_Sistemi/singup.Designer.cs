namespace Kutuphane_Otomasyon_Sistemi
{
    partial class singup_frm
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
            this.singup_btn = new System.Windows.Forms.Button();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.surname_txtbx = new System.Windows.Forms.TextBox();
            this.gsm_txtbx = new System.Windows.Forms.TextBox();
            this.email_txtbx = new System.Windows.Forms.TextBox();
            this.password__txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password2_txtbx = new System.Windows.Forms.TextBox();
            this.error_lbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singup_btn
            // 
            this.singup_btn.Location = new System.Drawing.Point(191, 251);
            this.singup_btn.Name = "singup_btn";
            this.singup_btn.Size = new System.Drawing.Size(75, 23);
            this.singup_btn.TabIndex = 0;
            this.singup_btn.Text = "Kaydol";
            this.singup_btn.UseVisualStyleBackColor = true;
            this.singup_btn.Click += new System.EventHandler(this.singup_btn_Click);
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(166, 59);
            this.name_txtbx.MaxLength = 45;
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(157, 20);
            this.name_txtbx.TabIndex = 1;
            // 
            // surname_txtbx
            // 
            this.surname_txtbx.Location = new System.Drawing.Point(166, 85);
            this.surname_txtbx.MaxLength = 45;
            this.surname_txtbx.Name = "surname_txtbx";
            this.surname_txtbx.Size = new System.Drawing.Size(157, 20);
            this.surname_txtbx.TabIndex = 2;
            // 
            // gsm_txtbx
            // 
            this.gsm_txtbx.Location = new System.Drawing.Point(166, 111);
            this.gsm_txtbx.MaxLength = 11;
            this.gsm_txtbx.Name = "gsm_txtbx";
            this.gsm_txtbx.Size = new System.Drawing.Size(157, 20);
            this.gsm_txtbx.TabIndex = 3;
            this.gsm_txtbx.TextChanged += new System.EventHandler(this.gsm_txtbx_TextChanged);
            this.gsm_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gsm_txtbx_KeyPress);
            // 
            // email_txtbx
            // 
            this.email_txtbx.Location = new System.Drawing.Point(166, 137);
            this.email_txtbx.Name = "email_txtbx";
            this.email_txtbx.Size = new System.Drawing.Size(157, 20);
            this.email_txtbx.TabIndex = 4;
            // 
            // password__txtbx
            // 
            this.password__txtbx.Location = new System.Drawing.Point(166, 163);
            this.password__txtbx.MaxLength = 100;
            this.password__txtbx.Name = "password__txtbx";
            this.password__txtbx.Size = new System.Drawing.Size(157, 20);
            this.password__txtbx.TabIndex = 5;
            this.password__txtbx.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "GSM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Parola:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Parola (Tekrar):";
            // 
            // password2_txtbx
            // 
            this.password2_txtbx.Location = new System.Drawing.Point(166, 189);
            this.password2_txtbx.MaxLength = 100;
            this.password2_txtbx.Name = "password2_txtbx";
            this.password2_txtbx.Size = new System.Drawing.Size(157, 20);
            this.password2_txtbx.TabIndex = 6;
            this.password2_txtbx.UseSystemPasswordChar = true;
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(195, 226);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(71, 13);
            this.error_lbl.TabIndex = 13;
            this.error_lbl.Text = "hata mesajları";
            this.error_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(207, 293);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giriş Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(329, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(329, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(329, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(329, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(329, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(329, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(192, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 34);
            this.label18.TabIndex = 33;
            this.label18.Text = "ÜYE OL";
            // 
            // singup_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 315);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password2_txtbx);
            this.Controls.Add(this.password__txtbx);
            this.Controls.Add(this.email_txtbx);
            this.Controls.Add(this.gsm_txtbx);
            this.Controls.Add(this.surname_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Controls.Add(this.singup_btn);
            this.Name = "singup_frm";
            this.Text = "Kaydol";
            this.Load += new System.EventHandler(this.singup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singup_btn;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.TextBox surname_txtbx;
        private System.Windows.Forms.TextBox gsm_txtbx;
        private System.Windows.Forms.TextBox email_txtbx;
        private System.Windows.Forms.TextBox password__txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password2_txtbx;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
    }
}