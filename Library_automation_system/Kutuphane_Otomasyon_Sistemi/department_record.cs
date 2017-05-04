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
    
    public partial class department_record : Form
    {
        public department_record()
        {
            InitializeComponent();
        }



        
        private void department_record_Load(object sender, EventArgs e)
        {
            string value;
            error_msg_lbl.Text = string.Empty;
            Utils.list_faculty();
            for (int i = 0; i < Utils.faculty_list.Count; i++)
            {
                value = Utils.faculty_list[i].Id.ToString() + " - " + Utils.faculty_list[i].Name;
                faculty_name_cmbx.Items.Add(value);
            }
        }

        private void record_btn_Click(object sender, EventArgs e)
        {
            string department_name,faculty_id, query;
            int index;
            Boolean result;
            department_name = department_name_txtbx.Text;
            index = faculty_name_cmbx.SelectedIndex;

            if(department_name != "" && index > -1)
            {
                faculty_id = Utils.faculty_list[index].Id.ToString();
                query = "INSERT INTO department(id,faculty_id,name,create_date) "+
                                                        "values(new_id,{0},'{1}',NOW());";
                query = string.Format(query, faculty_id, department_name);
                result = DatabaseProcess.insert(query, "department");
                if(result)
                {
                    MessageBox.Show("Bölüm başarıyla kayıt ededildi");
                }
                else
                {
                    error_msg_lbl.Text = DatabaseProcess.error_msg;
                }
                DatabaseProcess.conn_close();
            }

        }
    }
    
}
