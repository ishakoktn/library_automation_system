namespace Kutuphane_Otomasyon_Sistemi
{
    partial class lending_report
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
            this.label18 = new System.Windows.Forms.Label();
            this.search_student_txtbx = new System.Windows.Forms.TextBox();
            this.result_dtGrdVw = new System.Windows.Forms.DataGridView();
            this.recieved_rdbtn = new System.Windows.Forms.RadioButton();
            this.not_recieved_rdbtn = new System.Windows.Forms.RadioButton();
            this.all_rdbtn = new System.Windows.Forms.RadioButton();
            this.search_book_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(354, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 34);
            this.label18.TabIndex = 39;
            this.label18.Text = "İŞLEM RAPORU";
            // 
            // search_student_txtbx
            // 
            this.search_student_txtbx.Location = new System.Drawing.Point(269, 123);
            this.search_student_txtbx.Name = "search_student_txtbx";
            this.search_student_txtbx.Size = new System.Drawing.Size(223, 20);
            this.search_student_txtbx.TabIndex = 38;
            this.search_student_txtbx.TextChanged += new System.EventHandler(this.search_student_txtbx_TextChanged);
            // 
            // result_dtGrdVw
            // 
            this.result_dtGrdVw.AllowUserToAddRows = false;
            this.result_dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dtGrdVw.Location = new System.Drawing.Point(12, 161);
            this.result_dtGrdVw.Name = "result_dtGrdVw";
            this.result_dtGrdVw.Size = new System.Drawing.Size(870, 269);
            this.result_dtGrdVw.TabIndex = 37;
            // 
            // recieved_rdbtn
            // 
            this.recieved_rdbtn.AutoSize = true;
            this.recieved_rdbtn.Location = new System.Drawing.Point(563, 123);
            this.recieved_rdbtn.Name = "recieved_rdbtn";
            this.recieved_rdbtn.Size = new System.Drawing.Size(133, 17);
            this.recieved_rdbtn.TabIndex = 40;
            this.recieved_rdbtn.TabStop = true;
            this.recieved_rdbtn.Text = "Sadece teslim edilenler";
            this.recieved_rdbtn.UseVisualStyleBackColor = true;
            this.recieved_rdbtn.CheckedChanged += new System.EventHandler(this.recieved_rdbtn_CheckedChanged);
            // 
            // not_recieved_rdbtn
            // 
            this.not_recieved_rdbtn.AutoSize = true;
            this.not_recieved_rdbtn.Location = new System.Drawing.Point(702, 123);
            this.not_recieved_rdbtn.Name = "not_recieved_rdbtn";
            this.not_recieved_rdbtn.Size = new System.Drawing.Size(152, 17);
            this.not_recieved_rdbtn.TabIndex = 41;
            this.not_recieved_rdbtn.TabStop = true;
            this.not_recieved_rdbtn.Text = "Sadece teslim edilmeyenler";
            this.not_recieved_rdbtn.UseVisualStyleBackColor = true;
            this.not_recieved_rdbtn.CheckedChanged += new System.EventHandler(this.not_recieved_rdbtn_CheckedChanged);
            // 
            // all_rdbtn
            // 
            this.all_rdbtn.AutoSize = true;
            this.all_rdbtn.Location = new System.Drawing.Point(507, 123);
            this.all_rdbtn.Name = "all_rdbtn";
            this.all_rdbtn.Size = new System.Drawing.Size(50, 17);
            this.all_rdbtn.TabIndex = 42;
            this.all_rdbtn.TabStop = true;
            this.all_rdbtn.Text = "hepsi";
            this.all_rdbtn.UseVisualStyleBackColor = true;
            this.all_rdbtn.CheckedChanged += new System.EventHandler(this.all_rdbtn_CheckedChanged);
            // 
            // search_book_txtbx
            // 
            this.search_book_txtbx.Location = new System.Drawing.Point(28, 123);
            this.search_book_txtbx.Name = "search_book_txtbx";
            this.search_book_txtbx.Size = new System.Drawing.Size(223, 20);
            this.search_book_txtbx.TabIndex = 43;
            this.search_book_txtbx.TextChanged += new System.EventHandler(this.search_book_txtbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Kitap adı,yazarı veya kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Öğrenci ismi veya numarası";
            // 
            // lending_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_book_txtbx);
            this.Controls.Add(this.all_rdbtn);
            this.Controls.Add(this.not_recieved_rdbtn);
            this.Controls.Add(this.recieved_rdbtn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.search_student_txtbx);
            this.Controls.Add(this.result_dtGrdVw);
            this.Name = "lending_report";
            this.Text = "İŞLEM RAPORU";
            this.Load += new System.EventHandler(this.lending_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox search_student_txtbx;
        private System.Windows.Forms.DataGridView result_dtGrdVw;
        private System.Windows.Forms.RadioButton recieved_rdbtn;
        private System.Windows.Forms.RadioButton not_recieved_rdbtn;
        private System.Windows.Forms.RadioButton all_rdbtn;
        private System.Windows.Forms.TextBox search_book_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}