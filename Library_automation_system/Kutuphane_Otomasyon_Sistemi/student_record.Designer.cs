namespace Kutuphane_Otomasyon_Sistemi
{
    partial class student_record
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
            this.record_btn = new System.Windows.Forms.Button();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.surname_txtbx = new System.Windows.Forms.TextBox();
            this.number_txtbx = new System.Windows.Forms.TextBox();
            this.address_txtbx = new System.Windows.Forms.TextBox();
            this.home_address_txtbx = new System.Windows.Forms.TextBox();
            this.gsm_txtbx = new System.Windows.Forms.TextBox();
            this.faculty_cmbx = new System.Windows.Forms.ComboBox();
            this.department_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.error_msg_lbl = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // record_btn
            // 
            this.record_btn.Location = new System.Drawing.Point(299, 386);
            this.record_btn.Name = "record_btn";
            this.record_btn.Size = new System.Drawing.Size(75, 23);
            this.record_btn.TabIndex = 0;
            this.record_btn.Text = "Kayıt Et";
            this.record_btn.UseVisualStyleBackColor = true;
            this.record_btn.Click += new System.EventHandler(this.record_btn_Click);
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(259, 77);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(180, 20);
            this.name_txtbx.TabIndex = 1;
            // 
            // surname_txtbx
            // 
            this.surname_txtbx.Location = new System.Drawing.Point(259, 103);
            this.surname_txtbx.Name = "surname_txtbx";
            this.surname_txtbx.Size = new System.Drawing.Size(180, 20);
            this.surname_txtbx.TabIndex = 2;
            // 
            // number_txtbx
            // 
            this.number_txtbx.Location = new System.Drawing.Point(259, 129);
            this.number_txtbx.Name = "number_txtbx";
            this.number_txtbx.Size = new System.Drawing.Size(180, 20);
            this.number_txtbx.TabIndex = 3;
            this.number_txtbx.TextChanged += new System.EventHandler(this.number_txtbx_TextChanged);
            this.number_txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_txtbx_KeyPress);
            // 
            // address_txtbx
            // 
            this.address_txtbx.Location = new System.Drawing.Point(259, 155);
            this.address_txtbx.Multiline = true;
            this.address_txtbx.Name = "address_txtbx";
            this.address_txtbx.Size = new System.Drawing.Size(180, 55);
            this.address_txtbx.TabIndex = 4;
            // 
            // home_address_txtbx
            // 
            this.home_address_txtbx.Location = new System.Drawing.Point(259, 216);
            this.home_address_txtbx.Multiline = true;
            this.home_address_txtbx.Name = "home_address_txtbx";
            this.home_address_txtbx.Size = new System.Drawing.Size(180, 55);
            this.home_address_txtbx.TabIndex = 5;
            // 
            // gsm_txtbx
            // 
            this.gsm_txtbx.Location = new System.Drawing.Point(259, 277);
            this.gsm_txtbx.MaxLength = 11;
            this.gsm_txtbx.Name = "gsm_txtbx";
            this.gsm_txtbx.Size = new System.Drawing.Size(180, 20);
            this.gsm_txtbx.TabIndex = 6;
            this.gsm_txtbx.Text = "0";
            // 
            // faculty_cmbx
            // 
            this.faculty_cmbx.FormattingEnabled = true;
            this.faculty_cmbx.Location = new System.Drawing.Point(259, 303);
            this.faculty_cmbx.Name = "faculty_cmbx";
            this.faculty_cmbx.Size = new System.Drawing.Size(180, 21);
            this.faculty_cmbx.TabIndex = 7;
            this.faculty_cmbx.SelectedIndexChanged += new System.EventHandler(this.faculty_cmbx_SelectedIndexChanged);
            // 
            // department_cmbx
            // 
            this.department_cmbx.FormattingEnabled = true;
            this.department_cmbx.Location = new System.Drawing.Point(259, 331);
            this.department_cmbx.Name = "department_cmbx";
            this.department_cmbx.Size = new System.Drawing.Size(180, 21);
            this.department_cmbx.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Okul numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bölüm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adresi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Memleket Adresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-114, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "GSM:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-102, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "label4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-349, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "label4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fakülte:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-107, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "label4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-336, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "label4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-583, 473);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "label4";
            // 
            // error_msg_lbl
            // 
            this.error_msg_lbl.AutoSize = true;
            this.error_msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg_lbl.Location = new System.Drawing.Point(315, 358);
            this.error_msg_lbl.Name = "error_msg_lbl";
            this.error_msg_lbl.Size = new System.Drawing.Size(63, 13);
            this.error_msg_lbl.TabIndex = 13;
            this.error_msg_lbl.Text = "Hata Mesajı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(445, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 26;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(445, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 24);
            this.label16.TabIndex = 25;
            this.label16.Text = "**";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(445, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 24;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(445, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 24);
            this.label18.TabIndex = 23;
            this.label18.Text = "**";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(445, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 24);
            this.label19.TabIndex = 22;
            this.label19.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(445, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 24);
            this.label20.TabIndex = 21;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(445, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 24);
            this.label21.TabIndex = 27;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(445, 331);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 24);
            this.label22.TabIndex = 28;
            this.label22.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(29, 452);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(289, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "** işaretli alanların doldurulması zorunldur ayrıca tekil olmalıdır";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(29, 432);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(192, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "* işaretli alanların doldurulması zorunldur";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label25.Location = new System.Drawing.Point(265, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(174, 34);
            this.label25.TabIndex = 33;
            this.label25.Text = "ÖĞRENCİ KAYIT";
            // 
            // student_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 469);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.error_msg_lbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.department_cmbx);
            this.Controls.Add(this.faculty_cmbx);
            this.Controls.Add(this.gsm_txtbx);
            this.Controls.Add(this.home_address_txtbx);
            this.Controls.Add(this.address_txtbx);
            this.Controls.Add(this.number_txtbx);
            this.Controls.Add(this.surname_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Controls.Add(this.record_btn);
            this.Name = "student_record";
            this.Text = "Öğrenci Kaydı";
            this.Load += new System.EventHandler(this.student_record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.TextBox surname_txtbx;
        private System.Windows.Forms.TextBox number_txtbx;
        private System.Windows.Forms.TextBox address_txtbx;
        private System.Windows.Forms.TextBox home_address_txtbx;
        private System.Windows.Forms.TextBox gsm_txtbx;
        private System.Windows.Forms.ComboBox faculty_cmbx;
        private System.Windows.Forms.ComboBox department_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label error_msg_lbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}