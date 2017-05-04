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
    public partial class book_record : Form
    {
        public book_record()
        {
            InitializeComponent();
        }

        private void book_record_Load(object sender, EventArgs e)
        {
            error_msg_lbl.Text = string.Empty;
            int this_year = DateTime.Now.Year;
            for (int i = 1850; i <= this_year; i++)
            {
                year_cmbx.Items.Add(i.ToString());
            }

            string[] category_list = {
                                         "Akademik",
                                         "Bilgisayar",
                                         "Bilim - Mühendislik",
                                         "Çocuk Kitapları",
                                         "Edebiyat",
                                         "Eğitim",
                                         "Ekonomi",
                                         "Felsefe",
                                         "Genel Konular",
                                         "Gezi ve Rehper Kitapları",
                                         "Hobi",
                                         "Hukuk",
                                         "İlginç kitaplar",
                                         "İnsan ve Toplum",
                                         "Müzik",
                                         "Periyodik Yayınlar",
                                         "Politika Siyaset",
                                         "Psikoloji",
                                         "Sağlık",
                                         "Sanat",
                                         "Sosyoloji",
                                         "Tarih",
                                         "Yabancı Dilde Kitaplar"
                                     };
            for (int i = 0; i < category_list.Length; i++)
            {
                category_cmbx.Items.Add(category_list[i]);
            }

        }

        private void record_btn_Click(object sender, EventArgs e)
        {
            string code, name, category, isbn_number, keys, author, page_count, print_year;
            string query;
            Boolean result;

            name        = name_txtbx.Text;
            author      = author_txtbx.Text;
            category    = category_cmbx.Text;
            code        = code_txtbx.Text;
            isbn_number = isbn_txtbx.Text;
            keys        = keys_txtbx.Text;
            page_count  = page_count_txbx.Text;
            print_year  = year_cmbx.Text;

            if (name != "" && author != "" && category != "" && code != "" && isbn_number != "" && print_year != "")
            {
                query = "INSERT INTO book() values(new_id, '{0}','{1}','{2}',{3},'{4}',{5},'{6}','{7}');";
                query = string.Format(query, code, name, category, print_year, isbn_number, page_count, keys, author);
                result = DatabaseProcess.insert(query, "book");

                if(result)
                {
                    MessageBox.Show("Kitap kaydı başarıyla gerçekleşmiştir.");
                }
                else
                {
                    error_msg_lbl.Text = DatabaseProcess.error_msg;
                }
            }
            else
            {
                    error_msg_lbl.Text = "Yıldızlı alanların doldurulması zorunludur.";
            }
        }
    }
}
