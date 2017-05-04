using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class main_panel : Form
    {
        public main_panel()
        {
            InitializeComponent();
        }

        public Form show_singin { get; set; }
        private void main_panel_Load(object sender, EventArgs e)
        {
            username_lbl.Text = Utils.User.name + " " + Utils.User.surname;

        }

        private void lending_btn_Click(object sender, EventArgs e)
        {
            lending frm = new lending();
            frm.Show();
        }

        private void student_record_btn_Click(object sender, EventArgs e)
        {
            student_record frm = new student_record();
            frm.Show();
        }

        private void faculty_record_btn_Click(object sender, EventArgs e)
        {
            faculty_record frm = new faculty_record();
            frm.Show();
        }

        private void department_record_btn_Click(object sender, EventArgs e)
        {
            department_record frm = new department_record();
            frm.Show();
        }

        private void book_record_btn_Click(object sender, EventArgs e)
        {
            book_record frm = new book_record();
            frm.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?"+
                                      "\nGiriş sayfasına yönlendirileceksiniz.","ONAY",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    if (Application.OpenForms[i].Name != "singin_frm")
                        Application.OpenForms[i].Close();
                }
                Utils.User = new UserDetail();
                this.show_singin.Show();
                this.Close();
            }
            else
            {
                //Do not anything
            }
        }

        private void receive_btn_Click(object sender, EventArgs e)
        {
            receive_book frm = new receive_book();
            frm.Show();
        }

        private void main_panel_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void book_list_btn_Click(object sender, EventArgs e)
        {
            books frm = new books();
            frm.Show();
        }

        private void student_list_btn_Click(object sender, EventArgs e)
        {
            students frm = new students();
            frm.Show();
        }

        private void lending_report_btn_Click(object sender, EventArgs e)
        {
            lending_report frm = new lending_report();
            frm.Show();
        }

        private void experied_ones_btn_Click(object sender, EventArgs e)
        {
            timeout_ones frm = new timeout_ones();
            frm.Show();
        }
    }
}
