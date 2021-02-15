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
    public partial class Form_change_info : Form
    {
        ArrayList wait_change_list = new ArrayList();
        public Form_change_info(ArrayList arr)
        {
            InitializeComponent();
            wait_change_list = arr;
            while (dataGridView_book_list.Rows.Count != 0)
            {
                dataGridView_book_list.Rows.RemoveAt(0);
            }
            for (int i = 0; i < wait_change_list.Count; i++)
            {
                Book_node node = (Book_node)wait_change_list[i];
                dataGridView_book_list.Rows.Add(
                    i.ToString(),
                    node.book_id,
                    node.book_name,
                    node.book_author,
                    node.book_count.ToString()
                );
            }
            dataGridView_book_list.ReadOnly = false;
            dataGridView_book_list.EditMode = DataGridViewEditMode.EditOnEnter;
        }


        private void dataGridView_book_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView_book_list.CurrentCellAddress.X != 1 && dataGridView_book_list.CurrentCellAddress.X != 0) {
                dataGridView_book_list.CurrentCell.ReadOnly = false;
            }
            //防止修改唯一标识id
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            operate op = new operate();
            
            foreach (DataGridViewRow select_row in dataGridView_book_list.Rows)
            {
                op.renew_book_name(select_row.Cells["book_id"].Value.ToString(), select_row.Cells["book_name"].Value.ToString());
                op.renew_book_author(select_row.Cells["book_id"].Value.ToString(), select_row.Cells["book_author"].Value.ToString());
                op.renew_book_count(select_row.Cells["book_id"].Value.ToString(), Convert.ToInt32(select_row.Cells["book_count"].Value));
            }
            MessageBox.Show("修改完毕");
            this.Close();
        }
    }
}
