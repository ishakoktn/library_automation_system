namespace Kutuphane_Otomasyon_Sistemi
{
    partial class timeout_ones
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
            this.result_dtGrdVw = new System.Windows.Forms.DataGridView();
            this.update_chckbx = new System.Windows.Forms.CheckBox();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(321, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(196, 34);
            this.label18.TabIndex = 34;
            this.label18.Text = "SÜRESİ DOLANAR";
            // 
            // result_dtGrdVw
            // 
            this.result_dtGrdVw.AllowUserToAddRows = false;
            this.result_dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dtGrdVw.Location = new System.Drawing.Point(-2, 103);
            this.result_dtGrdVw.Name = "result_dtGrdVw";
            this.result_dtGrdVw.Size = new System.Drawing.Size(870, 269);
            this.result_dtGrdVw.TabIndex = 35;
            // 
            // update_chckbx
            // 
            this.update_chckbx.AutoSize = true;
            this.update_chckbx.Location = new System.Drawing.Point(403, 416);
            this.update_chckbx.Name = "update_chckbx";
            this.update_chckbx.Size = new System.Drawing.Size(105, 17);
            this.update_chckbx.TabIndex = 37;
            this.update_chckbx.Text = "Güncellemeyi Aç";
            this.update_chckbx.UseVisualStyleBackColor = true;
            this.update_chckbx.CheckedChanged += new System.EventHandler(this.update_chckbx_CheckedChanged);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(392, 438);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(131, 23);
            this.update_btn.TabIndex = 36;
            this.update_btn.Text = "Güncelle";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // timeout_ones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 475);
            this.Controls.Add(this.update_chckbx);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.result_dtGrdVw);
            this.Controls.Add(this.label18);
            this.Name = "timeout_ones";
            this.Text = "SÜRESİ DOLANLAR - RAPORLAR";
            this.Load += new System.EventHandler(this.timeout_ones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView result_dtGrdVw;
        private System.Windows.Forms.CheckBox update_chckbx;
        private System.Windows.Forms.Button update_btn;
    }
}