namespace Kutuphane_Otomasyon_Sistemi
{
    partial class books
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
            this.search_txtbx = new System.Windows.Forms.TextBox();
            this.result_dtGrdVw = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.update_chckbx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // search_txtbx
            // 
            this.search_txtbx.Location = new System.Drawing.Point(223, 83);
            this.search_txtbx.Name = "search_txtbx";
            this.search_txtbx.Size = new System.Drawing.Size(330, 20);
            this.search_txtbx.TabIndex = 0;
            this.search_txtbx.TextChanged += new System.EventHandler(this.search_txtbx_TextChanged);
            // 
            // result_dtGrdVw
            // 
            this.result_dtGrdVw.AllowUserToAddRows = false;
            this.result_dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dtGrdVw.Location = new System.Drawing.Point(12, 111);
            this.result_dtGrdVw.Name = "result_dtGrdVw";
            this.result_dtGrdVw.Size = new System.Drawing.Size(870, 269);
            this.result_dtGrdVw.TabIndex = 2;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(399, 420);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(131, 23);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Güncelle";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // update_chckbx
            // 
            this.update_chckbx.AutoSize = true;
            this.update_chckbx.Location = new System.Drawing.Point(410, 398);
            this.update_chckbx.Name = "update_chckbx";
            this.update_chckbx.Size = new System.Drawing.Size(105, 17);
            this.update_chckbx.TabIndex = 8;
            this.update_chckbx.Text = "Güncellemeyi Aç";
            this.update_chckbx.UseVisualStyleBackColor = true;
            this.update_chckbx.CheckedChanged += new System.EventHandler(this.update_chckbx_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kitap adi, yazarı veya kodu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(280, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(294, 34);
            this.label18.TabIndex = 33;
            this.label18.Text = "KİTAP LİSTESİ - DÜZENLEME";
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 455);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_chckbx);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.result_dtGrdVw);
            this.Controls.Add(this.search_txtbx);
            this.Name = "books";
            this.Text = "KİTAP LİSTESİ - DÜZENLEME";
            this.Load += new System.EventHandler(this.books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_txtbx;
        private System.Windows.Forms.DataGridView result_dtGrdVw;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.CheckBox update_chckbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;

    }
}