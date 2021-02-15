using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookOS
{
    class Bookos_register
    {
        MySqlConnection con;
        public Bookos_register() {
            this.con = this.get_connecton();
        }
        private MySqlConnection get_connecton()
        {
            string str_connection = "data source=localhost;database=ovo;user id=root;password=root;pooling=false;charset=utf8";
            MySqlConnection con = new MySqlConnection(str_connection);
            return con;
        }

        public bool user_is_exist(string user_id_in) {
            //用户存在返回true
            string str_sql = "select * from bookos_user where user_id=" + "\"" + user_id_in + "\"";
            bool back_value = false;
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                back_value = true;
            }
            this.con.Close();
            return back_value;
        }

        public bool password_is_allow(string user_password_in) {
            //若密码允许返回true
            bool back_value = false;
            back_value = (user_password_in.Length >= 6 ? true : false);
            return back_value;
        }

        public bool user_register(string user_id_in, string user_password_in, string user_type_in = "1") {
            //注册成功返回true
            string str_sql = "insert into bookos_user (user_id, user_password, user_type) values ('"+ user_id_in + "', '" + user_password_in + "', " + user_type_in + ")";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            bool back_value = false;
            this.con.Open();
            back_value = (cmd.ExecuteNonQuery() == 0 ? false : true);
            this.con.Close();
            return back_value;
        }
    }
}
