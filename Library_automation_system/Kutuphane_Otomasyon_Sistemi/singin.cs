using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Authentication;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class singin_frm : Form
    {
        public singin_frm()
        {
            InitializeComponent();
        }

   
        private void giris_btn_Click(object sender, EventArgs e)
        {
            string email, password;
            email    = email_txtbx.Text;
            password = psswrd_txtbx.Text;
            string hash = Utils.get_hash(password);
            string query = "SELECT * FROM User WHERE email='"+email+"' and password='"+hash+"';";
            try
            {
                    DatabaseProcess.conn_open();
                    MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                    MySqlDataReader dt_reader = cmd.ExecuteReader();
                    if (dt_reader.Read())
                    {
                        Utils.User.id       = dt_reader.GetInt32("id");
                        Utils.User.name     = dt_reader.GetString("name");
                        Utils.User.surname  = dt_reader.GetString("surname");
                
                        int id = dt_reader.GetInt32("id");
                
                        main_panel main_panel_form = new main_panel();
                        main_panel_form.show_singin = this;
                        this.Visible = false;
                        main_panel_form.Show();
                     }
            
                    else
                    {
                        msg_lbl.Text = "Email, parola combinasyonu bulunamadı. Bilgileri kontrol ediniz.";
                    }
                    DatabaseProcess.conn_close();
            }
            catch (Exception)
            {
                
            }
            

        }

        private void kulllanici_kaydi_lnklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            singup_frm new_form = new singup_frm();
            new_form.Show();
        }

        private void singin_frm_Load(object sender, EventArgs e)
        {
            psswrd_txtbx.PasswordChar = '\u25CF';

           
        }
    }
}
