using System;
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
    public partial class Form_borrow : Form
    {
        public string user_id;
        public Form_borrow(string user_id_in)
        {
            InitializeComponent();
            this.user_id = user_id_in;
        }

        private void button_renew_list_Click(object sender, EventArgs e)
        {
            operate op = new operate();
            while (dataGridView_book_list.Rows.Count != 0)
            {
                dataGridView_book_list.Rows.RemoveAt(0);
            }
            foreach (string book_id in op.get_borrow_list(1, this.user_id)) {
                dataGridView_book_list.Rows.Add(op.get_borrow_id(book_id), book_id, op.get_book_name(book_id));
                
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            operate op = new operate();
            foreach (DataGridViewRow select_row in dataGridView_book_list.SelectedRows)
            {
                string id = select_row.Cells["id"].Value.ToString();
                string book_id = select_row.Cells["book_id"].Value.ToString();
                op.return_book(id, book_id);
            }
            MessageBox.Show("归还完毕");
        }
    }
}
