using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOS
{
    public partial class Form_main : Form
    {
        public string login_user_id;
        public int login_user_type;
        public Form_main(string user_id_in, int user_type_in)
        {
            InitializeComponent();
            this.login_user_id = user_id_in;
            this.login_user_type = user_type_in;
        }

        private void button_renew_book_list_Click(object sender, EventArgs e)
        {
            operate usop = new operate();
            ArrayList arr_book = new ArrayList();
            arr_book = usop.get_book();
            while (dataGridView_book_list.Rows.Count != 0) {
                dataGridView_book_list.Rows.RemoveAt(0);
            }
            
            for (int i = 0; i < arr_book.Count; i++) {
                Book_node node = (Book_node)arr_book[i];
                dataGridView_book_list.Rows.Add(
                    i.ToString(),
                    node.book_id,
                    node.book_name,
                    node.book_author,
                    node.book_count.ToString()
                );
            }
        }

        private void button_borrow_select_book_Click(object sender, EventArgs e)
        {
            operate op = new operate();
            string news = "";
            foreach (DataGridViewRow select_row in dataGridView_book_list.SelectedRows)
            {
                string book_id = select_row.Cells["book_id"].Value.ToString();
                if (op.borrow_book(book_id, 1, login_user_id))
                {
                    news += book_id + "\n";
                }
            }
            MessageBox.Show("成功借阅:\n" + news);
        }

        private void button_exit_system_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_read_now_borrow_Click(object sender, EventArgs e)
        {
            Form form_borrow = new Form_borrow(login_user_id);
            form_borrow.Show();
        }
    }
}
