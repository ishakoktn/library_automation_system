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
    public partial class faculty_record : Form
    {
        public faculty_record()
        {
            InitializeComponent();
        }

        private void faculty_name_txtbx_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void faculty_record_Load(object sender, EventArgs e)
        {   
            faculty_name_txtbx.Focus();
            error_msg_lbl.Text = string.Empty;
            

        }

        private void record_btn_Click(object sender, EventArgs e)
        {
            string faculty_name = faculty_name_txtbx.Text + " Fakültesi";

            string query = "INSERT INTO faculty(id, name, create_time) values(new_id, '{0}', NOW());";
            query = string.Format(query, faculty_name);

            Boolean result = DatabaseProcess.insert(query, "faculty");
            if (result)
            {
                MessageBox.Show("Fakülte kaydınız başarıyla tamamlanmıştır.");
            }
            else
            {
                error_msg_lbl.Text = DatabaseProcess.error_msg;
            }
        }
    }
}
