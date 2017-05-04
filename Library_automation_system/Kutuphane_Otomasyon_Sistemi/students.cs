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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }
        List<faculty> list_faculty = new List<faculty>();
        List<department> list_department = new List<department>();

        MySqlDataAdapter dt_adapter;
        DataTable data_table = new DataTable();

        private void search_txtbx_TextChanged(object sender, EventArgs e)
        {
            if (result_dtGrdVw.Rows.Count > 0)
            {
                result_dtGrdVw.DataSource = null;
                data_table.Clear();
            }

            string query, name, with_faculty, with_department, faculty_name, department_name;
            int faculty_id=0, department_id=0;

            name = search_txtbx.Text;
            faculty_name     = faculty_cmbx.Text;
            department_name  = department_cmbx.Text;
            
            if(faculty_cmbx.SelectedIndex >= 0)
                faculty_id       = list_faculty[faculty_cmbx.SelectedIndex].Id;
            if (department_cmbx.SelectedIndex >= 0)
                department_id    = list_department[department_cmbx.SelectedIndex].Id;



            query = "SELECT * from student WHERE (concat_ws(' ',name, surname) like '%{0}%' OR number like '%{0}%') {1}{2};";
            with_faculty = "AND department_id IN (SELECT id FROM department WHERE faculty_id={0})";
            with_department = "AND department_id={0}";

            if (department_name != "")
            {
                with_department = string.Format(with_department, department_id.ToString());
                query = string.Format(query, name,"",with_department);
            }
            else if(faculty_name != "")
            {
                with_faculty = string.Format(with_faculty, faculty_id.ToString());
                query = string.Format(query, name, with_faculty, "");
            }
            else
                query = string.Format(query, name, "", "");


            dt_adapter = new MySqlDataAdapter(query, DatabaseProcess.myconn);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(dt_adapter);
            dt_adapter.Fill(data_table);
            result_dtGrdVw.DataSource = data_table;
            result_dtGrdVw.Columns[0].Visible = false;
        }

        private void students_Load(object sender, EventArgs e)
        {
            update_btn.Enabled = false;

            string query,name;
            int id;
            query = "SELECT id,name FROM faculty";
            try
            {
                DatabaseProcess.conn_open();
                MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                MySqlDataReader dt_reader = cmd.ExecuteReader();
                while (dt_reader.Read())
                {
                    name = dt_reader.GetString("name");
                    id   = dt_reader.GetInt32("id");

                    faculty_cmbx.Items.Add(name);
                    list_faculty.Add(new faculty(id, name));
                }
                DatabaseProcess.conn_close();
            }
            catch 
            {}

        }

        private void faculty_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            department_cmbx.Items.Clear();
            string query, name;
            int id,faculty_id, index;
            index = faculty_cmbx.SelectedIndex;
            faculty_id = list_faculty[index].Id;
            query = "SELECT id,name FROM department WHERE faculty_id={0}";
            query = string.Format(query, faculty_id);
            try
            {
                DatabaseProcess.conn_open();
                MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                MySqlDataReader dt_reader = cmd.ExecuteReader();
                while (dt_reader.Read())
                {
                    name = dt_reader.GetString("name");
                    id = dt_reader.GetInt32("id");

                    department_cmbx.Items.Add(name);
                    list_department.Add(new department(id,name));
                }
                DatabaseProcess.conn_close();
            }
            catch
            { }
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

        private void faculty_cmbx_SelectedValueChanged(object sender, EventArgs e)
        {
            string txt = search_txtbx.Text;
            search_txtbx.Text += " ";
            search_txtbx.Text = txt;
        }

        private void department_cmbx_TextChanged(object sender, EventArgs e)
        {
            string txt = search_txtbx.Text;
            search_txtbx.Text += " ";
            search_txtbx.Text = txt;
        }

        private void update_chckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (update_chckbx.Checked == false)
                update_btn.Enabled = false;
            else
                update_btn.Enabled = true;
        }
    }
}
