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
    public partial class Form_add_book : Form
    {
        public Form_add_book()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            operate op = new operate();
            Book_node book = new Book_node();
            book.book_id = textBox_book_id.Text;
            book.book_name = textBox_book_name.Text;
            book.book_author = textBox_book_author.Text;
            book.book_count = Convert.ToInt32(textBox_book_count.Text);
            
            if (!op.book_is_exsit(book.book_id))
            {
                if (op.add_book(book))
                {
                    MessageBox.Show("添加成功");
                    textBox_book_id.Text = "";
                    textBox_book_name.Text = "";
                    textBox_book_author.Text = "";
                    textBox_book_count.Text = "";
                }
                else {
                    MessageBox.Show("添加失败");
                }
            }
            else {
                MessageBox.Show("图书已存在");
            }
        }

        private void textBox_book_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)

            {
                e.Handled = true;
            }
        }
    }
}
