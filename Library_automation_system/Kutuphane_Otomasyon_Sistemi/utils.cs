using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;



public static class Utils
{
    public static UserDetail User;
    public static string get_hash(string input)
    {
        StringBuilder Sb = new StringBuilder();

        using (SHA256 hash = SHA256Managed.Create())
        {
            Encoding enc = Encoding.UTF8;
            Byte[] result = hash.ComputeHash(enc.GetBytes(input));

            foreach (Byte b in result)
                Sb.Append(b.ToString("x2"));
        }

        return Sb.ToString();
    }

    
    public static Boolean is_email(string email)
    {
        char[] valid_chars = "abcdefghijklmnopqrstuvwxyz0123456789@-_.".ToCharArray();
        Boolean valid = false;

        
        foreach(char c in email.ToCharArray())
        {
            foreach(char s in valid_chars)
            {
                if (c == s)
                    valid = true;
            }
            if (valid == false)
                return false;
        }

        if (!(email.Contains("@") && email.Contains(".")))
            return false;
        if (email.Length < 8)
            return false;
       
        return true;
    }
    // Need to develop 

    public  static List<faculty> faculty_list = new List<faculty>();
    public static void list_faculty()
    {
        faculty_list.Clear();
        int new_id;
        string new_name;
        string query = "SELECT id,name FROM faculty;";
        DatabaseProcess.conn_open();
        MySqlCommand cmd = new MySqlCommand(query, DatabaseProcess.myconn);
        MySqlDataReader dt_reader = cmd.ExecuteReader();
        while(dt_reader.Read())
        {
            new_id = dt_reader.GetInt32("id");
            new_name = dt_reader.GetString("name");
            faculty_list.Add(new faculty(new_id, new_name));
        }
            
            DatabaseProcess.conn_close();
    }
    public static string error_message(string msg)
    {
        msg = msg.Replace("'","$");
        string unique = msg.Split('$')[3];
        string column = unique.Replace("_UNIQUE","");
        return column;     

    }
    
}

public class DatabaseProcess
{
    private static string conn_string = "server=localhost;port=3306;user id=root;database=library;password=1234";
    public static MySqlConnection myconn = new MySqlConnection(conn_string);
    public static string error_msg = "";
    public static Boolean conn_open()
    {
         try 
	    {	        
		     myconn.Open();
             return true;
	    }
	    catch (Exception)
	    {
		    return false;
	    }
    }
    public static Boolean conn_close()
    {
        try 
	    {	        
		    myconn.Close();
            return true;
	    }
	    catch (Exception)
	    {
		    return false;
		}
    }
    private static int find_last_id(string table_name)
    {
        int last_id = -1; 
        string query = "SELECT * from "+ table_name +";";
        conn_open();
        MySqlCommand cmd = new MySqlCommand(query, myconn);
        MySqlDataReader dt_reader;
        dt_reader = cmd.ExecuteReader();
        while(dt_reader.Read())
            last_id = dt_reader.GetInt32("id");
        conn_close();
        return last_id;

    }
    public static Boolean insert(string query, string table_name)
    {
        string id = (find_last_id(table_name) + 1).ToString();
        query = query.Replace("new_id", id);
        try
        {   
            conn_open();        
            MySqlCommand cmd = new MySqlCommand(query, myconn);            
            MySqlDataReader dt_reader = cmd.ExecuteReader();
            conn_close();
            return true;
        }
        catch (Exception ex)
        {
            string msg = ex.ToString();
            if (msg.Contains("UNIQUE"))
            {
                error_msg = "Girdiğiniz değer başka bir kullanıcının bilgisi ile çakışıyor (ipucu:{0}).";
                error_msg = string.Format(error_msg, Utils.error_message(msg));
            }         

            return false;
        }
       

    }


  

    public static Boolean update(string query)
    {
        error_msg = "";
        try
        {
            conn_open();
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader dt_reader = cmd.ExecuteReader();
            conn_close();
            return true;
        }
        catch(Exception ex)
        {
            error_msg = ex.ToString();
            return false;
        }
        
    }

    public static Boolean delete(string query)
    {

        error_msg = "";
        try
        {
            conn_open();
            MySqlCommand cmd = new MySqlCommand(query, myconn);
            MySqlDataReader dt_reader = cmd.ExecuteReader();
            conn_close();
            return true;
        }
        catch (Exception ex)
        {
            error_msg = ex.ToString();
            return false;
        }
    }
}

public class faculty
{
    public int Id;
    public string Name;

    public faculty(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}

public class student
{
    public int Id;

    public student(int id)
    {
        this.Id = id;
    }
}

public class book
{
    public int Id;

    public book(int id)
    {
        this.Id = id;
    }
}
public class department
{
    public int Id;
    public string Nmae;

    public department(int id, string name)
    {
        this.Id = id;
        this.Nmae = name;
    }
}
public struct UserDetail
{
    public int id;
    public string name, surname;
}
