namespace Kutuphane_Otomasyon_Sistemi
{
    partial class receive_book
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
            this.receive_it_btn = new System.Windows.Forms.Button();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.student_info_lbl = new System.Windows.Forms.Label();
            this.book_info_lbl = new System.Windows.Forms.Label();
            this.remaining_time_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lend_date_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // receive_it_btn
            // 
            this.receive_it_btn.Location = new System.Drawing.Point(148, 133);
            this.receive_it_btn.Name = "receive_it_btn";
            this.receive_it_btn.Size = new System.Drawing.Size(75, 23);
            this.receive_it_btn.TabIndex = 0;
            this.receive_it_btn.Text = "Teslim Al";
            this.receive_it_btn.UseVisualStyleBackColor = true;
            this.receive_it_btn.Click += new System.EventHandler(this.receive_it_btn_Click);
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(129, 59);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(260, 20);
            this.search_txtbx.TabIndex = 1;
            this.search_txtbx.TextChanged += new System.EventHandler(this.student_search_txtbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitabın Kodu:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.student_info_lbl);
            this.groupBox1.Controls.Add(this.book_info_lbl);
            this.groupBox1.Controls.Add(this.remaining_time_lbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lend_date_lbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.receive_it_btn);
            this.groupBox1.Location = new System.Drawing.Point(86, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 162);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETAYLAR";
            // 
            // student_info_lbl
            // 
            this.student_info_lbl.AutoSize = true;
            this.student_info_lbl.Location = new System.Drawing.Point(105, 69);
            this.student_info_lbl.Name = "student_info_lbl";
            this.student_info_lbl.Size = new System.Drawing.Size(78, 13);
            this.student_info_lbl.TabIndex = 8;
            this.student_info_lbl.Text = "Öğrenci bilgileri";
            // 
            // book_info_lbl
            // 
            this.book_info_lbl.AutoSize = true;
            this.book_info_lbl.Location = new System.Drawing.Point(106, 36);
            this.book_info_lbl.Name = "book_info_lbl";
            this.book_info_lbl.Size = new System.Drawing.Size(65, 13);
            this.book_info_lbl.TabIndex = 7;
            this.book_info_lbl.Text = "Kitap bilgileri";
            // 
            // remaining_time_lbl
            // 
            this.remaining_time_lbl.AutoSize = true;
            this.remaining_time_lbl.Location = new System.Drawing.Point(266, 102);
            this.remaining_time_lbl.Name = "remaining_time_lbl";
            this.remaining_time_lbl.Size = new System.Drawing.Size(67, 13);
            this.remaining_time_lbl.TabIndex = 6;
            this.remaining_time_lbl.Text = "<süre bilgisi>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Süre Durumu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alıdığı Tarih:";
            // 
            // lend_date_lbl
            // 
            this.lend_date_lbl.AutoSize = true;
            this.lend_date_lbl.Location = new System.Drawing.Point(94, 102);
            this.lend_date_lbl.Name = "lend_date_lbl";
            this.lend_date_lbl.Size = new System.Drawing.Size(59, 13);
            this.lend_date_lbl.TabIndex = 3;
            this.lend_date_lbl.Text = "<alış tarihi>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alan Öğrenci:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitap:";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(419, 56);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "Tamam";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(196, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 34);
            this.label18.TabIndex = 31;
            this.label18.Text = "TESLİM ALMA";
            // 
            // receive_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 331);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_txtbx);
            this.Name = "receive_book";
            this.Text = "TESLİM ALMA";
            this.Load += new System.EventHandler(this.receive_book_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button receive_it_btn;
        private System.Windows.Forms.TextBox search_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label remaining_time_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lend_date_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label student_info_lbl;
        private System.Windows.Forms.Label book_info_lbl;
        private System.Windows.Forms.Label label18;
    }
}