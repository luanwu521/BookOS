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
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
        }

        private void button_renew_book_list_Click(object sender, EventArgs e)
        {
            operate op = new operate();
            ArrayList arr_book = new ArrayList();
            arr_book = op.get_book();
            while (dataGridView_book_list.Rows.Count != 0)
            {
                dataGridView_book_list.Rows.RemoveAt(0);
            }

            for (int i = 0; i < arr_book.Count; i++)
            {
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

        private void button_remove_book_Click(object sender, EventArgs e)
        {
            int remove_count = 0;
            operate op = new operate();
            foreach (DataGridViewRow select_row in dataGridView_book_list.SelectedRows)
            {
                if (op.remove_book(select_row.Cells["book_id"].Value.ToString()))
                {
                    remove_count++;
                }
            }
            MessageBox.Show("成功删除图书:" + remove_count.ToString() + "本!");
            
        }

        private void button_add_book_Click(object sender, EventArgs e)
        {
            Form form_addbook = new Form_add_book();
            form_addbook.Show();
        }
    
        private void button_exit_system_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_change_book_information_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            foreach (DataGridViewRow select_row in dataGridView_book_list.SelectedRows)
            {
                Book_node add_node = new Book_node();
                add_node.book_id = select_row.Cells["book_id"].Value.ToString();
                add_node.book_name = select_row.Cells["book_name"].Value.ToString();
                add_node.book_author = select_row.Cells["book_author"].Value.ToString();
                add_node.book_count = Convert.ToInt32(select_row.Cells["book_count"].Value);
                arr.Add(add_node);
            }
            Form form_change = new Form_change_info(arr);
            form_change.Show();
        }
    }
}
