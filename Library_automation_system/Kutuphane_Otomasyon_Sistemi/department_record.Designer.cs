namespace Kutuphane_Otomasyon_Sistemi
{
    partial class department_record
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
            this.error_msg_lbl = new System.Windows.Forms.Label();
            this.department_name_txtbx = new System.Windows.Forms.TextBox();
            this.record_btn = new System.Windows.Forms.Button();
            this.faculty_name_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error_msg_lbl
            // 
            this.error_msg_lbl.AutoSize = true;
            this.error_msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg_lbl.Location = new System.Drawing.Point(272, 168);
            this.error_msg_lbl.Name = "error_msg_lbl";
            this.error_msg_lbl.Size = new System.Drawing.Size(73, 13);
            this.error_msg_lbl.TabIndex = 6;
            this.error_msg_lbl.Text = "Hata mesajları";
            // 
            // department_name_txtbx
            // 
            this.department_name_txtbx.Location = new System.Drawing.Point(205, 87);
            this.department_name_txtbx.Name = "department_name_txtbx";
            this.department_name_txtbx.Size = new System.Drawing.Size(224, 20);
            this.department_name_txtbx.TabIndex = 5;
            // 
            // record_btn
            // 
            this.record_btn.Location = new System.Drawing.Point(275, 193);
            this.record_btn.Name = "record_btn";
            this.record_btn.Size = new System.Drawing.Size(75, 23);
            this.record_btn.TabIndex = 4;
            this.record_btn.Text = "Kaydet";
            this.record_btn.UseVisualStyleBackColor = true;
            this.record_btn.Click += new System.EventHandler(this.record_btn_Click);
            // 
            // faculty_name_cmbx
            // 
            this.faculty_name_cmbx.FormattingEnabled = true;
            this.faculty_name_cmbx.Location = new System.Drawing.Point(205, 124);
            this.faculty_name_cmbx.Name = "faculty_name_cmbx";
            this.faculty_name_cmbx.Size = new System.Drawing.Size(224, 21);
            this.faculty_name_cmbx.TabIndex = 7;
            this.faculty_name_cmbx.Text = "Fakülte seçiniz...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Yeni Bölüm İsmi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bağlı Bulunduğu Fakülte:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(215, 250);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(189, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Tüm alanların doldurulması zorunludur,.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(234, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 34);
            this.label18.TabIndex = 34;
            this.label18.Text = "BÖLÜM EKLEME";
            // 
            // department_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 272);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faculty_name_cmbx);
            this.Controls.Add(this.error_msg_lbl);
            this.Controls.Add(this.department_name_txtbx);
            this.Controls.Add(this.record_btn);
            this.Name = "department_record";
            this.Text = "BÖLÜM EKLEME";
            this.Load += new System.EventHandler(this.department_record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error_msg_lbl;
        private System.Windows.Forms.TextBox department_name_txtbx;
        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.ComboBox faculty_name_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
    }
}