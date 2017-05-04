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
    public partial class lending_report : Form
    {
        public lending_report()
        {
            InitializeComponent();
        }
        MySqlDataAdapter dt_adapter;
        DataTable data_table = new DataTable();

        private void search()
        {

            if (result_dtGrdVw.Rows.Count > 0)
            {
                result_dtGrdVw.DataSource = null;
                data_table.Clear();
            }

            string student_name="", book_name="", query;
            student_name = search_student_txtbx.Text;
            book_name = search_book_txtbx.Text;
            query = "SELECT DISTINCT concat(s.name,' ',s.surname) as Öğrenci,s.number,b.name, b.code, b.author,"+
                    "  lb.lend_date,lb.delivery_date from student s " +
                    "  JOIN lend_book lb ON (lb.recieve_case={2} OR lb.recieve_case={3})" +
                    "  JOIN  book b ON (b.name like '%{1}%' OR b.code like '%{1}%' OR b.code like '%{1}%') " +
                    "  JOIN student ON (concat(s.name,' ',s.surname) like '%{0}%' OR s.number like '%{0}%')" +
                    "  WHERE s.id=lb.student_id AND b.id=lb.book_id;";
            if (all_rdbtn.Checked == true)
                query = string.Format(query, student_name, book_name, "0", "1");
            else if (recieved_rdbtn.Checked == true)
                query = string.Format(query, student_name, book_name, "1", "1");
            else if (not_recieved_rdbtn.Checked == true)
                query = string.Format(query, student_name, book_name, "0", "0");

            dt_adapter = new MySqlDataAdapter(query, DatabaseProcess.myconn);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(dt_adapter);
            dt_adapter.Fill(data_table);
            result_dtGrdVw.DataSource = data_table;
        }
        private void search_student_txtbx_TextChanged(object sender, EventArgs e)
        {

            search();
        }

        private void search_book_txtbx_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void lending_report_Load(object sender, EventArgs e)
        {
            all_rdbtn.Checked = true;
        }

        private void recieved_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void not_recieved_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }

        private void all_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
