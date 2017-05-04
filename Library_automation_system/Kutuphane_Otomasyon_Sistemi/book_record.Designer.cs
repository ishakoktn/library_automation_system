namespace Kutuphane_Otomasyon_Sistemi
{
    partial class book_record
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
            this.code_txtbx = new System.Windows.Forms.TextBox();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.isbn_txtbx = new System.Windows.Forms.TextBox();
            this.page_count_txbx = new System.Windows.Forms.TextBox();
            this.keys_txtbx = new System.Windows.Forms.TextBox();
            this.author_txtbx = new System.Windows.Forms.TextBox();
            this.year_cmbx = new System.Windows.Forms.ComboBox();
            this.error_msg_lbl = new System.Windows.Forms.Label();
            this.category_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // record_btn
            // 
            this.record_btn.Location = new System.Drawing.Point(265, 308);
            this.record_btn.Name = "record_btn";
            this.record_btn.Size = new System.Drawing.Size(102, 23);
            this.record_btn.TabIndex = 0;
            this.record_btn.Text = "Kaydet";
            this.record_btn.UseVisualStyleBackColor = true;
            this.record_btn.Click += new System.EventHandler(this.record_btn_Click);
            // 
            // code_txtbx
            // 
            this.code_txtbx.Location = new System.Drawing.Point(206, 120);
            this.code_txtbx.Name = "code_txtbx";
            this.code_txtbx.Size = new System.Drawing.Size(236, 20);
            this.code_txtbx.TabIndex = 1;
            // 
            // name_txtbx
            // 
            this.name_txtbx.Location = new System.Drawing.Point(206, 68);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(236, 20);
            this.name_txtbx.TabIndex = 2;
            // 
            // isbn_txtbx
            // 
            this.isbn_txtbx.Location = new System.Drawing.Point(206, 146);
            this.isbn_txtbx.Name = "isbn_txtbx";
            this.isbn_txtbx.Size = new System.Drawing.Size(236, 20);
            this.isbn_txtbx.TabIndex = 4;
            // 
            // page_count_txbx
            // 
            this.page_count_txbx.Location = new System.Drawing.Point(206, 226);
            this.page_count_txbx.Name = "page_count_txbx";
            this.page_count_txbx.Size = new System.Drawing.Size(236, 20);
            this.page_count_txbx.TabIndex = 5;
            // 
            // keys_txtbx
            // 
            this.keys_txtbx.Location = new System.Drawing.Point(206, 252);
            this.keys_txtbx.Name = "keys_txtbx";
            this.keys_txtbx.Size = new System.Drawing.Size(236, 20);
            this.keys_txtbx.TabIndex = 6;
            // 
            // author_txtbx
            // 
            this.author_txtbx.Location = new System.Drawing.Point(206, 94);
            this.author_txtbx.Name = "author_txtbx";
            this.author_txtbx.Size = new System.Drawing.Size(236, 20);
            this.author_txtbx.TabIndex = 7;
            // 
            // year_cmbx
            // 
            this.year_cmbx.FormattingEnabled = true;
            this.year_cmbx.Location = new System.Drawing.Point(206, 199);
            this.year_cmbx.Name = "year_cmbx";
            this.year_cmbx.Size = new System.Drawing.Size(236, 21);
            this.year_cmbx.TabIndex = 8;
            // 
            // error_msg_lbl
            // 
            this.error_msg_lbl.AutoSize = true;
            this.error_msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg_lbl.Location = new System.Drawing.Point(210, 292);
            this.error_msg_lbl.Name = "error_msg_lbl";
            this.error_msg_lbl.Size = new System.Drawing.Size(62, 13);
            this.error_msg_lbl.TabIndex = 9;
            this.error_msg_lbl.Text = "Hata mesajı";
            // 
            // category_cmbx
            // 
            this.category_cmbx.FormattingEnabled = true;
            this.category_cmbx.Location = new System.Drawing.Point(206, 172);
            this.category_cmbx.Name = "category_cmbx";
            this.category_cmbx.Size = new System.Drawing.Size(236, 21);
            this.category_cmbx.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kitap adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Yazarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kitabın Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ISBN Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yayın Yılı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sayfa Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Anahtar Kelimeler:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(448, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(448, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(448, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(448, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "**";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(448, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(448, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(448, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 24);
            this.label15.TabIndex = 27;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(12, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "* işaretli alanların doldurulması zorunldur";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(12, 357);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(289, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "** işaretli alanların doldurulması zorunldur ayrıca tekil olmalıdır";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(247, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 34);
            this.label18.TabIndex = 32;
            this.label18.Text = "KİTAP KAYIT";
            // 
            // book_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 376);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_cmbx);
            this.Controls.Add(this.error_msg_lbl);
            this.Controls.Add(this.year_cmbx);
            this.Controls.Add(this.author_txtbx);
            this.Controls.Add(this.keys_txtbx);
            this.Controls.Add(this.page_count_txbx);
            this.Controls.Add(this.isbn_txtbx);
            this.Controls.Add(this.name_txtbx);
            this.Controls.Add(this.code_txtbx);
            this.Controls.Add(this.record_btn);
            this.Name = "book_record";
            this.Text = "Kitap Kaydı";
            this.Load += new System.EventHandler(this.book_record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.TextBox code_txtbx;
        private System.Windows.Forms.TextBox name_txtbx;
        private System.Windows.Forms.TextBox isbn_txtbx;
        private System.Windows.Forms.TextBox page_count_txbx;
        private System.Windows.Forms.TextBox keys_txtbx;
        private System.Windows.Forms.TextBox author_txtbx;
        private System.Windows.Forms.ComboBox year_cmbx;
        private System.Windows.Forms.Label error_msg_lbl;
        private System.Windows.Forms.ComboBox category_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}