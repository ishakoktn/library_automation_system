using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class lending : Form
    {
        public lending()
        {
            InitializeComponent();
        }
        List<student> list_student = new List<student>();
        List<book> list_book = new List<book>();
        int book_index, student_index;
        private void lend_btn_Click(object sender, EventArgs e)
        {
            Boolean result;

            int user_id, student_id, book_id, expiry_date, recieve_case;
            string query = "INSERT INTO lend_book(id,student_id,book_id,recieve_by_id,lend_date,expiry_date)"+
                                            "values(new_id,{0},{1},{2},NOW(),"+ 
                                            "DATE_ADD(NOW(),INTERVAL {3} DAY));";
            string query2 = "SELECT recieve_case FROM lend_book WHERE book_id={0}";
            user_id     = Utils.User.id;
            student_id  = list_student[student_index].Id;
            book_id     = list_book[book_index].Id;

            query2 = string.Format(query2, book_id.ToString());
            DatabaseProcess.conn_open();
            MySqlCommand cmd = new MySqlCommand(query2, DatabaseProcess.myconn);
            MySqlDataReader dt_reader = cmd.ExecuteReader();
            if (dt_reader.Read())
                recieve_case = dt_reader.GetByte("recieve_case");
            else
                recieve_case = 1;
            DatabaseProcess.conn_close();

            if (change_lend_time_rdbtn.Enabled == false)
                expiry_date = Convert.ToInt32(lend_time_cmbx.Text);
            else
            {
                expiry_date = 15;
            }


            
            if(student_index > -1 && book_index > -1 && recieve_case == 1 )
            {
                query = string.Format(query, student_id, book_id, user_id, "15");
                result = DatabaseProcess.insert(query, "lend_book");
                if (result)
                    MessageBox.Show("Tamamlandı!");
                else
                    error_msg_lbl.Text = DatabaseProcess.error_msg;
            }
            else
            {
                if (recieve_case == 0)
                    MessageBox.Show("Bu kitap şu an rafta değil!");
                else
                    error_msg_lbl.Text = "Lütfen gerekli alanları doldurunuz.";
            }
            
        }

        private void student_search_txtbx_TextChanged(object sender, EventArgs e)
        {
            student_result_lstbx.Items.Clear();


            string query = "SELECT * FROM student WHERE {0}";
            string search_with_name = " concat_ws(' ',name, surname) like '%{0}%'";
            string search_with_number = "number={0}";
        
             if(student_search_txtbx.Text.Length>2)
             {
                 list_student.Clear();
                 string name,surname="", string_number;
                 int number,id;

                 if(student_search_txtbx.Text.Any(char.IsLetter))
                 {
                     name = student_search_txtbx.Text;
                     query = string.Format(query, search_with_name);
                     query = string.Format(query, name);
                     
                
                 }
                 else
                 {
                     string_number = student_search_txtbx.Text;
                     query = string.Format(query, search_with_number);
                     query = string.Format(query, string_number);

                 }

                 try
                 {
                     DatabaseProcess.conn_open();
                     MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                     MySqlDataReader dt_reader = cmd.ExecuteReader();
                     while (dt_reader.Read())
                     {
                         id = dt_reader.GetInt32("id");
                         name = dt_reader.GetString("name");
                         surname = dt_reader.GetString("surname");
                         number = dt_reader.GetInt32("number");
                         string_number = number.ToString();
                         list_student.Add(new student(id));
                         student_result_lstbx.Items.Add(name + "  " + surname + " | " + string_number);
                     }

                     DatabaseProcess.conn_close();
                 }
                 catch { }

                 if(student_result_lstbx.Items.Count == 0)
                 {
                     student_result_lstbx.Items.Add("Eşleşme yok");
                 }

             }//if
             else
             {
                 student_result_lstbx.Items.Add("Arama için en az 3 karakter girmelisiniz.");
             }
      



        }//student_search_txtbx_TextChanged

        private void lending_Load(object sender, EventArgs e)
        {
            error_msg_lbl.Text = string.Empty;
            lend_time_cmbx.Text = "15";
            lend_time_cmbx.Enabled = false;
            student_info_lbl.Text = book_info_lbl.Text = waiting_recive_book_lbl.Text = "";
        }

        private void book_search_txtbx_TextChanged(object sender, EventArgs e)
        {
            // Keys ile arama çalışmıyo!!
            book_result_lstbx.Items.Clear();
            int recieve_case;
            int id;
            string search,name, author, code;
            string query            = "SELECT * FROM book WHERE {0}";
            string search_with_name = "name LIKE '%{0}%' OR code LIKE '%{1}%' OR ISBN_number LIKE '%{2}%' OR author LIKE '%{3}%';";
            string query2 = "SELECT recieve_case FROM lend_book WHERE book_id={0}"+
                        " AND lend_date=(SELECT MAX(lend_date) FROM lend_book WHERE book_id={0});";
            string query3;
            string[] temp;
            if (book_search_txtbx.Text.Length > 2)
            {
                list_book.Clear();
                search = book_search_txtbx.Text;

                query = string.Format(query, search_with_name);
                query = string.Format(query, search, search, search, search);
                try
                {
                    DatabaseProcess.conn_open();
                    MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                    MySqlDataReader dt_reader = cmd.ExecuteReader();
                    while (dt_reader.Read())
                    {
                        id          = dt_reader.GetInt32("id");
                        name        = dt_reader.GetString("name").ToUpper();
                        author      = dt_reader.GetString("author");
                        code        = dt_reader.GetString("code");

                        list_book.Add(new book(id));
                        
                        book_result_lstbx.Items.Add(name + " | " + author + " | " + code);
                    }
                DatabaseProcess.conn_close();
                    
                }
                catch
                { }

                if(book_result_lstbx.Items.Count <= 0)
                {
                    book_result_lstbx.Items.Add("Eşleşen kayıt yok");
                }
                else if(book_search_txtbx.Text.Length>2)
                {
                    // Start  with ">>>"  substring which books on students
                    temp = new string[list_book.Count];
                    for (int i = 0; i < list_book.Count; i++)
                    {
                        temp[i] = book_result_lstbx.Items[i].ToString();
                    }
                    book_result_lstbx.Items.Clear();
                    for (int i = 0; i < list_book.Count; i++)
                    {
                        query3 = string.Format(query2, list_book[i].Id.ToString());
                        DatabaseProcess.conn_open();
                        MySqlCommand cmd2 = new MySqlCommand(query3, DatabaseProcess.myconn);
                        MySqlDataReader dt_reader2 = cmd2.ExecuteReader();
                        if (dt_reader2.Read())
                        {
                            recieve_case = dt_reader2.GetByte("recieve_case");
                            if (recieve_case == 0)
                                temp[i] = "<!> | " + temp[i];
                        }

                        book_result_lstbx.Items.Add(temp[i]);
                        
                        DatabaseProcess.conn_close();
                    }

                }
            }//if(book_search_txtbx.Text.Length > 2)
                
            else
            {
                book_result_lstbx.Items.Add("Arama için en az 3 karakter girmelisiniz.");
            }

        }

        private void student_result_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query="",query2="",query3,book_name,code,waiting_recieve ="";
            int student_id;
            List<int> book_id = new List<int>();
            if (student_result_lstbx.SelectedIndex>-1)
            {
                student_index         = student_result_lstbx.SelectedIndex;
                student_info_lbl.Text = student_result_lstbx.SelectedItem.ToString();
                student_id            = list_student[student_index].Id;
                query  = "SELECT book_id FROM lend_book WHERE student_id={0} && recieve_case=0";
                query2 = "SELECT name,code FROM book WHERE id={0};";
                query = string.Format(query, student_id.ToString());
            }
            
            
            try
            {
                
                DatabaseProcess.conn_open();
                MySqlCommand cmd          = new MySqlCommand(query, DatabaseProcess.myconn);
                MySqlDataReader dt_reader;
                dt_reader = cmd.ExecuteReader();
                while(dt_reader.Read())
                {
                    book_id.Add(dt_reader.GetInt32("book_id"));
                }
                DatabaseProcess.conn_close();
                if (book_id.Count == 0)
                {
                    waiting_recive_book_lbl.Text = "Ödünç aldığı kitap yok";
                }
                else
                {
                    for (int i = 0; i < book_id.Count; i++)
                    {
                        DatabaseProcess.conn_open();
                        query3 = string.Format(query2, book_id[i].ToString());
                        cmd = new MySqlCommand(query3, DatabaseProcess.myconn);
                        dt_reader = cmd.ExecuteReader();
                        dt_reader.Read();
                        code = dt_reader.GetString("code");
                        book_name = dt_reader.GetString("name");
                        if (i > 0)
                        {
                            waiting_recieve += "\n" + book_name + " | " + code;
                        }
                        else
                        {
                            waiting_recieve = book_name + " | " + code;
                        }
                        waiting_recive_book_lbl.Text = waiting_recieve;
                        DatabaseProcess.conn_close();
                    }
                   
                }
                   
            }
            catch (Exception)
            {
                
            }

        }

        private void book_result_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (book_result_lstbx.SelectedIndex > -1)
            {
                book_index = book_result_lstbx.SelectedIndex;
                book_info_lbl.Text = book_result_lstbx.SelectedItem.ToString();
            }
        }

        private void change_lend_time_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(change_lend_time_rdbtn.Checked == true)
            {   
                lend_time_cmbx.Enabled = true;
                for (int i = 0; i < 60; i++)
                {
                    lend_time_cmbx.Items.Add(i.ToString());
                }
                
            }
            else
            {
                lend_time_cmbx.Text = "15";
                lend_time_cmbx.Enabled = false;

            }
        }//book_search_txtbx_TextChanged
    }
}
