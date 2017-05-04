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
    public partial class receive_book : Form
    {
        public receive_book()
        {
            InitializeComponent();
        }
        string lend_book_id;
        private void student_search_txtbx_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string query, query2, query3, code,student_id="",book_id="",name,surname,number,author,temp="";
            DateTime lend_date,expiry_date, today = DateTime.Today;
            int remaining_time;
            query = "SELECT id,student_id,lend_date,expiry_date FROM lend_book WHERE book_id={0} AND recieve_case=0;";
            query2 = "SELECT name, surname, number FROM student WHERE id={0};";
            query3 = "SELECT id,name, author FROM book WHERE code='{0}';";

            code = search_txtbx.Text;
            query3 = string.Format(query3, code);
            
            try
            {
                DatabaseProcess.conn_open();
                MySqlCommand cmd = new MySqlCommand(query3, DatabaseProcess.myconn);
                MySqlDataReader dt_reader = cmd.ExecuteReader();
                dt_reader.Read();          
                book_id = dt_reader.GetInt32("id").ToString();
                name = dt_reader.GetString("name");
                author = dt_reader.GetString("author");
                book_info_lbl.Text = name + "  " + author + " | " + code;
                DatabaseProcess.conn_close();
                
            }
            catch 
            {}
            if (book_id != "")
            {
                query = string.Format(query, book_id);
                try
                {
                    DatabaseProcess.conn_open();
                    MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                    MySqlDataReader dt_reader = cmd.ExecuteReader();
                    dt_reader.Read();
                    lend_book_id = dt_reader.GetInt32("id").ToString();
                    student_id = dt_reader.GetInt32("student_id").ToString();
                    lend_date = dt_reader.GetDateTime("lend_date");
                    expiry_date = dt_reader.GetDateTime("expiry_date");
                    lend_date_lbl.Text = lend_date.ToShortDateString();
                    remaining_time = (int)today.Subtract(expiry_date).TotalDays;
                    if (remaining_time <= 0)
                        remaining_time_lbl.Text = Math.Abs((int)remaining_time) + " gün kaldı";
                    else
                        remaining_time_lbl.Text = Math.Abs((int)remaining_time) + " gün geçti";
                    DatabaseProcess.conn_close();
                }
                catch
                { 
                    DatabaseProcess.conn_close();
                }

                if(student_id != "")
                {
                    query2 = string.Format(query2, student_id);
                    try
                    {
                        DatabaseProcess.conn_open();
                        MySqlCommand cmd = new MySqlCommand(query2, DatabaseProcess.myconn);
                        MySqlDataReader dt_reader = cmd.ExecuteReader();
                        dt_reader.Read();
                            name = dt_reader.GetString("name");
                            surname = dt_reader.GetString("surname");
                            number = dt_reader.GetInt32("number").ToString();
                            student_info_lbl.Text = name + "  " + surname + " | " + number;
                        DatabaseProcess.conn_close();
                    }
                    catch
                    { }
                    groupBox1.Visible = true;
               
                }//if(student_id != "")
            
            
                else
                {
                    query = "SELECT name FROM book WHERE code='{0}';";
                    query = string.Format(query, code);
                    MessageBox.Show(query);
                    try
                    {
                        DatabaseProcess.conn_open();
                        MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        MySqlDataReader dt_reader = cmd.ExecuteReader();
                        while(dt_reader.Read())
                            temp = dt_reader.GetString("name");
                        DatabaseProcess.conn_close();
                    }
                    catch
                    {
                    
                    }
                    if(temp != "")
                        MessageBox.Show("Bu kitap zaten rafta");

                    else
                        MessageBox.Show("Kitap kodu hatalı!");
                }
            }//if(book_id != "")
            else
                MessageBox.Show("Kitap kodu hatalı!");
        }//student_search_txtbx_TextChanged

        private void receive_book_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void receive_it_btn_Click(object sender, EventArgs e)
        {
            string query;
            Boolean result;
            query = "UPDATE lend_book SET recieve_case=1,delivery_date=NOW() WHERE id={0};";
            query = string.Format(query, lend_book_id);
            result = DatabaseProcess.update(query);
            if (result)
            {
                MessageBox.Show("Kitap alındı");
                this.Close();
            }
                
            else
                MessageBox.Show("Bir sorun oluştu");

        }
    }
}
