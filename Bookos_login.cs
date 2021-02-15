using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookOS
{
    class Bookos_login
    {
        private MySqlConnection con;
        
        public Bookos_login() {
            this.con = this.get_connecton();
        }
        private MySqlConnection get_connecton() {
            string str_connection = "data source=localhost;database=ovo;user id=root;password=root;pooling=false;charset=utf8";
            MySqlConnection con = new MySqlConnection(str_connection);
            return con;
        }
        public string get_user_password(string user_id_in)
        {
            //通过user_id获取user_password
            string str_sql = "select * from bookos_user where user_id=" + "\"" + user_id_in + "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            string user_psw = "";
            if (result.Read()) {
                user_psw = result.GetString("user_password");
            }
            this.con.Close();
            return user_psw;
        }

        public int get_user_type(string user_id) {
            //通过user_id获取user_type
            string str_sql = "select * from bookos_user where user_id=" + "\"" + user_id + "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            int user_type = 0;
            if (result.Read())
            {
                user_type = result.GetInt32("user_type");
            }
            this.con.Close();
            return user_type;
        }
    }
}
