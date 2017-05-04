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
    public partial class timeout_ones : Form
    {
        public timeout_ones()
        {
            InitializeComponent();
        }

        MySqlDataAdapter dt_adapter;
        DataTable data_table = new DataTable();
        private void timeout_ones_Load(object sender, EventArgs e)
        {
            update_btn.Enabled = false;
            string query = "SELECT B.name, B.author,CONCAT_WS(' ',S.name,S.surname) AS Öğrenci_Adı, "+
                "DATEDIFF(NOW(), L.expiry_date) AS GECİKME_SÜRESİ " +
                "FROM lend_book AS L " +
                "JOIN student AS S ON (L.student_id=S.id) " +
                "JOIN book AS B ON(L.book_id=B.id) " +
                "WHERE  DATEDIFF(NOW(), L.expiry_date)>0;";
            dt_adapter = new MySqlDataAdapter(query, DatabaseProcess.myconn);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(dt_adapter);
            dt_adapter.Fill(data_table);
            result_dtGrdVw.DataSource = data_table;

            if (result_dtGrdVw.Rows.Count <= 0)
            {
                MessageBox.Show("Zamanında teslim edilmeyen kitap yok");
            }
                
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
    }
}
