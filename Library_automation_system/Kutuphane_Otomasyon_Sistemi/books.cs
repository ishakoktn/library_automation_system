using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class books : Form
    {
        public books()
        {
            InitializeComponent();
        }
        MySqlDataAdapter dt_adapter;
        DataTable data_table = new DataTable();
        private void books_Load(object sender, EventArgs e)
        {
            update_btn.Enabled = false;
            search_txtbx.Text = " ";
            search_txtbx.Text = "";
        }

        private void update_chckbx_CheckedChanged(object sender, EventArgs e)
        {
             if (update_chckbx.Checked == false)
                update_btn.Enabled = false;
             else
                update_btn.Enabled = true;
        }


        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dt_adapter.Update(data_table);
                MessageBox.Show("Güncellendi");
            }
            catch
            {
                MessageBox.Show("Kayıt güncellenemedi");
            }
            
        }

        private void search_txtbx_TextChanged(object sender, EventArgs e)
        {
            if (result_dtGrdVw.Rows.Count > 0)
            {
                result_dtGrdVw.DataSource = null;
                data_table.Clear();
            }
            string query, name;
            query = "SELECT * from book WHERE name Like '%{0}%' OR code Like '%{0}%' OR author Like '%{0}%';";
            name= search_txtbx.Text;

            // sadece boşluk karakterinden oluşan stringlerin engellenmesi gerekiyor.
            if(search_txtbx.Text == "" )
            {
                query = "SELECT * from book";
            }
            else
            {
                query = string.Format(query, name);
            }
            dt_adapter = new MySqlDataAdapter(query, DatabaseProcess.myconn);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(dt_adapter);
            dt_adapter.Fill(data_table);
            result_dtGrdVw.DataSource = data_table;
            result_dtGrdVw.Columns[0].Visible = false;

           
        }
    }
}
