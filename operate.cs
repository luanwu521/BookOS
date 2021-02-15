using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOS
{
    internal class Book_node
    {
        public string book_id;
        public string book_name;
        public string book_author;
        public int book_count;

    }
    class operate
    {
        private MySqlConnection con;
        public operate()
        {
            this.con = this.get_connecton();
        }
        private MySqlConnection get_connecton()
        {
            string str_connection = "data source=localhost;database=ovo;user id=root;password=root;pooling=false;charset=utf8";
            MySqlConnection con = new MySqlConnection(str_connection);
            return con;
        }
        public ArrayList get_book() {
            //获取存储在数据库中的所有图书 
            ArrayList back_list = new ArrayList();
            string str_sql = "select * from bookos_book";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read()) {
                Book_node add_node = new Book_node();
                add_node.book_id = result.GetString("book_id");
                add_node.book_name = result.GetString("book_name");
                add_node.book_author = result.GetString("book_author");
                add_node.book_count = result.GetInt32("book_count");
                back_list.Add(add_node);
            }
            this.con.Close();
            return back_list;
        }

        public bool book_is_exsit(string book_id_in) {
            //图书存在返回true
            bool back_value = false;
            string str_sql = "select * from bookos_book where book_id=" + "\"" + book_id_in + "\"";
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

        public bool remove_book(string book_id_in) {
            bool back_value = false;
            string str_sql = "delete from bookos_book where book_id = " + "\"" + book_id_in + "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            back_value = (cmd.ExecuteNonQuery() == 0 ? false : true);
            this.con.Close();
            return back_value;
        }

        public bool add_book(Book_node book) {
            bool back_value = false;
            string str_sql = "insert into bookos_book (book_id, book_name, book_author, book_count) values ( ";
            str_sql += "\"" + book.book_id + "\",";
            str_sql += "\"" + book.book_name + "\",";
            str_sql += "\"" + book.book_author + "\",";
            str_sql +=  book.book_count.ToString();
            str_sql += ")";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            back_value = (cmd.ExecuteNonQuery() == 0 ? false : true);
            this.con.Close();
            return back_value;
        }

        public int get_book_count(string book_id_in) {
            string str_sql = "select book_count from bookos_book where book_id = ";
            int back_value = 0;
            str_sql += "\"";
            str_sql += book_id_in;
            str_sql += "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.Read()) {
                back_value = result.GetInt32("book_count");
            }
            this.con.Close();
            return back_value;
        }

        public string get_book_name(string book_id_in)
        {
            string str_sql = "select book_name from bookos_book where book_id = ";
            string back_value = "";
            str_sql += "\"";
            str_sql += book_id_in;
            str_sql += "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                back_value = result.GetString("book_name");
            }
            this.con.Close();
            return back_value;
        }

        private void add_book_to_borrow_list(string book_id_in, string book_owner) {
            //将图书放入借阅列表
            string str_sql = "insert into bookos_borrow (book_id, book_owner) values (";
            str_sql += "\"";
            str_sql += book_id_in;
            str_sql += "\",";
            str_sql += "\"";
            str_sql += book_owner;
            str_sql += "\"";
            str_sql += ")";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            cmd.ExecuteNonQuery();
            this.con.Close();
        }

        public bool borrow_book(string book_id_in, int borrow_count, string who) {
            bool back_value = false;
            if (borrow_count <= 0) {
                return back_value;
            }
            if (book_is_exsit(book_id_in) && borrow_count <= get_book_count(book_id_in)) {
                //库存-borrow_count 加入借阅列表
                for (int i = 0; i < borrow_count; i++) {
                    add_book_to_borrow_list(book_id_in, who);
                    renew_book_count(book_id_in, get_book_count(book_id_in) - 1);
                }
                back_value = true;
            }
            return back_value;
        }

        public void renew_book_name(string book_id_in, string book_name_in) 
        {
            //更新书名
            string str_sql = "update bookos_book set book_name=";
            str_sql += "\"";
            str_sql += book_name_in.ToString();
            str_sql += "\"";
            str_sql += " where book_id =";
            str_sql += "\"";
            str_sql += book_id_in;
            str_sql += "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            cmd.ExecuteNonQuery();
            this.con.Close();
        }

        public void renew_book_author(string book_id_in, string book_author_in)
        {
            //更新作者
            string str_sql = "update bookos_book set book_author=";
            str_sql += "\"";
            str_sql += book_author_in.ToString();
            str_sql += "\"";
            str_sql += " where book_id =";
            str_sql += "\"";
            str_sql += book_id_in;
            str_sql += "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            cmd.ExecuteNonQuery();
            this.con.Close();
        }

        public void renew_book_count(string book_id_in, int book_count_in)
        {
            //更新库存
            string str_sql = "update bookos_book set book_count=";
            str_sql += book_count_in.ToString();
            str_sql += " where book_id =";
            str_sql += "\"";
            str_sql += book_id_in;
            str_sql += "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            cmd.ExecuteNonQuery();
            this.con.Close();
        }

        public ArrayList get_borrow_list(int read_type, string user_id_in = "") {
            ArrayList back_list = new ArrayList();
            string str_sql = "";
            if (read_type == 0) {
                //查看全部
                str_sql = "select * from bookos_borrow";
            }
            if (read_type == 1) {
                //查看指定用户
                str_sql = "select * from bookos_borrow where book_owner=";
                str_sql += "\"";
                str_sql += user_id_in;
                str_sql += "\"";
            }
            
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            while (result.Read())
            {
                back_list.Add(result.GetString("book_id"));
            }
            this.con.Close();
            return back_list;
        }

        public string get_borrow_id(string book_id_in) {
            string back_value = "";
            string str_sql = "select * from bookos_borrow where book_id=" + "\"" + book_id_in + "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                back_value = result.GetString("id");
            }
            this.con.Close();
            return back_value;
        }

        public void return_book(string tips_in, string book_id_in) {
            //归还流程:从借阅列表删除该书 书库库存+1
            string str_sql = "delete from bookos_borrow where id = ";
            str_sql += "\"";
            str_sql += tips_in;
            str_sql += "\"";
            MySqlCommand cmd = new MySqlCommand(str_sql, this.con);
            this.con.Open();
            cmd.ExecuteNonQuery();
            this.con.Close();

            renew_book_count(book_id_in, get_book_count(book_id_in) + 1);
        }
    }
}
