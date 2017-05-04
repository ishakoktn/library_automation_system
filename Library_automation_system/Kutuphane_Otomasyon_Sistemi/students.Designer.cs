namespace Kutuphane_Otomasyon_Sistemi
{
    partial class students
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
            this.update_chckbx = new System.Windows.Forms.CheckBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.result_dtGrdVw = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.faculty_cmbx = new System.Windows.Forms.ComboBox();
            this.department_cmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // update_chckbx
            // 
            this.update_chckbx.AutoSize = true;
            this.update_chckbx.Location = new System.Drawing.Point(400, 405);
            this.update_chckbx.Name = "update_chckbx";
            this.update_chckbx.Size = new System.Drawing.Size(105, 17);
            this.update_chckbx.TabIndex = 11;
            this.update_chckbx.Text = "Güncellemeyi Aç";
            this.update_chckbx.UseVisualStyleBackColor = true;
            this.update_chckbx.CheckedChanged += new System.EventHandler(this.update_chckbx_CheckedChanged);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(389, 427);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(131, 23);
            this.update_btn.TabIndex = 10;
            this.update_btn.Text = "Güncelle";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // result_dtGrdVw
            // 
            this.result_dtGrdVw.AllowUserToAddRows = false;
            this.result_dtGrdVw.AllowUserToDeleteRows = false;
            this.result_dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dtGrdVw.Location = new System.Drawing.Point(2, 118);
            this.result_dtGrdVw.Name = "result_dtGrdVw";
            this.result_dtGrdVw.Size = new System.Drawing.Size(870, 269);
            this.result_dtGrdVw.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(239, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(327, 34);
            this.label18.TabIndex = 36;
            this.label18.Text = "ÖĞRENCİ LİSTESİ - DÜZENLEME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Öğrencinin adı, soyadı veya numarası";
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(200, 84);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(220, 20);
            this.search_txtbx.TabIndex = 34;
            this.search_txtbx.TextChanged += new System.EventHandler(this.search_txtbx_TextChanged);
            // 
            // faculty_cmbx
            // 
            this.faculty_cmbx.FormattingEnabled = true;
            this.faculty_cmbx.Location = new System.Drawing.Point(498, 83);
            this.faculty_cmbx.Name = "faculty_cmbx";
            this.faculty_cmbx.Size = new System.Drawing.Size(144, 21);
            this.faculty_cmbx.TabIndex = 37;
            this.faculty_cmbx.SelectedIndexChanged += new System.EventHandler(this.faculty_cmbx_SelectedIndexChanged);
            this.faculty_cmbx.SelectedValueChanged += new System.EventHandler(this.faculty_cmbx_SelectedValueChanged);
            // 
            // department_cmbx
            // 
            this.department_cmbx.FormattingEnabled = true;
            this.department_cmbx.Location = new System.Drawing.Point(696, 83);
            this.department_cmbx.Name = "department_cmbx";
            this.department_cmbx.Size = new System.Drawing.Size(166, 21);
            this.department_cmbx.TabIndex = 38;
            this.department_cmbx.TextChanged += new System.EventHandler(this.department_cmbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Fakültesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Bölümü";
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 468);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.department_cmbx);
            this.Controls.Add(this.faculty_cmbx);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_txtbx);
            this.Controls.Add(this.update_chckbx);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.result_dtGrdVw);
            this.Name = "students";
            this.Text = "ÖĞRENCİ LİSTESİ - DÜZENLEME";
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox update_chckbx;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView result_dtGrdVw;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_txtbx;
        private System.Windows.Forms.ComboBox faculty_cmbx;
        private System.Windows.Forms.ComboBox department_cmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}