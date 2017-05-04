namespace Kutuphane_Otomasyon_Sistemi
{
    partial class lending
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
            this.student_search_txtbx = new System.Windows.Forms.TextBox();
            this.book_search_txtbx = new System.Windows.Forms.TextBox();
            this.student_result_lstbx = new System.Windows.Forms.ListBox();
            this.lend_btn = new System.Windows.Forms.Button();
            this.book_result_lstbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error_msg_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.student_info_lbl = new System.Windows.Forms.Label();
            this.book_info_lbl = new System.Windows.Forms.Label();
            this.waiting_recive_book_lbl = new System.Windows.Forms.Label();
            this.lend_time_cmbx = new System.Windows.Forms.ComboBox();
            this.change_lend_time_rdbtn = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_search_txtbx
            // 
            this.student_search_txtbx.Location = new System.Drawing.Point(78, 92);
            this.student_search_txtbx.Name = "student_search_txtbx";
            this.student_search_txtbx.Size = new System.Drawing.Size(266, 20);
            this.student_search_txtbx.TabIndex = 0;
            this.student_search_txtbx.TextChanged += new System.EventHandler(this.student_search_txtbx_TextChanged);
            // 
            // book_search_txtbx
            // 
            this.book_search_txtbx.Location = new System.Drawing.Point(406, 92);
            this.book_search_txtbx.Name = "book_search_txtbx";
            this.book_search_txtbx.Size = new System.Drawing.Size(306, 20);
            this.book_search_txtbx.TabIndex = 1;
            this.book_search_txtbx.TextChanged += new System.EventHandler(this.book_search_txtbx_TextChanged);
            // 
            // student_result_lstbx
            // 
            this.student_result_lstbx.FormattingEnabled = true;
            this.student_result_lstbx.Location = new System.Drawing.Point(78, 118);
            this.student_result_lstbx.Name = "student_result_lstbx";
            this.student_result_lstbx.Size = new System.Drawing.Size(266, 173);
            this.student_result_lstbx.TabIndex = 2;
            this.student_result_lstbx.SelectedIndexChanged += new System.EventHandler(this.student_result_lstbx_SelectedIndexChanged);
            // 
            // lend_btn
            // 
            this.lend_btn.Location = new System.Drawing.Point(19, 120);
            this.lend_btn.Name = "lend_btn";
            this.lend_btn.Size = new System.Drawing.Size(108, 34);
            this.lend_btn.TabIndex = 3;
            this.lend_btn.Text = "Ödünç Ver";
            this.lend_btn.UseVisualStyleBackColor = true;
            this.lend_btn.Click += new System.EventHandler(this.lend_btn_Click);
            // 
            // book_result_lstbx
            // 
            this.book_result_lstbx.FormattingEnabled = true;
            this.book_result_lstbx.Location = new System.Drawing.Point(406, 118);
            this.book_result_lstbx.Name = "book_result_lstbx";
            this.book_result_lstbx.Size = new System.Drawing.Size(306, 173);
            this.book_result_lstbx.TabIndex = 4;
            this.book_result_lstbx.SelectedIndexChanged += new System.EventHandler(this.book_result_lstbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Arama";
            // 
            // error_msg_lbl
            // 
            this.error_msg_lbl.AutoSize = true;
            this.error_msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg_lbl.Location = new System.Drawing.Point(339, 333);
            this.error_msg_lbl.Name = "error_msg_lbl";
            this.error_msg_lbl.Size = new System.Drawing.Size(63, 13);
            this.error_msg_lbl.TabIndex = 7;
            this.error_msg_lbl.Text = "Hata Mesaji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(350, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(718, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(718, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(350, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kitabın verileceği öğrenci:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Verilecek Kitap:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Öğrenciğin aldığı kitaplar:";
            // 
            // student_info_lbl
            // 
            this.student_info_lbl.AutoSize = true;
            this.student_info_lbl.Location = new System.Drawing.Point(165, 18);
            this.student_info_lbl.Name = "student_info_lbl";
            this.student_info_lbl.Size = new System.Drawing.Size(112, 13);
            this.student_info_lbl.TabIndex = 17;
            this.student_info_lbl.Text = "Öğrenci  ismi-numarası";
            // 
            // book_info_lbl
            // 
            this.book_info_lbl.AutoSize = true;
            this.book_info_lbl.Location = new System.Drawing.Point(165, 47);
            this.book_info_lbl.Name = "book_info_lbl";
            this.book_info_lbl.Size = new System.Drawing.Size(78, 13);
            this.book_info_lbl.TabIndex = 18;
            this.book_info_lbl.Text = "Kitap ismi-kodu";
            // 
            // waiting_recive_book_lbl
            // 
            this.waiting_recive_book_lbl.AutoSize = true;
            this.waiting_recive_book_lbl.Location = new System.Drawing.Point(165, 76);
            this.waiting_recive_book_lbl.Name = "waiting_recive_book_lbl";
            this.waiting_recive_book_lbl.Size = new System.Drawing.Size(81, 13);
            this.waiting_recive_book_lbl.TabIndex = 19;
            this.waiting_recive_book_lbl.Text = "Elindeki kitaplar";
            // 
            // lend_time_cmbx
            // 
            this.lend_time_cmbx.FormattingEnabled = true;
            this.lend_time_cmbx.Location = new System.Drawing.Point(381, 309);
            this.lend_time_cmbx.Name = "lend_time_cmbx";
            this.lend_time_cmbx.Size = new System.Drawing.Size(70, 21);
            this.lend_time_cmbx.TabIndex = 20;
            // 
            // change_lend_time_rdbtn
            // 
            this.change_lend_time_rdbtn.AutoSize = true;
            this.change_lend_time_rdbtn.Location = new System.Drawing.Point(285, 313);
            this.change_lend_time_rdbtn.Name = "change_lend_time_rdbtn";
            this.change_lend_time_rdbtn.Size = new System.Drawing.Size(90, 17);
            this.change_lend_time_rdbtn.TabIndex = 21;
            this.change_lend_time_rdbtn.TabStop = true;
            this.change_lend_time_rdbtn.Text = "Süreyi değiştir";
            this.change_lend_time_rdbtn.UseVisualStyleBackColor = true;
            this.change_lend_time_rdbtn.CheckedChanged += new System.EventHandler(this.change_lend_time_rdbtn_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gün";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.lend_btn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.waiting_recive_book_lbl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.book_info_lbl);
            this.groupBox1.Controls.Add(this.student_info_lbl);
            this.groupBox1.Location = new System.Drawing.Point(174, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 173);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaylar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(300, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 34);
            this.label18.TabIndex = 32;
            this.label18.Text = "ÖDÜNÇ VERME";
            // 
            // lending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 525);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.error_msg_lbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.change_lend_time_rdbtn);
            this.Controls.Add(this.lend_time_cmbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book_result_lstbx);
            this.Controls.Add(this.student_result_lstbx);
            this.Controls.Add(this.book_search_txtbx);
            this.Controls.Add(this.student_search_txtbx);
            this.Name = "lending";
            this.Text = "ÖDÜNÇ VERME";
            this.Load += new System.EventHandler(this.lending_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox student_search_txtbx;
        private System.Windows.Forms.TextBox book_search_txtbx;
        private System.Windows.Forms.ListBox student_result_lstbx;
        private System.Windows.Forms.Button lend_btn;
        private System.Windows.Forms.ListBox book_result_lstbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error_msg_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label student_info_lbl;
        private System.Windows.Forms.Label book_info_lbl;
        private System.Windows.Forms.Label waiting_recive_book_lbl;
        private System.Windows.Forms.ComboBox lend_time_cmbx;
        private System.Windows.Forms.RadioButton change_lend_time_rdbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
    }
}