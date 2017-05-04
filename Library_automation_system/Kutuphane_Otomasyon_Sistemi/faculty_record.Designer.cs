namespace Kutuphane_Otomasyon_Sistemi
{
    partial class faculty_record
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
            this.faculty_name_txtbx = new System.Windows.Forms.TextBox();
            this.error_msg_lbl = new System.Windows.Forms.Label();
            this.faculty_lbl = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // record_btn
            // 
            this.record_btn.Location = new System.Drawing.Point(198, 144);
            this.record_btn.Name = "record_btn";
            this.record_btn.Size = new System.Drawing.Size(75, 23);
            this.record_btn.TabIndex = 0;
            this.record_btn.Text = "Kaydet";
            this.record_btn.UseVisualStyleBackColor = true;
            this.record_btn.Click += new System.EventHandler(this.record_btn_Click);
            // 
            // faculty_name_txtbx
            // 
            this.faculty_name_txtbx.Location = new System.Drawing.Point(133, 83);
            this.faculty_name_txtbx.Name = "faculty_name_txtbx";
            this.faculty_name_txtbx.Size = new System.Drawing.Size(224, 20);
            this.faculty_name_txtbx.TabIndex = 1;
            this.faculty_name_txtbx.TextChanged += new System.EventHandler(this.faculty_name_txtbx_TextChanged);
            // 
            // error_msg_lbl
            // 
            this.error_msg_lbl.AutoSize = true;
            this.error_msg_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_msg_lbl.Location = new System.Drawing.Point(195, 119);
            this.error_msg_lbl.Name = "error_msg_lbl";
            this.error_msg_lbl.Size = new System.Drawing.Size(73, 13);
            this.error_msg_lbl.TabIndex = 2;
            this.error_msg_lbl.Text = "Hata mesajları";
            // 
            // faculty_lbl
            // 
            this.faculty_lbl.AutoSize = true;
            this.faculty_lbl.Location = new System.Drawing.Point(363, 90);
            this.faculty_lbl.Name = "faculty_lbl";
            this.faculty_lbl.Size = new System.Drawing.Size(49, 13);
            this.faculty_lbl.TabIndex = 3;
            this.faculty_lbl.Text = "Fakültesi";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(102, 204);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(291, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Fakülte isminin girilmesi zorunludur, ayrıca benzersiz olmalıdır.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fakülte Adı:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(165, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 34);
            this.label18.TabIndex = 34;
            this.label18.Text = "FAKÜLTE KAYIT";
            // 
            // faculty_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 244);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.faculty_lbl);
            this.Controls.Add(this.error_msg_lbl);
            this.Controls.Add(this.faculty_name_txtbx);
            this.Controls.Add(this.record_btn);
            this.Name = "faculty_record";
            this.Text = "FAKÜLTE KAYDI";
            this.Load += new System.EventHandler(this.faculty_record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.TextBox faculty_name_txtbx;
        private System.Windows.Forms.Label error_msg_lbl;
        private System.Windows.Forms.Label faculty_lbl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
    }
}