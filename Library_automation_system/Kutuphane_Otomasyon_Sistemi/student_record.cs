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
    public partial class student_record : Form
    {
        public student_record()
        {
            InitializeComponent();
        }
        List<department> list_department = new List<department>();
        private void record_btn_Click(object sender, EventArgs e)
        {
           

            string name, surname, number,address, home_address, gsm, department_id;
            string query;
            int index;
            Boolean result;

            name = name_txtbx.Text;
            surname = surname_txtbx.Text;
            number = number_txtbx.Text;
            address = address_txtbx.Text;
            home_address = home_address_txtbx.Text;
            gsm = gsm_txtbx.Text;
            index = department_cmbx.SelectedIndex;
            department_id = list_department[index].Id.ToString();

            if (name != "" && surname != "" && number!="" && address != "" && home_address != ""  &&
                                                        department_id!="" && gsm.Length == 11)
            {
                query = "INSERT INTO student() values(new_id,{0},'{1}','{2}','{3}','{4}',{5},{6});";
                query = string.Format(query, number, name, surname, address, home_address, gsm,department_id);
                result = DatabaseProcess.insert(query, "student");
                if (result)
                    MessageBox.Show("Yeni öğrenci kaydı başarıyla tamamlandı");
                else
                {
                    MessageBox.Show(DatabaseProcess.error_msg);
                }
            }
            else
            {
                MessageBox.Show("hatalı");
            }
            DatabaseProcess.conn_close();

        }

        private void student_record_Load(object sender, EventArgs e)
        {
            string value;
            error_msg_lbl.Text = string.Empty;
            Utils.list_faculty();
            for (int i = 0; i < Utils.faculty_list.Count; i++)
            {
                value = Utils.faculty_list[i].Id.ToString() + " - " + Utils.faculty_list[i].Name;
                faculty_cmbx.Items.Add(value);
            }
        }

        private void faculty_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            department_cmbx.Items.Clear();

            int index,id;
            string faculty_id, query, value,name;
            index = faculty_cmbx.SelectedIndex;
            faculty_id = Utils.faculty_list[index].Id.ToString();

            query = "SELECT id, name FROM department WHERE faculty_id={0};";
            query = string.Format(query, faculty_id);
            DatabaseProcess.conn_open();
            MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
            MySqlDataReader dt_reader = cmd.ExecuteReader();
            while(dt_reader.Read())
            {
                id = dt_reader.GetInt32("id");
                name = dt_reader.GetString("name");
                value = id.ToString() + " - " + name;
                department_cmbx.Items.Add(value);
                list_department.Add(new department(id,name));
            }
            DatabaseProcess.conn_close();

        }

        private void number_txtbx_TextChanged(object sender, EventArgs e)
        {
        }

        private void number_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }

    //public class department
    //{
    //    public int id;
    //    public string name;
    //}
}
