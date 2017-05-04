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
using MySql.Data;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class singup_frm : Form
    {
        public singup_frm()
        {
            InitializeComponent();
        }

       

        private void singup_btn_Click(object sender, EventArgs e)
        {
            string name, surname,gsm, email, password, password2;
            name      = name_txtbx.Text;
            surname   = surname_txtbx.Text;
            gsm       = gsm_txtbx.Text;
            email     = email_txtbx.Text;
            password  = password__txtbx.Text;
            password2 = password2_txtbx.Text;

            if((password == password2) && Utils.is_email(email) && gsm.Length==11)
            {
                MessageBox.Show("Test");
                string hash = Utils.get_hash(password);
                string tel = gsm.Replace(" ", "");
                DateTime date = DateTime.Now;
                string query = "INSERT INTO User(id,name,surname,singup_date,gsm,email,password)" + 
                    " values(new_id,'new_name','new_surname',NOW(),'new_tel','new_email','new_password');";
                query = query.Replace("new_name", name);
                query = query.Replace("new_surname", surname);
                query = query.Replace("new_tel", tel);
                query = query.Replace("new_email", email);
                query = query.Replace("new_password", hash);

                Boolean a = DatabaseProcess.insert(query, "User");
                if (a == true)
                {
                    MessageBox.Show("Kayıt işleminiz başarıyla tamamlandı.\n     Artık giriş yapabilirsiniz.");
                    this.Close();
                    singin_frm singin_form = new singin_frm();
                    singin_form.Show();
                }
                else
                {
                    error_lbl.Text = DatabaseProcess.error_msg;
                }
                 
            }
            else
            {
                if (password != password2)
                {
                    error_lbl.Text = "Şifreler aynı değil!";
                    password__txtbx.Text = password2_txtbx.Text = "";
                }
                else if (!Utils.is_email(email))
                    error_lbl.Text = "Girdiğiniz email hatalı!";
            }
            
        }

        private void gsm_txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //Just accept digits
        }

        private void gsm_txtbx_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void singup_Load(object sender, EventArgs e)
        {
            gsm_txtbx.Text = "0";
            error_lbl.Text =  "";

            //// create database  /////

            //try
            //{
                Boolean result = DatabaseProcess.conn_open();
                if(!result)
                {
                    string connline = "server=127.0.0.1;port=3306;user id=root;password=1234";
                    string query = "CREATE DATABASE library";
                    MySqlConnection conn = new MySqlConnection(connline);
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.Connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        query = "use library; CREATE TABLE book (id int(11) NOT NULL,code varchar(45) NOT NULL,name varchar(45) NOT NULL,category varchar(45) NOT NULL,published_year int(11) NOT NULL,ISBN_number varchar(45) NOT NULL,page_count int(11) NOT NULL,search_keys varchar(250) NOT NULL,author varchar(45) NOT NULL,PRIMARY KEY (id),UNIQUE KEY id_UNIQUE (id),UNIQUE KEY code_UNIQUE (code));";
                        DatabaseProcess.conn_open();
                        cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        cmd.ExecuteNonQuery();
                        DatabaseProcess.conn_close();

                        query = "CREATE TABLE faculty (" +
                                    "id int(11) NOT NULL," +
                                    "name varchar(100) NOT NULL," +
                                    "create_time datetime NOT NULL," +
                                    "PRIMARY KEY (id)," +
                                    "UNIQUE KEY id_UNIQUE (id)," +
                                     "UNIQUE KEY name_UNIQUE (name))";

                        cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        DatabaseProcess.conn_open();
                        cmd.ExecuteNonQuery();
                        DatabaseProcess.conn_close();

                        query = "CREATE TABLE department (" +
                                "id int(11) NOT NULL," +
                                "faculty_id int(11) NOT NULL," +
                                "name varchar(100) NOT NULL," +
                                "create_date datetime NOT NULL," +
                                "PRIMARY KEY (id)," +
                                "UNIQUE KEY id_UNIQUE (id)," +
                                "UNIQUE KEY name_UNIQUE (name)," +
                                "KEY fakulty_id_idx (faculty_id)," +
                                "CONSTRAINT fakulty_id FOREIGN KEY (faculty_id) " +
                                "REFERENCES faculty (id) ON UPDATE NO ACTION)";
                        cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        DatabaseProcess.conn_open();
                        cmd.ExecuteNonQuery();
                        DatabaseProcess.conn_close();

                        query = "CREATE TABLE student (" +
                                     "id int(11) NOT NULL," +
                                     "number int(11) NOT NULL," +
                                     "name varchar(45) NOT NULL," +
                                     "surname varchar(45) NOT NULL," +
                                     "adress varchar(255) NOT NULL," +
                                     "hometown_address varchar(255) NOT NULL," +
                                     "gsm varchar(11) NOT NULL," +
                                     "department_id int(11) NOT NULL," +
                                     "PRIMARY KEY (id)," +
                                    " UNIQUE KEY id_UNIQUE (id)," +
                                     "UNIQUE KEY number_UNIQUE (number)," +
                                     "UNIQUE KEY gsm_number_UNIQUE (gsm)," +
                                     "KEY department_id_idx (department_id)," +
                                     "CONSTRAINT department_id FOREIGN KEY (department_id) REFERENCES department (id) ON DELETE NO ACTION ON UPDATE NO ACTION)";

                        cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        DatabaseProcess.conn_open();
                        cmd.ExecuteNonQuery();
                        DatabaseProcess.conn_close();

                        query = "CREATE TABLE user (" +
                                       "id int(11) NOT NULL," +
                                       "name varchar(45) NOT NULL," +
                                       "surname varchar(45) NOT NULL," +
                                       "singup_date datetime NOT NULL," +
                                       "gsm varchar(11) NOT NULL," +
                                       "email varchar(45) NOT NULL," +
                                       "password varchar(255) NOT NULL," +
                                       "PRIMARY KEY (id)," +
                                      " UNIQUE KEY id_UNIQUE (id)," +
                                      " UNIQUE KEY tel_UNIQUE (gsm)," +
                                      " UNIQUE KEY email_UNIQUE (email))";

                        cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        DatabaseProcess.conn_open();
                        cmd.ExecuteNonQuery();
                        DatabaseProcess.conn_close();

                        query = "CREATE TABLE lend_book (" +
                                       "id int(11) NOT NULL," +
                                       "student_id int(11) NOT NULL," +
                                       "book_id int(11) NOT NULL," +
                                       "recieve_by_id int(11) DEFAULT NULL," +
                                       "lend_date datetime NOT NULL," +
                                       "expiry_date datetime NOT NULL," +
                                       "delivery_date datetime DEFAULT NULL," +
                                       "recieve_case tinyint(1) DEFAULT 0," +
                                       "PRIMARY KEY (id)," +
                                       "UNIQUE KEY id_UNIQUE (id)," +
                                       "KEY student_id_idx (student_id)," +
                                       "KEY book_id_idx (book_id)," +
                                       "KEY recieve_by_id_idx (recieve_by_id)," +
                                       "CONSTRAINT book_id FOREIGN KEY (book_id) REFERENCES book (id) ON DELETE NO ACTION ON UPDATE NO ACTION," +
                                       "CONSTRAINT recieve_by_id FOREIGN KEY (recieve_by_id) REFERENCES user (id) ON DELETE NO ACTION ON UPDATE NO ACTION," +
                                       "CONSTRAINT student_id FOREIGN KEY (student_id) REFERENCES student (id) ON DELETE NO ACTION ON UPDATE NO ACTION) ";

                        cmd = new MySqlCommand(query, DatabaseProcess.myconn);
                        DatabaseProcess.conn_open();
                        cmd.ExecuteNonQuery();
                        DatabaseProcess.conn_close();
                    }
                    catch (Exception)
                    {
                    }
                    

                }
                else
                    DatabaseProcess.conn_close();
            //}
            //catch
            //{
            //    MessageBox.Show("Hata verdi");
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            singin_frm frm = new singin_frm();
            frm.Show();
        }
    }
}
