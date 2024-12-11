using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sunny.UI.Win32;

namespace WindowsFormsApp1
{
    class DB
    {
        //string connectionString = "server=localhost;port=3306;user id=nyhj;database=yethannyhj;password=nyhj!@345;Charset=utf8;SslMode=none";

        // 海创园
        string connectionString = "server=localhost;port=3306;user id=root;database=nyhj;password=hc!@123;Charset=utf8;SslMode=none";

        //string connectionString = "server=121.43.123.32;port=3306;user id=nyhj;database=yethannyhj;password=nyhj!@345;Charset=utf8;SslMode=none;Allow User Variables=True";
        //Server=127.0.0.1;Database=yethannyhj;User ID = root; Password=123456;Port=3306
        public void ADD(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand mc = new MySqlCommand(sql, connection);
            connection.Open();
            int result = mc.ExecuteNonQuery();
            connection.Close();

        }
        public void DEL(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand mc = new MySqlCommand(sql, connection);
            connection.Open();
            int result = mc.ExecuteNonQuery();
            connection.Close();
        }
        public int UPD(string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand mc = new MySqlCommand(sql, connection);
            mc.CommandTimeout = 30; //设置命令超时时间为30s
            connection.Open();
            int result = mc.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public DataTable SEA(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection);
            mda.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
